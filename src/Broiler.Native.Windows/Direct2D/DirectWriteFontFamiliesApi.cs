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
// Broiler-Falsified-If: GetStringProc's buffer and size reach IDWriteLocalizedStrings::GetString(UINT32, WCHAR*, UINT32) in swapped positions, so the name and its terminator are written to the address given by the capacity
// Broiler-Human:        PENDING
public static class DirectWriteFontFamiliesApi
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=C6C363
    // Broiler-Falsified-If: checkForUpdates is not marshalled as a 4-byte BOOL, so GetSystemFontCollection reads stray bits and rescans installed fonts on calls meant to reuse the collection
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetSystemFontCollectionProc(IntPtr self,
        out IntPtr collection, [MarshalAs(UnmanagedType.Bool)] bool checkForUpdates);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=9E781E
    // Broiler-Falsified-If: the UINT32 count is read as a wider type, so a loop bounded by it calls GetFontFamily with indices the collection rejects
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint GetFontFamilyCountProc(IntPtr self);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=7109EE
    // Broiler-Falsified-If: index and the family out reach IDWriteFontCollection::GetFontFamily(UINT32, IDWriteFontFamily**) in swapped positions, so the family pointer is written through the index value as an address
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetFontFamilyProc(IntPtr self, uint index, out IntPtr family);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=31159B
    // Broiler-Falsified-If: names is not declared as an out IDWriteLocalizedStrings**, so GetFamilyNames writes the strings pointer through an address formed from the caller's argument
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetFamilyNamesProc(IntPtr self, out IntPtr names);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4B03F9
    // Broiler-Falsified-If: exists is not marshalled as a 4-byte BOOL, so a locale the strings do not contain is reported as found and its unset index is used
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate int FindLocaleNameProc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string localeName, 
        out uint index, [MarshalAs(UnmanagedType.Bool)] out bool exists);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=BAB88A
    // Broiler-Falsified-If: index and the length out reach IDWriteLocalizedStrings::GetStringLength(UINT32, UINT32*) in swapped positions, so the length is written through the index value as an address
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetStringLengthProc(IntPtr self, uint index, out uint length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=15EEF0
    // Broiler-Falsified-If: buffer and size reach IDWriteLocalizedStrings::GetString(UINT32, WCHAR*, UINT32) in swapped positions, so the name and its terminator are written to the address given by the capacity
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetStringProc(IntPtr self, uint index, IntPtr buffer, uint size);
}
