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
// Broiler-Falsified-If: a CreateTextLayoutProc call with textLength greater than text.Length makes IDWriteFactory::CreateTextLayout read UTF-16 units past the marshalled string
// Broiler-Human:        PENDING
public static class DirectWriteTextMetricsProviderApi
{

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=671FA2
    // Broiler-Falsified-If: a call with textLength greater than text.Length makes CreateTextLayout read UTF-16 code units past the end of the marshalled string
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
