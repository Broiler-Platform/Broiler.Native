// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   87
// Annotated:        87/87
// Exempt:           30
// Human-reviewed:   0/87
// IP risk:          Low
// Security risk:    Critical
// Criteria:         87/87
// Resource impact:  7/10 max
// Unverified:       87
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Broiler.Native.Windows.MediaFoundation.Capture;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=2038F3
// Broiler-Falsified-If: one of its imports differs from its SDK prototype, MFEnumDeviceSources or MFCreateDeviceSource in mfidl.h or MFCreateSourceReaderFromMediaSource in mfreadwrite.h
// Broiler-Human:        PENDING
public static partial class WindowsMediaFoundationNative
{

    public const int MF_SOURCE_READER_FIRST_VIDEO_STREAM = unchecked((int)0xFFFFFFFC);
    public const int MF_SOURCE_READER_CURRENT_TYPE_INDEX = unchecked((int)0xFFFFFFFF);

    public static readonly Guid IMFMediaSourceId = new("279A808D-AEC7-40C8-9C6B-A6B492C78A66");
    public static readonly Guid MFMediaTypeVideo = new("73646976-0000-0010-8000-00AA00389B71");
    public static readonly Guid MFVideoFormatRgb32 = new("00000016-0000-0010-8000-00AA00389B71");
    public static readonly Guid MFVideoFormatRgb24 = new("00000014-0000-0010-8000-00AA00389B71");
    public static readonly Guid MFVideoFormatNv12 = new("3231564E-0000-0010-8000-00AA00389B71");
    public static readonly Guid MFVideoFormatYuy2 = new("32595559-0000-0010-8000-00AA00389B71");
    public static readonly Guid MFVideoFormatMjpg = new("47504A4D-0000-0010-8000-00AA00389B71");
    public static readonly Guid MFVideoFormatL8 = new("00000032-0000-0010-8000-00AA00389B71");

    public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE = new("C60AC5FE-252A-478F-A0EF-BC8FA5F7CAD3");
    public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUID = new("8AC3587A-4AE7-42D8-99E0-0A6013EEF90F");
    public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_FRIENDLY_NAME = new("60D0E559-52F8-4FA2-BBCE-ACDB34A8EC01");
    public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_SYMBOLIC_LINK = new("58F0AAD8-22BF-4F8A-BB3D-D2C4978C6E2F");
    public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_FRAMESERVER_SHARE_MODE = new("44D1A9BC-2999-4238-AE43-0730CEB2AB1B");

    public static readonly Guid MF_MT_MAJOR_TYPE = new("48EBA18E-F8C9-4687-BF11-0A74C9F96A8F");
    public static readonly Guid MF_MT_SUBTYPE = new("F7E34C9A-42E8-4714-B74B-CB29D72C35E5");
    public static readonly Guid MF_MT_FRAME_SIZE = new("1652C33D-D6B2-4012-B834-72030849A37D");
    public static readonly Guid MF_MT_FRAME_RATE = new("C459A2E8-3D2C-4E44-B132-FEE5156C7BB0");
    public static readonly Guid MF_MT_DEFAULT_STRIDE = new("644B4E48-1E02-4516-B0EB-C01CA9D49AC6");
    public static readonly Guid MF_SOURCE_READER_ENABLE_ADVANCED_VIDEO_PROCESSING = new("0F81DA2C-B537-4672-A8B2-A681B17307A3");
    public static readonly Guid MF_SOURCE_READER_DISCONNECT_MEDIASOURCE_ON_SHUTDOWN = new("56B67165-219E-456D-A22E-2D3004C7FE56");

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=8E6AB1
    // Broiler-Falsified-If: differs from STDAPI MFEnumDeviceSources(IMFAttributes* pAttributes, IMFActivate*** pppSourceActivate, UINT32* pcSourceActivate) in mfidl.h, where devices receives an array of count IMFActivate references the caller must each Release and then free with CoTaskMemFree
    // Broiler-Human:        PENDING
    [LibraryImport("mf.dll")]
    public static partial int MFEnumDeviceSources(IMFAttributes attributes, out IntPtr devices, out uint count);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=8FEFF4
    // Broiler-Falsified-If: differs from STDAPI MFCreateDeviceSource(IMFAttributes* pAttributes, IMFMediaSource** ppSource) in mfidl.h, whose ppSource reference must pass to the returned wrapper and be released once with it
    // Broiler-Human:        PENDING
    [LibraryImport("mf.dll")]
    public static partial int MFCreateDeviceSource(IMFAttributes attributes, out IMFMediaSource mediaSource);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=1B4E53
    // Broiler-Falsified-If: differs from STDAPI MFCreateSourceReaderFromMediaSource(IMFMediaSource *pMediaSource, IMFAttributes *pAttributes, IMFSourceReader **ppSourceReader) in mfreadwrite.h, or a null attributes does not arrive as the null pointer the _In_opt_ pAttributes allows
    // Broiler-Human:        PENDING
    [LibraryImport("mfreadwrite.dll")]
    public static partial int MFCreateSourceReaderFromMediaSource(IMFMediaSource mediaSource, IMFAttributes? attributes,
        out IMFSourceReader sourceReader);

}

