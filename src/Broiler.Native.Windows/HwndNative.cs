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
// Resource impact:  0/10 max
// Unverified:       2
//
// GENERATED - DO NOT EDIT MANUALLY

using System.Runtime.InteropServices;

namespace Broiler.Native.Windows;

// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=EDAB60
// Broiler-Falsified-If: its IsWindow import differs from BOOL IsWindow(HWND hWnd) in winuser.h
// Broiler-Human:        PENDING
public static partial class HwndNative
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=EF9423
    // Broiler-Falsified-If: differs from BOOL IsWindow(HWND hWnd) in winuser.h, with the result marshalled as a 4-byte BOOL
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsWindow(nint hwnd);
}
