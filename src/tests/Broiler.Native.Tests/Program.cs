using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
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
using Broiler.Native.Windows.Wic;

[UnconditionalSuppressMessage("Trimming", "IL2026:RequiresUnreferencedCode", Justification = "Test suite reflection")]
[UnconditionalSuppressMessage("Trimming", "IL2070", Justification = "Test suite reflection")]
[UnconditionalSuppressMessage("Trimming", "IL2050", Justification = "Test of COM runtime marshalling fallback")]
internal class Program
{
    private static int Main(string[] args)
    {
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
                var exportedTypes = typeof(ComNative).Assembly.GetExportedTypes();
                var allMethods = exportedTypes
                    .SelectMany(type => type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
                    .ToArray();
                if (allMethods.Length > 0)
                {
                    foreach (string name in new[] { "CoInitializeEx", "CoUninitialize", "CoTaskMemFree", "MFStartup", "MFShutdown", "GetKeyState", "ScreenToClient", "TrackMouseEvent" })
                        Check(allMethods.Count(method => method.Name == name) == 1, name + " must have one import.");

                    Check(allMethods.Count(method => method.Name == "CoCreateInstance") == 3, "Keep all three COM activation marshalling overloads.");
                    Check(allMethods.Count(method => method.Name == "MFCreateAttributes") == 2, "Keep raw and typed attribute creation overloads.");
                }

                foreach (string name in new[] { "CreateDeviceContextProc", "SetTargetProc", "CreateTextFormatProc", "POINT", "TRACKMOUSEEVENT" })
                {
                    int count = exportedTypes.Count(type => type.Name == name);
                    Check(count <= 1, name + " must not have duplicate declarations.");
                    if (allMethods.Length > 0)
                        Check(count == 1, name + " must have one declaration.");
                }
            }),

