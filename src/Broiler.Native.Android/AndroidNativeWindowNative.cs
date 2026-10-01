// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   10
// Annotated:        10/10
// Exempt:           0
// Human-reviewed:   0/10
// IP risk:          Low
// Security risk:    High
// Criteria:         10/10
// Resource impact:  3/10 max
// Unverified:       10
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
// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=8121EE
// Broiler-Falsified-If: a Release not matched by a FromSurface or Acquire reference frees the ANativeWindow while the host Surface still renders to it
// Broiler-Human:        PENDING
public static partial class AndroidNativeWindowNative
{
    /// <summary>Matches <c>WINDOW_FORMAT_RGBA_8888</c>.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=0A0115
    // Broiler-Falsified-If: the value is not 1 (WINDOW_FORMAT_RGBA_8888 in the NDK native_window.h), so SetBuffersGeometry requests a buffer format other than 8-bit RGBA with alpha
    // Broiler-Human:        PENDING
    public const int WindowFormatRgba8888 = 1;

    /// <summary>Matches <c>WINDOW_FORMAT_RGBX_8888</c>.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=D56A1B
    // Broiler-Falsified-If: the value is not 2 (WINDOW_FORMAT_RGBX_8888 in the NDK native_window.h), so SetBuffersGeometry requests a buffer format other than 8-bit RGB with an ignored fourth byte
    // Broiler-Human:        PENDING
    public const int WindowFormatRgbx8888 = 2;

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=F68393
    // Broiler-Falsified-If: the JNIEnv* and jobject arguments reach ANativeWindow_fromSurface in swapped order, so the Surface handle is dereferenced as the JNI function table
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_fromSurface")]
    public static partial IntPtr FromSurface(IntPtr jniEnvironment, IntPtr surface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=F2F5A1
    // Broiler-Falsified-If: Acquire does not add a reference, so a window released once by its other owner is freed while this caller still holds it
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_acquire")]
    public static partial void Acquire(IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=8A97DE
    // Broiler-Falsified-If: a window obtained from FromSurface keeps its extra reference after one Release call, so the ANativeWindow and its buffer queue outlive the host Surface
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_release")]
    public static partial void Release(IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=914A39
    // Broiler-Falsified-If: for a window whose buffers were set to 640 by 480, GetWidth returns a value other than 640
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_getWidth")]
    public static partial int GetWidth(IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=ABB058
    // Broiler-Falsified-If: for a window whose buffers were set to 640 by 480, GetHeight returns a value other than 480
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_getHeight")]
    public static partial int GetHeight(IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=16B613
    // Broiler-Falsified-If: after SetBuffersGeometry with WindowFormatRgba8888 succeeds, GetFormat returns a value other than 1
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_getFormat")]
    public static partial int GetFormat(IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=5A7772
    // Broiler-Falsified-If: a 640 by 480 geometry returns 0 but GetWidth and GetHeight then report 480 by 640, showing the width and height reach the NDK swapped
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.AndroidRuntime, EntryPoint = "ANativeWindow_setBuffersGeometry")]
    public static partial int SetBuffersGeometry(IntPtr window, int width, int height, int format);
}
