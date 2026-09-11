using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Linux.OpenGL;

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

    [LibraryImport("libEGL.so.1", EntryPoint = "eglGetDisplay")]
    public static partial IntPtr GetDisplay(IntPtr displayId);

    [LibraryImport("libEGL.so.1", EntryPoint = "eglInitialize")]
    public static partial int Initialize(IntPtr display, out int major, out int minor);

    [LibraryImport("libEGL.so.1", EntryPoint = "eglTerminate")]
    public static partial int Terminate(IntPtr display);

    [LibraryImport("libEGL.so.1", EntryPoint = "eglBindAPI")]
    public static partial int BindApi(int api);

    [LibraryImport("libEGL.so.1", EntryPoint = "eglChooseConfig")]
    public static partial int ChooseConfig(IntPtr display, int[] attribList, IntPtr[] configs, int configSize, out int numConfig);

    [LibraryImport("libEGL.so.1", EntryPoint = "eglCreateContext")]
    public static partial IntPtr CreateContext(IntPtr display, IntPtr config, IntPtr shareContext, int[] attribList);

    [LibraryImport("libEGL.so.1", EntryPoint = "eglDestroyContext")]
    public static partial int DestroyContext(IntPtr display, IntPtr context);

    [LibraryImport("libEGL.so.1", EntryPoint = "eglCreatePbufferSurface")]
    public static partial IntPtr CreatePbufferSurface(IntPtr display, IntPtr config, int[] attribList);

    [LibraryImport("libEGL.so.1", EntryPoint = "eglCreateWindowSurface")]
    public static partial IntPtr CreateWindowSurface(IntPtr display, IntPtr config, IntPtr nativeWindow, int[] attribList);

    [LibraryImport("libEGL.so.1", EntryPoint = "eglDestroySurface")]
    public static partial int DestroySurface(IntPtr display, IntPtr surface);

    [LibraryImport("libEGL.so.1", EntryPoint = "eglMakeCurrent")]
    public static partial int MakeCurrent(IntPtr display, IntPtr draw, IntPtr read, IntPtr context);

    [LibraryImport("libEGL.so.1", EntryPoint = "eglSwapBuffers")]
    public static partial int SwapBuffers(IntPtr display, IntPtr surface);

    [LibraryImport("libEGL.so.1", EntryPoint = "eglGetError")]
    public static partial int GetError();

    [LibraryImport("libEGL.so.1", EntryPoint = "eglGetProcAddress")]
    public static partial IntPtr GetProcAddress([MarshalAs(UnmanagedType.LPUTF8Str)] string procName);
}
