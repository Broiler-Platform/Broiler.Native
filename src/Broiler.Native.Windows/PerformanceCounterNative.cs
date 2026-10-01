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
// Security risk:    High
// Criteria:         3/3
// Resource impact:  0/10 max
// Unverified:       3
//
// GENERATED - DO NOT EDIT MANUALLY

using System.Runtime.InteropServices;

namespace Broiler.Native.Windows;

// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=641D5D
// Broiler-Falsified-If: either import differs from BOOL QueryPerformanceCounter(LARGE_INTEGER* lpPerformanceCount) or BOOL QueryPerformanceFrequency(LARGE_INTEGER* lpFrequency) in profileapi.h
// Broiler-Human:        PENDING
public static partial class PerformanceCounterNative
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=F43BED
    // Broiler-Falsified-If: differs from BOOL QueryPerformanceCounter(LARGE_INTEGER* lpPerformanceCount) in profileapi.h, the 8-byte LARGE_INTEGER passed as an out pointer
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool QueryPerformanceCounter(out long performanceCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=96C697
    // Broiler-Falsified-If: differs from BOOL QueryPerformanceFrequency(LARGE_INTEGER* lpFrequency) in profileapi.h, the 8-byte LARGE_INTEGER passed as an out pointer
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool QueryPerformanceFrequency(out long frequency);
}
