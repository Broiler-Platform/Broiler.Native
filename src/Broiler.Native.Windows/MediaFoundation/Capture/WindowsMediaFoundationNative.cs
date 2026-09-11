using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Broiler.Native.Windows.MediaFoundation.Capture;

public static class WindowsMediaFoundationNative
{
    public const int S_OK = 0;
    public const int S_FALSE = 1;
    public const int MF_VERSION = 0x00020070;
    public const int MFSTARTUP_NOSOCKET = 0x1;
    public const uint COINIT_MULTITHREADED = 0x0;

    public const int E_ACCESSDENIED = unchecked((int)0x80070005);
    public const int E_NOTFOUND = unchecked((int)0x80070490);
    public const int RPC_E_CHANGED_MODE = unchecked((int)0x80010106);
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

    [DllImport("mfplat.dll", ExactSpelling = true)]
    public static extern int MFStartup(int version, int flags);

    [DllImport("mfplat.dll", ExactSpelling = true)]
    public static extern int MFShutdown();

    [DllImport("mfplat.dll", ExactSpelling = true)]
    public static extern int MFCreateAttributes(out IMFAttributes attributes, uint initialSize);

    [DllImport("mf.dll", ExactSpelling = true)]
    public static extern int MFEnumDeviceSources(IMFAttributes attributes, out IntPtr devices, out uint count);

    [DllImport("mf.dll", ExactSpelling = true)]
    public static extern int MFCreateDeviceSource(IMFAttributes attributes, out IMFMediaSource mediaSource);

    [DllImport("mfreadwrite.dll", ExactSpelling = true)]
    public static extern int MFCreateSourceReaderFromMediaSource(IMFMediaSource mediaSource, IMFAttributes? attributes,
        out IMFSourceReader sourceReader);

    [DllImport("ole32.dll")]
    public static extern void CoTaskMemFree(IntPtr value);

    [DllImport("ole32.dll")]
    public static extern int CoInitializeEx(IntPtr reserved, uint coInit);

    [DllImport("ole32.dll")]
    public static extern void CoUninitialize();
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
[Guid("7FEE9E9A-4A89-47A6-899C-B6A53A70FB67")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IMFActivate : IMFAttributes
{
    [PreserveSig]
    int ActivateObject(ref Guid interfaceId, [MarshalAs(UnmanagedType.IUnknown)] out object? activatedObject);

    [PreserveSig]
    int ShutdownObject();

    [PreserveSig]
    int DetachObject();
}

[ComImport]
[Guid("279A808D-AEC7-40C8-9C6B-A6B492C78A66")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IMFMediaSource
{
    [PreserveSig]
    int GetEvent(int flags, [MarshalAs(UnmanagedType.IUnknown)] out object? mediaEvent);

    [PreserveSig]
    int BeginGetEvent([MarshalAs(UnmanagedType.IUnknown)] object? callback, [MarshalAs(UnmanagedType.IUnknown)] object? state);

    [PreserveSig]
    int EndGetEvent([MarshalAs(UnmanagedType.IUnknown)] object result, [MarshalAs(UnmanagedType.IUnknown)] out object? mediaEvent);

    [PreserveSig]
    int QueueEvent(int mediaEventType, ref Guid extendedType, int status, IntPtr value);

    [PreserveSig]
    int GetCharacteristics(out int characteristics);

    [PreserveSig]
    int CreatePresentationDescriptor([MarshalAs(UnmanagedType.IUnknown)] out object? presentationDescriptor);

    [PreserveSig]
    int Start([MarshalAs(UnmanagedType.IUnknown)] object presentationDescriptor, ref Guid timeFormat, IntPtr startPosition);

    [PreserveSig]
    int Stop();

    [PreserveSig]
    int Pause();

    [PreserveSig]
    int Shutdown();
}

[ComImport]
[Guid("44AE0FA8-EA31-4109-8D2E-4CAE4997C555")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IMFMediaType : IMFAttributes
{
    [PreserveSig]
    int GetMajorType(out Guid majorType);

    [PreserveSig]
    int IsCompressedFormat([MarshalAs(UnmanagedType.Bool)] out bool compressed);

    [PreserveSig]
    int IsEqual(IMFMediaType mediaType, out int flags);

    [PreserveSig]
    int GetRepresentation(Guid representation, out IntPtr representationData);

    [PreserveSig]
    int FreeRepresentation(Guid representation, IntPtr representationData);
}

[ComImport]
[Guid("70AE66F2-C809-4E4F-8915-BDCB406B7993")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IMFSourceReader
{
    [PreserveSig]
    int GetStreamSelection(int streamIndex, [MarshalAs(UnmanagedType.Bool)] out bool selected);

    [PreserveSig]
    int SetStreamSelection(int streamIndex, [MarshalAs(UnmanagedType.Bool)] bool selected);

    [PreserveSig]
    int GetNativeMediaType(int streamIndex, int mediaTypeIndex, out IMFMediaType mediaType);

    [PreserveSig]
    int GetCurrentMediaType(int streamIndex, out IMFMediaType mediaType);

    [PreserveSig]
    int SetCurrentMediaType(int streamIndex, IntPtr reserved, IMFMediaType mediaType);

    [PreserveSig]
    int SetCurrentPosition(ref Guid timeFormat, IntPtr position);

    [PreserveSig]
    int ReadSample(int streamIndex, int controlFlags, out int actualStreamIndex, out SourceReaderFlags streamFlags,
        out long timestamp, out IMFSample? sample);

    [PreserveSig]
    int Flush(int streamIndex);

    [PreserveSig]
    int GetServiceForStream(int streamIndex, ref Guid service, ref Guid interfaceId, [MarshalAs(UnmanagedType.IUnknown)] out object? serviceObject);

    [PreserveSig]
    int GetPresentationAttribute(int streamIndex, ref Guid attribute, IntPtr value);
}

[ComImport]
[Guid("C40A00F2-B93A-4D80-AE8C-5A1C634F58E4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IMFSample
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

    [PreserveSig]
    int GetSampleFlags(out int flags);

    [PreserveSig]
    int SetSampleFlags(int flags);

    [PreserveSig]
    int GetSampleTime(out long sampleTime);

    [PreserveSig]
    int SetSampleTime(long sampleTime);

    [PreserveSig]
    int GetSampleDuration(out long sampleDuration);

    [PreserveSig]
    int SetSampleDuration(long sampleDuration);

    [PreserveSig]
    int GetBufferCount(out int bufferCount);

    [PreserveSig]
    int GetBufferByIndex(int index, out IMFMediaBuffer buffer);

    [PreserveSig]
    int ConvertToContiguousBuffer(out IMFMediaBuffer buffer);

    [PreserveSig]
    int AddBuffer(IMFMediaBuffer buffer);

    [PreserveSig]
    int RemoveBufferByIndex(int index);

    [PreserveSig]
    int RemoveAllBuffers();

    [PreserveSig]
    int GetTotalLength(out int totalLength);

    [PreserveSig]
    int CopyToBuffer(IMFMediaBuffer buffer);
}

[GeneratedComInterface]
[Guid("045FA593-8799-42B8-BC8D-8968C6453507")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public partial interface IMFMediaBuffer
{
    [PreserveSig]
    int Lock(out IntPtr buffer, out int maxLength, out int currentLength);

    [PreserveSig]
    int Unlock();

    [PreserveSig]
    int GetCurrentLength(out int currentLength);

    [PreserveSig]
    int SetCurrentLength(int currentLength);

    [PreserveSig]
    int GetMaxLength(out int maxLength);
}
