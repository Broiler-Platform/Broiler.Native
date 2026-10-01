# Broiler.Native Code Assurance

GENERATED - DO NOT EDIT MANUALLY. Regenerate with
`dotnet run --project Broiler.Code/src/Broiler.Code.Review.Cli -c Release -- assurance generate --root Broiler.Native`, which rewrites this file,
`HUMAN_REVIEW.md`, `assurance.manifest.json` and every generated source header from the
product tree.

**No code unit in this component carries a decision on its human line yet.** This report
records that absence precisely. It is not a claim that the code is reviewed, assured or safe,
and the figures below are the measurement of how far from that claim the per-unit record is.

## Summary

| Metric | Value |
|---|---:|
| Files scanned | 42 |
| Files not covered | 0 |
| Files carrying an annotation | 42 |
| Code units | 1413 |
| Relevant | 649 |
| Exempt by predicate | 764 |
| Annotated | 649 of 649 (100%) |
| Human reviewed | 0 of 649 (0%) |
| Unverified | 649 |

## Review states

| State | Count |
|---|---:|
| NEW | 0 |
| AI_ASSESSED | 0 |
| HUMAN_PENDING | 649 |
| HUMAN_APPROVED_PENDING_FINGERPRINT | 0 |
| VERIFIED | 0 |
| STALE | 0 |
| EXEMPT | 764 |

## IP risk

| Value | Units |
|---|---:|
| None | 47 |
| Low | 602 |
| Medium | 0 |
| High | 0 |
| Unknown | 0 |
| *not annotated* | 0 |

## Security risk

| Value | Units |
|---|---:|
| None | 2 |
| Low | 24 |
| Medium | 0 |
| High | 428 |
| Critical | 195 |
| *not annotated* | 0 |

## Resource impact

| Metric | Value |
|---|---:|
| Maximum | 8 / 10 |
| Average over annotated units | 1.4 / 10 |
| Units scored | 649 |

## High-security review areas