[Flags]
public enum SourceReaderFlags
{
    None = 0,
    Error = 0x00000001,
    EndOfStream = 0x00000002,
    NewStream = 0x00000004,
    NativeMediaTypeChanged = 0x00000010,
    CurrentMediaTypeChanged = 0x00000020,
    StreamTick = 0x00000100,
}

// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=9CE72D
// Broiler-Falsified-If: its vtable differs from IMFActivate : public IMFAttributes in mfobjects.h, the 30 IMFAttributes methods at slots 3 to 32, then ActivateObject at slot 33 through DetachObject at slot 35
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("7FEE9E9A-4A89-47A6-899C-B6A53A70FB67")]
public partial interface IMFActivate : IMFAttributes
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=9210BC
    // Broiler-Falsified-If: is not slot 33 of IMFActivate, HRESULT ActivateObject(REFIID riid, void **ppv) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int ActivateObject(ref Guid interfaceId, out IntPtr activatedObject);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B2D4A2
    // Broiler-Falsified-If: is not slot 34 of IMFActivate, HRESULT ShutdownObject(void) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int ShutdownObject();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=3D143C
    // Broiler-Falsified-If: is not slot 35 of IMFActivate, HRESULT DetachObject(void) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int DetachObject();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=0E895F
// Broiler-Falsified-If: its vtable differs from IMFMediaSource : public IMFMediaEventGenerator in mfidl.h, GetEvent at slot 3 through QueueEvent at slot 6 from mfobjects.h, then GetCharacteristics at slot 7 through Shutdown at slot 12
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("279A808D-AEC7-40C8-9C6B-A6B492C78A66")]
public partial interface IMFMediaSource
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=0E5E8D
    // Broiler-Falsified-If: is not slot 3 of IMFMediaSource, HRESULT GetEvent(DWORD dwFlags, IMFMediaEvent **ppEvent) of IMFMediaEventGenerator in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetEvent(int flags, out IntPtr mediaEvent);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=A2701C
    // Broiler-Falsified-If: is not slot 4 of IMFMediaSource, HRESULT BeginGetEvent(IMFAsyncCallback *pCallback, IUnknown *punkState) of IMFMediaEventGenerator in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int BeginGetEvent(IntPtr callback, IntPtr state);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=F27CE9
    // Broiler-Falsified-If: is not slot 5 of IMFMediaSource, HRESULT EndGetEvent(IMFAsyncResult *pResult, IMFMediaEvent **ppEvent) of IMFMediaEventGenerator in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int EndGetEvent(IntPtr result, out IntPtr mediaEvent);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=0CB8DF
    // Broiler-Falsified-If: is not slot 6 of IMFMediaSource, HRESULT QueueEvent(MediaEventType met, REFGUID guidExtendedType, HRESULT hrStatus, const PROPVARIANT *pvValue) of IMFMediaEventGenerator in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int QueueEvent(int mediaEventType, ref Guid extendedType, int status, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=233D25
    // Broiler-Falsified-If: is not slot 7 of IMFMediaSource, HRESULT GetCharacteristics(DWORD *pdwCharacteristics) in mfidl.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCharacteristics(out int characteristics);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=DFC700
    // Broiler-Falsified-If: is not slot 8 of IMFMediaSource, HRESULT CreatePresentationDescriptor(IMFPresentationDescriptor **ppPresentationDescriptor) in mfidl.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CreatePresentationDescriptor(out IntPtr presentationDescriptor);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=007B5F
    // Broiler-Falsified-If: is not slot 9 of IMFMediaSource, HRESULT Start(IMFPresentationDescriptor *pPresentationDescriptor, const GUID *pguidTimeFormat, const PROPVARIANT *pvarStartPosition) in mfidl.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Start(IntPtr presentationDescriptor, ref Guid timeFormat, IntPtr startPosition);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=458393
    // Broiler-Falsified-If: is not slot 10 of IMFMediaSource, HRESULT Stop(void) in mfidl.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Stop();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=3DEE33
    // Broiler-Falsified-If: is not slot 11 of IMFMediaSource, HRESULT Pause(void) in mfidl.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Pause();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B383A8
    // Broiler-Falsified-If: is not slot 12 of IMFMediaSource, HRESULT Shutdown(void) in mfidl.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Shutdown();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=0511AF
