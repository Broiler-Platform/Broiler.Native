using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Android;

/// <summary>
/// The <c>ANativeWindow</c> API from <c>libandroid.so</c>.
/// </summary>
/// <remarks>
/// This is the whole reason the backend can target plain <c>net10.0</c>. EGL needs an
/// <c>ANativeWindow*</c>, which is obtained from a Java <c>Surface</c> — but
/// <c>ANativeWindow_fromSurface</c> takes a <c>JNIEnv*</c> and a <c>jobject</c>, and both are just
/// pointers. A host holding a <c>SurfaceView</c> passes
/// <c>JniEnvironment.EnvironmentPointer</c> and <c>surface.Handle</c>, and no managed Android type
/// crosses into Graphics.
///
/// Ownership: <see cref="FromSurface"/> returns a reference the caller must release with
/// <see cref="Release"/>. A graphics window surface does not take ownership of a
/// window handed to it, because the host's surface lifecycle already owns it.
/// </remarks>
public static partial class AndroidNativeWindowNative
{
    /// <summary>Matches <c>WINDOW_FORMAT_RGBA_8888</c>.</summary>
    public const int WindowFormatRgba8888 = 1;

    /// <summary>Matches <c>WINDOW_FORMAT_RGBX_8888</c>.</summary>
    public const int WindowFormatRgbx8888 = 2;

    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_fromSurface")]
    public static partial IntPtr FromSurface(IntPtr jniEnvironment, IntPtr surface);

    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_acquire")]
    public static partial void Acquire(IntPtr window);

    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_release")]
    public static partial void Release(IntPtr window);

    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_getWidth")]
    public static partial int GetWidth(IntPtr window);

    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_getHeight")]
    public static partial int GetHeight(IntPtr window);

    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_getFormat")]
    public static partial int GetFormat(IntPtr window);

    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_setBuffersGeometry")]
    public static partial int SetBuffersGeometry(IntPtr window, int width, int height, int format);
}
