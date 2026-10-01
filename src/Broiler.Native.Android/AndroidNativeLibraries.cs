// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   8
// Annotated:        8/8
// Exempt:           3
// Human-reviewed:   0/8
// IP risk:          Low
// Security risk:    High
// Criteria:         8/8
// Resource impact:  2/10 max
// Unverified:       8
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace Broiler.Native.Android;

/// <summary>
/// Resolves the EGL, GLES, and native-window libraries this backend imports.
/// </summary>
/// <remarks>
/// The <c>DllImport</c> names below are the canonical Android sonames, but two of them vary in
/// practice: desktop-style hosts expose EGL as <c>libEGL.so.1</c>, and on some devices
/// <c>libGLESv3.so</c> is absent while <c>libGLESv2.so</c> exports the ES 3 entry points anyway
/// (Android's "GLESv2" library has carried ES 3 since API 18). A resolver with a candidate list
/// keeps a working device from failing on a naming detail.
/// </remarks>
// Broiler-AI:           Origin=AI; Spec=ADR-0001; IP=Low; Security=High; Resources=2; Fingerprint=D71B08
// Broiler-Falsified-If: on a device without libGLESv3.so but with libGLESv2.so, a GLES import fails with DllNotFoundException instead of binding to libGLESv2.so
// Broiler-Human:        PENDING
public static class AndroidNativeLibraries
{
    /// <summary>Import name for EGL. Resolved against <see cref="EglCandidates"/>.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=15C6CF
    // Broiler-Falsified-If: the value is not libEGL.so, the soname Android ships EGL under, so an EGL import bound without the resolver fails to load on a device that has EGL
    // Broiler-Human:        PENDING
    public const string Egl = "libEGL.so";

    /// <summary>Import name for OpenGL ES. Resolved against <see cref="GlesCandidates"/>.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=2716D7
    // Broiler-Falsified-If: the value is not libGLESv3.so, the library the NDK documents for the ES 3.0 entry points this backend imports, so a GLES import bound without the resolver loads by another soname and fails on a device that ships only libGLESv3.so
    // Broiler-Human:        PENDING
    public const string Gles = "libGLESv3.so";

    /// <summary>Import name for the Android native-window API.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=0E0F4B
    // Broiler-Falsified-If: the value is not libandroid.so, the NDK library exporting ANativeWindow_fromSurface, so every window import fails with DllNotFoundException since Resolve has no candidates for it
    // Broiler-Human:        PENDING
    public const string AndroidRuntime = "libandroid.so";

    public static IReadOnlyList<string> EglCandidates { get; } = ["libEGL.so", "libEGL.so.1"];

    public static IReadOnlyList<string> GlesCandidates { get; } = ["libGLESv3.so", "libGLESv2.so", "libGLESv2.so.2"];

    private static bool s_registered;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E33051
    // Broiler-Falsified-If: concurrent first calls to EnsureRegistered do not serialize on this gate, so two of them call SetDllImportResolver and the second throws InvalidOperationException
    // Broiler-Human:        PENDING
    private static readonly Lock s_gate = new();

    /// <summary>
    /// Registers the resolver. Safe to call repeatedly; only the first call installs it.
    /// </summary>
    // Broiler-AI:           Origin=AI; Spec=ADR-0001; IP=Low; Security=High; Resources=0; Fingerprint=AFC9D0
    // Broiler-Falsified-If: two threads making the first call at the same time both reach SetDllImportResolver, and the second throws InvalidOperationException
    // Broiler-Human:        PENDING
    public static void EnsureRegistered()
    {
        if (s_registered)
            return;

        lock (s_gate)
        {
            if (s_registered)
                return;

            NativeLibrary.SetDllImportResolver(typeof(AndroidNativeLibraries).Assembly, Resolve);
            s_registered = true;
        }
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=CE82F0
    // Broiler-Falsified-If: an import name other than libEGL.so or libGLESv3.so, such as libandroid.so, is redirected to an EGL or GLES candidate instead of returning zero to the runtime's own probing
    // Broiler-Human:        PENDING
    private static IntPtr Resolve(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        IReadOnlyList<string>? candidates = libraryName switch
        {
            Egl => EglCandidates,
            Gles => GlesCandidates,
            _ => null,
        };

        if (candidates is null)
            return IntPtr.Zero;

        foreach (string candidate in candidates)
        {
            if (NativeLibrary.TryLoad(candidate, assembly, searchPath, out IntPtr handle))
                return handle;
        }

        // Zero lets the runtime fall back to its own probing, which produces the normal
        // DllNotFoundException with the original name rather than a resolver-shaped error.
        return IntPtr.Zero;
    }

    /// <summary>Reports whether a library can be loaded, for the dependency probe.</summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=C11A03
    // Broiler-Falsified-If: a successful probe leaves the probed library loaded because the handle it opened is not freed before the name is reported
    // Broiler-Human:        PENDING
    public static bool TryLoadAny(IReadOnlyList<string> candidates, out string resolvedName)
    {
        ArgumentNullException.ThrowIfNull(candidates);

        foreach (string candidate in candidates)
        {
            if (NativeLibrary.TryLoad(candidate, out IntPtr handle))
            {
                NativeLibrary.Free(handle);
                resolvedName = candidate;
                return true;
            }
        }

        resolvedName = string.Empty;
        return false;
    }
}