// Broiler-Falsified-If: its vtable differs from IMFMediaType : public IMFAttributes in mfobjects.h, the 30 IMFAttributes methods at slots 3 to 32, then GetMajorType at slot 33 through FreeRepresentation at slot 37
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("44AE0FA8-EA31-4109-8D2E-4CAE4997C555")]
public partial interface IMFMediaType : IMFAttributes
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A1D09D
    // Broiler-Falsified-If: is not slot 33 of IMFMediaType, HRESULT GetMajorType(GUID *pguidMajorType) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetMajorType(out Guid majorType);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=8C2475
    // Broiler-Falsified-If: compressed is marshalled narrower than the 4-byte BOOL of HRESULT IsCompressedFormat(BOOL *pfCompressed), slot 34 of IMFMediaType in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int IsCompressedFormat([MarshalAs(UnmanagedType.Bool)] out bool compressed);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=01BD88
    // Broiler-Falsified-If: is not slot 35 of IMFMediaType, HRESULT IsEqual(IMFMediaType *pIMediaType, DWORD *pdwFlags) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int IsEqual(IMFMediaType mediaType, out int flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=C437BF
    // Broiler-Falsified-If: is not slot 36 of IMFMediaType, HRESULT GetRepresentation(GUID guidRepresentation, LPVOID *ppvRepresentation) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetRepresentation(Guid representation, out IntPtr representationData);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=E8E537
    // Broiler-Falsified-If: is not slot 37 of IMFMediaType, HRESULT FreeRepresentation(GUID guidRepresentation, LPVOID pvRepresentation) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int FreeRepresentation(Guid representation, IntPtr representationData);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=0EC939
