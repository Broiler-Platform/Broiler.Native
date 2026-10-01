// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   56
// Annotated:        56/56
// Exempt:           59
// Human-reviewed:   0/56
// IP risk:          Low
// Security risk:    Critical
// Criteria:         56/56
// Resource impact:  5/10 max
// Unverified:       56
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Broiler.Native.Windows.Wasapi;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=C217C8
// Broiler-Falsified-If: a member differs from its prototype in combaseapi.h (PropVariantClear), synchapi.h (CreateEventW, SetEvent, WaitForSingleObject) or handleapi.h (CloseHandle)
// Broiler-Human:        PENDING
public static partial class WindowsWasapiNative
{
    public const int AUDCLNT_E_DEVICE_INVALIDATED = unchecked((int)0x88890004);
    public const int AUDCLNT_E_UNSUPPORTED_FORMAT = unchecked((int)0x88890008);
    public const int AUDCLNT_E_DEVICE_IN_USE = unchecked((int)0x8889000A);
    public const int AUDCLNT_E_SERVICE_NOT_RUNNING = unchecked((int)0x88890010);

    public const uint WAIT_OBJECT_0 = 0;
    public const uint WAIT_TIMEOUT = 258;
    public const uint WAIT_FAILED = 0xFFFFFFFF;

    public static readonly Guid MMDeviceEnumeratorClassId = new("BCDE0395-E52F-467C-8E3D-C4579291692E");
    public static readonly Guid IMMDeviceEnumeratorId = new("A95664D2-9614-4F35-A746-DE8DB63617E6");
    public static readonly Guid IAudioClientId = new("1CB9AD4C-DBFA-4c32-B178-C2F568A703B2");
    public static readonly Guid IAudioCaptureClientId = new("C8ADBD64-E71E-48a0-A4DE-185C395CD317");

