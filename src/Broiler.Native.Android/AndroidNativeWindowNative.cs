// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   8
// Annotated:        8/8
// Exempt:           2
// Human-reviewed:   0/8
// IP risk:          Low
// Security risk:    Critical
// Criteria:         8/8
// Resource impact:  3/10 max
// Unverified:       8
//
// GENERATED - DO NOT EDIT MANUALLY

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
// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=8121EE
// Broiler-Falsified-If: an import here differs from its prototype in android/native_window.h or android/native_window_jni.h, where the window is ANativeWindow*, env and surface are JNIEnv* and jobject, and widths, heights, formats and results are int32_t
// Broiler-Human:        PENDING
public static partial class AndroidNativeWindowNative
{
    /// <summary>Matches <c>WINDOW_FORMAT_RGBA_8888</c>.</summary>
    public const int WindowFormatRgba8888 = 1;

    /// <summary>Matches <c>WINDOW_FORMAT_RGBX_8888</c>.</summary>
    public const int WindowFormatRgbx8888 = 2;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=F68393
    // Broiler-Falsified-If: the reference that ANativeWindow* ANativeWindow_fromSurface(JNIEnv* env, jobject surface) in android/native_window_jni.h acquires on the returned window is not dropped by exactly one Release
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_fromSurface")]
    public static partial IntPtr FromSurface(IntPtr jniEnvironment, IntPtr surface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=F2F5A1
    // Broiler-Falsified-If: a reference added by void ANativeWindow_acquire(ANativeWindow* window) in android/native_window.h is not dropped by exactly one Release
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_acquire")]
    public static partial void Acquire(IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=8A97DE
    // Broiler-Falsified-If: Release drops a reference its caller did not take through FromSurface or Acquire, against void ANativeWindow_release(ANativeWindow* window) in android/native_window.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_release")]
    public static partial void Release(IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=914A39
    // Broiler-Falsified-If: differs from int32_t ANativeWindow_getWidth(ANativeWindow* window) in android/native_window.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_getWidth")]
    public static partial int GetWidth(IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=ABB058
    // Broiler-Falsified-If: differs from int32_t ANativeWindow_getHeight(ANativeWindow* window) in android/native_window.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_getHeight")]
    public static partial int GetHeight(IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=16B613
    // Broiler-Falsified-If: differs from int32_t ANativeWindow_getFormat(ANativeWindow* window) in android/native_window.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_getFormat")]
    public static partial int GetFormat(IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=5A7772
    // Broiler-Falsified-If: differs from int32_t ANativeWindow_setBuffersGeometry(ANativeWindow* window, int32_t width, int32_t height, int32_t format) in android/native_window.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_setBuffersGeometry")]
    public static partial int SetBuffersGeometry(IntPtr window, int width, int height, int format);
}
