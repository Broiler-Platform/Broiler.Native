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
// Broiler-Falsified-If: ChooseConfig's configs array is not of pointer-sized EGLConfig handles, so on x86-64 eglChooseConfig writes 8-byte handles past the end of the pinned array
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
    // Broiler-Falsified-If: an Xlib Display pointer above 4 GiB passed as displayId reaches eglGetDisplay truncated to 32 bits, so EGL opens a different display or returns EGL_NO_DISPLAY
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglGetDisplay")]
    public static partial IntPtr GetDisplay(IntPtr displayId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=89B711
    // Broiler-Falsified-If: eglInitialize returns EGL_TRUE but major and minor read back as 0 because the out parameters do not reach it as pointers to 32-bit EGLint
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglInitialize")]
    public static partial int Initialize(IntPtr display, out int major, out int minor);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=C32377
    // Broiler-Falsified-If: an EGL_FALSE result from eglTerminate on an invalid display reads back nonzero because the 32-bit EGLBoolean return is marshalled at another width
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglTerminate")]
    public static partial int Terminate(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7F31B4
    // Broiler-Falsified-If: EGL_OPENGL_API passed here does not reach eglBindAPI as the 32-bit EGLenum 0x30A2, so the thread stays bound to OpenGL ES and the desktop context request fails
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglBindAPI")]
    public static partial int BindApi(int api);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=7A0D75
    // Broiler-Falsified-If: configs is not marshalled as an array of pointer-sized EGLConfig handles, so on x86-64 eglChooseConfig writes 8-byte handles into 4-byte elements and runs past the pinned array
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglChooseConfig")]
    public static partial int ChooseConfig(IntPtr display, int[] attribList, IntPtr[] configs, int configSize, out int numConfig);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=9110AD
    // Broiler-Falsified-If: attribList and shareContext reach eglCreateContext(EGLDisplay, EGLConfig, EGLContext, const EGLint*) in swapped positions, so EGL walks the share context's memory as an attribute list
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglCreateContext")]
    public static partial IntPtr CreateContext(IntPtr display, IntPtr config, IntPtr shareContext, int[] attribList);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=CEE9B9
    // Broiler-Falsified-If: an EGLContext handle reaches eglDestroyContext at other than pointer width, so it fails with EGL_BAD_CONTEXT and the driver context leaks
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglDestroyContext")]
    public static partial int DestroyContext(IntPtr display, IntPtr context);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=E5C06E
    // Broiler-Falsified-If: config and attribList reach eglCreatePbufferSurface(EGLDisplay, EGLConfig, const EGLint*) in swapped positions, so EGL walks the config handle's memory as an attribute list
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglCreatePbufferSurface")]
    public static partial IntPtr CreatePbufferSurface(IntPtr display, IntPtr config, int[] attribList);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=26BB95
    // Broiler-Falsified-If: nativeWindow and attribList reach eglCreateWindowSurface(EGLDisplay, EGLConfig, EGLNativeWindowType, const EGLint*) in swapped positions, so EGL walks the X window id as an attribute list and takes the array address as the window
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglCreateWindowSurface")]
    public static partial IntPtr CreateWindowSurface(IntPtr display, IntPtr config, IntPtr nativeWindow, int[] attribList);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=645A11
    // Broiler-Falsified-If: an EGLSurface handle reaches eglDestroySurface at other than pointer width, so it fails with EGL_BAD_SURFACE and the surface buffers leak
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglDestroySurface")]
    public static partial int DestroySurface(IntPtr display, IntPtr surface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B3981D
    // Broiler-Falsified-If: the draw and read arguments reach eglMakeCurrent in an order other than display, draw, read, context, so reads come from the wrong surface or EGL_BAD_MATCH is raised
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglMakeCurrent")]
    public static partial int MakeCurrent(IntPtr display, IntPtr draw, IntPtr read, IntPtr context);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=BE06C5
    // Broiler-Falsified-If: an EGL_FALSE result for a lost or invalid surface reads back nonzero because the 32-bit EGLBoolean return is marshalled at another width, so a failed present is treated as success
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglSwapBuffers")]
    public static partial int SwapBuffers(IntPtr display, IntPtr surface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7C4EE1
    // Broiler-Falsified-If: the error read after a failed EGL call is the process errno rather than the calling thread's eglGetError code, so EGL_BAD_ALLOC (0x3003) is reported as an unrelated value
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglGetError")]
    public static partial int GetError();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=774421
    // Broiler-Falsified-If: the function pointer eglGetProcAddress returns is truncated to 32 bits on x86-64, so a delegate built from it jumps to an unrelated address
    // Broiler-Human:        PENDING
    [LibraryImport("libEGL.so.1", EntryPoint = "eglGetProcAddress")]
    public static partial IntPtr GetProcAddress([MarshalAs(UnmanagedType.LPUTF8Str)] string procName);
}
