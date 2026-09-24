# End-User and Consumer Guide

`Broiler.Native` provides high-performance, zero-allocation, NativeAOT-ready .NET 10 interop bindings for operating-system and hardware graphics, audio, input, and windowing APIs across Windows, Linux, and Android.

This guide is designed for developers consuming `Broiler.Native` directly in applications or through higher-level libraries such as `Broiler.Graphics`, `Broiler.Input`, and `Broiler.Media`.

---

## Package Overview

| Package | Target OS | Key Functionality |
| :--- | :--- | :--- |
| **`Broiler.Native`** | Any (.NET 10) | Lightweight core containing `NativeLibraryProbe` for non-throwing dynamic library availability checks. Zero external dependencies. |
| **`Broiler.Native.Windows`** | Windows (`net10.0`) | Win32 Windowing, Message Loop, Raw Input, Performance Counters, COM & `ComPtr<T>`, Direct2D, DirectWrite, DXGI, Direct3D 11, WIC (Windows Imaging Component), WASAPI audio, Media Foundation capture and playback. |
| **`Broiler.Native.Linux`** | Linux (`net10.0`) | libc/evdev input, `poll`, X11, EGL, OpenGL dynamic function loading, OpenGL driver diagnostic queries, Vulkan instance and physical device enumeration. |
| **`Broiler.Native.Android`** | Android (`net10.0`) | EGL, OpenGL ES 2.0 / 3.0, `ANativeWindow`, and an automated assembly-scoped `DllImportResolver` handling device-specific library sonames (`libEGL.so`, `libGLESv3.so`, `libGLESv2.so`, `libandroid.so`). |
| **`Broiler.Native.All`** | Any (.NET 10) | Metapackage referencing all platform packages for multi-target or cross-platform codebases. |

### Installing via NuGet

Install the package suited to your target deployment:

```sh
# Core runtime probing only:
dotnet add package Broiler.Native

# Platform-specific packages:
dotnet add package Broiler.Native.Windows
dotnet add package Broiler.Native.Linux
dotnet add package Broiler.Native.Android

# Or all platforms at once:
dotnet add package Broiler.Native.All
```

> [!NOTE]
> All packages target plain `net10.0` rather than platform-specific target framework monikers (such as `net10.0-windows` or `net10.0-android`). This allows cross-platform libraries to reference platform packages unconditionally and choose native backends dynamically at runtime.

---

## Runtime Requirements & Host Prerequisites

Referencing a platform package does **not** load native libraries until an entry point in that library is called. Always verify the host platform and library presence before invoking platform APIs.

| Platform | Host Requirements |
| :--- | :--- |
| **Windows** | Windows 10 (version 1809+) or Windows 11 (x64, arm64). No C++ desktop workload or Windows SDK required at runtime. Standard OS system DLLs (`kernel32.dll`, `user32.dll`, `gdi32.dll`, `d2d1.dll`, `dwrite.dll`, `dxgi.dll`, `d3d11.dll`, `windowscodecs.dll`, `mfplat.dll`, `mf.dll`). |
| **Linux** | Linux kernel 4.19+ with glibc 2.28+ (x86_64, aarch64). Required shared objects depend on features invoked: `libc.so.6`, `libX11.so.6` (X11), `libEGL.so.1` (EGL), `libGL.so.1` (OpenGL), `libvulkan.so.1` (Vulkan). |
| **Android** | Android API 21+ (64-bit ARM / x86_64). OpenGL ES 3.0 requires Android API 18+. Standard Android NDK shared objects (`libEGL.so`, `libGLESv3.so` or `libGLESv2.so`, `libandroid.so`). |

---

## Safe Invocation Pattern: Probing

To write robust cross-platform applications, avoid unguarded calls that could raise `DllNotFoundException` or `EntryPointNotFoundException`. Use `OperatingSystem` checks combined with `NativeLibraryProbe.IsAvailable`:

```csharp
using System;
using Broiler.Native;
using Broiler.Native.Windows;
using Broiler.Native.Linux.OpenGL;

if (OperatingSystem.IsWindows())
{
    if (NativeLibraryProbe.IsAvailable("d2d1.dll"))
    {
        Console.WriteLine("Direct2D is supported on this Windows host.");
    }
}
else if (OperatingSystem.IsLinux())
{
    if (NativeLibraryProbe.IsAvailable("libvulkan.so.1"))
    {
        Console.WriteLine("Vulkan loader found on this Linux host.");
    }
}
```

