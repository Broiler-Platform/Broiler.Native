using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Broiler.Native.Windows.MediaFoundation.MediaEngine;

public static partial class MediaFoundationNative
{
    public const int S_OK = 0;
    public const int S_FALSE = 1;
    public const int MF_VERSION = 0x00020070;
    public const int MFSTARTUP_NOSOCKET = 0x1;
    public const uint COINIT_MULTITHREADED = 0x0;
    public const uint CLSCTX_INPROC_SERVER = 0x1;

    public const int E_ACCESSDENIED = unchecked((int)0x80070005);
    public const int RPC_E_CHANGED_MODE = unchecked((int)0x80010106);
    public const int MF_E_PLATFORM_NOT_INITIALIZED = unchecked((int)0xC00D36B0);
    public const int MF_E_INVALIDMEDIATYPE = unchecked((int)0xC00D36B4);
    public const int MF_E_NOT_INITIALIZED = unchecked((int)0xC00D36B6);
    public const int MF_E_NOT_AVAILABLE = unchecked((int)0xC00D36D6);
    public const int MF_E_DISABLED_IN_SAFEMODE = unchecked((int)0xC00D36EF);
    public const int MF_E_SHUTDOWN = unchecked((int)0xC00D3E85);

    public const uint MF_MEDIA_ENGINE_FORCEMUTE = 0x4;
    public const uint MF_MEDIA_ENGINE_DISABLE_LOCAL_PLUGINS = 0x10;

    public static readonly Guid CLSID_MFMediaEngineClassFactory = new("B44392DA-499B-446B-A4CB-005FEAD0E6D5");
    public static readonly Guid IID_IMFMediaEngineClassFactory = new("4D645ACE-26AA-4688-9BE1-DF3516990B93");

    public static readonly Guid MF_MEDIA_ENGINE_CALLBACK = new("C60381B8-83A4-41F8-A3D0-DE05076849A9");
    public static readonly Guid MF_MEDIA_ENGINE_PLAYBACK_HWND = new("D988879B-67C9-4D92-BAA7-6EADD446039D");
    public static readonly Guid MF_MEDIA_ENGINE_SYNCHRONOUS_CLOSE = new("C3C2E12F-7E0E-4E43-B91C-DC992CCDFA5E");
    public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE = new("4E0212E2-E18F-41E1-95E5-C0E7E9235BC3");
    public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE_EDGE = new("A6F3E465-3ACA-442C-A3F0-AD6DDAD839AE");

    [LibraryImport("mfplat.dll")]
    public static partial int MFStartup(int version, int flags);

    [LibraryImport("mfplat.dll")]
    public static partial int MFShutdown();

    [LibraryImport("mfplat.dll")]
    public static partial int MFCreateAttributes(out IntPtr attributes, uint initialSize);

    [LibraryImport("ole32.dll")]
    public static partial int CoInitializeEx(IntPtr reserved, uint coInit);

    [LibraryImport("ole32.dll")]
    public static partial void CoUninitialize();

    [LibraryImport("ole32.dll")]
    public static partial int CoCreateInstance(ref Guid rclsid, IntPtr pUnkOuter, uint dwClsContext, ref Guid riid, out IntPtr ppv);

    public static void ReleaseIUnknown(IntPtr value)
    {
        if (value != IntPtr.Zero)
            Marshal.Release(value);
    }

    [SupportedOSPlatform("windows")]
    public static void ReleaseComObject(object? value)
    {
        if (value is not null && Marshal.IsComObject(value))
            Marshal.ReleaseComObject(value);
    }
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
[Guid("2CD2D921-C447-44A7-A13C-4ADABFC247E3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IMFAttributes
{
    [PreserveSig]
    int GetItem(ref Guid key, IntPtr value);

    [PreserveSig]
    int GetItemType(ref Guid key, out int type);

    [PreserveSig]
    int CompareItem(ref Guid key, IntPtr value, [MarshalAs(UnmanagedType.Bool)] out bool result);

    [PreserveSig]
    int Compare(IMFAttributes attributes, int matchType, [MarshalAs(UnmanagedType.Bool)] out bool result);

    [PreserveSig]
    int GetUINT32(ref Guid key, out int value);

    [PreserveSig]
    int GetUINT64(ref Guid key, out long value);

    [PreserveSig]
    int GetDouble(ref Guid key, out double value);

    [PreserveSig]
    int GetGUID(ref Guid key, out Guid value);

    [PreserveSig]
    int GetStringLength(ref Guid key, out int length);

    [PreserveSig]
    int GetString(ref Guid key, IntPtr value, int size, out int length);

    [PreserveSig]
    int GetAllocatedString(ref Guid key, out IntPtr value, out int length);

    [PreserveSig]
    int GetBlobSize(ref Guid key, out int size);

    [PreserveSig]
    int GetBlob(ref Guid key, IntPtr buffer, int bufferSize, out int blobSize);

    [PreserveSig]
    int GetAllocatedBlob(ref Guid key, out IntPtr buffer, out int size);

    [PreserveSig]
    int GetUnknown(ref Guid key, ref Guid interfaceId, [MarshalAs(UnmanagedType.IUnknown)] out object? value);

    [PreserveSig]
    int SetItem(ref Guid key, IntPtr value);

    [PreserveSig]
    int DeleteItem(ref Guid key);

    [PreserveSig]
    int DeleteAllItems();

    [PreserveSig]
    int SetUINT32(ref Guid key, int value);

    [PreserveSig]
    int SetUINT64(ref Guid key, long value);

    [PreserveSig]
    int SetDouble(ref Guid key, double value);

    [PreserveSig]
    int SetGUID(ref Guid key, ref Guid value);

    [PreserveSig]
    int SetString(ref Guid key, [MarshalAs(UnmanagedType.LPWStr)] string value);

    [PreserveSig]
    int SetBlob(ref Guid key, IntPtr buffer, int size);

    [PreserveSig]
    int SetUnknown(ref Guid key, [MarshalAs(UnmanagedType.IUnknown)] object? value);

    [PreserveSig]
    int LockStore();

    [PreserveSig]
    int UnlockStore();

    [PreserveSig]
    int GetCount(out int count);

    [PreserveSig]
    int GetItemByIndex(int index, out Guid key, IntPtr value);

    [PreserveSig]
    int CopyAllItems(IMFAttributes destination);
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
