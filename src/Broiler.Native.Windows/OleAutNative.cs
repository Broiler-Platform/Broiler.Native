// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// HAIRS Code Assurance
// --------------------
// Relevant units:   6
// Annotated:        6/6
// Exempt:           0
// Human-reviewed:   0/6
// IP risk:          Low
// Security risk:    Low
// Criteria:         0/0
// Resource impact:  0/10 max
// Unverified:       6
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows;

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3F95B2
// Hairs-Human:        PENDING
public static partial class OleAutNative
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=314C53
    // Hairs-Human:        PENDING
    [LibraryImport("oleaut32.dll")]
    public static partial IntPtr SafeArrayCreateVector(ushort vt, int lLbound, uint cElements);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=73BEA7
    // Hairs-Human:        PENDING
    [LibraryImport("oleaut32.dll")]
    public static partial int SafeArrayAccessData(IntPtr psa, out IntPtr ppvData);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=21E92A
    // Hairs-Human:        PENDING
    [LibraryImport("oleaut32.dll")]
    public static partial int SafeArrayUnaccessData(IntPtr psa);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=434B93
    // Hairs-Human:        PENDING
    [LibraryImport("oleaut32.dll")]
    public static partial int SafeArrayDestroy(IntPtr psa);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=310A2D
    // Hairs-Human:        PENDING
    [LibraryImport("oleaut32.dll")]
    public static partial int SafeArrayPutElement(IntPtr psa, in int rgIndices, IntPtr pv);
}