    public static readonly Guid PcmSubFormat = new("00000001-0000-0010-8000-00aa00389b71");
    public static readonly Guid IeeeFloatSubFormat = new("00000003-0000-0010-8000-00aa00389b71");

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=72B3B6
    // Broiler-Falsified-If: differs from WINOLEAPI PropVariantClear(PROPVARIANT *pvar) in combaseapi.h, whose pvar is the 24-byte x64 PROPVARIANT of propidl.h, so the PropVariant passed must be 24 bytes there
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial int PropVariantClear(ref PropVariant value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=7EA6F8
    // Broiler-Falsified-If: differs from HANDLE CreateEventW(LPSECURITY_ATTRIBUTES lpEventAttributes, BOOL bManualReset, BOOL bInitialState, LPCWSTR lpName) in synchapi.h, or passes a BOOL in other than 4 bytes or lpName in other than UTF-16, or a NULL return leaves the last error uncaptured
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    public static partial IntPtr CreateEventW(IntPtr eventAttributes, [MarshalAs(UnmanagedType.Bool)] bool manualReset,
        [MarshalAs(UnmanagedType.Bool)] bool initialState, string? name);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E6D39B
    // Broiler-Falsified-If: differs from BOOL SetEvent(HANDLE hEvent) in synchapi.h, or reads the BOOL in other than 4 bytes, or a FALSE return leaves the last error uncaptured
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SetEvent(IntPtr handle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0F7F8E
    // Broiler-Falsified-If: differs from BOOL CloseHandle(HANDLE hObject) in handleapi.h, or reads the BOOL in other than 4 bytes, or a FALSE return leaves the last error uncaptured
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CloseHandle(IntPtr handle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=75FDEC
    // Broiler-Falsified-If: differs from DWORD WaitForSingleObject(HANDLE hHandle, DWORD dwMilliseconds) in synchapi.h, or a WAIT_FAILED return leaves the last error uncaptured
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true)]
    public static partial uint WaitForSingleObject(IntPtr handle, uint milliseconds);
}

public enum EDataFlow
{
    Render = 0,
    Capture = 1,
    All = 2,
}

public enum ERole
{
    Console = 0,
    Multimedia = 1,
    Communications = 2,
}

[Flags]
public enum DeviceState : uint
{
    Active = 0x00000001,
    Disabled = 0x00000002,
    NotPresent = 0x00000004,
    Unplugged = 0x00000008,
    All = 0x0000000F,
}

public enum StorageAccess
{
    Read = 0,
}

public enum AudioClientShareMode
{
    Shared = 0,
    Exclusive = 1,
}

[Flags]
public enum AudioClientStreamFlags : uint
{
    None = 0,
    EventCallback = 0x00040000,
}

[Flags]
public enum AudioClientBufferFlags : uint
{
    None = 0,
    DataDiscontinuity = 0x1,
    Silent = 0x2,
    TimestampError = 0x4,
}

// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=B090C8
// Broiler-Falsified-If: Marshal.SizeOf of PropertyKey is not 20 or Marshal.OffsetOf its PropertyId is not 16, the layout of PROPERTYKEY (GUID fmtid, DWORD pid) in wtypes.h
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct PropertyKey(Guid formatId, uint propertyId)
{
    public Guid FormatId = formatId;

    public uint PropertyId = propertyId;
}

/// <summary>The propidl.h PROPVARIANT: an 8-byte header and a value union.</summary>
/// <remarks>
/// The union's widest members, BLOB and the counted arrays, are a ULONG and a pointer, so it is
/// two pointers wide: 16 bytes on 64-bit and 8 on 32-bit, making the struct 24 or 16 bytes. Native
/// code writes all of it (IPropertyStore.GetValue fills it, PropVariantClear zeroes it), so a
/// shorter managed struct lets those calls overwrite whatever follows it.
/// </remarks>
// Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=6295F8
// Broiler-Falsified-If: Marshal.SizeOf of PropVariant is not 24 on 64-bit and 16 on 32-bit, the size of PROPVARIANT in propidl.h, whose value union holds the ULONG-plus-pointer BLOB
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct PropVariant
{
    public ushort ValueType;
    private ushort _reserved1;
    private ushort _reserved2;
    private ushort _reserved3;
    public IntPtr PointerValue;
    private IntPtr _unionTail;
}

// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=6A0461
// Broiler-Falsified-If: Marshal.SizeOf of WaveFormatEx is not 18, or Marshal.OffsetOf SamplesPerSec and Size are not 4 and 16, the byte-packed WAVEFORMATEX of mmreg.h
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct WaveFormatEx
{
    public ushort FormatTag;
    public ushort Channels;
    public uint SamplesPerSec;
    public uint AvgBytesPerSec;
    public ushort BlockAlign;
    public ushort BitsPerSample;
    public ushort Size;
}

// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=DE61A8
// Broiler-Falsified-If: Marshal.SizeOf of WaveFormatExtensible is not 40, or Marshal.OffsetOf ValidBitsPerSample, ChannelMask and SubFormat are not 18, 20 and 24, the byte-packed WAVEFORMATEXTENSIBLE of mmreg.h
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct WaveFormatExtensible
{
    public WaveFormatEx Format;
    public ushort ValidBitsPerSample;
    public uint ChannelMask;
    public Guid SubFormat;
}

// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=5E529E
// Broiler-Falsified-If: its vtable is not the IMMDeviceEnumerator order of mmdeviceapi.h, EnumAudioEndpoints at slot 3 through UnregisterEndpointNotificationCallback at slot 7
// Broiler-Human:        PENDING
[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("A95664D2-9614-4F35-A746-DE8DB63617E6")]
public partial interface IMMDeviceEnumerator
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=B02A40
    // Broiler-Falsified-If: is not slot 3 of IMMDeviceEnumerator, HRESULT EnumAudioEndpoints(EDataFlow dataFlow, DWORD dwStateMask, IMMDeviceCollection **ppDevices) in mmdeviceapi.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int EnumAudioEndpoints(EDataFlow dataFlow, DeviceState stateMask, out IMMDeviceCollection devices);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=2C427E
    // Broiler-Falsified-If: is not slot 4 of IMMDeviceEnumerator, HRESULT GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, IMMDevice **ppEndpoint) in mmdeviceapi.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, out IMMDevice endpoint);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B582C9
    // Broiler-Falsified-If: is not slot 5 of IMMDeviceEnumerator, HRESULT GetDevice(LPCWSTR pwstrId, IMMDevice **ppDevice) in mmdeviceapi.h, or id reaches pwstrId as other than a NUL-terminated UTF-16 string
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetDevice(string id, out IMMDevice device);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=5ECB61
    // Broiler-Falsified-If: is not slot 6 of IMMDeviceEnumerator, HRESULT RegisterEndpointNotificationCallback(IMMNotificationClient *pClient) in mmdeviceapi.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int RegisterEndpointNotificationCallback(IMMNotificationClient client);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=81112A
    // Broiler-Falsified-If: is not slot 7 of IMMDeviceEnumerator, HRESULT UnregisterEndpointNotificationCallback(IMMNotificationClient *pClient) in mmdeviceapi.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int UnregisterEndpointNotificationCallback(IMMNotificationClient client);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=6ACDC0
// Broiler-Falsified-If: its vtable is not the IMMDeviceCollection order of mmdeviceapi.h, GetCount at slot 3 and Item at slot 4
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("0BD7A1BE-7A1A-44DB-8397-CC5392387B5E")]
public partial interface IMMDeviceCollection
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=9DEF9C
    // Broiler-Falsified-If: is not slot 3 of IMMDeviceCollection, HRESULT GetCount(UINT *pcDevices) in mmdeviceapi.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCount(out uint count);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=A3EAF2
    // Broiler-Falsified-If: is not slot 4 of IMMDeviceCollection, HRESULT Item(UINT nDevice, IMMDevice **ppDevice) in mmdeviceapi.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Item(uint itemIndex, out IMMDevice device);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=37CE13
