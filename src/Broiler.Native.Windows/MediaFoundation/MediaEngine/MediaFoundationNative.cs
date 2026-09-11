using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Broiler.Native.Windows.MediaFoundation.MediaEngine;

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
[ComVisible(true)]
[Guid("FEE7C112-E776-42B5-9BBF-0048524E2BD5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
// COM requires a public interface for QueryInterface, even with ComVisible(true).
[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
public interface IMFMediaEngineNotify
{
    [PreserveSig]
    int EventNotify(uint @event, UIntPtr param1, uint param2);
}

[ComImport]
[Guid("4D645ACE-26AA-4688-9BE1-DF3516990B93")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IMFMediaEngineClassFactory
{
    [PreserveSig]
    int CreateInstance(uint createFlags, IMFAttributes attributes, out IMFMediaEngine mediaEngine);

    [PreserveSig]
    int CreateTimeRange([MarshalAs(UnmanagedType.IUnknown)] out object? timeRange);

    [PreserveSig]
    int CreateError([MarshalAs(UnmanagedType.IUnknown)] out object? error);
}

[ComImport]
[Guid("98A1B0BB-03EB-4935-AE7C-93C1FA0E1C93")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IMFMediaEngine
{
    [PreserveSig]
    int GetError([MarshalAs(UnmanagedType.IUnknown)] out object? error);

    [PreserveSig]
    int SetErrorCode(int error);

    [PreserveSig]
    int SetSourceElements([MarshalAs(UnmanagedType.IUnknown)] object? sourceElements);

    [PreserveSig]
    int SetSource([MarshalAs(UnmanagedType.BStr)] string url);

    [PreserveSig]
    int GetCurrentSource([MarshalAs(UnmanagedType.BStr)] out string? url);

    [PreserveSig]
    ushort GetNetworkState();

    [PreserveSig]
    int GetPreload();

    [PreserveSig]
    int SetPreload(int preload);

    [PreserveSig]
    int GetBuffered([MarshalAs(UnmanagedType.IUnknown)] out object? buffered);

    [PreserveSig]
    int Load();

    [PreserveSig]
    int CanPlayType([MarshalAs(UnmanagedType.BStr)] string type, out int answer);

    [PreserveSig]
    ushort GetReadyState();

    [PreserveSig]
    int IsSeeking();

    [PreserveSig]
    double GetCurrentTime();

    [PreserveSig]
    int SetCurrentTime(double seekTime);

    [PreserveSig]
    double GetStartTime();

    [PreserveSig]
    double GetDuration();

    [PreserveSig]
    int IsPaused();

    [PreserveSig]
    double GetDefaultPlaybackRate();

    [PreserveSig]
    int SetDefaultPlaybackRate(double rate);

    [PreserveSig]
    double GetPlaybackRate();

    [PreserveSig]
    int SetPlaybackRate(double rate);

    [PreserveSig]
    int GetPlayed([MarshalAs(UnmanagedType.IUnknown)] out object? played);

    [PreserveSig]
    int GetSeekable([MarshalAs(UnmanagedType.IUnknown)] out object? seekable);

    [PreserveSig]
    int IsEnded();

    [PreserveSig]
    int GetAutoPlay();

    [PreserveSig]
    int SetAutoPlay(int autoPlay);

    [PreserveSig]
    int GetLoop();

    [PreserveSig]
    int SetLoop(int loop);

    [PreserveSig]
    int Play();

    [PreserveSig]
    int Pause();

    [PreserveSig]
    int GetMuted();

    [PreserveSig]
    int SetMuted(int muted);

    [PreserveSig]
    double GetVolume();

    [PreserveSig]
    int SetVolume(double volume);

    [PreserveSig]
    int HasVideo();

    [PreserveSig]
    int HasAudio();

    [PreserveSig]
    int GetNativeVideoSize(out uint width, out uint height);

    [PreserveSig]
    int GetVideoAspectRatio(out uint width, out uint height);

    [PreserveSig]
    int Shutdown();

    [PreserveSig]
    int TransferVideoFrame(IntPtr destinationSurface, IntPtr source, IntPtr destination, IntPtr borderColor);

    [PreserveSig]
    int OnVideoStreamTick(out long presentationTime);
}
