using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.MediaFoundation;

/// <summary>Media Foundation platform startup, attribute creation, and error codes.</summary>
public static partial class MediaFoundationPlatformNative
{
    public const int MF_VERSION = 0x00020070;
    public const int MFSTARTUP_NOSOCKET = 0x1;
    public const int MF_E_PLATFORM_NOT_INITIALIZED = unchecked((int)0xC00D36B0);
    public const int MF_E_INVALIDMEDIATYPE = unchecked((int)0xC00D36B4);
    public const int MF_E_NOT_INITIALIZED = unchecked((int)0xC00D36B6);
    public const int MF_E_NO_MORE_TYPES = unchecked((int)0xC00D36B9);
    public const int MF_E_NOT_FOUND = unchecked((int)0xC00D36D5);
    public const int MF_E_NOT_AVAILABLE = unchecked((int)0xC00D36D6);
    public const int MF_E_ATTRIBUTENOTFOUND = unchecked((int)0xC00D36E6);
    public const int MF_E_DISABLED_IN_SAFEMODE = unchecked((int)0xC00D36EF);
    public const int MF_E_SHUTDOWN = unchecked((int)0xC00D3E85);
    public const int MF_E_VIDEO_RECORDING_DEVICE_INVALIDATED = unchecked((int)0xC00D3EA2);
    public const int MF_E_VIDEO_RECORDING_DEVICE_PREEMPTED = unchecked((int)0xC00D3EA3);
    public const int MF_E_VIDEO_DEVICE_LOCKED = unchecked((int)0xC00D4E24);
    public const int MF_E_NO_CAPTURE_DEVICES_AVAILABLE = unchecked((int)0xC00DABE0);
    public const int MF_E_CAPTURE_SOURCE_NO_VIDEO_STREAM_PRESENT = unchecked((int)0xC00DABE7);
    public const int MF_E_UNSUPPORTED_CAPTURE_DEVICE_PRESENT = unchecked((int)0xC00DABED);

    [LibraryImport("mfplat.dll")]
    public static partial int MFStartup(int version, int flags);

    [LibraryImport("mfplat.dll")]
    public static partial int MFShutdown();

    [DllImport("mfplat.dll", ExactSpelling = true)]
    public static extern int MFCreateAttributes(out IMFAttributes attributes, uint initialSize);

    [LibraryImport("mfplat.dll")]
    public static partial int MFCreateAttributes(out IntPtr attributes, uint initialSize);
}
