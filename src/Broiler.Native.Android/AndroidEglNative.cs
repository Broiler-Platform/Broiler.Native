// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   17
// Annotated:        17/17
// Exempt:           29
// Human-reviewed:   0/17
// IP risk:          Low
// Security risk:    Critical
// Criteria:         17/17
// Resource impact:  5/10 max
// Unverified:       17
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
    public const int EGL_FALSE = 0;
    public const int EGL_TRUE = 1;

    public static readonly IntPtr EGL_NO_DISPLAY = IntPtr.Zero;
    public static readonly IntPtr EGL_NO_SURFACE = IntPtr.Zero;
    public static readonly IntPtr EGL_NO_CONTEXT = IntPtr.Zero;
    public static readonly IntPtr EGL_DEFAULT_DISPLAY = IntPtr.Zero;

    public const int EGL_NONE = 0x3038;
    public const int EGL_ALPHA_SIZE = 0x3021;
    public const int EGL_BLUE_SIZE = 0x3022;
    public const int EGL_GREEN_SIZE = 0x3023;
    public const int EGL_RED_SIZE = 0x3024;
    public const int EGL_DEPTH_SIZE = 0x3025;
    public const int EGL_STENCIL_SIZE = 0x3026;
    public const int EGL_SURFACE_TYPE = 0x3033;
    public const int EGL_RENDERABLE_TYPE = 0x3040;
    public const int EGL_NATIVE_VISUAL_ID = 0x302E;
    public const int EGL_HEIGHT = 0x3056;
    public const int EGL_WIDTH = 0x3057;

    /// <summary>Also spelled <c>EGL_CONTEXT_MAJOR_VERSION</c> in EGL 1.5; the value is the same.</summary>
    public const int EGL_CONTEXT_CLIENT_VERSION = 0x3098;

    public const int EGL_PBUFFER_BIT = 0x0001;
    public const int EGL_WINDOW_BIT = 0x0004;

    public const int EGL_OPENGL_ES_BIT = 0x0001;
    public const int EGL_OPENGL_ES2_BIT = 0x0004;
    public const int EGL_OPENGL_ES3_BIT = 0x0040;

    public const int EGL_OPENGL_ES_API = 0x30A0;

    public const int EGL_SUCCESS = 0x3000;
    public const int EGL_CONTEXT_LOST = 0x300E;
    public const int EGL_BAD_SURFACE = 0x300D;
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
