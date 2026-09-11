using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Broiler.Native;
using Broiler.Native.Android;
using Broiler.Native.Linux.Input;
using Broiler.Native.Windows;
using Broiler.Native.Windows.Direct2D;
using Broiler.Native.Windows.Wasapi;
using Broiler.Native.Windows.Input;
using Broiler.Native.Windows.MediaFoundation.MediaEngine;
using Broiler.Native.Windows.MediaFoundation;
using Broiler.Native.Windows.MediaFoundation.Capture;
using static Broiler.Native.Windows.Wic.WicNative;

var tests = new (string Name, Action Run)[]
{
    ("Windows COM interface IDs have one public contract", () =>
    {
        var duplicateIds = typeof(ComNative).Assembly.GetExportedTypes()
            .Where(type => type.IsInterface && type.GetCustomAttribute<GuidAttribute>() is not null)
            .GroupBy(type => type.GUID).Where(group => group.Count() > 1);
        Check(!duplicateIds.Any(), "Duplicate COM interface declarations: " +
            string.Join(", ", duplicateIds.SelectMany(group => group.Select(type => type.FullName))));
        Check(typeof(IMFActivate).GetInterfaces().Contains(typeof(IMFAttributes)), "Capture must use shared attributes.");
        Check(typeof(IMFMediaEngineClassFactory).GetMethod("CreateInstance")!.GetParameters()[1].ParameterType == typeof(IMFAttributes),
            "Playback must use the same attribute contract as capture.");
    }),
    ("Shared Windows imports have one owner", () =>
    {
        var methods = typeof(ComNative).Assembly.GetExportedTypes()
            .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
            .Where(method => method.GetCustomAttribute<LibraryImportAttribute>() is not null ||
                method.GetCustomAttribute<DllImportAttribute>() is not null).ToArray();
        foreach (string name in new[] { "CoInitializeEx", "CoUninitialize", "CoTaskMemFree", "MFStartup", "MFShutdown",
            "GetKeyState", "ScreenToClient", "TrackMouseEvent" })
            Check(methods.Count(method => method.Name == name) == 1, name + " must have one import.");
        Check(methods.Count(method => method.Name == "CoCreateInstance") == 3, "Keep all three COM activation marshalling overloads.");
        Check(methods.Count(method => method.Name == "MFCreateAttributes") == 2, "Keep raw and typed attribute creation overloads.");
        foreach (string name in new[] { "CreateDeviceContextProc", "SetTargetProc", "CreateTextFormatProc", "POINT", "TRACKMOUSEEVENT" })
            Check(typeof(ComNative).Assembly.GetExportedTypes().Count(type => type.Name == name) == 1, name + " must have one declaration.");
    }),
    ("Shared COM and Media Foundation overloads preserve runtime marshalling", () =>
    {
        if (!OperatingSystem.IsWindows()) return;
        int initialized = ComNative.CoInitializeEx(IntPtr.Zero, ComNative.COINIT_MULTITHREADED);
        Check(initialized >= 0 || initialized == ComNative.RPC_E_CHANGED_MODE, "COM initialization failed.");
        try
        {
            Guid clsid = ClsidWicImagingFactory;
            Guid iid = IidWicImagingFactory;
            Marshal.ThrowExceptionForHR(ComNative.CoCreateInstance(ref clsid, IntPtr.Zero, ComNative.CLSCTX_INPROC_SERVER, ref iid, out IntPtr rawFactory));
            ComNative.ReleaseIUnknown(rawFactory);
            Marshal.ThrowExceptionForHR(ComNative.CoCreateInstance(ref clsid, IntPtr.Zero, ComNative.CLSCTX_INPROC_SERVER, ref iid, out object? objectFactory));
            ComNative.ReleaseComObject(objectFactory);
            Marshal.ThrowExceptionForHR(ComNative.CoCreateInstance(ref clsid, IntPtr.Zero, ComNative.CLSCTX_INPROC_SERVER, ref iid, out IWICImagingFactory typedFactory));
            ComNative.ReleaseComObject(typedFactory);

            Marshal.ThrowExceptionForHR(MediaFoundationPlatformNative.MFStartup(MediaFoundationPlatformNative.MF_VERSION, MediaFoundationPlatformNative.MFSTARTUP_NOSOCKET));
            try
            {
                Marshal.ThrowExceptionForHR(MediaFoundationPlatformNative.MFCreateAttributes(out IMFAttributes typed, 1));
                try
                {
                    Guid key = Guid.NewGuid();
                    Marshal.ThrowExceptionForHR(typed.SetUINT32(ref key, 42));
                    Marshal.ThrowExceptionForHR(typed.GetUINT32(ref key, out int value));
                    Check(value == 42, "Shared attribute vtable failed to round-trip a value.");
                }
                finally { ComNative.ReleaseComObject(typed); }
                Marshal.ThrowExceptionForHR(MediaFoundationPlatformNative.MFCreateAttributes(out IntPtr raw, 1));
                try
                {
                    var attributes = (IMFAttributes)Marshal.GetObjectForIUnknown(raw);
                    try
                    {
                        Marshal.ThrowExceptionForHR(attributes.GetCount(out int count));
                        Check(count == 0, "Raw attribute creation should return an empty shared contract.");
                    }
                    finally { ComNative.ReleaseComObject(attributes); }
                }
                finally { ComNative.ReleaseIUnknown(raw); }
            }
            finally { Marshal.ThrowExceptionForHR(MediaFoundationPlatformNative.MFShutdown()); }
        }
        finally { if (initialized >= 0) ComNative.CoUninitialize(); }
    }),
    ("Native assemblies have no component dependencies", () =>
    {
        Assembly[] assemblies = [typeof(NativeLibraryProbe).Assembly, typeof(WindowNative).Assembly,
            typeof(LinuxNativeMethods).Assembly, typeof(AndroidEglNative).Assembly];
        foreach (Assembly assembly in assemblies)
            Check(!assembly.GetReferencedAssemblies().Any(reference =>
                reference.Name!.StartsWith("Broiler.", StringComparison.Ordinal) &&
                reference.Name != "Broiler.Native" &&
                !reference.Name.StartsWith("Broiler.Native.", StringComparison.Ordinal)), assembly.FullName!);
    }),
    ("Native ABI layouts survive assembly extraction", () =>
    {
        Size<WindowNative.RECT>(16);
        Size<WindowNative.WNDCLASSEX>(IntPtr.Size == 8 ? 80 : 48);
        Size<WindowNative.BITMAPINFOHEADER>(40);
        Size<RawInputReaderNative.RawInputHeader>(IntPtr.Size == 8 ? 24 : 16);
        Size<RawInputRegistrationNative.RawInputDevice>(IntPtr.Size == 8 ? 16 : 12);
        Size<WaveFormatEx>(18);
        Size<WaveFormatExtensible>(40);
        Size<D2DNative.D2D1_MATRIX_3X2_F>(24);
        Size<DWriteNative.DWRITE_TEXT_METRICS>(36);
        Size<LinuxNativeMethods.PollFd>(8);
    }),
    ("Media Engine callback remains visible to COM", () =>
    {
        Type callback = typeof(IMFMediaEngineNotify);
        Check(callback.IsPublic, "The runtime must expose the callback to QueryInterface.");
        Check(callback.GetCustomAttribute<ComVisibleAttribute>()?.Value == true, "ComVisible must remain enabled.");
        Check(callback.GUID == new Guid("FEE7C112-E776-42B5-9BBF-0048524E2BD5"), "Callback IID changed.");
        Check(callback.GetMethod("EventNotify")!.GetCustomAttribute<PreserveSigAttribute>() is not null,
            "Callback must return its HRESULT without translation.");
    }),
    ("Android imports and their resolver share an assembly", () =>
    {
        Check(typeof(AndroidNativeLibraries).Assembly == typeof(AndroidGlesNative).Assembly,
            "A resolver only applies to imports in its own assembly.");
        AndroidNativeLibraries.EnsureRegistered();
        AndroidNativeLibraries.EnsureRegistered();
        var import = typeof(AndroidGlesNative).GetMethod("BlitFramebuffer")!.GetCustomAttribute<DllImportAttribute>();
        Check(import?.EntryPoint == "glBlitFramebuffer" && import.Value == AndroidNativeLibraries.Gles,
            "ES 3 entry point or resolver import name changed.");
    }),
    ("Missing native libraries are reported without throwing", () =>
    {
        Check(!NativeLibraryProbe.IsAvailable("broiler-library-that-does-not-exist-91f5"), "Unexpected library loaded.");
        Check(!NativeLibraryProbe.IsAvailable(" "), "Empty names must be unavailable.");
    }),
    ("Host native calls execute through the extracted assembly", () =>
    {
        if (OperatingSystem.IsWindows())
        {
            Check(NativeLibraryProbe.IsAvailable("kernel32.dll"), "kernel32 probe failed.");
            Check(PerformanceCounterNative.QueryPerformanceFrequency(out long frequency) && frequency > 0, "QPC frequency failed.");
            Check(PerformanceCounterNative.QueryPerformanceCounter(out _), "QPC failed.");
            Check(!HwndNative.IsWindow(IntPtr.Zero), "NULL cannot be a window.");
        }
        else if (OperatingSystem.IsLinux())
        {
            Check(NativeLibraryProbe.IsAvailable("libc.so.6"), "libc probe failed.");
            Check(LinuxNativeMethods.Poll([], 0, 0) == 0, "Empty poll should time out immediately.");
        }
    }),
};

int failed = 0;
foreach (var test in tests)
{
    try { test.Run(); Console.WriteLine("PASS " + test.Name); }
    catch (Exception exception) { failed++; Console.WriteLine("FAIL " + test.Name + ": " + exception.Message); }
}
Console.WriteLine($"{tests.Length - failed}/{tests.Length} passed, {failed} failed.");
return failed;

static void Check(bool condition, string message)
{
    if (!condition) throw new InvalidOperationException(message);
}

static void Size<T>(int expected) where T : struct =>
    Check(Marshal.SizeOf<T>() == expected, $"{typeof(T).FullName}: expected ABI size {expected}, got {Marshal.SizeOf<T>()}.");