`NativeLibraryProbe.IsAvailable` attempts to load the named library via `NativeLibrary.TryLoad` and immediately frees the handle upon success without retaining any references or throwing exceptions.

---

## Subsystem Guides & Code Examples

### 1. Windows Windowing & Message Loop (`Broiler.Native.Windows`)

`WindowNative` exposes Win32 window management, HiDPI awareness, cursor/icon loading, and standard message loop dispatching.

```csharp
using System;
using System.Runtime.InteropServices;
using Broiler.Native.Windows;

// 1. Enable per-monitor DPI awareness (v2)
WindowNative.SetProcessDpiAwarenessContext(new IntPtr(-4)); // DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2

// 2. Define a Window Procedure delegate
WindowNative.WndProc wndProc = (hwnd, msg, wParam, lParam) =>
{
    switch (msg)
    {
        case WindowNative.WmDestroy:
            WindowNative.PostQuitMessage(0);
            return IntPtr.Zero;
        case WindowNative.WmPaint:
            // Custom render invocation
            break;
    }
    return WindowNative.DefWindowProc(hwnd, msg, wParam, lParam);
};

// 3. Register window class
var wc = new WindowNative.WNDCLASSEX
{
    CbSize = (uint)Marshal.SizeOf<WindowNative.WNDCLASSEX>(),
    Style = WindowNative.CsHRedraw | WindowNative.CsVRedraw,
    LpfnWndProc = wndProc,
    HInstance = WindowNative.GetModuleHandle(null),
    HCursor = WindowNative.LoadCursor(IntPtr.Zero, (IntPtr)32512), // IDC_ARROW
    LpszClassName = "BroilerAppClass"
};
WindowNative.RegisterClassEx(ref wc);

// 4. Create and show window
IntPtr hwnd = WindowNative.CreateWindowEx(
    0,
    "BroilerAppClass",
    "Broiler Native Window",
    WindowNative.WsOverlappedWindow | WindowNative.WsVisible,
    WindowNative.CwUseDefault, WindowNative.CwUseDefault,
    800, 600,
    IntPtr.Zero, IntPtr.Zero, wc.HInstance, IntPtr.Zero);

// 5. Standard message pump
while (WindowNative.GetMessage(out WindowNative.MSG msg, IntPtr.Zero, 0, 0) > 0)
{
    WindowNative.TranslateMessage(ref msg);
    WindowNative.DispatchMessage(ref msg);
}
```

### 2. High-Precision Timing (`Broiler.Native.Windows`)

Access the hardware performance counter directly:

```csharp
using Broiler.Native.Windows;

if (PerformanceCounterNative.QueryPerformanceFrequency(out long frequency))
{
    PerformanceCounterNative.QueryPerformanceCounter(out long start);
    // Workload here
    PerformanceCounterNative.QueryPerformanceCounter(out long end);

    double elapsedSeconds = (double)(end - start) / frequency;
}
```

### 3. COM Interoperability & Memory Safety (`Broiler.Native.Windows`)

`Broiler.Native.Windows` uses modern .NET source-generated COM interfaces (`[GeneratedComInterface]`) compatible with NativeAOT:

```csharp
using System;
using System.Runtime.InteropServices;
using Broiler.Native.Windows;
using Broiler.Native.Windows.Wic;

// Initialize COM on current thread
int hr = ComNative.CoInitializeEx(IntPtr.Zero, ComNative.COINIT_MULTITHREADED);
Marshal.ThrowExceptionForHR(hr);

try
{
    Guid clsid = WicNative.ClsidWicImagingFactory;
    Guid iid = WicNative.IidWicImagingFactory;

    // Activate typed source-generated COM interface
    hr = ComNative.CoCreateInstance(in clsid, IntPtr.Zero, ComNative.CLSCTX_INPROC_SERVER, in iid, out WicNative.IWICImagingFactory factory);
    Marshal.ThrowExceptionForHR(hr);

    try
    {
        // Use factory...
    }
    finally
    {
        // Explicitly release source-generated COM wrappers
        ComNative.ReleaseComObject(factory);
    }
}
finally
{
    ComNative.CoUninitialize();
}
```

### 4. Linux Evdev Input & Polling (`Broiler.Native.Linux`)

