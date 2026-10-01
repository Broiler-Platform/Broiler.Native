// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
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

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=782571
// Broiler-Falsified-If: a member out of mfobjects.h vtable order (GetItem at slot 3 through CopyAllItems at slot 32) sends a call to a native method whose arguments differ, so a PROPVARIANT, GUID or pointer is written through an out sized for something else
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("2CD2D921-C447-44A7-A13C-4ADABFC247E3")]
public partial interface IMFAttributes
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=CE6DAE
    // Broiler-Falsified-If: a value pointer addressing fewer than 24 bytes on x64 (16 on x86) is overrun when native code copies the stored PROPVARIANT into it
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetItem(ref Guid key, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=14817B
    // Broiler-Falsified-If: GetItemType is not vtable slot 4, directly after GetItem, so a call reaches GetItem and native code writes a whole PROPVARIANT through the 4-byte type out
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetItemType(ref Guid key, out int type);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=E2FA0C
    // Broiler-Falsified-If: a value pointer that does not address a fully initialised native-size PROPVARIANT lets native code read past it or follow a garbage string or blob pointer inside it
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CompareItem(ref Guid key, IntPtr value, [MarshalAs(UnmanagedType.Bool)] out bool result);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=FC95C3
    // Broiler-Falsified-If: result is marshalled as a 1-byte bool rather than a 4-byte BOOL, so native code writes 3 bytes past the managed out slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Compare(IMFAttributes attributes, int matchType, [MarshalAs(UnmanagedType.Bool)] out bool result);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=22EFE5
    // Broiler-Falsified-If: GetUINT32 is not vtable slot 7, so a call reaches GetUINT64 and native code writes 8 bytes through the 4-byte value out
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetUINT32(ref Guid key, out int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B0164D
    // Broiler-Falsified-If: value is declared narrower than 8 bytes, so native code writes the UINT64 past the managed out slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetUINT64(ref Guid key, out long value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E83B03
    // Broiler-Falsified-If: GetDouble is not vtable slot 9, so a call reaches GetGUID and native code writes 16 bytes through the 8-byte double out
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetDouble(ref Guid key, out double value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=04EAF7
    // Broiler-Falsified-If: GetGUID is not vtable slot 10, so a call reaches GetDouble or GetStringLength and the 16-byte out receives a value of another attribute type
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetGUID(ref Guid key, out Guid value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=CC6026
    // Broiler-Falsified-If: GetStringLength is not vtable slot 11, so a call reaches GetGUID and native code writes 16 bytes through the 4-byte length out
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetStringLength(ref Guid key, out int length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=77BE94
    // Broiler-Falsified-If: a size counted in bytes rather than UTF-16 characters lets native code write up to twice the buffer length, terminator included, into value
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetString(ref Guid key, IntPtr value, int size, out int length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=028D50
    // Broiler-Falsified-If: the pointer written to value is freed with anything other than CoTaskMemFree, or not freed, so each call leaks or corrupts the COM task-memory block holding the string
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetAllocatedString(ref Guid key, out IntPtr value, out int length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=689F15
    // Broiler-Falsified-If: GetBlobSize is not vtable slot 14, so a call reaches GetAllocatedString and native code writes a pointer through the 4-byte size out
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBlobSize(ref Guid key, out int size);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=DF996E
    // Broiler-Falsified-If: a bufferSize larger than the bytes buffer addresses lets native code copy the stored blob past the end of the caller's buffer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBlob(ref Guid key, IntPtr buffer, int bufferSize, out int blobSize);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=D95683
    // Broiler-Falsified-If: a caller copies more than the returned size bytes out of buffer and reads past the end of the CoTaskMemAlloc block
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetAllocatedBlob(ref Guid key, out IntPtr buffer, out int size);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D93F2C
    // Broiler-Falsified-If: the AddRef'd interface pointer written to value is not released by the caller, so each call leaks one reference to the stored object
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetUnknown(ref Guid key, ref Guid interfaceId, out IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=8A63F9
    // Broiler-Falsified-If: a value pointer that does not address an initialised native-size PROPVARIANT lets native code read past it and copy a garbage string or blob pointer into the store
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetItem(ref Guid key, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=74315D
    // Broiler-Falsified-If: DeleteItem is not vtable slot 19, directly after SetItem, so a call carrying only a key reaches SetItem and native code reads a PROPVARIANT through an unset argument
    // Broiler-Human:        PENDING
    [PreserveSig]
    int DeleteItem(ref Guid key);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=B3EEDA
    // Broiler-Falsified-If: DeleteAllItems is not vtable slot 20, so a call with no arguments reaches DeleteItem or SetUINT32 and native code dereferences an unset key pointer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int DeleteAllItems();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACC7DC
    // Broiler-Falsified-If: SetUINT32 is not vtable slot 21, so a call reaches SetUINT64 and the key is stored as a UINT64 that a later GetUINT32 rejects as the wrong type
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetUINT32(ref Guid key, int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=D8F6A0
    // Broiler-Falsified-If: value is declared narrower than 8 bytes, so a packed MF_MT_FRAME_SIZE or MF_MT_FRAME_RATE pair loses its high 32 bits when stored
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetUINT64(ref Guid key, long value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=0AB870
    // Broiler-Falsified-If: SetDouble is not vtable slot 23, so the double travels in a floating-point register while native code reads an integer register and stores an unrelated value
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetDouble(ref Guid key, double value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4C3268
    // Broiler-Falsified-If: SetGUID is not vtable slot 24, so a call reaches SetString and native code reads the 16-byte GUID as a NUL-terminated UTF-16 string past its end
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetGUID(ref Guid key, ref Guid value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=C88CB0
    // Broiler-Falsified-If: value is marshalled as an ANSI LPStr instead of LPWStr, so native code reads single-byte text as UTF-16 and runs past the marshalled buffer looking for a 2-byte terminator
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetString(ref Guid key, [MarshalAs(UnmanagedType.LPWStr)] string value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=643E87
    // Broiler-Falsified-If: a size larger than the bytes buffer addresses lets native code copy memory past the end of the caller's buffer into the store
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetBlob(ref Guid key, IntPtr buffer, int size);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=EB4C73
    // Broiler-Falsified-If: a value that is not a live IUnknown pointer, such as one already released, makes native code call AddRef through a freed vtable
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetUnknown(ref Guid key, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=52D8D9
    // Broiler-Falsified-If: a LockStore call is not matched by UnlockStore on every path, so another thread calling any member on the same store blocks indefinitely
    // Broiler-Human:        PENDING
    [PreserveSig]
    int LockStore();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B80F37
    // Broiler-Falsified-If: UnlockStore is not vtable slot 29, directly after LockStore, so an unlock reaches GetCount, which writes through an unset argument and leaves the store locked
    // Broiler-Human:        PENDING
    [PreserveSig]
    int UnlockStore();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C12DCA
    // Broiler-Falsified-If: GetCount is not vtable slot 30, so a call reaches GetItemByIndex and native code takes the count out pointer as an index and writes a GUID through an unset argument
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCount(out int count);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=57C3C3
    // Broiler-Falsified-If: a non-null value pointer addressing fewer than 24 bytes on x64 (16 on x86) is overrun when native code copies the indexed item's PROPVARIANT into it
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetItemByIndex(int index, out Guid key, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=F083D6
    // Broiler-Falsified-If: CopyAllItems is not the last member at vtable slot 32, so IMFActivate.ActivateObject and IMFMediaType.GetMajorType in the derived interfaces dispatch to the wrong native slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CopyAllItems(IMFAttributes destination);
}
