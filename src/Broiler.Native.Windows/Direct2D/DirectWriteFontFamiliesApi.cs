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
// Broiler-Falsified-If: a GetStringProc call whose size exceeds the WCHAR capacity of buffer makes GetString write the name and its terminator past the allocation
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
    // Broiler-Falsified-If: the HRESULT for an index equal to GetFontFamilyCount is ignored and the null family pointer it leaves is dereferenced through ComVtable
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetFontFamilyProc(IntPtr self, uint index, out IntPtr family);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=31159B
    // Broiler-Falsified-If: the IDWriteLocalizedStrings written to names is not released once per successful call, leaking one per enumerated family
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
    // Broiler-Falsified-If: the returned length is used as the GetString size with no room for the terminating NUL, so GetString fails with E_NOT_SUFFICIENT_BUFFER
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetStringLengthProc(IntPtr self, uint index, out uint length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=15EEF0
    // Broiler-Falsified-If: size is larger than the WCHAR capacity of buffer, so GetString writes the name and its NUL terminator past the end of the allocation
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetStringProc(IntPtr self, uint index, IntPtr buffer, uint size);
}
