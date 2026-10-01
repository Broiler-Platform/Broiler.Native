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
  - Falsified if: an import here differs from its prototype in EGL/egl.h, where EGLDisplay, EGLConfig, EGLSurface and EGLContext are void *, EGLBoolean and EGLenum are unsigned int, and Android's EGL/eglplatform.h makes EGLNativeWindowType struct ANativeWindow * and EGLint khronos_int32_t
- `Broiler.Native.Android.AndroidEglNative.GetDisplay(IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `885D32`, PENDING
  - Falsified if: differs from EGLDisplay eglGetDisplay(EGLNativeDisplayType display_id) in EGL/egl.h, EGLNativeDisplayType being void * on Android in EGL/eglplatform.h
- `Broiler.Native.Android.AndroidEglNative.Initialize(IntPtr, out int, out int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `B5AA7C`, PENDING
  - Falsified if: differs from EGLBoolean eglInitialize(EGLDisplay dpy, EGLint *major, EGLint *minor) in EGL/egl.h
- `Broiler.Native.Android.AndroidEglNative.Terminate(IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `365B80`, PENDING
  - Falsified if: differs from EGLBoolean eglTerminate(EGLDisplay dpy) in EGL/egl.h
- `Broiler.Native.Android.AndroidEglNative.BindApi(int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `D9992F`, PENDING
  - Falsified if: differs from EGLBoolean eglBindAPI(EGLenum api) in EGL/egl.h
- `Broiler.Native.Android.AndroidEglNative.ChooseConfig(IntPtr, int[], IntPtr[], int, out int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, Spec=none cited, `314663`, PENDING
  - Falsified if: configSize exceeds configs.Length, the number of void * EGLConfig slots that EGLBoolean eglChooseConfig(EGLDisplay dpy, const EGLint *attrib_list, EGLConfig *configs, EGLint config_size, EGLint *num_config) in EGL/egl.h may fill
- `Broiler.Native.Android.AndroidEglNative.GetConfigAttrib(IntPtr, IntPtr, int, out int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `D9277A`, PENDING
  - Falsified if: differs from EGLBoolean eglGetConfigAttrib(EGLDisplay dpy, EGLConfig config, EGLint attribute, EGLint *value) in EGL/egl.h
- `Broiler.Native.Android.AndroidEglNative.CreateContext(IntPtr, IntPtr, IntPtr, int[])` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, Spec=none cited, `B24254`, PENDING
  - Falsified if: attribList is not ended by EGL_NONE, the terminator that EGLContext eglCreateContext(EGLDisplay dpy, EGLConfig config, EGLContext share_context, const EGLint *attrib_list) in EGL/egl.h reads up to
- `Broiler.Native.Android.AndroidEglNative.DestroyContext(IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `4D4D42`, PENDING
  - Falsified if: differs from EGLBoolean eglDestroyContext(EGLDisplay dpy, EGLContext ctx) in EGL/egl.h
- `Broiler.Native.Android.AndroidEglNative.CreatePbufferSurface(IntPtr, IntPtr, int[])` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, Spec=none cited, `7ACFAF`, PENDING
  - Falsified if: attribList is not ended by EGL_NONE, the terminator that EGLSurface eglCreatePbufferSurface(EGLDisplay dpy, EGLConfig config, const EGLint *attrib_list) in EGL/egl.h reads up to
- `Broiler.Native.Android.AndroidEglNative.CreateWindowSurface(IntPtr, IntPtr, IntPtr, int[]?)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=Critical, Spec=none cited, `DAD63B`, PENDING
  - Falsified if: a non-null attribList is not ended by EGL_NONE, the terminator that EGLSurface eglCreateWindowSurface(EGLDisplay dpy, EGLConfig config, EGLNativeWindowType win, const EGLint *attrib_list) in EGL/egl.h reads up to
- `Broiler.Native.Android.AndroidEglNative.DestroySurface(IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `A060B1`, PENDING
  - Falsified if: differs from EGLBoolean eglDestroySurface(EGLDisplay dpy, EGLSurface surface) in EGL/egl.h
- `Broiler.Native.Android.AndroidEglNative.MakeCurrent(IntPtr, IntPtr, IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `BA9F32`, PENDING
  - Falsified if: differs from EGLBoolean eglMakeCurrent(EGLDisplay dpy, EGLSurface draw, EGLSurface read, EGLContext ctx) in EGL/egl.h
- `Broiler.Native.Android.AndroidEglNative.SwapBuffers(IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `1968CA`, PENDING
  - Falsified if: differs from EGLBoolean eglSwapBuffers(EGLDisplay dpy, EGLSurface surface) in EGL/egl.h
- `Broiler.Native.Android.AndroidEglNative.SwapInterval(IntPtr, int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `2D465B`, PENDING
  - Falsified if: differs from EGLBoolean eglSwapInterval(EGLDisplay dpy, EGLint interval) in EGL/egl.h
- `Broiler.Native.Android.AndroidEglNative.QuerySurface(IntPtr, IntPtr, int, out int)` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `6B6DBC`, PENDING
  - Falsified if: differs from EGLBoolean eglQuerySurface(EGLDisplay dpy, EGLSurface surface, EGLint attribute, EGLint *value) in EGL/egl.h
- `Broiler.Native.Android.AndroidEglNative.GetError()` in `src/Broiler.Native.Android/AndroidEglNative.cs` - Security=High, Spec=none cited, `B71C87`, PENDING
  - Falsified if: differs from EGLint eglGetError(void) in EGL/egl.h
- `Broiler.Native.Android.AndroidGlesNative` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `1454CE`, PENDING
  - Falsified if: an import here differs from its prototype in GLES3/gl3.h, where GLenum, GLuint and GLbitfield are unsigned int, GLint and GLsizei are int, and GLfloat is khronos_float_t
- `Broiler.Native.Android.AndroidGlesNative.GenTextures(int, out uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `AD9690`, PENDING
  - Falsified if: count is other than 1 although textures is one GLuint, through which void glGenTextures(GLsizei n, GLuint *textures) in GLES3/gl3.h writes n names
- `Broiler.Native.Android.AndroidGlesNative.DeleteTextures(int, ref uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `0A6CA2`, PENDING
  - Falsified if: count is other than 1 although textures is one GLuint, from which void glDeleteTextures(GLsizei n, const GLuint *textures) in GLES3/gl3.h reads n names
- `Broiler.Native.Android.AndroidGlesNative.BindTexture(int, uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `38241C`, PENDING
  - Falsified if: differs from void glBindTexture(GLenum target, GLuint texture) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.TexParameteri(int, int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `A34865`, PENDING
  - Falsified if: differs from void glTexParameteri(GLenum target, GLenum pname, GLint param) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.TexImage2D(int, int, int, int, int, int, int, int, IntPtr)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `A9CDA8`, PENDING
  - Falsified if: a non-null pixels points at fewer bytes than width by height pixels of format and type take with GL_UNPACK_ALIGNMENT row padding, against void glTexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const void *pixels) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.GenFramebuffers(int, out uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `4EFD10`, PENDING
  - Falsified if: count is other than 1 although framebuffers is one GLuint, through which void glGenFramebuffers(GLsizei n, GLuint *framebuffers) in GLES3/gl3.h writes n names
- `Broiler.Native.Android.AndroidGlesNative.DeleteFramebuffers(int, ref uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `9D2CF0`, PENDING
  - Falsified if: count is other than 1 although framebuffers is one GLuint, from which void glDeleteFramebuffers(GLsizei n, const GLuint *framebuffers) in GLES3/gl3.h reads n names
- `Broiler.Native.Android.AndroidGlesNative.BindFramebuffer(int, uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `BC9CAF`, PENDING
  - Falsified if: differs from void glBindFramebuffer(GLenum target, GLuint framebuffer) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.FramebufferTexture2D(int, int, int, uint, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `EC63D1`, PENDING
  - Falsified if: differs from void glFramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.CheckFramebufferStatus(int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `3C9771`, PENDING
  - Falsified if: differs from GLenum glCheckFramebufferStatus(GLenum target) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.Viewport(int, int, int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `71E586`, PENDING
  - Falsified if: differs from void glViewport(GLint x, GLint y, GLsizei width, GLsizei height) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.ClearColor(float, float, float, float)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `D00842`, PENDING
  - Falsified if: differs from void glClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.Clear(int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `10E14B`, PENDING
  - Falsified if: differs from void glClear(GLbitfield mask) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.ReadPixels(int, int, int, int, int, int, IntPtr)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `944115`, PENDING
  - Falsified if: pixels points at fewer bytes than width by height pixels of format and type take with GL_PACK_ALIGNMENT row padding, against void glReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void *pixels) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.BlitFramebuffer(int, int, int, int, int, int, int, int, int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `EFD1E6`, PENDING
  - Falsified if: differs from void glBlitFramebuffer(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.PixelStorei(int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=Critical, Spec=none cited, `8D640E`, PENDING
  - Falsified if: differs from void glPixelStorei(GLenum pname, GLint param) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.Enable(int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `E9E50C`, PENDING
  - Falsified if: differs from void glEnable(GLenum cap) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.Disable(int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `D5E5DF`, PENDING
  - Falsified if: differs from void glDisable(GLenum cap) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.Scissor(int, int, int, int)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `5190C4`, PENDING
  - Falsified if: differs from void glScissor(GLint x, GLint y, GLsizei width, GLsizei height) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.Flush()` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `17C3C7`, PENDING
  - Falsified if: differs from void glFlush(void) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.Finish()` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `539514`, PENDING
  - Falsified if: differs from void glFinish(void) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.GetError()` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `F60C77`, PENDING
  - Falsified if: differs from GLenum glGetError(void) in GLES3/gl3.h
- `Broiler.Native.Android.AndroidGlesNative.GetString(uint)` in `src/Broiler.Native.Android/AndroidGlesNative.cs` - Security=High, Spec=none cited, `D8D88A`, PENDING
  - Falsified if: the result of const GLubyte *glGetString(GLenum name) in GLES3/gl3.h, a string the GL owns, is marshalled as a managed string and freed instead of returned as a pointer
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
  - Falsified if: an import here differs from its prototype in android/native_window.h or android/native_window_jni.h, where the window is ANativeWindow*, env and surface are JNIEnv* and jobject, and widths, heights, formats and results are int32_t
- `Broiler.Native.Android.AndroidNativeWindowNative.FromSurface(IntPtr, IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=Critical, Spec=none cited, `F68393`, PENDING
  - Falsified if: the reference that ANativeWindow* ANativeWindow_fromSurface(JNIEnv* env, jobject surface) in android/native_window_jni.h acquires on the returned window is not dropped by exactly one Release
- `Broiler.Native.Android.AndroidNativeWindowNative.Acquire(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, Spec=none cited, `F2F5A1`, PENDING
  - Falsified if: a reference added by void ANativeWindow_acquire(ANativeWindow* window) in android/native_window.h is not dropped by exactly one Release
- `Broiler.Native.Android.AndroidNativeWindowNative.Release(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, Spec=none cited, `8A97DE`, PENDING
  - Falsified if: Release drops a reference its caller did not take through FromSurface or Acquire, against void ANativeWindow_release(ANativeWindow* window) in android/native_window.h
- `Broiler.Native.Android.AndroidNativeWindowNative.GetWidth(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, Spec=none cited, `914A39`, PENDING
  - Falsified if: differs from int32_t ANativeWindow_getWidth(ANativeWindow* window) in android/native_window.h
- `Broiler.Native.Android.AndroidNativeWindowNative.GetHeight(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, Spec=none cited, `ABB058`, PENDING
  - Falsified if: differs from int32_t ANativeWindow_getHeight(ANativeWindow* window) in android/native_window.h
- `Broiler.Native.Android.AndroidNativeWindowNative.GetFormat(IntPtr)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, Spec=none cited, `16B613`, PENDING
  - Falsified if: differs from int32_t ANativeWindow_getFormat(ANativeWindow* window) in android/native_window.h
- `Broiler.Native.Android.AndroidNativeWindowNative.SetBuffersGeometry(IntPtr, int, int, int)` in `src/Broiler.Native.Android/AndroidNativeWindowNative.cs` - Security=High, Spec=none cited, `5A7772`, PENDING
  - Falsified if: differs from int32_t ANativeWindow_setBuffersGeometry(ANativeWindow* window, int32_t width, int32_t height, int32_t format) in android/native_window.h
- `Broiler.Native.Linux.Input.LinuxNativeMethods` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `C79A53`, PENDING
  - Falsified if: Read differs from ssize_t read(size_t count; int fd, void buf[count], size_t count) in unistd.h as read(2) gives it, or a caller passes a count larger than its buffer
- `Broiler.Native.Linux.Input.LinuxNativeMethods.Open(string, int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=High, Spec=none cited, `B96AC4`, PENDING
  - Falsified if: pathname reaches int open(const char *path, int flags, ...) in fcntl.h, the open(2) prototype, as other than the NUL-terminated UTF-8 bytes of the managed string, for example cut short at an embedded NUL
- `Broiler.Native.Linux.Input.LinuxNativeMethods.Read(int, byte[], nuint)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `B87244`, PENDING
  - Falsified if: differs from ssize_t read(size_t count; int fd, void buf[count], size_t count) in unistd.h as read(2) gives it, or count is larger than the length of buffer
- `Broiler.Native.Linux.Input.LinuxNativeMethods.Poll(PollFd[], nuint, int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `D0C8DE`, PENDING
  - Falsified if: differs from int poll(struct pollfd *fds, nfds_t nfds, int timeout) in poll.h as poll(2) gives it, or nfds is larger than the length of fds
- `Broiler.Native.Linux.Input.LinuxNativeMethods.IoctlClockId(int, nuint, ref int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=High, Spec=none cited, `E09054`, PENDING
  - Falsified if: differs from int ioctl(int fd, unsigned long op, ...) in sys/ioctl.h as ioctl(2) gives it for glibc, or the third argument is not a pointer to the int that EVIOCSCLOCKID, _IOW('E', 0xa0, int) in linux/input.h, reads
- `Broiler.Native.Linux.Input.LinuxNativeMethods.IoctlAbsInfo(int, nuint, byte[])` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `7FA6C0`, PENDING
  - Falsified if: differs from int ioctl(int fd, unsigned long op, ...) in sys/ioctl.h as ioctl(2) gives it for glibc, or absInfo is shorter than the 24-byte struct input_absinfo of six __s32 fields that EVIOCGABS(abs), _IOR('E', 0x40 + (abs), struct input_absinfo) in linux/input.h, writes through the third argument
- `Broiler.Native.Linux.Input.LinuxNativeMethods.TrySetMonotonicClock(int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=High, Spec=none cited, `3DDB0B`, PENDING
  - Falsified if: an EVIOCSCLOCKID ioctl that fails with -1 makes the method return true, so callers treat CLOCK_REALTIME event timestamps as monotonic
- `Broiler.Native.Linux.Input.LinuxNativeMethods.TryGetAbsInfo(int, ushort, out int, out int, out int)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `77BE13`, PENDING
  - Falsified if: the buffer allocated here is shorter than the 24-byte size EviocgAbs encodes in the request, so the kernel copy of struct input_absinfo runs past the end of the array
- `Broiler.Native.Linux.Input.LinuxNativeMethods.EviocgAbs(ushort)` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `817AD7`, PENDING
  - Falsified if: an abs argument above ABS_MAX (0x3f) is encoded without rejection, and 0xC6 yields 0x80184506, which is EVIOCGNAME(24) rather than an EVIOCGABS request
- `Broiler.Native.Linux.Input.LinuxNativeMethods.PollFd` in `src/Broiler.Native.Linux/Input/LinuxNativeMethods.cs` - Security=Critical, Spec=none cited, `D2661F`, PENDING
  - Falsified if: Marshal.SizeOf of PollFd is not 8, or Marshal.OffsetOf puts Events and Revents anywhere but 4 and 6, against struct pollfd { int fd; short events; short revents; } in asm-generic/poll.h
- `Broiler.Native.Linux.OpenGL.LinuxEglNative` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, Spec=none cited, `9489E2`, PENDING
  - Falsified if: ChooseConfig differs from EGLBoolean eglChooseConfig(EGLDisplay dpy, const EGLint *attrib_list, EGLConfig *configs, EGLint config_size, EGLint *num_config) in EGL/egl.h
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.GetDisplay(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `BD56B4`, PENDING
  - Falsified if: differs from EGLDisplay eglGetDisplay(EGLNativeDisplayType display_id) in EGL/egl.h
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.Initialize(IntPtr, out int, out int)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `89B711`, PENDING
  - Falsified if: differs from EGLBoolean eglInitialize(EGLDisplay dpy, EGLint *major, EGLint *minor) in EGL/egl.h
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.Terminate(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `C32377`, PENDING
  - Falsified if: differs from EGLBoolean eglTerminate(EGLDisplay dpy) in EGL/egl.h
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.BindApi(int)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `7F31B4`, PENDING
  - Falsified if: differs from EGLBoolean eglBindAPI(EGLenum api) in EGL/egl.h
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.ChooseConfig(IntPtr, int[], IntPtr[], int, out int)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, Spec=none cited, `7A0D75`, PENDING
  - Falsified if: differs from EGLBoolean eglChooseConfig(EGLDisplay dpy, const EGLint *attrib_list, EGLConfig *configs, EGLint config_size, EGLint *num_config) in EGL/egl.h, or configSize is larger than the length of configs
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.CreateContext(IntPtr, IntPtr, IntPtr, int[])` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, Spec=none cited, `9110AD`, PENDING
  - Falsified if: differs from EGLContext eglCreateContext(EGLDisplay dpy, EGLConfig config, EGLContext share_context, const EGLint *attrib_list) in EGL/egl.h, or attribList does not end in EGL_NONE
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.DestroyContext(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `CEE9B9`, PENDING
  - Falsified if: differs from EGLBoolean eglDestroyContext(EGLDisplay dpy, EGLContext ctx) in EGL/egl.h
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.CreatePbufferSurface(IntPtr, IntPtr, int[])` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, Spec=none cited, `E5C06E`, PENDING
  - Falsified if: differs from EGLSurface eglCreatePbufferSurface(EGLDisplay dpy, EGLConfig config, const EGLint *attrib_list) in EGL/egl.h, or attribList does not end in EGL_NONE
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.CreateWindowSurface(IntPtr, IntPtr, IntPtr, int[])` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=Critical, Spec=none cited, `26BB95`, PENDING
  - Falsified if: differs from EGLSurface eglCreateWindowSurface(EGLDisplay dpy, EGLConfig config, EGLNativeWindowType win, const EGLint *attrib_list) in EGL/egl.h, or attribList does not end in EGL_NONE
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.DestroySurface(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `645A11`, PENDING
  - Falsified if: differs from EGLBoolean eglDestroySurface(EGLDisplay dpy, EGLSurface surface) in EGL/egl.h
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.MakeCurrent(IntPtr, IntPtr, IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `B3981D`, PENDING
  - Falsified if: differs from EGLBoolean eglMakeCurrent(EGLDisplay dpy, EGLSurface draw, EGLSurface read, EGLContext ctx) in EGL/egl.h
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.SwapBuffers(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `BE06C5`, PENDING
  - Falsified if: differs from EGLBoolean eglSwapBuffers(EGLDisplay dpy, EGLSurface surface) in EGL/egl.h
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.GetError()` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `7C4EE1`, PENDING
  - Falsified if: differs from EGLint eglGetError(void) in EGL/egl.h
- `Broiler.Native.Linux.OpenGL.LinuxEglNative.GetProcAddress(string)` in `src/Broiler.Native.Linux/OpenGL/LinuxEglNative.cs` - Security=High, Spec=none cited, `774421`, PENDING
  - Falsified if: differs from __eglMustCastToProperFunctionPointerType eglGetProcAddress(const char *procname) in EGL/egl.h, or procName reaches it as other than a NUL-terminated 8-bit string
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `B1E919`, PENDING
  - Falsified if: GlReadPixelsProc differs from void glReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void *pixels) in GL/glcorearb.h
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
  - Falsified if: differs from void glGenTextures(GLsizei n, GLuint *textures) in GL/glcorearb.h, or n is greater than the 1 GLuint its out parameter holds
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlDeleteTexturesProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `987158`, PENDING
  - Falsified if: differs from void glDeleteTextures(GLsizei n, const GLuint *textures) in GL/glcorearb.h, or n is greater than the 1 GLuint its ref parameter holds
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlBindTextureProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `86B3EB`, PENDING
  - Falsified if: differs from void glBindTexture(GLenum target, GLuint texture) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlTexParameteriProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `72149D`, PENDING
  - Falsified if: differs from void glTexParameteri(GLenum target, GLenum pname, GLint param) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlTexImage2DProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `53B054`, PENDING
  - Falsified if: differs from void glTexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const void *pixels) in GL/glcorearb.h, or pixels points to fewer bytes than width, height, format, type and GL_UNPACK_ALIGNMENT describe
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlGenFramebuffersProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `918023`, PENDING
  - Falsified if: differs from void glGenFramebuffers(GLsizei n, GLuint *framebuffers) in GL/glcorearb.h, or n is greater than the 1 GLuint its out parameter holds
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlDeleteFramebuffersProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `74B8E4`, PENDING
  - Falsified if: differs from void glDeleteFramebuffers(GLsizei n, const GLuint *framebuffers) in GL/glcorearb.h, or n is greater than the 1 GLuint its ref parameter holds
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlBindFramebufferProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `E22C59`, PENDING
  - Falsified if: differs from void glBindFramebuffer(GLenum target, GLuint framebuffer) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlFramebufferTexture2DProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `89CAEA`, PENDING
  - Falsified if: differs from void glFramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlCheckFramebufferStatusProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `7B20CF`, PENDING
  - Falsified if: differs from GLenum glCheckFramebufferStatus(GLenum target) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlViewportProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `45AE3A`, PENDING
  - Falsified if: differs from void glViewport(GLint x, GLint y, GLsizei width, GLsizei height) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlClearColorProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `181780`, PENDING
  - Falsified if: differs from void glClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlClearProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `ED39A6`, PENDING
  - Falsified if: differs from void glClear(GLbitfield mask) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlReadPixelsProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `4D8968`, PENDING
  - Falsified if: differs from void glReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void *pixels) in GL/glcorearb.h, or pixels points to fewer bytes than width, height, format, type and GL_PACK_ALIGNMENT describe
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlBlitFramebufferProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `2FE5E1`, PENDING
  - Falsified if: differs from void glBlitFramebuffer(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlPixelStoreiProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=Critical, Spec=none cited, `C7EF03`, PENDING
  - Falsified if: differs from void glPixelStorei(GLenum pname, GLint param) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlEnableProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `DE694A`, PENDING
  - Falsified if: differs from void glEnable(GLenum cap) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlDisableProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `524E32`, PENDING
  - Falsified if: differs from void glDisable(GLenum cap) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlScissorProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `EB992B`, PENDING
  - Falsified if: differs from void glScissor(GLint x, GLint y, GLsizei width, GLsizei height) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlFlushProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `89AA1E`, PENDING
  - Falsified if: differs from void glFlush(void) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlGetErrorProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `8ACE41`, PENDING
  - Falsified if: differs from GLenum glGetError(void) in GL/glcorearb.h
- `Broiler.Native.Linux.OpenGL.LinuxOpenGlFunctions.GlGetStringProc` in `src/Broiler.Native.Linux/OpenGL/LinuxOpenGlFunctions.cs` - Security=High, Spec=none cited, `C7F9A4`, PENDING
  - Falsified if: differs from const GLubyte *glGetString(GLenum name) in GL/glcorearb.h, or its return is marshalled as a string, which frees memory the GL implementation owns
- `Broiler.Native.Linux.OpenGL.LinuxX11Native` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=Critical, Spec=none cited, `96F4E9`, PENDING
  - Falsified if: an import here differs from its prototype in X11/Xlib.h, where the connection is Display*, Window, Atom and Time are unsigned long in X11/X.h, and Bool and Status are int
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.OpenDisplay(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=Critical, Spec=none cited, `929967`, PENDING
  - Falsified if: differs from Display *XOpenDisplay(_Xconst char *display_name) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.CloseDisplay(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `876CC0`, PENDING
  - Falsified if: differs from int XCloseDisplay(Display *display) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.DefaultScreen(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `84D7AA`, PENDING
  - Falsified if: differs from int XDefaultScreen(Display *display) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.RootWindow(IntPtr, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `0B2C4A`, PENDING
  - Falsified if: differs from Window XRootWindow(Display *display, int screen_number) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.BlackPixel(IntPtr, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `224BE2`, PENDING
  - Falsified if: differs from unsigned long XBlackPixel(Display *display, int screen_number) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.WhitePixel(IntPtr, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `48663B`, PENDING
  - Falsified if: differs from unsigned long XWhitePixel(Display *display, int screen_number) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.CreateSimpleWindow(IntPtr, IntPtr, int, int, uint, uint, uint, IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `464005`, PENDING
  - Falsified if: differs from Window XCreateSimpleWindow(Display *display, Window parent, int x, int y, unsigned int width, unsigned int height, unsigned int border_width, unsigned long border, unsigned long background) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.StoreName(IntPtr, IntPtr, string)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `EEE573`, PENDING
  - Falsified if: windowName is not marshalled as a NUL-terminated 8-bit string, the _Xconst char *window_name of int XStoreName(Display *display, Window w, _Xconst char *window_name) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.SelectInput(IntPtr, IntPtr, long)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `46FCB1`, PENDING
  - Falsified if: differs from int XSelectInput(Display *display, Window w, long event_mask) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.MapWindow(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `8B669F`, PENDING
  - Falsified if: differs from int XMapWindow(Display *display, Window w) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.ResizeWindow(IntPtr, IntPtr, uint, uint)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `98C0F3`, PENDING
  - Falsified if: differs from int XResizeWindow(Display *display, Window w, unsigned int width, unsigned int height) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.DestroyWindow(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `79BA88`, PENDING
  - Falsified if: differs from int XDestroyWindow(Display *display, Window w) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.Flush(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `F8DD82`, PENDING
  - Falsified if: differs from int XFlush(Display *display) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.Pending(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `B97E6E`, PENDING
  - Falsified if: differs from int XPending(Display *display) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.NextEvent(IntPtr, out XEvent)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `70D77F`, PENDING
  - Falsified if: the out XEvent is smaller than 192 bytes on 64-bit, the size of union _XEvent with its long pad[24], into which int XNextEvent(Display *display, XEvent *event_return) in X11/Xlib.h writes
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.InternAtom(IntPtr, string, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `C1DAEF`, PENDING
  - Falsified if: atomName is not marshalled as a NUL-terminated 8-bit string, or onlyIfExists not as the int that Bool is, against Atom XInternAtom(Display *display, _Xconst char *atom_name, Bool only_if_exists) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.ChangeProperty(IntPtr, IntPtr, IntPtr, IntPtr, int, int, byte[], int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=Critical, Spec=none cited, `618340`, PENDING
  - Falsified if: elementCount counts more items than data holds at the given format, one byte each at format 8, against int XChangeProperty(Display *display, Window w, Atom property, Atom type, int format, int mode, _Xconst unsigned char *data, int nelements) in X11/Xlib.h, which reads nelements items from data
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.SetWmProtocols(IntPtr, IntPtr, IntPtr[], int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=Critical, Spec=none cited, `D252C5`, PENDING
  - Falsified if: count is larger than protocols.Length, the IntPtr-sized slots from which Status XSetWMProtocols(Display *display, Window w, Atom *protocols, int count) in X11/Xlib.h reads count Atoms, Atom being unsigned long in X11/X.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.SetInputFocus(IntPtr, IntPtr, int, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `54C7BF`, PENDING
  - Falsified if: differs from int XSetInputFocus(Display *display, Window focus, int revert_to, Time time) in X11/Xlib.h, where Time is unsigned long in X11/X.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.QueryPointer(IntPtr, IntPtr, out IntPtr, out IntPtr, out int, out int, out int, out int, out uint)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `C89EB0`, PENDING
  - Falsified if: differs from Bool XQueryPointer(Display *display, Window w, Window *root_return, Window *child_return, int *root_x_return, int *root_y_return, int *win_x_return, int *win_y_return, unsigned int *mask_return) in X11/Xlib.h, where Bool is int
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.Sync(IntPtr, int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `B4629B`, PENDING
  - Falsified if: differs from int XSync(Display *display, Bool discard) in X11/Xlib.h, where Bool is int
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.GetInputFocus(IntPtr, out IntPtr, out int)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `1B3468`, PENDING
  - Falsified if: differs from int XGetInputFocus(Display *display, Window *focus_return, int *revert_to_return) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.SetErrorHandler(IntPtr)` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `36F83B`, PENDING
  - Falsified if: handler is not a function of the XErrorHandler type int (*)(Display *display, XErrorEvent *error_event) that stays callable while installed, against XErrorHandler XSetErrorHandler(XErrorHandler handler) in X11/Xlib.h
- `Broiler.Native.Linux.OpenGL.LinuxX11Native.XEvent` in `src/Broiler.Native.Linux/OpenGL/LinuxX11Native.cs` - Security=High, Spec=none cited, `803926`, PENDING
  - Falsified if: Marshal.SizeOf is not 192 on 64-bit, the size of union _XEvent with its long pad[24] in X11/Xlib.h, or ConfigureWidth, ConfigureHeight and ClientMessageData0 are not at offsets 56, 60 and 56, where XConfigureEvent puts width and height and XClientMessageEvent puts data.l[0]
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `E46435`, PENDING
  - Falsified if: an import here differs from its prototype in vulkan/vulkan_core.h, where VkInstance, VkPhysicalDevice, VkDevice and VkQueue are pointer handles, VkResult is an enum, and counts, versions and indices are uint32_t
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetSupportedInstanceVersion()` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, Spec=none cited, `06A932`, PENDING
  - Falsified if: a Vulkan 1.0 loader that does not export vkEnumerateInstanceVersion makes the method throw instead of returning version 1.0.0
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.ThrowIfFailed(int, string)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, Spec=none cited, `1B627A`, PENDING
  - Falsified if: a negative VkResult such as VK_ERROR_INITIALIZATION_FAILED (-3) returns without throwing, so the caller goes on to use the out handle of a failed call
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetPhysicalDeviceInfo(IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `1AD6E2`, PENDING
  - Falsified if: the 256-byte deviceName copy starts at an offset other than 20 of VkPhysicalDeviceProperties, so the reported name includes deviceType bytes or runs into pipelineCacheUUID
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.EnumerateInstanceVersion(out uint)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, Spec=none cited, `205D93`, PENDING
  - Falsified if: differs from VkResult vkEnumerateInstanceVersion(uint32_t* pApiVersion) in vulkan/vulkan_core.h
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.CreateInstance(ref VkInstanceCreateInfo, IntPtr, out IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `5CE6EF`, PENDING
  - Falsified if: differs from VkResult vkCreateInstance(const VkInstanceCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkInstance* pInstance) in vulkan/vulkan_core.h, or the VkInstanceCreateInfo passed by ref is not the 64 bytes that header lays out on 64-bit
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.DestroyInstance(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `98A399`, PENDING
  - Falsified if: differs from void vkDestroyInstance(VkInstance instance, const VkAllocationCallbacks* pAllocator) in vulkan/vulkan_core.h
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.EnumeratePhysicalDevices(IntPtr, ref uint, IntPtr[]?)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `0003C3`, PENDING
  - Falsified if: physicalDeviceCount is larger than physicalDevices.Length on entry to VkResult vkEnumeratePhysicalDevices(VkInstance instance, uint32_t* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices) in vulkan/vulkan_core.h, which writes up to that many pointer-sized handles
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetPhysicalDeviceQueueFamilyProperties(IntPtr, ref uint, VkQueueFamilyProperties[]?)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `8B21E9`, PENDING
  - Falsified if: queueFamilyPropertyCount is larger than queueFamilyProperties.Length on entry to void vkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint32_t* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties) in vulkan/vulkan_core.h, which writes up to that many 24-byte entries
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetPhysicalDeviceProperties(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `89BCFE`, PENDING
  - Falsified if: the buffer passed as properties is smaller than 824 bytes, the 64-bit size of the VkPhysicalDeviceProperties that void vkGetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties) in vulkan/vulkan_core.h writes
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.CreateDevice(IntPtr, ref VkDeviceCreateInfo, IntPtr, out IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `59040F`, PENDING
  - Falsified if: differs from VkResult vkCreateDevice(VkPhysicalDevice physicalDevice, const VkDeviceCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkDevice* pDevice) in vulkan/vulkan_core.h, or the VkDeviceCreateInfo passed by ref is not the 72 bytes that header lays out on 64-bit
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.DestroyDevice(IntPtr, IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `19195C`, PENDING
  - Falsified if: differs from void vkDestroyDevice(VkDevice device, const VkAllocationCallbacks* pAllocator) in vulkan/vulkan_core.h
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.GetDeviceQueue(IntPtr, uint, uint, out IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, Spec=none cited, `933A0D`, PENDING
  - Falsified if: differs from void vkGetDeviceQueue(VkDevice device, uint32_t queueFamilyIndex, uint32_t queueIndex, VkQueue* pQueue) in vulkan/vulkan_core.h
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.DeviceWaitIdle(IntPtr)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=High, Spec=none cited, `3C80E2`, PENDING
  - Falsified if: differs from VkResult vkDeviceWaitIdle(VkDevice device) in vulkan/vulkan_core.h
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkApplicationInfo` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `2B62F4`, PENDING
  - Falsified if: Marshal.SizeOf is not 48 on 64-bit, the size of VkApplicationInfo in vulkan/vulkan_core.h, or ApiVersion is not at offset 44
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkInstanceCreateInfo` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `D473E7`, PENDING
  - Falsified if: Marshal.SizeOf is not 64 on 64-bit, the size of VkInstanceCreateInfo in vulkan/vulkan_core.h, or PpEnabledExtensionNames is not at offset 56
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkDeviceQueueCreateInfo` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `3020AD`, PENDING
  - Falsified if: Marshal.SizeOf is not 40 on 64-bit, the size of VkDeviceQueueCreateInfo in vulkan/vulkan_core.h, or PQueuePriorities is not at offset 32
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkDeviceCreateInfo` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `CADF59`, PENDING
  - Falsified if: Marshal.SizeOf is not 72 on 64-bit, the size of VkDeviceCreateInfo in vulkan/vulkan_core.h, or PEnabledFeatures is not at offset 64
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkQueueFamilyProperties` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `243E73`, PENDING
  - Falsified if: Marshal.SizeOf is not 24, the size of VkQueueFamilyProperties in vulkan/vulkan_core.h, or MinImageTransferGranularity is not at offset 12
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.VkExtent3D` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `BD2FAE`, PENDING
  - Falsified if: Marshal.SizeOf is not 12, the size of VkExtent3D in vulkan/vulkan_core.h with its uint32_t width, height and depth
- `Broiler.Native.Linux.Vulkan.LinuxVulkanNative.ReadUInt32(IntPtr, int)` in `src/Broiler.Native.Linux/Vulkan/LinuxVulkanNative.cs` - Security=Critical, Spec=none cited, `B56DE7`, PENDING
  - Falsified if: the value is read at the buffer plus offset times four rather than plus offset, so vendorId at offset 8 is taken from byte 32
- `Broiler.Native.Windows.IStream` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `72C7E0`, PENDING
  - Falsified if: the member order differs from ISequentialStream then IStream in objidlbase.h, whose vtable runs from Read at slot 3 to Clone at slot 13 after the three IUnknown slots
- `Broiler.Native.Windows.IStream.Read(IntPtr, uint, out uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `EBC476`, PENDING
  - Falsified if: is not slot 3 of IStream, HRESULT Read(void *pv, ULONG cb, ULONG *pcbRead) of ISequentialStream in objidlbase.h, which writes up to cb bytes at pv
- `Broiler.Native.Windows.IStream.Write(IntPtr, uint, out uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `2AC1C9`, PENDING
  - Falsified if: is not slot 4 of IStream, HRESULT Write(const void *pv, ULONG cb, ULONG *pcbWritten) of ISequentialStream in objidlbase.h, which reads cb bytes at pv
- `Broiler.Native.Windows.IStream.Seek(long, uint, out ulong)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `2AF8C4`, PENDING
  - Falsified if: is not slot 5 of IStream, HRESULT Seek(LARGE_INTEGER dlibMove, DWORD dwOrigin, ULARGE_INTEGER *plibNewPosition) in objidlbase.h
- `Broiler.Native.Windows.IStream.SetSize(ulong)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `107363`, PENDING
  - Falsified if: is not slot 6 of IStream, HRESULT SetSize(ULARGE_INTEGER libNewSize) in objidlbase.h
- `Broiler.Native.Windows.IStream.CopyTo(IStream, ulong, out ulong, out ulong)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `8B6736`, PENDING
  - Falsified if: is not slot 7 of IStream, HRESULT CopyTo(IStream *pstm, ULARGE_INTEGER cb, ULARGE_INTEGER *pcbRead, ULARGE_INTEGER *pcbWritten) in objidlbase.h
- `Broiler.Native.Windows.IStream.Commit(uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `6A4557`, PENDING
  - Falsified if: is not slot 8 of IStream, HRESULT Commit(DWORD grfCommitFlags) in objidlbase.h
- `Broiler.Native.Windows.IStream.Revert()` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `94840D`, PENDING
  - Falsified if: is not slot 9 of IStream, HRESULT Revert(void) in objidlbase.h
- `Broiler.Native.Windows.IStream.LockRegion(ulong, ulong, uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `DD2680`, PENDING
  - Falsified if: is not slot 10 of IStream, HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, DWORD dwLockType) in objidlbase.h
- `Broiler.Native.Windows.IStream.UnlockRegion(ulong, ulong, uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `0DB8D7`, PENDING
  - Falsified if: is not slot 11 of IStream, HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, DWORD dwLockType) in objidlbase.h
- `Broiler.Native.Windows.IStream.Stat(IntPtr, uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `D1A188`, PENDING
  - Falsified if: is not slot 12 of IStream, HRESULT Stat(STATSTG *pstatstg, DWORD grfStatFlag) in objidlbase.h, or pstatstg addresses fewer than the 80 bytes a STATSTG takes on 64-bit
- `Broiler.Native.Windows.IStream.Clone(out IStream)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `C91B52`, PENDING
  - Falsified if: is not slot 13 of IStream, HRESULT Clone(IStream **ppstm) in objidlbase.h, or the reference written to *ppstm is still held after the returned wrapper is released
- `Broiler.Native.Windows.ComNative` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `E10EF6`, PENDING
  - Falsified if: ReleaseIUnknown lowers a non-null pointer's reference count by other than exactly one, or CoTaskMemFree binds an export other than ole32's, so an object or block another holder still uses is freed
- `Broiler.Native.Windows.ComNative.s_comWrappers` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `2EB7A1`, PENDING
  - Falsified if: a pointer wrapped through this instance cannot be cast to a [GeneratedComInterface] interface the native object implements, showing the instance lacks the source-generated interface strategy
- `Broiler.Native.Windows.ComNative.CoInitializeEx(IntPtr, uint)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `29F17C`, PENDING
  - Falsified if: differs from HRESULT CoInitializeEx(LPVOID pvReserved, DWORD dwCoInit) in combaseapi.h
- `Broiler.Native.Windows.ComNative.CoUninitialize()` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `1CDFE8`, PENDING
  - Falsified if: differs from void CoUninitialize(void) in combaseapi.h
- `Broiler.Native.Windows.ComNative.CoTaskMemFree(IntPtr)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `396F43`, PENDING
  - Falsified if: differs from void CoTaskMemFree(LPVOID pv) in combaseapi.h
- `Broiler.Native.Windows.ComNative.CoCreateInstance(in Guid, IntPtr, uint, in Guid, out IntPtr)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `F9E5E6`, PENDING
  - Falsified if: differs from HRESULT CoCreateInstance(REFCLSID rclsid, LPUNKNOWN pUnkOuter, DWORD dwClsContext, REFIID riid, LPVOID *ppv) in combaseapi.h
- `Broiler.Native.Windows.ComNative.CoCreateInstance(ref Guid, IntPtr, uint, ref Guid, out object?)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `4C1BCE`, PENDING
  - Falsified if: differs from HRESULT CoCreateInstance(REFCLSID rclsid, LPUNKNOWN pUnkOuter, DWORD dwClsContext, REFIID riid, LPVOID *ppv) in combaseapi.h, or the reference written to *ppv is still held after ComNative.ReleaseComObject releases the returned runtime-callable wrapper
- `Broiler.Native.Windows.ComNative.CoCreateInstance(in Guid, IntPtr, uint, in Guid, out WicNative.IWICImagingFactory)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `DE546D`, PENDING
  - Falsified if: differs from HRESULT CoCreateInstance(REFCLSID rclsid, LPUNKNOWN pUnkOuter, DWORD dwClsContext, REFIID riid, LPVOID *ppv) in combaseapi.h, or the reference written to *ppv is still held once the returned IWICImagingFactory wrapper has been collected
- `Broiler.Native.Windows.ComNative.CreateStreamOnHGlobal(IntPtr, bool, out IStream)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `B90342`, PENDING
  - Falsified if: fDeleteOnRelease is not marshalled as the 4-byte BOOL of HRESULT CreateStreamOnHGlobal(HGLOBAL hGlobal, BOOL fDeleteOnRelease, LPSTREAM *ppstm) in combaseapi.h
- `Broiler.Native.Windows.ComNative.GetOrCreateComObject<TInterface>(IntPtr)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `92D005`, PENDING
  - Falsified if: after the caller releases its own reference to comPointer the returned wrapper points at a destroyed object, showing the wrapper took no native reference of its own
- `Broiler.Native.Windows.ComNative.ReleaseIUnknown(IntPtr)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=Critical, Spec=none cited, `455A91`, PENDING
  - Falsified if: one call on a non-null pointer lowers its native reference count by other than exactly one
- `Broiler.Native.Windows.ComNative.ReleaseComObject(object?)` in `src/Broiler.Native.Windows/ComNative.cs` - Security=High, Spec=none cited, `EFB4EB`, PENDING
  - Falsified if: a source-generated ComObject (from a [GeneratedComInterface] out parameter or GetOrCreateComObject) is neither IsComObject nor IDisposable, so the call returns with its native reference still held until finalization
- `Broiler.Native.Windows.Direct2D.ComPtr` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=Critical, Spec=none cited, `2776DD`, PENDING
  - Falsified if: a second Dispose or Release on the same ComPtr calls IUnknown::Release (slot 2) again for the one owned reference, dropping the native count below the references held
- `Broiler.Native.Windows.Direct2D.ComPtr.QueryInterfaceProc` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=High, Spec=none cited, `0E802B`, PENDING
  - Falsified if: differs from HRESULT (STDMETHODCALLTYPE *QueryInterface)(IUnknown *This, REFIID riid, void **ppvObject), slot 0 of IUnknownVtbl in unknwnbase.h
- `Broiler.Native.Windows.Direct2D.ComPtr.AddRefProc` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=High, Spec=none cited, `BE262F`, PENDING
  - Falsified if: differs from ULONG (STDMETHODCALLTYPE *AddRef)(IUnknown *This), slot 1 of IUnknownVtbl in unknwnbase.h
- `Broiler.Native.Windows.Direct2D.ComPtr.ReleaseProc` in `src/Broiler.Native.Windows/Direct2D/ComPtr.cs` - Security=High, Spec=none cited, `CAFAC2`, PENDING
  - Falsified if: differs from ULONG (STDMETHODCALLTYPE *Release)(IUnknown *This), slot 2 of IUnknownVtbl in unknwnbase.h
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
  - Falsified if: Marshal.SizeOf is not 8 or Height is not at offset 4, the layout of D2D_SIZE_U { UINT32 width; UINT32 height; } in dcommon.h that d2d1.h names D2D1_SIZE_U
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_MAPPED_RECT` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, Spec=none cited, `A8FA51`, PENDING
  - Falsified if: Marshal.SizeOf is not 16 on 64-bit or Bits is not at offset 8, the layout of D2D1_MAPPED_RECT { UINT32 pitch; BYTE *bits; } in d2d1_1.h
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_PIXEL_FORMAT` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, Spec=none cited, `89F880`, PENDING
  - Falsified if: Marshal.SizeOf is not 8 or AlphaMode is not at offset 4, the layout of D2D1_PIXEL_FORMAT { DXGI_FORMAT format; D2D1_ALPHA_MODE alphaMode; } in dcommon.h
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_BITMAP_PROPERTIES` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, Spec=none cited, `D33E87`, PENDING
  - Falsified if: Marshal.SizeOf is not 16 or DpiX is not at offset 8, the layout of D2D1_BITMAP_PROPERTIES { D2D1_PIXEL_FORMAT pixelFormat; FLOAT dpiX; FLOAT dpiY; } in d2d1.h
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_BITMAP_PROPERTIES1` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, Spec=none cited, `651843`, PENDING
  - Falsified if: Marshal.SizeOf is not 32 on 64-bit or ColorContext is not at offset 24, the layout of D2D1_BITMAP_PROPERTIES1 { D2D1_PIXEL_FORMAT pixelFormat; FLOAT dpiX; FLOAT dpiY; D2D1_BITMAP_OPTIONS bitmapOptions; ID2D1ColorContext *colorContext; } in d2d1_1.h
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_COLOR_F` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, Spec=none cited, `20006A`, PENDING
  - Falsified if: Marshal.SizeOf is not 16 or R, G, B and A are not at offsets 0, 4, 8 and 12, the layout of D3DCOLORVALUE { float r; float g; float b; float a; } in dxgitype.h that d2dbasetypes.h names D2D_COLOR_F
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_POINT_2F` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=Critical, Spec=none cited, `FDCA31`, PENDING
  - Falsified if: Marshal.SizeOf is not 8 or Y is not at offset 4, the layout of D2D_POINT_2F { FLOAT x; FLOAT y; } in dcommon.h that d2d1.h names D2D1_POINT_2F
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_RECT_F` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, Spec=none cited, `5A4C8B`, PENDING
  - Falsified if: Marshal.SizeOf is not 16 or Left, Top, Right and Bottom are not at offsets 0, 4, 8 and 12, the layout of D2D_RECT_F { FLOAT left; FLOAT top; FLOAT right; FLOAT bottom; } in dcommon.h
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_ROUNDED_RECT` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, Spec=none cited, `B27539`, PENDING
  - Falsified if: Marshal.SizeOf is not 24 or RadiusX is not at offset 16, the layout of D2D1_ROUNDED_RECT { D2D1_RECT_F rect; FLOAT radiusX; FLOAT radiusY; } in d2d1.h
- `Broiler.Native.Windows.Direct2D.D2DNative.D2D1_MATRIX_3X2_F` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, Spec=none cited, `440448`, PENDING
  - Falsified if: Marshal.SizeOf is not 24 or M11, M12, M21, M22, Dx and Dy are not at offsets 0 to 20 in steps of 4, the m11, m12, m21, m22, dx, dy order of D2D_MATRIX_3X2_F in dcommon.h
- `Broiler.Native.Windows.Direct2D.D2DNative.CreateDeviceContextProc` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, Spec=none cited, `F3DA9B`, PENDING
  - Falsified if: differs from slot 4 of ID2D1Device, HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext **deviceContext) in d2d1_1.h, with this as the explicit first argument
- `Broiler.Native.Windows.Direct2D.D2DNative.SetTargetProc` in `src/Broiler.Native.Windows/Direct2D/D2DNative.cs` - Security=High, Spec=none cited, `307319`, PENDING
  - Falsified if: differs from slot 74 of ID2D1DeviceContext, void SetTarget(ID2D1Image *image) in d2d1_1.h, with this as the explicit first argument
- `Broiler.Native.Windows.Direct2D.DWriteNative` in `src/Broiler.Native.Windows/Direct2D/DWriteNative.cs` - Security=High, Spec=none cited, `564421`, PENDING
  - Falsified if: a structure here is not laid out as in dwrite.h, for example DWRITE_TEXT_METRICS not being the 36 bytes IDWriteTextLayout::GetMetrics writes, so the measured sizes and LineCount are read from the wrong bytes
- `Broiler.Native.Windows.Direct2D.DWriteNative.DWRITE_TEXT_METRICS` in `src/Broiler.Native.Windows/Direct2D/DWriteNative.cs` - Security=High, Spec=none cited, `71E01C`, PENDING
  - Falsified if: Marshal.SizeOf is not 36 or LineCount is not at offset 32, the layout of DWRITE_TEXT_METRICS in dwrite.h, seven FLOATs from left to layoutHeight then UINT32 maxBidiReorderingDepth and UINT32 lineCount
- `Broiler.Native.Windows.Direct2D.DWriteNative.CreateTextFormatProc` in `src/Broiler.Native.Windows/Direct2D/DWriteNative.cs` - Security=High, Spec=none cited, `3000F3`, PENDING
  - Falsified if: differs from slot 15 of IDWriteFactory, HRESULT CreateTextFormat(WCHAR const* fontFamilyName, IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, FLOAT fontSize, WCHAR const* localeName, IDWriteTextFormat** textFormat) in dwrite.h, or fontFamilyName or localeName does not reach it as a NUL-terminated UTF-16 string
- `Broiler.Native.Windows.Direct2D.Direct2DDeviceApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DDeviceApi.cs` - Security=High, Spec=none cited, `A189CB`, PENDING
  - Falsified if: CreateD2DDeviceProc, the one delegate here, is not slot 17 of ID2D1Factory1, HRESULT CreateDevice(IDXGIDevice *dxgiDevice, ID2D1Device **d2dDevice) in d2d1_1.h
- `Broiler.Native.Windows.Direct2D.Direct2DDeviceApi.CreateD2DDeviceProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DDeviceApi.cs` - Security=High, Spec=none cited, `6E40F2`, PENDING
  - Falsified if: CreateD2DDeviceProc is not slot 17 of ID2D1Factory1, HRESULT CreateDevice(IDXGIDevice *dxgiDevice, ID2D1Device **d2dDevice) in d2d1_1.h
- `Broiler.Native.Windows.Direct2D.Direct2DImageStoreApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DImageStoreApi.cs` - Security=Critical, Spec=none cited, `BF5EB3`, PENDING
  - Falsified if: CreateBitmapProc, the one delegate here, is not slot 4 of ID2D1RenderTarget, HRESULT CreateBitmap(D2D1_SIZE_U size, CONST void *srcData, UINT32 pitch, CONST D2D1_BITMAP_PROPERTIES *bitmapProperties, ID2D1Bitmap **bitmap) in d2d1.h, which reads size.height rows pitch bytes apart from srcData
- `Broiler.Native.Windows.Direct2D.Direct2DImageStoreApi.CreateBitmapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DImageStoreApi.cs` - Security=Critical, Spec=none cited, `B276F6`, PENDING
  - Falsified if: CreateBitmapProc is not slot 4 of ID2D1RenderTarget, HRESULT CreateBitmap(D2D1_SIZE_U size, CONST void *srcData, UINT32 pitch, CONST D2D1_BITMAP_PROPERTIES *bitmapProperties, ID2D1Bitmap **bitmap) in d2d1.h, which reads size.height rows pitch bytes apart from srcData
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=Critical, Spec=none cited, `1DD226`, PENDING
  - Falsified if: CreateBitmap1Proc is not slot 57 of ID2D1DeviceContext, HRESULT CreateBitmap(D2D1_SIZE_U size, CONST void *sourceData, UINT32 pitch, CONST D2D1_BITMAP_PROPERTIES1 *bitmapProperties, ID2D1Bitmap1 **bitmap) in d2d1_1.h, which reads size.height rows pitch bytes apart from sourceData
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi.CreateBitmap1Proc` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=Critical, Spec=none cited, `A118A6`, PENDING
  - Falsified if: CreateBitmap1Proc is not slot 57 of ID2D1DeviceContext, HRESULT CreateBitmap(D2D1_SIZE_U size, CONST void *sourceData, UINT32 pitch, CONST D2D1_BITMAP_PROPERTIES1 *bitmapProperties, ID2D1Bitmap1 **bitmap) in d2d1_1.h, which reads size.height rows pitch bytes apart from sourceData
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi.CopyFromBitmapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=Critical, Spec=none cited, `622C7A`, PENDING
  - Falsified if: CopyFromBitmapProc is not slot 8 of ID2D1Bitmap, HRESULT CopyFromBitmap(CONST D2D1_POINT_2U *destPoint, ID2D1Bitmap *bitmap, CONST D2D1_RECT_U *srcRect) in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi.MapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=Critical, Spec=none cited, `37BC4C`, PENDING
  - Falsified if: MapProc is not slot 14 of ID2D1Bitmap1, HRESULT Map(D2D1_MAP_OPTIONS options, D2D1_MAPPED_RECT *mappedRect) in d2d1_1.h, whose D2D1_MAPPED_RECT is 16 bytes on 64-bit with bits at offset 8
- `Broiler.Native.Windows.Direct2D.Direct2DOffscreenSurfaceApi.UnmapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DOffscreenSurfaceApi.cs` - Security=High, Spec=none cited, `4A016C`, PENDING
  - Falsified if: UnmapProc is not slot 15 of ID2D1Bitmap1, HRESULT Unmap() in d2d1_1.h
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, Spec=none cited, `5AD2D2`, PENDING
  - Falsified if: DrawTextProc is not slot 27 of ID2D1RenderTarget, void DrawText(CONST WCHAR *string, UINT32 stringLength, IDWriteTextFormat *textFormat, CONST D2D1_RECT_F *layoutRect, ID2D1Brush *defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode) in d2d1.h, whose string is UTF-16 and stringLength counts its WCHARs
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.BeginDrawProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `19DEFC`, PENDING
  - Falsified if: BeginDrawProc is not slot 48 of ID2D1RenderTarget, void BeginDraw() in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.EndDrawProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, Spec=none cited, `908727`, PENDING
  - Falsified if: EndDrawProc is not slot 49 of ID2D1RenderTarget, HRESULT EndDraw(D2D1_TAG *tag1, D2D1_TAG *tag2) in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.ClearProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `AE36CF`, PENDING
  - Falsified if: ClearProc is not slot 47 of ID2D1RenderTarget, void Clear(CONST D2D1_COLOR_F *clearColor) in d2d1.h, whose clearColor points at a 16-byte D2D1_COLOR_F
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.SetAntialiasModeProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `DF1DCC`, PENDING
  - Falsified if: SetAntialiasModeProc is not slot 32 of ID2D1RenderTarget, void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode) in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.SetTextAntialiasModeProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `0D0E8D`, PENDING
  - Falsified if: SetTextAntialiasModeProc is not slot 34 of ID2D1RenderTarget, void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode) in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.SetTransformProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `698448`, PENDING
  - Falsified if: SetTransformProc is not slot 30 of ID2D1RenderTarget, void SetTransform(CONST D2D1_MATRIX_3X2_F *transform) in d2d1.h, whose transform points at a 24-byte D2D1_MATRIX_3X2_F
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.CreateSolidColorBrushProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, Spec=none cited, `E7E385`, PENDING
  - Falsified if: CreateSolidColorBrushProc is not slot 8 of ID2D1RenderTarget, HRESULT CreateSolidColorBrush(CONST D2D1_COLOR_F *color, CONST D2D1_BRUSH_PROPERTIES *brushProperties, ID2D1SolidColorBrush **solidColorBrush) in d2d1.h, whose color points at a 16-byte D2D1_COLOR_F
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.FillRectangleProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `824F30`, PENDING
  - Falsified if: FillRectangleProc is not slot 17 of ID2D1RenderTarget, void FillRectangle(CONST D2D1_RECT_F *rect, ID2D1Brush *brush) in d2d1.h, whose rect points at a 16-byte D2D1_RECT_F
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GetFactoryProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `7F9457`, PENDING
  - Falsified if: GetFactoryProc is not slot 3 of ID2D1Resource, void GetFactory(ID2D1Factory **factory) CONST in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.CreatePathGeometryProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `263E64`, PENDING
  - Falsified if: CreatePathGeometryProc is not slot 10 of ID2D1Factory, HRESULT CreatePathGeometry(ID2D1PathGeometry **pathGeometry) in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.PathGeometryOpenProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `F267E0`, PENDING
  - Falsified if: PathGeometryOpenProc is not slot 17 of ID2D1PathGeometry, HRESULT Open(ID2D1GeometrySink **geometrySink) in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkSetFillModeProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `EA5E6B`, PENDING
  - Falsified if: GeometrySinkSetFillModeProc is not slot 3 of ID2D1SimplifiedGeometrySink, void SetFillMode(D2D1_FILL_MODE fillMode) in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkBeginFigureProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `112802`, PENDING
  - Falsified if: GeometrySinkBeginFigureProc is not slot 5 of ID2D1SimplifiedGeometrySink, void BeginFigure(D2D1_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin) in d2d1.h, whose startPoint is an 8-byte D2D1_POINT_2F passed by value
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkAddLinesProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, Spec=none cited, `1D7738`, PENDING
  - Falsified if: GeometrySinkAddLinesProc is not slot 6 of ID2D1SimplifiedGeometrySink, void AddLines(CONST D2D1_POINT_2F *points, UINT32 pointsCount) in d2d1.h, which reads pointsCount 8-byte points from the array
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkEndFigureProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `B50897`, PENDING
  - Falsified if: GeometrySinkEndFigureProc is not slot 8 of ID2D1SimplifiedGeometrySink, void EndFigure(D2D1_FIGURE_END figureEnd) in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.GeometrySinkCloseProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `610C3C`, PENDING
  - Falsified if: GeometrySinkCloseProc is not slot 9 of ID2D1SimplifiedGeometrySink, HRESULT Close() in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.FillGeometryProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `A97749`, PENDING
  - Falsified if: FillGeometryProc is not slot 23 of ID2D1RenderTarget, void FillGeometry(ID2D1Geometry *geometry, ID2D1Brush *brush, ID2D1Brush *opacityBrush) in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.DrawRectangleProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `3980C2`, PENDING
  - Falsified if: DrawRectangleProc is not slot 16 of ID2D1RenderTarget, void DrawRectangle(CONST D2D1_RECT_F *rect, ID2D1Brush *brush, FLOAT strokeWidth, ID2D1StrokeStyle *strokeStyle) in d2d1.h, whose rect points at a 16-byte D2D1_RECT_F
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.FillRoundedRectangleProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `53C94F`, PENDING
  - Falsified if: FillRoundedRectangleProc is not slot 19 of ID2D1RenderTarget, void FillRoundedRectangle(CONST D2D1_ROUNDED_RECT *roundedRect, ID2D1Brush *brush) in d2d1.h, whose roundedRect points at a 24-byte D2D1_ROUNDED_RECT with radiusX at offset 16
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.DrawRoundedRectangleProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `5F1379`, PENDING
  - Falsified if: DrawRoundedRectangleProc is not slot 18 of ID2D1RenderTarget, void DrawRoundedRectangle(CONST D2D1_ROUNDED_RECT *roundedRect, ID2D1Brush *brush, FLOAT strokeWidth, ID2D1StrokeStyle *strokeStyle) in d2d1.h, whose roundedRect points at a 24-byte D2D1_ROUNDED_RECT
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.DrawTextProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=Critical, Spec=none cited, `B0981C`, PENDING
  - Falsified if: DrawTextProc is not slot 27 of ID2D1RenderTarget, void DrawText(CONST WCHAR *string, UINT32 stringLength, IDWriteTextFormat *textFormat, CONST D2D1_RECT_F *layoutRect, ID2D1Brush *defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode) in d2d1.h, whose string is UTF-16 and stringLength counts its WCHARs
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.DrawBitmapProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `B19583`, PENDING
  - Falsified if: DrawBitmapProc is not slot 26 of ID2D1RenderTarget, void DrawBitmap(ID2D1Bitmap *bitmap, CONST D2D1_RECT_F *destinationRectangle, FLOAT opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, CONST D2D1_RECT_F *sourceRectangle) in d2d1.h, whose two rectangles point at 16-byte D2D1_RECT_F values
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.PushAxisAlignedClipProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `7E94DC`, PENDING
  - Falsified if: PushAxisAlignedClipProc is not slot 45 of ID2D1RenderTarget, void PushAxisAlignedClip(CONST D2D1_RECT_F *clipRect, D2D1_ANTIALIAS_MODE antialiasMode) in d2d1.h, whose clipRect points at a 16-byte D2D1_RECT_F
- `Broiler.Native.Windows.Direct2D.Direct2DRendererApi.PopAxisAlignedClipProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DRendererApi.cs` - Security=High, Spec=none cited, `F1D399`, PENDING
  - Falsified if: PopAxisAlignedClipProc is not slot 46 of ID2D1RenderTarget, void PopAxisAlignedClip() in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=Critical, Spec=none cited, `062529`, PENDING
  - Falsified if: CreateSwapChainForHwndProc is not slot 15 of IDXGIFactory2, HRESULT CreateSwapChainForHwnd(IUnknown *pDevice, HWND hWnd, const DXGI_SWAP_CHAIN_DESC1 *pDesc, const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *pFullscreenDesc, IDXGIOutput *pRestrictToOutput, IDXGISwapChain1 **ppSwapChain) in dxgi1_2.h, whose pDesc points at a 48-byte DXGI_SWAP_CHAIN_DESC1
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.CreateSwapChainForCompositionProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, Spec=none cited, `7753C7`, PENDING
  - Falsified if: CreateSwapChainForCompositionProc is not slot 24 of IDXGIFactory2, HRESULT CreateSwapChainForComposition(IUnknown *pDevice, const DXGI_SWAP_CHAIN_DESC1 *pDesc, IDXGIOutput *pRestrictToOutput, IDXGISwapChain1 **ppSwapChain) in dxgi1_2.h, whose pDesc points at a 48-byte DXGI_SWAP_CHAIN_DESC1
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.CreateSwapChainForHwndProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=Critical, Spec=none cited, `25B49B`, PENDING
  - Falsified if: CreateSwapChainForHwndProc is not slot 15 of IDXGIFactory2, HRESULT CreateSwapChainForHwnd(IUnknown *pDevice, HWND hWnd, const DXGI_SWAP_CHAIN_DESC1 *pDesc, const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *pFullscreenDesc, IDXGIOutput *pRestrictToOutput, IDXGISwapChain1 **ppSwapChain) in dxgi1_2.h, whose pDesc points at a 48-byte DXGI_SWAP_CHAIN_DESC1
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.GetBufferProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, Spec=none cited, `CC68D0`, PENDING
  - Falsified if: GetBufferProc is not slot 9 of IDXGISwapChain, HRESULT GetBuffer(UINT Buffer, REFIID riid, void **ppSurface) in dxgi.h, whose riid is passed as the address of a 16-byte IID
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.ResizeBuffersProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, Spec=none cited, `FA3C79`, PENDING
  - Falsified if: ResizeBuffersProc is not slot 13 of IDXGISwapChain, HRESULT ResizeBuffers(UINT BufferCount, UINT Width, UINT Height, DXGI_FORMAT NewFormat, UINT SwapChainFlags) in dxgi.h
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.CreateBitmapFromDxgiSurfaceProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, Spec=none cited, `3A939B`, PENDING
  - Falsified if: CreateBitmapFromDxgiSurfaceProc is not slot 62 of ID2D1DeviceContext, HRESULT CreateBitmapFromDxgiSurface(IDXGISurface *surface, CONST D2D1_BITMAP_PROPERTIES1 *bitmapProperties, ID2D1Bitmap1 **bitmap) in d2d1_1.h, whose D2D1_BITMAP_PROPERTIES1 is 32 bytes on 64-bit with colorContext at offset 24
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.SetDpiProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, Spec=none cited, `07F303`, PENDING
  - Falsified if: SetDpiProc is not slot 51 of ID2D1RenderTarget, void SetDpi(FLOAT dpiX, FLOAT dpiY) in d2d1.h
- `Broiler.Native.Windows.Direct2D.Direct2DSurfaceApi.PresentProc` in `src/Broiler.Native.Windows/Direct2D/Direct2DSurfaceApi.cs` - Security=High, Spec=none cited, `F5376C`, PENDING
  - Falsified if: PresentProc is not slot 8 of IDXGISwapChain, HRESULT Present(UINT SyncInterval, UINT Flags) in dxgi.h
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=Critical, Spec=none cited, `6C4DE2`, PENDING
  - Falsified if: GetStringProc is not slot 8 of IDWriteLocalizedStrings, HRESULT GetString(UINT32 index, WCHAR* stringBuffer, UINT32 size) in dwrite.h, whose size is the capacity of stringBuffer in WCHARs, terminating null included
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetSystemFontCollectionProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, Spec=none cited, `C6C363`, PENDING
  - Falsified if: GetSystemFontCollectionProc is not slot 3 of IDWriteFactory, HRESULT GetSystemFontCollection(IDWriteFontCollection** fontCollection, BOOL checkForUpdates) in dwrite.h, whose checkForUpdates is a 4-byte BOOL
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetFontFamilyCountProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, Spec=none cited, `9E781E`, PENDING
  - Falsified if: GetFontFamilyCountProc is not slot 3 of IDWriteFontCollection, UINT32 GetFontFamilyCount() in dwrite.h
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetFontFamilyProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, Spec=none cited, `7109EE`, PENDING
  - Falsified if: GetFontFamilyProc is not slot 4 of IDWriteFontCollection, HRESULT GetFontFamily(UINT32 index, IDWriteFontFamily** fontFamily) in dwrite.h
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetFamilyNamesProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, Spec=none cited, `31159B`, PENDING
  - Falsified if: GetFamilyNamesProc is not slot 6 of IDWriteFontFamily, HRESULT GetFamilyNames(IDWriteLocalizedStrings** names) in dwrite.h
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.FindLocaleNameProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, Spec=none cited, `4B03F9`, PENDING
  - Falsified if: FindLocaleNameProc is not slot 4 of IDWriteLocalizedStrings, HRESULT FindLocaleName(WCHAR const* localeName, UINT32* index, BOOL* exists) in dwrite.h, whose localeName is a null-terminated UTF-16 string and exists a 4-byte BOOL
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetStringLengthProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=High, Spec=none cited, `BAB88A`, PENDING
  - Falsified if: GetStringLengthProc is not slot 7 of IDWriteLocalizedStrings, HRESULT GetStringLength(UINT32 index, UINT32* length) in dwrite.h
- `Broiler.Native.Windows.Direct2D.DirectWriteFontFamiliesApi.GetStringProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteFontFamiliesApi.cs` - Security=Critical, Spec=none cited, `15EEF0`, PENDING
  - Falsified if: GetStringProc is not slot 8 of IDWriteLocalizedStrings, HRESULT GetString(UINT32 index, WCHAR* stringBuffer, UINT32 size) in dwrite.h, whose size is the capacity of stringBuffer in WCHARs, terminating null included
- `Broiler.Native.Windows.Direct2D.DirectWriteTextMetricsProviderApi` in `src/Broiler.Native.Windows/Direct2D/DirectWriteTextMetricsProviderApi.cs` - Security=Critical, Spec=none cited, `E4A9A2`, PENDING
  - Falsified if: CreateTextLayoutProc is not slot 18 of IDWriteFactory, HRESULT CreateTextLayout(WCHAR const* string, UINT32 stringLength, IDWriteTextFormat* textFormat, FLOAT maxWidth, FLOAT maxHeight, IDWriteTextLayout** textLayout) in dwrite.h, whose string is UTF-16 and stringLength counts its WCHARs
- `Broiler.Native.Windows.Direct2D.DirectWriteTextMetricsProviderApi.CreateTextLayoutProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteTextMetricsProviderApi.cs` - Security=Critical, Spec=none cited, `671FA2`, PENDING
  - Falsified if: CreateTextLayoutProc is not slot 18 of IDWriteFactory, HRESULT CreateTextLayout(WCHAR const* string, UINT32 stringLength, IDWriteTextFormat* textFormat, FLOAT maxWidth, FLOAT maxHeight, IDWriteTextLayout** textLayout) in dwrite.h, whose string is UTF-16 and stringLength counts its WCHARs
- `Broiler.Native.Windows.Direct2D.DirectWriteTextMetricsProviderApi.GetMetricsProc` in `src/Broiler.Native.Windows/Direct2D/DirectWriteTextMetricsProviderApi.cs` - Security=High, Spec=none cited, `ED31D6`, PENDING
  - Falsified if: GetMetricsProc is not slot 60 of IDWriteTextLayout, HRESULT GetMetrics(DWRITE_TEXT_METRICS* textMetrics) in dwrite.h, whose DWRITE_TEXT_METRICS is 36 bytes with lineCount at offset 32
- `Broiler.Native.Windows.Direct2D.DxgiNative` in `src/Broiler.Native.Windows/Direct2D/DxgiNative.cs` - Security=High, Spec=none cited, `AC7CA2`, PENDING
  - Falsified if: a structure here is not laid out as in dxgi1_2.h, for example DXGI_SWAP_CHAIN_DESC1 not being 48 bytes, so CreateSwapChainForHwnd reads the sample description and the later fields at shifted offsets
- `Broiler.Native.Windows.Direct2D.DxgiNative.DXGI_SAMPLE_DESC` in `src/Broiler.Native.Windows/Direct2D/DxgiNative.cs` - Security=High, Spec=none cited, `A550C9`, PENDING
  - Falsified if: Marshal.SizeOf is not 8 or Quality is not at offset 4, the layout of DXGI_SAMPLE_DESC { UINT Count; UINT Quality; } in dxgicommon.h
- `Broiler.Native.Windows.Direct2D.DxgiNative.DXGI_SWAP_CHAIN_DESC1` in `src/Broiler.Native.Windows/Direct2D/DxgiNative.cs` - Security=High, Spec=none cited, `DBD1C7`, PENDING
  - Falsified if: Marshal.SizeOf is not 48, Stereo is not a 4-byte BOOL at offset 12, or SampleDesc is not at offset 16, the layout of DXGI_SWAP_CHAIN_DESC1 in dxgi1_2.h
- `Broiler.Native.Windows.Direct2D.NativeMethods` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=Critical, Spec=none cited, `C630AC`, PENDING
  - Falsified if: an entry point here differs from its prototype: D3D11CreateDevice in d3d11.h, CreateDXGIFactory1 in dxgi.h, D2D1CreateFactory in d2d1.h or DWriteCreateFactory in dwrite.h
- `Broiler.Native.Windows.Direct2D.NativeMethods.D3D11CreateDevice(IntPtr, D3D11Native.D3D_DRIVER_TYPE, IntPtr, uint, IntPtr, uint, uint, out IntPtr, out D3D11Native.D3D_FEATURE_LEVEL, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=Critical, Spec=none cited, `B9D586`, PENDING
  - Falsified if: differs from HRESULT D3D11CreateDevice(IDXGIAdapter* pAdapter, D3D_DRIVER_TYPE DriverType, HMODULE Software, UINT Flags, CONST D3D_FEATURE_LEVEL* pFeatureLevels, UINT FeatureLevels, UINT SDKVersion, ID3D11Device** ppDevice, D3D_FEATURE_LEVEL* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext) in d3d11.h, which reads FeatureLevels entries from pFeatureLevels
- `Broiler.Native.Windows.Direct2D.NativeMethods.CreateDXGIFactory1(in Guid, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=High, Spec=none cited, `260F5E`, PENDING
  - Falsified if: differs from HRESULT CreateDXGIFactory1(REFIID riid, void **ppFactory) in dxgi.h
- `Broiler.Native.Windows.Direct2D.NativeMethods.D2D1CreateFactory(D2DNative.D2D1_FACTORY_TYPE, in Guid, IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=Critical, Spec=none cited, `3563F3`, PENDING
  - Falsified if: differs from HRESULT D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, REFIID riid, CONST D2D1_FACTORY_OPTIONS *pFactoryOptions, void **ppIFactory) in d2d1.h
- `Broiler.Native.Windows.Direct2D.NativeMethods.DWriteCreateFactory(DWriteNative.DWRITE_FACTORY_TYPE, in Guid, out IntPtr)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=High, Spec=none cited, `F2E7BF`, PENDING
  - Falsified if: differs from HRESULT DWriteCreateFactory(DWRITE_FACTORY_TYPE factoryType, REFIID iid, IUnknown **factory) in dwrite.h
- `Broiler.Native.Windows.Direct2D.NativeMethods.Succeeded(int)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=High, Spec=none cited, `74416D`, PENDING
  - Falsified if: an HRESULT with the severity bit set, such as 0x887A0005, returns true, so the caller attaches an out pointer the failed call never wrote
- `Broiler.Native.Windows.Direct2D.NativeMethods.ThrowIfFailed(int, string)` in `src/Broiler.Native.Windows/Direct2D/NativeMethods.cs` - Security=High, Spec=none cited, `88558B`, PENDING
  - Falsified if: a failing HRESULT such as 0x80004005 returns without throwing, so the caller attaches the zero out pointer and calls through it
- `Broiler.Native.Windows.HwndNative` in `src/Broiler.Native.Windows/HwndNative.cs` - Security=High, Spec=none cited, `EDAB60`, PENDING
  - Falsified if: its IsWindow import differs from BOOL IsWindow(HWND hWnd) in winuser.h
- `Broiler.Native.Windows.HwndNative.IsWindow(nint)` in `src/Broiler.Native.Windows/HwndNative.cs` - Security=High, Spec=none cited, `EF9423`, PENDING
  - Falsified if: differs from BOOL IsWindow(HWND hWnd) in winuser.h, with the result marshalled as a 4-byte BOOL
- `Broiler.Native.Windows.Input.RawInputReaderNative` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=Critical, Spec=none cited, `33D29B`, PENDING
  - Falsified if: a struct or the import differs from its winuser.h counterpart: RAWINPUTHEADER, RAWMOUSE, RAWKEYBOARD or UINT GetRawInputData(HRAWINPUT, UINT, LPVOID, PUINT, UINT)
- `Broiler.Native.Windows.Input.RawInputReaderNative.RawInputHeader` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=High, Spec=none cited, `777845`, PENDING
  - Falsified if: Marshal.SizeOf is not 24 on 64-bit (16 on 32-bit) or Device is not at offset 8, the layout of RAWINPUTHEADER (DWORD dwType, DWORD dwSize, HANDLE hDevice, WPARAM wParam) in winuser.h
- `Broiler.Native.Windows.Input.RawInputReaderNative.RawMouse` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=High, Spec=none cited, `42EB0C`, PENDING
  - Falsified if: Marshal.OffsetOf of ButtonFlags is not 4 or of ButtonData not 6, where RAWMOUSE in winuser.h puts usButtonFlags and usButtonData in a union with ULONG ulButtons after USHORT usFlags
- `Broiler.Native.Windows.Input.RawInputReaderNative.RawKeyboard` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=High, Spec=none cited, `09BBF5`, PENDING
  - Falsified if: Marshal.SizeOf is not 16 or VKey is not at offset 6 and Message at 8, the layout of RAWKEYBOARD (USHORT MakeCode, Flags, Reserved, VKey, UINT Message, ULONG ExtraInformation) in winuser.h
- `Broiler.Native.Windows.Input.RawInputReaderNative.GetRawInputData(IntPtr, uint, IntPtr, ref uint, uint)` in `src/Broiler.Native.Windows/Input/RawInputReaderNative.cs` - Security=Critical, Spec=none cited, `DCA974`, PENDING
  - Falsified if: differs from UINT GetRawInputData(HRAWINPUT hRawInput, UINT uiCommand, LPVOID pData, PUINT pcbSize, UINT cbSizeHeader) in winuser.h, where pcbSize is the byte size of pData and cbSizeHeader must be sizeof(RAWINPUTHEADER)
- `Broiler.Native.Windows.Input.RawInputRegistrationNative` in `src/Broiler.Native.Windows/Input/RawInputRegistrationNative.cs` - Security=Critical, Spec=none cited, `B1A9F1`, PENDING
  - Falsified if: its import differs from BOOL RegisterRawInputDevices(PCRAWINPUTDEVICE pRawInputDevices, UINT uiNumDevices, UINT cbSize) in winuser.h
- `Broiler.Native.Windows.Input.RawInputRegistrationNative.RawInputDevice` in `src/Broiler.Native.Windows/Input/RawInputRegistrationNative.cs` - Security=High, Spec=none cited, `BCE2F9`, PENDING
  - Falsified if: Marshal.SizeOf is not 16 on 64-bit (12 on 32-bit) or TargetWindow is not at offset 8, the layout of RAWINPUTDEVICE (USHORT usUsagePage, USHORT usUsage, DWORD dwFlags, HWND hwndTarget) in winuser.h
- `Broiler.Native.Windows.Input.RawInputRegistrationNative.RegisterRawInputDevices(RawInputDevice[], uint, uint)` in `src/Broiler.Native.Windows/Input/RawInputRegistrationNative.cs` - Security=Critical, Spec=none cited, `261907`, PENDING
  - Falsified if: differs from BOOL RegisterRawInputDevices(PCRAWINPUTDEVICE pRawInputDevices, UINT uiNumDevices, UINT cbSize) in winuser.h, where uiNumDevices counts the array's entries and cbSize must be sizeof(RAWINPUTDEVICE)
- `Broiler.Native.Windows.MediaFoundation.Capture.WindowsMediaFoundationNative` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `2038F3`, PENDING
  - Falsified if: one of its imports differs from its SDK prototype, MFEnumDeviceSources or MFCreateDeviceSource in mfidl.h or MFCreateSourceReaderFromMediaSource in mfreadwrite.h
- `Broiler.Native.Windows.MediaFoundation.Capture.WindowsMediaFoundationNative.MFEnumDeviceSources(IMFAttributes, out IntPtr, out uint)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `8E6AB1`, PENDING
  - Falsified if: differs from STDAPI MFEnumDeviceSources(IMFAttributes* pAttributes, IMFActivate*** pppSourceActivate, UINT32* pcSourceActivate) in mfidl.h, where devices receives an array of count IMFActivate references the caller must each Release and then free with CoTaskMemFree
- `Broiler.Native.Windows.MediaFoundation.Capture.WindowsMediaFoundationNative.MFCreateDeviceSource(IMFAttributes, out IMFMediaSource)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `8FEFF4`, PENDING
  - Falsified if: differs from STDAPI MFCreateDeviceSource(IMFAttributes* pAttributes, IMFMediaSource** ppSource) in mfidl.h, whose ppSource reference must pass to the returned wrapper and be released once with it
- `Broiler.Native.Windows.MediaFoundation.Capture.WindowsMediaFoundationNative.MFCreateSourceReaderFromMediaSource(IMFMediaSource, IMFAttributes?, out IMFSourceReader)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `1B4E53`, PENDING
  - Falsified if: differs from STDAPI MFCreateSourceReaderFromMediaSource(IMFMediaSource *pMediaSource, IMFAttributes *pAttributes, IMFSourceReader **ppSourceReader) in mfreadwrite.h, or a null attributes does not arrive as the null pointer the _In_opt_ pAttributes allows
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFActivate` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `9CE72D`, PENDING
  - Falsified if: its vtable differs from IMFActivate : public IMFAttributes in mfobjects.h, the 30 IMFAttributes methods at slots 3 to 32, then ActivateObject at slot 33 through DetachObject at slot 35
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFActivate.ActivateObject(ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `9210BC`, PENDING
  - Falsified if: is not slot 33 of IMFActivate, HRESULT ActivateObject(REFIID riid, void **ppv) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFActivate.ShutdownObject()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B2D4A2`, PENDING
  - Falsified if: is not slot 34 of IMFActivate, HRESULT ShutdownObject(void) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFActivate.DetachObject()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `3D143C`, PENDING
  - Falsified if: is not slot 35 of IMFActivate, HRESULT DetachObject(void) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `0E895F`, PENDING
  - Falsified if: its vtable differs from IMFMediaSource : public IMFMediaEventGenerator in mfidl.h, GetEvent at slot 3 through QueueEvent at slot 6 from mfobjects.h, then GetCharacteristics at slot 7 through Shutdown at slot 12
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.GetEvent(int, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `0E5E8D`, PENDING
  - Falsified if: is not slot 3 of IMFMediaSource, HRESULT GetEvent(DWORD dwFlags, IMFMediaEvent **ppEvent) of IMFMediaEventGenerator in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.BeginGetEvent(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `A2701C`, PENDING
  - Falsified if: is not slot 4 of IMFMediaSource, HRESULT BeginGetEvent(IMFAsyncCallback *pCallback, IUnknown *punkState) of IMFMediaEventGenerator in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.EndGetEvent(IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `F27CE9`, PENDING
  - Falsified if: is not slot 5 of IMFMediaSource, HRESULT EndGetEvent(IMFAsyncResult *pResult, IMFMediaEvent **ppEvent) of IMFMediaEventGenerator in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.QueueEvent(int, ref Guid, int, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `0CB8DF`, PENDING
  - Falsified if: is not slot 6 of IMFMediaSource, HRESULT QueueEvent(MediaEventType met, REFGUID guidExtendedType, HRESULT hrStatus, const PROPVARIANT *pvValue) of IMFMediaEventGenerator in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.GetCharacteristics(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `233D25`, PENDING
  - Falsified if: is not slot 7 of IMFMediaSource, HRESULT GetCharacteristics(DWORD *pdwCharacteristics) in mfidl.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.CreatePresentationDescriptor(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `DFC700`, PENDING
  - Falsified if: is not slot 8 of IMFMediaSource, HRESULT CreatePresentationDescriptor(IMFPresentationDescriptor **ppPresentationDescriptor) in mfidl.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.Start(IntPtr, ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `007B5F`, PENDING
  - Falsified if: is not slot 9 of IMFMediaSource, HRESULT Start(IMFPresentationDescriptor *pPresentationDescriptor, const GUID *pguidTimeFormat, const PROPVARIANT *pvarStartPosition) in mfidl.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.Stop()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `458393`, PENDING
  - Falsified if: is not slot 10 of IMFMediaSource, HRESULT Stop(void) in mfidl.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.Pause()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `3DEE33`, PENDING
  - Falsified if: is not slot 11 of IMFMediaSource, HRESULT Pause(void) in mfidl.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaSource.Shutdown()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B383A8`, PENDING
  - Falsified if: is not slot 12 of IMFMediaSource, HRESULT Shutdown(void) in mfidl.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `0511AF`, PENDING
  - Falsified if: its vtable differs from IMFMediaType : public IMFAttributes in mfobjects.h, the 30 IMFAttributes methods at slots 3 to 32, then GetMajorType at slot 33 through FreeRepresentation at slot 37
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.GetMajorType(out Guid)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `A1D09D`, PENDING
  - Falsified if: is not slot 33 of IMFMediaType, HRESULT GetMajorType(GUID *pguidMajorType) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.IsCompressedFormat(out bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `8C2475`, PENDING
  - Falsified if: compressed is marshalled narrower than the 4-byte BOOL of HRESULT IsCompressedFormat(BOOL *pfCompressed), slot 34 of IMFMediaType in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.IsEqual(IMFMediaType, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `01BD88`, PENDING
  - Falsified if: is not slot 35 of IMFMediaType, HRESULT IsEqual(IMFMediaType *pIMediaType, DWORD *pdwFlags) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.GetRepresentation(Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `C437BF`, PENDING
  - Falsified if: is not slot 36 of IMFMediaType, HRESULT GetRepresentation(GUID guidRepresentation, LPVOID *ppvRepresentation) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaType.FreeRepresentation(Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `E8E537`, PENDING
  - Falsified if: is not slot 37 of IMFMediaType, HRESULT FreeRepresentation(GUID guidRepresentation, LPVOID pvRepresentation) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `0EC939`, PENDING
  - Falsified if: its vtable differs from IMFSourceReader : public IUnknown in mfreadwrite.h, GetStreamSelection at slot 3 through GetPresentationAttribute at slot 12
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetStreamSelection(int, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `ACDBE9`, PENDING
  - Falsified if: selected is marshalled narrower than the 4-byte BOOL of HRESULT GetStreamSelection(DWORD dwStreamIndex, BOOL *pfSelected), slot 3 of IMFSourceReader in mfreadwrite.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.SetStreamSelection(int, bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `37F403`, PENDING
  - Falsified if: selected is passed narrower than the 4-byte BOOL of HRESULT SetStreamSelection(DWORD dwStreamIndex, BOOL fSelected), slot 4 of IMFSourceReader in mfreadwrite.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetNativeMediaType(int, int, out IMFMediaType)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `191BB5`, PENDING
  - Falsified if: is not slot 5 of IMFSourceReader, HRESULT GetNativeMediaType(DWORD dwStreamIndex, DWORD dwMediaTypeIndex, IMFMediaType **ppMediaType) in mfreadwrite.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetCurrentMediaType(int, out IMFMediaType)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `CAC63C`, PENDING
  - Falsified if: is not slot 6 of IMFSourceReader, HRESULT GetCurrentMediaType(DWORD dwStreamIndex, IMFMediaType **ppMediaType) in mfreadwrite.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.SetCurrentMediaType(int, IntPtr, IMFMediaType)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `57AE9A`, PENDING
  - Falsified if: is not slot 7 of IMFSourceReader, HRESULT SetCurrentMediaType(DWORD dwStreamIndex, DWORD *pdwReserved, IMFMediaType *pMediaType) in mfreadwrite.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.SetCurrentPosition(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `CF62FB`, PENDING
  - Falsified if: is not slot 8 of IMFSourceReader, HRESULT SetCurrentPosition(REFGUID guidTimeFormat, REFPROPVARIANT varPosition) in mfreadwrite.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.ReadSample(int, int, out int, out SourceReaderFlags, out long, out IMFSample?)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `2D7F72`, PENDING
  - Falsified if: is not slot 9 of IMFSourceReader, HRESULT ReadSample(DWORD dwStreamIndex, DWORD dwControlFlags, DWORD *pdwActualStreamIndex, DWORD *pdwStreamFlags, LONGLONG *pllTimestamp, IMFSample **ppSample) in mfreadwrite.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.Flush(int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `7D05AD`, PENDING
  - Falsified if: is not slot 10 of IMFSourceReader, HRESULT Flush(DWORD dwStreamIndex) in mfreadwrite.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetServiceForStream(int, ref Guid, ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `26A506`, PENDING
  - Falsified if: is not slot 11 of IMFSourceReader, HRESULT GetServiceForStream(DWORD dwStreamIndex, REFGUID guidService, REFIID riid, LPVOID *ppvObject) in mfreadwrite.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSourceReader.GetPresentationAttribute(int, ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `05DCB9`, PENDING
  - Falsified if: is not slot 12 of IMFSourceReader, HRESULT GetPresentationAttribute(DWORD dwStreamIndex, REFGUID guidAttribute, PROPVARIANT *pvarAttribute) in mfreadwrite.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `AA199C`, PENDING
  - Falsified if: its vtable differs from IMFSample : public IMFAttributes in mfobjects.h, the inherited GetItem at slot 3 through CopyAllItems at slot 32 declared inline, then GetSampleFlags at slot 33 through CopyToBuffer at slot 46
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetItem(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `CE6DAE`, PENDING
  - Falsified if: is not slot 3 of IMFSample, HRESULT GetItem(REFGUID guidKey, PROPVARIANT *pValue) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetItemType(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `14817B`, PENDING
  - Falsified if: is not slot 4 of IMFSample, HRESULT GetItemType(REFGUID guidKey, MF_ATTRIBUTE_TYPE *pType) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.CompareItem(ref Guid, IntPtr, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `E2FA0C`, PENDING
  - Falsified if: result is marshalled narrower than the 4-byte BOOL of HRESULT CompareItem(REFGUID guidKey, REFPROPVARIANT Value, BOOL *pbResult), slot 5 of IMFSample from IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.Compare(IMFAttributes, int, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `FC95C3`, PENDING
  - Falsified if: result is marshalled narrower than the 4-byte BOOL of HRESULT Compare(IMFAttributes *pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL *pbResult), slot 6 of IMFSample from IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetUINT32(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `22EFE5`, PENDING
  - Falsified if: is not slot 7 of IMFSample, HRESULT GetUINT32(REFGUID guidKey, UINT32 *punValue) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetUINT64(ref Guid, out long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B0164D`, PENDING
  - Falsified if: is not slot 8 of IMFSample, HRESULT GetUINT64(REFGUID guidKey, UINT64 *punValue) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetDouble(ref Guid, out double)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `E83B03`, PENDING
  - Falsified if: is not slot 9 of IMFSample, HRESULT GetDouble(REFGUID guidKey, double *pfValue) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetGUID(ref Guid, out Guid)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `04EAF7`, PENDING
  - Falsified if: is not slot 10 of IMFSample, HRESULT GetGUID(REFGUID guidKey, GUID *pguidValue) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetStringLength(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `CC6026`, PENDING
  - Falsified if: is not slot 11 of IMFSample, HRESULT GetStringLength(REFGUID guidKey, UINT32 *pcchLength) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetString(ref Guid, IntPtr, int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `77BE94`, PENDING
  - Falsified if: differs from HRESULT GetString(REFGUID guidKey, LPWSTR pwszValue, UINT32 cchBufSize, UINT32 *pcchLength), slot 12 of IMFSample from IMFAttributes in mfobjects.h, where size counts the WCHARs value can hold, not its bytes
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetAllocatedString(ref Guid, out IntPtr, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `028D50`, PENDING
  - Falsified if: differs from HRESULT GetAllocatedString(REFGUID guidKey, LPWSTR *ppwszValue, UINT32 *pcchLength), slot 13 of IMFSample from IMFAttributes in mfobjects.h, whose value string of length plus 1 WCHARs the caller owns and must free with CoTaskMemFree
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetBlobSize(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `689F15`, PENDING
  - Falsified if: is not slot 14 of IMFSample, HRESULT GetBlobSize(REFGUID guidKey, UINT32 *pcbBlobSize) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetBlob(ref Guid, IntPtr, int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `DF996E`, PENDING
  - Falsified if: differs from HRESULT GetBlob(REFGUID guidKey, UINT8 *pBuf, UINT32 cbBufSize, UINT32 *pcbBlobSize), slot 15 of IMFSample from IMFAttributes in mfobjects.h, where bufferSize is the byte capacity of buffer
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetAllocatedBlob(ref Guid, out IntPtr, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `D95683`, PENDING
  - Falsified if: differs from HRESULT GetAllocatedBlob(REFGUID guidKey, UINT8 **ppBuf, UINT32 *pcbSize), slot 16 of IMFSample from IMFAttributes in mfobjects.h, whose buffer of size bytes the caller owns and must free with CoTaskMemFree
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetUnknown(ref Guid, ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `D93F2C`, PENDING
  - Falsified if: is not slot 17 of IMFSample, HRESULT GetUnknown(REFGUID guidKey, REFIID riid, LPVOID *ppv) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetItem(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `8A63F9`, PENDING
  - Falsified if: is not slot 18 of IMFSample, HRESULT SetItem(REFGUID guidKey, REFPROPVARIANT Value) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.DeleteItem(ref Guid)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `74315D`, PENDING
  - Falsified if: is not slot 19 of IMFSample, HRESULT DeleteItem(REFGUID guidKey) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.DeleteAllItems()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B3EEDA`, PENDING
  - Falsified if: is not slot 20 of IMFSample, HRESULT DeleteAllItems(void) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetUINT32(ref Guid, int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `ACC7DC`, PENDING
  - Falsified if: is not slot 21 of IMFSample, HRESULT SetUINT32(REFGUID guidKey, UINT32 unValue) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetUINT64(ref Guid, long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `D8F6A0`, PENDING
  - Falsified if: is not slot 22 of IMFSample, HRESULT SetUINT64(REFGUID guidKey, UINT64 unValue) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetDouble(ref Guid, double)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `0AB870`, PENDING
  - Falsified if: is not slot 23 of IMFSample, HRESULT SetDouble(REFGUID guidKey, double fValue) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetGUID(ref Guid, ref Guid)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `4C3268`, PENDING
  - Falsified if: is not slot 24 of IMFSample, HRESULT SetGUID(REFGUID guidKey, REFGUID guidValue) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetString(ref Guid, string)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `C88CB0`, PENDING
  - Falsified if: value is not marshalled as the null-terminated UTF-16 LPCWSTR of HRESULT SetString(REFGUID guidKey, LPCWSTR wszValue), slot 25 of IMFSample from IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetBlob(ref Guid, IntPtr, int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `643E87`, PENDING
  - Falsified if: differs from HRESULT SetBlob(REFGUID guidKey, const UINT8 *pBuf, UINT32 cbBufSize), slot 26 of IMFSample from IMFAttributes in mfobjects.h, where size is the number of bytes read from buffer
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetUnknown(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `EB4C73`, PENDING
  - Falsified if: is not slot 27 of IMFSample, HRESULT SetUnknown(REFGUID guidKey, IUnknown *pUnknown) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.LockStore()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `52D8D9`, PENDING
  - Falsified if: is not slot 28 of IMFSample, HRESULT LockStore(void) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.UnlockStore()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B80F37`, PENDING
  - Falsified if: is not slot 29 of IMFSample, HRESULT UnlockStore(void) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetCount(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `C12DCA`, PENDING
  - Falsified if: is not slot 30 of IMFSample, HRESULT GetCount(UINT32 *pcItems) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetItemByIndex(int, out Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `57C3C3`, PENDING
  - Falsified if: is not slot 31 of IMFSample, HRESULT GetItemByIndex(UINT32 unIndex, GUID *pguidKey, PROPVARIANT *pValue) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.CopyAllItems(IMFAttributes)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `F083D6`, PENDING
  - Falsified if: is not slot 32 of IMFSample, HRESULT CopyAllItems(IMFAttributes *pDest) of IMFAttributes in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetSampleFlags(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `28DCB0`, PENDING
  - Falsified if: is not slot 33 of IMFSample, HRESULT GetSampleFlags(DWORD *pdwSampleFlags) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetSampleFlags(int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `119402`, PENDING
  - Falsified if: is not slot 34 of IMFSample, HRESULT SetSampleFlags(DWORD dwSampleFlags) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetSampleTime(out long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `36A75E`, PENDING
  - Falsified if: is not slot 35 of IMFSample, HRESULT GetSampleTime(LONGLONG *phnsSampleTime) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetSampleTime(long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `58104B`, PENDING
  - Falsified if: is not slot 36 of IMFSample, HRESULT SetSampleTime(LONGLONG hnsSampleTime) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetSampleDuration(out long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `895682`, PENDING
  - Falsified if: is not slot 37 of IMFSample, HRESULT GetSampleDuration(LONGLONG *phnsSampleDuration) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.SetSampleDuration(long)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `3D6461`, PENDING
  - Falsified if: is not slot 38 of IMFSample, HRESULT SetSampleDuration(LONGLONG hnsSampleDuration) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetBufferCount(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B473B3`, PENDING
  - Falsified if: is not slot 39 of IMFSample, HRESULT GetBufferCount(DWORD *pdwBufferCount) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetBufferByIndex(int, out IMFMediaBuffer)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `2959BC`, PENDING
  - Falsified if: is not slot 40 of IMFSample, HRESULT GetBufferByIndex(DWORD dwIndex, IMFMediaBuffer **ppBuffer) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.ConvertToContiguousBuffer(out IMFMediaBuffer)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `799F86`, PENDING
  - Falsified if: is not slot 41 of IMFSample, HRESULT ConvertToContiguousBuffer(IMFMediaBuffer **ppBuffer) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.AddBuffer(IMFMediaBuffer)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `35F355`, PENDING
  - Falsified if: is not slot 42 of IMFSample, HRESULT AddBuffer(IMFMediaBuffer *pBuffer) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.RemoveBufferByIndex(int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `AB56F6`, PENDING
  - Falsified if: is not slot 43 of IMFSample, HRESULT RemoveBufferByIndex(DWORD dwIndex) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.RemoveAllBuffers()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `2BC579`, PENDING
  - Falsified if: is not slot 44 of IMFSample, HRESULT RemoveAllBuffers(void) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.GetTotalLength(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `B86A11`, PENDING
  - Falsified if: is not slot 45 of IMFSample, HRESULT GetTotalLength(DWORD *pcbTotalLength) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFSample.CopyToBuffer(IMFMediaBuffer)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=High, Spec=none cited, `5C8BE2`, PENDING
  - Falsified if: is not slot 46 of IMFSample, HRESULT CopyToBuffer(IMFMediaBuffer *pBuffer) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `59E929`, PENDING
  - Falsified if: its vtable differs from IMFMediaBuffer : public IUnknown in mfobjects.h, Lock at slot 3 through GetMaxLength at slot 7
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.Lock(out IntPtr, out int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `B58521`, PENDING
  - Falsified if: differs from HRESULT Lock(BYTE **ppbBuffer, DWORD *pcbMaxLength, DWORD *pcbCurrentLength), slot 3 of IMFMediaBuffer in mfobjects.h, whose buffer holds maxLength bytes of which only currentLength are valid until Unlock
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.Unlock()` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `82E696`, PENDING
  - Falsified if: is not slot 4 of IMFMediaBuffer, HRESULT Unlock(void) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.GetCurrentLength(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `BA0C7A`, PENDING
  - Falsified if: is not slot 5 of IMFMediaBuffer, HRESULT GetCurrentLength(DWORD *pcbCurrentLength) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.SetCurrentLength(int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `6EBEA5`, PENDING
  - Falsified if: is not slot 6 of IMFMediaBuffer, HRESULT SetCurrentLength(DWORD cbCurrentLength) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.Capture.IMFMediaBuffer.GetMaxLength(out int)` in `src/Broiler.Native.Windows/MediaFoundation/Capture/WindowsMediaFoundationNative.cs` - Security=Critical, Spec=none cited, `5A8655`, PENDING
  - Falsified if: is not slot 7 of IMFMediaBuffer, HRESULT GetMaxLength(DWORD *pcbMaxLength) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `782571`, PENDING
  - Falsified if: the member order differs from IMFAttributes in mfobjects.h, whose vtable runs from GetItem at slot 3 to CopyAllItems at slot 32 after the three IUnknown slots
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetItem(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `CE6DAE`, PENDING
  - Falsified if: is not slot 3 of IMFAttributes, HRESULT GetItem(REFGUID guidKey, PROPVARIANT *pValue) in mfobjects.h, or value addresses fewer than the 24 bytes a PROPVARIANT from propidl.h takes on 64-bit
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetItemType(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `14817B`, PENDING
  - Falsified if: is not slot 4 of IMFAttributes, HRESULT GetItemType(REFGUID guidKey, MF_ATTRIBUTE_TYPE *pType) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.CompareItem(ref Guid, IntPtr, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `E2FA0C`, PENDING
  - Falsified if: is not slot 5 of IMFAttributes, HRESULT CompareItem(REFGUID guidKey, REFPROPVARIANT Value, BOOL *pbResult) in mfobjects.h, or result is marshalled narrower than the 4-byte BOOL
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.Compare(IMFAttributes, int, out bool)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `FC95C3`, PENDING
  - Falsified if: is not slot 6 of IMFAttributes, HRESULT Compare(IMFAttributes *pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL *pbResult) in mfobjects.h, or result is marshalled narrower than the 4-byte BOOL
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetUINT32(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `22EFE5`, PENDING
  - Falsified if: is not slot 7 of IMFAttributes, HRESULT GetUINT32(REFGUID guidKey, UINT32 *punValue) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetUINT64(ref Guid, out long)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `B0164D`, PENDING
  - Falsified if: is not slot 8 of IMFAttributes, HRESULT GetUINT64(REFGUID guidKey, UINT64 *punValue) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetDouble(ref Guid, out double)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `E83B03`, PENDING
  - Falsified if: is not slot 9 of IMFAttributes, HRESULT GetDouble(REFGUID guidKey, double *pfValue) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetGUID(ref Guid, out Guid)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `04EAF7`, PENDING
  - Falsified if: is not slot 10 of IMFAttributes, HRESULT GetGUID(REFGUID guidKey, GUID *pguidValue) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetStringLength(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `CC6026`, PENDING
  - Falsified if: is not slot 11 of IMFAttributes, HRESULT GetStringLength(REFGUID guidKey, UINT32 *pcchLength) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetString(ref Guid, IntPtr, int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `77BE94`, PENDING
  - Falsified if: is not slot 12 of IMFAttributes, HRESULT GetString(REFGUID guidKey, LPWSTR pwszValue, UINT32 cchBufSize, UINT32 *pcchLength) in mfobjects.h, or size is larger than the number of WCHARs the buffer at value holds
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetAllocatedString(ref Guid, out IntPtr, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `028D50`, PENDING
  - Falsified if: is not slot 13 of IMFAttributes, HRESULT GetAllocatedString(REFGUID guidKey, LPWSTR *ppwszValue, UINT32 *pcchLength) in mfobjects.h, or the string written to value is not released with CoTaskMemFree
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetBlobSize(ref Guid, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `689F15`, PENDING
  - Falsified if: is not slot 14 of IMFAttributes, HRESULT GetBlobSize(REFGUID guidKey, UINT32 *pcbBlobSize) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetBlob(ref Guid, IntPtr, int, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `DF996E`, PENDING
  - Falsified if: is not slot 15 of IMFAttributes, HRESULT GetBlob(REFGUID guidKey, UINT8 *pBuf, UINT32 cbBufSize, UINT32 *pcbBlobSize) in mfobjects.h, or bufferSize is larger than the number of bytes the buffer at buffer holds
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetAllocatedBlob(ref Guid, out IntPtr, out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `D95683`, PENDING
  - Falsified if: is not slot 16 of IMFAttributes, HRESULT GetAllocatedBlob(REFGUID guidKey, UINT8 **ppBuf, UINT32 *pcbSize) in mfobjects.h, or the blob written to buffer is not released with CoTaskMemFree
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetUnknown(ref Guid, ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `D93F2C`, PENDING
  - Falsified if: is not slot 17 of IMFAttributes, HRESULT GetUnknown(REFGUID guidKey, REFIID riid, LPVOID *ppv) in mfobjects.h, or the caller does not Release the interface reference written to value
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetItem(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `8A63F9`, PENDING
  - Falsified if: is not slot 18 of IMFAttributes, HRESULT SetItem(REFGUID guidKey, REFPROPVARIANT Value) in mfobjects.h, or value addresses fewer than the 24 bytes a PROPVARIANT from propidl.h takes on 64-bit
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.DeleteItem(ref Guid)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `74315D`, PENDING
  - Falsified if: is not slot 19 of IMFAttributes, HRESULT DeleteItem(REFGUID guidKey) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.DeleteAllItems()` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `B3EEDA`, PENDING
  - Falsified if: is not slot 20 of IMFAttributes, HRESULT DeleteAllItems(void) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetUINT32(ref Guid, int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `ACC7DC`, PENDING
  - Falsified if: is not slot 21 of IMFAttributes, HRESULT SetUINT32(REFGUID guidKey, UINT32 unValue) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetUINT64(ref Guid, long)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `D8F6A0`, PENDING
  - Falsified if: is not slot 22 of IMFAttributes, HRESULT SetUINT64(REFGUID guidKey, UINT64 unValue) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetDouble(ref Guid, double)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `0AB870`, PENDING
  - Falsified if: is not slot 23 of IMFAttributes, HRESULT SetDouble(REFGUID guidKey, double fValue) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetGUID(ref Guid, ref Guid)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `4C3268`, PENDING
  - Falsified if: is not slot 24 of IMFAttributes, HRESULT SetGUID(REFGUID guidKey, REFGUID guidValue) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetString(ref Guid, string)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `C88CB0`, PENDING
  - Falsified if: is not slot 25 of IMFAttributes, HRESULT SetString(REFGUID guidKey, LPCWSTR wszValue) in mfobjects.h, or value reaches it as anything but NUL-terminated UTF-16
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetBlob(ref Guid, IntPtr, int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `643E87`, PENDING
  - Falsified if: is not slot 26 of IMFAttributes, HRESULT SetBlob(REFGUID guidKey, const UINT8 *pBuf, UINT32 cbBufSize) in mfobjects.h, or size is larger than the number of bytes the buffer at buffer holds
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.SetUnknown(ref Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `EB4C73`, PENDING
  - Falsified if: is not slot 27 of IMFAttributes, HRESULT SetUnknown(REFGUID guidKey, IUnknown *pUnknown) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.LockStore()` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `52D8D9`, PENDING
  - Falsified if: is not slot 28 of IMFAttributes, HRESULT LockStore(void) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.UnlockStore()` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `B80F37`, PENDING
  - Falsified if: is not slot 29 of IMFAttributes, HRESULT UnlockStore(void) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetCount(out int)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `C12DCA`, PENDING
  - Falsified if: is not slot 30 of IMFAttributes, HRESULT GetCount(UINT32 *pcItems) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.GetItemByIndex(int, out Guid, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=Critical, Spec=none cited, `57C3C3`, PENDING
  - Falsified if: is not slot 31 of IMFAttributes, HRESULT GetItemByIndex(UINT32 unIndex, GUID *pguidKey, PROPVARIANT *pValue) in mfobjects.h, or value addresses fewer than the 24 bytes a PROPVARIANT from propidl.h takes on 64-bit
- `Broiler.Native.Windows.MediaFoundation.IMFAttributes.CopyAllItems(IMFAttributes)` in `src/Broiler.Native.Windows/MediaFoundation/IMFAttributes.cs` - Security=High, Spec=none cited, `F083D6`, PENDING
  - Falsified if: is not slot 32 of IMFAttributes, HRESULT CopyAllItems(IMFAttributes *pDest) in mfobjects.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineNotify` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `4624E7`, PENDING
  - Falsified if: the vtable differs from IMFMediaEngineNotify in mfmediaengine.h, which has EventNotify alone at slot 3 under IID fee7c112-e776-42b5-9bbf-0048524e2bd5
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineNotify.EventNotify(uint, UIntPtr, uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `FD7E19`, PENDING
  - Falsified if: is not slot 3 of IMFMediaEngineNotify, HRESULT EventNotify(DWORD event, DWORD_PTR param1, DWORD param2) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineClassFactory` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `85C98C`, PENDING
  - Falsified if: the member order differs from IMFMediaEngineClassFactory in mfmediaengine.h, whose vtable runs from CreateInstance at slot 3 to CreateError at slot 5
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineClassFactory.CreateInstance(uint, IMFAttributes, out IMFMediaEngine)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `9BBC9A`, PENDING
  - Falsified if: is not slot 3 of IMFMediaEngineClassFactory, HRESULT CreateInstance(DWORD dwFlags, IMFAttributes *pAttr, IMFMediaEngine **ppPlayer) in mfmediaengine.h, or the reference written to mediaEngine is not Released once its managed wrapper holds it
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineClassFactory.CreateTimeRange(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `37E2E9`, PENDING
  - Falsified if: is not slot 4 of IMFMediaEngineClassFactory, HRESULT CreateTimeRange(IMFMediaTimeRange **ppTimeRange) in mfmediaengine.h, or the caller does not Release the IMFMediaTimeRange written to timeRange
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngineClassFactory.CreateError(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `DF2494`, PENDING
  - Falsified if: is not slot 5 of IMFMediaEngineClassFactory, HRESULT CreateError(IMFMediaError **ppError) in mfmediaengine.h, or the caller does not Release the IMFMediaError written to error
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=Critical, Spec=none cited, `B197E9`, PENDING
  - Falsified if: the member order differs from IMFMediaEngine in mfmediaengine.h, whose vtable runs from GetError at slot 3 to OnVideoStreamTick at slot 44 after the three IUnknown slots
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetError(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `E58FDF`, PENDING
  - Falsified if: is not slot 3 of IMFMediaEngine, HRESULT GetError(IMFMediaError **ppError) in mfmediaengine.h, or the caller does not Release the IMFMediaError written to error
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetErrorCode(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `ABCE54`, PENDING
  - Falsified if: is not slot 4 of IMFMediaEngine, HRESULT SetErrorCode(MF_MEDIA_ENGINE_ERR error) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetSourceElements(IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `625F7D`, PENDING
  - Falsified if: is not slot 5 of IMFMediaEngine, HRESULT SetSourceElements(IMFMediaEngineSrcElements *pSrcElements) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetSource(string)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `670DA0`, PENDING
  - Falsified if: is not slot 6 of IMFMediaEngine, HRESULT SetSource(BSTR pUrl) in mfmediaengine.h, or url reaches it as anything but a length-prefixed BSTR
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetCurrentSource(out string?)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `CA939B`, PENDING
  - Falsified if: is not slot 7 of IMFMediaEngine, HRESULT GetCurrentSource(BSTR *ppUrl) in mfmediaengine.h, or the BSTR written to url is not released with SysFreeString after conversion
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetNetworkState()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `6A0B51`, PENDING
  - Falsified if: is not slot 8 of IMFMediaEngine, USHORT GetNetworkState(void) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetPreload()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `55635A`, PENDING
  - Falsified if: is not slot 9 of IMFMediaEngine, MF_MEDIA_ENGINE_PRELOAD GetPreload(void) in mfmediaengine.h, whose return is the value itself and not an HRESULT
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetPreload(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `B5134F`, PENDING
  - Falsified if: is not slot 10 of IMFMediaEngine, HRESULT SetPreload(MF_MEDIA_ENGINE_PRELOAD Preload) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetBuffered(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `80B762`, PENDING
  - Falsified if: is not slot 11 of IMFMediaEngine, HRESULT GetBuffered(IMFMediaTimeRange **ppBuffered) in mfmediaengine.h, or the caller does not Release the IMFMediaTimeRange written to buffered
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.Load()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `4179CD`, PENDING
  - Falsified if: is not slot 12 of IMFMediaEngine, HRESULT Load(void) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.CanPlayType(string, out int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `310347`, PENDING
  - Falsified if: is not slot 13 of IMFMediaEngine, HRESULT CanPlayType(BSTR type, MF_MEDIA_ENGINE_CANPLAY *pAnswer) in mfmediaengine.h, or type reaches it as anything but a length-prefixed BSTR
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetReadyState()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `731F28`, PENDING
  - Falsified if: is not slot 14 of IMFMediaEngine, USHORT GetReadyState(void) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.IsSeeking()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `40C53E`, PENDING
  - Falsified if: is not slot 15 of IMFMediaEngine, BOOL IsSeeking(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetCurrentTime()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `D30507`, PENDING
  - Falsified if: is not slot 16 of IMFMediaEngine, double GetCurrentTime(void) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetCurrentTime(double)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `A4CA2E`, PENDING
  - Falsified if: is not slot 17 of IMFMediaEngine, HRESULT SetCurrentTime(double seekTime) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetStartTime()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `B36727`, PENDING
  - Falsified if: is not slot 18 of IMFMediaEngine, double GetStartTime(void) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetDuration()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `AED091`, PENDING
  - Falsified if: is not slot 19 of IMFMediaEngine, double GetDuration(void) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.IsPaused()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `2CE76C`, PENDING
  - Falsified if: is not slot 20 of IMFMediaEngine, BOOL IsPaused(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetDefaultPlaybackRate()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `245D28`, PENDING
  - Falsified if: is not slot 21 of IMFMediaEngine, double GetDefaultPlaybackRate(void) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetDefaultPlaybackRate(double)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `1D2A07`, PENDING
  - Falsified if: is not slot 22 of IMFMediaEngine, HRESULT SetDefaultPlaybackRate(double Rate) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetPlaybackRate()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `63C2D3`, PENDING
  - Falsified if: is not slot 23 of IMFMediaEngine, double GetPlaybackRate(void) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetPlaybackRate(double)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `478425`, PENDING
  - Falsified if: is not slot 24 of IMFMediaEngine, HRESULT SetPlaybackRate(double Rate) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetPlayed(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `C0F99A`, PENDING
  - Falsified if: is not slot 25 of IMFMediaEngine, HRESULT GetPlayed(IMFMediaTimeRange **ppPlayed) in mfmediaengine.h, or the caller does not Release the IMFMediaTimeRange written to played
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetSeekable(out IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `B6B68E`, PENDING
  - Falsified if: is not slot 26 of IMFMediaEngine, HRESULT GetSeekable(IMFMediaTimeRange **ppSeekable) in mfmediaengine.h, or the caller does not Release the IMFMediaTimeRange written to seekable
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.IsEnded()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `4FE527`, PENDING
  - Falsified if: is not slot 27 of IMFMediaEngine, BOOL IsEnded(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetAutoPlay()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `57EAA0`, PENDING
  - Falsified if: is not slot 28 of IMFMediaEngine, BOOL GetAutoPlay(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetAutoPlay(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `FEDB7F`, PENDING
  - Falsified if: is not slot 29 of IMFMediaEngine, HRESULT SetAutoPlay(BOOL AutoPlay) in mfmediaengine.h, or autoPlay is passed narrower than the 4-byte BOOL
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetLoop()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `5CDB3E`, PENDING
  - Falsified if: is not slot 30 of IMFMediaEngine, BOOL GetLoop(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetLoop(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `992AFA`, PENDING
  - Falsified if: is not slot 31 of IMFMediaEngine, HRESULT SetLoop(BOOL Loop) in mfmediaengine.h, or loop is passed narrower than the 4-byte BOOL
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.Play()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `69F7C6`, PENDING
  - Falsified if: is not slot 32 of IMFMediaEngine, HRESULT Play(void) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.Pause()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `3DEE33`, PENDING
  - Falsified if: is not slot 33 of IMFMediaEngine, HRESULT Pause(void) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetMuted()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `5AB855`, PENDING
  - Falsified if: is not slot 34 of IMFMediaEngine, BOOL GetMuted(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetMuted(int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `07AB7B`, PENDING
  - Falsified if: is not slot 35 of IMFMediaEngine, HRESULT SetMuted(BOOL Muted) in mfmediaengine.h, or muted is passed narrower than the 4-byte BOOL
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetVolume()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `53DD7D`, PENDING
  - Falsified if: is not slot 36 of IMFMediaEngine, double GetVolume(void) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.SetVolume(double)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `A18602`, PENDING
  - Falsified if: is not slot 37 of IMFMediaEngine, HRESULT SetVolume(double Volume) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.HasVideo()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `313443`, PENDING
  - Falsified if: is not slot 38 of IMFMediaEngine, BOOL HasVideo(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.HasAudio()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `238FA6`, PENDING
  - Falsified if: is not slot 39 of IMFMediaEngine, BOOL HasAudio(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetNativeVideoSize(out uint, out uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `B5334A`, PENDING
  - Falsified if: is not slot 40 of IMFMediaEngine, HRESULT GetNativeVideoSize(DWORD *cx, DWORD *cy) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.GetVideoAspectRatio(out uint, out uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `C5F727`, PENDING
  - Falsified if: is not slot 41 of IMFMediaEngine, HRESULT GetVideoAspectRatio(DWORD *cx, DWORD *cy) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.Shutdown()` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `B383A8`, PENDING
  - Falsified if: is not slot 42 of IMFMediaEngine, HRESULT Shutdown(void) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.TransferVideoFrame(IntPtr, IntPtr, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=Critical, Spec=none cited, `037618`, PENDING
  - Falsified if: is not slot 43 of IMFMediaEngine, HRESULT TransferVideoFrame(IUnknown *pDstSurf, const MFVideoNormalizedRect *pSrc, const RECT *pDst, const MFARGB *pBorderClr) in mfmediaengine.h, or source does not address the 16-byte MFVideoNormalizedRect of four floats from mfidl.h and destination a 16-byte RECT from windef.h
- `Broiler.Native.Windows.MediaFoundation.MediaEngine.IMFMediaEngine.OnVideoStreamTick(out long)` in `src/Broiler.Native.Windows/MediaFoundation/MediaEngine/MediaFoundationNative.cs` - Security=High, Spec=none cited, `B3A83D`, PENDING
  - Falsified if: is not slot 44 of IMFMediaEngine, HRESULT OnVideoStreamTick(LONGLONG *pPts) in mfmediaengine.h
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, Spec=none cited, `48313E`, PENDING
  - Falsified if: one of its mfplat.dll imports differs from the mfapi.h prototype it binds, STDAPI MFStartup(ULONG Version, DWORD dwFlags), STDAPI MFShutdown() or STDAPI MFCreateAttributes(IMFAttributes **ppMFAttributes, UINT32 cInitialSize)
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative.MFStartup(int, int)` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, Spec=none cited, `FB247B`, PENDING
  - Falsified if: differs from STDAPI MFStartup(ULONG Version, DWORD dwFlags) in mfapi.h
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative.MFShutdown()` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, Spec=none cited, `344711`, PENDING
  - Falsified if: differs from STDAPI MFShutdown() in mfapi.h
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative.MFCreateAttributes(out IMFAttributes, uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, Spec=none cited, `A9BFE4`, PENDING
  - Falsified if: differs from STDAPI MFCreateAttributes(IMFAttributes **ppMFAttributes, UINT32 cInitialSize) in mfapi.h, or the reference written to attributes is not Released once its managed wrapper holds it
- `Broiler.Native.Windows.MediaFoundation.MediaFoundationPlatformNative.MFCreateAttributes(out IntPtr, uint)` in `src/Broiler.Native.Windows/MediaFoundation/MediaFoundationPlatformNative.cs` - Security=High, Spec=none cited, `E28897`, PENDING
  - Falsified if: differs from STDAPI MFCreateAttributes(IMFAttributes **ppMFAttributes, UINT32 cInitialSize) in mfapi.h, or the caller does not Release the IMFAttributes written to attributes
- `Broiler.Native.Windows.PerformanceCounterNative` in `src/Broiler.Native.Windows/PerformanceCounterNative.cs` - Security=High, Spec=none cited, `641D5D`, PENDING
  - Falsified if: either import differs from BOOL QueryPerformanceCounter(LARGE_INTEGER* lpPerformanceCount) or BOOL QueryPerformanceFrequency(LARGE_INTEGER* lpFrequency) in profileapi.h
- `Broiler.Native.Windows.PerformanceCounterNative.QueryPerformanceCounter(out long)` in `src/Broiler.Native.Windows/PerformanceCounterNative.cs` - Security=High, Spec=none cited, `F43BED`, PENDING
  - Falsified if: differs from BOOL QueryPerformanceCounter(LARGE_INTEGER* lpPerformanceCount) in profileapi.h, the 8-byte LARGE_INTEGER passed as an out pointer
- `Broiler.Native.Windows.PerformanceCounterNative.QueryPerformanceFrequency(out long)` in `src/Broiler.Native.Windows/PerformanceCounterNative.cs` - Security=High, Spec=none cited, `96C697`, PENDING
  - Falsified if: differs from BOOL QueryPerformanceFrequency(LARGE_INTEGER* lpFrequency) in profileapi.h, the 8-byte LARGE_INTEGER passed as an out pointer
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `C217C8`, PENDING
  - Falsified if: a member differs from its prototype in combaseapi.h (PropVariantClear), synchapi.h (CreateEventW, SetEvent, WaitForSingleObject) or handleapi.h (CloseHandle), as PropVariantClear does on x64 by passing the 16-byte PropVariant for a 24-byte PROPVARIANT
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.PropVariantClear(ref PropVariant)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `72B3B6`, PENDING
  - Falsified if: differs from WINOLEAPI PropVariantClear(PROPVARIANT *pvar) in combaseapi.h, whose pvar is the 24-byte x64 PROPVARIANT of propidl.h while Marshal.SizeOf of the PropVariant passed is 16
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.CreateEventW(IntPtr, bool, bool, string?)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `7EA6F8`, PENDING
  - Falsified if: differs from HANDLE CreateEventW(LPSECURITY_ATTRIBUTES lpEventAttributes, BOOL bManualReset, BOOL bInitialState, LPCWSTR lpName) in synchapi.h, or passes a BOOL in other than 4 bytes or lpName in other than UTF-16, or a NULL return leaves the last error uncaptured
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.SetEvent(IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `E6D39B`, PENDING
  - Falsified if: differs from BOOL SetEvent(HANDLE hEvent) in synchapi.h, or reads the BOOL in other than 4 bytes, or a FALSE return leaves the last error uncaptured
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.CloseHandle(IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `0F7F8E`, PENDING
  - Falsified if: differs from BOOL CloseHandle(HANDLE hObject) in handleapi.h, or reads the BOOL in other than 4 bytes, or a FALSE return leaves the last error uncaptured
- `Broiler.Native.Windows.Wasapi.WindowsWasapiNative.WaitForSingleObject(IntPtr, uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `75FDEC`, PENDING
  - Falsified if: differs from DWORD WaitForSingleObject(HANDLE hHandle, DWORD dwMilliseconds) in synchapi.h, or a WAIT_FAILED return leaves the last error uncaptured
- `Broiler.Native.Windows.Wasapi.PropertyKey` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `B090C8`, PENDING
  - Falsified if: Marshal.SizeOf of PropertyKey is not 20 or Marshal.OffsetOf its PropertyId is not 16, the layout of PROPERTYKEY (GUID fmtid, DWORD pid) in wtypes.h
- `Broiler.Native.Windows.Wasapi.PropVariant` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `6295F8`, PENDING
  - Falsified if: Marshal.SizeOf of PropVariant is not 24 on 64-bit and 16 on 32-bit, the size of PROPVARIANT in propidl.h, whose value union holds the ULONG-plus-pointer BLOB; today it is 16 and 12
- `Broiler.Native.Windows.Wasapi.WaveFormatEx` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `6A0461`, PENDING
  - Falsified if: Marshal.SizeOf of WaveFormatEx is not 18, or Marshal.OffsetOf SamplesPerSec and Size are not 4 and 16, the byte-packed WAVEFORMATEX of mmreg.h
- `Broiler.Native.Windows.Wasapi.WaveFormatExtensible` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `DE61A8`, PENDING
  - Falsified if: Marshal.SizeOf of WaveFormatExtensible is not 40, or Marshal.OffsetOf ValidBitsPerSample, ChannelMask and SubFormat are not 18, 20 and 24, the byte-packed WAVEFORMATEXTENSIBLE of mmreg.h
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `5E529E`, PENDING
  - Falsified if: its vtable is not the IMMDeviceEnumerator order of mmdeviceapi.h, EnumAudioEndpoints at slot 3 through UnregisterEndpointNotificationCallback at slot 7
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.EnumAudioEndpoints(EDataFlow, DeviceState, out IMMDeviceCollection)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `B02A40`, PENDING
  - Falsified if: is not slot 3 of IMMDeviceEnumerator, HRESULT EnumAudioEndpoints(EDataFlow dataFlow, DWORD dwStateMask, IMMDeviceCollection **ppDevices) in mmdeviceapi.h
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.GetDefaultAudioEndpoint(EDataFlow, ERole, out IMMDevice)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `2C427E`, PENDING
  - Falsified if: is not slot 4 of IMMDeviceEnumerator, HRESULT GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, IMMDevice **ppEndpoint) in mmdeviceapi.h
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.GetDevice(string, out IMMDevice)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `B582C9`, PENDING
  - Falsified if: is not slot 5 of IMMDeviceEnumerator, HRESULT GetDevice(LPCWSTR pwstrId, IMMDevice **ppDevice) in mmdeviceapi.h, or id reaches pwstrId as other than a NUL-terminated UTF-16 string
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.RegisterEndpointNotificationCallback(IMMNotificationClient)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `5ECB61`, PENDING
  - Falsified if: is not slot 6 of IMMDeviceEnumerator, HRESULT RegisterEndpointNotificationCallback(IMMNotificationClient *pClient) in mmdeviceapi.h
- `Broiler.Native.Windows.Wasapi.IMMDeviceEnumerator.UnregisterEndpointNotificationCallback(IMMNotificationClient)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `81112A`, PENDING
  - Falsified if: is not slot 7 of IMMDeviceEnumerator, HRESULT UnregisterEndpointNotificationCallback(IMMNotificationClient *pClient) in mmdeviceapi.h
- `Broiler.Native.Windows.Wasapi.IMMDeviceCollection` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `6ACDC0`, PENDING
  - Falsified if: its vtable is not the IMMDeviceCollection order of mmdeviceapi.h, GetCount at slot 3 and Item at slot 4
- `Broiler.Native.Windows.Wasapi.IMMDeviceCollection.GetCount(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `9DEF9C`, PENDING
  - Falsified if: is not slot 3 of IMMDeviceCollection, HRESULT GetCount(UINT *pcDevices) in mmdeviceapi.h
- `Broiler.Native.Windows.Wasapi.IMMDeviceCollection.Item(uint, out IMMDevice)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `A3EAF2`, PENDING
  - Falsified if: is not slot 4 of IMMDeviceCollection, HRESULT Item(UINT nDevice, IMMDevice **ppDevice) in mmdeviceapi.h
- `Broiler.Native.Windows.Wasapi.IMMDevice` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `37CE13`, PENDING
  - Falsified if: its vtable is not the IMMDevice order of mmdeviceapi.h, Activate at slot 3 through GetState at slot 6
- `Broiler.Native.Windows.Wasapi.IMMDevice.Activate(ref Guid, uint, IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `86ECE4`, PENDING
  - Falsified if: is not slot 3 of IMMDevice, HRESULT Activate(REFIID iid, DWORD dwClsCtx, PROPVARIANT *pActivationParams, void **ppInterface) in mmdeviceapi.h, whose reference arrives as a raw IntPtr that no marshaller releases
- `Broiler.Native.Windows.Wasapi.IMMDevice.OpenPropertyStore(StorageAccess, out IPropertyStore)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `4D668C`, PENDING
  - Falsified if: is not slot 4 of IMMDevice, HRESULT OpenPropertyStore(DWORD stgmAccess, IPropertyStore **ppProperties) in mmdeviceapi.h
- `Broiler.Native.Windows.Wasapi.IMMDevice.GetId(out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `A54561`, PENDING
  - Falsified if: is not slot 5 of IMMDevice, HRESULT GetId(LPWSTR *ppstrId) in mmdeviceapi.h, whose string arrives as a raw IntPtr the caller must free with CoTaskMemFree
- `Broiler.Native.Windows.Wasapi.IMMDevice.GetState(out DeviceState)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `2C18EF`, PENDING
  - Falsified if: is not slot 6 of IMMDevice, HRESULT GetState(DWORD *pdwState) in mmdeviceapi.h
- `Broiler.Native.Windows.Wasapi.IPropertyStore` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `079EE3`, PENDING
  - Falsified if: its vtable is not the IPropertyStore order of propsys.h, GetCount at slot 3 through Commit at slot 7
- `Broiler.Native.Windows.Wasapi.IPropertyStore.GetCount(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `39889B`, PENDING
  - Falsified if: is not slot 3 of IPropertyStore, HRESULT GetCount(DWORD *cProps) in propsys.h
- `Broiler.Native.Windows.Wasapi.IPropertyStore.GetAt(uint, out PropertyKey)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `53B7D0`, PENDING
  - Falsified if: is not slot 4 of IPropertyStore, HRESULT GetAt(DWORD iProp, PROPERTYKEY *pkey) in propsys.h, or PropertyKey is not the 20 bytes pkey receives
- `Broiler.Native.Windows.Wasapi.IPropertyStore.GetValue(ref PropertyKey, out PropVariant)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `2E7085`, PENDING
  - Falsified if: is not slot 5 of IPropertyStore, HRESULT GetValue(REFPROPERTYKEY key, PROPVARIANT *pv) in propsys.h, or PropVariant is smaller than the 24-byte x64 PROPVARIANT pv receives, as its 16 bytes are today
- `Broiler.Native.Windows.Wasapi.IPropertyStore.SetValue(ref PropertyKey, ref PropVariant)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `7DEB4C`, PENDING
  - Falsified if: is not slot 6 of IPropertyStore, HRESULT SetValue(REFPROPERTYKEY key, REFPROPVARIANT propvar) in propsys.h, or PropVariant is smaller than the 24-byte x64 PROPVARIANT propvar is read as, as its 16 bytes are today
- `Broiler.Native.Windows.Wasapi.IPropertyStore.Commit()` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `8609BA`, PENDING
  - Falsified if: is not slot 7 of IPropertyStore, HRESULT Commit(void) in propsys.h
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `2B52F8`, PENDING
  - Falsified if: its vtable is not the IMMNotificationClient order of mmdeviceapi.h, OnDeviceStateChanged at slot 3 through OnPropertyValueChanged at slot 7
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnDeviceStateChanged(string, DeviceState)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `96A9AC`, PENDING
  - Falsified if: is not slot 3 of IMMNotificationClient, HRESULT OnDeviceStateChanged(LPCWSTR pwstrDeviceId, DWORD dwNewState) in mmdeviceapi.h, or pwstrDeviceId is read as other than NUL-terminated UTF-16
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnDeviceAdded(string)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `4EA116`, PENDING
  - Falsified if: is not slot 4 of IMMNotificationClient, HRESULT OnDeviceAdded(LPCWSTR pwstrDeviceId) in mmdeviceapi.h, or pwstrDeviceId is read as other than NUL-terminated UTF-16
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnDeviceRemoved(string)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `A1017B`, PENDING
  - Falsified if: is not slot 5 of IMMNotificationClient, HRESULT OnDeviceRemoved(LPCWSTR pwstrDeviceId) in mmdeviceapi.h, or pwstrDeviceId is read as other than NUL-terminated UTF-16
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnDefaultDeviceChanged(EDataFlow, ERole, string)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `5AFB15`, PENDING
  - Falsified if: is not slot 6 of IMMNotificationClient, HRESULT OnDefaultDeviceChanged(EDataFlow flow, ERole role, LPCWSTR pwstrDefaultDeviceId) in mmdeviceapi.h, or the _In_opt_ pwstrDefaultDeviceId is declared as a non-nullable string, as it is today
- `Broiler.Native.Windows.Wasapi.IMMNotificationClient.OnPropertyValueChanged(string, PropertyKey)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `DEBD93`, PENDING
  - Falsified if: is not slot 7 of IMMNotificationClient, HRESULT OnPropertyValueChanged(LPCWSTR pwstrDeviceId, const PROPERTYKEY key) in mmdeviceapi.h, or key is taken other than by value as the 20-byte PROPERTYKEY
- `Broiler.Native.Windows.Wasapi.IAudioClient` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `85032C`, PENDING
  - Falsified if: its vtable is not the IAudioClient order of audioclient.h, Initialize at slot 3 through GetService at slot 14
- `Broiler.Native.Windows.Wasapi.IAudioClient.Initialize(AudioClientShareMode, AudioClientStreamFlags, long, long, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `8F9E64`, PENDING
  - Falsified if: is not slot 3 of IAudioClient, HRESULT Initialize(AUDCLNT_SHAREMODE ShareMode, DWORD StreamFlags, REFERENCE_TIME hnsBufferDuration, REFERENCE_TIME hnsPeriodicity, const WAVEFORMATEX *pFormat, LPCGUID AudioSessionGuid) in audioclient.h
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetBufferSize(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `7407DC`, PENDING
  - Falsified if: is not slot 4 of IAudioClient, HRESULT GetBufferSize(UINT32 *pNumBufferFrames) in audioclient.h
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetStreamLatency(out long)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `FEE5D6`, PENDING
  - Falsified if: is not slot 5 of IAudioClient, HRESULT GetStreamLatency(REFERENCE_TIME *phnsLatency) in audioclient.h
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetCurrentPadding(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `B5581D`, PENDING
  - Falsified if: is not slot 6 of IAudioClient, HRESULT GetCurrentPadding(UINT32 *pNumPaddingFrames) in audioclient.h
- `Broiler.Native.Windows.Wasapi.IAudioClient.IsFormatSupported(AudioClientShareMode, IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `9D437E`, PENDING
  - Falsified if: is not slot 7 of IAudioClient, HRESULT IsFormatSupported(AUDCLNT_SHAREMODE ShareMode, const WAVEFORMATEX *pFormat, WAVEFORMATEX **ppClosestMatch) in audioclient.h, whose closest match arrives as a raw IntPtr the caller must free with CoTaskMemFree
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetMixFormat(out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `EB4C3A`, PENDING
  - Falsified if: is not slot 8 of IAudioClient, HRESULT GetMixFormat(WAVEFORMATEX **ppDeviceFormat) in audioclient.h, whose format block arrives as a raw IntPtr the caller must free with CoTaskMemFree
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetDevicePeriod(out long, out long)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `C6E8C9`, PENDING
  - Falsified if: is not slot 9 of IAudioClient, HRESULT GetDevicePeriod(REFERENCE_TIME *phnsDefaultDevicePeriod, REFERENCE_TIME *phnsMinimumDevicePeriod) in audioclient.h
- `Broiler.Native.Windows.Wasapi.IAudioClient.Start()` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `6B8586`, PENDING
  - Falsified if: is not slot 10 of IAudioClient, HRESULT Start(void) in audioclient.h
- `Broiler.Native.Windows.Wasapi.IAudioClient.Stop()` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `458393`, PENDING
  - Falsified if: is not slot 11 of IAudioClient, HRESULT Stop(void) in audioclient.h
- `Broiler.Native.Windows.Wasapi.IAudioClient.Reset()` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `C17181`, PENDING
  - Falsified if: is not slot 12 of IAudioClient, HRESULT Reset(void) in audioclient.h
- `Broiler.Native.Windows.Wasapi.IAudioClient.SetEventHandle(IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `A5695E`, PENDING
  - Falsified if: is not slot 13 of IAudioClient, HRESULT SetEventHandle(HANDLE eventHandle) in audioclient.h
- `Broiler.Native.Windows.Wasapi.IAudioClient.GetService(ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `DCDAC0`, PENDING
  - Falsified if: is not slot 14 of IAudioClient, HRESULT GetService(REFIID riid, void **ppv) in audioclient.h, whose reference arrives as a raw IntPtr that no marshaller releases
- `Broiler.Native.Windows.Wasapi.IAudioCaptureClient` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `E6F0E2`, PENDING
  - Falsified if: its vtable is not the IAudioCaptureClient order of audioclient.h, GetBuffer at slot 3 through GetNextPacketSize at slot 5
- `Broiler.Native.Windows.Wasapi.IAudioCaptureClient.GetBuffer(out IntPtr, out uint, out AudioClientBufferFlags, out ulong, out ulong)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `BE96C9`, PENDING
  - Falsified if: is not slot 3 of IAudioCaptureClient, HRESULT GetBuffer(BYTE **ppData, UINT32 *pNumFramesToRead, DWORD *pdwFlags, UINT64 *pu64DevicePosition, UINT64 *pu64QPCPosition) in audioclient.h, whose ppData holds only *pNumFramesToRead times nBlockAlign bytes
- `Broiler.Native.Windows.Wasapi.IAudioCaptureClient.ReleaseBuffer(uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `D3903A`, PENDING
  - Falsified if: is not slot 4 of IAudioCaptureClient, HRESULT ReleaseBuffer(UINT32 NumFramesRead) in audioclient.h
- `Broiler.Native.Windows.Wasapi.IAudioCaptureClient.GetNextPacketSize(out uint)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=High, Spec=none cited, `6EB7A4`, PENDING
  - Falsified if: is not slot 5 of IAudioCaptureClient, HRESULT GetNextPacketSize(UINT32 *pNumFramesInNextPacket) in audioclient.h
- `Broiler.Native.Windows.Wasapi.WasapiExtensions` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `D28A8B`, PENDING
  - Falsified if: Activate and GetService never release the native reference their COM call returned once GetOrCreateComObject has taken its own, so each call leaks one COM reference
- `Broiler.Native.Windows.Wasapi.WasapiExtensions.Activate<TInterface>(this IMMDevice, uint, IntPtr, out TInterface?)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `E4FA3E`, PENDING
  - Falsified if: the pointer IMMDevice.Activate returns with S_OK is wrapped by GetOrCreateComObject, which takes its own reference, and is never released, so every call leaks one reference to the activated object
- `Broiler.Native.Windows.Wasapi.WasapiExtensions.GetService<TInterface>(this IAudioClient, out TInterface?)` in `src/Broiler.Native.Windows/Wasapi/WindowsWasapiNative.cs` - Security=Critical, Spec=none cited, `1D2EA0`, PENDING
  - Falsified if: the pointer IAudioClient.GetService returns with S_OK is wrapped by GetOrCreateComObject, which takes its own reference, and is never released, so every call leaks one reference to the service object
- `Broiler.Native.Windows.Wic.WicNative` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `5EFA14`, PENDING
  - Falsified if: a nested interface differs from its wincodec.h declaration of IWICBitmapFrameDecode, IWICFormatConverter, IWICBitmapDecoder or IWICImagingFactory in slot order or in a member prototype
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `1783FD`, PENDING
  - Falsified if: its vtable is not the IWICBitmapFrameDecode order of wincodec.h, IWICBitmapSource GetSize at slot 3 through CopyPixels at slot 7, then GetMetadataQueryReader at slot 8 through GetThumbnail at slot 10
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetSize(out uint, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `7C536B`, PENDING
  - Falsified if: is not slot 3 of IWICBitmapFrameDecode, HRESULT GetSize(UINT *puiWidth, UINT *puiHeight) of IWICBitmapSource in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetPixelFormat(out Guid)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `69EFDA`, PENDING
  - Falsified if: is not slot 4 of IWICBitmapFrameDecode, HRESULT GetPixelFormat(WICPixelFormatGUID *pPixelFormat) of IWICBitmapSource in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetResolution(out double, out double)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `2054F8`, PENDING
  - Falsified if: is not slot 5 of IWICBitmapFrameDecode, HRESULT GetResolution(double *pDpiX, double *pDpiY) of IWICBitmapSource in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.CopyPalette(IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `ACA555`, PENDING
  - Falsified if: is not slot 6 of IWICBitmapFrameDecode, HRESULT CopyPalette(IWICPalette *pIPalette) of IWICBitmapSource in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.CopyPixels(IntPtr, uint, uint, IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `19BB8D`, PENDING
  - Falsified if: is not slot 7 of IWICBitmapFrameDecode, HRESULT CopyPixels(const WICRect *prc, UINT cbStride, UINT cbBufferSize, BYTE *pbBuffer) of IWICBitmapSource in wincodec.h, or pbBuffer holds fewer than the cbBufferSize bytes passed with it
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetMetadataQueryReader(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `5B4345`, PENDING
  - Falsified if: is not slot 8 of IWICBitmapFrameDecode, HRESULT GetMetadataQueryReader(IWICMetadataQueryReader **ppIMetadataQueryReader) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetColorContexts(uint, IntPtr, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `2E33A1`, PENDING
  - Falsified if: is not slot 9 of IWICBitmapFrameDecode, HRESULT GetColorContexts(UINT cCount, IWICColorContext **ppIColorContexts, UINT *pcActualCount) in wincodec.h, or ppIColorContexts holds fewer than cCount pointers
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapFrameDecode.GetThumbnail(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `F83FCD`, PENDING
  - Falsified if: is not slot 10 of IWICBitmapFrameDecode, HRESULT GetThumbnail(IWICBitmapSource **ppIThumbnail) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `EBC48E`, PENDING
  - Falsified if: its vtable is not the IWICFormatConverter order of wincodec.h, IWICBitmapSource GetSize at slot 3 through CopyPixels at slot 7, then Initialize at slot 8 and CanConvert at slot 9
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.GetSize(out uint, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `7C536B`, PENDING
  - Falsified if: is not slot 3 of IWICFormatConverter, HRESULT GetSize(UINT *puiWidth, UINT *puiHeight) of IWICBitmapSource in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.GetPixelFormat(out Guid)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `69EFDA`, PENDING
  - Falsified if: is not slot 4 of IWICFormatConverter, HRESULT GetPixelFormat(WICPixelFormatGUID *pPixelFormat) of IWICBitmapSource in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.GetResolution(out double, out double)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `2054F8`, PENDING
  - Falsified if: is not slot 5 of IWICFormatConverter, HRESULT GetResolution(double *pDpiX, double *pDpiY) of IWICBitmapSource in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.CopyPalette(IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `ACA555`, PENDING
  - Falsified if: is not slot 6 of IWICFormatConverter, HRESULT CopyPalette(IWICPalette *pIPalette) of IWICBitmapSource in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.CopyPixels(IntPtr, uint, uint, IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `19BB8D`, PENDING
  - Falsified if: is not slot 7 of IWICFormatConverter, HRESULT CopyPixels(const WICRect *prc, UINT cbStride, UINT cbBufferSize, BYTE *pbBuffer) of IWICBitmapSource in wincodec.h, or pbBuffer holds fewer than the cbBufferSize bytes passed with it
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.Initialize(IWICBitmapFrameDecode, ref Guid, int, IntPtr, double, int)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `F22BAE`, PENDING
  - Falsified if: is not slot 8 of IWICFormatConverter, HRESULT Initialize(IWICBitmapSource *pISource, REFWICPixelFormatGUID dstFormat, WICBitmapDitherType dither, IWICPalette *pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate) in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICFormatConverter.CanConvert(ref Guid, ref Guid, out int)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `C957AB`, PENDING
  - Falsified if: is not slot 9 of IWICFormatConverter, HRESULT CanConvert(REFWICPixelFormatGUID srcPixelFormat, REFWICPixelFormatGUID dstPixelFormat, BOOL *pfCanConvert) in wincodec.h, or pfCanConvert is received in other than the 4 bytes of a BOOL
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `F3A325`, PENDING
  - Falsified if: its vtable is not the IWICBitmapDecoder order of wincodec.h, QueryCapability at slot 3 through GetFrame at slot 13
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.QueryCapability(IStream, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `E9B82A`, PENDING
  - Falsified if: is not slot 3 of IWICBitmapDecoder, HRESULT QueryCapability(IStream *pIStream, DWORD *pdwCapability) in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.Initialize(IStream, int)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `BFEDCC`, PENDING
  - Falsified if: is not slot 4 of IWICBitmapDecoder, HRESULT Initialize(IStream *pIStream, WICDecodeOptions cacheOptions) in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetContainerFormat(out Guid)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `DCE272`, PENDING
  - Falsified if: is not slot 5 of IWICBitmapDecoder, HRESULT GetContainerFormat(GUID *pguidContainerFormat) in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetDecoderInfo(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `51BF48`, PENDING
  - Falsified if: is not slot 6 of IWICBitmapDecoder, HRESULT GetDecoderInfo(IWICBitmapDecoderInfo **ppIDecoderInfo) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.CopyPalette(IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `ACA555`, PENDING
  - Falsified if: is not slot 7 of IWICBitmapDecoder, HRESULT CopyPalette(IWICPalette *pIPalette) in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetMetadataQueryReader(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `5B4345`, PENDING
  - Falsified if: is not slot 8 of IWICBitmapDecoder, HRESULT GetMetadataQueryReader(IWICMetadataQueryReader **ppIMetadataQueryReader) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetPreview(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `E2D6CB`, PENDING
  - Falsified if: is not slot 9 of IWICBitmapDecoder, HRESULT GetPreview(IWICBitmapSource **ppIBitmapSource) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetColorContexts(uint, IntPtr, out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `2E33A1`, PENDING
  - Falsified if: is not slot 10 of IWICBitmapDecoder, HRESULT GetColorContexts(UINT cCount, IWICColorContext **ppIColorContexts, UINT *pcActualCount) in wincodec.h, or ppIColorContexts holds fewer than cCount pointers
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetThumbnail(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `F83FCD`, PENDING
  - Falsified if: is not slot 11 of IWICBitmapDecoder, HRESULT GetThumbnail(IWICBitmapSource **ppIThumbnail) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetFrameCount(out uint)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `C7763B`, PENDING
  - Falsified if: is not slot 12 of IWICBitmapDecoder, HRESULT GetFrameCount(UINT *pCount) in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICBitmapDecoder.GetFrame(uint, out IWICBitmapFrameDecode)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `ABCC93`, PENDING
  - Falsified if: is not slot 13 of IWICBitmapDecoder, HRESULT GetFrame(UINT index, IWICBitmapFrameDecode **ppIBitmapFrame) in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `A8CD55`, PENDING
  - Falsified if: its first slots are not the IWICImagingFactory order of wincodec.h, CreateDecoderFromFilename at slot 3 through CreateFormatConverter at slot 10
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateDecoderFromFilename(string, IntPtr, uint, int, out IWICBitmapDecoder)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `777C84`, PENDING
  - Falsified if: is not slot 3 of IWICImagingFactory, HRESULT CreateDecoderFromFilename(LPCWSTR wzFilename, const GUID *pguidVendor, DWORD dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder **ppIDecoder) in wincodec.h, or wzFilename is marshalled as other than NUL-terminated UTF-16
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateDecoderFromStream(IStream, IntPtr, int, out IWICBitmapDecoder)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `A96950`, PENDING
  - Falsified if: is not slot 4 of IWICImagingFactory, HRESULT CreateDecoderFromStream(IStream *pIStream, const GUID *pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder **ppIDecoder) in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateDecoderFromFileHandle(IntPtr, IntPtr, int, out IWICBitmapDecoder)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `0FCBE9`, PENDING
  - Falsified if: is not slot 5 of IWICImagingFactory, HRESULT CreateDecoderFromFileHandle(ULONG_PTR hFile, const GUID *pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder **ppIDecoder) in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateComponentInfo(ref Guid, out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `84A58A`, PENDING
  - Falsified if: is not slot 6 of IWICImagingFactory, HRESULT CreateComponentInfo(REFCLSID clsidComponent, IWICComponentInfo **ppIInfo) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateDecoder(ref Guid, IntPtr, out IWICBitmapDecoder)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `B0ED40`, PENDING
  - Falsified if: is not slot 7 of IWICImagingFactory, HRESULT CreateDecoder(REFGUID guidContainerFormat, const GUID *pguidVendor, IWICBitmapDecoder **ppIDecoder) in wincodec.h
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateEncoder(ref Guid, IntPtr, out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=Critical, Spec=none cited, `F89366`, PENDING
  - Falsified if: is not slot 8 of IWICImagingFactory, HRESULT CreateEncoder(REFGUID guidContainerFormat, const GUID *pguidVendor, IWICBitmapEncoder **ppIEncoder) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreatePalette(out IntPtr)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `592ED9`, PENDING
  - Falsified if: is not slot 9 of IWICImagingFactory, HRESULT CreatePalette(IWICPalette **ppIPalette) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
- `Broiler.Native.Windows.Wic.WicNative.IWICImagingFactory.CreateFormatConverter(out IWICFormatConverter)` in `src/Broiler.Native.Windows/Wic/WicNative.cs` - Security=High, Spec=none cited, `903F42`, PENDING
  - Falsified if: is not slot 10 of IWICImagingFactory, HRESULT CreateFormatConverter(IWICFormatConverter **ppIFormatConverter) in wincodec.h
- `Broiler.Native.Windows.WindowNative` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `3B0E79`, PENDING
  - Falsified if: GetWindowText(IntPtr, Span<char>) passes a count other than text.Length to GetWindowTextW, so a title longer than the span is written past its end
- `Broiler.Native.Windows.WindowNative.SetWindowLongPtr(IntPtr, int, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `16DDCC`, PENDING
  - Falsified if: on a 64-bit process the call reaches SetWindowLongW rather than SetWindowLongPtrW, so the GCHandle pointer stored at GWLP_USERDATA keeps only its low 32 bits and GCHandle.FromIntPtr later resolves a truncated handle
- `Broiler.Native.Windows.WindowNative.GetWindowLongPtr(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `DD2B69`, PENDING
  - Falsified if: on a 64-bit process the call reaches GetWindowLongW rather than GetWindowLongPtrW, so the GWLP_USERDATA pointer read back is sign-extended from 32 bits and GCHandle.FromIntPtr dereferences a different handle
- `Broiler.Native.Windows.WindowNative.GetClassLongPtr(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `D4D0DB`, PENDING
  - Falsified if: on a 64-bit process the call reaches GetClassLongW rather than GetClassLongPtrW, so the GCLP_HICON value read back loses its high 32 bits and no longer equals the icon the class registered
- `Broiler.Native.Windows.WindowNative.WndProc` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `AE2EBF`, PENDING
  - Falsified if: differs from typedef LRESULT (CALLBACK* WNDPROC)(HWND, UINT, WPARAM, LPARAM) in winuser.h, CALLBACK being stdcall on 32-bit x86
- `Broiler.Native.Windows.WindowNative.WNDCLASSEX` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `637957`, PENDING
  - Falsified if: Marshal.SizeOf is not 80 on 64-bit (48 on 32-bit) or, on 64-bit, LpfnWndProc is not at offset 8 and LpszClassName at 64, the layout of WNDCLASSEXW in winuser.h
- `Broiler.Native.Windows.WindowNative.RECT` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `563E6D`, PENDING
  - Falsified if: Marshal.SizeOf is not 16 or Left, Top, Right and Bottom are not at offsets 0, 4, 8 and 12, the layout of RECT (LONG left, top, right, bottom) in windef.h
- `Broiler.Native.Windows.WindowNative.POINT` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `AA2E46`, PENDING
  - Falsified if: Marshal.SizeOf is not 8 or Y is not at offset 4, the layout of POINT (LONG x, LONG y) in windef.h
- `Broiler.Native.Windows.WindowNative.TRACKMOUSEEVENT` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `E547C3`, PENDING
  - Falsified if: Marshal.SizeOf is not 24 on 64-bit (16 on 32-bit) or HwndTrack is not at offset 8, the layout of TRACKMOUSEEVENT (DWORD cbSize, DWORD dwFlags, HWND hwndTrack, DWORD dwHoverTime) in winuser.h
- `Broiler.Native.Windows.WindowNative.MSG` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `2C3C7D`, PENDING
  - Falsified if: Marshal.SizeOf is not 48 on 64-bit (28 on 32-bit) or, on 64-bit, LParam is not at offset 24 and Pt at 36, the layout of MSG (HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam, DWORD time, POINT pt) in winuser.h
- `Broiler.Native.Windows.WindowNative.CREATESTRUCT` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `39F0BA`, PENDING
  - Falsified if: Marshal.SizeOf is not 80 on 64-bit (48 on 32-bit), LpCreateParams is not at offset 0 or, on 64-bit, LpszName is not at 56, the layout of CREATESTRUCTW in winuser.h
- `Broiler.Native.Windows.WindowNative.GetModuleHandle(string?)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `150856`, PENDING
  - Falsified if: differs from HMODULE GetModuleHandleW(LPCWSTR lpModuleName) in libloaderapi.h, where moduleName must arrive as a UTF-16 pointer and a null moduleName as a null pointer rather than an empty string
- `Broiler.Native.Windows.WindowNative.RegisterClassEx(ref WNDCLASSEX)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `2D2FB1`, PENDING
  - Falsified if: differs from ATOM RegisterClassExW(CONST WNDCLASSEXW *) in winuser.h, CharSet.Unicode binding the W export and the struct passed by pointer with UTF-16 lpszMenuName and lpszClassName
- `Broiler.Native.Windows.WindowNative.CreateWindowEx(uint, string, string, uint, int, int, int, int, IntPtr, IntPtr, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `B8CB64`, PENDING
  - Falsified if: differs from HWND CreateWindowExW(DWORD dwExStyle, LPCWSTR lpClassName, LPCWSTR lpWindowName, DWORD dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, LPVOID lpParam) in winuser.h, both strings passed as UTF-16
- `Broiler.Native.Windows.WindowNative.AdjustWindowRectEx(ref RECT, uint, bool, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `C0C181`, PENDING
  - Falsified if: differs from BOOL AdjustWindowRectEx(LPRECT lpRect, DWORD dwStyle, BOOL bMenu, DWORD dwExStyle) in winuser.h, with bMenu and the result marshalled as a 4-byte BOOL
- `Broiler.Native.Windows.WindowNative.AdjustWindowRectExForDpi(ref RECT, uint, bool, uint, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `6C102F`, PENDING
  - Falsified if: differs from BOOL AdjustWindowRectExForDpi(LPRECT lpRect, DWORD dwStyle, BOOL bMenu, DWORD dwExStyle, UINT dpi) in winuser.h, with bMenu and the result marshalled as a 4-byte BOOL
- `Broiler.Native.Windows.WindowNative.GetSystemMetrics(int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `BF4309`, PENDING
  - Falsified if: differs from int GetSystemMetrics(int nIndex) in winuser.h
- `Broiler.Native.Windows.WindowNative.ShowWindow(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `BCA376`, PENDING
  - Falsified if: differs from BOOL ShowWindow(HWND hWnd, int nCmdShow) in winuser.h, with the result marshalled as a 4-byte BOOL
- `Broiler.Native.Windows.WindowNative.UpdateWindow(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `59BCAA`, PENDING
  - Falsified if: differs from BOOL UpdateWindow(HWND hWnd) in winuser.h, with the result marshalled as a 4-byte BOOL
- `Broiler.Native.Windows.WindowNative.GetMessage(out MSG, IntPtr, uint, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `91B735`, PENDING
  - Falsified if: differs from BOOL GetMessageW(LPMSG lpMsg, HWND hWnd, UINT wMsgFilterMin, UINT wMsgFilterMax) in winuser.h, whose BOOL result can be -1 and so must stay an int rather than a marshalled bool
- `Broiler.Native.Windows.WindowNative.TranslateMessage(ref MSG)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `9CEEB7`, PENDING
  - Falsified if: differs from BOOL TranslateMessage(CONST MSG *lpMsg) in winuser.h, the MSG passed by pointer and the result marshalled as a 4-byte BOOL
- `Broiler.Native.Windows.WindowNative.DispatchMessage(ref MSG)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `4EEAC8`, PENDING
  - Falsified if: differs from LRESULT DispatchMessageW(CONST MSG *lpMsg) in winuser.h, the MSG passed by pointer
- `Broiler.Native.Windows.WindowNative.DefWindowProc(IntPtr, uint, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `6D1BFB`, PENDING
  - Falsified if: differs from LRESULT DefWindowProcW(HWND hWnd, UINT Msg, WPARAM wParam, LPARAM lParam) in winuser.h
- `Broiler.Native.Windows.WindowNative.PostQuitMessage(int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `28D17C`, PENDING
  - Falsified if: differs from VOID PostQuitMessage(int nExitCode) in winuser.h
- `Broiler.Native.Windows.WindowNative.PostMessage(IntPtr, uint, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `785298`, PENDING
  - Falsified if: differs from BOOL PostMessageW(HWND hWnd, UINT Msg, WPARAM wParam, LPARAM lParam) in winuser.h
- `Broiler.Native.Windows.WindowNative.InvalidateRect(IntPtr, IntPtr, bool)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `11E879`, PENDING
  - Falsified if: differs from BOOL InvalidateRect(HWND hWnd, CONST RECT *lpRect, BOOL bErase) in winuser.h, with bErase and the result marshalled as a 4-byte BOOL
- `Broiler.Native.Windows.WindowNative.ValidateRect(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `3194D3`, PENDING
  - Falsified if: differs from BOOL ValidateRect(HWND hWnd, CONST RECT *lpRect) in winuser.h
- `Broiler.Native.Windows.WindowNative.MoveWindow(IntPtr, int, int, int, int, bool)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `19633F`, PENDING
  - Falsified if: differs from BOOL MoveWindow(HWND hWnd, int X, int Y, int nWidth, int nHeight, BOOL bRepaint) in winuser.h, with bRepaint and the result marshalled as a 4-byte BOOL
- `Broiler.Native.Windows.WindowNative.DestroyWindow(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `005B01`, PENDING
  - Falsified if: differs from BOOL DestroyWindow(HWND hWnd) in winuser.h, imported with SetLastError so the error code read after a failure is this call's own
- `Broiler.Native.Windows.WindowNative.GetParent(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `E7F331`, PENDING
  - Falsified if: differs from HWND GetParent(HWND hWnd) in winuser.h
- `Broiler.Native.Windows.WindowNative.SetTimer(IntPtr, nuint, uint, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `3A2024`, PENDING
  - Falsified if: differs from UINT_PTR SetTimer(HWND hWnd, UINT_PTR nIDEvent, UINT uElapse, TIMERPROC lpTimerFunc) in winuser.h
- `Broiler.Native.Windows.WindowNative.KillTimer(IntPtr, nuint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `24FCA7`, PENDING
  - Falsified if: differs from BOOL KillTimer(HWND hWnd, UINT_PTR uIDEvent) in winuser.h
- `Broiler.Native.Windows.WindowNative.SetFocus(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `AD9CC7`, PENDING
  - Falsified if: differs from HWND SetFocus(HWND hWnd) in winuser.h
- `Broiler.Native.Windows.WindowNative.GetKeyState(int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `54C5B0`, PENDING
  - Falsified if: differs from SHORT GetKeyState(int nVirtKey) in winuser.h
- `Broiler.Native.Windows.WindowNative.ScreenToClient(IntPtr, ref POINT)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `D0E8CE`, PENDING
  - Falsified if: differs from BOOL ScreenToClient(HWND hWnd, LPPOINT lpPoint) in winuser.h, the 8-byte POINT passed by pointer and written back
- `Broiler.Native.Windows.WindowNative.TrackMouseEvent(ref TRACKMOUSEEVENT)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `0C9D2E`, PENDING
  - Falsified if: differs from BOOL TrackMouseEvent(LPTRACKMOUSEEVENT lpEventTrack) in winuser.h, the TRACKMOUSEEVENT passed by pointer
- `Broiler.Native.Windows.WindowNative.GetClientRect(IntPtr, out RECT)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `212BE0`, PENDING
  - Falsified if: differs from BOOL GetClientRect(HWND hWnd, LPRECT lpRect) in winuser.h, the 16-byte RECT passed as an out pointer
- `Broiler.Native.Windows.WindowNative.GetDpiForWindow(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `81749E`, PENDING
  - Falsified if: differs from UINT GetDpiForWindow(HWND hwnd) in winuser.h
- `Broiler.Native.Windows.WindowNative.GetDC(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `58339A`, PENDING
  - Falsified if: differs from HDC GetDC(HWND hWnd) in winuser.h, whose returned DC the caller holds until ReleaseDC
- `Broiler.Native.Windows.WindowNative.ReleaseDC(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `089DAA`, PENDING
  - Falsified if: differs from int ReleaseDC(HWND hWnd, HDC hDC) in winuser.h
- `Broiler.Native.Windows.WindowNative.GetDeviceCaps(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `A5C5DC`, PENDING
  - Falsified if: differs from int GetDeviceCaps(HDC hdc, int index) in wingdi.h
- `Broiler.Native.Windows.WindowNative.LoadCursor(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `178AF0`, PENDING
  - Falsified if: differs from HCURSOR LoadCursorW(HINSTANCE hInstance, LPCWSTR lpCursorName) in winuser.h, with lpCursorName carried as a MAKEINTRESOURCE integer in a pointer-sized IntPtr rather than a marshalled string
- `Broiler.Native.Windows.WindowNative.LoadIcon(IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `C66880`, PENDING
  - Falsified if: differs from HICON LoadIconW(HINSTANCE hInstance, LPCWSTR lpIconName) in winuser.h, with lpIconName carried as a MAKEINTRESOURCE integer in a pointer-sized IntPtr rather than a marshalled string
- `Broiler.Native.Windows.WindowNative.GetSysColorBrush(int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `CDE6AD`, PENDING
  - Falsified if: differs from HBRUSH GetSysColorBrush(int nIndex) in winuser.h
- `Broiler.Native.Windows.WindowNative.SetWindowLongPtr64(IntPtr, int, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `0ACA59`, PENDING
  - Falsified if: differs from LONG_PTR SetWindowLongPtrW(HWND hWnd, int nIndex, LONG_PTR dwNewLong) in winuser.h, which declares that export only under _WIN64
- `Broiler.Native.Windows.WindowNative.SetWindowLong32(IntPtr, int, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `B10A49`, PENDING
  - Falsified if: differs from LONG SetWindowLongW(HWND hWnd, int nIndex, LONG dwNewLong) in winuser.h
- `Broiler.Native.Windows.WindowNative.GetWindowLongPtr64(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `5B314E`, PENDING
  - Falsified if: differs from LONG_PTR GetWindowLongPtrW(HWND hWnd, int nIndex) in winuser.h, which declares that export only under _WIN64
- `Broiler.Native.Windows.WindowNative.GetWindowLong32(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `EDCE2B`, PENDING
  - Falsified if: differs from LONG GetWindowLongW(HWND hWnd, int nIndex) in winuser.h
- `Broiler.Native.Windows.WindowNative.GetClassLongPtr64(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `3B4FE6`, PENDING
  - Falsified if: differs from ULONG_PTR GetClassLongPtrW(HWND hWnd, int nIndex) in winuser.h, which declares that export only under _WIN64
- `Broiler.Native.Windows.WindowNative.GetClassLong32(IntPtr, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `3B5E17`, PENDING
  - Falsified if: differs from DWORD GetClassLongW(HWND hWnd, int nIndex) in winuser.h
- `Broiler.Native.Windows.WindowNative.SetWindowText(IntPtr, string)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `D43A2E`, PENDING
  - Falsified if: differs from BOOL SetWindowTextW(HWND hWnd, LPCWSTR lpString) in winuser.h, the title passed as a null-terminated UTF-16 string
- `Broiler.Native.Windows.WindowNative.SendMessage(IntPtr, uint, IntPtr, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `A75408`, PENDING
  - Falsified if: differs from LRESULT SendMessageW(HWND hWnd, UINT Msg, WPARAM wParam, LPARAM lParam) in winuser.h
- `Broiler.Native.Windows.WindowNative.ReleaseCapture()` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `4BCCEF`, PENDING
  - Falsified if: differs from BOOL ReleaseCapture(VOID) in winuser.h
- `Broiler.Native.Windows.WindowNative.IsIconic(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `A814E8`, PENDING
  - Falsified if: differs from BOOL IsIconic(HWND hWnd) in winuser.h, with the result marshalled as a 4-byte BOOL
- `Broiler.Native.Windows.WindowNative.IsZoomed(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `6E1CF7`, PENDING
  - Falsified if: differs from BOOL IsZoomed(HWND hWnd) in winuser.h, with the result marshalled as a 4-byte BOOL
- `Broiler.Native.Windows.WindowNative.GetWindowRect(IntPtr, out RECT)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `7E4EBC`, PENDING
  - Falsified if: differs from BOOL GetWindowRect(HWND hWnd, LPRECT lpRect) in winuser.h, the 16-byte RECT passed as an out pointer
- `Broiler.Native.Windows.WindowNative.MonitorFromWindow(IntPtr, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `E8219B`, PENDING
  - Falsified if: differs from HMONITOR MonitorFromWindow(HWND hwnd, DWORD dwFlags) in winuser.h
- `Broiler.Native.Windows.WindowNative.GetMonitorInfo(IntPtr, ref MONITORINFO)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `7EA744`, PENDING
  - Falsified if: differs from BOOL GetMonitorInfoW(HMONITOR hMonitor, LPMONITORINFO lpmi) in winuser.h, the 40-byte MONITORINFO passed by pointer, which a cbSize of 104 (MONITORINFOEXW) would overrun
- `Broiler.Native.Windows.WindowNative.DestroyIcon(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `9BE911`, PENDING
  - Falsified if: differs from BOOL DestroyIcon(HICON hIcon) in winuser.h, with the result marshalled as a 4-byte BOOL
- `Broiler.Native.Windows.WindowNative.CreateIconIndirect(ref ICONINFO)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `86BA93`, PENDING
  - Falsified if: differs from HICON CreateIconIndirect(PICONINFO piconinfo) in winuser.h, the ICONINFO passed by pointer and the returned HICON held by the caller until DestroyIcon
- `Broiler.Native.Windows.WindowNative.CreateDIBSection(IntPtr, ref BITMAPINFOHEADER, uint, out IntPtr, IntPtr, uint)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `9DDFFE`, PENDING
  - Falsified if: differs from HBITMAP CreateDIBSection(HDC hdc, CONST BITMAPINFO *pbmi, UINT usage, VOID **ppvBits, HANDLE hSection, DWORD offset) in wingdi.h, where passing only the 40-byte BITMAPINFOHEADER holds only while biBitCount is above 8 and biCompression is BI_RGB
- `Broiler.Native.Windows.WindowNative.CreateBitmap(int, int, uint, uint, IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `C60669`, PENDING
  - Falsified if: differs from HBITMAP CreateBitmap(int nWidth, int nHeight, UINT nPlanes, UINT nBitCount, CONST VOID *lpBits) in wingdi.h
- `Broiler.Native.Windows.WindowNative.DeleteObject(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `C1D6A1`, PENDING
  - Falsified if: differs from BOOL DeleteObject(HGDIOBJ ho) in wingdi.h
- `Broiler.Native.Windows.WindowNative.MONITORINFO` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `85EE60`, PENDING
  - Falsified if: Marshal.SizeOf is not 40 or RcWork is not at offset 20 and DwFlags at 36, the layout of MONITORINFO (DWORD cbSize, RECT rcMonitor, RECT rcWork, DWORD dwFlags) in winuser.h
- `Broiler.Native.Windows.WindowNative.ICONINFO` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `3ED120`, PENDING
  - Falsified if: Marshal.SizeOf is not 32 on 64-bit (20 on 32-bit) or HbmMask is not at offset 16 (12 on 32-bit), the layout of ICONINFO (BOOL fIcon, DWORD xHotspot, DWORD yHotspot, HBITMAP hbmMask, HBITMAP hbmColor) in winuser.h
- `Broiler.Native.Windows.WindowNative.BITMAPINFOHEADER` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `C8BD94`, PENDING
  - Falsified if: Marshal.SizeOf is not 40 or BiBitCount is not at offset 14 and BiCompression at 16, the layout of BITMAPINFOHEADER in wingdi.h
- `Broiler.Native.Windows.WindowNative.SetProcessDpiAwarenessContext(IntPtr)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=High, Spec=none cited, `F83A05`, PENDING
  - Falsified if: differs from BOOL SetProcessDpiAwarenessContext(DPI_AWARENESS_CONTEXT value) in winuser.h, the context passed as the pointer-sized handle windef.h declares
- `Broiler.Native.Windows.WindowNative.GetWindowText(IntPtr, char*, int)` in `src/Broiler.Native.Windows/WindowNative.cs` - Security=Critical, Spec=none cited, `139E0E`, PENDING
  - Falsified if: differs from int GetWindowTextW(HWND hWnd, LPWSTR lpString, int nMaxCount) in winuser.h, where nMaxCount counts the UTF-16 chars lpString can hold, terminator included
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
