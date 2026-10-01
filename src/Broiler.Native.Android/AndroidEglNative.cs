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
// Broiler-Falsified-If: an import here differs from its prototype in EGL/egl.h, where EGLDisplay, EGLConfig, EGLSurface and EGLContext are void *, EGLBoolean and EGLenum are unsigned int, and Android's EGL/eglplatform.h makes EGLNativeWindowType struct ANativeWindow * and EGLint khronos_int32_t
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
    // Broiler-Falsified-If: differs from EGLDisplay eglGetDisplay(EGLNativeDisplayType display_id) in EGL/egl.h, EGLNativeDisplayType being void * on Android in EGL/eglplatform.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglGetDisplay")]
    public static partial IntPtr GetDisplay(IntPtr displayId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=B5AA7C
    // Broiler-Falsified-If: differs from EGLBoolean eglInitialize(EGLDisplay dpy, EGLint *major, EGLint *minor) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglInitialize")]
    public static partial int Initialize(IntPtr display, out int major, out int minor);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=365B80
    // Broiler-Falsified-If: differs from EGLBoolean eglTerminate(EGLDisplay dpy) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglTerminate")]
    public static partial int Terminate(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D9992F
    // Broiler-Falsified-If: differs from EGLBoolean eglBindAPI(EGLenum api) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglBindAPI")]
    public static partial int BindApi(int api);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=314663
    // Broiler-Falsified-If: configSize exceeds configs.Length, the number of void * EGLConfig slots that EGLBoolean eglChooseConfig(EGLDisplay dpy, const EGLint *attrib_list, EGLConfig *configs, EGLint config_size, EGLint *num_config) in EGL/egl.h may fill
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglChooseConfig")]
    public static partial int ChooseConfig(IntPtr display, int[] attribList, IntPtr[] configs, int configSize, out int numConfig);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D9277A
    // Broiler-Falsified-If: differs from EGLBoolean eglGetConfigAttrib(EGLDisplay dpy, EGLConfig config, EGLint attribute, EGLint *value) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglGetConfigAttrib")]
    public static partial int GetConfigAttrib(IntPtr display, IntPtr config, int attribute, out int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=B24254
    // Broiler-Falsified-If: attribList is not ended by EGL_NONE, the terminator that EGLContext eglCreateContext(EGLDisplay dpy, EGLConfig config, EGLContext share_context, const EGLint *attrib_list) in EGL/egl.h reads up to
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglCreateContext")]
    public static partial IntPtr CreateContext(IntPtr display, IntPtr config, IntPtr shareContext, int[] attribList);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4D4D42
    // Broiler-Falsified-If: differs from EGLBoolean eglDestroyContext(EGLDisplay dpy, EGLContext ctx) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglDestroyContext")]
    public static partial int DestroyContext(IntPtr display, IntPtr context);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=7ACFAF
    // Broiler-Falsified-If: attribList is not ended by EGL_NONE, the terminator that EGLSurface eglCreatePbufferSurface(EGLDisplay dpy, EGLConfig config, const EGLint *attrib_list) in EGL/egl.h reads up to
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglCreatePbufferSurface")]
    public static partial IntPtr CreatePbufferSurface(IntPtr display, IntPtr config, int[] attribList);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=DAD63B
    // Broiler-Falsified-If: a non-null attribList is not ended by EGL_NONE, the terminator that EGLSurface eglCreateWindowSurface(EGLDisplay dpy, EGLConfig config, EGLNativeWindowType win, const EGLint *attrib_list) in EGL/egl.h reads up to
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglCreateWindowSurface")]
    public static partial IntPtr CreateWindowSurface(IntPtr display, IntPtr config, IntPtr nativeWindow, int[]? attribList);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=A060B1
    // Broiler-Falsified-If: differs from EGLBoolean eglDestroySurface(EGLDisplay dpy, EGLSurface surface) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglDestroySurface")]
    public static partial int DestroySurface(IntPtr display, IntPtr surface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=BA9F32
    // Broiler-Falsified-If: differs from EGLBoolean eglMakeCurrent(EGLDisplay dpy, EGLSurface draw, EGLSurface read, EGLContext ctx) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglMakeCurrent")]
    public static partial int MakeCurrent(IntPtr display, IntPtr draw, IntPtr read, IntPtr context);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=1968CA
    // Broiler-Falsified-If: differs from EGLBoolean eglSwapBuffers(EGLDisplay dpy, EGLSurface surface) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglSwapBuffers")]
    public static partial int SwapBuffers(IntPtr display, IntPtr surface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2D465B
    // Broiler-Falsified-If: differs from EGLBoolean eglSwapInterval(EGLDisplay dpy, EGLint interval) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglSwapInterval")]
    public static partial int SwapInterval(IntPtr display, int interval);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=6B6DBC
    // Broiler-Falsified-If: differs from EGLBoolean eglQuerySurface(EGLDisplay dpy, EGLSurface surface, EGLint attribute, EGLint *value) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglQuerySurface")]
    public static partial int QuerySurface(IntPtr display, IntPtr surface, int attribute, out int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B71C87
    // Broiler-Falsified-If: differs from EGLint eglGetError(void) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglGetError")]
    public static partial int GetError();
}
