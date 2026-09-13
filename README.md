# Broiler.Native

Shared native API bindings for Broiler.Graphics, Broiler.Input, and Broiler.Media.
The component owns native entry points, ABI structures, constants, COM contracts,
function delegates, and library loading. It has no dependency on those consumers.

| Package | Contents |
| --- | --- |
| `Broiler.Native` | Native library availability probing |
| `Broiler.Native.Windows` | Win32 windowing, performance counters, Raw Input, DirectX, WIC, WASAPI, Media Foundation |
| `Broiler.Native.Linux` | libc/evdev, X11, EGL/OpenGL, Vulkan |
| `Broiler.Native.Android` | EGL, OpenGL ES, ANativeWindow, library resolver |
| `Broiler.Native.All` | Convenience reference to all native packages |

All projects target `net10.0`. A reference to a platform package does not load its
native libraries. Call platform APIs only on a compatible host with the required
libraries installed. Windows remains consumable by a neutral codec assembly that
guards its WIC calls at runtime; it does not require the Windows desktop workload.

## Build and test

Requires the .NET 10 SDK.

```sh
dotnet build Broiler.Native.slnx -c Release
dotnet run --project src/tests/Broiler.Native.Tests -c Release --no-build
pwsh -File eng/pack.ps1
```

The solution uses `Debug` and `Release`. Tests use the console-runner convention
of the other components. CI runs on Windows and Linux and checks layout, dependency direction,
COM callback metadata, resolver ownership, and host native calls.

## Consuming packages

Graphics, Input, and Media reference Native packages at the versions in their
`Directory.Packages.props`. A sibling checkout does not replace those references.
Publish Native to the destination feed before publishing dependent components.
See [CI, packages, and releases](docs/packaging.md) for preview version selection,
dry runs, package credentials, and NuGet.org release setup.

Native API namespaces now begin with `Broiler.Native`. Driver descriptions and
OpenGL/Vulkan native exceptions moved with their bindings, so code explicitly
using those types needs the corresponding Native namespace. Renderers, device
providers, media decoding, diagnostic models, and domain error translation remain
in their original components. See [the extraction inventory](docs/native-api-inventory.md).

## Repository layout

`src/` holds the five libraries; `src/tests/` holds the test runner; `eng/` contains
the vendored packaging defaults and release helpers; `docs/adr/` records the
dependency boundary. The Publish workflow uses the same preview version resolver
and feed selection as Broiler.Input, with manual dry runs enabled by default.

Licensed under Apache-2.0; see [LICENSE](LICENSE).