`LinuxNativeMethods` provides low-level Linux POSIX and evdev system calls:

```csharp
using System;
using Broiler.Native.Linux.Input;

int fd = LinuxNativeMethods.Open("/dev/input/event0", LinuxNativeMethods.O_RDONLY | LinuxNativeMethods.O_NONBLOCK);
if (fd >= 0)
{
    try
    {
        // Set event clock to CLOCK_MONOTONIC for accurate timestamping
        LinuxNativeMethods.TrySetMonotonicClock(fd);

        // Read absolute axis limits for touchscreen/touchpad normalization
        if (LinuxNativeMethods.TryGetAbsInfo(fd, 0x00 /* ABS_X */, out int minX, out int maxX, out int resX))
        {
            Console.WriteLine($"X Axis Range: [{minX}, {maxX}] resolution: {resX}");
        }

        // Poll for input events
        var fds = new LinuxNativeMethods.PollFd[]
        {
            new() { Fd = fd, Events = LinuxNativeMethods.POLLIN }
        };

        int ready = LinuxNativeMethods.Poll(fds, 1, 10 /* timeout ms */);
        if (ready > 0 && (fds[0].Revents & LinuxNativeMethods.POLLIN) != 0)
        {
            byte[] buffer = new byte[64];
            nint bytesRead = LinuxNativeMethods.Read(fd, buffer, (nuint)buffer.Length);
            // Process raw input_event structures
        }
    }
    finally
    {
        // Close file descriptor via libc
    }
}
```

### 5. Linux Vulkan & OpenGL Driver Diagnostics (`Broiler.Native.Linux`)

Enumerate physical devices and OpenGL driver details without pulling in heavy graphics framework layers:

```csharp
using System;
using Broiler.Native.Linux.Vulkan;
using Broiler.Native.Linux.OpenGL;

// Vulkan enumeration
var devices = LinuxVulkanDeviceInfo.Enumerate();
foreach (var device in devices)
{
    Console.WriteLine($"Found Vulkan device: {device.DeviceName} ({device.DeviceType}) Driver: {device.DriverVersion}");
}

// OpenGL driver query
var glInfo = LinuxOpenGlDriverInfo.Query();
Console.WriteLine($"GL Renderer: {glInfo.Renderer}, Vendor: {glInfo.Vendor}, Version: {glInfo.Version}");
```

### 6. Android Dynamic Library Loading (`Broiler.Native.Android`)

Android distributions and device manufacturers often vary the installed soname for graphics libraries (e.g. `libEGL.so.1` vs `libEGL.so`, or exposing GLES 3 via `libGLESv2.so`).

Call `AndroidNativeLibraries.EnsureRegistered()` once during application startup. It installs an assembly-scoped `DllImportResolver` that automatically probes candidate names:

```csharp
using Broiler.Native.Android;

// Install resolver early before any EGL or GLES calls
AndroidNativeLibraries.EnsureRegistered();

// Safe call to Android EGL/GLES
IntPtr display = AndroidEglNative.eglGetDisplay(IntPtr.Zero);
```

---

## NativeAOT and Trimming Support

All packages in `Broiler.Native` are built with `<IsAotCompatible>true</IsAotCompatible>`:

- **Zero Reflection-Based Marshalling**: Built-in runtime COM marshalling is replaced with compile-time source-generated COM wrappers (`[GeneratedComInterface]`).
- **Exact ABI Struct Layouts**: Every unmanaged struct uses explicit sequential layouts and verified byte sizes.
- **Trimmable**: Unused platform assemblies and symbols can be stripped by the .NET IL trimmer without runtime breakage.

When compiling an application with NativeAOT:
```sh
dotnet publish -c Release -r win-x64 /p:PublishAot=true
```
`Broiler.Native` assemblies will publish with zero trim warnings or AOT compatibility errors.

---

## Dependency Guidance for Broiler Consumers

- If you are building a component in the `Broiler-Platform` ecosystem (e.g. `Broiler.Graphics`, `Broiler.Input`, `Broiler.Media`), declare your dependency on `Broiler.Native.*` in `Directory.Packages.props`.
- In a sibling local checkout scenario, consumer builds can map to project references using `BroilerNativeRoot`.
- Standalone builds automatically restore the packages from [NuGet.org](https://www.nuget.org/packages?q=Broiler.Native).
