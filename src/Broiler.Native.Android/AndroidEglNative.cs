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

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglGetDisplay")]
    public static partial IntPtr GetDisplay(IntPtr displayId);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglInitialize")]
    public static partial int Initialize(IntPtr display, out int major, out int minor);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglTerminate")]
    public static partial int Terminate(IntPtr display);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglBindAPI")]
    public static partial int BindApi(int api);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglChooseConfig")]
    public static partial int ChooseConfig(IntPtr display, int[] attribList, IntPtr[] configs, int configSize, out int numConfig);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglGetConfigAttrib")]
    public static partial int GetConfigAttrib(IntPtr display, IntPtr config, int attribute, out int value);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglCreateContext")]
    public static partial IntPtr CreateContext(IntPtr display, IntPtr config, IntPtr shareContext, int[] attribList);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglDestroyContext")]
    public static partial int DestroyContext(IntPtr display, IntPtr context);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglCreatePbufferSurface")]
    public static partial IntPtr CreatePbufferSurface(IntPtr display, IntPtr config, int[] attribList);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglCreateWindowSurface")]
    public static partial IntPtr CreateWindowSurface(IntPtr display, IntPtr config, IntPtr nativeWindow, int[]? attribList);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglDestroySurface")]
    public static partial int DestroySurface(IntPtr display, IntPtr surface);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglMakeCurrent")]
    public static partial int MakeCurrent(IntPtr display, IntPtr draw, IntPtr read, IntPtr context);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglSwapBuffers")]
    public static partial int SwapBuffers(IntPtr display, IntPtr surface);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglSwapInterval")]
    public static partial int SwapInterval(IntPtr display, int interval);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglQuerySurface")]
    public static partial int QuerySurface(IntPtr display, IntPtr surface, int attribute, out int value);

    [LibraryImport(AndroidNativeLibraries.Egl, EntryPoint = "eglGetError")]
    public static partial int GetError();
}
