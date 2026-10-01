# Human Review: Broiler.Native

GENERATED - DO NOT EDIT MANUALLY. Regenerate with
`dotnet run --project Broiler.Code/src/Broiler.Code.Review.Cli -c Release -- assurance generate --root Broiler.Native`, which rewrites this file,
`CODE-ASSURANCE.md`, `assurance.manifest.json` and every generated source header from the
product tree.

> **Status: PENDING.** Human-reviewed: 0 of 649 relevant units. `dotnet run --project Broiler.Code/src/Broiler.Code.Review.Cli -c Release -- assurance check --root Broiler.Native --release`
> fails while any relevant unit is without a decision bound to its current fingerprint.

## 1. How To Use This File

Read it; do not edit it. A decision about a code unit is the `// Broiler-Human:` line on that
unit's declaration, and every table below is read out of those lines. There is nothing here
to fill in and nothing here to leave blank.

## 2. How A Review Is Recorded

In one place: the `// Broiler-Human:` line of the assurance annotation that sits on the
declaration being read. Nothing in this file is edited by hand, no second document carries a
per-item checklist, and no list of permitted aliases exists to be added to.

```csharp
// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=4A3BFD
// Broiler-Falsified-If: a negative value reaches the running total
// Broiler-Human:        PENDING
```

The last line has four shapes. A human writes three of them; the generator writes the fourth
and may never invent an alias, which the check asserts in both directions.

| Line | Meaning |
|---|---|
| `PENDING` | Nobody has recorded a decision for this unit. The generator leaves it exactly as it stands. |
| `<alias>` | A human states their own alias and leaves the machine field to the generator, which fills it with the declaration's fingerprint at the next run. |
| `<alias>; Fingerprint=<six hex>` | A decision bound to one exact version of one declaration. |
| `STALE; Previous=<alias>@<fingerprint>` | Written by the generator when the code moved after a decision. Only a human clears it, by stating their alias again. |

A human may state their own `IP=`, `Security=` and `Resources=` assessment beside their alias,
which is how a reader disagrees with the machine assessment on the line above: an assessment is
a comment and moves no fingerprint, so there is nowhere else to say it.

**No branch, commit or tag is recorded in this file.** Each decision names the fingerprint of
the declaration it was made against, and the state machine compares that value with the
declaration as it now stands. A commit says a tree moved; a fingerprint says whether this unit
did, which is the narrower and the more useful of the two.

## 3. Summary

| Metric | Value |
|---|---:|
| Files scanned | 42 |
| Code units | 1413 |
| Relevant | 649 |
| Exempt | 764 |
| Assessed | 649 of 649 (100%) |
| Human reviewed | 0 of 649 (0%) |
| Unverified | 649 |
| Aliases naming a decision | 0 |

## 4. Review States

One row per state of the machine that reads the two lines. The states are computed from the
annotations and the current fingerprints; nothing stores them.

| State | Units |
|---|---:|
| NEW | 0 |
| AI_ASSESSED | 0 |
| HUMAN_PENDING | 649 |
| HUMAN_APPROVED_PENDING_FINGERPRINT | 0 |
| VERIFIED | 0 |
| STALE | 0 |
| EXEMPT | 764 |

## 5. Aliases In The Tree

No alias appears on a human line anywhere in the product tree. Nobody has recorded a
decision about any unit of this component.

## 6. Coverage By File

One row per covered file, carrying that file's generated header. `Unverified` counts the
relevant units in a state that blocks a release.

| File | Units | Relevant | Exempt | Unverified | IP risk | Security risk | Criteria |
|---|---:|---:|---:|---:|---|---|---:|
| `src/Broiler.Native.Android/AndroidEglNative.cs` | 46 | 17 | 29 | 17 | Low | Critical | 17/17 |
| `src/Broiler.Native.Android/AndroidGlesNative.cs` | 52 | 27 | 25 | 27 | Low | Critical | 27/27 |
| `src/Broiler.Native.Android/AndroidNativeLibraries.cs` | 11 | 5 | 6 | 5 | Low | High | 5/5 |
| `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` | 10 | 8 | 2 | 8 | Low | Critical | 8/8 |
| `src/Broiler.Native.Android/AndroidOpenGlEsDriverInfo.cs` | 2 | 2 | 0 | 2 | Low | Low | 0/0 |
| `src/Broiler.Native.Android/AndroidOpenGlEsException.cs` | 3 | 3 | 0 | 3 | Low | Low | 0/0 |
| `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` | 30 | 10 | 20 | 10 | Low | Critical | 10/10 |
| `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` | 36 | 15 | 21 | 15 | Low | Critical | 15/15 |
| `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlDriverInfo.cs` | 2 | 2 | 0 | 2 | Low | Low | 0/0 |
| `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlException.cs` | 3 | 3 | 0 | 3 | Low | Low | 0/0 |
| `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` | 96 | 29 | 67 | 29 | Low | Critical | 29/29 |
| `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` | 42 | 25 | 17 | 25 | Low | Critical | 25/25 |
| `src/Broiler.Native.Linux/Vulkan/LinuxVulkanDeviceInfo.cs` | 2 | 2 | 0 | 2 | Low | Low | 0/0 |
| `src/Broiler.Native.Linux/Vulkan/LinuxVulkanException.cs` | 3 | 3 | 0 | 3 | Low | Low | 0/0 |
| `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` | 70 | 25 | 45 | 25 | Low | Critical | 21/21 |
| `src/Broiler.Native.Windows/ComNative.cs` | 32 | 24 | 8 | 24 | Low | Critical | 24/24 |
| `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` | 14 | 11 | 3 | 11 | Low | Critical | 8/8 |
| `src/Broiler.Native.Windows/Direct2D/ComVtable.cs` | 3 | 3 | 0 | 3 | Low | Critical | 3/3 |
| `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` | 131 | 13 | 118 | 13 | Low | Critical | 13/13 |
| `src/Broiler.Native.Windows/Direct2D/D3D11Native.cs` | 22 | 1 | 21 | 1 | Low | None | 0/0 |
| `src/Broiler.Native.Windows/Direct2D/DWriteNative.cs` | 44 | 3 | 41 | 3 | Low | High | 3/3 |
| `src/Broiler.Native.Windows/Direct2D/Direct2DDeviceApi.cs` | 2 | 2 | 0 | 2 | Low | High | 2/2 |
| `src/Broiler.Native.Windows/Direct2D/Direct2DImageStoreApi.cs` | 2 | 2 | 0 | 2 | Low | Critical | 2/2 |
| `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` | 5 | 5 | 0 | 5 | Low | Critical | 5/5 |
| `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` | 25 | 25 | 0 | 25 | Low | Critical | 25/25 |
| `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` | 8 | 8 | 0 | 8 | Low | Critical | 8/8 |
| `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` | 8 | 8 | 0 | 8 | Low | Critical | 8/8 |
| `src/Broiler.Native.Windows/Direct2D/DirectWriteTextMetricsProviderApi.cs` | 3 | 3 | 0 | 3 | Low | Critical | 3/3 |
| `src/Broiler.Native.Windows/Direct2D/DxgiNative.cs` | 47 | 3 | 44 | 3 | Low | High | 3/3 |
| `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` | 7 | 7 | 0 | 7 | Low | Critical | 7/7 |
| `src/Broiler.Native.Windows/HwndNative.cs` | 2 | 2 | 0 | 2 | Low | High | 2/2 |
| `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` | 26 | 5 | 21 | 5 | Low | Critical | 5/5 |
| `src/Broiler.Native.Windows/Input/RawInputRegistrationNative.cs` | 14 | 3 | 11 | 3 | Low | Critical | 3/3 |
| `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` | 117 | 87 | 30 | 87 | Low | Critical | 87/87 |
| `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` | 31 | 31 | 0 | 31 | Low | Critical | 31/31 |
| `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` | 59 | 50 | 9 | 50 | Low | Critical | 49/49 |
| `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` | 22 | 5 | 17 | 5 | Low | High | 5/5 |
| `src/Broiler.Native.Windows/PerformanceCounterNative.cs` | 3 | 3 | 0 | 3 | Low | High | 3/3 |
| `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` | 114 | 56 | 58 | 56 | Low | Critical | 56/56 |
| `src/Broiler.Native.Windows/Wic/WicNative.cs` | 47 | 39 | 8 | 39 | Low | Critical | 39/39 |
| `src/Broiler.Native.Windows/WindowNative.cs` | 215 | 72 | 143 | 72 | Low | Critical | 70/70 |
| `src/Broiler.Native/NativeLibraryProbe.cs` | 2 | 2 | 0 | 2 | Low | High | 2/2 |

## 7. Decisions Recorded

No unit in this component carries a decision on its human line. Every one of them reads
`PENDING`.

## 8. Decisions The Code Has Outrun

No unit carries a decision that the code has since moved past.

## 9. Where A Decision Is Required First

The units at the top of the security vocabulary, with the observation that would show each
one wrong and the human line it carries. The set is read from the assessments rather than
written out, so a unit that becomes `High` joins it at the next generation.

- `Broiler.Native.Android.AndroidEglNative` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, Spec=ADR-0001, `CCDC42`, PENDING
  - Falsified if: ChooseConfig's configs array is not of pointer-sized EGLConfig handles, so on a 64-bit device eglChooseConfig writes 8-byte handles past the end of the pinned array
