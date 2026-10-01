// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   56
// Annotated:        56/56
// Exempt:           58
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
// Broiler-Falsified-If: PropVariantClear is handed the 16-byte managed PropVariant on x64 while ole32 clears a 24-byte PROPVARIANT, overwriting the 8 bytes that follow it
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
    // Broiler-Falsified-If: on x64 ole32 PropVariantClear zeroes a 24-byte PROPVARIANT through a pointer to the 16-byte managed PropVariant, overwriting the 8 bytes after a stack local
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial int PropVariantClear(ref PropVariant value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=7EA6F8
    // Broiler-Falsified-If: a NULL return leaves Marshal.GetLastWin32Error reporting a code from an earlier call because the stub does not capture the last error after CreateEventW
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    public static partial IntPtr CreateEventW(IntPtr eventAttributes, [MarshalAs(UnmanagedType.Bool)] bool manualReset,
        [MarshalAs(UnmanagedType.Bool)] bool initialState, string? name);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E6D39B
    // Broiler-Falsified-If: the BOOL result is read as a 1-byte bool instead of a 4-byte BOOL, so a failed SetEvent on a closed handle reports success and a blocked capture wait is never interrupted
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SetEvent(IntPtr handle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0F7F8E
    // Broiler-Falsified-If: the BOOL result is read as a 1-byte bool instead of a 4-byte BOOL, so closing an event handle that was already closed reports success and the double close goes unnoticed
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool CloseHandle(IntPtr handle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=75FDEC
    // Broiler-Falsified-If: a WAIT_FAILED return on a closed handle leaves Marshal.GetLastWin32Error reporting a code from an earlier call because the stub does not capture the last error
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
// Broiler-Falsified-If: the layout is not a 16-byte GUID followed by a 4-byte DWORD (20 bytes, no padding) as in wtypes.h PROPERTYKEY, so GetAt and GetValue read or write the property id at the wrong offset
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct PropertyKey(Guid formatId, uint propertyId)
{
    public Guid FormatId = formatId;

    public uint PropertyId = propertyId;
}

// Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=6295F8
// Broiler-Falsified-If: Marshal.SizeOf of PropVariant is 16 on x64 while the native PROPVARIANT of propidl.h is 24, so IPropertyStore.GetValue and PropVariantClear write 8 bytes past the managed value
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct PropVariant
{
    public ushort ValueType;
    private ushort _reserved1;
    private ushort _reserved2;
    private ushort _reserved3;
    public IntPtr PointerValue;
}

// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=6A0461
// Broiler-Falsified-If: the layout is not the 18-byte, byte-packed WAVEFORMATEX of mmreg.h (nSamplesPerSec at offset 4, cbSize at offset 16), so the mix format read from GetMixFormat yields the wrong sample rate or cbSize
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
// Broiler-Falsified-If: the layout is not the 40-byte WAVEFORMATEXTENSIBLE of mmreg.h (Samples at 18, dwChannelMask at 20, SubFormat at 24), so the sub-format GUID is taken from the wrong bytes of a mix-format block
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
// Broiler-Falsified-If: the members are not in mmdeviceapi.h vtable order (EnumAudioEndpoints, GetDefaultAudioEndpoint, GetDevice, RegisterEndpointNotificationCallback, UnregisterEndpointNotificationCallback) after IUnknown, so a call lands in another method's slot
// Broiler-Human:        PENDING
[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("A95664D2-9614-4F35-A746-DE8DB63617E6")]
public partial interface IMMDeviceEnumerator
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=B02A40
    // Broiler-Falsified-If: dataFlow and stateMask are not passed as the 4-byte EDataFlow and DWORD of mmdeviceapi.h, so a capture-only Active enumeration returns render or disabled endpoints
    // Broiler-Human:        PENDING
    [PreserveSig]
    int EnumAudioEndpoints(EDataFlow dataFlow, DeviceState stateMask, out IMMDeviceCollection devices);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=2C427E
    // Broiler-Falsified-If: dataFlow and role are not passed as the 4-byte EDataFlow and ERole of mmdeviceapi.h, so the default capture endpoint is resolved for another role or data flow
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, out IMMDevice endpoint);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B582C9
    // Broiler-Falsified-If: id is marshalled as anything other than a NUL-terminated UTF-16 LPCWSTR, so an endpoint id returned by IMMDevice.GetId does not round-trip and GetDevice returns E_NOTFOUND
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetDevice(string id, out IMMDevice device);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=5ECB61
    // Broiler-Falsified-If: client is not passed as an interface pointer for IID 7991EEC9-7E89-4D85-8390-6C703CEC60C0, so the audio service calls OnDeviceStateChanged through the vtable of another interface
    // Broiler-Human:        PENDING
    [PreserveSig]
    int RegisterEndpointNotificationCallback(IMMNotificationClient client);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=81112A
    // Broiler-Falsified-If: UnregisterEndpointNotificationCallback is not the fifth method after IUnknown, directly after RegisterEndpointNotificationCallback, so an unregister request registers the client again and its callbacks keep arriving after the owner is gone
    // Broiler-Human:        PENDING
    [PreserveSig]
    int UnregisterEndpointNotificationCallback(IMMNotificationClient client);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=6ACDC0
// Broiler-Falsified-If: GetCount and Item are not the first two slots after IUnknown as in mmdeviceapi.h, so an Item call runs GetCount and a device pointer is written into a uint
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("0BD7A1BE-7A1A-44DB-8397-CC5392387B5E")]
public partial interface IMMDeviceCollection
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=9DEF9C
    // Broiler-Falsified-If: count is written through a pointer to anything other than a 4-byte UINT, so an Item loop bounded by it reads part of its bound from the adjacent stack slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCount(out uint count);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=A3EAF2
    // Broiler-Falsified-If: itemIndex and the device out reach IMMDeviceCollection::Item(UINT, IMMDevice**) in swapped positions, so the device pointer is written through the index value as an address
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Item(uint itemIndex, out IMMDevice device);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=37CE13
// Broiler-Falsified-If: a member is out of mmdeviceapi.h order (Activate, OpenPropertyStore, GetId, GetState after IUnknown), so GetId's string-pointer out or Activate's parameter pointer reaches a method that reads or writes it with another size
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("D666063F-1587-4E43-81F1-B948E807363F")]
public partial interface IMMDevice
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=86ECE4
    // Broiler-Falsified-If: activationParams and the out pointer reach IMMDevice::Activate(REFIID, DWORD, PROPVARIANT*, void**) in swapped positions, so the activated interface is written through the activation-parameter pointer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Activate(ref Guid interfaceId, uint classContext, IntPtr activationParams, out IntPtr activatedInterface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=4D668C
    // Broiler-Falsified-If: access is not passed as the 4-byte DWORD stgmAccess of mmdeviceapi.h, so the store is opened with an access mode taken from undefined upper bits
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OpenPropertyStore(StorageAccess access, out IPropertyStore properties);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=A54561
    // Broiler-Falsified-If: GetId is not vtable slot 5, after OpenPropertyStore, so an id query reaches GetState and a 4-byte state is written into the 8-byte string-pointer out the caller then dereferences
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetId(out IntPtr id);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2C18EF
    // Broiler-Falsified-If: state is written through a pointer to anything other than a 4-byte DWORD, so an unplugged endpoint can read as Active
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetState(out DeviceState state);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=079EE3
// Broiler-Falsified-If: GetValue writes a 24-byte PROPVARIANT on x64 into the 16-byte managed PropVariant it is given, corrupting the 8 bytes after it
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99")]
public partial interface IPropertyStore
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=39889B
    // Broiler-Falsified-If: propertyCount is written through a pointer to anything other than a 4-byte DWORD, so a GetAt loop bounded by it asks for indexes past the end of the store
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCount(out uint propertyCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=53B7D0
    // Broiler-Falsified-If: GetAt is not vtable slot 4, directly after GetCount, so an index lookup reaches GetValue and native code writes a PROPVARIANT through the 20-byte PROPERTYKEY out
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetAt(uint propertyIndex, out PropertyKey key);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=2E7085
    // Broiler-Falsified-If: on x64 the property store writes a 24-byte PROPVARIANT through the pointer to the 16-byte managed PropVariant, overwriting the 8 bytes after a stack local such as GetFriendlyName's value
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetValue(ref PropertyKey key, out PropVariant value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=7DEB4C
    // Broiler-Falsified-If: on x64 the property store reads a 24-byte PROPVARIANT from the 16-byte managed PropVariant, taking the 8 bytes after the struct as part of the value
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetValue(ref PropertyKey key, ref PropVariant value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=8609BA
    // Broiler-Falsified-If: Commit is not vtable slot 7, the last IPropertyStore method, so a commit request reaches SetValue and native code dereferences unset key and value pointers
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Commit();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=2B52F8
// Broiler-Falsified-If: an implementation blocks, or calls Register or UnregisterEndpointNotificationCallback, inside a callback that runs on the audio service's notification thread and deadlocks it
// Broiler-Human:        PENDING
[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("7991EEC9-7E89-4D85-8390-6C703CEC60C0")]
public partial interface IMMNotificationClient
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=96A9AC
    // Broiler-Falsified-If: deviceId is not unmarshalled as a NUL-terminated UTF-16 LPCWSTR, so the endpoint id given to the implementation does not match the one IMMDevice.GetId returns
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OnDeviceStateChanged(string deviceId, DeviceState newState);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4EA116
    // Broiler-Falsified-If: deviceId is not unmarshalled as a NUL-terminated UTF-16 LPCWSTR, so the id of an added endpoint does not match the one GetDevice accepts
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OnDeviceAdded(string deviceId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=A1017B
    // Broiler-Falsified-If: deviceId is not unmarshalled as a NUL-terminated UTF-16 LPCWSTR, so a removed endpoint is not matched to the capture session that is using it
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OnDeviceRemoved(string deviceId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=5AFB15
    // Broiler-Falsified-If: defaultDeviceId arrives as null when no default endpoint remains for the flow and role, and an implementation that dereferences it throws on the notification thread
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OnDefaultDeviceChanged(EDataFlow flow, ERole role, string defaultDeviceId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=DEBD93
    // Broiler-Falsified-If: key is read with an argument convention other than the by-value 20-byte PROPERTYKEY of mmdeviceapi.h, so the implementation receives a format id and property id the audio service did not send
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OnPropertyValueChanged(string deviceId, PropertyKey key);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=85032C
// Broiler-Falsified-If: a member is out of audioclient.h order, so Initialize's format pointer or GetMixFormat's out pointer reaches another method that reads or writes it with a different size
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("1CB9AD4C-DBFA-4C32-B178-C2F568A703B2")]
public partial interface IAudioClient
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=8F9E64
    // Broiler-Falsified-If: format and audioSessionGuid reach IAudioClient::Initialize in swapped positions, so the engine reads the WAVEFORMATEX through the session GUID pointer, or through null when no session is given
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Initialize(AudioClientShareMode shareMode, AudioClientStreamFlags streamFlags, long bufferDuration,
        long periodicity, IntPtr format, IntPtr audioSessionGuid);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7407DC
    // Broiler-Falsified-If: bufferFrameCount is written through a pointer to anything other than a 4-byte UINT32, so a buffer sized from it is smaller than the endpoint buffer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBufferSize(out uint bufferFrameCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=FEE5D6
    // Broiler-Falsified-If: latency is written through a pointer to anything other than an 8-byte REFERENCE_TIME, so half of the reported latency comes from the adjacent stack slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetStreamLatency(out long latency);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B5581D
    // Broiler-Falsified-If: currentPaddingFrameCount is written through a pointer to anything other than a 4-byte UINT32, so the frames already queued in the endpoint buffer are misread
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetCurrentPadding(out uint currentPaddingFrameCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=9D437E
    // Broiler-Falsified-If: format and the closestMatch out reach IAudioClient::IsFormatSupported in swapped positions, so the engine reads the WAVEFORMATEX from the caller's out slot
    // Broiler-Human:        PENDING
    [PreserveSig]
    int IsFormatSupported(AudioClientShareMode shareMode, IntPtr format, out IntPtr closestMatch);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=EB4C3A
    // Broiler-Falsified-If: GetMixFormat is not vtable slot 8, directly after IsFormatSupported, so the query reaches GetDevicePeriod and an 8-byte period is written where the caller expects a WAVEFORMATEX pointer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetMixFormat(out IntPtr deviceFormat);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C6E8C9
    // Broiler-Falsified-If: the two REFERENCE_TIME outputs are not in audioclient.h order (default period, then minimum period), so a client takes the minimum period for the default
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetDevicePeriod(out long defaultDevicePeriod, out long minimumDevicePeriod);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=6B8586
    // Broiler-Falsified-If: Start is not the eighth method after IUnknown as in audioclient.h, so a request to start capture runs GetDevicePeriod or Stop instead
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Start();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=458393
    // Broiler-Falsified-If: Stop is not the ninth method after IUnknown as in audioclient.h, so a request to stop capture runs Start or Reset and the stream keeps running
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Stop();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=C17181
    // Broiler-Falsified-If: Reset is not the tenth method after IUnknown as in audioclient.h, so a reset runs another method and the queued packets are not flushed
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Reset();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A5695E
    // Broiler-Falsified-If: SetEventHandle is not vtable slot 13, after Reset, so the event handle reaches GetService as its IID pointer and the engine never signals it
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetEventHandle(IntPtr eventHandle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=DCDAC0
    // Broiler-Falsified-If: interfaceId and the out pointer reach IAudioClient::GetService(REFIID, void**) in swapped positions, so the service pointer is written over the caller's IID
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetService(ref Guid interfaceId, out IntPtr serviceInterface);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=E6F0E2
// Broiler-Falsified-If: GetBuffer, ReleaseBuffer and GetNextPacketSize are not the first three slots after IUnknown as in audioclient.h, so the packet pointer and frame count are read from outputs another method never wrote
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("C8ADBD64-E71E-48A0-A4DE-185C395CD317")]
public partial interface IAudioCaptureClient
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=BE96C9
    // Broiler-Falsified-If: data and framesToRead reach IAudioCaptureClient::GetBuffer(BYTE**, UINT32*, DWORD*, UINT64*, UINT64*) in swapped positions, so the frame count that sizes the caller's copy is read from the packet pointer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBuffer(out IntPtr data, out uint framesToRead, out AudioClientBufferFlags flags,
        out ulong devicePosition, out ulong qpcPosition);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D3903A
    // Broiler-Falsified-If: ReleaseBuffer is not vtable slot 4, directly after GetBuffer, so a release reaches GetNextPacketSize and the engine writes a frame count through the framesRead value as an address
    // Broiler-Human:        PENDING
    [PreserveSig]
    int ReleaseBuffer(uint framesRead);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=6EB7A4
    // Broiler-Falsified-If: framesInNextPacket is written through a pointer to anything other than a 4-byte UINT32, so a drain loop that stops at zero never sees zero and spins
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
