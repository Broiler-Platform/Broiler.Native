// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Broiler.Native.Windows.Credentials;

/// <summary>
/// Windows Credential Manager (advapi32.dll) bindings from wincred.h.
/// </summary>
public static partial class CredentialNative
{
    public const uint CredTypeGeneric = 1;
    public const uint CredPersistSession = 1;
    public const uint CredPersistLocalMachine = 2;
    public const uint CredPersistEnterprise = 3;
    public const int CredMaxCredentialBlobSize = 2560;
    public const int ErrorNotFound = 1168;

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct CREDENTIAL
    {
        public uint Flags;
        public uint Type;
        public string? TargetName;
        public string? Comment;
        public FILETIME LastWritten;
        public uint CredentialBlobSize;
        public IntPtr CredentialBlob;
        public uint Persist;
        public uint AttributeCount;
        public IntPtr Attributes;
        public string? TargetAlias;
        public string? UserName;
    }

    [LibraryImport("advapi32.dll", EntryPoint = "CredReadW", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CredRead(string target, uint type, uint flags, out IntPtr credential);

    [DllImport("advapi32.dll", EntryPoint = "CredWriteW", CharSet = CharSet.Unicode, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool CredWrite(ref CREDENTIAL credential, uint flags);

    [LibraryImport("advapi32.dll", EntryPoint = "CredDeleteW", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CredDelete(string target, uint type, uint flags);

    [LibraryImport("advapi32.dll")]
    public static partial void CredFree(IntPtr buffer);
}
