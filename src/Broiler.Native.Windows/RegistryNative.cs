// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows;

/// <summary>
/// Windows Registry (advapi32.dll) bindings from winreg.h.
/// </summary>
public static partial class RegistryNative
{
    public static readonly IntPtr HkeyCurrentUser = unchecked((IntPtr)0x80000001);
    public static readonly IntPtr HkeyLocalMachine = unchecked((IntPtr)0x80000002);

    public const uint RrfRtRegDword = 0x00000010;
    public const int ErrorSuccess = 0;

    [LibraryImport("advapi32.dll", EntryPoint = "RegGetValueW", StringMarshalling = StringMarshalling.Utf16, SetLastError = false)]
    public static partial int RegGetValue(
        IntPtr hkey,
        string? subKey,
        string? value,
        uint flags,
        out uint type,
        out int data,
        ref uint pcbData);
}
