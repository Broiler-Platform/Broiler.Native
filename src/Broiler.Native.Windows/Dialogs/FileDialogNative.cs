// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Dialogs;

/// <summary>
/// Windows common file and folder dialog bindings from commdlg.h and shlobj_core.h.
/// </summary>
public static partial class FileDialogNative
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct OPENFILENAME
    {
        public int StructureSize;
        public IntPtr Owner;
        public IntPtr Instance;
        public IntPtr Filter;
        public IntPtr CustomFilter;
        public int MaxCustomFilter;
        public int FilterIndex;
        public IntPtr File;
        public int MaxFile;
        public IntPtr FileTitle;
        public int MaxFileTitle;
        public IntPtr InitialDirectory;
        public IntPtr Title;
        public int Flags;
        public short FileOffset;
        public short FileExtension;
        public IntPtr DefaultExtension;
        public IntPtr CustomData;
        public IntPtr Hook;
        public IntPtr TemplateName;
        public IntPtr ReservedPointer;
        public int ReservedInt;
        public int FlagsEx;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct BROWSEINFO
    {
        public IntPtr Owner;
        public IntPtr Root;
        public IntPtr DisplayName;
        public IntPtr Title;
        public uint Flags;
        public IntPtr Callback;
        public IntPtr Parameter;
        public int Image;
    }

    [LibraryImport("comdlg32.dll", EntryPoint = "GetOpenFileNameW")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool GetOpenFileName(ref OPENFILENAME openFileName);

    [LibraryImport("comdlg32.dll", EntryPoint = "GetSaveFileNameW")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool GetSaveFileName(ref OPENFILENAME openFileName);

    [LibraryImport("shell32.dll", EntryPoint = "SHBrowseForFolderW")]
    public static partial IntPtr SHBrowseForFolder(ref BROWSEINFO browseInfo);

    [LibraryImport("shell32.dll", EntryPoint = "SHGetPathFromIDListEx")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static unsafe partial bool SHGetPathFromIDListEx(IntPtr pidl, char* path, int length, int options);
}
