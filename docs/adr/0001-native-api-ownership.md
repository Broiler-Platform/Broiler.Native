# 0001: Native API ownership and dependency direction

Status: Accepted

Graphics, Input, and Media previously owned operating-system imports and ABI
declarations. These declarations belong in a shared component so their consumers
can reuse them without referencing a renderer, input provider, or codec.

Broiler.Native owns platform bindings and low-level lifetime helpers. Its core and
platform assemblies reference only the framework and other Native assemblies.
The Windows, Linux, and Android packages can be referenced individually or through
Broiler.Native.All. They use plain net10.0 because a cross-platform provider may
choose a native fallback only after checking the host at runtime.

Consumers retain their high-level policies: rendering, device enumeration flows,
session lifecycle, pixel conversion, input reports, and domain error translation.
Native structs, signatures, GUIDs, calling conventions, and marshalling attributes
are preserved during extraction. Separate Media Foundation capture and playback
COM surfaces are retained to avoid changing their existing ABI contracts.

Native declarations are public to support separate consumer assemblies. Namespace
migration is a source/API change during preview; no compatibility facade is added.
The Android resolver lives in the same assembly as its imports, since .NET scopes
DllImport resolvers to an assembly.

Sibling source checkouts use project references. Standalone consumers use the
published Native packages. Native must be published before these consumer changes.
