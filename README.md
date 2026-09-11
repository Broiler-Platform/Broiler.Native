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
dotnet pack Broiler.Native.slnx -c Release -o artifacts
```

The solution also supports `Debug-Linux`, `Release-Linux`, `Debug-Windows`, and
`Release-Windows`. Tests use the same console-runner convention as the other
components. CI runs on Windows and Linux and checks layout, dependency direction,
COM callback metadata, resolver ownership, and host native calls.

## Consuming from source

Keep the four repositories beside each other. Graphics, Input, and Media discover
the sibling `Broiler.Native` checkout and use project references. To use a different
location, set `BroilerNativeRoot` to this repository's absolute path:

```sh
dotnet build ../Broiler.Input/Broiler.Input.slnx -c Release-Windows -p:BroilerNativeRoot=/path/to/Broiler.Native
```

Without a source checkout, the consumers use packages at `BroilerNativeVersion`
(initially `0.1.0-preview.1`). Publish Native before publishing the consumer changes,
or pack it into a local feed. Set `BroilerNativeVersion` to the published version
when advancing the coordinated release.

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
