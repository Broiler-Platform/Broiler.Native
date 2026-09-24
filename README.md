# Broiler.Native

Shared native API bindings for `Broiler.Graphics`, `Broiler.Input`, and `Broiler.Media`.
The component owns native entry points, ABI structures, constants, COM contracts,
function delegates, and library probing. It has no dependency on those consumers.

## Packages

| Package | Target | Description |
| :--- | :--- | :--- |
| [`Broiler.Native`](src/Broiler.Native) | Any (`net10.0`) | Lightweight core with `NativeLibraryProbe` for non-throwing library probing. Zero external dependencies. |
| [`Broiler.Native.Windows`](src/Broiler.Native.Windows) | Windows (`net10.0`) | Win32 windowing, performance counters, Raw Input, DirectX (D2D, DWrite, DXGI, D3D11), WIC, WASAPI, Media Foundation. |
| [`Broiler.Native.Linux`](src/Broiler.Native.Linux) | Linux (`net10.0`) | libc/evdev input, `poll`, X11, EGL/OpenGL dynamic loading and driver queries, Vulkan device enumeration. |
| [`Broiler.Native.Android`](src/Broiler.Native.Android) | Android (`net10.0`) | EGL, OpenGL ES 2.0 / 3.0, `ANativeWindow`, and assembly-scoped dynamic soname resolver. |
| [`Broiler.Native.All`](src/Broiler.Native.All) | Any (`net10.0`) | Convenience meta-package referencing all platform packages for multi-target or cross-platform codebases. |

All projects target `net10.0` and are annotated with `<IsAotCompatible>true</IsAotCompatible>`.
A reference to a platform package does not eagerly load its native libraries; call platform APIs only on a compatible host with the required libraries installed.

---

## Quickstart for Consumers

Install packages via NuGet:

```sh
dotnet add package Broiler.Native.Windows
# or for multi-platform projects:
dotnet add package Broiler.Native.All
```

### Probing Library Availability

```csharp
using Broiler.Native;

if (OperatingSystem.IsWindows() && NativeLibraryProbe.IsAvailable("d2d1.dll"))
{
    // Direct2D is available
}
```

### High-Precision Timing

```csharp
using Broiler.Native.Windows;

PerformanceCounterNative.QueryPerformanceFrequency(out long frequency);
PerformanceCounterNative.QueryPerformanceCounter(out long start);
// ... work ...
PerformanceCounterNative.QueryPerformanceCounter(out long end);
double elapsedSeconds = (double)(end - start) / frequency;
```

For complete consumer documentation, platform requirements, and detailed subsystem examples, see the [End-User and Consumer Guide](docs/consumer-guide.md).

---

## Developer Quickstart

Requires the .NET 10 SDK, Node.js 24, and PowerShell 7 (or Windows PowerShell).

```sh
# Build solution
dotnet build Broiler.Native.slnx -c Release

# Run test suite
dotnet run --project src/tests/Broiler.Native.Tests -c Release --no-build
# or: bash ./eng/run-tests.sh Release

# Test version resolution engine
node --test eng/resolve-preview-version.test.mjs

# Pack and verify shipping packages locally
pwsh -File eng/pack.ps1 -Configuration Release

# Verify consumer restoration against NuGet.org
pwsh -File eng/verify-feed.ps1 -Packages artifacts
```

For guidelines on authoring bindings, COM interfaces under NativeAOT, struct layout verification, and release workflows, see the [Developer and Contributor Guide](docs/developer-guide.md).

---

## Documentation Index

- [End-User and Consumer Guide](docs/consumer-guide.md): Package selection, host prerequisites, probing patterns, subsystem guides, and code examples.
- [Developer and Contributor Guide](docs/developer-guide.md): Architecture scope, development setup, building, testing, binding conventions, and packaging.
- [CI, Packages, and Releases](docs/packaging.md): Preview version calculation, feed rules, packaging validation, and NuGet.org release workflow.
- [Architecture Decision Record: 0001 Native API Ownership](docs/adr/0001-native-api-ownership.md): Decision context and rationale for native API extraction.
- [Native API Extraction Inventory](docs/native-api-inventory.md): Mapping of extracted types from legacy sibling components.
- [Roadmap](docs/roadmap.md): Current implementation status and milestones.

---

## License

Licensed under [Apache-2.0](LICENSE).
