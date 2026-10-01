// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   46
// Annotated:        46/46
// Exempt:           0
// Human-reviewed:   0/46
// IP risk:          Low
// Security risk:    Critical
// Criteria:         46/19
// Resource impact:  5/10 max
// Unverified:       46
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Android;

/// <summary>
/// EGL entry points and constants used by the Android presentation backend.
/// </summary>
/// <remarks>
/// The shape mirrors the Linux EGL binding, but three things differ and all three are load-bearing:
/// Android binds the ES API rather than desktop GL (<see cref="EGL_OPENGL_ES_API"/> instead of
/// <c>EGL_OPENGL_API</c>), configs must request <see cref="EGL_OPENGL_ES3_BIT"/> instead of
/// <c>EGL_OPENGL_BIT</c>, and the library soname has no <c>.1</c> suffix. Getting any of them wrong
/// produces an <c>eglChooseConfig</c> or <c>eglCreateContext</c> failure that is hard to read.
/// </remarks>
// Broiler-AI:           Origin=AI; Spec=ADR-0001; IP=Low; Security=Critical; Resources=5; Fingerprint=CCDC42
// Broiler-Falsified-If: ChooseConfig's configs array is not of pointer-sized EGLConfig handles, so on a 64-bit device eglChooseConfig writes 8-byte handles past the end of the pinned array
// Broiler-Human:        PENDING
public static partial class AndroidEglNative
{
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=EEE3BF
    // Broiler-Falsified-If: EGL_FALSE is not 0, so an EGLBoolean failure from eglMakeCurrent or eglSwapBuffers compares unequal to it and is taken as success
    // Broiler-Human:        PENDING
    public const int EGL_FALSE = 0;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=20CED0
    // Broiler-Falsified-If: EGL_TRUE is not 1, so a caller comparing an EGLBoolean return against it treats a successful EGL call as a failure
    // Broiler-Human:        PENDING
    public const int EGL_TRUE = 1;

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=234B24
    // Broiler-Falsified-If: EGL_NO_DISPLAY is not the null pointer, so a failed eglGetDisplay is not recognised and its zero handle reaches eglInitialize
    // Broiler-Human:        PENDING
    public static readonly IntPtr EGL_NO_DISPLAY = IntPtr.Zero;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=3CADBF
    // Broiler-Falsified-If: EGL_NO_SURFACE is not the null pointer, so a failed surface creation is not recognised and MakeCurrent with it does not unbind the current surface
    // Broiler-Human:        PENDING
    public static readonly IntPtr EGL_NO_SURFACE = IntPtr.Zero;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=20E18C
    // Broiler-Falsified-If: EGL_NO_CONTEXT is not the null pointer, so MakeCurrent with it leaves the context bound to the thread and a failed eglCreateContext is not recognised
    // Broiler-Human:        PENDING
    public static readonly IntPtr EGL_NO_CONTEXT = IntPtr.Zero;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=A985BE
    // Broiler-Falsified-If: EGL_DEFAULT_DISPLAY is not the null EGLNativeDisplayType, so eglGetDisplay is handed an arbitrary native display pointer instead of the default display
    // Broiler-Human:        PENDING
    public static readonly IntPtr EGL_DEFAULT_DISPLAY = IntPtr.Zero;

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=F1A225
    // Broiler-Falsified-If: EGL_NONE is not 0x3038, so every attribute list ends without a terminator and eglChooseConfig or eglCreateContext reads past the end of the array
    // Broiler-Human:        PENDING
    public const int EGL_NONE = 0x3038;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=9ADE51
    // Broiler-Falsified-If: EGL_ALPHA_SIZE is not 0x3021, so eglChooseConfig rejects the attribute list or matches a config without an 8-bit alpha channel
    // Broiler-Human:        PENDING
    public const int EGL_ALPHA_SIZE = 0x3021;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=3C817F
    // Broiler-Falsified-If: EGL_BLUE_SIZE is not 0x3022, so eglChooseConfig rejects the attribute list or matches a config without an 8-bit blue channel
    // Broiler-Human:        PENDING
    public const int EGL_BLUE_SIZE = 0x3022;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=F45F72
    // Broiler-Falsified-If: EGL_GREEN_SIZE is not 0x3023, so eglChooseConfig rejects the attribute list or matches a config without an 8-bit green channel
    // Broiler-Human:        PENDING
    public const int EGL_GREEN_SIZE = 0x3023;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=C99A69
    // Broiler-Falsified-If: EGL_RED_SIZE is not 0x3024, so eglChooseConfig rejects the attribute list or matches a config without an 8-bit red channel
    // Broiler-Human:        PENDING
    public const int EGL_RED_SIZE = 0x3024;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=3EB559
    // Broiler-Falsified-If: EGL_DEPTH_SIZE is not 0x3025, so eglChooseConfig rejects the attribute list or applies the zero depth request to another attribute
    // Broiler-Human:        PENDING
    public const int EGL_DEPTH_SIZE = 0x3025;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=1FD37C
    // Broiler-Falsified-If: EGL_STENCIL_SIZE is not 0x3026, so eglChooseConfig rejects the attribute list or applies the zero stencil request to another attribute
    // Broiler-Human:        PENDING
    public const int EGL_STENCIL_SIZE = 0x3026;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=AB3532
    // Broiler-Falsified-If: EGL_SURFACE_TYPE is not 0x3033, so eglChooseConfig returns a config that cannot back the requested window or pbuffer surface and surface creation fails with EGL_BAD_MATCH
    // Broiler-Human:        PENDING
    public const int EGL_SURFACE_TYPE = 0x3033;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=77486E
    // Broiler-Falsified-If: EGL_RENDERABLE_TYPE is not 0x3040, so eglChooseConfig returns a config without ES 3 support and eglCreateContext for client version 3 fails
    // Broiler-Human:        PENDING
    public const int EGL_RENDERABLE_TYPE = 0x3040;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=C89B59
    // Broiler-Falsified-If: EGL_NATIVE_VISUAL_ID is not 0x302E, so eglGetConfigAttrib returns another attribute and the ANativeWindow buffer format does not match the chosen config
    // Broiler-Human:        PENDING
    public const int EGL_NATIVE_VISUAL_ID = 0x302E;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=5C4021
    // Broiler-Falsified-If: EGL_HEIGHT is not 0x3056, so eglCreatePbufferSurface or eglQuerySurface sets or reads another attribute and the surface height is wrong
    // Broiler-Human:        PENDING
    public const int EGL_HEIGHT = 0x3056;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=9FCA3C
    // Broiler-Falsified-If: EGL_WIDTH is not 0x3057, so eglCreatePbufferSurface or eglQuerySurface sets or reads another attribute and the surface width is wrong
    // Broiler-Human:        PENDING
    public const int EGL_WIDTH = 0x3057;

