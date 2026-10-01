// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   15
// Annotated:        15/15
// Exempt:           21
// Human-reviewed:   0/15
// IP risk:          Low
// Security risk:    Critical
// Criteria:         15/15
// Resource impact:  5/10 max
// Unverified:       15
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Linux.OpenGL;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=9489E2
// Broiler-Falsified-If: ChooseConfig differs from EGLBoolean eglChooseConfig(EGLDisplay dpy, const EGLint *attrib_list, EGLConfig *configs, EGLint config_size, EGLint *num_config) in EGL/egl.h
// Broiler-Human:        PENDING
public static partial class LinuxEglNative
{
    public const int EGL_FALSE = 0;
    public const int EGL_TRUE = 1;

    public const int EGL_NONE = 0x3038;
    public const int EGL_RED_SIZE = 0x3024;
    public const int EGL_GREEN_SIZE = 0x3023;
    public const int EGL_BLUE_SIZE = 0x3022;
    public const int EGL_ALPHA_SIZE = 0x3021;
    public const int EGL_DEPTH_SIZE = 0x3025;
    public const int EGL_STENCIL_SIZE = 0x3026;
    public const int EGL_SURFACE_TYPE = 0x3033;
    public const int EGL_RENDERABLE_TYPE = 0x3040;
    public const int EGL_WIDTH = 0x3057;
    public const int EGL_HEIGHT = 0x3056;
    public const int EGL_CONTEXT_MAJOR_VERSION = 0x3098;
    public const int EGL_CONTEXT_MINOR_VERSION = 0x30FB;
    public const int EGL_CONTEXT_OPENGL_PROFILE_MASK = 0x30FD;

    public const int EGL_PBUFFER_BIT = 0x0001;
    public const int EGL_WINDOW_BIT = 0x0004;
    public const int EGL_OPENGL_BIT = 0x0008;
    public const int EGL_OPENGL_API = 0x30A2;
    public const int EGL_CONTEXT_OPENGL_CORE_PROFILE_BIT = 0x00000001;

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=BD56B4
    // Broiler-Falsified-If: differs from EGLDisplay eglGetDisplay(EGLNativeDisplayType display_id) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglGetDisplay")]
    public static partial IntPtr GetDisplay(IntPtr displayId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=89B711
    // Broiler-Falsified-If: differs from EGLBoolean eglInitialize(EGLDisplay dpy, EGLint *major, EGLint *minor) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglInitialize")]
    public static partial int Initialize(IntPtr display, out int major, out int minor);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=C32377
    // Broiler-Falsified-If: differs from EGLBoolean eglTerminate(EGLDisplay dpy) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglTerminate")]
    public static partial int Terminate(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7F31B4
    // Broiler-Falsified-If: differs from EGLBoolean eglBindAPI(EGLenum api) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglBindAPI")]
    public static partial int BindApi(int api);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=7A0D75
    // Broiler-Falsified-If: differs from EGLBoolean eglChooseConfig(EGLDisplay dpy, const EGLint *attrib_list, EGLConfig *configs, EGLint config_size, EGLint *num_config) in EGL/egl.h, or configSize is larger than the length of configs
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglChooseConfig")]
    public static partial int ChooseConfig(IntPtr display, int[] attribList, IntPtr[] configs, int configSize, out int numConfig);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=9110AD
    // Broiler-Falsified-If: differs from EGLContext eglCreateContext(EGLDisplay dpy, EGLConfig config, EGLContext share_context, const EGLint *attrib_list) in EGL/egl.h, or attribList does not end in EGL_NONE
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglCreateContext")]
    public static partial IntPtr CreateContext(IntPtr display, IntPtr config, IntPtr shareContext, int[] attribList);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=CEE9B9
    // Broiler-Falsified-If: differs from EGLBoolean eglDestroyContext(EGLDisplay dpy, EGLContext ctx) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglDestroyContext")]
    public static partial int DestroyContext(IntPtr display, IntPtr context);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=E5C06E
    // Broiler-Falsified-If: differs from EGLSurface eglCreatePbufferSurface(EGLDisplay dpy, EGLConfig config, const EGLint *attrib_list) in EGL/egl.h, or attribList does not end in EGL_NONE
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglCreatePbufferSurface")]
    public static partial IntPtr CreatePbufferSurface(IntPtr display, IntPtr config, int[] attribList);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=26BB95
    // Broiler-Falsified-If: differs from EGLSurface eglCreateWindowSurface(EGLDisplay dpy, EGLConfig config, EGLNativeWindowType win, const EGLint *attrib_list) in EGL/egl.h, or attribList does not end in EGL_NONE
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglCreateWindowSurface")]
    public static partial IntPtr CreateWindowSurface(IntPtr display, IntPtr config, IntPtr nativeWindow, int[] attribList);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=645A11
    // Broiler-Falsified-If: differs from EGLBoolean eglDestroySurface(EGLDisplay dpy, EGLSurface surface) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglDestroySurface")]
    public static partial int DestroySurface(IntPtr display, IntPtr surface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B3981D
    // Broiler-Falsified-If: differs from EGLBoolean eglMakeCurrent(EGLDisplay dpy, EGLSurface draw, EGLSurface read, EGLContext ctx) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglMakeCurrent")]
    public static partial int MakeCurrent(IntPtr display, IntPtr draw, IntPtr read, IntPtr context);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=BE06C5
    // Broiler-Falsified-If: differs from EGLBoolean eglSwapBuffers(EGLDisplay dpy, EGLSurface surface) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglSwapBuffers")]
    public static partial int SwapBuffers(IntPtr display, IntPtr surface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7C4EE1
    // Broiler-Falsified-If: differs from EGLint eglGetError(void) in EGL/egl.h
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglGetError")]
    public static partial int GetError();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=774421
    // Broiler-Falsified-If: differs from __eglMustCastToProperFunctionPointerType eglGetProcAddress(const char *procname) in EGL/egl.h, or procName reaches it as other than a NUL-terminated 8-bit string
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglGetProcAddress")]
    public static partial IntPtr GetProcAddress([MarshalAs(UnmanagedType.LPUTF8Str)] string procName);
}