- `Broiler.Native.Android.AndroidEglNative.GetDisplay(IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `885D32`, PENDING
  - Falsified if: the displayId argument or the EGLDisplay return is declared narrower than a native pointer, so a 64-bit device passes or receives a truncated display handle
- `Broiler.Native.Android.AndroidEglNative.Initialize(IntPtr, out int, out int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `B5AA7C`, PENDING
  - Falsified if: the major or minor out parameter is not a 32-bit int, so the EGLint writes of eglInitialize overrun or truncate the managed locals
- `Broiler.Native.Android.AndroidEglNative.Terminate(IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `365B80`, PENDING
  - Falsified if: the EGLBoolean return of eglTerminate is not read as a 32-bit value, so an EGL_FALSE for an invalid display reads as success
- `Broiler.Native.Android.AndroidEglNative.BindApi(int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `D9992F`, PENDING
  - Falsified if: the EGLenum api argument is not passed as a 32-bit value, so EGL_OPENGL_ES_API reaches eglBindAPI as a different enum and the call fails with EGL_BAD_PARAMETER
- `Broiler.Native.Android.AndroidEglNative.ChooseConfig(IntPtr, int[], IntPtr[], int, out int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, Spec=none cited, `314663`, PENDING
  - Falsified if: configs is not marshalled as an array of pointer-sized EGLConfig handles, so on a 64-bit device eglChooseConfig writes 8-byte handles into 4-byte elements and runs past the pinned array
- `Broiler.Native.Android.AndroidEglNative.GetConfigAttrib(IntPtr, IntPtr, int, out int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `D9277A`, PENDING
  - Falsified if: the out value is not a 32-bit int, so the EGLint that eglGetConfigAttrib writes for EGL_NATIVE_VISUAL_ID is truncated or overruns the managed local
- `Broiler.Native.Android.AndroidEglNative.CreateContext(IntPtr, IntPtr, IntPtr, int[])` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, Spec=none cited, `B24254`, PENDING
  - Falsified if: attribList and shareContext reach eglCreateContext(EGLDisplay, EGLConfig, EGLContext, const EGLint*) in swapped positions, so EGL walks the share context's memory as an attribute list
- `Broiler.Native.Android.AndroidEglNative.DestroyContext(IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `4D4D42`, PENDING
  - Falsified if: the display and context arguments are in a different order than eglDestroyContext(EGLDisplay, EGLContext), so the call fails with EGL_BAD_DISPLAY and the context leaks
- `Broiler.Native.Android.AndroidEglNative.CreatePbufferSurface(IntPtr, IntPtr, int[])` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, Spec=none cited, `7ACFAF`, PENDING
  - Falsified if: config and attribList reach eglCreatePbufferSurface(EGLDisplay, EGLConfig, const EGLint*) in swapped positions, so EGL walks the config handle's memory as an attribute list
- `Broiler.Native.Android.AndroidEglNative.CreateWindowSurface(IntPtr, IntPtr, IntPtr, int[]?)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, Spec=none cited, `DAD63B`, PENDING
  - Falsified if: nativeWindow and attribList reach eglCreateWindowSurface(EGLDisplay, EGLConfig, EGLNativeWindowType, const EGLint*) in swapped positions, so EGL walks the ANativeWindow as an attribute list and takes the array as the window
- `Broiler.Native.Android.AndroidEglNative.DestroySurface(IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `A060B1`, PENDING
  - Falsified if: the display and surface arguments are in a different order than eglDestroySurface(EGLDisplay, EGLSurface), so the call fails with EGL_BAD_DISPLAY and the window buffers leak
- `Broiler.Native.Android.AndroidEglNative.MakeCurrent(IntPtr, IntPtr, IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `BA9F32`, PENDING
  - Falsified if: the draw and read arguments are in a different order than eglMakeCurrent(dpy, draw, read, ctx), so a context bound with distinct draw and read surfaces renders into the read surface
- `Broiler.Native.Android.AndroidEglNative.SwapBuffers(IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `1968CA`, PENDING
  - Falsified if: the EGLBoolean return of eglSwapBuffers is not read as a 32-bit value, so an EGL_FALSE for a surface whose ANativeWindow was destroyed is taken as a presented frame
- `Broiler.Native.Android.AndroidEglNative.SwapInterval(IntPtr, int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `2D465B`, PENDING
  - Falsified if: the interval argument is not passed as a 32-bit EGLint, so eglSwapInterval receives a different interval and vsync is not turned on or off as asked
- `Broiler.Native.Android.AndroidEglNative.QuerySurface(IntPtr, IntPtr, int, out int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `6B6DBC`, PENDING
  - Falsified if: the out value is not a 32-bit int, so the EGLint that eglQuerySurface writes for EGL_WIDTH or EGL_HEIGHT is truncated or overruns the managed local
- `Broiler.Native.Android.AndroidEglNative.GetError()` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `B71C87`, PENDING
  - Falsified if: the EGLint return of eglGetError is not read as a 32-bit value, so EGL_CONTEXT_LOST arrives as a different code and a lost context is not reported as one
- `Broiler.Native.Android.AndroidGlesNative` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `1454CE`, PENDING
  - Falsified if: the seven arguments reach glReadPixels out of order, so format and type arrive swapped and the driver writes another number of bytes per pixel through the caller's pixels pointer
- `Broiler.Native.Android.AndroidGlesNative.GenTextures(int, out uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `AD9690`, PENDING
  - Falsified if: a count above 1 makes glGenTextures write count names through the single out uint, past the caller's 4-byte slot
- `Broiler.Native.Android.AndroidGlesNative.DeleteTextures(int, ref uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `0A6CA2`, PENDING
  - Falsified if: a count above 1 makes glDeleteTextures read count names past the single ref uint and delete whatever textures the adjacent bytes name
- `Broiler.Native.Android.AndroidGlesNative.BindTexture(int, uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `38241C`, PENDING
  - Falsified if: the target and texture name reach glBindTexture swapped, so binding texture 1 to GL_TEXTURE_2D raises GL_INVALID_ENUM and binds nothing
- `Broiler.Native.Android.AndroidGlesNative.TexParameteri(int, int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `A34865`, PENDING
  - Falsified if: the parameter name and value reach glTexParameteri swapped, so setting GL_TEXTURE_MIN_FILTER to GL_LINEAR raises GL_INVALID_ENUM and the filter stays mipmapped
- `Broiler.Native.Android.AndroidGlesNative.TexImage2D(int, int, int, int, int, int, int, int, IntPtr)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `A9CDA8`, PENDING
  - Falsified if: the nine arguments reach glTexImage2D out of order, so format and type arrive swapped and the driver reads another number of bytes per pixel from the caller's pixels pointer
- `Broiler.Native.Android.AndroidGlesNative.GenFramebuffers(int, out uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `4EFD10`, PENDING
  - Falsified if: a count above 1 makes glGenFramebuffers write count names through the single out uint, past the caller's 4-byte slot
- `Broiler.Native.Android.AndroidGlesNative.DeleteFramebuffers(int, ref uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `9D2CF0`, PENDING
  - Falsified if: a count above 1 makes glDeleteFramebuffers read count names past the single ref uint and delete whatever framebuffers the adjacent bytes name
- `Broiler.Native.Android.AndroidGlesNative.BindFramebuffer(int, uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `BC9CAF`, PENDING
  - Falsified if: the target and framebuffer name reach glBindFramebuffer swapped, so binding framebuffer 1 to GL_READ_FRAMEBUFFER raises GL_INVALID_ENUM and leaves the default bound
- `Broiler.Native.Android.AndroidGlesNative.FramebufferTexture2D(int, int, int, uint, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `EC63D1`, PENDING
  - Falsified if: the texture name and level reach glFramebufferTexture2D in swapped positions, so attaching texture 3 at level 0 leaves the framebuffer incomplete
- `Broiler.Native.Android.AndroidGlesNative.CheckFramebufferStatus(int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `3C9771`, PENDING
  - Falsified if: the GLenum status comes back through a return other than a 32-bit unsigned value, so a complete framebuffer does not compare equal to GL_FRAMEBUFFER_COMPLETE
- `Broiler.Native.Android.AndroidGlesNative.Viewport(int, int, int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `71E586`, PENDING
  - Falsified if: the x, y, width and height reach glViewport in another order, so a 1080 by 1920 viewport is set as 1920 by 1080
- `Broiler.Native.Android.AndroidGlesNative.ClearColor(float, float, float, float)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `D00842`, PENDING
  - Falsified if: the four float components reach glClearColor in an order other than red, green, blue, alpha, so a clear to opaque red reads back as another colour
- `Broiler.Native.Android.AndroidGlesNative.Clear(int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `10E14B`, PENDING
  - Falsified if: the mask reaches glClear as a value other than the bitfield passed, so a GL_COLOR_BUFFER_BIT clear leaves the colour buffer unchanged
- `Broiler.Native.Android.AndroidGlesNative.ReadPixels(int, int, int, int, int, int, IntPtr)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `944115`, PENDING
  - Falsified if: the seven arguments reach glReadPixels out of order, so format and type arrive swapped and the driver writes another number of bytes per pixel through the caller's pixels pointer
- `Broiler.Native.Android.AndroidGlesNative.BlitFramebuffer(int, int, int, int, int, int, int, int, int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `EFD1E6`, PENDING
  - Falsified if: the ten arguments reach glBlitFramebuffer out of order, so a 640 by 480 source blitted to 1280 by 960 copies another rectangle or treats the filter as the mask
- `Broiler.Native.Android.AndroidGlesNative.PixelStorei(int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `8D640E`, PENDING
  - Falsified if: the name and value reach glPixelStorei swapped, so GL_PACK_ALIGNMENT stays 4 and ReadPixels pads rows past a buffer sized for alignment 1
- `Broiler.Native.Android.AndroidGlesNative.Enable(int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `E9E50C`, PENDING
  - Falsified if: the import binds to an entry point other than glEnable, so Enable(GL_SCISSOR_TEST) leaves scissoring off
- `Broiler.Native.Android.AndroidGlesNative.Disable(int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `D5E5DF`, PENDING
  - Falsified if: the import binds to an entry point other than glDisable, so Disable(GL_SCISSOR_TEST) leaves a scissor box clipping the clear and the blit
- `Broiler.Native.Android.AndroidGlesNative.Scissor(int, int, int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `5190C4`, PENDING
  - Falsified if: the x, y, width and height reach glScissor in another order, so a 100 by 50 box at the origin clips a 50 by 100 region instead
- `Broiler.Native.Android.AndroidGlesNative.Flush()` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `17C3C7`, PENDING
  - Falsified if: the import binds to an entry point other than glFlush, for example glFinish, so the call blocks until the GPU drains instead of returning after submission
- `Broiler.Native.Android.AndroidGlesNative.Finish()` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `539514`, PENDING
  - Falsified if: Finish returns while commands issued before it are still executing on the GPU
- `Broiler.Native.Android.AndroidGlesNative.GetError()` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `F60C77`, PENDING
  - Falsified if: after a call that raises GL_INVALID_ENUM, the first GetError returns something other than 0x500
- `Broiler.Native.Android.AndroidGlesNative.GetString(uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `D8D88A`, PENDING
  - Falsified if: the const GLubyte* result is declared narrower than a pointer, so on arm64 GetStringValue reads a driver string from a truncated address
- `Broiler.Native.Android.AndroidGlesNative.GetStringValue(uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `46DE45`, PENDING
  - Falsified if: a null pointer from glGetString, returned for an invalid name or with no current context, reaches PtrToStringAnsi instead of yielding an empty string
- `Broiler.Native.Android.AndroidGlesNative.ThrowIfError(string)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `A25A60`, PENDING
  - Falsified if: a second error flag still queued after the single glGetError read survives and makes the next, successful operation's check throw
- `Broiler.Native.Android.AndroidGlesNative.GetDriverInfo()` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `10652C`, PENDING
  - Falsified if: two of the GL_VENDOR, GL_RENDERER, GL_VERSION and GL_SHADING_LANGUAGE_VERSION queries are passed in swapped positions, so Renderer holds the version string
- `Broiler.Native.Android.AndroidNativeLibraries` in `src/Broiler.Native.Android/AndroidNativeLibraries.cs` - Security=High, Spec=ADR-0001, `D71B08`, PENDING
  - Falsified if: on a device without libGLESv3.so but with libGLESv2.so, a GLES import fails with DllNotFoundException instead of binding to libGLESv2.so
- `Broiler.Native.Android.AndroidNativeLibraries.s_gate` in `src/Broiler.Native.Android/AndroidNativeLibraries.cs` - Security=High, Spec=none cited, `E33051`, PENDING
  - Falsified if: concurrent first calls to EnsureRegistered do not serialize on this gate, so two of them call SetDllImportResolver and the second throws InvalidOperationException
- `Broiler.Native.Android.AndroidNativeLibraries.EnsureRegistered()` in `src/Broiler.Native.Android/AndroidNativeLibraries.cs` - Security=High, Spec=ADR-0001, `AFC9D0`, PENDING
  - Falsified if: two threads making the first call at the same time both reach SetDllImportResolver, and the second throws InvalidOperationException
- `Broiler.Native.Android.AndroidNativeLibraries.Resolve(string, Assembly, DllImportSearchPath?)` in `src/Broiler.Native.Android/AndroidNativeLibraries.cs` - Security=High, Spec=none cited, `CE82F0`, PENDING
  - Falsified if: an import name other than libEGL.so or libGLESv3.so, such as libandroid.so, is redirected to an EGL or GLES candidate instead of returning zero to the runtime's own probing
- `Broiler.Native.Android.AndroidNativeLibraries.TryLoadAny(IReadOnlyList<string>, out string)` in `src/Broiler.Native.Android/AndroidNativeLibraries.cs` - Security=High, Spec=none cited, `C11A03`, PENDING
  - Falsified if: a successful probe leaves the probed library loaded because the handle it opened is not freed before the name is reported
- `Broiler.Native.Android.AndroidNativeWindowNative` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=Critical, Spec=none cited, `8121EE`, PENDING
  - Falsified if: FromSurface's JNIEnv* and jobject arguments reach ANativeWindow_fromSurface in swapped order, so the NDK calls through the Surface handle as the JNI function table
- `Broiler.Native.Android.AndroidNativeWindowNative.FromSurface(IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=Critical, Spec=none cited, `F68393`, PENDING
  - Falsified if: the JNIEnv* and jobject arguments reach ANativeWindow_fromSurface in swapped order, so the Surface handle is dereferenced as the JNI function table
- `Broiler.Native.Android.AndroidNativeWindowNative.Acquire(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, Spec=none cited, `F2F5A1`, PENDING
  - Falsified if: Acquire does not add a reference, so a window released once by its other owner is freed while this caller still holds it
- `Broiler.Native.Android.AndroidNativeWindowNative.Release(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, Spec=none cited, `8A97DE`, PENDING
  - Falsified if: a window obtained from FromSurface keeps its extra reference after one Release call, so the ANativeWindow and its buffer queue outlive the host Surface
- `Broiler.Native.Android.AndroidNativeWindowNative.GetWidth(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, Spec=none cited, `914A39`, PENDING
  - Falsified if: for a window whose buffers were set to 640 by 480, GetWidth returns a value other than 640
- `Broiler.Native.Android.AndroidNativeWindowNative.GetHeight(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, Spec=none cited, `ABB058`, PENDING
  - Falsified if: for a window whose buffers were set to 640 by 480, GetHeight returns a value other than 480
- `Broiler.Native.Android.AndroidNativeWindowNative.GetFormat(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, Spec=none cited, `16B613`, PENDING
  - Falsified if: after SetBuffersGeometry with WindowFormatRgba8888 succeeds, GetFormat returns a value other than 1
- `Broiler.Native.Android.AndroidNativeWindowNative.SetBuffersGeometry(IntPtr, int, int, int)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, Spec=none cited, `5A7772`, PENDING
  - Falsified if: a 640 by 480 geometry returns 0 but GetWidth and GetHeight then report 480 by 640, showing the width and height reach the NDK swapped
- `Broiler.Native.Linux.Input.LinuxNativeMethods` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `C79A53`, PENDING
  - Falsified if: Read's count is declared narrower than size_t, so on x86-64 read(2) takes a byte count with undefined upper bits and writes evdev bytes past the end of the pinned array
- `Broiler.Native.Linux.Input.LinuxNativeMethods.Open(string, int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=High, Spec=none cited, `B96AC4`, PENDING
  - Falsified if: a pathname containing an embedded NUL character is truncated at the NUL by the UTF-8 marshaller, so open(2) opens a different node than the one named instead of failing
- `Broiler.Native.Linux.Input.LinuxNativeMethods.Read(int, byte[], nuint)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `B87244`, PENDING
  - Falsified if: count is declared narrower than size_t, so on x86-64 read(2) takes a byte count with undefined upper bits and writes evdev bytes past the end of the pinned array
- `Broiler.Native.Linux.Input.LinuxNativeMethods.Poll(PollFd[], nuint, int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `D0C8DE`, PENDING
  - Falsified if: nfds is declared narrower than nfds_t, so on x86-64 poll(2) takes an entry count with undefined upper bits and walks pollfd entries past the end of the pinned array
- `Broiler.Native.Linux.Input.LinuxNativeMethods.IoctlClockId(int, nuint, ref int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=High, Spec=none cited, `E09054`, PENDING
  - Falsified if: the clock id reaches ioctl(2) by value instead of as a pointer to a 32-bit int, so EVIOCSCLOCKID fails with EFAULT on every device
- `Broiler.Native.Linux.Input.LinuxNativeMethods.IoctlAbsInfo(int, nuint, byte[])` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `7FA6C0`, PENDING
  - Falsified if: request is declared narrower than unsigned long, so on x86-64 ioctl(2) receives an EVIOCGABS code with undefined upper bits and copies into the array under another request's size
- `Broiler.Native.Linux.Input.LinuxNativeMethods.TrySetMonotonicClock(int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=High, Spec=none cited, `3DDB0B`, PENDING
  - Falsified if: an EVIOCSCLOCKID ioctl that fails with -1 makes the method return true, so callers treat CLOCK_REALTIME event timestamps as monotonic
- `Broiler.Native.Linux.Input.LinuxNativeMethods.TryGetAbsInfo(int, ushort, out int, out int, out int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `77BE13`, PENDING
  - Falsified if: the buffer allocated here is shorter than the 24-byte size EviocgAbs encodes in the request, so the kernel copy of struct input_absinfo runs past the end of the array
- `Broiler.Native.Linux.Input.LinuxNativeMethods.EviocgAbs(ushort)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `817AD7`, PENDING
  - Falsified if: an abs argument above ABS_MAX (0x3f) is encoded without rejection, and 0xC6 yields 0x80184506, which is EVIOCGNAME(24) rather than an EVIOCGABS request
- `Broiler.Native.Linux.Input.LinuxNativeMethods.PollFd` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `D2661F`, PENDING
  - Falsified if: PollFd is not 8 bytes with Events and Revents as 16-bit fields at offsets 4 and 6, so poll(2) reads the event mask from and writes revents into the wrong bytes
- `Broiler.Native.Linux.OpenGL.LinuxEglNative` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, Spec=none cited, `9489E2`, PENDING
  - Falsified if: ChooseConfig's configs array is not of pointer-sized EGLConfig handles, so on x86-64 eglChooseConfig writes 8-byte handles past the end of the pinned array
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.GetDisplay(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `BD56B4`, PENDING
  - Falsified if: an Xlib Display pointer above 4 GiB passed as displayId reaches eglGetDisplay truncated to 32 bits, so EGL opens a different display or returns EGL_NO_DISPLAY
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.Initialize(IntPtr, out int, out int)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `89B711`, PENDING
  - Falsified if: eglInitialize returns EGL_TRUE but major and minor read back as 0 because the out parameters do not reach it as pointers to 32-bit EGLint
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.Terminate(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `C32377`, PENDING
  - Falsified if: an EGL_FALSE result from eglTerminate on an invalid display reads back nonzero because the 32-bit EGLBoolean return is marshalled at another width
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.BindApi(int)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `7F31B4`, PENDING
  - Falsified if: EGL_OPENGL_API passed here does not reach eglBindAPI as the 32-bit EGLenum 0x30A2, so the thread stays bound to OpenGL ES and the desktop context request fails
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.ChooseConfig(IntPtr, int[], IntPtr[], int, out int)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, Spec=none cited, `7A0D75`, PENDING
  - Falsified if: configs is not marshalled as an array of pointer-sized EGLConfig handles, so on x86-64 eglChooseConfig writes 8-byte handles into 4-byte elements and runs past the pinned array
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.CreateContext(IntPtr, IntPtr, IntPtr, int[])` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, Spec=none cited, `9110AD`, PENDING
  - Falsified if: attribList and shareContext reach eglCreateContext(EGLDisplay, EGLConfig, EGLContext, const EGLint*) in swapped positions, so EGL walks the share context's memory as an attribute list
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.DestroyContext(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `CEE9B9`, PENDING
  - Falsified if: an EGLContext handle reaches eglDestroyContext at other than pointer width, so it fails with EGL_BAD_CONTEXT and the driver context leaks
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.CreatePbufferSurface(IntPtr, IntPtr, int[])` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, Spec=none cited, `E5C06E`, PENDING
  - Falsified if: config and attribList reach eglCreatePbufferSurface(EGLDisplay, EGLConfig, const EGLint*) in swapped positions, so EGL walks the config handle's memory as an attribute list
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.CreateWindowSurface(IntPtr, IntPtr, IntPtr, int[])` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, Spec=none cited, `26BB95`, PENDING
  - Falsified if: nativeWindow and attribList reach eglCreateWindowSurface(EGLDisplay, EGLConfig, EGLNativeWindowType, const EGLint*) in swapped positions, so EGL walks the X window id as an attribute list and takes the array address as the window
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.DestroySurface(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `645A11`, PENDING
  - Falsified if: an EGLSurface handle reaches eglDestroySurface at other than pointer width, so it fails with EGL_BAD_SURFACE and the surface buffers leak
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.MakeCurrent(IntPtr, IntPtr, IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `B3981D`, PENDING
  - Falsified if: the draw and read arguments reach eglMakeCurrent in an order other than display, draw, read, context, so reads come from the wrong surface or EGL_BAD_MATCH is raised
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.SwapBuffers(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `BE06C5`, PENDING
  - Falsified if: an EGL_FALSE result for a lost or invalid surface reads back nonzero because the 32-bit EGLBoolean return is marshalled at another width, so a failed present is treated as success
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.GetError()` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `7C4EE1`, PENDING
  - Falsified if: the error read after a failed EGL call is the process errno rather than the calling thread's eglGetError code, so EGL_BAD_ALLOC (0x3003) is reported as an unrelated value
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.GetProcAddress(string)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `774421`, PENDING
  - Falsified if: the function pointer eglGetProcAddress returns is truncated to 32 bits on x86-64, so a delegate built from it jumps to an unrelated address
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `B1E919`, PENDING
  - Falsified if: GlReadPixelsProc's seven declared parameters differ in order from glReadPixels(x, y, width, height, format, type, pixels), so format and type arrive swapped and the driver writes another number of bytes per pixel through the pixels pointer
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.LinuxOpenGlFunctions()` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `A9BC99`, PENDING
  - Falsified if: an entry-point name is paired with a delegate type whose parameter list differs from that function's gl.h prototype (for example glReadPixels loaded as GlTexImage2DProc), so calls through that field hand the driver a mismatched argument list
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.LoadCurrentContext()` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `9FD27C`, PENDING
  - Falsified if: it returns a function table when no EGL context is current on the calling thread, and the first GL call through that table dispatches into a driver with no context bound
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GetString(uint)` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `525EF7`, PENDING
  - Falsified if: a NULL from glGetString, returned when no context is current, is passed to PtrToStringAnsi or reported as an empty string rather than as unavailable
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GetDriverInfo()` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `AAF5FB`, PENDING
  - Falsified if: two of the GL_VENDOR, GL_RENDERER, GL_VERSION and GL_SHADING_LANGUAGE_VERSION queries are passed in swapped positions, so Renderer holds the version string
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.ThrowIfError(string)` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `470A06`, PENDING
  - Falsified if: glGetError is read only once, so when several error flags are recorded the remaining ones survive and a later ThrowIfError reports them against an unrelated operation
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.Load<TDelegate>(string)` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `0A9223`, PENDING
  - Falsified if: a function name the driver does not implement still yields a non-zero pointer from eglGetProcAddress, which EGL permits, so Load returns a delegate and the first call jumps into an unsupported entry
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlGenTexturesProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `A6564B`, PENDING
  - Falsified if: n greater than 1 makes glGenTextures write n texture names through the out pointer to a single uint, overwriting the caller's memory after it
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlDeleteTexturesProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `987158`, PENDING
  - Falsified if: n greater than 1 makes glDeleteTextures read n names through the ref pointer to a single uint and delete textures named by whatever memory follows it
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlBindTextureProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `86B3EB`, PENDING
  - Falsified if: the declared parameters differ from glBindTexture(GLenum target, GLuint texture), for example a 64-bit texture name, so on 32-bit x86 the driver reads the name from the wrong stack slot
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlTexParameteriProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `72149D`, PENDING
  - Falsified if: the declared parameters differ from glTexParameteri(GLenum, GLenum, GLint), for example a float param, so the filter or wrap value arrives in a floating-point register the driver never reads
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlTexImage2DProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `53B054`, PENDING
  - Falsified if: the nine declared parameters differ in order from glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels), so format and type arrive swapped and the driver reads another number of bytes per pixel from the pixels pointer
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlGenFramebuffersProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `918023`, PENDING
  - Falsified if: n greater than 1 makes glGenFramebuffers write n framebuffer names through the out pointer to a single uint, overwriting the caller's memory after it
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlDeleteFramebuffersProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `74B8E4`, PENDING
  - Falsified if: n greater than 1 makes glDeleteFramebuffers read n names through the ref pointer to a single uint and delete framebuffers named by whatever memory follows it
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlBindFramebufferProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `E22C59`, PENDING
  - Falsified if: the declared parameters differ from glBindFramebuffer(GLenum target, GLuint framebuffer), for example a 64-bit framebuffer name, so on 32-bit x86 the driver reads the name from the wrong stack slot
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlFramebufferTexture2DProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `89CAEA`, PENDING
  - Falsified if: the five declared parameters differ in order from glFramebufferTexture2D(target, attachment, textarget, texture, level), so the texture name is passed as the mip level and the attachment stays empty
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlCheckFramebufferStatusProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `7B20CF`, PENDING
  - Falsified if: the return type is not the 32-bit unsigned GLenum of glCheckFramebufferStatus, so the returned status never equals GL_FRAMEBUFFER_COMPLETE (0x8CD5) and a complete framebuffer is rejected
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlViewportProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `45AE3A`, PENDING
  - Falsified if: the declared parameters differ from glViewport(GLint x, GLint y, GLsizei width, GLsizei height), for example width and height swapped, so a non-square surface renders into a transposed viewport
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlClearColorProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `181780`, PENDING
  - Falsified if: a component is declared as double instead of the gl.h GLfloat, so the driver reads red, green, blue and alpha from the wrong floating-point registers or stack slots
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlClearProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `ED39A6`, PENDING
  - Falsified if: the mask is not passed as the 32-bit GLbitfield of glClear(GLbitfield mask), so GL_COLOR_BUFFER_BIT arrives as a different bit set and the colour buffer is not cleared
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlReadPixelsProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `4D8968`, PENDING
  - Falsified if: the seven declared parameters differ in order from glReadPixels(x, y, width, height, format, type, pixels), so format and type arrive swapped and the driver writes another number of bytes per pixel through the pixels pointer
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlBlitFramebufferProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `2FE5E1`, PENDING
  - Falsified if: the ten declared parameters differ in order from glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter), so the source and destination rectangles are swapped or the filter is read as a coordinate
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlPixelStoreiProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `C7EF03`, PENDING
  - Falsified if: the declared parameters differ from glPixelStorei(GLenum pname, GLint param), for example param before pname, so the row alignment of 1 is never set and later pixel transfers assume padded rows
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlEnableProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `DE694A`, PENDING
  - Falsified if: the cap is not passed as the 32-bit GLenum of glEnable(GLenum cap), so GL_SCISSOR_TEST is not enabled and a later glClear covers the whole framebuffer
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlDisableProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `524E32`, PENDING
  - Falsified if: the cap is not passed as the 32-bit GLenum of glDisable(GLenum cap), so GL_SCISSOR_TEST stays enabled and later clears and blits are clipped to a stale rectangle
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlScissorProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `EB992B`, PENDING
  - Falsified if: the declared parameters differ from glScissor(GLint x, GLint y, GLsizei width, GLsizei height), for example width and height swapped, so a clear meant for one rectangle paints a transposed one
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlFlushProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `89AA1E`, PENDING
  - Falsified if: the delegate declares an argument or result that glFlush(void) does not have, so the call marshals a value the driver entry never takes or returns a register value it never set
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlGetErrorProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `8ACE41`, PENDING
  - Falsified if: the return type is not the 32-bit unsigned GLenum of glGetError(void), so an error such as GL_OUT_OF_MEMORY (0x0505) reaches ThrowIfError truncated or as zero
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlGetStringProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `C7F9A4`, PENDING
  - Falsified if: the const GLubyte pointer return is declared as a 32-bit int, so on 64-bit Linux the driver's string address is truncated before GetString reads it
- `Broiler.Native.Linux.OpenGL.LinuxX11Native` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=Critical, Spec=none cited, `96F4E9`, PENDING
  - Falsified if: SetWmProtocols's Atom array does not use pointer-sized elements, so on x86-64 XSetWMProtocols reads 8-byte Atoms from 4-byte elements and runs past the end of the pinned array
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.OpenDisplay(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=Critical, Spec=none cited, `929967`, PENDING
  - Falsified if: displayName is declared narrower than a pointer, so on x86-64 XOpenDisplay reads the display name through a truncated address
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.CloseDisplay(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `876CC0`, PENDING
  - Falsified if: the display argument is declared narrower than a pointer, so on x86-64 XCloseDisplay receives a truncated Display* and frees memory at an unrelated address
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.DefaultScreen(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `84D7AA`, PENDING
  - Falsified if: the import binds XDefaultScreenOfDisplay rather than XDefaultScreen, so a Screen* truncated to int is returned as the screen number
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.RootWindow(IntPtr, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `0B2C4A`, PENDING
  - Falsified if: the Window return is declared narrower than C unsigned long, so on x86-64 the root window id read back is truncated and XCreateSimpleWindow is given another parent
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.BlackPixel(IntPtr, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `224BE2`, PENDING
  - Falsified if: the pixel return is declared narrower than C unsigned long, so on x86-64 the border colour passed on to XCreateSimpleWindow carries undefined upper bits
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.WhitePixel(IntPtr, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `48663B`, PENDING
  - Falsified if: the pixel return is declared narrower than C unsigned long, so on x86-64 the background colour passed on to XCreateSimpleWindow carries undefined upper bits
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.CreateSimpleWindow(IntPtr, IntPtr, int, int, uint, uint, uint, IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `464005`, PENDING
  - Falsified if: border or background is declared narrower than C unsigned long, so these stack-passed arguments reach XCreateSimpleWindow with undefined upper bytes on x86-64
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.StoreName(IntPtr, IntPtr, string)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `EEE573`, PENDING
  - Falsified if: the title is marshalled as UTF-16 or without a terminating NUL, so XStoreName reads past the end of the marshalled buffer
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.SelectInput(IntPtr, IntPtr, long)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `46FCB1`, PENDING
  - Falsified if: eventMask is passed with a width other than C long, so on LP64 Xlib reads undefined upper bits and selects event classes that were not requested
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.MapWindow(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `8B669F`, PENDING
  - Falsified if: the window XID is declared narrower than C unsigned long, so XMapWindow receives an XID with undefined upper bits and maps another window or raises BadWindow
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.ResizeWindow(IntPtr, IntPtr, uint, uint)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `98C0F3`, PENDING
  - Falsified if: width and height reach XResizeWindow in swapped positions, so a resize to 800 by 600 is followed by a ConfigureNotify reporting 600 by 800
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.DestroyWindow(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `79BA88`, PENDING
  - Falsified if: the display and window arguments reach XDestroyWindow(Display*, Window) in swapped positions, so Xlib dereferences the window id as the connection pointer
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.Flush(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `F8DD82`, PENDING
  - Falsified if: the import binds XSync or another export instead of XFlush, so the call blocks on a server round trip or drops queued events instead of only sending buffered requests
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.Pending(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `B97E6E`, PENDING
  - Falsified if: the import binds XEventsQueued or another export instead of XPending, so events still unread on the connection are not counted and the loop stops reading while events are waiting
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.NextEvent(IntPtr, out XEvent)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `70D77F`, PENDING
  - Falsified if: Xlib's XEvent on the target is larger than the 192-byte managed struct, so XNextEvent writes past the out local
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.InternAtom(IntPtr, string, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `C1DAEF`, PENDING
  - Falsified if: the atom name is marshalled as UTF-16 or without a terminating NUL, so the server interns a different atom than the one named, such as _NET_WM_NAME
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.ChangeProperty(IntPtr, IntPtr, IntPtr, IntPtr, int, int, byte[], int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=Critical, Spec=none cited, `618340`, PENDING
  - Falsified if: data and elementCount reach XChangeProperty in swapped positions, so the element count is dereferenced as the property data and the array address is taken as the count
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.SetWmProtocols(IntPtr, IntPtr, IntPtr[], int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=Critical, Spec=none cited, `D252C5`, PENDING
  - Falsified if: protocols is not marshalled as an array of pointer-sized Atoms, so on x86-64 XSetWMProtocols reads 8-byte Atoms from 4-byte elements and runs past the end of the pinned array
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.SetInputFocus(IntPtr, IntPtr, int, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `54C7BF`, PENDING
  - Falsified if: time is declared int while Xlib's Time is a 64-bit unsigned long on LP64, so XSetInputFocus receives a register whose upper half the caller never defined
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.QueryPointer(IntPtr, IntPtr, out IntPtr, out IntPtr, out int, out int, out int, out int, out uint)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `C89EB0`, PENDING
  - Falsified if: rootReturn or childReturn is declared narrower than the 64-bit Window Xlib writes, so XQueryPointer writes past those out locals
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.Sync(IntPtr, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `B4629B`, PENDING
  - Falsified if: the import binds an export other than XSync, such as XFlush, so a sync returns before the server has processed the queued requests and the ConfigureNotify they cause is not yet queued
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.GetInputFocus(IntPtr, out IntPtr, out int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `1B3468`, PENDING
  - Falsified if: focusReturn is declared narrower than the 64-bit Window Xlib writes, so XGetInputFocus writes past the out local
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.SetErrorHandler(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `36F83B`, PENDING
  - Falsified if: the handler argument or the previous-handler return is declared narrower than a function pointer, so on x86-64 Xlib installs a truncated handler address and the next protocol error jumps to it
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.XEvent` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `803926`, PENDING
  - Falsified if: on 64-bit Linux the bytes at offsets 56 and 60 are not XConfigureEvent width and height, or offset 56 is not XClientMessageEvent data.l[0], so resizes and close requests are read from the wrong bytes
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `E46435`, PENDING
  - Falsified if: vkEnumeratePhysicalDevices or vkGetPhysicalDeviceQueueFamilyProperties receives its count and array arguments in swapped positions, so the driver writes handles or 24-byte entries through the count's address
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetSupportedInstanceVersion()` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, Spec=none cited, `06A932`, PENDING
  - Falsified if: a Vulkan 1.0 loader that does not export vkEnumerateInstanceVersion makes the method throw instead of returning version 1.0.0
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.ThrowIfFailed(int, string)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, Spec=none cited, `1B627A`, PENDING
  - Falsified if: a negative VkResult such as VK_ERROR_INITIALIZATION_FAILED (-3) returns without throwing, so the caller goes on to use the out handle of a failed call
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetPhysicalDeviceInfo(IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `1AD6E2`, PENDING
  - Falsified if: the 256-byte deviceName copy starts at an offset other than 20 of VkPhysicalDeviceProperties, so the reported name includes deviceType bytes or runs into pipelineCacheUUID
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.EnumerateInstanceVersion(out uint)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, Spec=none cited, `205D93`, PENDING
  - Falsified if: apiVersion is declared with a width other than uint32_t, so the loader's write leaves part of the out local undefined or overruns it
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.CreateInstance(ref VkInstanceCreateInfo, IntPtr, out IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `5CE6EF`, PENDING
  - Falsified if: createInfo and allocator reach vkCreateInstance(const VkInstanceCreateInfo*, const VkAllocationCallbacks*, VkInstance*) in swapped positions, so the loader calls through the create-info fields as allocation callbacks
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.DestroyInstance(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `98A399`, PENDING
  - Falsified if: instance and allocator reach vkDestroyInstance(VkInstance, const VkAllocationCallbacks*) in swapped positions, so the loader reads allocation callbacks through the instance handle
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.EnumeratePhysicalDevices(IntPtr, ref uint, IntPtr[]?)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `0003C3`, PENDING
  - Falsified if: physicalDevices is not marshalled as an out array of pointer-sized handles, so the loader writes 8-byte VkPhysicalDevice handles into narrower elements and runs past the pinned array
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetPhysicalDeviceQueueFamilyProperties(IntPtr, ref uint, VkQueueFamilyProperties[]?)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `8B21E9`, PENDING
  - Falsified if: the count and the properties array reach vkGetPhysicalDeviceQueueFamilyProperties in swapped positions, so the driver writes the family count through the array and 24-byte entries through the count's address
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetPhysicalDeviceProperties(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `89BCFE`, PENDING
  - Falsified if: physicalDevice and properties reach vkGetPhysicalDeviceProperties in swapped positions, so the driver writes the 824-byte properties structure over the physical-device object
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.CreateDevice(IntPtr, ref VkDeviceCreateInfo, IntPtr, out IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `59040F`, PENDING
  - Falsified if: createInfo and allocator reach vkCreateDevice(VkPhysicalDevice, const VkDeviceCreateInfo*, const VkAllocationCallbacks*, VkDevice*) in swapped positions, so the driver calls through the create-info fields as allocation callbacks
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.DestroyDevice(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `19195C`, PENDING
  - Falsified if: device and allocator reach vkDestroyDevice(VkDevice, const VkAllocationCallbacks*) in swapped positions, so the driver reads allocation callbacks through the device handle
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetDeviceQueue(IntPtr, uint, uint, out IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, Spec=none cited, `933A0D`, PENDING
  - Falsified if: queueFamilyIndex and queueIndex reach vkGetDeviceQueue(VkDevice, uint32_t, uint32_t, VkQueue*) in swapped positions, so the queue at index 1 of family 0 is requested as index 0 of family 1
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.DeviceWaitIdle(IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, Spec=none cited, `3C80E2`, PENDING
  - Falsified if: the import binds an export other than vkDeviceWaitIdle, such as vkQueueWaitIdle, so the call returns while work on the device's other queues is still running
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkApplicationInfo` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `2B62F4`, PENDING
  - Falsified if: Marshal.SizeOf is not 48 on 64-bit or apiVersion is not at offset 44, so the loader reads the requested API version from the wrong bytes
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkInstanceCreateInfo` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `D473E7`, PENDING
  - Falsified if: Marshal.SizeOf is not 64 on 64-bit or ppEnabledExtensionNames is not at offset 56, so the loader treats a count or padding as a pointer
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkDeviceQueueCreateInfo` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `3020AD`, PENDING
  - Falsified if: Marshal.SizeOf is not 40 on 64-bit or pQueuePriorities is not at offset 32, so the driver reads queue priorities through the wrong bytes
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkDeviceCreateInfo` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `CADF59`, PENDING
  - Falsified if: Marshal.SizeOf is not 72 on 64-bit or pEnabledFeatures is not at offset 64, so the driver dereferences a count or padding as the features pointer
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkQueueFamilyProperties` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `243E73`, PENDING
  - Falsified if: Marshal.SizeOf is not 24, so the driver's array writes use a different stride than the managed elements and overrun the last one
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkExtent3D` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `BD2FAE`, PENDING
  - Falsified if: a field is not a 32-bit unsigned value, so the struct is not 12 bytes and VkQueueFamilyProperties no longer matches the driver's 24-byte entries
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.ReadUInt32(IntPtr, int)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `B56DE7`, PENDING
  - Falsified if: the value is read at the buffer plus offset times four rather than plus offset, so vendorId at offset 8 is taken from byte 32
- `Broiler.Native.Windows.IStream` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `72C7E0`, PENDING
  - Falsified if: a member declared out of objidl.h IStream order (Read, Write, Seek, SetSize, CopyTo, Commit, Revert, LockRegion, UnlockRegion, Stat, Clone after IUnknown) sends a call such as Read with a caller buffer to a different native slot
- `Broiler.Native.Windows.IStream.Read(IntPtr, uint, out uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `EBC476`, PENDING
  - Falsified if: Read is not vtable slot 3, the first ISequentialStream method after IUnknown, so a read request reaches Write and the stream copies cb bytes out of the caller's buffer instead of into it
- `Broiler.Native.Windows.IStream.Write(IntPtr, uint, out uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `2AC1C9`, PENDING
  - Falsified if: Write is not vtable slot 4, directly after Read, so a write request reaches Read and the stream copies cb bytes into the caller's buffer instead of out of it
- `Broiler.Native.Windows.IStream.Seek(long, uint, out ulong)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `2AF8C4`, PENDING
  - Falsified if: Seek(-1, STREAM_SEEK_CUR) does not move the position back by one byte, showing dlibMove is not passed as a signed 64-bit LARGE_INTEGER
- `Broiler.Native.Windows.IStream.SetSize(ulong)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `107363`, PENDING
  - Falsified if: SetSize(n) followed by a seek to the end reports a position other than n, showing libNewSize does not reach IStream::SetSize as a 64-bit ULARGE_INTEGER
- `Broiler.Native.Windows.IStream.CopyTo(IStream, ulong, out ulong, out ulong)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `8B6736`, PENDING
  - Falsified if: after CopyTo of n bytes between two HGlobal streams pcbRead or pcbWritten differs from n, showing the two ULARGE_INTEGER out pointers are swapped or narrowed
- `Broiler.Native.Windows.IStream.Commit(uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `6A4557`, PENDING
  - Falsified if: Commit(STGC_DEFAULT) on a CreateStreamOnHGlobal stream returns a failure or changes its size or position, showing the call reaches a slot other than IStream::Commit
- `Broiler.Native.Windows.IStream.Revert()` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `94840D`, PENDING
  - Falsified if: Revert on a CreateStreamOnHGlobal stream returns a failure or changes its size or seek position, showing the call reaches a slot other than IStream::Revert
- `Broiler.Native.Windows.IStream.LockRegion(ulong, ulong, uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `DD2680`, PENDING
  - Falsified if: LockRegion on a CreateStreamOnHGlobal stream returns something other than STG_E_INVALIDFUNCTION (0x80030001), showing the call reaches a slot other than IStream::LockRegion
- `Broiler.Native.Windows.IStream.UnlockRegion(ulong, ulong, uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `0DB8D7`, PENDING
  - Falsified if: UnlockRegion on a CreateStreamOnHGlobal stream returns something other than STG_E_INVALIDFUNCTION (0x80030001), showing the call reaches a slot other than IStream::UnlockRegion
- `Broiler.Native.Windows.IStream.Stat(IntPtr, uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `D1A188`, PENDING
  - Falsified if: Stat is not vtable slot 12, after UnlockRegion, so a stat request reaches Clone and an IStream pointer is written into the STATSTG buffer
- `Broiler.Native.Windows.IStream.Clone(out IStream)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `C91B52`, PENDING
  - Falsified if: moving the seek pointer of the stream returned by Clone also moves the original's, or the clone does not read the original's bytes, showing the call reaches a slot other than IStream::Clone
- `Broiler.Native.Windows.ComNative` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `E10EF6`, PENDING
  - Falsified if: ReleaseIUnknown lowers a non-null pointer's reference count by other than exactly one, or CoTaskMemFree binds an export other than ole32's, so an object or block another holder still uses is freed
- `Broiler.Native.Windows.ComNative.s_comWrappers` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `2EB7A1`, PENDING
  - Falsified if: a pointer wrapped through this instance cannot be cast to a [GeneratedComInterface] interface the native object implements, showing the instance lacks the source-generated interface strategy
- `Broiler.Native.Windows.ComNative.CoInitializeEx(IntPtr, uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `29F17C`, PENDING
  - Falsified if: CoInitializeEx with COINIT_MULTITHREADED on a thread already in a single-threaded apartment returns something other than RPC_E_CHANGED_MODE, showing the HRESULT is not returned unchanged
- `Broiler.Native.Windows.ComNative.CoUninitialize()` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `1CDFE8`, PENDING
  - Falsified if: the import binds an export other than ole32's CoUninitialize, so the thread's apartment initialisation count is not lowered and a later CoInitializeEx on it still returns S_FALSE
- `Broiler.Native.Windows.ComNative.CoTaskMemFree(IntPtr)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `396F43`, PENDING
  - Falsified if: the import binds an export other than ole32's CoTaskMemFree, such as GlobalFree, so a string returned by IMMDevice.GetId is released to another heap
- `Broiler.Native.Windows.ComNative.CoCreateInstance(in Guid, IntPtr, uint, in Guid, out IntPtr)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `F9E5E6`, PENDING
  - Falsified if: rclsid or riid is passed by value rather than as a REFCLSID or REFIID pointer, so ole32 reads the first bytes of the GUID as an address
- `Broiler.Native.Windows.ComNative.CoCreateInstance(ref Guid, IntPtr, uint, ref Guid, out object?)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `4C1BCE`, PENDING
  - Falsified if: the object returned on success is not a built-in runtime-callable wrapper, so ComNative.ReleaseComObject leaves the activation's native reference held until finalization
- `Broiler.Native.Windows.ComNative.CoCreateInstance(in Guid, IntPtr, uint, in Guid, out WicNative.IWICImagingFactory)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `DE546D`, PENDING
  - Falsified if: after a successful call the activation's own +1 out reference is still held once the managed IWICImagingFactory wrapper has been collected, showing the generated marshaller kept it as well as the wrapper's reference
- `Broiler.Native.Windows.ComNative.CreateStreamOnHGlobal(IntPtr, bool, out IStream)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `B90342`, PENDING
  - Falsified if: fDeleteOnRelease is not marshalled as a 4-byte BOOL, so a false request reaches ole32 with stray upper bytes and the stream frees an HGLOBAL the caller still owns
- `Broiler.Native.Windows.ComNative.GetOrCreateComObject<TInterface>(IntPtr)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `92D005`, PENDING
  - Falsified if: after the caller releases its own reference to comPointer the returned wrapper points at a destroyed object, showing the wrapper took no native reference of its own
- `Broiler.Native.Windows.ComNative.ReleaseIUnknown(IntPtr)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `455A91`, PENDING
  - Falsified if: one call on a non-null pointer lowers its native reference count by other than exactly one
- `Broiler.Native.Windows.ComNative.ReleaseComObject(object?)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `EFB4EB`, PENDING
  - Falsified if: a source-generated ComObject (from a [GeneratedComInterface] out parameter or GetOrCreateComObject) is neither IsComObject nor IDisposable, so the call returns with its native reference still held until finalization
- `Broiler.Native.Windows.Direct2D.ComPtr` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=Critical, Spec=none cited, `2776DD`, PENDING
  - Falsified if: a second Dispose or Release on the same ComPtr calls IUnknown::Release (slot 2) again for the one owned reference, dropping the native count below the references held
- `Broiler.Native.Windows.Direct2D.ComPtr.QueryInterfaceProc` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=High, Spec=none cited, `0E802B`, PENDING
  - Falsified if: on 32-bit x86 a call through this delegate leaves the stack unbalanced or returns a garbage result, showing its convention or parameters differ from IUnknown::QueryInterface(this, REFIID, void**)
- `Broiler.Native.Windows.Direct2D.ComPtr.AddRefProc` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=High, Spec=none cited, `BE262F`, PENDING
  - Falsified if: on 32-bit x86 a call through this delegate leaves the stack unbalanced, showing its convention or parameters differ from IUnknown::AddRef(this)
- `Broiler.Native.Windows.Direct2D.ComPtr.ReleaseProc` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=High, Spec=none cited, `CAFAC2`, PENDING
  - Falsified if: on 32-bit x86 a call through this delegate leaves the stack unbalanced, showing its convention or parameters differ from IUnknown::Release(this)
- `Broiler.Native.Windows.Direct2D.ComPtr.Attach(IntPtr)` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=Critical, Spec=none cited, `3AC576`, PENDING
  - Falsified if: attaching a fresh +1 reference equal to the pointer already held returns early, so one of the two references is never released
- `Broiler.Native.Windows.Direct2D.ComPtr.AddRef()` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=Critical, Spec=none cited, `C690D9`, PENDING
  - Falsified if: AddRef calls a vtable slot other than 1, so the native count Marshal.AddRef reports afterwards is not exactly one higher
- `Broiler.Native.Windows.Direct2D.ComPtr.QueryInterface(in Guid, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=Critical, Spec=none cited, `58EA68`, PENDING
  - Falsified if: QueryInterface for IID_IUnknown returns S_OK with a result different from Marshal.QueryInterface's for the same object, showing slot 0 or the riid pointer is mis-marshalled
- `Broiler.Native.Windows.Direct2D.ComPtr.Release()` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=Critical, Spec=none cited, `AA80BA`, PENDING
  - Falsified if: a second Release or Dispose after the first calls slot 2 again instead of returning 0, dropping the native count below the references held
- `Broiler.Native.Windows.Direct2D.ComVtable` in `src/Broiler.Native.Windows/Direct2D/ComVtable.cs` - Security=Critical, Spec=none cited, `A7E366`, PENDING
  - Falsified if: a function pointer shared by two methods with different signatures is called through the delegate type cached for the other method, corrupting the arguments or the stack
- `Broiler.Native.Windows.Direct2D.ComVtable.Delegates` in `src/Broiler.Native.Windows/Direct2D/ComVtable.cs` - Security=Critical, Spec=none cited, `907F1B`, PENDING
  - Falsified if: a lookup for one function pointer with two delegate types returns the delegate built for the first type
- `Broiler.Native.Windows.Direct2D.ComVtable.Method<TDelegate>(IntPtr, int)` in `src/Broiler.Native.Windows/Direct2D/ComVtable.cs` - Security=Critical, Spec=none cited, `22A61E`, PENDING
  - Falsified if: the function returned for slot n is not the pointer stored at the vtable plus n times IntPtr.Size, for example slot 2 on x64 yields the entry at byte 8 instead of byte 16
- `Broiler.Native.Windows.Direct2D.D2DNative` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, Spec=none cited, `5336C0`, PENDING
  - Falsified if: a structure here is not laid out as in d2d1.h and d2d1_1.h, for example D2D1_MAPPED_RECT without Bits at offset 8 on x64, so the readback after Map copies Pitch times height bytes from a pointer that is not the mapped bitmap
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_SIZE_U` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, Spec=none cited, `9B8A78`, PENDING
  - Falsified if: the struct is not two consecutive 32-bit unsigned integers, Width then Height (8 bytes), so CreateBitmap reads more or wider rows from the pinned source buffer than the caller sized from Width and Height
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_MAPPED_RECT` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, Spec=none cited, `A8FA51`, PENDING
  - Falsified if: on x64 Bits is not at offset 8 after the 32-bit Pitch and 4 bytes of padding (16 bytes in all), so the readback copy after Map walks Pitch times height bytes from a pointer that is not the mapped bitmap
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_PIXEL_FORMAT` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, Spec=none cited, `89F880`, PENDING
  - Falsified if: Format and AlphaMode are not two consecutive 32-bit fields in that order (8 bytes), so CreateBitmap takes the alpha mode as the DXGI format and reads more bytes per pixel than the caller's pitch-by-height source buffer holds
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_BITMAP_PROPERTIES` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, Spec=none cited, `D33E87`, PENDING
  - Falsified if: the struct is not an 8-byte D2D1_PIXEL_FORMAT followed by DpiX and DpiY floats (16 bytes), so CreateBitmap takes its pixel format from the wrong bytes and sizes its read of the source buffer from a wrong bytes-per-pixel
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_BITMAP_PROPERTIES1` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, Spec=none cited, `651843`, PENDING
  - Falsified if: on x64 ColorContext is not at offset 24 after BitmapOptions and 4 bytes of padding (32 bytes in all), so CreateBitmap1 or CreateBitmapFromDxgiSurface dereferences a garbage ID2D1ColorContext pointer
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_COLOR_F` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, Spec=none cited, `20006A`, PENDING
  - Falsified if: the struct is not four consecutive floats R, G, B, A (16 bytes) as D3DCOLORVALUE, so Clear and CreateSolidColorBrush read the channels in another order
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_POINT_2F` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, Spec=none cited, `FDCA31`, PENDING
  - Falsified if: the struct is not two consecutive 32-bit floats, X then Y (8 bytes), so AddLines reads pointsCount entries at the native 8-byte stride past the end of a managed array laid out with another element size
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_RECT_F` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, Spec=none cited, `5A4C8B`, PENDING
  - Falsified if: the struct is not four floats Left, Top, Right, Bottom in that order (16 bytes), so FillRectangle, PushAxisAlignedClip and the DrawText layout rectangle receive swapped edges and paint or clip page content in the wrong place
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_ROUNDED_RECT` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, Spec=none cited, `B27539`, PENDING
  - Falsified if: the struct is not a 16-byte D2D1_RECT_F followed by RadiusX and RadiusY floats (24 bytes), so FillRoundedRectangle and DrawRoundedRectangle take the radii from the rectangle
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_MATRIX_3X2_F` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, Spec=none cited, `440448`, PENDING
  - Falsified if: the six floats are not in the d2d1.h _11, _12, _21, _22, _31, _32 order, so SetTransform applies a transposed matrix or takes the translation from the shear terms and page content is drawn in the wrong place
- `Broiler.Native.Windows.Direct2D.D2DNative.CreateDeviceContextProc` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, Spec=none cited, `F3DA9B`, PENDING
  - Falsified if: the 32-bit options argument or the ID2D1DeviceContext** out parameter differs from ID2D1Device::CreateDeviceContext in d2d1_1.h, so the new context is written through a mismatched argument and its +1 reference is never released
- `Broiler.Native.Windows.Direct2D.D2DNative.SetTargetProc` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, Spec=none cited, `307319`, PENDING
  - Falsified if: the void return or the single ID2D1Image* argument differs from ID2D1DeviceContext::SetTarget in d2d1_1.h, so the target bitmap lands in the wrong argument slot and the context keeps drawing to the previous target
- `Broiler.Native.Windows.Direct2D.DWriteNative` in `src/Broiler.Native.Windows/Direct2D/DWriteNative.cs` - Security=High, Spec=none cited, `564421`, PENDING
  - Falsified if: a structure here is not laid out as in dwrite.h, for example DWRITE_TEXT_METRICS not being the 36 bytes IDWriteTextLayout::GetMetrics writes, so the measured sizes and LineCount are read from the wrong bytes
- `Broiler.Native.Windows.Direct2D.DWriteNative.DWRITE_TEXT_METRICS` in `src/Broiler.Native.Windows/Direct2D/DWriteNative.cs` - Security=High, Spec=none cited, `71E01C`, PENDING
  - Falsified if: Marshal.SizeOf is not the 36 bytes IDWriteTextLayout::GetMetrics writes, or LineCount is not at offset 32 after seven floats and MaxBidiReorderingDepth
- `Broiler.Native.Windows.Direct2D.DWriteNative.CreateTextFormatProc` in `src/Broiler.Native.Windows/Direct2D/DWriteNative.cs` - Security=High, Spec=none cited, `3000F3`, PENDING
  - Falsified if: fontFamilyName or localeName is marshalled as ANSI instead of NUL-terminated UTF-16, so a non-ASCII page-supplied family name reaches CreateTextFormat mangled
- `Broiler.Native.Windows.Direct2D.Direct2DDeviceApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DDeviceApi.cs` - Security=High, Spec=none cited, `A189CB`, PENDING
  - Falsified if: CreateD2DDeviceProc differs from ID2D1Factory1::CreateDevice(IDXGIDevice*, ID2D1Device**), so the new device pointer is written through the wrong argument
- `Broiler.Native.Windows.Direct2D.Direct2DDeviceApi.CreateD2DDeviceProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DDeviceApi.cs` - Security=High, Spec=none cited, `6E40F2`, PENDING
  - Falsified if: dxgiDevice and the ID2D1Device** out reach ID2D1Factory1::CreateDevice(IDXGIDevice*, ID2D1Device**) in swapped positions, so the new device pointer is written over the first bytes of the IDXGIDevice object
- `Broiler.Native.Windows.Direct2D.Direct2DImageStoreApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DImageStoreApi.cs` - Security=Critical, Spec=none cited, `BF5EB3`, PENDING
  - Falsified if: CreateBitmapProc's sourceData and pitch reach ID2D1RenderTarget::CreateBitmap(D2D1_SIZE_U, const void*, UINT32, const D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**) in swapped positions, so Direct2D reads decoded pixels from the address given by the pitch
- `Broiler.Native.Windows.Direct2D.Direct2DImageStoreApi.CreateBitmapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DImageStoreApi.cs` - Security=Critical, Spec=none cited, `B276F6`, PENDING
  - Falsified if: sourceData and pitch reach ID2D1RenderTarget::CreateBitmap(D2D1_SIZE_U, const void*, UINT32, const D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**) in swapped positions, so Direct2D reads decoded pixels from the address given by the pitch
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=Critical, Spec=none cited, `1DD226`, PENDING
  - Falsified if: CreateBitmap1Proc's sourceData and pitch reach ID2D1DeviceContext::CreateBitmap(D2D1_SIZE_U, const void*, UINT32, const D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**) in swapped positions, so Direct2D reads pixels from the address given by the pitch
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi.CreateBitmap1Proc` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=Critical, Spec=none cited, `A118A6`, PENDING
  - Falsified if: sourceData and pitch reach ID2D1DeviceContext::CreateBitmap(D2D1_SIZE_U, const void*, UINT32, const D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**) in swapped positions, so Direct2D reads pixels from the address given by the pitch
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi.CopyFromBitmapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=Critical, Spec=none cited, `622C7A`, PENDING
  - Falsified if: destinationPoint and bitmap reach ID2D1Bitmap::CopyFromBitmap(const D2D1_POINT_2U*, ID2D1Bitmap*, const D2D1_RECT_U*) in swapped positions, so Direct2D reads the destination point from the source bitmap object and calls through null as the bitmap
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi.MapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=Critical, Spec=none cited, `37BC4C`, PENDING
  - Falsified if: options and the mapped-rect out reach ID2D1Bitmap1::Map(D2D1_MAP_OPTIONS, D2D1_MAPPED_RECT*) in swapped positions, so Map writes the pitch and bits pointer through the options value as an address
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi.UnmapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=High, Spec=none cited, `4A016C`, PENDING
  - Falsified if: UnmapProc is declared with a parameter beyond self, so a 32-bit stdcall call to ID2D1Bitmap1::Unmap leaves the stack unbalanced by the extra bytes
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, Spec=none cited, `5AD2D2`, PENDING
  - Falsified if: DrawTextProc's textLength is not passed as the 32-bit UINT32 directly after the string pointer, so DrawText reads a length taken from other bits and walks UTF-16 units past the marshalled page text
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.BeginDrawProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `19DEFC`, PENDING
  - Falsified if: BeginDraw is declared with a return value or a parameter beyond self, so a 32-bit stdcall call leaves the stack unbalanced by the extra bytes
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.EndDrawProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, Spec=none cited, `908727`, PENDING
  - Falsified if: the tag pointers are declared narrower than a pointer, so on x64 EndDraw writes its UINT64 tags through truncated addresses
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.ClearProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `AE36CF`, PENDING
  - Falsified if: the color is passed by value instead of as a pointer to a 16-byte D2D1_COLOR_F, so Clear dereferences the colour components as an address
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.SetAntialiasModeProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `DF1DCC`, PENDING
  - Falsified if: the mode is not marshalled as the 32-bit D2D1_ANTIALIAS_MODE enum, so the value Direct2D reads carries bits the caller never set
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.SetTextAntialiasModeProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `0D0E8D`, PENDING
  - Falsified if: the mode is not marshalled as the 32-bit D2D1_TEXT_ANTIALIAS_MODE enum, so the value Direct2D reads carries bits the caller never set
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.SetTransformProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `698448`, PENDING
  - Falsified if: the matrix is passed by value instead of as a pointer to a 24-byte D2D1_MATRIX_3X2_F, so SetTransform reads its six floats from an address formed from matrix contents
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.CreateSolidColorBrushProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, Spec=none cited, `E7E385`, PENDING
  - Falsified if: color and brushProperties reach CreateSolidColorBrush(const D2D1_COLOR_F*, const D2D1_BRUSH_PROPERTIES*, ID2D1SolidColorBrush**) in swapped positions, so Direct2D reads the colour through a null pointer and the colour as opacity and transform
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.FillRectangleProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `824F30`, PENDING
  - Falsified if: the rectangle is passed by value instead of as a pointer to a 16-byte D2D1_RECT_F, so FillRectangle dereferences the left and top coordinates as an address
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GetFactoryProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `7F9457`, PENDING
  - Falsified if: factory is not declared as an out ID2D1Factory**, so GetFactory writes the factory pointer through an address formed from the caller's argument
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.CreatePathGeometryProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `263E64`, PENDING
  - Falsified if: pathGeometry is not declared as an out ID2D1PathGeometry**, so CreatePathGeometry writes the new geometry through an address formed from the caller's argument
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.PathGeometryOpenProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `F267E0`, PENDING
  - Falsified if: sink is not declared as an out ID2D1GeometrySink**, so Open writes the sink pointer through an address formed from the caller's argument
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkSetFillModeProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `EA5E6B`, PENDING
  - Falsified if: the fill mode is not marshalled as the 32-bit D2D1_FILL_MODE enum, so the value Direct2D reads carries bits the caller never set
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkBeginFigureProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `112802`, PENDING
  - Falsified if: startPoint is passed as a pointer instead of the 8-byte D2D1_POINT_2F by value, so BeginFigure starts the figure at coordinates taken from an address
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkAddLinesProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, Spec=none cited, `1D7738`, PENDING
  - Falsified if: points and pointsCount reach ID2D1SimplifiedGeometrySink::AddLines(const D2D1_POINT_2F*, UINT32) in swapped positions, so Direct2D reads points from the address given by the count
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkEndFigureProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `B50897`, PENDING
  - Falsified if: the figure end is not marshalled as the 32-bit D2D1_FIGURE_END enum, so the value Direct2D reads carries bits the caller never set
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkCloseProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `610C3C`, PENDING
  - Falsified if: Close is declared returning void, so its failure HRESULT is lost and an unclosed geometry reaches FillGeometry
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.FillGeometryProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `A97749`, PENDING
  - Falsified if: geometry and brush reach ID2D1RenderTarget::FillGeometry(ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*) in swapped positions, so Direct2D calls ID2D1Geometry methods through the brush's vtable
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.DrawRectangleProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `3980C2`, PENDING
  - Falsified if: strokeWidth is not marshalled as a 32-bit float after the brush pointer, so DrawRectangle strokes with a width reinterpreted from other bits
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.FillRoundedRectangleProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `53C94F`, PENDING
  - Falsified if: the rounded rectangle is not passed as a pointer to a 24-byte D2D1_ROUNDED_RECT with the radii after the rectangle, so the radii are read from the wrong offsets
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.DrawRoundedRectangleProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `5F1379`, PENDING
  - Falsified if: strokeWidth is not marshalled as a 32-bit float after the brush pointer, so DrawRoundedRectangle strokes with a width reinterpreted from other bits
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.DrawTextProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, Spec=none cited, `B0981C`, PENDING
  - Falsified if: textLength is not passed as the 32-bit UINT32 directly after the string pointer, so DrawText reads a length taken from other bits and walks UTF-16 units past the marshalled page text
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.DrawBitmapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `B19583`, PENDING
  - Falsified if: opacity is not marshalled as a 32-bit float between the destination pointer and the interpolation mode, so DrawBitmap draws with an opacity reinterpreted from other bits
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.PushAxisAlignedClipProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `7E94DC`, PENDING
  - Falsified if: clipRect is passed by value rather than as a pointer to a 16-byte D2D1_RECT_F, so PushAxisAlignedClip reads the clip rectangle from an address formed from its left and top edges
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.PopAxisAlignedClipProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `F1D399`, PENDING
  - Falsified if: PopAxisAlignedClip is declared with a parameter beyond self or a return value, so a 32-bit stdcall call leaves the stack unbalanced by the extra bytes
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=Critical, Spec=none cited, `062529`, PENDING
  - Falsified if: CreateSwapChainForHwndProc passes the DXGI_SWAP_CHAIN_DESC1 pointer and fullscreenDesc to IDXGIFactory2::CreateSwapChainForHwnd in swapped positions, so DXGI reads the fullscreen description from the 48-byte swap-chain descriptor and dereferences null as the descriptor
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.CreateSwapChainForCompositionProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, Spec=none cited, `7753C7`, PENDING
  - Falsified if: desc is not passed as a pointer to the 48-byte DXGI_SWAP_CHAIN_DESC1, so DXGI allocates swap-chain buffers from misread width, height or buffer count
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.CreateSwapChainForHwndProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=Critical, Spec=none cited, `25B49B`, PENDING
  - Falsified if: the DXGI_SWAP_CHAIN_DESC1 pointer and fullscreenDesc reach IDXGIFactory2::CreateSwapChainForHwnd in swapped positions, so DXGI reads the fullscreen description from the 48-byte swap-chain descriptor and dereferences null as the descriptor
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.GetBufferProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, Spec=none cited, `CC68D0`, PENDING
  - Falsified if: buffer and riid reach IDXGISwapChain::GetBuffer(UINT, REFIID, void**) in swapped positions, so the back-buffer index is dereferenced as the IID pointer
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.ResizeBuffersProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, Spec=none cited, `FA3C79`, PENDING
  - Falsified if: bufferCount, width, height, format and flags reach IDXGISwapChain::ResizeBuffers out of that order, so a resize to 1280 by 720 leaves back buffers whose description reports another size
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.CreateBitmapFromDxgiSurfaceProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, Spec=none cited, `3A939B`, PENDING
  - Falsified if: the ColorContext field of bitmapProperties does not land at offset 24 on x64 after four padding bytes, so Direct2D dereferences padding as an ID2D1ColorContext
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.SetDpiProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, Spec=none cited, `07F303`, PENDING
  - Falsified if: dpiX and dpiY are not marshalled as 32-bit floats, so SetDpi scales every later draw by values reinterpreted from other bits
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.PresentProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, Spec=none cited, `F5376C`, PENDING
  - Falsified if: syncInterval and flags reach IDXGISwapChain::Present(UINT SyncInterval, UINT Flags) in swapped positions, so Present(1, 0) is issued as Present(0, DXGI_PRESENT_TEST) and no frame reaches the window
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=Critical, Spec=none cited, `6C4DE2`, PENDING
  - Falsified if: GetStringProc's buffer and size reach IDWriteLocalizedStrings::GetString(UINT32, WCHAR*, UINT32) in swapped positions, so the name and its terminator are written to the address given by the capacity
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetSystemFontCollectionProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, Spec=none cited, `C6C363`, PENDING
  - Falsified if: checkForUpdates is not marshalled as a 4-byte BOOL, so GetSystemFontCollection reads stray bits and rescans installed fonts on calls meant to reuse the collection
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetFontFamilyCountProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, Spec=none cited, `9E781E`, PENDING
  - Falsified if: the UINT32 count is read as a wider type, so a loop bounded by it calls GetFontFamily with indices the collection rejects
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetFontFamilyProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, Spec=none cited, `7109EE`, PENDING
  - Falsified if: index and the family out reach IDWriteFontCollection::GetFontFamily(UINT32, IDWriteFontFamily**) in swapped positions, so the family pointer is written through the index value as an address
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetFamilyNamesProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, Spec=none cited, `31159B`, PENDING
  - Falsified if: names is not declared as an out IDWriteLocalizedStrings**, so GetFamilyNames writes the strings pointer through an address formed from the caller's argument
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.FindLocaleNameProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, Spec=none cited, `4B03F9`, PENDING
  - Falsified if: exists is not marshalled as a 4-byte BOOL, so a locale the strings do not contain is reported as found and its unset index is used
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetStringLengthProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, Spec=none cited, `BAB88A`, PENDING
  - Falsified if: index and the length out reach IDWriteLocalizedStrings::GetStringLength(UINT32, UINT32*) in swapped positions, so the length is written through the index value as an address
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetStringProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=Critical, Spec=none cited, `15EEF0`, PENDING
  - Falsified if: buffer and size reach IDWriteLocalizedStrings::GetString(UINT32, WCHAR*, UINT32) in swapped positions, so the name and its terminator are written to the address given by the capacity
- `Broiler.Native.Windows.Direct2D.DirectWriteTextMetricsProviderApi` in `src/Broiler.Native.Windows/Direct2D/DirectWriteTextMetricsProviderApi.cs` - Security=Critical, Spec=none cited, `E4A9A2`, PENDING
  - Falsified if: CreateTextLayoutProc's textLength is not passed as the 32-bit UINT32 directly after the string pointer, so CreateTextLayout reads a length taken from other bits and walks UTF-16 units past the marshalled text
- `Broiler.Native.Windows.Direct2D.DirectWriteTextMetricsProviderApi.CreateTextLayoutProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteTextMetricsProviderApi.cs` - Security=Critical, Spec=none cited, `671FA2`, PENDING
  - Falsified if: textLength is not passed as the 32-bit UINT32 directly after the string pointer, so CreateTextLayout reads a length taken from other bits and walks UTF-16 units past the marshalled text
- `Broiler.Native.Windows.Direct2D.DirectWriteTextMetricsProviderApi.GetMetricsProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteTextMetricsProviderApi.cs` - Security=High, Spec=none cited, `ED31D6`, PENDING
  - Falsified if: metrics is not an out pointer to the 36-byte DWRITE_TEXT_METRICS, so the width and line count GetMetrics writes land in the wrong fields or past the struct
- `Broiler.Native.Windows.Direct2D.DxgiNative` in `src/Broiler.Native.Windows/Direct2D/DxgiNative.cs` - Security=High, Spec=none cited, `AC7CA2`, PENDING
  - Falsified if: a structure here is not laid out as in dxgi1_2.h, for example DXGI_SWAP_CHAIN_DESC1 not being 48 bytes, so CreateSwapChainForHwnd reads the sample description and the later fields at shifted offsets
- `Broiler.Native.Windows.Direct2D.DxgiNative.DXGI_SAMPLE_DESC` in `src/Broiler.Native.Windows/Direct2D/DxgiNative.cs` - Security=High, Spec=none cited, `A550C9`, PENDING
  - Falsified if: Count and Quality are in the opposite order to dxgicommon.h, so a descriptor asking for Count 1 and Quality 0 reaches DXGI as Count 0 and swap-chain creation fails
- `Broiler.Native.Windows.Direct2D.DxgiNative.DXGI_SWAP_CHAIN_DESC1` in `src/Broiler.Native.Windows/Direct2D/DxgiNative.cs` - Security=High, Spec=none cited, `DBD1C7`, PENDING
  - Falsified if: Marshal.SizeOf is not 48 or Stereo is not a 4-byte BOOL, so CreateSwapChainForHwnd reads SampleDesc and the later fields at shifted offsets
- `Broiler.Native.Windows.Direct2D.NativeMethods` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=Critical, Spec=none cited, `C630AC`, PENDING
  - Falsified if: D3D11CreateDevice receives pFeatureLevels and featureLevels in swapped positions, so the level count is dereferenced as the D3D_FEATURE_LEVEL array
- `Broiler.Native.Windows.Direct2D.NativeMethods.D3D11CreateDevice(IntPtr, D3D11Native.D3D_DRIVER_TYPE, IntPtr, uint, IntPtr, uint, uint, out IntPtr, out D3D11Native.D3D_FEATURE_LEVEL, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=Critical, Spec=none cited, `B9D586`, PENDING
  - Falsified if: pFeatureLevels and featureLevels reach D3D11CreateDevice in swapped positions, so the level count is dereferenced as the D3D_FEATURE_LEVEL array
- `Broiler.Native.Windows.Direct2D.NativeMethods.CreateDXGIFactory1(in Guid, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=High, Spec=none cited, `260F5E`, PENDING
  - Falsified if: riid is passed as the 16-byte GUID value instead of a REFIID pointer, so dxgi.dll reads the first bytes of the IID as an address
- `Broiler.Native.Windows.Direct2D.NativeMethods.D2D1CreateFactory(D2DNative.D2D1_FACTORY_TYPE, in Guid, IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=Critical, Spec=none cited, `3563F3`, PENDING
  - Falsified if: riid and pFactoryOptions reach D2D1CreateFactory(D2D1_FACTORY_TYPE, REFIID, const D2D1_FACTORY_OPTIONS*, void**) in swapped positions, so d2d1.dll reads the factory options from the IID and dereferences the options pointer as the IID
- `Broiler.Native.Windows.Direct2D.NativeMethods.DWriteCreateFactory(DWriteNative.DWRITE_FACTORY_TYPE, in Guid, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=High, Spec=none cited, `F2E7BF`, PENDING
  - Falsified if: iid is passed as the 16-byte GUID value instead of a REFIID pointer, so dwrite.dll reads the first bytes of the IID as an address
- `Broiler.Native.Windows.Direct2D.NativeMethods.Succeeded(int)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=High, Spec=none cited, `74416D`, PENDING
  - Falsified if: an HRESULT with the severity bit set, such as 0x887A0005, returns true, so the caller attaches an out pointer the failed call never wrote
- `Broiler.Native.Windows.Direct2D.NativeMethods.ThrowIfFailed(int, string)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=High, Spec=none cited, `88558B`, PENDING
  - Falsified if: a failing HRESULT such as 0x80004005 returns without throwing, so the caller attaches the zero out pointer and calls through it
- `Broiler.Native.Windows.HwndNative` in `src/Broiler.Native.Windows/HwndNative.cs` - Security=High, Spec=none cited, `EDAB60`, PENDING
  - Falsified if: IsWindow's 4-byte BOOL result is read as a 1-byte bool, so a nonzero result such as 0x100 reports a live window as destroyed
- `Broiler.Native.Windows.HwndNative.IsWindow(nint)` in `src/Broiler.Native.Windows/HwndNative.cs` - Security=High, Spec=none cited, `EF9423`, PENDING
  - Falsified if: the 4-byte BOOL result is read as a 1-byte bool, so a nonzero result such as 0x100 reports a live window as destroyed
- `Broiler.Native.Windows.Input.RawInputReaderNative` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=Critical, Spec=none cited, `33D29B`, PENDING
  - Falsified if: GetRawInputData passes data and size to user32 in swapped positions, so the RAWINPUT is written through the size's address and the byte count into the caller's buffer
- `Broiler.Native.Windows.Input.RawInputReaderNative.RawInputHeader` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=High, Spec=none cited, `777845`, PENDING
  - Falsified if: Marshal.SizeOf is not sizeof(RAWINPUTHEADER), 24 bytes on x64 and 16 on x86, so GetRawInputData rejects the header size and the payload is read from the wrong offset
- `Broiler.Native.Windows.Input.RawInputReaderNative.RawMouse` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=High, Spec=none cited, `42EB0C`, PENDING
  - Falsified if: ButtonFlags is read from offset 2, which is padding, instead of usButtonFlags at offset 4, so a left-button press arrives in ButtonData and the wheel delta at offset 6 is never read
- `Broiler.Native.Windows.Input.RawInputReaderNative.RawKeyboard` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=High, Spec=none cited, `09BBF5`, PENDING
  - Falsified if: VKey is not read from offset 6 of RAWKEYBOARD (MakeCode 0, Flags 2, Reserved 4, VKey 6, Message 8, ExtraInformation 12), so a key press reports another field as its virtual-key code
- `Broiler.Native.Windows.Input.RawInputReaderNative.GetRawInputData(IntPtr, uint, IntPtr, ref uint, uint)` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=Critical, Spec=none cited, `DCA974`, PENDING
  - Falsified if: data and size reach GetRawInputData(HRAWINPUT, UINT, LPVOID, PUINT, UINT) in swapped positions, so user32 writes the RAWINPUT through the size's address and the byte count into the caller's buffer
- `Broiler.Native.Windows.Input.RawInputRegistrationNative` in `src/Broiler.Native.Windows/Input/RawInputRegistrationNative.cs` - Security=Critical, Spec=none cited, `B1A9F1`, PENDING
  - Falsified if: RegisterRawInputDevices passes deviceCount and rawInputDeviceSize to user32 in swapped positions, so user32 walks as many entries as the struct size names past the pinned array
- `Broiler.Native.Windows.Input.RawInputRegistrationNative.RawInputDevice` in `src/Broiler.Native.Windows/Input/RawInputRegistrationNative.cs` - Security=High, Spec=none cited, `BCE2F9`, PENDING
  - Falsified if: TargetWindow is not at offset 8 on x64 or 4 on x86 as in RAWINPUTDEVICE, so user32 reads hwndTarget from the wrong bytes and WM_INPUT goes to another window or none
- `Broiler.Native.Windows.Input.RawInputRegistrationNative.RegisterRawInputDevices(RawInputDevice[], uint, uint)` in `src/Broiler.Native.Windows/Input/RawInputRegistrationNative.cs` - Security=Critical, Spec=none cited, `261907`, PENDING
  - Falsified if: deviceCount and rawInputDeviceSize reach RegisterRawInputDevices(PCRAWINPUTDEVICE, UINT, UINT) in swapped positions, so user32 walks as many entries as the struct size names past the pinned array
- `Broiler.Native.Windows.MediaFoundation.Capture.WindowsMediaFoundationNative` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `2038F3`, PENDING
  - Falsified if: an out parameter of a binding here differs in width from its SDK prototype (the UINT32* device count, the IMFActivate*** array), so native code writes the count or pointer into a slot of the wrong size
- `Broiler.Native.Windows.MediaFoundation.Capture.WindowsMediaFoundationNative.MFEnumDeviceSources(IMFAttributes, out IntPtr, out uint)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `8E6AB1`, PENDING
  - Falsified if: an out parameter differs in width from the IMFActivate*** and UINT32* of the mfidl.h prototype, so the CoTaskMem array pointer or the device count lands in a slot of the wrong size
- `Broiler.Native.Windows.MediaFoundation.Capture.WindowsMediaFoundationNative.MFCreateDeviceSource(IMFAttributes, out IMFMediaSource)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `8FEFF4`, PENDING
  - Falsified if: the IMFMediaSource reference written to ppSource is not owned by the returned wrapper, so releasing the wrapper leaves the camera device source alive
- `Broiler.Native.Windows.MediaFoundation.Capture.WindowsMediaFoundationNative.MFCreateSourceReaderFromMediaSource(IMFMediaSource, IMFAttributes?, out IMFSourceReader)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `1B4E53`, PENDING
  - Falsified if: a null attributes argument does not reach native code as a null IMFAttributes*, so the optional pAttributes of mfreadwrite.h receives an invalid interface pointer
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFActivate` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `9CE72D`, PENDING
  - Falsified if: the interface does not derive from an IMFAttributes declaration of exactly 30 methods, so ActivateObject is not dispatched through vtable slot 33 and calls another native method with mismatched arguments
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFActivate.ActivateObject(ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `9210BC`, PENDING
  - Falsified if: ActivateObject is not vtable slot 33, directly after the 30 IMFAttributes methods, so the call reaches CopyAllItems and native code calls through the IID pointer as an IMFAttributes object
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFActivate.ShutdownObject()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B2D4A2`, PENDING
  - Falsified if: ShutdownObject is not dispatched through the slot after ActivateObject in mfobjects.h, so a shutdown request runs another method and the device stays open
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFActivate.DetachObject()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `3D143C`, PENDING
  - Falsified if: DetachObject is not dispatched through the slot after ShutdownObject in mfobjects.h, so a detach request runs another method with mismatched arguments
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `0E895F`, PENDING
  - Falsified if: a member is out of mfidl.h order (the four IMFMediaEventGenerator methods, then GetCharacteristics through Shutdown), so Start or QueueEvent reaches a method that reads its PROPVARIANT pointer as another argument
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.GetEvent(int, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `0E5E8D`, PENDING
  - Falsified if: GetEvent is not vtable slot 3, the first IMFMediaEventGenerator method after IUnknown, so an event request reaches BeginGetEvent and the flags are taken as a callback pointer
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.BeginGetEvent(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `A2701C`, PENDING
  - Falsified if: BeginGetEvent is not vtable slot 4, directly after GetEvent, so the callback and state reach GetEvent and an event pointer is written through the callback value as an address
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.EndGetEvent(IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `F27CE9`, PENDING
  - Falsified if: result and the mediaEvent out reach IMFMediaEventGenerator::EndGetEvent(IMFAsyncResult*, IMFMediaEvent**) in swapped positions, so the event pointer is written over the async result object
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.QueueEvent(int, ref Guid, int, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `0CB8DF`, PENDING
  - Falsified if: QueueEvent is not vtable slot 6, after EndGetEvent, so the event type, GUID, status and PROPVARIANT pointer reach EndGetEvent or GetCharacteristics and native code writes through the event type as an address
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.GetCharacteristics(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `233D25`, PENDING
  - Falsified if: GetCharacteristics is not dispatched through slot 7, the first after the four IMFMediaEventGenerator methods in mfidl.h, so the characteristics DWORD is written by a different method
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.CreatePresentationDescriptor(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `DFC700`, PENDING
  - Falsified if: CreatePresentationDescriptor is not vtable slot 8, after GetCharacteristics, so the call reaches Start and native code reads the out slot as a presentation descriptor
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.Start(IntPtr, ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `007B5F`, PENDING
  - Falsified if: presentationDescriptor, timeFormat and startPosition reach IMFMediaSource::Start in another order, so the source reads the PROPVARIANT start position through the time-format GUID's address
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.Stop()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `458393`, PENDING
  - Falsified if: Stop is not dispatched through the slot after Start in mfidl.h, so a stop request runs Pause or Shutdown instead
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.Pause()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `3DEE33`, PENDING
  - Falsified if: Pause is not dispatched through the slot after Stop in mfidl.h, so a pause request runs Shutdown and the camera cannot be restarted
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.Shutdown()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B383A8`, PENDING
  - Falsified if: Shutdown is not the last IMFMediaSource slot in mfidl.h, so releasing a camera calls another method and leaves the device open
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `0511AF`, PENDING
  - Falsified if: the interface does not derive from an IMFAttributes declaration of exactly 30 methods, so GetMajorType and the other media-type members are dispatched through the wrong vtable slots
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.GetMajorType(out Guid)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `A1D09D`, PENDING
  - Falsified if: GetMajorType is not dispatched through slot 33, the first after the 30 IMFAttributes methods, so the GUID written to majorType comes from a different method
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.IsCompressedFormat(out bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `8C2475`, PENDING
  - Falsified if: compressed is marshalled as a 1-byte bool instead of a 4-byte BOOL, so native code writes past the managed local
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.IsEqual(IMFMediaType, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `01BD88`, PENDING
  - Falsified if: mediaType and the flags out reach IMFMediaType::IsEqual(IMFMediaType*, DWORD*) in swapped positions, so the match flags are written into the other media type object
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.GetRepresentation(Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `C437BF`, PENDING
  - Falsified if: GetRepresentation is not vtable slot 36, after IsEqual, so a representation request reaches FreeRepresentation and native code frees the caller's out slot as a representation block
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.FreeRepresentation(Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `E8E537`, PENDING
  - Falsified if: FreeRepresentation is not vtable slot 37, directly after GetRepresentation, so a free request reaches GetRepresentation and a new block is written through the pointer meant to be freed
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `0EC939`, PENDING
  - Falsified if: a member is out of mfreadwrite.h order (GetStreamSelection at slot 3 through GetPresentationAttribute at 12), so a PROPVARIANT, media-type or sample pointer is read or written by a method that takes another argument list
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetStreamSelection(int, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `ACDBE9`, PENDING
  - Falsified if: selected is marshalled as a 1-byte bool instead of a 4-byte BOOL, so native code writes 3 bytes past the managed local
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.SetStreamSelection(int, bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `37F403`, PENDING
  - Falsified if: selected is passed as a 1-byte bool instead of a 4-byte BOOL, so native code reads undefined upper bytes and a deselect can leave the stream enabled
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetNativeMediaType(int, int, out IMFMediaType)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `191BB5`, PENDING
  - Falsified if: GetNativeMediaType is not vtable slot 5, after SetStreamSelection, so the stream and type indexes reach GetCurrentMediaType and the type index is dereferenced as the out pointer
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetCurrentMediaType(int, out IMFMediaType)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `CAC63C`, PENDING
  - Falsified if: GetCurrentMediaType is not vtable slot 6, directly after GetNativeMediaType, so the out pointer is read as a media-type index and the type is written through an unset argument
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.SetCurrentMediaType(int, IntPtr, IMFMediaType)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `57AE9A`, PENDING
  - Falsified if: reserved and mediaType reach IMFSourceReader::SetCurrentMediaType(DWORD, DWORD*, IMFMediaType*) in swapped positions, so the reader dereferences null as the media type
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.SetCurrentPosition(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `CF62FB`, PENDING
  - Falsified if: timeFormat and position reach IMFSourceReader::SetCurrentPosition(REFGUID, REFPROPVARIANT) in swapped positions, so the reader reads the PROPVARIANT seek position through the GUID's address
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.ReadSample(int, int, out int, out SourceReaderFlags, out long, out IMFSample?)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `2D7F72`, PENDING
  - Falsified if: ReadSample is not vtable slot 9, after SetCurrentPosition, so a read reaches Flush or SetCurrentPosition and the five out arguments are never written
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.Flush(int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `7D05AD`, PENDING
  - Falsified if: Flush is not dispatched through the slot after ReadSample in mfreadwrite.h, so a flush request runs GetServiceForStream and native code writes through garbage pointer arguments
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetServiceForStream(int, ref Guid, ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `26A506`, PENDING
  - Falsified if: service and interfaceId reach GetServiceForStream(DWORD, REFGUID, REFIID, LPVOID*) in swapped positions, so the reader returns the service named by the IID and the caller calls it as another interface
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetPresentationAttribute(int, ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `05DCB9`, PENDING
  - Falsified if: GetPresentationAttribute is not vtable slot 12, the last IMFSourceReader method, so the query reaches GetServiceForStream and native code writes a service pointer through the PROPVARIANT argument
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `AA199C`, PENDING
  - Falsified if: a member is out of mfobjects.h order (the 30 IMFAttributes slots, then GetSampleFlags at 33 through CopyToBuffer at 46), so a PROPVARIANT, string, blob or buffer pointer reaches a method that writes it with another size
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetItem(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `CE6DAE`, PENDING
  - Falsified if: GetItem is not vtable slot 3, directly after IUnknown, so a lookup reaches GetItemType and the PROPVARIANT the caller then reads holds only a 4-byte type code
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetItemType(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `14817B`, PENDING
  - Falsified if: GetItemType is not the slot after GetItem in the IMFAttributes order of mfobjects.h, so the attribute type is written by a different method
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.CompareItem(ref Guid, IntPtr, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `E2FA0C`, PENDING
  - Falsified if: CompareItem is not vtable slot 5, after GetItemType, so a comparison reaches Compare and native code calls through the PROPVARIANT pointer as an IMFAttributes object
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.Compare(IMFAttributes, int, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `FC95C3`, PENDING
  - Falsified if: result is marshalled as a 1-byte bool instead of a 4-byte BOOL, so native code writes past the managed local and a mismatch can read as a match
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetUINT32(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `22EFE5`, PENDING
  - Falsified if: value is declared wider than the UINT32* of mfobjects.h, so native code fills only the low half and the caller reads stale upper bits
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetUINT64(ref Guid, out long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B0164D`, PENDING
  - Falsified if: value is declared narrower than the UINT64* of mfobjects.h, so native code writes 8 bytes into a 4-byte slot
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetDouble(ref Guid, out double)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `E83B03`, PENDING
  - Falsified if: value is not an 8-byte double, so native code writes past the managed local
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetGUID(ref Guid, out Guid)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `04EAF7`, PENDING
  - Falsified if: value is not a 16-byte Guid passed by pointer, so native code writes the GUID past the managed local
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetStringLength(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `CC6026`, PENDING
  - Falsified if: GetStringLength is not vtable slot 11, so a call reaches GetGUID and native code writes 16 bytes through the 4-byte length out
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetString(ref Guid, IntPtr, int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `77BE94`, PENDING
  - Falsified if: value and size reach IMFAttributes::GetString(REFGUID, LPWSTR, UINT32, UINT32*) in swapped positions, so the string is written to the address given by the capacity
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetAllocatedString(ref Guid, out IntPtr, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `028D50`, PENDING
  - Falsified if: value and length reach GetAllocatedString(REFGUID, LPWSTR*, UINT32*) in swapped positions, so the string pointer is written into the 4-byte length and the caller frees a truncated address
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetBlobSize(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `689F15`, PENDING
  - Falsified if: GetBlobSize is not the slot after GetAllocatedString in mfobjects.h, so the blob size is written by a different method
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetBlob(ref Guid, IntPtr, int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `DF996E`, PENDING
  - Falsified if: buffer and bufferSize reach IMFAttributes::GetBlob(REFGUID, UINT8*, UINT32, UINT32*) in swapped positions, so the blob is copied to the address given by the size
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetAllocatedBlob(ref Guid, out IntPtr, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `D95683`, PENDING
  - Falsified if: buffer and size reach GetAllocatedBlob(REFGUID, UINT8**, UINT32*) in swapped positions, so the blob pointer is written into the 4-byte size and the caller reads through a truncated address
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetUnknown(ref Guid, ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `D93F2C`, PENDING
  - Falsified if: key and interfaceId reach GetUnknown(REFGUID, REFIID, LPVOID*) in swapped positions, so the store looks the IID up as the key and returns an object queried for the key GUID
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetItem(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `8A63F9`, PENDING
  - Falsified if: SetItem is not vtable slot 18, after GetUnknown, so a store request reaches GetUnknown and native code writes an interface pointer through the PROPVARIANT argument
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.DeleteItem(ref Guid)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `74315D`, PENDING
  - Falsified if: DeleteItem is not the slot after SetItem in mfobjects.h, so a delete runs DeleteAllItems or SetUINT32 with mismatched arguments
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.DeleteAllItems()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B3EEDA`, PENDING
  - Falsified if: DeleteAllItems is not dispatched through the slot after DeleteItem in mfobjects.h, so clearing the attributes runs another method
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetUINT32(ref Guid, int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `ACC7DC`, PENDING
  - Falsified if: value is declared wider than the UINT32 of mfobjects.h, so on x86 the caller pushes 8 bytes where native code pops 4 and the stack is unbalanced on return
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetUINT64(ref Guid, long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `D8F6A0`, PENDING
  - Falsified if: value is declared narrower than the UINT64 of mfobjects.h, so on x86 the upper half is read from the next stack slot
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetDouble(ref Guid, double)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `0AB870`, PENDING
  - Falsified if: value is not passed as an 8-byte double, so native code stores a reinterpretation of another register or stack slot
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetGUID(ref Guid, ref Guid)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `4C3268`, PENDING
  - Falsified if: value is passed by value instead of as a REFGUID pointer, so native code reads the GUID from the bits of a pointer-sized argument
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetString(ref Guid, string)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `C88CB0`, PENDING
  - Falsified if: value is marshalled as an ANSI string instead of LPWSTR, so non-ASCII characters are lost and native code reads a narrow buffer as UTF-16 past its terminator
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetBlob(ref Guid, IntPtr, int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `643E87`, PENDING
  - Falsified if: buffer and size reach IMFAttributes::SetBlob(REFGUID, const UINT8*, UINT32) in swapped positions, so the store copies the blob from the address given by the size
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetUnknown(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `EB4C73`, PENDING
  - Falsified if: SetUnknown is not vtable slot 27, after SetBlob, so a store request reaches SetBlob and native code copies from the IUnknown pointer with an unset size
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.LockStore()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `52D8D9`, PENDING
  - Falsified if: LockStore is not vtable slot 28, directly after SetUnknown, so a lock request reaches SetUnknown or UnlockStore and the attribute store is never locked
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.UnlockStore()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B80F37`, PENDING
  - Falsified if: UnlockStore is not vtable slot 29, directly after LockStore, so an unlock reaches GetCount, which writes through an unset argument and leaves the store locked
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetCount(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `C12DCA`, PENDING
  - Falsified if: GetCount is not the slot after UnlockStore in mfobjects.h, so the item count is written by a different method
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetItemByIndex(int, out Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `57C3C3`, PENDING
  - Falsified if: GetItemByIndex is not vtable slot 31, after GetCount, so an indexed read reaches CopyAllItems and native code calls through the GUID out pointer as an IMFAttributes object
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.CopyAllItems(IMFAttributes)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `F083D6`, PENDING
  - Falsified if: CopyAllItems is not the last of the 30 IMFAttributes slots in mfobjects.h, so GetSampleFlags and every sample member after it are dispatched one slot off
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetSampleFlags(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `28DCB0`, PENDING
  - Falsified if: GetSampleFlags is not dispatched through slot 33, the first after the 30 IMFAttributes methods, so the flags DWORD is written by a different method
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetSampleFlags(int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `119402`, PENDING
  - Falsified if: SetSampleFlags is not dispatched through the slot after GetSampleFlags in mfobjects.h, so the flags value reaches a getter as a pointer argument
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetSampleTime(out long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `36A75E`, PENDING
  - Falsified if: sampleTime is narrower than the LONGLONG* of mfobjects.h, so native code writes 8 bytes into a 4-byte slot
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetSampleTime(long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `58104B`, PENDING
  - Falsified if: sampleTime is narrower than the LONGLONG of mfobjects.h, so on x86 the upper half of the time is read from the next stack slot
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetSampleDuration(out long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `895682`, PENDING
  - Falsified if: sampleDuration is narrower than the LONGLONG* of mfobjects.h, so native code writes 8 bytes into a 4-byte slot
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetSampleDuration(long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `3D6461`, PENDING
  - Falsified if: sampleDuration is narrower than the LONGLONG of mfobjects.h, so on x86 the upper half of the duration is read from the next stack slot
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetBufferCount(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B473B3`, PENDING
  - Falsified if: GetBufferCount is not dispatched through the slot after SetSampleDuration in mfobjects.h, so the buffer count is written by a different method
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetBufferByIndex(int, out IMFMediaBuffer)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `2959BC`, PENDING
  - Falsified if: GetBufferByIndex is not vtable slot 40, after GetBufferCount, so the call reaches ConvertToContiguousBuffer and a buffer pointer is written through the index value as an address
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.ConvertToContiguousBuffer(out IMFMediaBuffer)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `799F86`, PENDING
  - Falsified if: ConvertToContiguousBuffer is not vtable slot 41, after GetBufferByIndex, so the call reaches AddBuffer and the caller's out slot is read as a buffer to append
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.AddBuffer(IMFMediaBuffer)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `35F355`, PENDING
  - Falsified if: AddBuffer is not dispatched through the slot after ConvertToContiguousBuffer in mfobjects.h, so adding a buffer runs RemoveBufferByIndex with the interface pointer as an index
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.RemoveBufferByIndex(int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `AB56F6`, PENDING
  - Falsified if: RemoveBufferByIndex is not dispatched through the slot after AddBuffer in mfobjects.h, so removing a buffer runs another method with mismatched arguments
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.RemoveAllBuffers()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `2BC579`, PENDING
  - Falsified if: RemoveAllBuffers is not dispatched through the slot after RemoveBufferByIndex in mfobjects.h, so clearing the buffers runs GetTotalLength or another method
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetTotalLength(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B86A11`, PENDING
  - Falsified if: totalLength is not declared as an out 4-byte DWORD, so GetTotalLength writes the byte count into a slot of another width and the length read back carries stale bits
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.CopyToBuffer(IMFMediaBuffer)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `5C8BE2`, PENDING
  - Falsified if: CopyToBuffer is not vtable slot 46, the last IMFSample method, so a copy request reaches GetTotalLength and native code writes a byte count over the destination buffer object
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `59E929`, PENDING
  - Falsified if: a member is out of mfobjects.h order (Lock, Unlock, GetCurrentLength, SetCurrentLength, GetMaxLength after IUnknown), so the length that bounds reads through the Lock pointer comes from another method
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.Lock(out IntPtr, out int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `B58521`, PENDING
  - Falsified if: buffer, maxLength and currentLength reach IMFMediaBuffer::Lock(BYTE**, DWORD*, DWORD*) in another order, so the data pointer is written into a 4-byte length and the caller reads frames through a truncated address
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.Unlock()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `82E696`, PENDING
  - Falsified if: Unlock is not vtable slot 4, directly after Lock, so an unlock reaches GetCurrentLength with no out argument and native code writes the length through an unset pointer
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.GetCurrentLength(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `BA0C7A`, PENDING
  - Falsified if: currentLength is declared other than a 4-byte DWORD, so the byte count a caller reads through the Lock pointer carries stale bits and overruns the buffer
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.SetCurrentLength(int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `6EBEA5`, PENDING
  - Falsified if: currentLength is not passed as a 4-byte DWORD, so SetCurrentLength stores a length taken from stray bits and GetCurrentLength then reports more valid bytes than were written
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.GetMaxLength(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `5A8655`, PENDING
  - Falsified if: maxLength is declared other than a 4-byte DWORD, so a capacity with stale upper bits sizes a write through the Lock pointer past the buffer
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `782571`, PENDING
  - Falsified if: a member out of mfobjects.h vtable order (GetItem at slot 3 through CopyAllItems at slot 32) sends a call to a native method whose arguments differ, so a PROPVARIANT, GUID or pointer is written through an out sized for something else
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetItem(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `CE6DAE`, PENDING
  - Falsified if: GetItem is not vtable slot 3, directly after IUnknown, so a lookup reaches GetItemType and the PROPVARIANT the caller then reads holds only a 4-byte type code
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetItemType(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `14817B`, PENDING
  - Falsified if: GetItemType is not vtable slot 4, directly after GetItem, so a call reaches GetItem and native code writes a whole PROPVARIANT through the 4-byte type out
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.CompareItem(ref Guid, IntPtr, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `E2FA0C`, PENDING
  - Falsified if: CompareItem is not vtable slot 5, after GetItemType, so a comparison reaches Compare and native code calls through the PROPVARIANT pointer as an IMFAttributes object
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.Compare(IMFAttributes, int, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `FC95C3`, PENDING
  - Falsified if: result is marshalled as a 1-byte bool rather than a 4-byte BOOL, so native code writes 3 bytes past the managed out slot
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetUINT32(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `22EFE5`, PENDING
  - Falsified if: GetUINT32 is not vtable slot 7, so a call reaches GetUINT64 and native code writes 8 bytes through the 4-byte value out
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetUINT64(ref Guid, out long)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `B0164D`, PENDING
  - Falsified if: value is declared narrower than 8 bytes, so native code writes the UINT64 past the managed out slot
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetDouble(ref Guid, out double)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `E83B03`, PENDING
  - Falsified if: GetDouble is not vtable slot 9, so a call reaches GetGUID and native code writes 16 bytes through the 8-byte double out
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetGUID(ref Guid, out Guid)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `04EAF7`, PENDING
  - Falsified if: GetGUID is not vtable slot 10, so a call reaches GetDouble or GetStringLength and the 16-byte out receives a value of another attribute type
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetStringLength(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `CC6026`, PENDING
  - Falsified if: GetStringLength is not vtable slot 11, so a call reaches GetGUID and native code writes 16 bytes through the 4-byte length out
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetString(ref Guid, IntPtr, int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `77BE94`, PENDING
  - Falsified if: value and size reach IMFAttributes::GetString(REFGUID, LPWSTR, UINT32, UINT32*) in swapped positions, so the string is written to the address given by the capacity
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetAllocatedString(ref Guid, out IntPtr, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `028D50`, PENDING
  - Falsified if: value and length reach GetAllocatedString(REFGUID, LPWSTR*, UINT32*) in swapped positions, so the string pointer is written into the 4-byte length and the caller frees a truncated address
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetBlobSize(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `689F15`, PENDING
  - Falsified if: GetBlobSize is not vtable slot 14, so a call reaches GetAllocatedString and native code writes a pointer through the 4-byte size out
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetBlob(ref Guid, IntPtr, int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `DF996E`, PENDING
  - Falsified if: buffer and bufferSize reach IMFAttributes::GetBlob(REFGUID, UINT8*, UINT32, UINT32*) in swapped positions, so the blob is copied to the address given by the size
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetAllocatedBlob(ref Guid, out IntPtr, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `D95683`, PENDING
  - Falsified if: buffer and size reach GetAllocatedBlob(REFGUID, UINT8**, UINT32*) in swapped positions, so the blob pointer is written into the 4-byte size and the caller reads through a truncated address
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetUnknown(ref Guid, ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `D93F2C`, PENDING
  - Falsified if: key and interfaceId reach GetUnknown(REFGUID, REFIID, LPVOID*) in swapped positions, so the store looks the IID up as the key and returns an object queried for the key GUID
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetItem(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `8A63F9`, PENDING
  - Falsified if: SetItem is not vtable slot 18, after GetUnknown, so a store request reaches GetUnknown and native code writes an interface pointer through the PROPVARIANT argument
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.DeleteItem(ref Guid)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `74315D`, PENDING
  - Falsified if: DeleteItem is not vtable slot 19, directly after SetItem, so a call carrying only a key reaches SetItem and native code reads a PROPVARIANT through an unset argument
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.DeleteAllItems()` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `B3EEDA`, PENDING
  - Falsified if: DeleteAllItems is not vtable slot 20, so a call with no arguments reaches DeleteItem or SetUINT32 and native code dereferences an unset key pointer
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetUINT32(ref Guid, int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `ACC7DC`, PENDING
  - Falsified if: SetUINT32 is not vtable slot 21, so a call reaches SetUINT64 and the key is stored as a UINT64 that a later GetUINT32 rejects as the wrong type
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetUINT64(ref Guid, long)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `D8F6A0`, PENDING
  - Falsified if: value is declared narrower than 8 bytes, so a packed MF_MT_FRAME_SIZE or MF_MT_FRAME_RATE pair loses its high 32 bits when stored
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetDouble(ref Guid, double)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `0AB870`, PENDING
  - Falsified if: SetDouble is not vtable slot 23, so the double travels in a floating-point register while native code reads an integer register and stores an unrelated value
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetGUID(ref Guid, ref Guid)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `4C3268`, PENDING
  - Falsified if: SetGUID is not vtable slot 24, so a call reaches SetString and native code reads the 16-byte GUID as a NUL-terminated UTF-16 string past its end
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetString(ref Guid, string)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `C88CB0`, PENDING
  - Falsified if: value is marshalled as an ANSI LPStr instead of LPWStr, so native code reads single-byte text as UTF-16 and runs past the marshalled buffer looking for a 2-byte terminator
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetBlob(ref Guid, IntPtr, int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `643E87`, PENDING
  - Falsified if: buffer and size reach IMFAttributes::SetBlob(REFGUID, const UINT8*, UINT32) in swapped positions, so the store copies the blob from the address given by the size
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetUnknown(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `EB4C73`, PENDING
  - Falsified if: SetUnknown is not vtable slot 27, after SetBlob, so a store request reaches SetBlob and native code copies from the IUnknown pointer with an unset size
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.LockStore()` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `52D8D9`, PENDING
  - Falsified if: LockStore is not vtable slot 28, directly after SetUnknown, so a lock request reaches SetUnknown or UnlockStore and the attribute store is never locked
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.UnlockStore()` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `B80F37`, PENDING
  - Falsified if: UnlockStore is not vtable slot 29, directly after LockStore, so an unlock reaches GetCount, which writes through an unset argument and leaves the store locked
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetCount(out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `C12DCA`, PENDING
  - Falsified if: GetCount is not vtable slot 30, so a call reaches GetItemByIndex and native code takes the count out pointer as an index and writes a GUID through an unset argument
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetItemByIndex(int, out Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `57C3C3`, PENDING
  - Falsified if: GetItemByIndex is not vtable slot 31, after GetCount, so an indexed read reaches CopyAllItems and native code calls through the GUID out pointer as an IMFAttributes object
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.CopyAllItems(IMFAttributes)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `F083D6`, PENDING
  - Falsified if: CopyAllItems is not the last member at vtable slot 32, so IMFActivate.ActivateObject and IMFMediaType.GetMajorType in the derived interfaces dispatch to the wrong native slot
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineNotify` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `4624E7`, PENDING
  - Falsified if: the [Guid] differs from IID_IMFMediaEngineNotify (FEE7C112-E776-42B5-9BBF-0048524E2BD5), so the engine's QueryInterface on the callback fails and CreateInstance has no notify sink
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineNotify.EventNotify(uint, UIntPtr, uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `FD7E19`, PENDING
  - Falsified if: param1 is declared narrower than the pointer-sized DWORD_PTR, so on x64 the high half of an event's param1, such as the NOTIFYSTABLESTATE event handle, is lost
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineClassFactory` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `85C98C`, PENDING
  - Falsified if: a member is declared out of mfmediaengine.h order, so CreateInstance runs CreateTimeRange's slot and the engine out pointer receives an IMFMediaTimeRange
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineClassFactory.CreateInstance(uint, IMFAttributes, out IMFMediaEngine)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `9BBC9A`, PENDING
  - Falsified if: the marshaller wraps the IMFMediaEngine written to mediaEngine without releasing the reference the factory returned, so each engine keeps one native reference after Shutdown and the last managed release
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineClassFactory.CreateTimeRange(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `37E2E9`, PENDING
  - Falsified if: CreateTimeRange is not vtable slot 4, directly after CreateInstance, so the call reaches CreateError and an IMFMediaError is returned where a time range is expected
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineClassFactory.CreateError(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `DF2494`, PENDING
  - Falsified if: CreateError is not vtable slot 5, the last IMFMediaEngineClassFactory method, so the call reaches CreateTimeRange and a time range is returned where an error object is expected
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=Critical, Spec=none cited, `B197E9`, PENDING
  - Falsified if: a member is missing or out of mfmediaengine.h order, so later slots shift and a call such as Shutdown() runs TransferVideoFrame, which dereferences unset surface and RECT pointer arguments
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetError(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `E58FDF`, PENDING
  - Falsified if: GetError is not vtable slot 3, the first IMFMediaEngine method, so an error query reaches SetErrorCode and the out pointer is taken as an error code
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetErrorCode(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `ABCE54`, PENDING
  - Falsified if: SetErrorCode does not sit in the slot after GetError, so the MF_MEDIA_ENGINE_ERR code reaches SetSourceElements and is dereferenced as an interface pointer
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetSourceElements(IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `625F7D`, PENDING
  - Falsified if: SetSourceElements does not sit in the slot after SetErrorCode, so the source-elements pointer reaches SetSource and the engine reads it as a BSTR URL
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetSource(string)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `670DA0`, PENDING
  - Falsified if: url is marshalled without the BStr attribute, so the engine reads the length from the four bytes before an LPWSTR and copies past the end of the page-supplied URL
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetCurrentSource(out string?)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `CA939B`, PENDING
  - Falsified if: the BSTR written to url is not freed with SysFreeString after conversion, so each call leaks a copy of the page-supplied source URL
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetNetworkState()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `6A0B51`, PENDING
  - Falsified if: the return is declared wider than the native USHORT, so stale upper bits of the return register yield a network state outside NETWORK_EMPTY to NETWORK_NO_SOURCE (0 to 3)
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetPreload()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `55635A`, PENDING
  - Falsified if: PreserveSig is dropped, so the stub treats the MF_MEDIA_ENGINE_PRELOAD return as an HRESULT and reads the value through a retval pointer the native method never writes
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetPreload(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `B5134F`, PENDING
  - Falsified if: SetPreload does not sit in the slot after GetPreload, so the preload value reaches GetBuffered as its out pointer and the engine writes an interface pointer to that address
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetBuffered(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `80B762`, PENDING
  - Falsified if: GetBuffered does not sit in the slot after SetPreload, so the call reaches SetPreload or Load and the caller reads an unset time-range pointer
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.Load()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `4179CD`, PENDING
  - Falsified if: Load is shifted onto a neighbouring slot, so a call meant to start loading page media runs GetBuffered or CanPlayType with unset pointer arguments
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.CanPlayType(string, out int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `310347`, PENDING
  - Falsified if: type is marshalled without the BStr attribute, so the engine reads the MIME type's length from the four bytes before an LPWSTR and parses past the end of the page-supplied string
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetReadyState()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `731F28`, PENDING
  - Falsified if: the return is declared wider than the native USHORT, so stale upper bits of the return register yield a ready state outside HAVE_NOTHING to HAVE_ENOUGH_DATA (0 to 4)
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.IsSeeking()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `40C53E`, PENDING
  - Falsified if: IsSeeking is shifted onto GetCurrentTime's slot, so the BOOL is read from EAX while the engine returns a double in XMM0
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetCurrentTime()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `D30507`, PENDING
  - Falsified if: the return is declared as an integer type, so the position is read from EAX while the engine returns it as a double in XMM0
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetCurrentTime(double)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `A4CA2E`, PENDING
  - Falsified if: seekTime is declared as float, so the engine reads a double from a register holding a single-precision value and seeks page media to an unrelated position
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetStartTime()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `B36727`, PENDING
  - Falsified if: the return is declared as an integer type, so the start time is read from EAX while the engine returns it as a double in XMM0
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetDuration()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `AED091`, PENDING
  - Falsified if: the return is declared as an integer type, so a NaN or infinite duration for unknown or live media is read from EAX instead of XMM0 and looks finite
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.IsPaused()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `2CE76C`, PENDING
  - Falsified if: IsPaused is shifted onto GetDuration's or GetDefaultPlaybackRate's slot, so the BOOL is read from EAX while the engine returns a double in XMM0
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetDefaultPlaybackRate()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `245D28`, PENDING
  - Falsified if: the return is declared as an integer type, so the default rate is read from EAX while the engine returns it as a double in XMM0
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetDefaultPlaybackRate(double)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `1D2A07`, PENDING
  - Falsified if: Rate is declared as float, so the engine reads a double from a register holding a single-precision value and sets an unrelated default rate
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetPlaybackRate()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `63C2D3`, PENDING
  - Falsified if: the return is declared as an integer type, so the playback rate is read from EAX while the engine returns it as a double in XMM0
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetPlaybackRate(double)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `478425`, PENDING
  - Falsified if: Rate is declared as float, so the engine reads a double from a register holding a single-precision value and plays page media at an unrelated rate
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetPlayed(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `C0F99A`, PENDING
  - Falsified if: GetPlayed does not sit in the slot after SetPlaybackRate, so the call reaches SetPlaybackRate and the caller reads an unset time-range pointer
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetSeekable(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `B6B68E`, PENDING
  - Falsified if: GetSeekable does not sit in the slot after GetPlayed, so the call reaches IsEnded and the caller reads an unset time-range pointer
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.IsEnded()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `4FE527`, PENDING
  - Falsified if: IsEnded is shifted onto GetSeekable's slot, so the engine writes an IMFMediaTimeRange pointer through an unset out-pointer argument
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetAutoPlay()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `57EAA0`, PENDING
  - Falsified if: GetAutoPlay is shifted onto SetAutoPlay's slot, so the engine reads its BOOL argument from an unset register and may switch autoplay on for page media
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetAutoPlay(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `FEDB7F`, PENDING
  - Falsified if: AutoPlay is declared as a one-byte bool, so the upper bytes of the 32-bit BOOL argument are undefined and a false request can enable autoplay
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetLoop()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `5CDB3E`, PENDING
  - Falsified if: GetLoop is shifted onto SetLoop's slot, so the engine reads its BOOL argument from an unset register and may turn looping on
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetLoop(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `992AFA`, PENDING
  - Falsified if: Loop is declared as a one-byte bool, so the upper bytes of the 32-bit BOOL argument are undefined and a false request can leave page media looping
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.Play()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `69F7C6`, PENDING
  - Falsified if: Play does not sit in the slot after SetLoop, so a play request runs SetLoop or Pause instead and no MF_MEDIA_ENGINE_EVENT_PLAY follows
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.Pause()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `3DEE33`, PENDING
  - Falsified if: Pause is shifted onto Play's slot, so a pause request starts or keeps decoding page media
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetMuted()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `5AB855`, PENDING
  - Falsified if: GetMuted is shifted onto SetMuted's slot, so the engine reads its BOOL argument from an unset register and may unmute page audio
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetMuted(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `07AB7B`, PENDING
  - Falsified if: Muted is declared as a one-byte bool, so the upper bytes of the 32-bit BOOL argument are undefined and an unmute request can leave the audio muted
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetVolume()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `53DD7D`, PENDING
  - Falsified if: the return is declared as an integer type, so the volume is read from EAX while the engine returns it as a double in XMM0
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetVolume(double)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `A18602`, PENDING
  - Falsified if: Volume is declared as float, so the engine reads a double from a register holding a single-precision value and sets an unrelated volume
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.HasVideo()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `313443`, PENDING
  - Falsified if: HasVideo is swapped with HasAudio relative to mfmediaengine.h, so an audio-only resource reports video and a video-only resource reports none
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.HasAudio()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `238FA6`, PENDING
  - Falsified if: HasAudio is shifted onto GetNativeVideoSize's slot, so the engine writes two DWORDs through unset out-pointer arguments
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetNativeVideoSize(out uint, out uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `B5334A`, PENDING
  - Falsified if: cx or cy is declared narrower than the 32-bit DWORD, so the engine writes four bytes into a two-byte slot and overwrites the adjacent local
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetVideoAspectRatio(out uint, out uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `C5F727`, PENDING
  - Falsified if: GetVideoAspectRatio is swapped with GetNativeVideoSize in the vtable, so a caller sizing frames receives the pixel aspect ratio, for example 1 by 1, as the video dimensions
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.Shutdown()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `B383A8`, PENDING
  - Falsified if: Shutdown is shifted onto TransferVideoFrame's slot, so the call passes no arguments and the engine dereferences unset surface and RECT pointers
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.TransferVideoFrame(IntPtr, IntPtr, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=Critical, Spec=none cited, `037618`, PENDING
  - Falsified if: source, destination and borderColor reach TransferVideoFrame(IUnknown*, const MFVideoNormalizedRect*, const RECT*, const MFARGB*) in another order, so the engine reads the normalized source rectangle through the destination RECT pointer
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.OnVideoStreamTick(out long)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `B3A83D`, PENDING
  - Falsified if: presentationTime is declared narrower than the 64-bit LONGLONG, so the engine writes eight bytes into a four-byte slot and overwrites the adjacent local
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, Spec=none cited, `48313E`, PENDING
  - Falsified if: an mfplat.dll import differs from its mfapi.h prototype in pointer width, so a 64-bit caller of MFCreateAttributes wraps and Releases a truncated IMFAttributes address
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative.MFStartup(int, int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, Spec=none cited, `FB247B`, PENDING
  - Falsified if: the import declares a calling convention other than the WINAPI default that STDAPI requires, so on 32-bit x86 the version and flags arguments are popped by both sides and the caller's stack is unbalanced after MFStartup returns
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative.MFShutdown()` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, Spec=none cited, `344711`, PENDING
  - Falsified if: the import binds to an export other than mfplat.dll's MFShutdown, so the platform reference a successful MFStartup takes is never dropped and Media Foundation work-queue threads outlive the last disposed scope
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative.MFCreateAttributes(out IMFAttributes, uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, Spec=none cited, `A9BFE4`, PENDING
  - Falsified if: the typed overload wraps the IMFAttributes** result without releasing the reference MFCreateAttributes returned, so each attribute store created through it outlives the release of its wrapper
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative.MFCreateAttributes(out IntPtr, uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, Spec=none cited, `E28897`, PENDING
  - Falsified if: the out parameter is narrower than pointer width, so on 64-bit the upper half of the returned IMFAttributes pointer is dropped and the caller wraps and Releases a truncated address
- `Broiler.Native.Windows.PerformanceCounterNative` in `src/Broiler.Native.Windows/PerformanceCounterNative.cs` - Security=High, Spec=none cited, `641D5D`, PENDING
  - Falsified if: either kernel32 import declares its LARGE_INTEGER out parameter narrower than 8 bytes, so the call writes past the managed slot in the caller's frame
- `Broiler.Native.Windows.PerformanceCounterNative.QueryPerformanceCounter(out long)` in `src/Broiler.Native.Windows/PerformanceCounterNative.cs` - Security=High, Spec=none cited, `F43BED`, PENDING
  - Falsified if: the out parameter is narrower than the 8-byte LARGE_INTEGER, so kernel32 writes past the managed slot and the tick count read back wraps within minutes of boot
- `Broiler.Native.Windows.PerformanceCounterNative.QueryPerformanceFrequency(out long)` in `src/Broiler.Native.Windows/PerformanceCounterNative.cs` - Security=High, Spec=none cited, `96C697`, PENDING
  - Falsified if: the out parameter is narrower than the 8-byte LARGE_INTEGER, so kernel32 writes eight bytes into a smaller managed slot and corrupts the adjacent value in the caller's frame
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `C217C8`, PENDING
  - Falsified if: PropVariantClear is handed the 16-byte managed PropVariant on x64 while ole32 clears a 24-byte PROPVARIANT, overwriting the 8 bytes that follow it
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.PropVariantClear(ref PropVariant)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `72B3B6`, PENDING
  - Falsified if: on x64 ole32 PropVariantClear zeroes a 24-byte PROPVARIANT through a pointer to the 16-byte managed PropVariant, overwriting the 8 bytes after a stack local
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.CreateEventW(IntPtr, bool, bool, string?)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `7EA6F8`, PENDING
  - Falsified if: a NULL return leaves Marshal.GetLastWin32Error reporting a code from an earlier call because the stub does not capture the last error after CreateEventW
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.SetEvent(IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `E6D39B`, PENDING
  - Falsified if: the BOOL result is read as a 1-byte bool instead of a 4-byte BOOL, so a failed SetEvent on a closed handle reports success and a blocked capture wait is never interrupted
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.CloseHandle(IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `0F7F8E`, PENDING
  - Falsified if: the BOOL result is read as a 1-byte bool instead of a 4-byte BOOL, so closing an event handle that was already closed reports success and the double close goes unnoticed
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.WaitForSingleObject(IntPtr, uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `75FDEC`, PENDING
  - Falsified if: a WAIT_FAILED return on a closed handle leaves Marshal.GetLastWin32Error reporting a code from an earlier call because the stub does not capture the last error
- `Broiler.Native.Windows.Wasapi.PropertyKey` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `B090C8`, PENDING
  - Falsified if: the layout is not a 16-byte GUID followed by a 4-byte DWORD (20 bytes, no padding) as in wtypes.h PROPERTYKEY, so GetAt and GetValue read or write the property id at the wrong offset
- `Broiler.Native.Windows.Wasapi.PropVariant` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `6295F8`, PENDING
  - Falsified if: Marshal.SizeOf of PropVariant is 16 on x64 while the native PROPVARIANT of propidl.h is 24, so IPropertyStore.GetValue and PropVariantClear write 8 bytes past the managed value
- `Broiler.Native.Windows.Wasapi.WaveFormatEx` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `6A0461`, PENDING
  - Falsified if: the layout is not the 18-byte, byte-packed WAVEFORMATEX of mmreg.h (nSamplesPerSec at offset 4, cbSize at offset 16), so the mix format read from GetMixFormat yields the wrong sample rate or cbSize
- `Broiler.Native.Windows.Wasapi.WaveFormatExtensible` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `DE61A8`, PENDING
  - Falsified if: the layout is not the 40-byte WAVEFORMATEXTENSIBLE of mmreg.h (Samples at 18, dwChannelMask at 20, SubFormat at 24), so the sub-format GUID is taken from the wrong bytes of a mix-format block
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `5E529E`, PENDING
  - Falsified if: the members are not in mmdeviceapi.h vtable order (EnumAudioEndpoints, GetDefaultAudioEndpoint, GetDevice, RegisterEndpointNotificationCallback, UnregisterEndpointNotificationCallback) after IUnknown, so a call lands in another method's slot
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.EnumAudioEndpoints(EDataFlow, DeviceState, out IMMDeviceCollection)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `B02A40`, PENDING
  - Falsified if: dataFlow and stateMask are not passed as the 4-byte EDataFlow and DWORD of mmdeviceapi.h, so a capture-only Active enumeration returns render or disabled endpoints
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.GetDefaultAudioEndpoint(EDataFlow, ERole, out IMMDevice)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `2C427E`, PENDING
  - Falsified if: dataFlow and role are not passed as the 4-byte EDataFlow and ERole of mmdeviceapi.h, so the default capture endpoint is resolved for another role or data flow
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.GetDevice(string, out IMMDevice)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `B582C9`, PENDING
  - Falsified if: id is marshalled as anything other than a NUL-terminated UTF-16 LPCWSTR, so an endpoint id returned by IMMDevice.GetId does not round-trip and GetDevice returns E_NOTFOUND
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.RegisterEndpointNotificationCallback(IMMNotificationClient)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `5ECB61`, PENDING
  - Falsified if: client is not passed as an interface pointer for IID 7991EEC9-7E89-4D85-8390-6C703CEC60C0, so the audio service calls OnDeviceStateChanged through the vtable of another interface
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.UnregisterEndpointNotificationCallback(IMMNotificationClient)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `81112A`, PENDING
  - Falsified if: UnregisterEndpointNotificationCallback is not the fifth method after IUnknown, directly after RegisterEndpointNotificationCallback, so an unregister request registers the client again and its callbacks keep arriving after the owner is gone
- `Broiler.Native.Windows.Wasapi.IMMDeviceCollection` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `6ACDC0`, PENDING
  - Falsified if: GetCount and Item are not the first two slots after IUnknown as in mmdeviceapi.h, so an Item call runs GetCount and a device pointer is written into a uint
- `Broiler.Native.Windows.Wasapi.IMMDeviceCollection.GetCount(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `9DEF9C`, PENDING
  - Falsified if: count is written through a pointer to anything other than a 4-byte UINT, so an Item loop bounded by it reads part of its bound from the adjacent stack slot
- `Broiler.Native.Windows.Wasapi.IMMDeviceCollection.Item(uint, out IMMDevice)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `A3EAF2`, PENDING
  - Falsified if: itemIndex and the device out reach IMMDeviceCollection::Item(UINT, IMMDevice**) in swapped positions, so the device pointer is written through the index value as an address
- `Broiler.Native.Windows.Wasapi.IMMDevice` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `37CE13`, PENDING
  - Falsified if: a member is out of mmdeviceapi.h order (Activate, OpenPropertyStore, GetId, GetState after IUnknown), so GetId's string-pointer out or Activate's parameter pointer reaches a method that reads or writes it with another size
- `Broiler.Native.Windows.Wasapi.IMMDevice.Activate(ref Guid, uint, IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `86ECE4`, PENDING
  - Falsified if: activationParams and the out pointer reach IMMDevice::Activate(REFIID, DWORD, PROPVARIANT*, void**) in swapped positions, so the activated interface is written through the activation-parameter pointer
- `Broiler.Native.Windows.Wasapi.IMMDevice.OpenPropertyStore(StorageAccess, out IPropertyStore)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `4D668C`, PENDING
  - Falsified if: access is not passed as the 4-byte DWORD stgmAccess of mmdeviceapi.h, so the store is opened with an access mode taken from undefined upper bits
- `Broiler.Native.Windows.Wasapi.IMMDevice.GetId(out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `A54561`, PENDING
  - Falsified if: GetId is not vtable slot 5, after OpenPropertyStore, so an id query reaches GetState and a 4-byte state is written into the 8-byte string-pointer out the caller then dereferences
- `Broiler.Native.Windows.Wasapi.IMMDevice.GetState(out DeviceState)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `2C18EF`, PENDING
  - Falsified if: state is written through a pointer to anything other than a 4-byte DWORD, so an unplugged endpoint can read as Active
- `Broiler.Native.Windows.Wasapi.IPropertyStore` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `079EE3`, PENDING
  - Falsified if: GetValue writes a 24-byte PROPVARIANT on x64 into the 16-byte managed PropVariant it is given, corrupting the 8 bytes after it
- `Broiler.Native.Windows.Wasapi.IPropertyStore.GetCount(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `39889B`, PENDING
  - Falsified if: propertyCount is written through a pointer to anything other than a 4-byte DWORD, so a GetAt loop bounded by it asks for indexes past the end of the store
- `Broiler.Native.Windows.Wasapi.IPropertyStore.GetAt(uint, out PropertyKey)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `53B7D0`, PENDING
  - Falsified if: GetAt is not vtable slot 4, directly after GetCount, so an index lookup reaches GetValue and native code writes a PROPVARIANT through the 20-byte PROPERTYKEY out
- `Broiler.Native.Windows.Wasapi.IPropertyStore.GetValue(ref PropertyKey, out PropVariant)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `2E7085`, PENDING
  - Falsified if: on x64 the property store writes a 24-byte PROPVARIANT through the pointer to the 16-byte managed PropVariant, overwriting the 8 bytes after a stack local such as GetFriendlyName's value
- `Broiler.Native.Windows.Wasapi.IPropertyStore.SetValue(ref PropertyKey, ref PropVariant)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `7DEB4C`, PENDING
  - Falsified if: on x64 the property store reads a 24-byte PROPVARIANT from the 16-byte managed PropVariant, taking the 8 bytes after the struct as part of the value
- `Broiler.Native.Windows.Wasapi.IPropertyStore.Commit()` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `8609BA`, PENDING
  - Falsified if: Commit is not vtable slot 7, the last IPropertyStore method, so a commit request reaches SetValue and native code dereferences unset key and value pointers
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `2B52F8`, PENDING
  - Falsified if: an implementation blocks, or calls Register or UnregisterEndpointNotificationCallback, inside a callback that runs on the audio service's notification thread and deadlocks it
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnDeviceStateChanged(string, DeviceState)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `96A9AC`, PENDING
  - Falsified if: deviceId is not unmarshalled as a NUL-terminated UTF-16 LPCWSTR, so the endpoint id given to the implementation does not match the one IMMDevice.GetId returns
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnDeviceAdded(string)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `4EA116`, PENDING
  - Falsified if: deviceId is not unmarshalled as a NUL-terminated UTF-16 LPCWSTR, so the id of an added endpoint does not match the one GetDevice accepts
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnDeviceRemoved(string)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `A1017B`, PENDING
  - Falsified if: deviceId is not unmarshalled as a NUL-terminated UTF-16 LPCWSTR, so a removed endpoint is not matched to the capture session that is using it
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnDefaultDeviceChanged(EDataFlow, ERole, string)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `5AFB15`, PENDING
  - Falsified if: defaultDeviceId arrives as null when no default endpoint remains for the flow and role, and an implementation that dereferences it throws on the notification thread
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnPropertyValueChanged(string, PropertyKey)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `DEBD93`, PENDING
  - Falsified if: key is read with an argument convention other than the by-value 20-byte PROPERTYKEY of mmdeviceapi.h, so the implementation receives a format id and property id the audio service did not send
- `Broiler.Native.Windows.Wasapi.IAudioClient` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `85032C`, PENDING
  - Falsified if: a member is out of audioclient.h order, so Initialize's format pointer or GetMixFormat's out pointer reaches another method that reads or writes it with a different size
- `Broiler.Native.Windows.Wasapi.IAudioClient.Initialize(AudioClientShareMode, AudioClientStreamFlags, long, long, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `8F9E64`, PENDING
  - Falsified if: format and audioSessionGuid reach IAudioClient::Initialize in swapped positions, so the engine reads the WAVEFORMATEX through the session GUID pointer, or through null when no session is given
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetBufferSize(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `7407DC`, PENDING
  - Falsified if: bufferFrameCount is written through a pointer to anything other than a 4-byte UINT32, so a buffer sized from it is smaller than the endpoint buffer
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetStreamLatency(out long)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `FEE5D6`, PENDING
  - Falsified if: latency is written through a pointer to anything other than an 8-byte REFERENCE_TIME, so half of the reported latency comes from the adjacent stack slot
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetCurrentPadding(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `B5581D`, PENDING
  - Falsified if: currentPaddingFrameCount is written through a pointer to anything other than a 4-byte UINT32, so the frames already queued in the endpoint buffer are misread
- `Broiler.Native.Windows.Wasapi.IAudioClient.IsFormatSupported(AudioClientShareMode, IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `9D437E`, PENDING
  - Falsified if: format and the closestMatch out reach IAudioClient::IsFormatSupported in swapped positions, so the engine reads the WAVEFORMATEX from the caller's out slot
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetMixFormat(out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `EB4C3A`, PENDING
  - Falsified if: GetMixFormat is not vtable slot 8, directly after IsFormatSupported, so the query reaches GetDevicePeriod and an 8-byte period is written where the caller expects a WAVEFORMATEX pointer
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetDevicePeriod(out long, out long)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `C6E8C9`, PENDING
  - Falsified if: the two REFERENCE_TIME outputs are not in audioclient.h order (default period, then minimum period), so a client takes the minimum period for the default
- `Broiler.Native.Windows.Wasapi.IAudioClient.Start()` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `6B8586`, PENDING
  - Falsified if: Start is not the eighth method after IUnknown as in audioclient.h, so a request to start capture runs GetDevicePeriod or Stop instead
- `Broiler.Native.Windows.Wasapi.IAudioClient.Stop()` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `458393`, PENDING
  - Falsified if: Stop is not the ninth method after IUnknown as in audioclient.h, so a request to stop capture runs Start or Reset and the stream keeps running
- `Broiler.Native.Windows.Wasapi.IAudioClient.Reset()` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `C17181`, PENDING
  - Falsified if: Reset is not the tenth method after IUnknown as in audioclient.h, so a reset runs another method and the queued packets are not flushed
- `Broiler.Native.Windows.Wasapi.IAudioClient.SetEventHandle(IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `A5695E`, PENDING
  - Falsified if: SetEventHandle is not vtable slot 13, after Reset, so the event handle reaches GetService as its IID pointer and the engine never signals it
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetService(ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `DCDAC0`, PENDING
  - Falsified if: interfaceId and the out pointer reach IAudioClient::GetService(REFIID, void**) in swapped positions, so the service pointer is written over the caller's IID
- `Broiler.Native.Windows.Wasapi.IAudioCaptureClient` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `E6F0E2`, PENDING
  - Falsified if: GetBuffer, ReleaseBuffer and GetNextPacketSize are not the first three slots after IUnknown as in audioclient.h, so the packet pointer and frame count are read from outputs another method never wrote
- `Broiler.Native.Windows.Wasapi.IAudioCaptureClient.GetBuffer(out IntPtr, out uint, out AudioClientBufferFlags, out ulong, out ulong)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `BE96C9`, PENDING
  - Falsified if: data and framesToRead reach IAudioCaptureClient::GetBuffer(BYTE**, UINT32*, DWORD*, UINT64*, UINT64*) in swapped positions, so the frame count that sizes the caller's copy is read from the packet pointer
- `Broiler.Native.Windows.Wasapi.IAudioCaptureClient.ReleaseBuffer(uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `D3903A`, PENDING
  - Falsified if: ReleaseBuffer is not vtable slot 4, directly after GetBuffer, so a release reaches GetNextPacketSize and the engine writes a frame count through the framesRead value as an address
- `Broiler.Native.Windows.Wasapi.IAudioCaptureClient.GetNextPacketSize(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `6EB7A4`, PENDING
  - Falsified if: framesInNextPacket is written through a pointer to anything other than a 4-byte UINT32, so a drain loop that stops at zero never sees zero and spins
- `Broiler.Native.Windows.Wasapi.WasapiExtensions` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `D28A8B`, PENDING
  - Falsified if: Activate and GetService never release the native reference their COM call returned once GetOrCreateComObject has taken its own, so each call leaks one COM reference
- `Broiler.Native.Windows.Wasapi.WasapiExtensions.Activate<TInterface>(this IMMDevice, uint, IntPtr, out TInterface?)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `E4FA3E`, PENDING
  - Falsified if: the pointer IMMDevice.Activate returns with S_OK is wrapped by GetOrCreateComObject, which takes its own reference, and is never released, so every call leaks one reference to the activated object
- `Broiler.Native.Windows.Wasapi.WasapiExtensions.GetService<TInterface>(this IAudioClient, out TInterface?)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `1D2EA0`, PENDING
  - Falsified if: the pointer IAudioClient.GetService returns with S_OK is wrapped by GetOrCreateComObject, which takes its own reference, and is never released, so every call leaks one reference to the service object
- `Broiler.Native.Windows.Wic.WicNative` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `5EFA14`, PENDING
  - Falsified if: CopyPixels on a frame or format converter receives cbStride, cbBufferSize and pbBuffer out of order, so the codec writes decoded page-image rows to an address given by a size value
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `1783FD`, PENDING
  - Falsified if: a member is out of wincodec.h order (IWICBitmapSource's GetSize to CopyPixels at slots 3-7, then GetMetadataQueryReader, GetColorContexts, GetThumbnail), so a call reaches a native method with another argument list that writes through its stride, size or index argument as a pointer
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetSize(out uint, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `7C536B`, PENDING
  - Falsified if: GetSize is not vtable slot 3, the first IWICBitmapSource member, so a call reaches GetPixelFormat and native code writes a 16-byte GUID through the 4-byte width out
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetPixelFormat(out Guid)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `69EFDA`, PENDING
  - Falsified if: GetPixelFormat is not vtable slot 4, directly after GetSize, so a call reaches GetResolution and native code writes a second double through an unset argument register
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetResolution(out double, out double)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `2054F8`, PENDING
  - Falsified if: pDpiX or pDpiY is declared as a 4-byte float or int rather than an 8-byte double, so native code writes 8 bytes into a 4-byte managed out slot
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.CopyPalette(IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `ACA555`, PENDING
  - Falsified if: CopyPalette is not vtable slot 6 of IWICBitmapSource, after GetResolution, so the palette pointer reaches CopyPixels as its rectangle and the codec writes pixel rows through unset arguments
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.CopyPixels(IntPtr, uint, uint, IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `19BB8D`, PENDING
  - Falsified if: cbStride, cbBufferSize and pbBuffer reach IWICBitmapSource::CopyPixels(const WICRect*, UINT, UINT, BYTE*) in another order, so the codec writes decoded page-image rows to the address given by a size value
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetMetadataQueryReader(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `5B4345`, PENDING
  - Falsified if: GetMetadataQueryReader is not vtable slot 8, the first after the IWICBitmapSource methods, so the call reaches GetColorContexts with the out pointer as its count and native code dereferences unset array arguments
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetColorContexts(uint, IntPtr, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `2E33A1`, PENDING
  - Falsified if: GetColorContexts is not vtable slot 9, after GetMetadataQueryReader, so the count and array pointer reach GetThumbnail and a bitmap-source pointer is written through the count value as an address
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetThumbnail(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `F83FCD`, PENDING
  - Falsified if: GetThumbnail is not vtable slot 10, after GetColorContexts, so the call reaches GetColorContexts with the out pointer as its count and native code dereferences unset array arguments
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `EBC48E`, PENDING
  - Falsified if: a member is out of wincodec.h order (IWICBitmapSource's GetSize to CopyPixels at slots 3-7, then Initialize at 8 and CanConvert at 9), so a call reaches a native method with another argument list that writes through one of its integer arguments as a pointer
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.GetSize(out uint, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `7C536B`, PENDING
  - Falsified if: GetSize is not vtable slot 3, the first IWICBitmapSource member, so a call reaches GetPixelFormat and native code writes a 16-byte GUID through the 4-byte width out that sizes the caller's pixel buffer
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.GetPixelFormat(out Guid)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `69EFDA`, PENDING
  - Falsified if: GetPixelFormat is not vtable slot 4, directly after GetSize, so a call reaches GetResolution and native code writes a second double through an unset argument register
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.GetResolution(out double, out double)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `2054F8`, PENDING
  - Falsified if: pDpiX or pDpiY is declared as a 4-byte float or int rather than an 8-byte double, so native code writes 8 bytes into a 4-byte managed out slot
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.CopyPalette(IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `ACA555`, PENDING
  - Falsified if: CopyPalette is not vtable slot 6 of IWICBitmapSource, after GetResolution, so the palette pointer reaches CopyPixels as its rectangle and the codec writes pixel rows through unset arguments
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.CopyPixels(IntPtr, uint, uint, IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `19BB8D`, PENDING
  - Falsified if: cbStride, cbBufferSize and pbBuffer reach IWICBitmapSource::CopyPixels(const WICRect*, UINT, UINT, BYTE*) in another order, so the codec writes converted page-image rows to the address given by a size value
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.Initialize(IWICBitmapFrameDecode, ref Guid, int, IntPtr, double, int)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `F22BAE`, PENDING
  - Falsified if: pISource is marshalled as a pointer to an interface whose slots 3-7 are not IWICBitmapSource's GetSize to CopyPixels, so the converter pulls the source's size and pixels through the wrong native methods
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.CanConvert(ref Guid, ref Guid, out int)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `C957AB`, PENDING
  - Falsified if: pfCanConvert is marshalled as a 1-byte bool rather than a 4-byte BOOL, so native code writes 3 bytes past the managed out slot
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `F3A325`, PENDING
  - Falsified if: a member is out of wincodec.h order (QueryCapability at slot 3 through GetFrame at slot 13), so a GetFrame call reaches GetFrameCount and native code writes the count through the frame index taken as a pointer
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.QueryCapability(IStream, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `E9B82A`, PENDING
  - Falsified if: QueryCapability is not vtable slot 3, so a probe of page-supplied bytes reaches Initialize and the decoder binds to the stream with the capability out pointer taken as its cache option
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.Initialize(IStream, int)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `BFEDCC`, PENDING
  - Falsified if: Initialize is not vtable slot 4, directly after QueryCapability, so a call reaches GetContainerFormat and native code writes a 16-byte GUID over the page-supplied IStream object its first argument points to
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetContainerFormat(out Guid)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `DCE272`, PENDING
  - Falsified if: the container-format out is declared narrower than the 16-byte GUID, so native code writes the GUID_ContainerFormat value past the managed out slot
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetDecoderInfo(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `51BF48`, PENDING
  - Falsified if: GetDecoderInfo is not vtable slot 6, after GetContainerFormat, so the call reaches GetContainerFormat and a 16-byte GUID is written through the 8-byte pointer out
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.CopyPalette(IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `ACA555`, PENDING
  - Falsified if: CopyPalette is not vtable slot 7 of IWICBitmapDecoder, after GetDecoderInfo, so the palette pointer reaches GetMetadataQueryReader as its out argument and a reader pointer is written into the palette object
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetMetadataQueryReader(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `5B4345`, PENDING
  - Falsified if: GetMetadataQueryReader is not vtable slot 8 of IWICBitmapDecoder, after CopyPalette, so the call reaches GetPreview and a bitmap source is returned where a metadata reader is expected
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetPreview(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `E2D6CB`, PENDING
  - Falsified if: GetPreview is not vtable slot 9, after GetMetadataQueryReader, so the call reaches GetColorContexts with the out pointer as its count and native code dereferences unset array arguments
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetColorContexts(uint, IntPtr, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `2E33A1`, PENDING
  - Falsified if: GetColorContexts is not vtable slot 10 of IWICBitmapDecoder, after GetPreview, so the count and array pointer reach GetThumbnail and a bitmap-source pointer is written through the count value as an address
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetThumbnail(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `F83FCD`, PENDING
  - Falsified if: GetThumbnail is not vtable slot 11 of IWICBitmapDecoder, after GetColorContexts, so the call reaches GetFrameCount and a 4-byte count is written into the 8-byte pointer out the caller then dereferences
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetFrameCount(out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `C7763B`, PENDING
  - Falsified if: GetFrameCount is not vtable slot 12, directly before GetFrame, so a count query reaches GetThumbnail and native code writes an 8-byte interface pointer through the 4-byte count out
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetFrame(uint, out IWICBitmapFrameDecode)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `ABCC93`, PENDING
  - Falsified if: GetFrame is not vtable slot 13, the last IWICBitmapDecoder member, so the call reaches GetFrameCount and native code writes the frame count through the frame index taken as a pointer
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `A8CD55`, PENDING
  - Falsified if: a member is out of wincodec.h order (CreateDecoderFromFilename at slot 3 through CreateFormatConverter at slot 10), so CreateDecoderFromStream reaches CreateDecoderFromFilename and native code reads the IStream pointer as a NUL-terminated UTF-16 file name
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateDecoderFromFilename(string, IntPtr, uint, int, out IWICBitmapDecoder)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `777C84`, PENDING
  - Falsified if: wzFilename is marshalled as an ANSI LPStr instead of LPWStr, so native code reads single-byte text as UTF-16 and opens a path other than the one passed, or runs past the marshalled buffer looking for a 2-byte terminator
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateDecoderFromStream(IStream, IntPtr, int, out IWICBitmapDecoder)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `A96950`, PENDING
  - Falsified if: pIStream is marshalled as an IUnknown or other interface pointer instead of the IStream obtained for IID_IStream, so the codec's Read and Seek calls on page-supplied image bytes dispatch through the wrong vtable slots
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateDecoderFromFileHandle(IntPtr, IntPtr, int, out IWICBitmapDecoder)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `0FCBE9`, PENDING
  - Falsified if: hFile is declared narrower than the pointer-sized ULONG_PTR, so on 64-bit the factory reads a truncated handle and decodes from whichever file that value names in the process
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateComponentInfo(ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `84A58A`, PENDING
  - Falsified if: CreateComponentInfo is not vtable slot 6, after CreateDecoderFromFileHandle, so the CLSID pointer reaches CreateDecoderFromFileHandle as a file handle
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateDecoder(ref Guid, IntPtr, out IWICBitmapDecoder)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `B0ED40`, PENDING
  - Falsified if: guidContainerFormat is passed by value rather than as a REFGUID pointer, so native code dereferences the first 8 bytes of the GUID as an address
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateEncoder(ref Guid, IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `F89366`, PENDING
  - Falsified if: CreateEncoder is not vtable slot 8, after CreateDecoder, so an encoder request reaches CreateDecoder and a decoder is returned where an encoder is expected
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreatePalette(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `592ED9`, PENDING
  - Falsified if: CreatePalette is not vtable slot 9, after CreateEncoder, so the call reaches CreateFormatConverter and a converter is returned where a palette is expected
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateFormatConverter(out IWICFormatConverter)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `903F42`, PENDING
  - Falsified if: CreateFormatConverter is not vtable slot 10, so the call reaches CreatePalette and the returned IWICPalette fails the cast to IWICFormatConverter, making every converted decode throw
- `Broiler.Native.Windows.WindowNative` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `3B0E79`, PENDING
  - Falsified if: GetWindowText(IntPtr, Span<char>) passes a count other than text.Length to GetWindowTextW, so a title longer than the span is written past its end
- `Broiler.Native.Windows.WindowNative.SetWindowLongPtr(IntPtr, int, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `16DDCC`, PENDING
  - Falsified if: on a 64-bit process the call reaches SetWindowLongW rather than SetWindowLongPtrW, so the GCHandle pointer stored at GWLP_USERDATA keeps only its low 32 bits and GCHandle.FromIntPtr later resolves a truncated handle
- `Broiler.Native.Windows.WindowNative.GetWindowLongPtr(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `DD2B69`, PENDING
  - Falsified if: on a 64-bit process the call reaches GetWindowLongW rather than GetWindowLongPtrW, so the GWLP_USERDATA pointer read back is sign-extended from 32 bits and GCHandle.FromIntPtr dereferences a different handle
- `Broiler.Native.Windows.WindowNative.GetClassLongPtr(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `D4D0DB`, PENDING
  - Falsified if: on a 64-bit process the call reaches GetClassLongW rather than GetClassLongPtrW, so the GCLP_HICON value read back loses its high 32 bits and no longer equals the icon the class registered
- `Broiler.Native.Windows.WindowNative.WndProc` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `AE2EBF`, PENDING
  - Falsified if: the delegate is declared Cdecl rather than Winapi, so on 32-bit x86 the stdcall WNDPROC caller in user32 finds 16 bytes of arguments left on its stack after every dispatched message
- `Broiler.Native.Windows.WindowNative.WNDCLASSEX` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `637957`, PENDING
  - Falsified if: a field is out of winuser.h WNDCLASSEXW order or Marshal.SizeOf is not 80 on x64 (48 on x86), so RegisterClassExW takes lpfnWndProc or lpszClassName from the wrong offset and the class calls a non-function address
- `Broiler.Native.Windows.WindowNative.RECT` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `563E6D`, PENDING
  - Falsified if: Marshal.SizeOf is not 16 or the fields are not in left, top, right, bottom order, so GetWindowRect or AdjustWindowRectExForDpi writes a frame edge into the wrong member
- `Broiler.Native.Windows.WindowNative.POINT` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `AA2E46`, PENDING
  - Falsified if: Marshal.SizeOf is not 8 or Y precedes X, so ScreenToClient converts a wheel event's screen coordinates with the axes swapped
- `Broiler.Native.Windows.WindowNative.TRACKMOUSEEVENT` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `E547C3`, PENDING
  - Falsified if: Marshal.SizeOf is not 24 on x64 (16 on x86) or HwndTrack is not the third field, so TrackMouseEvent rejects the cbSize or arms leave tracking for a handle read from the flags
- `Broiler.Native.Windows.WindowNative.MSG` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `2C3C7D`, PENDING
  - Falsified if: Marshal.SizeOf is not 48 on x64 (28 on x86) or a field is out of winuser.h order, so DispatchMessageW hands the window procedure wParam in place of lParam
- `Broiler.Native.Windows.WindowNative.CREATESTRUCT` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `39F0BA`, PENDING
  - Falsified if: a field is out of winuser.h CREATESTRUCTW order, so Marshal.PtrToStructure on the WM_NCCREATE lParam reads LpCreateParams from another member and GCHandle.FromIntPtr resolves a value that is not a handle
- `Broiler.Native.Windows.WindowNative.GetModuleHandle(string?)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `150856`, PENDING
  - Falsified if: a null module name is marshalled as an empty string rather than a null pointer, so GetModuleHandleW returns zero instead of the executable's HINSTANCE and the window class is registered against no module
- `Broiler.Native.Windows.WindowNative.RegisterClassEx(ref WNDCLASSEX)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `2D2FB1`, PENDING
  - Falsified if: the import binds RegisterClassExA rather than RegisterClassExW, so the UTF-16 class name is read as a one-character ANSI string and CreateWindowExW cannot find the class
- `Broiler.Native.Windows.WindowNative.CreateWindowEx(uint, string, string, uint, int, int, int, int, IntPtr, IntPtr, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `B8CB64`, PENDING
  - Falsified if: the parameters are not in user32 CreateWindowExW order (exStyle, class, name, style, x, y, width, height, parent, menu, instance, param), so the style lands in the extended style or the GCHandle passed as param reaches hMenu
- `Broiler.Native.Windows.WindowNative.AdjustWindowRectEx(ref RECT, uint, bool, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `C0C181`, PENDING
  - Falsified if: menu is marshalled as a 1-byte bool rather than a 4-byte BOOL, so user32 reads three stray bytes and adds a menu bar's height to a window that has none
- `Broiler.Native.Windows.WindowNative.AdjustWindowRectExForDpi(ref RECT, uint, bool, uint, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `6C102F`, PENDING
  - Falsified if: exStyle and dpi are swapped relative to user32's (LPRECT, DWORD, BOOL, DWORD, UINT), so the frame is computed for a DPI read from the extended style and a 144-DPI window gets a 96-DPI border
- `Broiler.Native.Windows.WindowNative.GetSystemMetrics(int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `BF4309`, PENDING
  - Falsified if: index or the return is declared other than a 32-bit int, so SM_CXSCREEN and SM_CYSCREEN read back a register half and a window with no explicit position is centred on a garbage screen size
- `Broiler.Native.Windows.WindowNative.ShowWindow(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `BCA376`, PENDING
  - Falsified if: the BOOL return is marshalled as a 1-byte bool, so the previous-visibility result reads three stray register bytes and a hidden window reports as previously visible
- `Broiler.Native.Windows.WindowNative.UpdateWindow(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `59BCAA`, PENDING
  - Falsified if: the BOOL return is marshalled as a 1-byte bool, so an UpdateWindow on a destroyed handle reads stray register bytes and reports success
- `Broiler.Native.Windows.WindowNative.GetMessage(out MSG, IntPtr, uint, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `91B735`, PENDING
  - Falsified if: the return is marshalled as bool rather than int, so the -1 that GetMessageW returns for an invalid window handle reads as true and the loop spins dispatching an unfilled MSG
- `Broiler.Native.Windows.WindowNative.TranslateMessage(ref MSG)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `9CEEB7`, PENDING
  - Falsified if: the MSG is passed by value rather than by pointer, so user32 reads a WM_KEYDOWN's virtual key from the wrong address and no WM_CHAR is posted for typed text
- `Broiler.Native.Windows.WindowNative.DispatchMessage(ref MSG)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `4EEAC8`, PENDING
  - Falsified if: DispatchMessage binds DispatchMessageA, so a WM_CHAR for a character outside the ANSI code page reaches the Unicode window procedure converted through the code page as a question mark
- `Broiler.Native.Windows.WindowNative.DefWindowProc(IntPtr, uint, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `6D1BFB`, PENDING
  - Falsified if: DefWindowProc binds DefWindowProcA, so WM_NCCREATE copies CREATESTRUCT.lpszName as ANSI and a window created with a non-ASCII title shows a truncated caption
- `Broiler.Native.Windows.WindowNative.PostQuitMessage(int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `28D17C`, PENDING
  - Falsified if: the import is not bound to user32's PostQuitMessage, so destroying the window that owns the loop leaves GetMessage blocking and the process running with no window
- `Broiler.Native.Windows.WindowNative.PostMessage(IntPtr, uint, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `785298`, PENDING
  - Falsified if: wParam or lParam is declared as a 32-bit int, so on 64-bit a pointer-sized payload posted to the window arrives with its high half cleared
- `Broiler.Native.Windows.WindowNative.InvalidateRect(IntPtr, IntPtr, bool)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `11E879`, PENDING
  - Falsified if: erase is marshalled as a 1-byte bool rather than a 4-byte BOOL, so user32 reads three stray bytes and a false erase sends WM_ERASEBKGND, flashing the class brush behind animation frames
- `Broiler.Native.Windows.WindowNative.ValidateRect(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `3194D3`, PENDING
  - Falsified if: rect is declared as a 32-bit int, so on 64-bit the IntPtr.Zero meaning the whole client area arrives with undefined high bits and user32 reads a RECT through it
- `Broiler.Native.Windows.WindowNative.MoveWindow(IntPtr, int, int, int, int, bool)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `19633F`, PENDING
  - Falsified if: repaint is marshalled as a 1-byte bool rather than a 4-byte BOOL, so user32 reads three stray bytes and a moved render host is repainted or left unpainted against the caller's choice
- `Broiler.Native.Windows.WindowNative.DestroyWindow(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `005B01`, PENDING
  - Falsified if: the import does not set SetLastError, so a DestroyWindow refused for a window owned by another thread reports a stale error code instead of ERROR_ACCESS_DENIED
- `Broiler.Native.Windows.WindowNative.GetParent(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `E7F331`, PENDING
  - Falsified if: the HWND return is declared narrower than a pointer, so on 64-bit the parent handle read back is truncated and the render host resolves another window's GWLP_USERDATA
- `Broiler.Native.Windows.WindowNative.SetTimer(IntPtr, nuint, uint, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `3A2024`, PENDING
  - Falsified if: eventId or the return is declared 32-bit rather than UINT_PTR, so on 64-bit the timer id compared against AnimationTimerId in WM_TIMER never matches and animation ticks fall through to DefWindowProc
- `Broiler.Native.Windows.WindowNative.KillTimer(IntPtr, nuint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `24FCA7`, PENDING
  - Falsified if: eventId is declared 32-bit rather than UINT_PTR, so on 64-bit KillTimer names another timer and the animation timer keeps posting WM_TIMER after it is stopped
- `Broiler.Native.Windows.WindowNative.SetFocus(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `AD9CC7`, PENDING
  - Falsified if: the return is declared as a BOOL rather than the previously focused HWND, so a caller restoring focus passes 1 as a window handle
- `Broiler.Native.Windows.WindowNative.GetKeyState(int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `54C5B0`, PENDING
  - Falsified if: the return is declared wider than SHORT without sign extension, so the down bit of a held VK_CONTROL lands outside the 0x8000 mask callers test and modifiers read as released
- `Broiler.Native.Windows.WindowNative.ScreenToClient(IntPtr, ref POINT)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `D0E8CE`, PENDING
  - Falsified if: point is passed by value rather than by reference, so user32 writes the client coordinates to a copy and wheel events keep their screen coordinates
- `Broiler.Native.Windows.WindowNative.TrackMouseEvent(ref TRACKMOUSEEVENT)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `0C9D2E`, PENDING
  - Falsified if: trackMouseEvent is passed by value rather than by reference, so user32 reads the TRACKMOUSEEVENT from an address formed from its CbSize and flags
- `Broiler.Native.Windows.WindowNative.GetClientRect(IntPtr, out RECT)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `212BE0`, PENDING
  - Falsified if: rect is passed by value rather than as an out pointer, so user32 writes the 16-byte client rectangle through an address formed from the struct's first field
- `Broiler.Native.Windows.WindowNative.GetDpiForWindow(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `81749E`, PENDING
  - Falsified if: the import binds GetDpiForSystem or another export instead of GetDpiForWindow, so a window on a 144-DPI monitor reports the system DPI
- `Broiler.Native.Windows.WindowNative.GetDC(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `58339A`, PENDING
  - Falsified if: the HDC return is declared narrower than a pointer, so on 64-bit GetDeviceCaps and ReleaseDC receive a truncated device-context handle
- `Broiler.Native.Windows.WindowNative.ReleaseDC(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `089DAA`, PENDING
  - Falsified if: hwnd and hdc are passed in swapped order, so user32 releases nothing, returns 0 and the window DC from GetDC leaks
- `Broiler.Native.Windows.WindowNative.GetDeviceCaps(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `A5C5DC`, PENDING
  - Falsified if: index or the return is declared other than a 32-bit int, so LOGPIXELSX reads back a register half and the fallback DPI is not 96 on a 100% display
- `Broiler.Native.Windows.WindowNative.LoadCursor(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `178AF0`, PENDING
  - Falsified if: cursorName is marshalled as a string rather than passed as the MAKEINTRESOURCE integer, so IDC_ARROW (32512) is looked up as a resource name and the class gets no cursor
- `Broiler.Native.Windows.WindowNative.LoadIcon(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `C66880`, PENDING
  - Falsified if: iconName is marshalled as a string rather than passed as the MAKEINTRESOURCE integer, so IDI_APPLICATION is looked up by name, the executable's icon is not found and the class falls back to the generic window glyph
- `Broiler.Native.Windows.WindowNative.GetSysColorBrush(int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `CDE6AD`, PENDING
  - Falsified if: the import binds GetSysColor instead of GetSysColorBrush, so a COLORREF value is stored as WNDCLASSEX.HbrBackground and the class background paints with an invalid brush handle
- `Broiler.Native.Windows.WindowNative.SetWindowLongPtr64(IntPtr, int, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `0ACA59`, PENDING
  - Falsified if: value or the return is declared 32-bit, so on 64-bit the GCHandle pointer stored at GWLP_USERDATA keeps only its low half
- `Broiler.Native.Windows.WindowNative.SetWindowLong32(IntPtr, int, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `B10A49`, PENDING
  - Falsified if: this import is reached on a 64-bit process, so a pointer stored through it keeps only its low 32 bits
- `Broiler.Native.Windows.WindowNative.GetWindowLongPtr64(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `5B314E`, PENDING
  - Falsified if: the return is declared 32-bit, so on 64-bit the GWLP_USERDATA value read back is truncated and GCHandle.FromIntPtr resolves another handle or throws
- `Broiler.Native.Windows.WindowNative.GetWindowLong32(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `EDCE2B`, PENDING
  - Falsified if: this import is reached on a 64-bit process, so GWLP_USERDATA reads back only its low 32 bits
- `Broiler.Native.Windows.WindowNative.GetClassLongPtr64(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `3B4FE6`, PENDING
  - Falsified if: the return is declared 32-bit, so on 64-bit GCLP_HICON reads back a truncated handle that compares unequal to the icon the class registered
- `Broiler.Native.Windows.WindowNative.GetClassLong32(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `3B5E17`, PENDING
  - Falsified if: this import is reached on a 64-bit process, so a GCLP_HICON value is read through GetClassLongW and its high 32 bits are lost
- `Broiler.Native.Windows.WindowNative.SetWindowText(IntPtr, string)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `D43A2E`, PENDING
  - Falsified if: title is marshalled as ANSI or the import binds SetWindowTextA, so a page title outside the ANSI code page shows as question marks in the caption and taskbar
- `Broiler.Native.Windows.WindowNative.SendMessage(IntPtr, uint, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `A75408`, PENDING
  - Falsified if: wParam or lParam is declared 32-bit, so on 64-bit a message whose lParam carries a pointer, such as WM_SETTEXT, makes the window procedure dereference a truncated address
- `Broiler.Native.Windows.WindowNative.ReleaseCapture()` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `4BCCEF`, PENDING
  - Falsified if: the import binds to an export other than user32's ReleaseCapture, so a window that captured the mouse on button-down keeps it and the WM_NCLBUTTONDOWN move or size loop sent next does not start
- `Broiler.Native.Windows.WindowNative.IsIconic(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `A814E8`, PENDING
  - Falsified if: the BOOL return is marshalled as a 1-byte bool, so a nonzero result whose low byte is zero reads as false and a minimised window reports the normal state
- `Broiler.Native.Windows.WindowNative.IsZoomed(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `6E1CF7`, PENDING
  - Falsified if: the BOOL return is marshalled as a 1-byte bool, so a nonzero result whose low byte is zero reads as false and a maximised window keeps its owner-drawn resize border
- `Broiler.Native.Windows.WindowNative.GetWindowRect(IntPtr, out RECT)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `7E4EBC`, PENDING
  - Falsified if: rect is passed by value rather than as an out pointer, so user32 writes the 16-byte screen rectangle through an address formed from the struct's first field
- `Broiler.Native.Windows.WindowNative.MonitorFromWindow(IntPtr, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `E8219B`, PENDING
  - Falsified if: flags is not passed through as a 32-bit DWORD, so MONITOR_DEFAULTTONEAREST reaches user32 as MONITOR_DEFAULTTONULL and a window positioned off every monitor gets a zero HMONITOR that GetMonitorInfo rejects
- `Broiler.Native.Windows.WindowNative.GetMonitorInfo(IntPtr, ref MONITORINFO)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `7EA744`, PENDING
  - Falsified if: a MONITORINFO whose CbSize names the 104-byte MONITORINFOEXW lets user32 write the device name past the end of the 40-byte managed struct
- `Broiler.Native.Windows.WindowNative.DestroyIcon(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `9BE911`, PENDING
  - Falsified if: the BOOL result is read as a 1-byte bool, so a failed DestroyIcon reports success and the caller treats a still-allocated icon handle as freed
- `Broiler.Native.Windows.WindowNative.CreateIconIndirect(ref ICONINFO)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `86BA93`, PENDING
  - Falsified if: iconInfo is passed by value rather than by reference, so CreateIconIndirect reads the ICONINFO from an address formed from its FIcon and hotspot fields
- `Broiler.Native.Windows.WindowNative.CreateDIBSection(IntPtr, ref BITMAPINFOHEADER, uint, out IntPtr, IntPtr, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `9DDFFE`, PENDING
  - Falsified if: a header with BiBitCount of 8 or less, or BI_BITFIELDS compression, makes gdi32 read a colour table or masks past the end of the 40-byte BITMAPINFOHEADER passed by reference
- `Broiler.Native.Windows.WindowNative.CreateBitmap(int, int, uint, uint, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `C60669`, PENDING
  - Falsified if: width and bitsPerPixel reach CreateBitmap(int, int, UINT, UINT, const void*) in swapped positions, so a 32-pixel-wide one-bit mask is read as a one-pixel-wide 32-bit bitmap from a non-null bits pointer
- `Broiler.Native.Windows.WindowNative.DeleteObject(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `C1D6A1`, PENDING
  - Falsified if: the gdiObject argument is declared narrower than a pointer, so on 64-bit DeleteObject receives a truncated handle and the bitmap leaks
- `Broiler.Native.Windows.WindowNative.MONITORINFO` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `85EE60`, PENDING
  - Falsified if: Marshal.SizeOf is not 40 or RcWork precedes RcMonitor, so GetMonitorInfo fills the wrong rectangle and a maximised owner-drawn window is clamped to the whole monitor and covers the taskbar
- `Broiler.Native.Windows.WindowNative.ICONINFO` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `3ED120`, PENDING
  - Falsified if: FIcon, XHotspot and YHotspot are not three 4-byte fields ahead of the two bitmap handles, so on 64-bit CreateIconIndirect reads HbmMask from padding and builds the icon from a garbage bitmap handle
- `Broiler.Native.Windows.WindowNative.BITMAPINFOHEADER` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `C8BD94`, PENDING
  - Falsified if: Marshal.SizeOf is not 40 or BiPlanes and BiBitCount are not 16-bit, so CreateDIBSection reads BiCompression from BiBitCount's bytes and allocates a DIB of another depth whose bits the caller then overruns
- `Broiler.Native.Windows.WindowNative.SetProcessDpiAwarenessContext(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `F83A05`, PENDING
  - Falsified if: the BOOL result is read as a 1-byte bool, so a call refused because the awareness was already set reports success
- `Broiler.Native.Windows.WindowNative.GetWindowText(IntPtr, char*, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `139E0E`, PENDING
  - Falsified if: lpString and maxCount reach GetWindowTextW(HWND, LPWSTR, int) in swapped positions, so the window title is written to the address given by the count
- `Broiler.Native.Windows.WindowNative.GetWindowText(IntPtr, Span<char>)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `E80171`, PENDING
  - Falsified if: the count passed to GetWindowTextW is not text.Length, so a title longer than the span is written past the end of the pinned span
- `Broiler.Native.Windows.WindowNative.GetWindowText(IntPtr, StringBuilder, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `6D9166`, PENDING
  - Falsified if: a maxCount different from the length of the char[] it pins lets GetWindowTextW write past the array's end
- `Broiler.Native.NativeLibraryProbe` in `src/Broiler.Native/NativeLibraryProbe.cs` - Security=High, Spec=none cited, `82A0F5`, PENDING
  - Falsified if: a probe through IsAvailable leaves a library the process had not loaded before still mapped after the call returns, true or false
- `Broiler.Native.NativeLibraryProbe.IsAvailable(string)` in `src/Broiler.Native/NativeLibraryProbe.cs` - Security=High, Spec=none cited, `A7B31A`, PENDING
  - Falsified if: the success path returns true without passing the TryLoad handle to NativeLibrary.Free, so a library the process had not loaded stays mapped

## 10. What This Record Does Not Say

It is not an approval of the component, and a full table above would not be one either. It
records which declarations somebody stated a decision about, and against which version of
each. It does not record what they read, how long they spent, or whether they were right.

A fingerprint is six hex characters of SHA-256 over a declaration's token texts. It answers
whether a unit changed since a decision was recorded against it. It is not a collision-free
identifier across units and it is not a cryptographic commitment, so it detects a change and
does not resist a forger with commit access.

An assessment is a comment, so changing one moves no fingerprint anywhere, and nothing
mechanical checks that it is right; the check holds its values to their vocabularies and no
further.

649 of the 649 assessed units declare `Origin=AI`. Reading a declaration is the only thing
that makes it read.
