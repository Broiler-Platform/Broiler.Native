// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   50
// Annotated:        50/50
// Exempt:           9
// Human-reviewed:   0/50
// IP risk:          Low
// Security risk:    Critical
// Criteria:         49/49
// Resource impact:  8/10 max
// Unverified:       50
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.ComponentModel;

namespace Broiler.Native.Windows.MediaFoundation.MediaEngine;

// Broiler-AI:           Origin=AI; IP=Low; Security=None; Resources=0; Fingerprint=31739E
// Broiler-Human:        PENDING
public static partial class MediaFoundationNative
{

    public const uint MF_MEDIA_ENGINE_FORCEMUTE = 0x4;
    public const uint MF_MEDIA_ENGINE_DISABLE_LOCAL_PLUGINS = 0x10;

    public static readonly Guid CLSID_MFMediaEngineClassFactory = new("B44392DA-499B-446B-A4CB-005FEAD0E6D5");
    public static readonly Guid IID_IMFMediaEngineClassFactory = new("4D645ACE-26AA-4688-9BE1-DF3516990B93");

    public static readonly Guid MF_MEDIA_ENGINE_CALLBACK = new("C60381B8-83A4-41F8-A3D0-DE05076849A9");
    public static readonly Guid MF_MEDIA_ENGINE_PLAYBACK_HWND = new("D988879B-67C9-4D92-BAA7-6EADD446039D");
    public static readonly Guid MF_MEDIA_ENGINE_SYNCHRONOUS_CLOSE = new("C3C2E12F-7E0E-4E43-B91C-DC992CCDFA5E");
    public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE = new("4E0212E2-E18F-41E1-95E5-C0E7E9235BC3");
    public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE_EDGE = new("A6F3E465-3ACA-442C-A3F0-AD6DDAD839AE");

}

/// <summary>Native Media Engine callback contract. Public visibility is required for COM QueryInterface.</summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4624E7
// Broiler-Falsified-If: the [Guid] differs from IID_IMFMediaEngineNotify (FEE7C112-E776-42B5-9BBF-0048524E2BD5), so the engine's QueryInterface on the callback fails and CreateInstance has no notify sink
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("FEE7C112-E776-42B5-9BBF-0048524E2BD5")]
[EditorBrowsable(EditorBrowsableState.Never)]
public partial interface IMFMediaEngineNotify
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=FD7E19
    // Broiler-Falsified-If: param1 is declared narrower than the pointer-sized DWORD_PTR, so on x64 the high half of an event's param1, such as the NOTIFYSTABLESTATE event handle, is lost
    // Broiler-Human:        PENDING
    [PreserveSig]
    int EventNotify(uint @event, UIntPtr param1, uint param2);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=85C98C
