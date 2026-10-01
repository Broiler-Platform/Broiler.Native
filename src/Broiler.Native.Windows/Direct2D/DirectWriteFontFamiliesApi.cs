// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   8
// Annotated:        8/8
// Exempt:           0
// Human-reviewed:   0/8
// IP risk:          Low
// Security risk:    Critical
// Criteria:         8/8
// Resource impact:  3/10 max
// Unverified:       8
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=6C4DE2
// Broiler-Falsified-If: GetStringProc is not slot 8 of IDWriteLocalizedStrings, HRESULT GetString(UINT32 index, WCHAR* stringBuffer, UINT32 size) in dwrite.h, whose size is the capacity of stringBuffer in WCHARs, terminating null included
// Broiler-Human:        PENDING
public static class DirectWriteFontFamiliesApi
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=C6C363
    // Broiler-Falsified-If: GetSystemFontCollectionProc is not slot 3 of IDWriteFactory, HRESULT GetSystemFontCollection(IDWriteFontCollection** fontCollection, BOOL checkForUpdates) in dwrite.h, whose checkForUpdates is a 4-byte BOOL
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetSystemFontCollectionProc(IntPtr self,
        out IntPtr collection, [MarshalAs(UnmanagedType.Bool)] bool checkForUpdates);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=9E781E
    // Broiler-Falsified-If: GetFontFamilyCountProc is not slot 3 of IDWriteFontCollection, UINT32 GetFontFamilyCount() in dwrite.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint GetFontFamilyCountProc(IntPtr self);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=7109EE
    // Broiler-Falsified-If: GetFontFamilyProc is not slot 4 of IDWriteFontCollection, HRESULT GetFontFamily(UINT32 index, IDWriteFontFamily** fontFamily) in dwrite.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetFontFamilyProc(IntPtr self, uint index, out IntPtr family);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=31159B
    // Broiler-Falsified-If: GetFamilyNamesProc is not slot 6 of IDWriteFontFamily, HRESULT GetFamilyNames(IDWriteLocalizedStrings** names) in dwrite.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetFamilyNamesProc(IntPtr self, out IntPtr names);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4B03F9
    // Broiler-Falsified-If: FindLocaleNameProc is not slot 4 of IDWriteLocalizedStrings, HRESULT FindLocaleName(WCHAR const* localeName, UINT32* index, BOOL* exists) in dwrite.h, whose localeName is a null-terminated UTF-16 string and exists a 4-byte BOOL
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate int FindLocaleNameProc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string localeName, 
        out uint index, [MarshalAs(UnmanagedType.Bool)] out bool exists);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=BAB88A
    // Broiler-Falsified-If: GetStringLengthProc is not slot 7 of IDWriteLocalizedStrings, HRESULT GetStringLength(UINT32 index, UINT32* length) in dwrite.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetStringLengthProc(IntPtr self, uint index, out uint length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=15EEF0
    // Broiler-Falsified-If: GetStringProc is not slot 8 of IDWriteLocalizedStrings, HRESULT GetString(UINT32 index, WCHAR* stringBuffer, UINT32 size) in dwrite.h, whose size is the capacity of stringBuffer in WCHARs, terminating null included
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetStringProc(IntPtr self, uint index, IntPtr buffer, uint size);
}
