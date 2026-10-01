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
// Broiler-Falsified-If: either kernel32 import declares its LARGE_INTEGER out parameter narrower than 8 bytes, so the call writes past the managed slot in the caller's frame
// Broiler-Human:        PENDING
public static partial class PerformanceCounterNative
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=F43BED
    // Broiler-Falsified-If: the out parameter is narrower than the 8-byte LARGE_INTEGER, so kernel32 writes past the managed slot and the tick count read back wraps within minutes of boot
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool QueryPerformanceCounter(out long performanceCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=96C697
    // Broiler-Falsified-If: the out parameter is narrower than the 8-byte LARGE_INTEGER, so kernel32 writes eight bytes into a smaller managed slot and corrupts the adjacent value in the caller's frame
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool QueryPerformanceFrequency(out long frequency);
}
