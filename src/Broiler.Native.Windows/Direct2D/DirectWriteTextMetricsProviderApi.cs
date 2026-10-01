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
// Broiler-Falsified-If: CreateTextLayoutProc is not slot 18 of IDWriteFactory, HRESULT CreateTextLayout(WCHAR const* string, UINT32 stringLength, IDWriteTextFormat* textFormat, FLOAT maxWidth, FLOAT maxHeight, IDWriteTextLayout** textLayout) in dwrite.h, whose string is UTF-16 and stringLength counts its WCHARs
// Broiler-Human:        PENDING
public static class DirectWriteTextMetricsProviderApi
{

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=671FA2
    // Broiler-Falsified-If: CreateTextLayoutProc is not slot 18 of IDWriteFactory, HRESULT CreateTextLayout(WCHAR const* string, UINT32 stringLength, IDWriteTextFormat* textFormat, FLOAT maxWidth, FLOAT maxHeight, IDWriteTextLayout** textLayout) in dwrite.h, whose string is UTF-16 and stringLength counts its WCHARs
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate int CreateTextLayoutProc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string text, uint textLength,
        IntPtr textFormat, float maxWidth, float maxHeight, out IntPtr textLayout);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=ED31D6
    // Broiler-Falsified-If: GetMetricsProc is not slot 60 of IDWriteTextLayout, HRESULT GetMetrics(DWRITE_TEXT_METRICS* textMetrics) in dwrite.h, whose DWRITE_TEXT_METRICS is 36 bytes with lineCount at offset 32
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetMetricsProc(IntPtr self, out DWriteNative.DWRITE_TEXT_METRICS metrics);
}
