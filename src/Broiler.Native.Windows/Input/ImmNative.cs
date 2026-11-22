// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// HAIRS Code Assurance
// --------------------
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

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=65F446
// Hairs-Human:        PENDING
public static partial class ImmNative
{
    public const uint WM_IME_STARTCOMPOSITION = 0x010D;
    public const uint WM_IME_ENDCOMPOSITION = 0x010E;
    public const uint WM_IME_COMPOSITION = 0x010F;
    public const uint WM_IME_SETCONTEXT = 0x0281;

    public const uint GCS_COMPSTR = 0x0008;
    public const uint GCS_RESULTSTR = 0x0800;
    public const uint GCS_CURSORPOS = 0x0080;

    public const uint CFS_POINT = 0x0002;
    public const uint CFS_FORCE_POSITION = 0x0020;
    public const uint IACE_DEFAULT = 0x0010;

    [StructLayout(LayoutKind.Sequential)]
    public struct COMPOSITIONFORM
    {
        public uint DwStyle;
        public WindowNative.POINT PtCurrentPos;
        public WindowNative.RECT RcArea;
    }

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=D5F6DB
    // Hairs-Human:        PENDING
    [LibraryImport("imm32.dll")]
    public static partial IntPtr ImmGetContext(IntPtr hWnd);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=FFAE87
    // Hairs-Human:        PENDING
    [LibraryImport("imm32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ImmReleaseContext(IntPtr hWnd, IntPtr hImc);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=E0ED61
    // Hairs-Human:        PENDING
    [LibraryImport("imm32.dll", EntryPoint = "ImmGetCompositionStringW")]
    public static partial int ImmGetCompositionString(IntPtr hImc, uint dwIndex, IntPtr lpBuf, uint dwBufLen);

    [LibraryImport("imm32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ImmSetCompositionWindow(IntPtr hImc, ref COMPOSITIONFORM lpCompForm);

    [LibraryImport("imm32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ImmGetCompositionWindow(IntPtr hImc, out COMPOSITIONFORM lpCompForm);

    [LibraryImport("imm32.dll")]
    public static partial IntPtr ImmCreateContext();

    [LibraryImport("imm32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ImmDestroyContext(IntPtr hImc);

    [LibraryImport("imm32.dll")]
    public static partial IntPtr ImmAssociateContext(IntPtr hWnd, IntPtr hImc);

    [LibraryImport("imm32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ImmAssociateContextEx(IntPtr hWnd, IntPtr hImc, uint dwFlags);

    [LibraryImport("imm32.dll")]
    public static partial IntPtr ImmGetDefaultIMEWnd(IntPtr hWnd);
}
