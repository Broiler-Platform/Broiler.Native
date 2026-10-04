// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   12
// Annotated:        12/12
// Exempt:           2
// Human-reviewed:   0/12
// IP risk:          Low
// Security risk:    Low
// Criteria:         0/0
// Resource impact:  0/10 max
// Unverified:       12
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows;

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=E3D6D4
// Broiler-Human:        PENDING
public static partial class ClipboardNative
{
    public const uint CF_UNICODETEXT = 13;
    public const uint GMEM_MOVEABLE = 0x0002;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=6FFFC4
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool OpenClipboard(IntPtr hWndNewOwner);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=298743
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CloseClipboard();

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=D2B8EC
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool EmptyClipboard();

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=35039C
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsClipboardFormatAvailable(uint format);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A57ED1
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial IntPtr GetClipboardData(uint uFormat);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=D1CA66
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial IntPtr SetClipboardData(uint uFormat, IntPtr hMem);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=472502
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true)]
    public static partial IntPtr GlobalAlloc(uint uFlags, nuint dwBytes);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=682946
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true)]
    public static partial IntPtr GlobalFree(IntPtr hMem);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A85A85
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true)]
    public static partial IntPtr GlobalLock(IntPtr hMem);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=E2EBBB
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool GlobalUnlock(IntPtr hMem);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=9C7FBA
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true)]
    public static partial nuint GlobalSize(IntPtr hMem);
}
