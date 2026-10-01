// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   110
// Annotated:        110/110
// Exempt:           7
// Human-reviewed:   0/110
// IP risk:          Low
// Security risk:    Critical
// Criteria:         110/104
// Resource impact:  7/10 max
// Unverified:       110
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Broiler.Native.Windows.MediaFoundation.Capture;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=2038F3
// Broiler-Falsified-If: an out parameter of a binding here differs in width from its SDK prototype (the UINT32* device count, the IMFActivate*** array), so native code writes the count or pointer into a slot of the wrong size
// Broiler-Human:        PENDING
public static partial class WindowsMediaFoundationNative
{

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=3AD40B
    // Broiler-Falsified-If: the value differs from 0xFFFFFFFC in mfreadwrite.h, so ReadSample and SetCurrentMediaType address a stream other than the first video stream
    // Broiler-Human:        PENDING
    public const int MF_SOURCE_READER_FIRST_VIDEO_STREAM = unchecked((int)0xFFFFFFFC);
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=2509CB
    // Broiler-Falsified-If: the value differs from 0xFFFFFFFF in mfreadwrite.h, so GetNativeMediaType returns an enumerated native type instead of the current one
    // Broiler-Human:        PENDING
    public const int MF_SOURCE_READER_CURRENT_TYPE_INDEX = unchecked((int)0xFFFFFFFF);

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=ED103B
    // Broiler-Falsified-If: the value differs from the IMFMediaSource IID 279A808D-AEC7-40C8-9C6B-A6B492C78A66, so ActivateObject returns a pointer to another interface that is then called through IMFMediaSource vtable slots
    // Broiler-Human:        PENDING
    public static readonly Guid IMFMediaSourceId = new("279A808D-AEC7-40C8-9C6B-A6B492C78A66");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=FAAD7A
    // Broiler-Falsified-If: the value differs from MFMediaType_Video 73646976-0000-0010-8000-00AA00389B71 in mfapi.h, so a video media type is rejected as non-video or another major type is accepted as video frames
    // Broiler-Human:        PENDING
    public static readonly Guid MFMediaTypeVideo = new("73646976-0000-0010-8000-00AA00389B71");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E64E37
    // Broiler-Falsified-If: the value is not the media-type GUID built from D3DFMT_X8R8G8B8 (22, 0x16), so frames of another subtype are read as 4 bytes per pixel
    // Broiler-Human:        PENDING
    public static readonly Guid MFVideoFormatRgb32 = new("00000016-0000-0010-8000-00AA00389B71");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=718C4A
    // Broiler-Falsified-If: the value is not the media-type GUID built from D3DFMT_R8G8B8 (20, 0x14), so frames of another subtype are read as 3 bytes per pixel
    // Broiler-Human:        PENDING
    public static readonly Guid MFVideoFormatRgb24 = new("00000014-0000-0010-8000-00AA00389B71");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=82DCC0
    // Broiler-Falsified-If: the value is not the media-type GUID built from FourCC NV12 (0x3231564E), so frames of another subtype are split into a luma plane and an interleaved chroma plane
    // Broiler-Human:        PENDING
    public static readonly Guid MFVideoFormatNv12 = new("3231564E-0000-0010-8000-00AA00389B71");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E0932E
    // Broiler-Falsified-If: the value is not the media-type GUID built from FourCC YUY2 (0x32595559), so frames of another subtype are read as packed 4:2:2 at 2 bytes per pixel
    // Broiler-Human:        PENDING
    public static readonly Guid MFVideoFormatYuy2 = new("32595559-0000-0010-8000-00AA00389B71");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=D7648A
    // Broiler-Falsified-If: the value is not the media-type GUID built from FourCC MJPG (0x47504A4D), so compressed JPEG frames are reported as an uncompressed subtype or the reverse
    // Broiler-Human:        PENDING
    public static readonly Guid MFVideoFormatMjpg = new("47504A4D-0000-0010-8000-00AA00389B71");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=F2951E
    // Broiler-Falsified-If: the value is not the media-type GUID built from D3DFMT_L8 (50, 0x32), so frames of another subtype are read as 1 byte per pixel
    // Broiler-Human:        PENDING
    public static readonly Guid MFVideoFormatL8 = new("00000032-0000-0010-8000-00AA00389B71");

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=0BEB7E
    // Broiler-Falsified-If: the value differs from C60AC5FE-252A-478F-A0EF-BC8FA5F7CAD3 in mfidl.h, so MFEnumDeviceSources and MFCreateDeviceSource receive no source-type filter and do not select video capture devices
    // Broiler-Human:        PENDING
    public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE = new("C60AC5FE-252A-478F-A0EF-BC8FA5F7CAD3");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=F8C1D8
    // Broiler-Falsified-If: the value differs from 8AC3587A-4AE7-42D8-99E0-0A6013EEF90F in mfidl.h, so the source-type filter selects audio capture devices or none instead of video capture devices
    // Broiler-Human:        PENDING
    public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUID = new("8AC3587A-4AE7-42D8-99E0-0A6013EEF90F");
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=2EFB1C
    // Broiler-Falsified-If: the value differs from 60D0E559-52F8-4FA2-BBCE-ACDB34A8EC01 in mfidl.h, so GetAllocatedString returns another attribute's string as the camera's display name or none at all
    // Broiler-Human:        PENDING
    public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_FRIENDLY_NAME = new("60D0E559-52F8-4FA2-BBCE-ACDB34A8EC01");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=D2B752
    // Broiler-Falsified-If: the value differs from 58F0AAD8-22BF-4F8A-BB3D-D2C4978C6E2F in mfidl.h, so the symbolic link read from an enumerated device or passed to MFCreateDeviceSource does not identify the camera the caller selected
    // Broiler-Human:        PENDING
    public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_SYMBOLIC_LINK = new("58F0AAD8-22BF-4F8A-BB3D-D2C4978C6E2F");
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=F471DD
    // Broiler-Falsified-If: the value differs from 44D1A9BC-2999-4238-AE43-0730CEB2AB1B in mfidl.h, so a camera meant to be opened for shared access through the frame server is opened exclusively
    // Broiler-Human:        PENDING
    public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_FRAMESERVER_SHARE_MODE = new("44D1A9BC-2999-4238-AE43-0730CEB2AB1B");

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=BEC5C8
    // Broiler-Falsified-If: the value differs from 48EBA18E-F8C9-4687-BF11-0A74C9F96A8F in mfapi.h, so a media type's major type is read from another attribute and non-video types pass as video
    // Broiler-Human:        PENDING
    public static readonly Guid MF_MT_MAJOR_TYPE = new("48EBA18E-F8C9-4687-BF11-0A74C9F96A8F");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=3EFFFC
    // Broiler-Falsified-If: the value differs from F7E34C9A-42E8-4714-B74B-CB29D72C35E5 in mfapi.h, so the pixel format of negotiated frames is read from another attribute and frame bytes are laid out by the wrong format
    // Broiler-Human:        PENDING
    public static readonly Guid MF_MT_SUBTYPE = new("F7E34C9A-42E8-4714-B74B-CB29D72C35E5");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=48EB75
    // Broiler-Falsified-If: the value differs from 1652C33D-D6B2-4012-B834-72030849A37D in mfapi.h, so width and height are unpacked from another UINT64 attribute and plane sizes disagree with the locked buffer length
    // Broiler-Human:        PENDING
    public static readonly Guid MF_MT_FRAME_SIZE = new("1652C33D-D6B2-4012-B834-72030849A37D");
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=7B01F0
    // Broiler-Falsified-If: the value differs from C459A2E8-3D2C-4E44-B132-FEE5156C7BB0 in mfapi.h, so the reported frame-rate numerator and denominator come from another attribute
    // Broiler-Human:        PENDING
    public static readonly Guid MF_MT_FRAME_RATE = new("C459A2E8-3D2C-4E44-B132-FEE5156C7BB0");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=1D27BE
    // Broiler-Falsified-If: the value differs from 644B4E48-1E02-4516-B0EB-C01CA9D49AC6 in mfapi.h, so the row pitch, including the negative pitch of a bottom-up RGB frame, is read from another attribute
    // Broiler-Human:        PENDING
    public static readonly Guid MF_MT_DEFAULT_STRIDE = new("644B4E48-1E02-4516-B0EB-C01CA9D49AC6");
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=1B6B07
    // Broiler-Falsified-If: the value differs from 0F81DA2C-B537-4672-A8B2-A681B17307A3 in mfreadwrite.h, so the source reader inserts no video processor and refuses an output subtype the camera does not produce natively
    // Broiler-Human:        PENDING
    public static readonly Guid MF_SOURCE_READER_ENABLE_ADVANCED_VIDEO_PROCESSING = new("0F81DA2C-B537-4672-A8B2-A681B17307A3");
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=29ABF8
    // Broiler-Falsified-If: the value differs from 56B67165-219E-456D-A22E-2D3004C7FE56 in mfreadwrite.h, so releasing the source reader also shuts down the media source the caller still owns
    // Broiler-Human:        PENDING
    public static readonly Guid MF_SOURCE_READER_DISCONNECT_MEDIASOURCE_ON_SHUTDOWN = new("56B67165-219E-456D-A22E-2D3004C7FE56");

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=8E6AB1
    // Broiler-Falsified-If: an out parameter differs in width from the IMFActivate*** and UINT32* of the mfidl.h prototype, so the CoTaskMem array pointer or the device count lands in a slot of the wrong size
    // Broiler-Human:        PENDING
    [LibraryImport("mf.dll")]
    public static partial int MFEnumDeviceSources(IMFAttributes attributes, out IntPtr devices, out uint count);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=8FEFF4
    // Broiler-Falsified-If: the IMFMediaSource reference written to ppSource is not owned by the returned wrapper, so releasing the wrapper leaves the camera device source alive
    // Broiler-Human:        PENDING
    [LibraryImport("mf.dll")]
    public static partial int MFCreateDeviceSource(IMFAttributes attributes, out IMFMediaSource mediaSource);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=1B4E53
    // Broiler-Falsified-If: a null attributes argument does not reach native code as a null IMFAttributes*, so the optional pAttributes of mfreadwrite.h receives an invalid interface pointer
    // Broiler-Human:        PENDING
    [LibraryImport("mfreadwrite.dll")]
    public static partial int MFCreateSourceReaderFromMediaSource(IMFMediaSource mediaSource, IMFAttributes? attributes,
        out IMFSourceReader sourceReader);

}

// Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=5FD83E
// Broiler-Falsified-If: a member differs from its MF_SOURCE_READERF value in mfreadwrite.h (Error 0x1, EndOfStream 0x2, StreamTick 0x100), so a reader error or end of stream returned by ReadSample is handled as an ordinary frame
// Broiler-Human:        PENDING
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
// Broiler-Falsified-If: the interface does not derive from an IMFAttributes declaration of exactly 30 methods, so ActivateObject is not dispatched through vtable slot 33 and calls another native method with mismatched arguments
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("7FEE9E9A-4A89-47A6-899C-B6A53A70FB67")]
public partial interface IMFActivate : IMFAttributes
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=9210BC
    // Broiler-Falsified-If: ActivateObject is not vtable slot 33, directly after the 30 IMFAttributes methods, so the call reaches CopyAllItems and native code calls through the IID pointer as an IMFAttributes object
    // Broiler-Human:        PENDING
    [PreserveSig]
    int ActivateObject(ref Guid interfaceId, out IntPtr activatedObject);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B2D4A2
    // Broiler-Falsified-If: ShutdownObject is not dispatched through the slot after ActivateObject in mfobjects.h, so a shutdown request runs another method and the device stays open
    // Broiler-Human:        PENDING
    [PreserveSig]
    int ShutdownObject();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=3D143C
    // Broiler-Falsified-If: DetachObject is not dispatched through the slot after ShutdownObject in mfobjects.h, so a detach request runs another method with mismatched arguments
    // Broiler-Human:        PENDING
    [PreserveSig]
    int DetachObject();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=0E895F