// Broiler-Falsified-If: its vtable differs from IMFSourceReader : public IUnknown in mfreadwrite.h, GetStreamSelection at slot 3 through GetPresentationAttribute at slot 12
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("70AE66F2-C809-4E4F-8915-BDCB406B7993")]
public partial interface IMFSourceReader
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=ACDBE9
    // Broiler-Falsified-If: selected is marshalled narrower than the 4-byte BOOL of HRESULT GetStreamSelection(DWORD dwStreamIndex, BOOL *pfSelected), slot 3 of IMFSourceReader in mfreadwrite.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetStreamSelection(int streamIndex, [MarshalAs(UnmanagedType.Bool)] out bool selected);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=37F403
    // Broiler-Falsified-If: selected is passed narrower than the 4-byte BOOL of HRESULT SetStreamSelection(DWORD dwStreamIndex, BOOL fSelected), slot 4 of IMFSourceReader in mfreadwrite.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetStreamSelection(int streamIndex, [MarshalAs(UnmanagedType.Bool)] bool selected);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=191BB5
    // Broiler-Falsified-If: is not slot 5 of IMFSourceReader, HRESULT GetNativeMediaType(DWORD dwStreamIndex, DWORD dwMediaTypeIndex, IMFMediaType **ppMediaType) in mfreadwrite.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetNativeMediaType(int streamIndex, int mediaTypeIndex, out IMFMediaType mediaType);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=CAC63C
    // Broiler-Falsified-If: is not slot 6 of IMFSourceReader, HRESULT GetCurrentMediaType(DWORD dwStreamIndex, IMFMediaType **ppMediaType) in mfreadwrite.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCurrentMediaType(int streamIndex, out IMFMediaType mediaType);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=57AE9A
    // Broiler-Falsified-If: is not slot 7 of IMFSourceReader, HRESULT SetCurrentMediaType(DWORD dwStreamIndex, DWORD *pdwReserved, IMFMediaType *pMediaType) in mfreadwrite.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetCurrentMediaType(int streamIndex, IntPtr reserved, IMFMediaType mediaType);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=CF62FB
    // Broiler-Falsified-If: is not slot 8 of IMFSourceReader, HRESULT SetCurrentPosition(REFGUID guidTimeFormat, REFPROPVARIANT varPosition) in mfreadwrite.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetCurrentPosition(ref Guid timeFormat, IntPtr position);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=7; Fingerprint=2D7F72
    // Broiler-Falsified-If: is not slot 9 of IMFSourceReader, HRESULT ReadSample(DWORD dwStreamIndex, DWORD dwControlFlags, DWORD *pdwActualStreamIndex, DWORD *pdwStreamFlags, LONGLONG *pllTimestamp, IMFSample **ppSample) in mfreadwrite.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int ReadSample(int streamIndex, int controlFlags, out int actualStreamIndex, out SourceReaderFlags streamFlags,
        out long timestamp, out IMFSample? sample);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=7D05AD
    // Broiler-Falsified-If: is not slot 10 of IMFSourceReader, HRESULT Flush(DWORD dwStreamIndex) in mfreadwrite.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Flush(int streamIndex);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=26A506
    // Broiler-Falsified-If: is not slot 11 of IMFSourceReader, HRESULT GetServiceForStream(DWORD dwStreamIndex, REFGUID guidService, REFIID riid, LPVOID *ppvObject) in mfreadwrite.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetServiceForStream(int streamIndex, ref Guid service, ref Guid interfaceId, out IntPtr serviceObject);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=05DCB9
    // Broiler-Falsified-If: is not slot 12 of IMFSourceReader, HRESULT GetPresentationAttribute(DWORD dwStreamIndex, REFGUID guidAttribute, PROPVARIANT *pvarAttribute) in mfreadwrite.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetPresentationAttribute(int streamIndex, ref Guid attribute, IntPtr value);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=AA199C
