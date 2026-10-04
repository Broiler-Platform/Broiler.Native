// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   4
// Annotated:        4/4
// Exempt:           7
// Human-reviewed:   0/4
// IP risk:          Low
// Security risk:    Low
// Criteria:         0/0
// Resource impact:  0/10 max
// Unverified:       4
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Input;

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=65F446
// Broiler-Human:        PENDING
public static partial class ImmNative
{
    public const uint WM_IME_STARTCOMPOSITION = 0x010D;
    public const uint WM_IME_ENDCOMPOSITION = 0x010E;
    public const uint WM_IME_COMPOSITION = 0x010F;
    public const uint WM_IME_SETCONTEXT = 0x0281;

    public const uint GCS_COMPSTR = 0x0008;
    public const uint GCS_RESULTSTR = 0x0800;
    public const uint GCS_CURSORPOS = 0x0080;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=D5F6DB
    // Broiler-Human:        PENDING
    [LibraryImport("imm32.dll")]
    public static partial IntPtr ImmGetContext(IntPtr hWnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=FFAE87
    // Broiler-Human:        PENDING
    [LibraryImport("imm32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ImmReleaseContext(IntPtr hWnd, IntPtr hImc);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=E0ED61
    // Broiler-Human:        PENDING
    [LibraryImport("imm32.dll", EntryPoint = "ImmGetCompositionStringW")]
    public static partial int ImmGetCompositionString(IntPtr hImc, uint dwIndex, IntPtr lpBuf, uint dwBufLen);
}
