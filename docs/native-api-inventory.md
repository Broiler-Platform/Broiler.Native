# Native API extraction inventory

The canonical sibling Graphics, Input, and Media source trees were scanned for
P/Invoke, COM imports, generated COM contracts, unmanaged function declarations,
native layouts, function loading, and native library probing. Nested submodule
copies inside Graphics are separate checkouts and were not edited.

The following source files were moved or had their native declarations extracted.
Domain lifetime/error handling from mixed Media Foundation and WASAPI files stays
in `*Lifetime.cs` in the original component. DirectWrite font conversion stays in
Graphics. Associated native driver descriptions and native exceptions move here.

| Original source | Native destination |
| --- | --- |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Native/ComPtr.cs` | `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Native/ComVtable.cs` | `src/Broiler.Native.Windows/Direct2D/ComVtable.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Native/D2DNative.cs` | `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Native/D3D11Native.cs` | `src/Broiler.Native.Windows/Direct2D/D3D11Native.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Native/DWriteNative.cs` | `src/Broiler.Native.Windows/Direct2D/DWriteNative.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Native/DxgiNative.cs` | `src/Broiler.Native.Windows/Direct2D/DxgiNative.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Native/NativeMethods.cs` | `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Android/AndroidEglNative.cs` | `src/Broiler.Native.Android/AndroidEglNative.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Android/AndroidGlesNative.cs` | `src/Broiler.Native.Android/AndroidGlesNative.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Android/AndroidNativeWindowNative.cs` | `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Android/AndroidNativeLibraries.cs` | `src/Broiler.Native.Android/AndroidNativeLibraries.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Linux.OpenGL/LinuxEglNative.cs` | `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Linux.OpenGL/LinuxX11Native.cs` | `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Linux.OpenGL/LinuxOpenGlFunctions.cs` | `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Linux.Vulkan/LinuxVulkanNative.cs` | `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` |
| `Broiler.Input/src/Broiler.Input.Linux/LinuxNativeMethods.cs` | `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` |
| `Broiler.Input/src/Broiler.Input.Keyboard.Windows/WindowsKeyboardNativeMethods.cs` | `src/Broiler.Native.Windows/WindowNative.cs` |
| `Broiler.Input/src/Broiler.Input.Mouse.Windows/WindowsMouseNativeMethods.cs` | `src/Broiler.Native.Windows/WindowNative.cs` |
| `Broiler.Input/src/Broiler.Input.Camera.Windows/WindowsMediaFoundationNative.cs` | `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` |
| `Broiler.Input/src/Broiler.Input.Microphone.Windows/WindowsWasapiNative.cs` | `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` |
| `Broiler.Media/src/Broiler.Media.Video.MediaFoundation/MediaFoundationNative.cs` | `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Direct2DWindow.cs` | `src/Broiler.Native.Windows/WindowNative.cs` |
| `Broiler.Input/src/Broiler.Input.Windows/WindowsInputClock.cs` | `src/Broiler.Native.Windows/PerformanceCounterNative.cs` |
| `Broiler.Input/src/Broiler.Input.Windows/WindowsRawInputReader.cs` | `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` |
| `Broiler.Input/src/Broiler.Input.Windows/WindowsRawInputRegistrationCoordinator.cs` | `src/Broiler.Native.Windows/Input/RawInputRegistrationNative.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/HwndVideoOutput.cs` | `src/Broiler.Native.Windows/HwndNative.cs` |
| `Broiler.Media/src/Broiler.Media.Image.Managed/Webp/WebpWicDecoder.cs` | `src/Broiler.Native.Windows/Wic/WicNative.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Direct2DDevice.cs` | `src/Broiler.Native.Windows/Direct2D/Direct2DDeviceApi.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Direct2DImageStore.cs` | `src/Broiler.Native.Windows/Direct2D/Direct2DImageStoreApi.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Direct2DOffscreenSurface.cs` | `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Direct2DRenderer.cs` | `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/Direct2DSurface.cs` | `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/DirectWriteFontFamilies.cs` | `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Windows/DirectWriteTextMetricsProvider.cs` | `src/Broiler.Native.Windows/Direct2D/DirectWriteTextMetricsProviderApi.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Android/AndroidOpenGlEsDriverInfo.cs` | `src/Broiler.Native.Android/AndroidOpenGlEsDriverInfo.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Android/AndroidOpenGlEsException.cs` | `src/Broiler.Native.Android/AndroidOpenGlEsException.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Linux.OpenGL/LinuxOpenGlDriverInfo.cs` | `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlDriverInfo.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Linux.OpenGL/LinuxOpenGlException.cs` | `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlException.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Linux.Vulkan/LinuxVulkanDeviceInfo.cs` | `src/Broiler.Native.Linux/Vulkan/LinuxVulkanDeviceInfo.cs` |
| `Broiler.Graphics/src/Broiler.Graphics.Linux.Vulkan/LinuxVulkanException.cs` | `src/Broiler.Native.Linux/Vulkan/LinuxVulkanException.cs` |

Additional consolidation:

- Windows demo and test imports now reuse `WindowNative`, including caption reads
  and process DPI awareness. Win32 constants and WIC GUIDs live with their bindings.
- The Linux diagnostic probes in Graphics and Input retain their existing public
  reports and delegate actual loading/freeing to `Broiler.Native.NativeLibraryProbe`.
- Android's resolver and its imports move together into `Broiler.Native.Android`.
- No native binaries or third-party implementation libraries are bundled.

Build consumers with a sibling checkout or `BroilerNativeRoot`; without sources,
the package fallback uses `BroilerNativeVersion`. The Native package release must
precede a standalone build or release of the migrated consumers.