// Broiler-Falsified-If: its vtable is not the IMMDevice order of mmdeviceapi.h, Activate at slot 3 through GetState at slot 6
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("D666063F-1587-4E43-81F1-B948E807363F")]
public partial interface IMMDevice
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=86ECE4
    // Broiler-Falsified-If: is not slot 3 of IMMDevice, HRESULT Activate(REFIID iid, DWORD dwClsCtx, PROPVARIANT *pActivationParams, void **ppInterface) in mmdeviceapi.h, whose reference arrives as a raw IntPtr that no marshaller releases
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Activate(ref Guid interfaceId, uint classContext, IntPtr activationParams, out IntPtr activatedInterface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=4D668C
    // Broiler-Falsified-If: is not slot 4 of IMMDevice, HRESULT OpenPropertyStore(DWORD stgmAccess, IPropertyStore **ppProperties) in mmdeviceapi.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OpenPropertyStore(StorageAccess access, out IPropertyStore properties);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=A54561
    // Broiler-Falsified-If: is not slot 5 of IMMDevice, HRESULT GetId(LPWSTR *ppstrId) in mmdeviceapi.h, whose string arrives as a raw IntPtr the caller must free with CoTaskMemFree
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetId(out IntPtr id);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2C18EF
    // Broiler-Falsified-If: is not slot 6 of IMMDevice, HRESULT GetState(DWORD *pdwState) in mmdeviceapi.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetState(out DeviceState state);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=079EE3
// Broiler-Falsified-If: its vtable is not the IPropertyStore order of propsys.h, GetCount at slot 3 through Commit at slot 7
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99")]
public partial interface IPropertyStore
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=39889B
    // Broiler-Falsified-If: is not slot 3 of IPropertyStore, HRESULT GetCount(DWORD *cProps) in propsys.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCount(out uint propertyCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=53B7D0
    // Broiler-Falsified-If: is not slot 4 of IPropertyStore, HRESULT GetAt(DWORD iProp, PROPERTYKEY *pkey) in propsys.h, or PropertyKey is not the 20 bytes pkey receives
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetAt(uint propertyIndex, out PropertyKey key);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=2E7085
    // Broiler-Falsified-If: is not slot 5 of IPropertyStore, HRESULT GetValue(REFPROPERTYKEY key, PROPVARIANT *pv) in propsys.h, or PropVariant is smaller than the 24-byte x64 PROPVARIANT pv receives
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetValue(ref PropertyKey key, out PropVariant value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=7DEB4C
    // Broiler-Falsified-If: is not slot 6 of IPropertyStore, HRESULT SetValue(REFPROPERTYKEY key, REFPROPVARIANT propvar) in propsys.h, or PropVariant is smaller than the 24-byte x64 PROPVARIANT propvar is read as
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetValue(ref PropertyKey key, ref PropVariant value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=8609BA
    // Broiler-Falsified-If: is not slot 7 of IPropertyStore, HRESULT Commit(void) in propsys.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Commit();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=2B52F8
// Broiler-Falsified-If: its vtable is not the IMMNotificationClient order of mmdeviceapi.h, OnDeviceStateChanged at slot 3 through OnPropertyValueChanged at slot 7
// Broiler-Human:        PENDING
[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("7991EEC9-7E89-4D85-8390-6C703CEC60C0")]
public partial interface IMMNotificationClient
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=96A9AC
    // Broiler-Falsified-If: is not slot 3 of IMMNotificationClient, HRESULT OnDeviceStateChanged(LPCWSTR pwstrDeviceId, DWORD dwNewState) in mmdeviceapi.h, or pwstrDeviceId is read as other than NUL-terminated UTF-16
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OnDeviceStateChanged(string deviceId, DeviceState newState);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4EA116
    // Broiler-Falsified-If: is not slot 4 of IMMNotificationClient, HRESULT OnDeviceAdded(LPCWSTR pwstrDeviceId) in mmdeviceapi.h, or pwstrDeviceId is read as other than NUL-terminated UTF-16
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OnDeviceAdded(string deviceId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=A1017B
    // Broiler-Falsified-If: is not slot 5 of IMMNotificationClient, HRESULT OnDeviceRemoved(LPCWSTR pwstrDeviceId) in mmdeviceapi.h, or pwstrDeviceId is read as other than NUL-terminated UTF-16
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OnDeviceRemoved(string deviceId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=5AFB15
    // Broiler-Falsified-If: is not slot 6 of IMMNotificationClient, HRESULT OnDefaultDeviceChanged(EDataFlow flow, ERole role, LPCWSTR pwstrDefaultDeviceId) in mmdeviceapi.h, or the _In_opt_ pwstrDefaultDeviceId is declared as a non-nullable string, as it is today
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OnDefaultDeviceChanged(EDataFlow flow, ERole role, string defaultDeviceId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=DEBD93
    // Broiler-Falsified-If: is not slot 7 of IMMNotificationClient, HRESULT OnPropertyValueChanged(LPCWSTR pwstrDeviceId, const PROPERTYKEY key) in mmdeviceapi.h, or key is taken other than by value as the 20-byte PROPERTYKEY
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OnPropertyValueChanged(string deviceId, PropertyKey key);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=85032C
// Broiler-Falsified-If: its vtable is not the IAudioClient order of audioclient.h, Initialize at slot 3 through GetService at slot 14
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("1CB9AD4C-DBFA-4C32-B178-C2F568A703B2")]
public partial interface IAudioClient
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=8F9E64
    // Broiler-Falsified-If: is not slot 3 of IAudioClient, HRESULT Initialize(AUDCLNT_SHAREMODE ShareMode, DWORD StreamFlags, REFERENCE_TIME hnsBufferDuration, REFERENCE_TIME hnsPeriodicity, const WAVEFORMATEX *pFormat, LPCGUID AudioSessionGuid) in audioclient.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Initialize(AudioClientShareMode shareMode, AudioClientStreamFlags streamFlags, long bufferDuration,
        long periodicity, IntPtr format, IntPtr audioSessionGuid);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7407DC
    // Broiler-Falsified-If: is not slot 4 of IAudioClient, HRESULT GetBufferSize(UINT32 *pNumBufferFrames) in audioclient.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBufferSize(out uint bufferFrameCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=FEE5D6
    // Broiler-Falsified-If: is not slot 5 of IAudioClient, HRESULT GetStreamLatency(REFERENCE_TIME *phnsLatency) in audioclient.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetStreamLatency(out long latency);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B5581D
    // Broiler-Falsified-If: is not slot 6 of IAudioClient, HRESULT GetCurrentPadding(UINT32 *pNumPaddingFrames) in audioclient.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCurrentPadding(out uint currentPaddingFrameCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=9D437E
    // Broiler-Falsified-If: is not slot 7 of IAudioClient, HRESULT IsFormatSupported(AUDCLNT_SHAREMODE ShareMode, const WAVEFORMATEX *pFormat, WAVEFORMATEX **ppClosestMatch) in audioclient.h, whose closest match arrives as a raw IntPtr the caller must free with CoTaskMemFree
    // Broiler-Human:        PENDING
    [PreserveSig]
    int IsFormatSupported(AudioClientShareMode shareMode, IntPtr format, out IntPtr closestMatch);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=EB4C3A
    // Broiler-Falsified-If: is not slot 8 of IAudioClient, HRESULT GetMixFormat(WAVEFORMATEX **ppDeviceFormat) in audioclient.h, whose format block arrives as a raw IntPtr the caller must free with CoTaskMemFree
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetMixFormat(out IntPtr deviceFormat);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C6E8C9
    // Broiler-Falsified-If: is not slot 9 of IAudioClient, HRESULT GetDevicePeriod(REFERENCE_TIME *phnsDefaultDevicePeriod, REFERENCE_TIME *phnsMinimumDevicePeriod) in audioclient.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetDevicePeriod(out long defaultDevicePeriod, out long minimumDevicePeriod);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=6B8586
    // Broiler-Falsified-If: is not slot 10 of IAudioClient, HRESULT Start(void) in audioclient.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Start();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=458393
    // Broiler-Falsified-If: is not slot 11 of IAudioClient, HRESULT Stop(void) in audioclient.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Stop();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=C17181
    // Broiler-Falsified-If: is not slot 12 of IAudioClient, HRESULT Reset(void) in audioclient.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Reset();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A5695E
    // Broiler-Falsified-If: is not slot 13 of IAudioClient, HRESULT SetEventHandle(HANDLE eventHandle) in audioclient.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetEventHandle(IntPtr eventHandle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=DCDAC0
    // Broiler-Falsified-If: is not slot 14 of IAudioClient, HRESULT GetService(REFIID riid, void **ppv) in audioclient.h, whose reference arrives as a raw IntPtr that no marshaller releases
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetService(ref Guid interfaceId, out IntPtr serviceInterface);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=E6F0E2
// Broiler-Falsified-If: its vtable is not the IAudioCaptureClient order of audioclient.h, GetBuffer at slot 3 through GetNextPacketSize at slot 5
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("C8ADBD64-E71E-48A0-A4DE-185C395CD317")]
public partial interface IAudioCaptureClient
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=BE96C9
    // Broiler-Falsified-If: is not slot 3 of IAudioCaptureClient, HRESULT GetBuffer(BYTE **ppData, UINT32 *pNumFramesToRead, DWORD *pdwFlags, UINT64 *pu64DevicePosition, UINT64 *pu64QPCPosition) in audioclient.h, whose ppData holds only *pNumFramesToRead times nBlockAlign bytes
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBuffer(out IntPtr data, out uint framesToRead, out AudioClientBufferFlags flags,
        out ulong devicePosition, out ulong qpcPosition);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D3903A
    // Broiler-Falsified-If: is not slot 4 of IAudioCaptureClient, HRESULT ReleaseBuffer(UINT32 NumFramesRead) in audioclient.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int ReleaseBuffer(uint framesRead);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=6EB7A4
    // Broiler-Falsified-If: is not slot 5 of IAudioCaptureClient, HRESULT GetNextPacketSize(UINT32 *pNumFramesInNextPacket) in audioclient.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetNextPacketSize(out uint framesInNextPacket);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=D28A8B
// Broiler-Falsified-If: Activate and GetService never release the native reference their COM call returned once GetOrCreateComObject has taken its own, so each call leaks one COM reference
// Broiler-Human:        PENDING
public static class WasapiExtensions
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=E4FA3E
    // Broiler-Falsified-If: the pointer IMMDevice.Activate returns with S_OK is wrapped by GetOrCreateComObject, which takes its own reference, and is never released, so every call leaks one reference to the activated object
    // Broiler-Human:        PENDING
    public static int Activate<TInterface>(this IMMDevice device, uint classContext, IntPtr activationParams, out TInterface? activatedInterface) where TInterface : class
    {
        Guid iid = typeof(TInterface).GUID;
        int hr = device.Activate(ref iid, classContext, activationParams, out IntPtr ptr);
        if (hr >= 0 && ptr != IntPtr.Zero)
        {
            activatedInterface = ComNative.GetOrCreateComObject<TInterface>(ptr);
        }
        else
        {
            activatedInterface = null;
        }
        return hr;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=1D2EA0
    // Broiler-Falsified-If: the pointer IAudioClient.GetService returns with S_OK is wrapped by GetOrCreateComObject, which takes its own reference, and is never released, so every call leaks one reference to the service object
    // Broiler-Human:        PENDING
    public static int GetService<TInterface>(this IAudioClient client, out TInterface? serviceInterface) where TInterface : class
    {
        Guid iid = typeof(TInterface).GUID;
        int hr = client.GetService(ref iid, out IntPtr ptr);
        if (hr >= 0 && ptr != IntPtr.Zero)
        {
            serviceInterface = ComNative.GetOrCreateComObject<TInterface>(ptr);
        }
        else
        {
            serviceInterface = null;
        }
        return hr;
    }
}