    /// <summary>Also spelled <c>EGL_CONTEXT_MAJOR_VERSION</c> in EGL 1.5; the value is the same.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=242E3B
    // Broiler-Falsified-If: EGL_CONTEXT_CLIENT_VERSION is not 0x3098, so eglCreateContext rejects the attribute list or creates a context of the default ES 1 version in which glBlitFramebuffer is missing
    // Broiler-Human:        PENDING
    public const int EGL_CONTEXT_CLIENT_VERSION = 0x3098;

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=55F42F
    // Broiler-Falsified-If: EGL_PBUFFER_BIT is not 0x0001, so the EGL_SURFACE_TYPE mask selects a config without pbuffer support and eglCreatePbufferSurface fails with EGL_BAD_MATCH
    // Broiler-Human:        PENDING
    public const int EGL_PBUFFER_BIT = 0x0001;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=0A0099
    // Broiler-Falsified-If: EGL_WINDOW_BIT is not 0x0004, so the EGL_SURFACE_TYPE mask selects a config without window support and eglCreateWindowSurface fails with EGL_BAD_MATCH
    // Broiler-Human:        PENDING
    public const int EGL_WINDOW_BIT = 0x0004;

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=187E51
    // Broiler-Falsified-If: EGL_OPENGL_ES_BIT is not 0x0001, so an EGL_RENDERABLE_TYPE mask built from it selects configs for another client API
    // Broiler-Human:        PENDING
    public const int EGL_OPENGL_ES_BIT = 0x0001;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=34B92D
    // Broiler-Falsified-If: EGL_OPENGL_ES2_BIT is not 0x0004, so an EGL_RENDERABLE_TYPE mask built from it selects configs for another client API
    // Broiler-Human:        PENDING
    public const int EGL_OPENGL_ES2_BIT = 0x0004;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=80660A
    // Broiler-Falsified-If: EGL_OPENGL_ES3_BIT is not 0x0040, so eglChooseConfig matches a config that cannot create the client version 3 context
    // Broiler-Human:        PENDING
    public const int EGL_OPENGL_ES3_BIT = 0x0040;

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=26A954
    // Broiler-Falsified-If: EGL_OPENGL_ES_API is not 0x30A0, so eglBindAPI fails with EGL_BAD_PARAMETER or binds desktop GL, which Android does not provide
    // Broiler-Human:        PENDING
    public const int EGL_OPENGL_ES_API = 0x30A0;

    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=4712E5
    // Broiler-Falsified-If: EGL_SUCCESS is not 0x3000, so an eglGetError result of no error is classified as a failure
    // Broiler-Human:        PENDING
    public const int EGL_SUCCESS = 0x3000;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=ACF5D0
    // Broiler-Falsified-If: EGL_CONTEXT_LOST is not 0x300E, so a lost context after eglMakeCurrent is reported as a generic EGL failure instead of a device loss the host can recover from
    // Broiler-Human:        PENDING
    public const int EGL_CONTEXT_LOST = 0x300E;
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=83EE47
    // Broiler-Falsified-If: EGL_BAD_SURFACE is not 0x300D, so an eglGetError result for a destroyed or invalid surface is classified as another error
    // Broiler-Human:        PENDING
    public const int EGL_BAD_SURFACE = 0x300D;
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=5457EC
    // Broiler-Falsified-If: EGL_BAD_NATIVE_WINDOW is not 0x300B, so an eglGetError result for an invalid ANativeWindow is classified as another error
    // Broiler-Human:        PENDING
    public const int EGL_BAD_NATIVE_WINDOW = 0x300B;

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=885D32
    // Broiler-Falsified-If: the displayId argument or the EGLDisplay return is declared narrower than a native pointer, so a 64-bit device passes or receives a truncated display handle
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglGetDisplay")]
    public static partial IntPtr GetDisplay(IntPtr displayId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=B5AA7C
    // Broiler-Falsified-If: the major or minor out parameter is not a 32-bit int, so the EGLint writes of eglInitialize overrun or truncate the managed locals
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglInitialize")]
    public static partial int Initialize(IntPtr display, out int major, out int minor);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=365B80
    // Broiler-Falsified-If: the EGLBoolean return of eglTerminate is not read as a 32-bit value, so an EGL_FALSE for an invalid display reads as success
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglTerminate")]
    public static partial int Terminate(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D9992F
    // Broiler-Falsified-If: the EGLenum api argument is not passed as a 32-bit value, so EGL_OPENGL_ES_API reaches eglBindAPI as a different enum and the call fails with EGL_BAD_PARAMETER
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglBindAPI")]
    public static partial int BindApi(int api);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=314663
    // Broiler-Falsified-If: configs is not marshalled as an array of pointer-sized EGLConfig handles, so on a 64-bit device eglChooseConfig writes 8-byte handles into 4-byte elements and runs past the pinned array
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglChooseConfig")]
    public static partial int ChooseConfig(IntPtr display, int[] attribList, IntPtr[] configs, int configSize, out int numConfig);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D9277A
    // Broiler-Falsified-If: the out value is not a 32-bit int, so the EGLint that eglGetConfigAttrib writes for EGL_NATIVE_VISUAL_ID is truncated or overruns the managed local
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglGetConfigAttrib")]
    public static partial int GetConfigAttrib(IntPtr display, IntPtr config, int attribute, out int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=B24254
    // Broiler-Falsified-If: attribList and shareContext reach eglCreateContext(EGLDisplay, EGLConfig, EGLContext, const EGLint*) in swapped positions, so EGL walks the share context's memory as an attribute list
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglCreateContext")]
    public static partial IntPtr CreateContext(IntPtr display, IntPtr config, IntPtr shareContext, int[] attribList);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4D4D42
    // Broiler-Falsified-If: the display and context arguments are in a different order than eglDestroyContext(EGLDisplay, EGLContext), so the call fails with EGL_BAD_DISPLAY and the context leaks
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglDestroyContext")]
    public static partial int DestroyContext(IntPtr display, IntPtr context);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=7ACFAF
    // Broiler-Falsified-If: config and attribList reach eglCreatePbufferSurface(EGLDisplay, EGLConfig, const EGLint*) in swapped positions, so EGL walks the config handle's memory as an attribute list
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglCreatePbufferSurface")]
    public static partial IntPtr CreatePbufferSurface(IntPtr display, IntPtr config, int[] attribList);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=DAD63B
    // Broiler-Falsified-If: nativeWindow and attribList reach eglCreateWindowSurface(EGLDisplay, EGLConfig, EGLNativeWindowType, const EGLint*) in swapped positions, so EGL walks the ANativeWindow as an attribute list and takes the array as the window
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglCreateWindowSurface")]
    public static partial IntPtr CreateWindowSurface(IntPtr display, IntPtr config, IntPtr nativeWindow, int[]? attribList);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=A060B1
    // Broiler-Falsified-If: the display and surface arguments are in a different order than eglDestroySurface(EGLDisplay, EGLSurface), so the call fails with EGL_BAD_DISPLAY and the window buffers leak
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglDestroySurface")]
    public static partial int DestroySurface(IntPtr display, IntPtr surface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=BA9F32
    // Broiler-Falsified-If: the draw and read arguments are in a different order than eglMakeCurrent(dpy, draw, read, ctx), so a context bound with distinct draw and read surfaces renders into the read surface
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglMakeCurrent")]
    public static partial int MakeCurrent(IntPtr display, IntPtr draw, IntPtr read, IntPtr context);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=1968CA
    // Broiler-Falsified-If: the EGLBoolean return of eglSwapBuffers is not read as a 32-bit value, so an EGL_FALSE for a surface whose ANativeWindow was destroyed is taken as a presented frame
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglSwapBuffers")]
    public static partial int SwapBuffers(IntPtr display, IntPtr surface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2D465B
    // Broiler-Falsified-If: the interval argument is not passed as a 32-bit EGLint, so eglSwapInterval receives a different interval and vsync is not turned on or off as asked
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglSwapInterval")]
    public static partial int SwapInterval(IntPtr display, int interval);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=6B6DBC
    // Broiler-Falsified-If: the out value is not a 32-bit int, so the EGLint that eglQuerySurface writes for EGL_WIDTH or EGL_HEIGHT is truncated or overruns the managed local
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglQuerySurface")]
    public static partial int QuerySurface(IntPtr display, IntPtr surface, int attribute, out int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B71C87
    // Broiler-Falsified-If: the EGLint return of eglGetError is not read as a 32-bit value, so EGL_CONTEXT_LOST arrives as a different code and a lost context is not reported as one
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglGetError")]
    public static partial int GetError();
}
