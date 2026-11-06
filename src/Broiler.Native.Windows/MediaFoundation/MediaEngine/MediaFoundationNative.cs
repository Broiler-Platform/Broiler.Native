// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// HAIRS Code Assurance
// --------------------
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

// Hairs-AI:           Origin=AI; IP=Low; Security=None; Resources=0; Fingerprint=31739E
// Hairs-Human:        PENDING
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
// Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4624E7
// Hairs-Falsified-If: the vtable differs from IMFMediaEngineNotify in mfmediaengine.h, which has EventNotify alone at slot 3 under IID fee7c112-e776-42b5-9bbf-0048524e2bd5
// Hairs-Human:        PENDING
[GeneratedComInterface]
[Guid("FEE7C112-E776-42B5-9BBF-0048524E2BD5")]
[EditorBrowsable(EditorBrowsableState.Never)]
public partial interface IMFMediaEngineNotify
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=FD7E19
    // Hairs-Falsified-If: is not slot 3 of IMFMediaEngineNotify, HRESULT EventNotify(DWORD event, DWORD_PTR param1, DWORD param2) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int EventNotify(uint @event, UIntPtr param1, uint param2);
}

// Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=85C98C
// Hairs-Falsified-If: the member order differs from IMFMediaEngineClassFactory in mfmediaengine.h, whose vtable runs from CreateInstance at slot 3 to CreateError at slot 5
// Hairs-Human:        PENDING
[GeneratedComInterface]
[Guid("4D645ACE-26AA-4688-9BE1-DF3516990B93")]
public partial interface IMFMediaEngineClassFactory
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=9BBC9A
    // Hairs-Falsified-If: is not slot 3 of IMFMediaEngineClassFactory, HRESULT CreateInstance(DWORD dwFlags, IMFAttributes *pAttr, IMFMediaEngine **ppPlayer) in mfmediaengine.h, or the reference written to mediaEngine is not Released once its managed wrapper holds it
    // Hairs-Human:        PENDING
    [PreserveSig]
    int CreateInstance(uint createFlags, IMFAttributes attributes, out IMFMediaEngine mediaEngine);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=37E2E9
    // Hairs-Falsified-If: is not slot 4 of IMFMediaEngineClassFactory, HRESULT CreateTimeRange(IMFMediaTimeRange **ppTimeRange) in mfmediaengine.h, or the caller does not Release the IMFMediaTimeRange written to timeRange
    // Hairs-Human:        PENDING
    [PreserveSig]
    int CreateTimeRange(out IntPtr timeRange);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=DF2494
    // Hairs-Falsified-If: is not slot 5 of IMFMediaEngineClassFactory, HRESULT CreateError(IMFMediaError **ppError) in mfmediaengine.h, or the caller does not Release the IMFMediaError written to error
    // Hairs-Human:        PENDING
    [PreserveSig]
    int CreateError(out IntPtr error);
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=B197E9
// Hairs-Falsified-If: the member order differs from IMFMediaEngine in mfmediaengine.h, whose vtable runs from GetError at slot 3 to OnVideoStreamTick at slot 44 after the three IUnknown slots
// Hairs-Human:        PENDING
[GeneratedComInterface]
[Guid("98A1B0BB-03EB-4935-AE7C-93C1FA0E1C93")]
public partial interface IMFMediaEngine
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=E58FDF
    // Hairs-Falsified-If: is not slot 3 of IMFMediaEngine, HRESULT GetError(IMFMediaError **ppError) in mfmediaengine.h, or the caller does not Release the IMFMediaError written to error
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetError(out IntPtr error);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=ABCE54
    // Hairs-Falsified-If: is not slot 4 of IMFMediaEngine, HRESULT SetErrorCode(MF_MEDIA_ENGINE_ERR error) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetErrorCode(int error);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=8; Fingerprint=625F7D
    // Hairs-Falsified-If: is not slot 5 of IMFMediaEngine, HRESULT SetSourceElements(IMFMediaEngineSrcElements *pSrcElements) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetSourceElements(IntPtr sourceElements);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=8; Fingerprint=670DA0
    // Hairs-Falsified-If: is not slot 6 of IMFMediaEngine, HRESULT SetSource(BSTR pUrl) in mfmediaengine.h, or url reaches it as anything but a length-prefixed BSTR
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetSource([MarshalAs(UnmanagedType.BStr)] string url);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=CA939B
    // Hairs-Falsified-If: is not slot 7 of IMFMediaEngine, HRESULT GetCurrentSource(BSTR *ppUrl) in mfmediaengine.h, or the BSTR written to url is not released with SysFreeString after conversion
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetCurrentSource([MarshalAs(UnmanagedType.BStr)] out string? url);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=6A0B51
    // Hairs-Falsified-If: is not slot 8 of IMFMediaEngine, USHORT GetNetworkState(void) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    ushort GetNetworkState();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=55635A
    // Hairs-Falsified-If: is not slot 9 of IMFMediaEngine, MF_MEDIA_ENGINE_PRELOAD GetPreload(void) in mfmediaengine.h, whose return is the value itself and not an HRESULT
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetPreload();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B5134F
    // Hairs-Falsified-If: is not slot 10 of IMFMediaEngine, HRESULT SetPreload(MF_MEDIA_ENGINE_PRELOAD Preload) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetPreload(int preload);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=80B762
    // Hairs-Falsified-If: is not slot 11 of IMFMediaEngine, HRESULT GetBuffered(IMFMediaTimeRange **ppBuffered) in mfmediaengine.h, or the caller does not Release the IMFMediaTimeRange written to buffered
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetBuffered(out IntPtr buffered);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=8; Fingerprint=4179CD
    // Hairs-Falsified-If: is not slot 12 of IMFMediaEngine, HRESULT Load(void) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Load();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=310347
    // Hairs-Falsified-If: is not slot 13 of IMFMediaEngine, HRESULT CanPlayType(BSTR type, MF_MEDIA_ENGINE_CANPLAY *pAnswer) in mfmediaengine.h, or type reaches it as anything but a length-prefixed BSTR
    // Hairs-Human:        PENDING
    [PreserveSig]
    int CanPlayType([MarshalAs(UnmanagedType.BStr)] string type, out int answer);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=731F28
    // Hairs-Falsified-If: is not slot 14 of IMFMediaEngine, USHORT GetReadyState(void) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    ushort GetReadyState();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=40C53E
    // Hairs-Falsified-If: is not slot 15 of IMFMediaEngine, BOOL IsSeeking(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
    // Hairs-Human:        PENDING
    [PreserveSig]
    int IsSeeking();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D30507
    // Hairs-Falsified-If: is not slot 16 of IMFMediaEngine, double GetCurrentTime(void) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    double GetCurrentTime();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=7; Fingerprint=A4CA2E
    // Hairs-Falsified-If: is not slot 17 of IMFMediaEngine, HRESULT SetCurrentTime(double seekTime) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetCurrentTime(double seekTime);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B36727
    // Hairs-Falsified-If: is not slot 18 of IMFMediaEngine, double GetStartTime(void) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    double GetStartTime();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=AED091
    // Hairs-Falsified-If: is not slot 19 of IMFMediaEngine, double GetDuration(void) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    double GetDuration();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2CE76C
    // Hairs-Falsified-If: is not slot 20 of IMFMediaEngine, BOOL IsPaused(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
    // Hairs-Human:        PENDING
    [PreserveSig]
    int IsPaused();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=245D28
    // Hairs-Falsified-If: is not slot 21 of IMFMediaEngine, double GetDefaultPlaybackRate(void) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    double GetDefaultPlaybackRate();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=1D2A07
    // Hairs-Falsified-If: is not slot 22 of IMFMediaEngine, HRESULT SetDefaultPlaybackRate(double Rate) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetDefaultPlaybackRate(double rate);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=63C2D3
    // Hairs-Falsified-If: is not slot 23 of IMFMediaEngine, double GetPlaybackRate(void) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    double GetPlaybackRate();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=478425
    // Hairs-Falsified-If: is not slot 24 of IMFMediaEngine, HRESULT SetPlaybackRate(double Rate) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetPlaybackRate(double rate);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=C0F99A
    // Hairs-Falsified-If: is not slot 25 of IMFMediaEngine, HRESULT GetPlayed(IMFMediaTimeRange **ppPlayed) in mfmediaengine.h, or the caller does not Release the IMFMediaTimeRange written to played
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetPlayed(out IntPtr played);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=B6B68E
    // Hairs-Falsified-If: is not slot 26 of IMFMediaEngine, HRESULT GetSeekable(IMFMediaTimeRange **ppSeekable) in mfmediaengine.h, or the caller does not Release the IMFMediaTimeRange written to seekable
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetSeekable(out IntPtr seekable);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=4FE527
    // Hairs-Falsified-If: is not slot 27 of IMFMediaEngine, BOOL IsEnded(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
    // Hairs-Human:        PENDING
    [PreserveSig]
    int IsEnded();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=57EAA0
    // Hairs-Falsified-If: is not slot 28 of IMFMediaEngine, BOOL GetAutoPlay(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetAutoPlay();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=FEDB7F
    // Hairs-Falsified-If: is not slot 29 of IMFMediaEngine, HRESULT SetAutoPlay(BOOL AutoPlay) in mfmediaengine.h, or autoPlay is passed narrower than the 4-byte BOOL
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetAutoPlay(int autoPlay);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=5CDB3E
    // Hairs-Falsified-If: is not slot 30 of IMFMediaEngine, BOOL GetLoop(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetLoop();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=992AFA
    // Hairs-Falsified-If: is not slot 31 of IMFMediaEngine, HRESULT SetLoop(BOOL Loop) in mfmediaengine.h, or loop is passed narrower than the 4-byte BOOL
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetLoop(int loop);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=8; Fingerprint=69F7C6
    // Hairs-Falsified-If: is not slot 32 of IMFMediaEngine, HRESULT Play(void) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Play();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=3DEE33
    // Hairs-Falsified-If: is not slot 33 of IMFMediaEngine, HRESULT Pause(void) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Pause();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=5AB855
    // Hairs-Falsified-If: is not slot 34 of IMFMediaEngine, BOOL GetMuted(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetMuted();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=07AB7B
    // Hairs-Falsified-If: is not slot 35 of IMFMediaEngine, HRESULT SetMuted(BOOL Muted) in mfmediaengine.h, or muted is passed narrower than the 4-byte BOOL
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetMuted(int muted);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=53DD7D
    // Hairs-Falsified-If: is not slot 36 of IMFMediaEngine, double GetVolume(void) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    double GetVolume();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A18602
    // Hairs-Falsified-If: is not slot 37 of IMFMediaEngine, HRESULT SetVolume(double Volume) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int SetVolume(double volume);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=313443
    // Hairs-Falsified-If: is not slot 38 of IMFMediaEngine, BOOL HasVideo(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
    // Hairs-Human:        PENDING
    [PreserveSig]
    int HasVideo();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=238FA6
    // Hairs-Falsified-If: is not slot 39 of IMFMediaEngine, BOOL HasAudio(void) in mfmediaengine.h, or its 4-byte BOOL return is declared narrower
    // Hairs-Human:        PENDING
    [PreserveSig]
    int HasAudio();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B5334A
    // Hairs-Falsified-If: is not slot 40 of IMFMediaEngine, HRESULT GetNativeVideoSize(DWORD *cx, DWORD *cy) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetNativeVideoSize(out uint width, out uint height);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C5F727
    // Hairs-Falsified-If: is not slot 41 of IMFMediaEngine, HRESULT GetVideoAspectRatio(DWORD *cx, DWORD *cy) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetVideoAspectRatio(out uint width, out uint height);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B383A8
    // Hairs-Falsified-If: is not slot 42 of IMFMediaEngine, HRESULT Shutdown(void) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Shutdown();

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=037618
    // Hairs-Falsified-If: is not slot 43 of IMFMediaEngine, HRESULT TransferVideoFrame(IUnknown *pDstSurf, const MFVideoNormalizedRect *pSrc, const RECT *pDst, const MFARGB *pBorderClr) in mfmediaengine.h, or source does not address the 16-byte MFVideoNormalizedRect of four floats from mfidl.h and destination a 16-byte RECT from windef.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int TransferVideoFrame(IntPtr destinationSurface, IntPtr source, IntPtr destination, IntPtr borderColor);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B3A83D
    // Hairs-Falsified-If: is not slot 44 of IMFMediaEngine, HRESULT OnVideoStreamTick(LONGLONG *pPts) in mfmediaengine.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int OnVideoStreamTick(out long presentationTime);
}