- `Broiler.Native.Android.AndroidEglNative` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.GetDisplay(IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.Initialize(IntPtr, out int, out int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.Terminate(IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.BindApi(int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.ChooseConfig(IntPtr, int[], IntPtr[], int, out int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.GetConfigAttrib(IntPtr, IntPtr, int, out int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.CreateContext(IntPtr, IntPtr, IntPtr, int[])` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.DestroyContext(IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.CreatePbufferSurface(IntPtr, IntPtr, int[])` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.CreateWindowSurface(IntPtr, IntPtr, IntPtr, int[]?)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.DestroySurface(IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.MakeCurrent(IntPtr, IntPtr, IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.SwapBuffers(IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.SwapInterval(IntPtr, int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.QuerySurface(IntPtr, IntPtr, int, out int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidEglNative.GetError()` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.GenTextures(int, out uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.DeleteTextures(int, ref uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.BindTexture(int, uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.TexParameteri(int, int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.TexImage2D(int, int, int, int, int, int, int, int, IntPtr)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.GenFramebuffers(int, out uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.DeleteFramebuffers(int, ref uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.BindFramebuffer(int, uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.FramebufferTexture2D(int, int, int, uint, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.CheckFramebufferStatus(int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.Viewport(int, int, int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.ClearColor(float, float, float, float)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.Clear(int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.ReadPixels(int, int, int, int, int, int, IntPtr)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.BlitFramebuffer(int, int, int, int, int, int, int, int, int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.PixelStorei(int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.Enable(int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.Disable(int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.Scissor(int, int, int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.Flush()` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.Finish()` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.GetError()` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.GetString(uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.GetStringValue(uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.ThrowIfError(string)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidGlesNative.GetDriverInfo()` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidNativeLibraries` in `src/Broiler.Native.Android/AndroidNativeLibraries.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidNativeLibraries.s_gate` in `src/Broiler.Native.Android/AndroidNativeLibraries.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidNativeLibraries.EnsureRegistered()` in `src/Broiler.Native.Android/AndroidNativeLibraries.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidNativeLibraries.Resolve(string, Assembly, DllImportSearchPath?)` in `src/Broiler.Native.Android/AndroidNativeLibraries.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidNativeLibraries.TryLoadAny(IReadOnlyList<string>, out string)` in `src/Broiler.Native.Android/AndroidNativeLibraries.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidNativeWindowNative` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidNativeWindowNative.FromSurface(IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Android.AndroidNativeWindowNative.Acquire(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidNativeWindowNative.Release(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidNativeWindowNative.GetWidth(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidNativeWindowNative.GetHeight(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidNativeWindowNative.GetFormat(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Android.AndroidNativeWindowNative.SetBuffersGeometry(IntPtr, int, int, int)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.Input.LinuxNativeMethods` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Input.LinuxNativeMethods.Open(string, int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.Input.LinuxNativeMethods.Read(int, byte[], nuint)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Input.LinuxNativeMethods.Poll(PollFd[], nuint, int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Input.LinuxNativeMethods.IoctlClockId(int, nuint, ref int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.Input.LinuxNativeMethods.IoctlAbsInfo(int, nuint, byte[])` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Input.LinuxNativeMethods.TrySetMonotonicClock(int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.Input.LinuxNativeMethods.TryGetAbsInfo(int, ushort, out int, out int, out int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Input.LinuxNativeMethods.EviocgAbs(ushort)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Input.LinuxNativeMethods.PollFd` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.GetDisplay(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.Initialize(IntPtr, out int, out int)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.Terminate(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.BindApi(int)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.ChooseConfig(IntPtr, int[], IntPtr[], int, out int)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.CreateContext(IntPtr, IntPtr, IntPtr, int[])` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.DestroyContext(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.CreatePbufferSurface(IntPtr, IntPtr, int[])` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.CreateWindowSurface(IntPtr, IntPtr, IntPtr, int[])` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.DestroySurface(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.MakeCurrent(IntPtr, IntPtr, IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.SwapBuffers(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.GetError()` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.GetProcAddress(string)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.LinuxOpenGlFunctions()` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.LoadCurrentContext()` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GetString(uint)` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GetDriverInfo()` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.ThrowIfError(string)` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.Load<TDelegate>(string)` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlGenTexturesProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlDeleteTexturesProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlBindTextureProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlTexParameteriProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlTexImage2DProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlGenFramebuffersProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlDeleteFramebuffersProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlBindFramebufferProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlFramebufferTexture2DProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlCheckFramebufferStatusProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlViewportProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlClearColorProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlClearProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlReadPixelsProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlBlitFramebufferProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlPixelStoreiProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlEnableProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlDisableProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlScissorProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlFlushProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlGetErrorProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlGetStringProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.OpenDisplay(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.CloseDisplay(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.DefaultScreen(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.RootWindow(IntPtr, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.BlackPixel(IntPtr, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.WhitePixel(IntPtr, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.CreateSimpleWindow(IntPtr, IntPtr, int, int, uint, uint, uint, IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.StoreName(IntPtr, IntPtr, string)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.SelectInput(IntPtr, IntPtr, long)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.MapWindow(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.ResizeWindow(IntPtr, IntPtr, uint, uint)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.DestroyWindow(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.Flush(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.Pending(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.NextEvent(IntPtr, out XEvent)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.InternAtom(IntPtr, string, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.ChangeProperty(IntPtr, IntPtr, IntPtr, IntPtr, int, int, byte[], int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.SetWmProtocols(IntPtr, IntPtr, IntPtr[], int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.SetInputFocus(IntPtr, IntPtr, int, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.QueryPointer(IntPtr, IntPtr, out IntPtr, out IntPtr, out int, out int, out int, out int, out uint)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.Sync(IntPtr, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.GetInputFocus(IntPtr, out IntPtr, out int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.SetErrorHandler(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.XEvent` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetSupportedInstanceVersion()` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.ThrowIfFailed(int, string)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetPhysicalDeviceInfo(IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.EnumerateInstanceVersion(out uint)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.CreateInstance(ref VkInstanceCreateInfo, IntPtr, out IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.DestroyInstance(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.EnumeratePhysicalDevices(IntPtr, ref uint, IntPtr[]?)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetPhysicalDeviceQueueFamilyProperties(IntPtr, ref uint, VkQueueFamilyProperties[]?)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetPhysicalDeviceProperties(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.CreateDevice(IntPtr, ref VkDeviceCreateInfo, IntPtr, out IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.DestroyDevice(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetDeviceQueue(IntPtr, uint, uint, out IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.DeviceWaitIdle(IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkApplicationInfo` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkInstanceCreateInfo` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkDeviceQueueCreateInfo` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkDeviceCreateInfo` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkQueueFamilyProperties` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkExtent3D` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.ReadUInt32(IntPtr, int)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.IStream` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.IStream.Read(IntPtr, uint, out uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.IStream.Write(IntPtr, uint, out uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.IStream.Seek(long, uint, out ulong)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.IStream.SetSize(ulong)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.IStream.CopyTo(IStream, ulong, out ulong, out ulong)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.IStream.Commit(uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.IStream.Revert()` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.IStream.LockRegion(ulong, ulong, uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.IStream.UnlockRegion(ulong, ulong, uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.IStream.Stat(IntPtr, uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.IStream.Clone(out IStream)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.ComNative` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.ComNative.s_comWrappers` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.ComNative.CoInitializeEx(IntPtr, uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.ComNative.CoUninitialize()` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.ComNative.CoTaskMemFree(IntPtr)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.ComNative.CoCreateInstance(in Guid, IntPtr, uint, in Guid, out IntPtr)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.ComNative.CoCreateInstance(ref Guid, IntPtr, uint, ref Guid, out object?)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.ComNative.CoCreateInstance(in Guid, IntPtr, uint, in Guid, out WicNative.IWICImagingFactory)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.ComNative.CreateStreamOnHGlobal(IntPtr, bool, out IStream)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.ComNative.GetOrCreateComObject<TInterface>(IntPtr)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.ComNative.ReleaseIUnknown(IntPtr)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.ComNative.ReleaseComObject(object?)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.ComPtr` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.ComPtr.QueryInterfaceProc` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.ComPtr.AddRefProc` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.ComPtr.ReleaseProc` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.ComPtr.Attach(IntPtr)` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.ComPtr.AddRef()` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.ComPtr.QueryInterface(in Guid, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.ComPtr.Release()` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.ComVtable` in `src/Broiler.Native.Windows/Direct2D/ComVtable.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.ComVtable.Delegates` in `src/Broiler.Native.Windows/Direct2D/ComVtable.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.ComVtable.Method<TDelegate>(IntPtr, int)` in `src/Broiler.Native.Windows/Direct2D/ComVtable.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_SIZE_U` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_MAPPED_RECT` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_PIXEL_FORMAT` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_BITMAP_PROPERTIES` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_BITMAP_PROPERTIES1` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_COLOR_F` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_POINT_2F` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_RECT_F` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_ROUNDED_RECT` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_MATRIX_3X2_F` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative.CreateDeviceContextProc` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.D2DNative.SetTargetProc` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DWriteNative` in `src/Broiler.Native.Windows/Direct2D/DWriteNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DWriteNative.DWRITE_TEXT_METRICS` in `src/Broiler.Native.Windows/Direct2D/DWriteNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DWriteNative.CreateTextFormatProc` in `src/Broiler.Native.Windows/Direct2D/DWriteNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DDeviceApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DDeviceApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DDeviceApi.CreateD2DDeviceProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DDeviceApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DImageStoreApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DImageStoreApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DImageStoreApi.CreateBitmapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DImageStoreApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi.CreateBitmap1Proc` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi.CopyFromBitmapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi.MapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi.UnmapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.BeginDrawProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.EndDrawProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.ClearProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.SetAntialiasModeProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.SetTextAntialiasModeProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.SetTransformProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.CreateSolidColorBrushProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.FillRectangleProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GetFactoryProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.CreatePathGeometryProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.PathGeometryOpenProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkSetFillModeProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkBeginFigureProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkAddLinesProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkEndFigureProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkCloseProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.FillGeometryProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.DrawRectangleProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.FillRoundedRectangleProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.DrawRoundedRectangleProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.DrawTextProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.DrawBitmapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.PushAxisAlignedClipProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.PopAxisAlignedClipProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.CreateSwapChainForCompositionProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.CreateSwapChainForHwndProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.GetBufferProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.ResizeBuffersProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.CreateBitmapFromDxgiSurfaceProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.SetDpiProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.PresentProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetSystemFontCollectionProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetFontFamilyCountProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetFontFamilyProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetFamilyNamesProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.FindLocaleNameProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetStringLengthProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetStringProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.DirectWriteTextMetricsProviderApi` in `src/Broiler.Native.Windows/Direct2D/DirectWriteTextMetricsProviderApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.DirectWriteTextMetricsProviderApi.CreateTextLayoutProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteTextMetricsProviderApi.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.DirectWriteTextMetricsProviderApi.GetMetricsProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteTextMetricsProviderApi.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DxgiNative` in `src/Broiler.Native.Windows/Direct2D/DxgiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DxgiNative.DXGI_SAMPLE_DESC` in `src/Broiler.Native.Windows/Direct2D/DxgiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.DxgiNative.DXGI_SWAP_CHAIN_DESC1` in `src/Broiler.Native.Windows/Direct2D/DxgiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.NativeMethods` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.NativeMethods.D3D11CreateDevice(IntPtr, D3D11Native.D3D_DRIVER_TYPE, IntPtr, uint, IntPtr, uint, uint, out IntPtr, out D3D11Native.D3D_FEATURE_LEVEL, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.NativeMethods.CreateDXGIFactory1(in Guid, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.NativeMethods.D2D1CreateFactory(D2DNative.D2D1_FACTORY_TYPE, in Guid, IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Direct2D.NativeMethods.DWriteCreateFactory(DWriteNative.DWRITE_FACTORY_TYPE, in Guid, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.NativeMethods.Succeeded(int)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Direct2D.NativeMethods.ThrowIfFailed(int, string)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.HwndNative` in `src/Broiler.Native.Windows/HwndNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.HwndNative.IsWindow(nint)` in `src/Broiler.Native.Windows/HwndNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Input.RawInputReaderNative` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Input.RawInputReaderNative.RawInputHeader` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Input.RawInputReaderNative.RawMouse` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Input.RawInputReaderNative.RawKeyboard` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Input.RawInputReaderNative.GetRawInputData(IntPtr, uint, IntPtr, ref uint, uint)` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Input.RawInputRegistrationNative` in `src/Broiler.Native.Windows/Input/RawInputRegistrationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Input.RawInputRegistrationNative.RawInputDevice` in `src/Broiler.Native.Windows/Input/RawInputRegistrationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Input.RawInputRegistrationNative.RegisterRawInputDevices(RawInputDevice[], uint, uint)` in `src/Broiler.Native.Windows/Input/RawInputRegistrationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.WindowsMediaFoundationNative` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.WindowsMediaFoundationNative.MFEnumDeviceSources(IMFAttributes, out IntPtr, out uint)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.WindowsMediaFoundationNative.MFCreateDeviceSource(IMFAttributes, out IMFMediaSource)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.WindowsMediaFoundationNative.MFCreateSourceReaderFromMediaSource(IMFMediaSource, IMFAttributes?, out IMFSourceReader)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFActivate` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFActivate.ActivateObject(ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFActivate.ShutdownObject()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFActivate.DetachObject()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.GetEvent(int, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.BeginGetEvent(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.EndGetEvent(IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.QueueEvent(int, ref Guid, int, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.GetCharacteristics(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.CreatePresentationDescriptor(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.Start(IntPtr, ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.Stop()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.Pause()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.Shutdown()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.GetMajorType(out Guid)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.IsCompressedFormat(out bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.IsEqual(IMFMediaType, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.GetRepresentation(Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.FreeRepresentation(Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetStreamSelection(int, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.SetStreamSelection(int, bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetNativeMediaType(int, int, out IMFMediaType)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetCurrentMediaType(int, out IMFMediaType)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.SetCurrentMediaType(int, IntPtr, IMFMediaType)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.SetCurrentPosition(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.ReadSample(int, int, out int, out SourceReaderFlags, out long, out IMFSample?)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.Flush(int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetServiceForStream(int, ref Guid, ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetPresentationAttribute(int, ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetItem(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetItemType(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.CompareItem(ref Guid, IntPtr, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.Compare(IMFAttributes, int, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetUINT32(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetUINT64(ref Guid, out long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetDouble(ref Guid, out double)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetGUID(ref Guid, out Guid)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetStringLength(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetString(ref Guid, IntPtr, int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetAllocatedString(ref Guid, out IntPtr, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetBlobSize(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetBlob(ref Guid, IntPtr, int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetAllocatedBlob(ref Guid, out IntPtr, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetUnknown(ref Guid, ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetItem(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.DeleteItem(ref Guid)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.DeleteAllItems()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetUINT32(ref Guid, int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetUINT64(ref Guid, long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetDouble(ref Guid, double)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetGUID(ref Guid, ref Guid)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetString(ref Guid, string)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetBlob(ref Guid, IntPtr, int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetUnknown(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.LockStore()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.UnlockStore()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetCount(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetItemByIndex(int, out Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.CopyAllItems(IMFAttributes)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetSampleFlags(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetSampleFlags(int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetSampleTime(out long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetSampleTime(long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetSampleDuration(out long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetSampleDuration(long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetBufferCount(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetBufferByIndex(int, out IMFMediaBuffer)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.ConvertToContiguousBuffer(out IMFMediaBuffer)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.AddBuffer(IMFMediaBuffer)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.RemoveBufferByIndex(int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.RemoveAllBuffers()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetTotalLength(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.CopyToBuffer(IMFMediaBuffer)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.Lock(out IntPtr, out int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.Unlock()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.GetCurrentLength(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.SetCurrentLength(int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.GetMaxLength(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetItem(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetItemType(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.CompareItem(ref Guid, IntPtr, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.Compare(IMFAttributes, int, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetUINT32(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetUINT64(ref Guid, out long)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetDouble(ref Guid, out double)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetGUID(ref Guid, out Guid)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetStringLength(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetString(ref Guid, IntPtr, int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetAllocatedString(ref Guid, out IntPtr, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetBlobSize(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetBlob(ref Guid, IntPtr, int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetAllocatedBlob(ref Guid, out IntPtr, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetUnknown(ref Guid, ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetItem(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.DeleteItem(ref Guid)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.DeleteAllItems()` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetUINT32(ref Guid, int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetUINT64(ref Guid, long)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetDouble(ref Guid, double)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetGUID(ref Guid, ref Guid)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetString(ref Guid, string)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetBlob(ref Guid, IntPtr, int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetUnknown(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.LockStore()` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.UnlockStore()` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetCount(out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetItemByIndex(int, out Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.CopyAllItems(IMFAttributes)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineNotify` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineNotify.EventNotify(uint, UIntPtr, uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineClassFactory` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineClassFactory.CreateInstance(uint, IMFAttributes, out IMFMediaEngine)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineClassFactory.CreateTimeRange(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineClassFactory.CreateError(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetError(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetErrorCode(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetSourceElements(IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetSource(string)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetCurrentSource(out string?)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetNetworkState()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetPreload()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetPreload(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetBuffered(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.Load()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.CanPlayType(string, out int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetReadyState()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.IsSeeking()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetCurrentTime()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetCurrentTime(double)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetStartTime()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetDuration()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.IsPaused()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetDefaultPlaybackRate()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetDefaultPlaybackRate(double)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetPlaybackRate()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetPlaybackRate(double)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetPlayed(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetSeekable(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.IsEnded()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetAutoPlay()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetAutoPlay(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetLoop()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetLoop(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.Play()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.Pause()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetMuted()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetMuted(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetVolume()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetVolume(double)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.HasVideo()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.HasAudio()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetNativeVideoSize(out uint, out uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetVideoAspectRatio(out uint, out uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.Shutdown()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.TransferVideoFrame(IntPtr, IntPtr, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.OnVideoStreamTick(out long)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative.MFStartup(int, int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative.MFShutdown()` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative.MFCreateAttributes(out IMFAttributes, uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative.MFCreateAttributes(out IntPtr, uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.PerformanceCounterNative` in `src/Broiler.Native.Windows/PerformanceCounterNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.PerformanceCounterNative.QueryPerformanceCounter(out long)` in `src/Broiler.Native.Windows/PerformanceCounterNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.PerformanceCounterNative.QueryPerformanceFrequency(out long)` in `src/Broiler.Native.Windows/PerformanceCounterNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.PropVariantClear(ref PropVariant)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.CreateEventW(IntPtr, bool, bool, string?)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.SetEvent(IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.CloseHandle(IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.WaitForSingleObject(IntPtr, uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.PropertyKey` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.PropVariant` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.WaveFormatEx` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.WaveFormatExtensible` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.EnumAudioEndpoints(EDataFlow, DeviceState, out IMMDeviceCollection)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.GetDefaultAudioEndpoint(EDataFlow, ERole, out IMMDevice)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.GetDevice(string, out IMMDevice)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.RegisterEndpointNotificationCallback(IMMNotificationClient)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.UnregisterEndpointNotificationCallback(IMMNotificationClient)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDeviceCollection` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDeviceCollection.GetCount(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDeviceCollection.Item(uint, out IMMDevice)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDevice` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDevice.Activate(ref Guid, uint, IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDevice.OpenPropertyStore(StorageAccess, out IPropertyStore)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDevice.GetId(out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMDevice.GetState(out DeviceState)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IPropertyStore` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.IPropertyStore.GetCount(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IPropertyStore.GetAt(uint, out PropertyKey)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IPropertyStore.GetValue(ref PropertyKey, out PropVariant)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.IPropertyStore.SetValue(ref PropertyKey, ref PropVariant)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.IPropertyStore.Commit()` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnDeviceStateChanged(string, DeviceState)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnDeviceAdded(string)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnDeviceRemoved(string)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnDefaultDeviceChanged(EDataFlow, ERole, string)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnPropertyValueChanged(string, PropertyKey)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient.Initialize(AudioClientShareMode, AudioClientStreamFlags, long, long, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetBufferSize(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetStreamLatency(out long)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetCurrentPadding(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient.IsFormatSupported(AudioClientShareMode, IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetMixFormat(out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetDevicePeriod(out long, out long)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient.Start()` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient.Stop()` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient.Reset()` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient.SetEventHandle(IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetService(ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioCaptureClient` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioCaptureClient.GetBuffer(out IntPtr, out uint, out AudioClientBufferFlags, out ulong, out ulong)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioCaptureClient.ReleaseBuffer(uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.IAudioCaptureClient.GetNextPacketSize(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wasapi.WasapiExtensions` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.WasapiExtensions.Activate<TInterface>(this IMMDevice, uint, IntPtr, out TInterface?)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wasapi.WasapiExtensions.GetService<TInterface>(this IAudioClient, out TInterface?)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetSize(out uint, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetPixelFormat(out Guid)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetResolution(out double, out double)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.CopyPalette(IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.CopyPixels(IntPtr, uint, uint, IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetMetadataQueryReader(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetColorContexts(uint, IntPtr, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetThumbnail(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.GetSize(out uint, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.GetPixelFormat(out Guid)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.GetResolution(out double, out double)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.CopyPalette(IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.CopyPixels(IntPtr, uint, uint, IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.Initialize(IWICBitmapFrameDecode, ref Guid, int, IntPtr, double, int)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.CanConvert(ref Guid, ref Guid, out int)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.QueryCapability(IStream, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.Initialize(IStream, int)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetContainerFormat(out Guid)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetDecoderInfo(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.CopyPalette(IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetMetadataQueryReader(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetPreview(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetColorContexts(uint, IntPtr, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetThumbnail(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetFrameCount(out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetFrame(uint, out IWICBitmapFrameDecode)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateDecoderFromFilename(string, IntPtr, uint, int, out IWICBitmapDecoder)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateDecoderFromStream(IStream, IntPtr, int, out IWICBitmapDecoder)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateDecoderFromFileHandle(IntPtr, IntPtr, int, out IWICBitmapDecoder)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateComponentInfo(ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateDecoder(ref Guid, IntPtr, out IWICBitmapDecoder)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateEncoder(ref Guid, IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreatePalette(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateFormatConverter(out IWICFormatConverter)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.WindowNative.SetWindowLongPtr(IntPtr, int, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetWindowLongPtr(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetClassLongPtr(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.WndProc` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.WNDCLASSEX` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.RECT` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.POINT` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.TRACKMOUSEEVENT` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.MSG` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.CREATESTRUCT` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetModuleHandle(string?)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.RegisterClassEx(ref WNDCLASSEX)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.CreateWindowEx(uint, string, string, uint, int, int, int, int, IntPtr, IntPtr, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.AdjustWindowRectEx(ref RECT, uint, bool, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.AdjustWindowRectExForDpi(ref RECT, uint, bool, uint, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetSystemMetrics(int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.ShowWindow(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.UpdateWindow(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetMessage(out MSG, IntPtr, uint, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.TranslateMessage(ref MSG)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.DispatchMessage(ref MSG)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.DefWindowProc(IntPtr, uint, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.PostQuitMessage(int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.PostMessage(IntPtr, uint, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.InvalidateRect(IntPtr, IntPtr, bool)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.WindowNative.ValidateRect(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.WindowNative.MoveWindow(IntPtr, int, int, int, int, bool)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.DestroyWindow(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetParent(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.SetTimer(IntPtr, nuint, uint, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.KillTimer(IntPtr, nuint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.SetFocus(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetKeyState(int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.ScreenToClient(IntPtr, ref POINT)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.TrackMouseEvent(ref TRACKMOUSEEVENT)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetClientRect(IntPtr, out RECT)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetDpiForWindow(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetDC(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.ReleaseDC(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetDeviceCaps(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.LoadCursor(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.WindowNative.LoadIcon(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetSysColorBrush(int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.SetWindowLongPtr64(IntPtr, int, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.SetWindowLong32(IntPtr, int, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetWindowLongPtr64(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetWindowLong32(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetClassLongPtr64(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetClassLong32(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.SetWindowText(IntPtr, string)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.SendMessage(IntPtr, uint, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.ReleaseCapture()` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.IsIconic(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.IsZoomed(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetWindowRect(IntPtr, out RECT)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.MonitorFromWindow(IntPtr, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetMonitorInfo(IntPtr, ref MONITORINFO)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.WindowNative.DestroyIcon(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.CreateIconIndirect(ref ICONINFO)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.CreateDIBSection(IntPtr, ref BITMAPINFOHEADER, uint, out IntPtr, IntPtr, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.WindowNative.CreateBitmap(int, int, uint, uint, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.WindowNative.DeleteObject(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.MONITORINFO` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.ICONINFO` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.BITMAPINFOHEADER` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.WindowNative.SetProcessDpiAwarenessContext(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetWindowText(IntPtr, char*, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetWindowText(IntPtr, Span<char>)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.Windows.WindowNative.GetWindowText(IntPtr, StringBuilder, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, human line PENDING
- `Broiler.Native.NativeLibraryProbe` in `src/Broiler.Native/NativeLibraryProbe.cs` - Security=High, human line PENDING
- `Broiler.Native.NativeLibraryProbe.IsAvailable(string)` in `src/Broiler.Native/NativeLibraryProbe.cs` - Security=High, human line PENDING

## Falsification criteria

| Metric | Value |
|---|---:|
| Units carrying a criterion | 623 |
| Units required to carry one | 623 |
| Required and missing | 0 |

A `Broiler-Falsified-If:` line states, at the declaration, the observation that would make
the unit wrong. `Security=High` says a unit is risky, which is a set and not a test; the
criterion is the test. It is required where `Security` is `High` or `Critical` and written
nowhere else: `dotnet run --project Broiler.Code/src/Broiler.Code.Review.Cli -c Release -- assurance check --root Broiler.Native` names every unit that owes one and carries none, and
every unit below `High` that carries one.

The line is a comment, so it is outside every fingerprint by construction: rewording a
criterion moves no recorded value here, in a file header or in
`assurance.manifest.json`, and invalidates nothing. That is the intended reading - a
criterion is an instruction to whoever reads the unit, not part of what a review is bound to.

## Exemption

Exemption is decided by one predicate in `CSharpAssuranceScanner`, not per unit, so
that the rule is reviewable in one place rather than in several hundred.

| Case | Units |
|---|---:|
| TrivialPropertyOrAccessor | 2 |
| ParameterAssigningConstructor | 1 |
| TrivialExpressionBodiedMember | 21 |
| CompilerSuppliedRecordOrEnumMember | 0 |
| DelegatingOverrideOrOperator | 0 |
| InsideAssemblyMarker | 0 |
| FieldDeclaringStorage | 223 |
| EnumMemberOfADeclaredVocabulary | 107 |
| NamedValue | 410 |
| DeclaredInSource | 0 |

`NamedValue` is this component's choice (`"namedValues": "watched"`): a `const`
field, an enum declaration and a `static readonly` `Guid`, `IntPtr`, `UIntPtr`, `nint` or `nuint`
stated by literals alone is a value with a name and carries no decision to assess, so it
carries no annotation. It is still a unit with an entry in `assurance.manifest.json`, so a
change to its value moves a fingerprint the check compares.

## Per-unit exemptions

| Metric | Value |
|---|---:|
| Per-unit exemptions | 0 |

A per-unit `EXEMPT=<reason>` line exempts one unit by a reason a human wrote, for what the
predicate cannot see. Nothing mechanical checks that the reason is true, that it describes
the unit it sits on, or that it says anything at all, so every use is counted and named
here.

No unit in this component states a per-unit exemption.

## Files not covered

No file under a covered project's directory, and no file a covered project compiles in
through a `<Compile Include>` it states, is left out of the record.

## Change detection

`assurance.manifest.json` lists **every** code unit in the 5 covered assemblies -
1413 of them, exempt and relevant alike - with the fingerprint of its declaration.
This manifest is a change-detection record, not a review. A unit listed there is watched, not reviewed:
the entry records what the declaration's tokens hashed to when the generator last ran, and
nothing else. What the manifest adds is that a unit the exemption predicate treats as
trivial is no longer invisible: a semantic change to one moves a value in a generated file
the check compares byte for byte. `dotnet run --project Broiler.Code/src/Broiler.Code.Review.Cli -c Release -- assurance check --root Broiler.Native` holds the manifest to the tree.

Beside the units it lists **every covered file** - 42 of them - with a
fingerprint over the complete token stream of its compilation unit. A unit entry exists only
for a declaration kind the scanner enumerates, and an enumeration is a whitelist: an
`[assembly: ...]` attribute is a member of nothing and can be in no unit at all.
Nothing in a covered file can change without something moving here, whatever kind of declaration it is. Comments are outside the stream, because a token's
text is its own characters, so the generated header above and the annotation lines below move
no file fingerprint - which is what lets one generation be a fixed point.

## Verification

The generator and the check are one computation: `dotnet run --project Broiler.Code/src/Broiler.Code.Review.Cli -c Release -- assurance check --root Broiler.Native` works out what the
generator would write and compares it with the tree byte for byte, so a record edited by
hand, or left behind by code that moved, is reported rather than trusted.

| Mode | Command | Effect |
|---|---|---|
| Generate | `dotnet run --project Broiler.Code/src/Broiler.Code.Review.Cli -c Release -- assurance generate --root Broiler.Native` | Fills every `Fingerprint=TBF`, refreshes a decision the code has outrun into `STALE; Previous=...`, rewrites the generated headers, `HUMAN_REVIEW.md`, `assurance.manifest.json` and this file. |
| Check | `dotnet run --project Broiler.Code/src/Broiler.Code.Review.Cli -c Release -- assurance check --root Broiler.Native` | Reports every generated artefact that is not byte-identical to what the generator would produce, every relevant unit with no annotation, every annotation this system cannot read, every fingerprint out of date and every unit at the top of the security vocabulary without a criterion, or below it with one. |
| Release | `dotnet run --project Broiler.Code/src/Broiler.Code.Review.Cli -c Release -- assurance check --root Broiler.Native --release` | The check, and additionally every relevant unit left in a state that blocks a release. |

The fingerprint is six hex characters - 24 bits - of SHA-256 over the declaration's token
texts, joined by single spaces. Trivia is excluded because a token's text is its own
characters and never the comments or whitespace around it, so `dotnet format` moves no
fingerprint and an annotation is never part of what it describes. The value answers whether a
unit changed since it was reviewed. It is not a collision-free identifier across units and it
is not a cryptographic commitment.