// Broiler-Falsified-If: its vtable differs from IMFSample : public IMFAttributes in mfobjects.h, the inherited GetItem at slot 3 through CopyAllItems at slot 32 declared inline, then GetSampleFlags at slot 33 through CopyToBuffer at slot 46
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("C40A00F2-B93A-4D80-AE8C-5A1C634F58E4")]
public partial interface IMFSample
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=CE6DAE
    // Broiler-Falsified-If: is not slot 3 of IMFSample, HRESULT GetItem(REFGUID guidKey, PROPVARIANT *pValue) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetItem(ref Guid key, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=14817B
    // Broiler-Falsified-If: is not slot 4 of IMFSample, HRESULT GetItemType(REFGUID guidKey, MF_ATTRIBUTE_TYPE *pType) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetItemType(ref Guid key, out int type);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=E2FA0C
    // Broiler-Falsified-If: result is marshalled narrower than the 4-byte BOOL of HRESULT CompareItem(REFGUID guidKey, REFPROPVARIANT Value, BOOL *pbResult), slot 5 of IMFSample from IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CompareItem(ref Guid key, IntPtr value, [MarshalAs(UnmanagedType.Bool)] out bool result);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=FC95C3
    // Broiler-Falsified-If: result is marshalled narrower than the 4-byte BOOL of HRESULT Compare(IMFAttributes *pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL *pbResult), slot 6 of IMFSample from IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Compare(IMFAttributes attributes, int matchType, [MarshalAs(UnmanagedType.Bool)] out bool result);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=22EFE5
    // Broiler-Falsified-If: is not slot 7 of IMFSample, HRESULT GetUINT32(REFGUID guidKey, UINT32 *punValue) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetUINT32(ref Guid key, out int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B0164D
    // Broiler-Falsified-If: is not slot 8 of IMFSample, HRESULT GetUINT64(REFGUID guidKey, UINT64 *punValue) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetUINT64(ref Guid key, out long value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E83B03
    // Broiler-Falsified-If: is not slot 9 of IMFSample, HRESULT GetDouble(REFGUID guidKey, double *pfValue) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetDouble(ref Guid key, out double value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=04EAF7
    // Broiler-Falsified-If: is not slot 10 of IMFSample, HRESULT GetGUID(REFGUID guidKey, GUID *pguidValue) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetGUID(ref Guid key, out Guid value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=CC6026
    // Broiler-Falsified-If: is not slot 11 of IMFSample, HRESULT GetStringLength(REFGUID guidKey, UINT32 *pcchLength) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetStringLength(ref Guid key, out int length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=77BE94
    // Broiler-Falsified-If: differs from HRESULT GetString(REFGUID guidKey, LPWSTR pwszValue, UINT32 cchBufSize, UINT32 *pcchLength), slot 12 of IMFSample from IMFAttributes in mfobjects.h, where size counts the WCHARs value can hold, not its bytes
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetString(ref Guid key, IntPtr value, int size, out int length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=028D50
    // Broiler-Falsified-If: differs from HRESULT GetAllocatedString(REFGUID guidKey, LPWSTR *ppwszValue, UINT32 *pcchLength), slot 13 of IMFSample from IMFAttributes in mfobjects.h, whose value string of length plus 1 WCHARs the caller owns and must free with CoTaskMemFree
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetAllocatedString(ref Guid key, out IntPtr value, out int length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=689F15
    // Broiler-Falsified-If: is not slot 14 of IMFSample, HRESULT GetBlobSize(REFGUID guidKey, UINT32 *pcbBlobSize) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBlobSize(ref Guid key, out int size);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=DF996E
    // Broiler-Falsified-If: differs from HRESULT GetBlob(REFGUID guidKey, UINT8 *pBuf, UINT32 cbBufSize, UINT32 *pcbBlobSize), slot 15 of IMFSample from IMFAttributes in mfobjects.h, where bufferSize is the byte capacity of buffer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBlob(ref Guid key, IntPtr buffer, int bufferSize, out int blobSize);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=D95683
    // Broiler-Falsified-If: differs from HRESULT GetAllocatedBlob(REFGUID guidKey, UINT8 **ppBuf, UINT32 *pcbSize), slot 16 of IMFSample from IMFAttributes in mfobjects.h, whose buffer of size bytes the caller owns and must free with CoTaskMemFree
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetAllocatedBlob(ref Guid key, out IntPtr buffer, out int size);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D93F2C
    // Broiler-Falsified-If: is not slot 17 of IMFSample, HRESULT GetUnknown(REFGUID guidKey, REFIID riid, LPVOID *ppv) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetUnknown(ref Guid key, ref Guid interfaceId, out IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=8A63F9
    // Broiler-Falsified-If: is not slot 18 of IMFSample, HRESULT SetItem(REFGUID guidKey, REFPROPVARIANT Value) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetItem(ref Guid key, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=74315D
    // Broiler-Falsified-If: is not slot 19 of IMFSample, HRESULT DeleteItem(REFGUID guidKey) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int DeleteItem(ref Guid key);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=B3EEDA
    // Broiler-Falsified-If: is not slot 20 of IMFSample, HRESULT DeleteAllItems(void) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int DeleteAllItems();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACC7DC
    // Broiler-Falsified-If: is not slot 21 of IMFSample, HRESULT SetUINT32(REFGUID guidKey, UINT32 unValue) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetUINT32(ref Guid key, int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=D8F6A0
    // Broiler-Falsified-If: is not slot 22 of IMFSample, HRESULT SetUINT64(REFGUID guidKey, UINT64 unValue) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetUINT64(ref Guid key, long value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=0AB870
    // Broiler-Falsified-If: is not slot 23 of IMFSample, HRESULT SetDouble(REFGUID guidKey, double fValue) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetDouble(ref Guid key, double value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4C3268
    // Broiler-Falsified-If: is not slot 24 of IMFSample, HRESULT SetGUID(REFGUID guidKey, REFGUID guidValue) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetGUID(ref Guid key, ref Guid value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=C88CB0
    // Broiler-Falsified-If: value is not marshalled as the null-terminated UTF-16 LPCWSTR of HRESULT SetString(REFGUID guidKey, LPCWSTR wszValue), slot 25 of IMFSample from IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetString(ref Guid key, [MarshalAs(UnmanagedType.LPWStr)] string value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=643E87
    // Broiler-Falsified-If: differs from HRESULT SetBlob(REFGUID guidKey, const UINT8 *pBuf, UINT32 cbBufSize), slot 26 of IMFSample from IMFAttributes in mfobjects.h, where size is the number of bytes read from buffer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetBlob(ref Guid key, IntPtr buffer, int size);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=EB4C73
    // Broiler-Falsified-If: is not slot 27 of IMFSample, HRESULT SetUnknown(REFGUID guidKey, IUnknown *pUnknown) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetUnknown(ref Guid key, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=52D8D9
    // Broiler-Falsified-If: is not slot 28 of IMFSample, HRESULT LockStore(void) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int LockStore();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B80F37
    // Broiler-Falsified-If: is not slot 29 of IMFSample, HRESULT UnlockStore(void) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int UnlockStore();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C12DCA
    // Broiler-Falsified-If: is not slot 30 of IMFSample, HRESULT GetCount(UINT32 *pcItems) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCount(out int count);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=57C3C3
    // Broiler-Falsified-If: is not slot 31 of IMFSample, HRESULT GetItemByIndex(UINT32 unIndex, GUID *pguidKey, PROPVARIANT *pValue) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetItemByIndex(int index, out Guid key, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=F083D6
    // Broiler-Falsified-If: is not slot 32 of IMFSample, HRESULT CopyAllItems(IMFAttributes *pDest) of IMFAttributes in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CopyAllItems(IMFAttributes destination);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=28DCB0
    // Broiler-Falsified-If: is not slot 33 of IMFSample, HRESULT GetSampleFlags(DWORD *pdwSampleFlags) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetSampleFlags(out int flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=119402
    // Broiler-Falsified-If: is not slot 34 of IMFSample, HRESULT SetSampleFlags(DWORD dwSampleFlags) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetSampleFlags(int flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=36A75E
    // Broiler-Falsified-If: is not slot 35 of IMFSample, HRESULT GetSampleTime(LONGLONG *phnsSampleTime) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetSampleTime(out long sampleTime);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=58104B
    // Broiler-Falsified-If: is not slot 36 of IMFSample, HRESULT SetSampleTime(LONGLONG hnsSampleTime) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetSampleTime(long sampleTime);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=895682
    // Broiler-Falsified-If: is not slot 37 of IMFSample, HRESULT GetSampleDuration(LONGLONG *phnsSampleDuration) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetSampleDuration(out long sampleDuration);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=3D6461
    // Broiler-Falsified-If: is not slot 38 of IMFSample, HRESULT SetSampleDuration(LONGLONG hnsSampleDuration) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetSampleDuration(long sampleDuration);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B473B3
    // Broiler-Falsified-If: is not slot 39 of IMFSample, HRESULT GetBufferCount(DWORD *pdwBufferCount) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBufferCount(out int bufferCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=2959BC
    // Broiler-Falsified-If: is not slot 40 of IMFSample, HRESULT GetBufferByIndex(DWORD dwIndex, IMFMediaBuffer **ppBuffer) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBufferByIndex(int index, out IMFMediaBuffer buffer);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=799F86
    // Broiler-Falsified-If: is not slot 41 of IMFSample, HRESULT ConvertToContiguousBuffer(IMFMediaBuffer **ppBuffer) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int ConvertToContiguousBuffer(out IMFMediaBuffer buffer);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=35F355
    // Broiler-Falsified-If: is not slot 42 of IMFSample, HRESULT AddBuffer(IMFMediaBuffer *pBuffer) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int AddBuffer(IMFMediaBuffer buffer);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=AB56F6
    // Broiler-Falsified-If: is not slot 43 of IMFSample, HRESULT RemoveBufferByIndex(DWORD dwIndex) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int RemoveBufferByIndex(int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=2BC579
    // Broiler-Falsified-If: is not slot 44 of IMFSample, HRESULT RemoveAllBuffers(void) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int RemoveAllBuffers();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B86A11
    // Broiler-Falsified-If: is not slot 45 of IMFSample, HRESULT GetTotalLength(DWORD *pcbTotalLength) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetTotalLength(out int totalLength);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=5C8BE2
    // Broiler-Falsified-If: is not slot 46 of IMFSample, HRESULT CopyToBuffer(IMFMediaBuffer *pBuffer) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CopyToBuffer(IMFMediaBuffer buffer);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=59E929
// Broiler-Falsified-If: its vtable differs from IMFMediaBuffer : public IUnknown in mfobjects.h, Lock at slot 3 through GetMaxLength at slot 7
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("045FA593-8799-42B8-BC8D-8968C6453507")]
public partial interface IMFMediaBuffer
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=B58521
    // Broiler-Falsified-If: differs from HRESULT Lock(BYTE **ppbBuffer, DWORD *pcbMaxLength, DWORD *pcbCurrentLength), slot 3 of IMFMediaBuffer in mfobjects.h, whose buffer holds maxLength bytes of which only currentLength are valid until Unlock
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Lock(out IntPtr buffer, out int maxLength, out int currentLength);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=82E696
    // Broiler-Falsified-If: is not slot 4 of IMFMediaBuffer, HRESULT Unlock(void) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Unlock();

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=BA0C7A
    // Broiler-Falsified-If: is not slot 5 of IMFMediaBuffer, HRESULT GetCurrentLength(DWORD *pcbCurrentLength) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCurrentLength(out int currentLength);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=6EBEA5
    // Broiler-Falsified-If: is not slot 6 of IMFMediaBuffer, HRESULT SetCurrentLength(DWORD cbCurrentLength) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetCurrentLength(int currentLength);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=5A8655
    // Broiler-Falsified-If: is not slot 7 of IMFMediaBuffer, HRESULT GetMaxLength(DWORD *pcbMaxLength) in mfobjects.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetMaxLength(out int maxLength);
}