            ("Shared COM and Media Foundation overloads preserve runtime marshalling", () =>
            {
                if (!OperatingSystem.IsWindows()) return;
                int initialized = ComNative.CoInitializeEx(nint.Zero, ComNative.COINIT_MULTITHREADED);

                Check(initialized >= 0 || initialized == ComNative.RPC_E_CHANGED_MODE, "COM initialization failed.");

                try
                {
                    Guid clsid = WicNative.ClsidWicImagingFactory;
                    Guid iid = WicNative.IidWicImagingFactory;

                    Marshal.ThrowExceptionForHR(ComNative.CoCreateInstance(in clsid, nint.Zero, ComNative.CLSCTX_INPROC_SERVER, in iid, out nint rawFactory));
                    ComNative.ReleaseIUnknown(rawFactory);

                    try
                    {
                        Marshal.ThrowExceptionForHR(ComNative.CoCreateInstance(ref clsid, nint.Zero, ComNative.CLSCTX_INPROC_SERVER, ref iid, out object? objectFactory));
                        ComNative.ReleaseComObject(objectFactory);
                    }
                    catch (NotSupportedException)
                    {
                        // Built-in COM runtime marshalling is not supported on NativeAOT.
                    }

                    Marshal.ThrowExceptionForHR(ComNative.CoCreateInstance(in clsid, nint.Zero, ComNative.CLSCTX_INPROC_SERVER, in iid, out WicNative.IWICImagingFactory typedFactory));
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

                        Marshal.ThrowExceptionForHR(MediaFoundationPlatformNative.MFCreateAttributes(out nint raw, 1));
                        try
                        {
                            var attributes = ComNative.GetOrCreateComObject<IMFAttributes>(raw)!;
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
                try
                {
                    Assembly[] assemblies = [typeof(NativeLibraryProbe).Assembly, typeof(WindowNative).Assembly,
                        typeof(LinuxNativeMethods).Assembly, typeof(AndroidEglNative).Assembly];
                    foreach (Assembly assembly in assemblies)
                        Check(!assembly.GetReferencedAssemblies().Any(reference =>
                            reference.Name!.StartsWith("Broiler.", StringComparison.Ordinal) &&
                            reference.Name != "Broiler.Native" &&
                            !reference.Name.StartsWith("Broiler.Native.", StringComparison.Ordinal)), assembly.FullName!);
                }
                catch (PlatformNotSupportedException)
                {
                    // Assembly.GetReferencedAssemblies is not supported under NativeAOT.
                }
            }),

            ("Native ABI layouts survive assembly extraction", () =>
            {
                Size<WindowNative.RECT>(16);
                Size<WindowNative.WNDCLASSEX>(nint.Size == 8 ? 80 : 48);
                Size<WindowNative.BITMAPINFOHEADER>(40);
                Size<RawInputReaderNative.RawInputHeader>(nint.Size == 8 ? 24 : 16);
                Size<RawInputRegistrationNative.RawInputDevice>(nint.Size == 8 ? 16 : 12);
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
                Check(callback.GetCustomAttribute<GeneratedComInterfaceAttribute>() is not null, "GeneratedComInterface must remain enabled.");
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
                var import = typeof(AndroidGlesNative).GetMethod("BlitFramebuffer")?.GetCustomAttribute<DllImportAttribute>();
                if (import is not null)
                {
                    Check(import.EntryPoint == "glBlitFramebuffer" && import.Value == AndroidNativeLibraries.Gles,
                        "ES 3 entry point or resolver import name changed.");
                }
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
                    Check(!HwndNative.IsWindow(nint.Zero), "NULL cannot be a window.");
                    Check(WindowNative.LoadIcon(nint.Zero, WindowNative.IdiApplication) != nint.Zero, "The stock application icon must load.");
                    Check(WindowNative.GetClassLongPtr(nint.Zero, WindowNative.GclpHIcon) == nint.Zero, "NULL cannot have a class icon.");
                }
                else if (OperatingSystem.IsLinux())
                {
                    Check(NativeLibraryProbe.IsAvailable("libc.so.6"), "libc probe failed.");
                    Check(LinuxNativeMethods.Poll([], 0, 0) == 0, "Empty poll should time out immediately.");
                }
            }),

            ("Source-generated COM interfaces function correctly under NativeAOT", () =>
            {
                if (!OperatingSystem.IsWindows()) return;
                int initialized = ComNative.CoInitializeEx(nint.Zero, ComNative.COINIT_MULTITHREADED);
                Check(initialized >= 0 || initialized == ComNative.RPC_E_CHANGED_MODE, "COM initialization failed.");
                try
                {
                    // 1. Verify IStream source-generated COM
                    int hr = ComNative.CreateStreamOnHGlobal(nint.Zero, true, out IStream stream);
                    Check(hr == 0 && stream != null, "CreateStreamOnHGlobal failed.");
                    try
                    {
                        byte[] testData = [1, 2, 3, 4, 5];
                        unsafe
                        {
                            fixed (byte* pData = testData)
                            {
                                Marshal.ThrowExceptionForHR(stream!.Write((nint)pData, (uint)testData.Length, out uint written));
                                Check(written == 5, "Stream write failed.");
                            }
                        }
                        Marshal.ThrowExceptionForHR(stream.Seek(0, 0, out _));
                        byte[] readBuffer = new byte[5];
                        unsafe
                        {
                            fixed (byte* pBuf = readBuffer)
                            {
                                Marshal.ThrowExceptionForHR(stream.Read((nint)pBuf, 5, out uint read));
                                Check(read == 5, "Stream read failed.");
                            }
                        }
                        Check(readBuffer.SequenceEqual(testData), "Stream data mismatch.");
                    }
                    finally
                    {
                        ComNative.ReleaseComObject(stream);
                    }

                    // 2. Verify WIC typed source-generated COM
                    Guid wicClsid = WicNative.ClsidWicImagingFactory;
                    Guid wicIid = WicNative.IidWicImagingFactory;
                    hr = ComNative.CoCreateInstance(in wicClsid, nint.Zero, ComNative.CLSCTX_INPROC_SERVER, in wicIid, out WicNative.IWICImagingFactory wicFactory);
                    Check(hr == 0 && wicFactory != null, "WIC factory creation failed.");
                    ComNative.ReleaseComObject(wicFactory);

                    // 3. Verify WASAPI source-generated COM
                    Guid wasapiClsid = WindowsWasapiNative.MMDeviceEnumeratorClassId;
                    Guid wasapiIid = WindowsWasapiNative.IMMDeviceEnumeratorId;
                    hr = ComNative.CoCreateInstance(in wasapiClsid, nint.Zero, ComNative.CLSCTX_INPROC_SERVER, in wasapiIid, out nint pEnumerator);
                    if (hr >= 0 && pEnumerator != nint.Zero)
                    {
                        try
                        {
                            var enumerator = ComNative.GetOrCreateComObject<IMMDeviceEnumerator>(pEnumerator);
                            Check(enumerator != null, "Failed to wrap IMMDeviceEnumerator via StrategyBasedComWrappers.");
                            hr = enumerator!.EnumAudioEndpoints(EDataFlow.Render, DeviceState.Active, out IMMDeviceCollection devices);
                            if (hr >= 0 && devices != null)
                            {
                                try
                                {
                                    hr = devices!.GetCount(out uint count);
                                    Check(hr >= 0, "devices.GetCount failed.");
                                }
                                finally
                                {
                                    ComNative.ReleaseComObject(devices);
                                }
                            }
                        }
                        finally
                        {
                            ComNative.ReleaseIUnknown(pEnumerator);
                        }
                    }
                }
                finally
                {
                    if (initialized >= 0) ComNative.CoUninitialize();
                }
            }),
        };

        int failed = 0;
        foreach (var (Name, Run) in tests)
        {
            try { Run(); Console.WriteLine("PASS " + Name); }
            catch (Exception exception) { failed++; Console.WriteLine("FAIL " + Name + ": " + exception); }
        }

        Console.WriteLine($"{tests.Length - failed}/{tests.Length} passed, {failed} failed.");
        return failed;

        static void Check(bool condition, string message)
        {
            if (!condition) throw new InvalidOperationException(message);
        }

        static void Size<T>(int expected) where T : struct =>
            Check(Marshal.SizeOf<T>() == expected, $"{typeof(T).FullName}: expected ABI size {expected}, got {Marshal.SizeOf<T>()}.");
    }
}