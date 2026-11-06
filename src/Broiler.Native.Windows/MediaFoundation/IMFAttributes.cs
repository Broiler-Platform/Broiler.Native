// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// HAIRS Code Assurance
// --------------------
// Relevant units:   31
// Annotated:        31/31
// Exempt:           0
// Human-reviewed:   0/31
// IP risk:          Low
// Security risk:    Critical
// Criteria:         31/31
// Resource impact:  4/10 max
// Unverified:       31
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Broiler.Native.Windows.MediaFoundation;

// Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=782571
// Hairs-Falsified-If: the member order differs from IMFAttributes in mfobjects.h, whose vtable runs from GetItem at slot 3 to CopyAllItems at slot 32 after the three IUnknown slots
// Hairs-Human:        PENDING
[GeneratedComInterface]
[Guid("2CD2D921-C447-44A7-A13C-4ADABFC247E3")]
public partial interface IMFAttributes
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=CE6DAE
    // Hairs-Falsified-If: is not slot 3 of IMFAttributes, HRESULT GetItem(REFGUID guidKey, PROPVARIANT *pValue) in mfobjects.h, or value addresses fewer than the 24 bytes a PROPVARIANT from propidl.h takes on 64-bit
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetItem(ref Guid key, IntPtr value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=14817B
    // Hairs-Falsified-If: is not slot 4 of IMFAttributes, HRESULT GetItemType(REFGUID guidKey, MF_ATTRIBUTE_TYPE *pType) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetItemType(ref Guid key, out int type);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=E2FA0C
    // Hairs-Falsified-If: is not slot 5 of IMFAttributes, HRESULT CompareItem(REFGUID guidKey, REFPROPVARIANT Value, BOOL *pbResult) in mfobjects.h, or result is marshalled narrower than the 4-byte BOOL
    // Hairs-Human:        PENDING
    [PreserveSig]
    int CompareItem(ref Guid key, IntPtr value, [MarshalAs(UnmanagedType.Bool)] out bool result);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=FC95C3
    // Hairs-Falsified-If: is not slot 6 of IMFAttributes, HRESULT Compare(IMFAttributes *pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL *pbResult) in mfobjects.h, or result is marshalled narrower than the 4-byte BOOL
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Compare(IMFAttributes attributes, int matchType, [MarshalAs(UnmanagedType.Bool)] out bool result);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=22EFE5
    // Hairs-Falsified-If: is not slot 7 of IMFAttributes, HRESULT GetUINT32(REFGUID guidKey, UINT32 *punValue) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetUINT32(ref Guid key, out int value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B0164D
    // Hairs-Falsified-If: is not slot 8 of IMFAttributes, HRESULT GetUINT64(REFGUID guidKey, UINT64 *punValue) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetUINT64(ref Guid key, out long value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E83B03
    // Hairs-Falsified-If: is not slot 9 of IMFAttributes, HRESULT GetDouble(REFGUID guidKey, double *pfValue) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetDouble(ref Guid key, out double value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=04EAF7
    // Hairs-Falsified-If: is not slot 10 of IMFAttributes, HRESULT GetGUID(REFGUID guidKey, GUID *pguidValue) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetGUID(ref Guid key, out Guid value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=CC6026
    // Hairs-Falsified-If: is not slot 11 of IMFAttributes, HRESULT GetStringLength(REFGUID guidKey, UINT32 *pcchLength) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetStringLength(ref Guid key, out int length);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=77BE94
    // Hairs-Falsified-If: is not slot 12 of IMFAttributes, HRESULT GetString(REFGUID guidKey, LPWSTR pwszValue, UINT32 cchBufSize, UINT32 *pcchLength) in mfobjects.h, or size is larger than the number of WCHARs the buffer at value holds
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetString(ref Guid key, IntPtr value, int size, out int length);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=028D50
    // Hairs-Falsified-If: is not slot 13 of IMFAttributes, HRESULT GetAllocatedString(REFGUID guidKey, LPWSTR *ppwszValue, UINT32 *pcchLength) in mfobjects.h, or the string written to value is not released with CoTaskMemFree
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetAllocatedString(ref Guid key, out IntPtr value, out int length);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=689F15
    // Hairs-Falsified-If: is not slot 14 of IMFAttributes, HRESULT GetBlobSize(REFGUID guidKey, UINT32 *pcbBlobSize) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetBlobSize(ref Guid key, out int size);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=DF996E
    // Hairs-Falsified-If: is not slot 15 of IMFAttributes, HRESULT GetBlob(REFGUID guidKey, UINT8 *pBuf, UINT32 cbBufSize, UINT32 *pcbBlobSize) in mfobjects.h, or bufferSize is larger than the number of bytes the buffer at buffer holds
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetBlob(ref Guid key, IntPtr buffer, int bufferSize, out int blobSize);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=D95683
    // Hairs-Falsified-If: is not slot 16 of IMFAttributes, HRESULT GetAllocatedBlob(REFGUID guidKey, UINT8 **ppBuf, UINT32 *pcbSize) in mfobjects.h, or the blob written to buffer is not released with CoTaskMemFree
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetAllocatedBlob(ref Guid key, out IntPtr buffer, out int size);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D93F2C
    // Hairs-Falsified-If: is not slot 17 of IMFAttributes, HRESULT GetUnknown(REFGUID guidKey, REFIID riid, LPVOID *ppv) in mfobjects.h, or the caller does not Release the interface reference written to value
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetUnknown(ref Guid key, ref Guid interfaceId, out IntPtr value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=8A63F9
    // Hairs-Falsified-If: is not slot 18 of IMFAttributes, HRESULT SetItem(REFGUID guidKey, REFPROPVARIANT Value) in mfobjects.h, or value addresses fewer than the 24 bytes a PROPVARIANT from propidl.h takes on 64-bit
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetItem(ref Guid key, IntPtr value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=74315D
    // Hairs-Falsified-If: is not slot 19 of IMFAttributes, HRESULT DeleteItem(REFGUID guidKey) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int DeleteItem(ref Guid key);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=B3EEDA
    // Hairs-Falsified-If: is not slot 20 of IMFAttributes, HRESULT DeleteAllItems(void) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int DeleteAllItems();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACC7DC
    // Hairs-Falsified-If: is not slot 21 of IMFAttributes, HRESULT SetUINT32(REFGUID guidKey, UINT32 unValue) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetUINT32(ref Guid key, int value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=D8F6A0
    // Hairs-Falsified-If: is not slot 22 of IMFAttributes, HRESULT SetUINT64(REFGUID guidKey, UINT64 unValue) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetUINT64(ref Guid key, long value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=0AB870
    // Hairs-Falsified-If: is not slot 23 of IMFAttributes, HRESULT SetDouble(REFGUID guidKey, double fValue) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetDouble(ref Guid key, double value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4C3268
    // Hairs-Falsified-If: is not slot 24 of IMFAttributes, HRESULT SetGUID(REFGUID guidKey, REFGUID guidValue) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetGUID(ref Guid key, ref Guid value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=C88CB0
    // Hairs-Falsified-If: is not slot 25 of IMFAttributes, HRESULT SetString(REFGUID guidKey, LPCWSTR wszValue) in mfobjects.h, or value reaches it as anything but NUL-terminated UTF-16
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetString(ref Guid key, [MarshalAs(UnmanagedType.LPWStr)] string value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=643E87
    // Hairs-Falsified-If: is not slot 26 of IMFAttributes, HRESULT SetBlob(REFGUID guidKey, const UINT8 *pBuf, UINT32 cbBufSize) in mfobjects.h, or size is larger than the number of bytes the buffer at buffer holds
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetBlob(ref Guid key, IntPtr buffer, int size);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=EB4C73
    // Hairs-Falsified-If: is not slot 27 of IMFAttributes, HRESULT SetUnknown(REFGUID guidKey, IUnknown *pUnknown) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetUnknown(ref Guid key, IntPtr value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=52D8D9
    // Hairs-Falsified-If: is not slot 28 of IMFAttributes, HRESULT LockStore(void) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int LockStore();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B80F37
    // Hairs-Falsified-If: is not slot 29 of IMFAttributes, HRESULT UnlockStore(void) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int UnlockStore();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C12DCA
    // Hairs-Falsified-If: is not slot 30 of IMFAttributes, HRESULT GetCount(UINT32 *pcItems) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetCount(out int count);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=57C3C3
    // Hairs-Falsified-If: is not slot 31 of IMFAttributes, HRESULT GetItemByIndex(UINT32 unIndex, GUID *pguidKey, PROPVARIANT *pValue) in mfobjects.h, or value addresses fewer than the 24 bytes a PROPVARIANT from propidl.h takes on 64-bit
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetItemByIndex(int index, out Guid key, IntPtr value);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=F083D6
    // Hairs-Falsified-If: is not slot 32 of IMFAttributes, HRESULT CopyAllItems(IMFAttributes *pDest) in mfobjects.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int CopyAllItems(IMFAttributes destination);
}
