// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   3
// Annotated:        3/3
// Exempt:           0
// Human-reviewed:   0/3
// IP risk:          Low
// Security risk:    Critical
// Criteria:         3/3
// Resource impact:  4/10 max
// Unverified:       3
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=E4A9A2
// Broiler-Falsified-If: CreateTextLayoutProc's textLength is not passed as the 32-bit UINT32 directly after the string pointer, so CreateTextLayout reads a length taken from other bits and walks UTF-16 units past the marshalled text
// Broiler-Human:        PENDING
public static class DirectWriteTextMetricsProviderApi
{

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=671FA2
    // Broiler-Falsified-If: textLength is not passed as the 32-bit UINT32 directly after the string pointer, so CreateTextLayout reads a length taken from other bits and walks UTF-16 units past the marshalled text
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate int CreateTextLayoutProc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string text, uint textLength,
        IntPtr textFormat, float maxWidth, float maxHeight, out IntPtr textLayout);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=ED31D6
    // Broiler-Falsified-If: metrics is not an out pointer to the 36-byte DWRITE_TEXT_METRICS, so the width and line count GetMetrics writes land in the wrong fields or past the struct
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetMetricsProc(IntPtr self, out DWriteNative.DWRITE_TEXT_METRICS metrics);
}
