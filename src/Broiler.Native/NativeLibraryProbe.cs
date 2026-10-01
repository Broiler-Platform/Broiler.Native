// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   2
// Annotated:        2/2
// Exempt:           0
// Human-reviewed:   0/2
// IP risk:          Low
// Security risk:    High
// Criteria:         2/2
// Resource impact:  2/10 max
// Unverified:       2
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native;

/// <summary>Probes native library availability without retaining a loaded handle.</summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=82A0F5
// Broiler-Falsified-If: a probe through IsAvailable leaves a library the process had not loaded before still mapped after the call returns, true or false
// Broiler-Human:        PENDING
public static class NativeLibraryProbe
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=A7B31A
    // Broiler-Falsified-If: the success path returns true without passing the TryLoad handle to NativeLibrary.Free, so a library the process had not loaded stays mapped
    // Broiler-Human:        PENDING
    public static bool IsAvailable(string libraryName)
    {
        if (string.IsNullOrWhiteSpace(libraryName))
            return false;

        if (!NativeLibrary.TryLoad(libraryName, out IntPtr handle))
            return false;
        
        NativeLibrary.Free(handle);
        return true;
    }
}