// Broiler-Falsified-If: a member is declared out of mfmediaengine.h order, so CreateInstance runs CreateTimeRange's slot and the engine out pointer receives an IMFMediaTimeRange
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("4D645ACE-26AA-4688-9BE1-DF3516990B93")]
public partial interface IMFMediaEngineClassFactory
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=9BBC9A
    // Broiler-Falsified-If: the marshaller wraps the IMFMediaEngine written to mediaEngine without releasing the reference the factory returned, so each engine keeps one native reference after Shutdown and the last managed release
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CreateInstance(uint createFlags, IMFAttributes attributes, out IMFMediaEngine mediaEngine);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=37E2E9
    // Broiler-Falsified-If: CreateTimeRange is not vtable slot 4, directly after CreateInstance, so the call reaches CreateError and an IMFMediaError is returned where a time range is expected
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CreateTimeRange(out IntPtr timeRange);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=DF2494
    // Broiler-Falsified-If: CreateError is not vtable slot 5, the last IMFMediaEngineClassFactory method, so the call reaches CreateTimeRange and a time range is returned where an error object is expected
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CreateError(out IntPtr error);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=B197E9
// Broiler-Falsified-If: a member is missing or out of mfmediaengine.h order, so later slots shift and a call such as Shutdown() runs TransferVideoFrame, which dereferences unset surface and RECT pointer arguments
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("98A1B0BB-03EB-4935-AE7C-93C1FA0E1C93")]
public partial interface IMFMediaEngine
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=E58FDF
    // Broiler-Falsified-If: GetError is not vtable slot 3, the first IMFMediaEngine method, so an error query reaches SetErrorCode and the out pointer is taken as an error code
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetError(out IntPtr error);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=ABCE54
    // Broiler-Falsified-If: SetErrorCode does not sit in the slot after GetError, so the MF_MEDIA_ENGINE_ERR code reaches SetSourceElements and is dereferenced as an interface pointer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetErrorCode(int error);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=8; Fingerprint=625F7D
    // Broiler-Falsified-If: SetSourceElements does not sit in the slot after SetErrorCode, so the source-elements pointer reaches SetSource and the engine reads it as a BSTR URL
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetSourceElements(IntPtr sourceElements);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=8; Fingerprint=670DA0
    // Broiler-Falsified-If: url is marshalled without the BStr attribute, so the engine reads the length from the four bytes before an LPWSTR and copies past the end of the page-supplied URL
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetSource([MarshalAs(UnmanagedType.BStr)] string url);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=CA939B
    // Broiler-Falsified-If: the BSTR written to url is not freed with SysFreeString after conversion, so each call leaks a copy of the page-supplied source URL
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCurrentSource([MarshalAs(UnmanagedType.BStr)] out string? url);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=6A0B51
    // Broiler-Falsified-If: the return is declared wider than the native USHORT, so stale upper bits of the return register yield a network state outside NETWORK_EMPTY to NETWORK_NO_SOURCE (0 to 3)
    // Broiler-Human:        PENDING
    [PreserveSig]
    ushort GetNetworkState();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=55635A
    // Broiler-Falsified-If: PreserveSig is dropped, so the stub treats the MF_MEDIA_ENGINE_PRELOAD return as an HRESULT and reads the value through a retval pointer the native method never writes
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetPreload();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B5134F
    // Broiler-Falsified-If: SetPreload does not sit in the slot after GetPreload, so the preload value reaches GetBuffered as its out pointer and the engine writes an interface pointer to that address
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetPreload(int preload);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=80B762
    // Broiler-Falsified-If: GetBuffered does not sit in the slot after SetPreload, so the call reaches SetPreload or Load and the caller reads an unset time-range pointer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBuffered(out IntPtr buffered);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=8; Fingerprint=4179CD
    // Broiler-Falsified-If: Load is shifted onto a neighbouring slot, so a call meant to start loading page media runs GetBuffered or CanPlayType with unset pointer arguments
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Load();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=310347
    // Broiler-Falsified-If: type is marshalled without the BStr attribute, so the engine reads the MIME type's length from the four bytes before an LPWSTR and parses past the end of the page-supplied string
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CanPlayType([MarshalAs(UnmanagedType.BStr)] string type, out int answer);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=731F28
    // Broiler-Falsified-If: the return is declared wider than the native USHORT, so stale upper bits of the return register yield a ready state outside HAVE_NOTHING to HAVE_ENOUGH_DATA (0 to 4)
    // Broiler-Human:        PENDING
    [PreserveSig]
    ushort GetReadyState();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=40C53E
    // Broiler-Falsified-If: IsSeeking is shifted onto GetCurrentTime's slot, so the BOOL is read from EAX while the engine returns a double in XMM0
    // Broiler-Human:        PENDING
    [PreserveSig]
    int IsSeeking();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D30507
    // Broiler-Falsified-If: the return is declared as an integer type, so the position is read from EAX while the engine returns it as a double in XMM0
    // Broiler-Human:        PENDING
    [PreserveSig]
    double GetCurrentTime();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=7; Fingerprint=A4CA2E
    // Broiler-Falsified-If: seekTime is declared as float, so the engine reads a double from a register holding a single-precision value and seeks page media to an unrelated position
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetCurrentTime(double seekTime);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B36727
    // Broiler-Falsified-If: the return is declared as an integer type, so the start time is read from EAX while the engine returns it as a double in XMM0
    // Broiler-Human:        PENDING
    [PreserveSig]
    double GetStartTime();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=AED091
    // Broiler-Falsified-If: the return is declared as an integer type, so a NaN or infinite duration for unknown or live media is read from EAX instead of XMM0 and looks finite
    // Broiler-Human:        PENDING
    [PreserveSig]
    double GetDuration();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2CE76C
    // Broiler-Falsified-If: IsPaused is shifted onto GetDuration's or GetDefaultPlaybackRate's slot, so the BOOL is read from EAX while the engine returns a double in XMM0
    // Broiler-Human:        PENDING
    [PreserveSig]
    int IsPaused();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=245D28
    // Broiler-Falsified-If: the return is declared as an integer type, so the default rate is read from EAX while the engine returns it as a double in XMM0
    // Broiler-Human:        PENDING
    [PreserveSig]
    double GetDefaultPlaybackRate();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=1D2A07
    // Broiler-Falsified-If: Rate is declared as float, so the engine reads a double from a register holding a single-precision value and sets an unrelated default rate
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetDefaultPlaybackRate(double rate);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=63C2D3
    // Broiler-Falsified-If: the return is declared as an integer type, so the playback rate is read from EAX while the engine returns it as a double in XMM0
    // Broiler-Human:        PENDING
    [PreserveSig]
    double GetPlaybackRate();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=478425
    // Broiler-Falsified-If: Rate is declared as float, so the engine reads a double from a register holding a single-precision value and plays page media at an unrelated rate
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetPlaybackRate(double rate);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=C0F99A
    // Broiler-Falsified-If: GetPlayed does not sit in the slot after SetPlaybackRate, so the call reaches SetPlaybackRate and the caller reads an unset time-range pointer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetPlayed(out IntPtr played);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=B6B68E
    // Broiler-Falsified-If: GetSeekable does not sit in the slot after GetPlayed, so the call reaches IsEnded and the caller reads an unset time-range pointer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetSeekable(out IntPtr seekable);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=4FE527
    // Broiler-Falsified-If: IsEnded is shifted onto GetSeekable's slot, so the engine writes an IMFMediaTimeRange pointer through an unset out-pointer argument
    // Broiler-Human:        PENDING
    [PreserveSig]
    int IsEnded();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=57EAA0
    // Broiler-Falsified-If: GetAutoPlay is shifted onto SetAutoPlay's slot, so the engine reads its BOOL argument from an unset register and may switch autoplay on for page media
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetAutoPlay();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=FEDB7F
    // Broiler-Falsified-If: AutoPlay is declared as a one-byte bool, so the upper bytes of the 32-bit BOOL argument are undefined and a false request can enable autoplay
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetAutoPlay(int autoPlay);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=5CDB3E
    // Broiler-Falsified-If: GetLoop is shifted onto SetLoop's slot, so the engine reads its BOOL argument from an unset register and may turn looping on
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetLoop();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=992AFA
    // Broiler-Falsified-If: Loop is declared as a one-byte bool, so the upper bytes of the 32-bit BOOL argument are undefined and a false request can leave page media looping
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetLoop(int loop);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=8; Fingerprint=69F7C6
    // Broiler-Falsified-If: Play does not sit in the slot after SetLoop, so a play request runs SetLoop or Pause instead and no MF_MEDIA_ENGINE_EVENT_PLAY follows
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Play();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=3DEE33
    // Broiler-Falsified-If: Pause is shifted onto Play's slot, so a pause request starts or keeps decoding page media
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Pause();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=5AB855
    // Broiler-Falsified-If: GetMuted is shifted onto SetMuted's slot, so the engine reads its BOOL argument from an unset register and may unmute page audio
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetMuted();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=07AB7B
    // Broiler-Falsified-If: Muted is declared as a one-byte bool, so the upper bytes of the 32-bit BOOL argument are undefined and an unmute request can leave the audio muted
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetMuted(int muted);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=53DD7D
    // Broiler-Falsified-If: the return is declared as an integer type, so the volume is read from EAX while the engine returns it as a double in XMM0
    // Broiler-Human:        PENDING
    [PreserveSig]
    double GetVolume();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A18602
    // Broiler-Falsified-If: Volume is declared as float, so the engine reads a double from a register holding a single-precision value and sets an unrelated volume
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetVolume(double volume);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=313443
    // Broiler-Falsified-If: HasVideo is swapped with HasAudio relative to mfmediaengine.h, so an audio-only resource reports video and a video-only resource reports none
    // Broiler-Human:        PENDING
    [PreserveSig]
    int HasVideo();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=238FA6
    // Broiler-Falsified-If: HasAudio is shifted onto GetNativeVideoSize's slot, so the engine writes two DWORDs through unset out-pointer arguments
    // Broiler-Human:        PENDING
    [PreserveSig]
    int HasAudio();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B5334A
    // Broiler-Falsified-If: cx or cy is declared narrower than the 32-bit DWORD, so the engine writes four bytes into a two-byte slot and overwrites the adjacent local
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetNativeVideoSize(out uint width, out uint height);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C5F727
    // Broiler-Falsified-If: GetVideoAspectRatio is swapped with GetNativeVideoSize in the vtable, so a caller sizing frames receives the pixel aspect ratio, for example 1 by 1, as the video dimensions
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetVideoAspectRatio(out uint width, out uint height);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B383A8
    // Broiler-Falsified-If: Shutdown is shifted onto TransferVideoFrame's slot, so the call passes no arguments and the engine dereferences unset surface and RECT pointers
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Shutdown();

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=037618
    // Broiler-Falsified-If: source, destination and borderColor reach TransferVideoFrame(IUnknown*, const MFVideoNormalizedRect*, const RECT*, const MFARGB*) in another order, so the engine reads the normalized source rectangle through the destination RECT pointer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int TransferVideoFrame(IntPtr destinationSurface, IntPtr source, IntPtr destination, IntPtr borderColor);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B3A83D
    // Broiler-Falsified-If: presentationTime is declared narrower than the 64-bit LONGLONG, so the engine writes eight bytes into a four-byte slot and overwrites the adjacent local
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OnVideoStreamTick(out long presentationTime);
}