// Broiler-Falsified-If: a member is out of mfidl.h order (the four IMFMediaEventGenerator methods, then GetCharacteristics through Shutdown), so Start or QueueEvent reaches a method that reads its PROPVARIANT pointer as another argument
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("279A808D-AEC7-40C8-9C6B-A6B492C78A66")]
public partial interface IMFMediaSource
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=0E5E8D
    // Broiler-Falsified-If: GetEvent is not vtable slot 3, the first IMFMediaEventGenerator method after IUnknown, so an event request reaches BeginGetEvent and the flags are taken as a callback pointer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetEvent(int flags, out IntPtr mediaEvent);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=A2701C
    // Broiler-Falsified-If: BeginGetEvent is not vtable slot 4, directly after GetEvent, so the callback and state reach GetEvent and an event pointer is written through the callback value as an address
    // Broiler-Human:        PENDING
    [PreserveSig]
    int BeginGetEvent(IntPtr callback, IntPtr state);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=F27CE9
    // Broiler-Falsified-If: result and the mediaEvent out reach IMFMediaEventGenerator::EndGetEvent(IMFAsyncResult*, IMFMediaEvent**) in swapped positions, so the event pointer is written over the async result object
    // Broiler-Human:        PENDING
    [PreserveSig]
    int EndGetEvent(IntPtr result, out IntPtr mediaEvent);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=0CB8DF
    // Broiler-Falsified-If: QueueEvent is not vtable slot 6, after EndGetEvent, so the event type, GUID, status and PROPVARIANT pointer reach EndGetEvent or GetCharacteristics and native code writes through the event type as an address
    // Broiler-Human:        PENDING
    [PreserveSig]
    int QueueEvent(int mediaEventType, ref Guid extendedType, int status, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=233D25
    // Broiler-Falsified-If: GetCharacteristics is not dispatched through slot 7, the first after the four IMFMediaEventGenerator methods in mfidl.h, so the characteristics DWORD is written by a different method
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCharacteristics(out int characteristics);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=DFC700
    // Broiler-Falsified-If: CreatePresentationDescriptor is not vtable slot 8, after GetCharacteristics, so the call reaches Start and native code reads the out slot as a presentation descriptor
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CreatePresentationDescriptor(out IntPtr presentationDescriptor);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=007B5F
    // Broiler-Falsified-If: presentationDescriptor, timeFormat and startPosition reach IMFMediaSource::Start in another order, so the source reads the PROPVARIANT start position through the time-format GUID's address
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Start(IntPtr presentationDescriptor, ref Guid timeFormat, IntPtr startPosition);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=458393
    // Broiler-Falsified-If: Stop is not dispatched through the slot after Start in mfidl.h, so a stop request runs Pause or Shutdown instead
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Stop();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=3DEE33
    // Broiler-Falsified-If: Pause is not dispatched through the slot after Stop in mfidl.h, so a pause request runs Shutdown and the camera cannot be restarted
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Pause();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B383A8
    // Broiler-Falsified-If: Shutdown is not the last IMFMediaSource slot in mfidl.h, so releasing a camera calls another method and leaves the device open
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Shutdown();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=0511AF
// Broiler-Falsified-If: the interface does not derive from an IMFAttributes declaration of exactly 30 methods, so GetMajorType and the other media-type members are dispatched through the wrong vtable slots
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("44AE0FA8-EA31-4109-8D2E-4CAE4997C555")]
public partial interface IMFMediaType : IMFAttributes
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A1D09D
    // Broiler-Falsified-If: GetMajorType is not dispatched through slot 33, the first after the 30 IMFAttributes methods, so the GUID written to majorType comes from a different method
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetMajorType(out Guid majorType);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=8C2475
    // Broiler-Falsified-If: compressed is marshalled as a 1-byte bool instead of a 4-byte BOOL, so native code writes past the managed local
    // Broiler-Human:        PENDING
    [PreserveSig]
    int IsCompressedFormat([MarshalAs(UnmanagedType.Bool)] out bool compressed);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=01BD88
    // Broiler-Falsified-If: mediaType and the flags out reach IMFMediaType::IsEqual(IMFMediaType*, DWORD*) in swapped positions, so the match flags are written into the other media type object
    // Broiler-Human:        PENDING
    [PreserveSig]
    int IsEqual(IMFMediaType mediaType, out int flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=C437BF
    // Broiler-Falsified-If: GetRepresentation is not vtable slot 36, after IsEqual, so a representation request reaches FreeRepresentation and native code frees the caller's out slot as a representation block
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetRepresentation(Guid representation, out IntPtr representationData);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=E8E537
    // Broiler-Falsified-If: FreeRepresentation is not vtable slot 37, directly after GetRepresentation, so a free request reaches GetRepresentation and a new block is written through the pointer meant to be freed
    // Broiler-Human:        PENDING
    [PreserveSig]
    int FreeRepresentation(Guid representation, IntPtr representationData);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=0EC939
// Broiler-Falsified-If: a member is out of mfreadwrite.h order (GetStreamSelection at slot 3 through GetPresentationAttribute at 12), so a PROPVARIANT, media-type or sample pointer is read or written by a method that takes another argument list
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("70AE66F2-C809-4E4F-8915-BDCB406B7993")]
public partial interface IMFSourceReader
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=ACDBE9
    // Broiler-Falsified-If: selected is marshalled as a 1-byte bool instead of a 4-byte BOOL, so native code writes 3 bytes past the managed local
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetStreamSelection(int streamIndex, [MarshalAs(UnmanagedType.Bool)] out bool selected);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=37F403
    // Broiler-Falsified-If: selected is passed as a 1-byte bool instead of a 4-byte BOOL, so native code reads undefined upper bytes and a deselect can leave the stream enabled
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetStreamSelection(int streamIndex, [MarshalAs(UnmanagedType.Bool)] bool selected);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=191BB5
    // Broiler-Falsified-If: GetNativeMediaType is not vtable slot 5, after SetStreamSelection, so the stream and type indexes reach GetCurrentMediaType and the type index is dereferenced as the out pointer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetNativeMediaType(int streamIndex, int mediaTypeIndex, out IMFMediaType mediaType);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=CAC63C
    // Broiler-Falsified-If: GetCurrentMediaType is not vtable slot 6, directly after GetNativeMediaType, so the out pointer is read as a media-type index and the type is written through an unset argument
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCurrentMediaType(int streamIndex, out IMFMediaType mediaType);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=57AE9A
    // Broiler-Falsified-If: reserved and mediaType reach IMFSourceReader::SetCurrentMediaType(DWORD, DWORD*, IMFMediaType*) in swapped positions, so the reader dereferences null as the media type
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetCurrentMediaType(int streamIndex, IntPtr reserved, IMFMediaType mediaType);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=CF62FB
    // Broiler-Falsified-If: timeFormat and position reach IMFSourceReader::SetCurrentPosition(REFGUID, REFPROPVARIANT) in swapped positions, so the reader reads the PROPVARIANT seek position through the GUID's address
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetCurrentPosition(ref Guid timeFormat, IntPtr position);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=7; Fingerprint=2D7F72
    // Broiler-Falsified-If: ReadSample is not vtable slot 9, after SetCurrentPosition, so a read reaches Flush or SetCurrentPosition and the five out arguments are never written
    // Broiler-Human:        PENDING
    [PreserveSig]
    int ReadSample(int streamIndex, int controlFlags, out int actualStreamIndex, out SourceReaderFlags streamFlags,
        out long timestamp, out IMFSample? sample);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=7D05AD
    // Broiler-Falsified-If: Flush is not dispatched through the slot after ReadSample in mfreadwrite.h, so a flush request runs GetServiceForStream and native code writes through garbage pointer arguments
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Flush(int streamIndex);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=26A506
    // Broiler-Falsified-If: service and interfaceId reach GetServiceForStream(DWORD, REFGUID, REFIID, LPVOID*) in swapped positions, so the reader returns the service named by the IID and the caller calls it as another interface
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetServiceForStream(int streamIndex, ref Guid service, ref Guid interfaceId, out IntPtr serviceObject);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=05DCB9
    // Broiler-Falsified-If: GetPresentationAttribute is not vtable slot 12, the last IMFSourceReader method, so the query reaches GetServiceForStream and native code writes a service pointer through the PROPVARIANT argument
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetPresentationAttribute(int streamIndex, ref Guid attribute, IntPtr value);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=AA199C
// Broiler-Falsified-If: a member is out of mfobjects.h order (the 30 IMFAttributes slots, then GetSampleFlags at 33 through CopyToBuffer at 46), so a PROPVARIANT, string, blob or buffer pointer reaches a method that writes it with another size
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("C40A00F2-B93A-4D80-AE8C-5A1C634F58E4")]
public partial interface IMFSample
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=CE6DAE
    // Broiler-Falsified-If: GetItem is not vtable slot 3, directly after IUnknown, so a lookup reaches GetItemType and the PROPVARIANT the caller then reads holds only a 4-byte type code
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetItem(ref Guid key, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=14817B
    // Broiler-Falsified-If: GetItemType is not the slot after GetItem in the IMFAttributes order of mfobjects.h, so the attribute type is written by a different method
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetItemType(ref Guid key, out int type);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=E2FA0C
    // Broiler-Falsified-If: CompareItem is not vtable slot 5, after GetItemType, so a comparison reaches Compare and native code calls through the PROPVARIANT pointer as an IMFAttributes object
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CompareItem(ref Guid key, IntPtr value, [MarshalAs(UnmanagedType.Bool)] out bool result);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=FC95C3
    // Broiler-Falsified-If: result is marshalled as a 1-byte bool instead of a 4-byte BOOL, so native code writes past the managed local and a mismatch can read as a match
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Compare(IMFAttributes attributes, int matchType, [MarshalAs(UnmanagedType.Bool)] out bool result);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=22EFE5
    // Broiler-Falsified-If: value is declared wider than the UINT32* of mfobjects.h, so native code fills only the low half and the caller reads stale upper bits
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetUINT32(ref Guid key, out int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B0164D
    // Broiler-Falsified-If: value is declared narrower than the UINT64* of mfobjects.h, so native code writes 8 bytes into a 4-byte slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetUINT64(ref Guid key, out long value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E83B03
    // Broiler-Falsified-If: value is not an 8-byte double, so native code writes past the managed local
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetDouble(ref Guid key, out double value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=04EAF7
    // Broiler-Falsified-If: value is not a 16-byte Guid passed by pointer, so native code writes the GUID past the managed local
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetGUID(ref Guid key, out Guid value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=CC6026
    // Broiler-Falsified-If: GetStringLength is not vtable slot 11, so a call reaches GetGUID and native code writes 16 bytes through the 4-byte length out
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetStringLength(ref Guid key, out int length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=77BE94
    // Broiler-Falsified-If: value and size reach IMFAttributes::GetString(REFGUID, LPWSTR, UINT32, UINT32*) in swapped positions, so the string is written to the address given by the capacity
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetString(ref Guid key, IntPtr value, int size, out int length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=028D50
    // Broiler-Falsified-If: value and length reach GetAllocatedString(REFGUID, LPWSTR*, UINT32*) in swapped positions, so the string pointer is written into the 4-byte length and the caller frees a truncated address
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetAllocatedString(ref Guid key, out IntPtr value, out int length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=689F15
    // Broiler-Falsified-If: GetBlobSize is not the slot after GetAllocatedString in mfobjects.h, so the blob size is written by a different method
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBlobSize(ref Guid key, out int size);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=DF996E
    // Broiler-Falsified-If: buffer and bufferSize reach IMFAttributes::GetBlob(REFGUID, UINT8*, UINT32, UINT32*) in swapped positions, so the blob is copied to the address given by the size
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBlob(ref Guid key, IntPtr buffer, int bufferSize, out int blobSize);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=D95683
    // Broiler-Falsified-If: buffer and size reach GetAllocatedBlob(REFGUID, UINT8**, UINT32*) in swapped positions, so the blob pointer is written into the 4-byte size and the caller reads through a truncated address
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetAllocatedBlob(ref Guid key, out IntPtr buffer, out int size);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D93F2C
    // Broiler-Falsified-If: key and interfaceId reach GetUnknown(REFGUID, REFIID, LPVOID*) in swapped positions, so the store looks the IID up as the key and returns an object queried for the key GUID
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetUnknown(ref Guid key, ref Guid interfaceId, out IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=8A63F9
    // Broiler-Falsified-If: SetItem is not vtable slot 18, after GetUnknown, so a store request reaches GetUnknown and native code writes an interface pointer through the PROPVARIANT argument
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetItem(ref Guid key, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=74315D
    // Broiler-Falsified-If: DeleteItem is not the slot after SetItem in mfobjects.h, so a delete runs DeleteAllItems or SetUINT32 with mismatched arguments
    // Broiler-Human:        PENDING
    [PreserveSig]
    int DeleteItem(ref Guid key);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=B3EEDA
    // Broiler-Falsified-If: DeleteAllItems is not dispatched through the slot after DeleteItem in mfobjects.h, so clearing the attributes runs another method
    // Broiler-Human:        PENDING
    [PreserveSig]
    int DeleteAllItems();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACC7DC
    // Broiler-Falsified-If: value is declared wider than the UINT32 of mfobjects.h, so on x86 the caller pushes 8 bytes where native code pops 4 and the stack is unbalanced on return
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetUINT32(ref Guid key, int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=D8F6A0
    // Broiler-Falsified-If: value is declared narrower than the UINT64 of mfobjects.h, so on x86 the upper half is read from the next stack slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetUINT64(ref Guid key, long value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=0AB870
    // Broiler-Falsified-If: value is not passed as an 8-byte double, so native code stores a reinterpretation of another register or stack slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetDouble(ref Guid key, double value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4C3268
    // Broiler-Falsified-If: value is passed by value instead of as a REFGUID pointer, so native code reads the GUID from the bits of a pointer-sized argument
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetGUID(ref Guid key, ref Guid value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=C88CB0
    // Broiler-Falsified-If: value is marshalled as an ANSI string instead of LPWSTR, so non-ASCII characters are lost and native code reads a narrow buffer as UTF-16 past its terminator
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetString(ref Guid key, [MarshalAs(UnmanagedType.LPWStr)] string value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=643E87
    // Broiler-Falsified-If: buffer and size reach IMFAttributes::SetBlob(REFGUID, const UINT8*, UINT32) in swapped positions, so the store copies the blob from the address given by the size
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetBlob(ref Guid key, IntPtr buffer, int size);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=EB4C73
    // Broiler-Falsified-If: SetUnknown is not vtable slot 27, after SetBlob, so a store request reaches SetBlob and native code copies from the IUnknown pointer with an unset size
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetUnknown(ref Guid key, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=52D8D9
    // Broiler-Falsified-If: LockStore is not vtable slot 28, directly after SetUnknown, so a lock request reaches SetUnknown or UnlockStore and the attribute store is never locked
    // Broiler-Human:        PENDING
    [PreserveSig]
    int LockStore();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B80F37
    // Broiler-Falsified-If: UnlockStore is not vtable slot 29, directly after LockStore, so an unlock reaches GetCount, which writes through an unset argument and leaves the store locked
    // Broiler-Human:        PENDING
    [PreserveSig]
    int UnlockStore();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C12DCA
    // Broiler-Falsified-If: GetCount is not the slot after UnlockStore in mfobjects.h, so the item count is written by a different method
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCount(out int count);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=57C3C3
    // Broiler-Falsified-If: GetItemByIndex is not vtable slot 31, after GetCount, so an indexed read reaches CopyAllItems and native code calls through the GUID out pointer as an IMFAttributes object
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetItemByIndex(int index, out Guid key, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=F083D6
    // Broiler-Falsified-If: CopyAllItems is not the last of the 30 IMFAttributes slots in mfobjects.h, so GetSampleFlags and every sample member after it are dispatched one slot off
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CopyAllItems(IMFAttributes destination);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=28DCB0
    // Broiler-Falsified-If: GetSampleFlags is not dispatched through slot 33, the first after the 30 IMFAttributes methods, so the flags DWORD is written by a different method
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetSampleFlags(out int flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=119402
    // Broiler-Falsified-If: SetSampleFlags is not dispatched through the slot after GetSampleFlags in mfobjects.h, so the flags value reaches a getter as a pointer argument
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetSampleFlags(int flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=36A75E
    // Broiler-Falsified-If: sampleTime is narrower than the LONGLONG* of mfobjects.h, so native code writes 8 bytes into a 4-byte slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetSampleTime(out long sampleTime);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=58104B
    // Broiler-Falsified-If: sampleTime is narrower than the LONGLONG of mfobjects.h, so on x86 the upper half of the time is read from the next stack slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetSampleTime(long sampleTime);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=895682
    // Broiler-Falsified-If: sampleDuration is narrower than the LONGLONG* of mfobjects.h, so native code writes 8 bytes into a 4-byte slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetSampleDuration(out long sampleDuration);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=3D6461
    // Broiler-Falsified-If: sampleDuration is narrower than the LONGLONG of mfobjects.h, so on x86 the upper half of the duration is read from the next stack slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetSampleDuration(long sampleDuration);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B473B3
    // Broiler-Falsified-If: GetBufferCount is not dispatched through the slot after SetSampleDuration in mfobjects.h, so the buffer count is written by a different method
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBufferCount(out int bufferCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=2959BC
    // Broiler-Falsified-If: GetBufferByIndex is not vtable slot 40, after GetBufferCount, so the call reaches ConvertToContiguousBuffer and a buffer pointer is written through the index value as an address
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBufferByIndex(int index, out IMFMediaBuffer buffer);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=799F86
    // Broiler-Falsified-If: ConvertToContiguousBuffer is not vtable slot 41, after GetBufferByIndex, so the call reaches AddBuffer and the caller's out slot is read as a buffer to append
    // Broiler-Human:        PENDING
    [PreserveSig]
    int ConvertToContiguousBuffer(out IMFMediaBuffer buffer);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=35F355
    // Broiler-Falsified-If: AddBuffer is not dispatched through the slot after ConvertToContiguousBuffer in mfobjects.h, so adding a buffer runs RemoveBufferByIndex with the interface pointer as an index
    // Broiler-Human:        PENDING
    [PreserveSig]
    int AddBuffer(IMFMediaBuffer buffer);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=AB56F6
    // Broiler-Falsified-If: RemoveBufferByIndex is not dispatched through the slot after AddBuffer in mfobjects.h, so removing a buffer runs another method with mismatched arguments
    // Broiler-Human:        PENDING
    [PreserveSig]
    int RemoveBufferByIndex(int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=2BC579
    // Broiler-Falsified-If: RemoveAllBuffers is not dispatched through the slot after RemoveBufferByIndex in mfobjects.h, so clearing the buffers runs GetTotalLength or another method
    // Broiler-Human:        PENDING
    [PreserveSig]
    int RemoveAllBuffers();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B86A11
    // Broiler-Falsified-If: totalLength is not declared as an out 4-byte DWORD, so GetTotalLength writes the byte count into a slot of another width and the length read back carries stale bits
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetTotalLength(out int totalLength);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=5C8BE2
    // Broiler-Falsified-If: CopyToBuffer is not vtable slot 46, the last IMFSample method, so a copy request reaches GetTotalLength and native code writes a byte count over the destination buffer object
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CopyToBuffer(IMFMediaBuffer buffer);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=59E929
// Broiler-Falsified-If: a member is out of mfobjects.h order (Lock, Unlock, GetCurrentLength, SetCurrentLength, GetMaxLength after IUnknown), so the length that bounds reads through the Lock pointer comes from another method
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("045FA593-8799-42B8-BC8D-8968C6453507")]
public partial interface IMFMediaBuffer
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=B58521
    // Broiler-Falsified-If: buffer, maxLength and currentLength reach IMFMediaBuffer::Lock(BYTE**, DWORD*, DWORD*) in another order, so the data pointer is written into a 4-byte length and the caller reads frames through a truncated address
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Lock(out IntPtr buffer, out int maxLength, out int currentLength);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=82E696
    // Broiler-Falsified-If: Unlock is not vtable slot 4, directly after Lock, so an unlock reaches GetCurrentLength with no out argument and native code writes the length through an unset pointer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Unlock();

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=BA0C7A
    // Broiler-Falsified-If: currentLength is declared other than a 4-byte DWORD, so the byte count a caller reads through the Lock pointer carries stale bits and overruns the buffer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCurrentLength(out int currentLength);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=6EBEA5
    // Broiler-Falsified-If: currentLength is not passed as a 4-byte DWORD, so SetCurrentLength stores a length taken from stray bits and GetCurrentLength then reports more valid bytes than were written
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetCurrentLength(int currentLength);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=5A8655
    // Broiler-Falsified-If: maxLength is declared other than a 4-byte DWORD, so a capacity with stale upper bits sizes a write through the Lock pointer past the buffer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetMaxLength(out int maxLength);
}
