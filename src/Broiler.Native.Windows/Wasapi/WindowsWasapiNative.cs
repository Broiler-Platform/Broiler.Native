// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   76
// Annotated:        76/76
// Exempt:           38
// Human-reviewed:   0/76
// IP risk:          Low
// Security risk:    Critical
// Criteria:         76/76
// Resource impact:  5/10 max
// Unverified:       76
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
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=598F31
    // Broiler-Falsified-If: the value is not AUDCLNT_ERR(0x004) = 0x88890004 from audioclient.h, so a removed capture endpoint is reported as a generic failure rather than an invalidated device
    // Broiler-Human:        PENDING
    public const int AUDCLNT_E_DEVICE_INVALIDATED = unchecked((int)0x88890004);
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=9E74FF
    // Broiler-Falsified-If: the value is not AUDCLNT_ERR(0x008) = 0x88890008 from audioclient.h, so an Initialize rejected for its format is not recognised as an unsupported format
    // Broiler-Human:        PENDING
    public const int AUDCLNT_E_UNSUPPORTED_FORMAT = unchecked((int)0x88890008);
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=92F951
    // Broiler-Falsified-If: the value is not AUDCLNT_ERR(0x00A) = 0x8889000A from audioclient.h, so an endpoint held in exclusive mode by another process is not reported as busy
    // Broiler-Human:        PENDING
    public const int AUDCLNT_E_DEVICE_IN_USE = unchecked((int)0x8889000A);
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=AACA56
    // Broiler-Falsified-If: the value is not AUDCLNT_ERR(0x010) = 0x88890010 from audioclient.h, so a stopped Windows Audio service is not recognised as the audio host being unavailable
    // Broiler-Human:        PENDING
    public const int AUDCLNT_E_SERVICE_NOT_RUNNING = unchecked((int)0x88890010);

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=65462B
    // Broiler-Falsified-If: the value is not 0 as in winbase.h, so a capture event that WaitForSingleObject reports as signalled is not recognised as signalled
    // Broiler-Human:        PENDING
    public const uint WAIT_OBJECT_0 = 0;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E2DDDC
    // Broiler-Falsified-If: the value is not 258 (0x102) as in winerror.h, so a wait that timed out is treated as a signalled event and the capture client is drained with no packet ready
    // Broiler-Human:        PENDING
    public const uint WAIT_TIMEOUT = 258;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=EE48F5
    // Broiler-Falsified-If: the value is not 0xFFFFFFFF as in winbase.h, so a failed wait on a closed or invalid event handle is treated as a signal and the capture loop spins instead of stopping
    // Broiler-Human:        PENDING
    public const uint WAIT_FAILED = 0xFFFFFFFF;

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=4E9396
    // Broiler-Falsified-If: the GUID differs from CLSID_MMDeviceEnumerator BCDE0395-E52F-467C-8E3D-C4579291692E in mmdeviceapi.h, so CoCreateInstance activates another class or fails with REGDB_E_CLASSNOTREG
    // Broiler-Human:        PENDING
    public static readonly Guid MMDeviceEnumeratorClassId = new("BCDE0395-E52F-467C-8E3D-C4579291692E");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=019EC1
    // Broiler-Falsified-If: the GUID differs from IID_IMMDeviceEnumerator A95664D2-9614-4F35-A746-DE8DB63617E6 in mmdeviceapi.h, so a raw pointer created with it is called through the IMMDeviceEnumerator vtable while pointing at another interface
    // Broiler-Human:        PENDING
    public static readonly Guid IMMDeviceEnumeratorId = new("A95664D2-9614-4F35-A746-DE8DB63617E6");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=C9CFEC
    // Broiler-Falsified-If: the GUID differs from IID_IAudioClient 1CB9AD4C-DBFA-4C32-B178-C2F568A703B2 in audioclient.h, so IMMDevice.Activate returns a pointer to another interface that is then called through the IAudioClient vtable
    // Broiler-Human:        PENDING
    public static readonly Guid IAudioClientId = new("1CB9AD4C-DBFA-4c32-B178-C2F568A703B2");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=BA49A8
    // Broiler-Falsified-If: the GUID differs from IID_IAudioCaptureClient C8ADBD64-E71E-48A0-A4DE-185C395CD317 in audioclient.h, so IAudioClient.GetService returns E_NOINTERFACE or a pointer to another interface instead of the capture client
    // Broiler-Human:        PENDING
    public static readonly Guid IAudioCaptureClientId = new("C8ADBD64-E71E-48a0-A4DE-185C395CD317");

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=1F686C
    // Broiler-Falsified-If: the GUID differs from KSDATAFORMAT_SUBTYPE_PCM 00000001-0000-0010-8000-00AA00389B71 in ksmedia.h, so an integer PCM mix format in WAVE_FORMAT_EXTENSIBLE is classified as an unknown sample format
    // Broiler-Human:        PENDING
    public static readonly Guid PcmSubFormat = new("00000001-0000-0010-8000-00aa00389b71");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=8B74E7
    // Broiler-Falsified-If: the GUID differs from KSDATAFORMAT_SUBTYPE_IEEE_FLOAT 00000003-0000-0010-8000-00AA00389B71 in ksmedia.h, so a WAVE_FORMAT_EXTENSIBLE float mix format is not recognised as 32-bit float samples
    // Broiler-Human:        PENDING
    public static readonly Guid IeeeFloatSubFormat = new("00000003-0000-0010-8000-00aa00389b71");

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=72B3B6
    // Broiler-Falsified-If: on x64 ole32 PropVariantClear zeroes a 24-byte PROPVARIANT through a pointer to the 16-byte managed PropVariant, overwriting the 8 bytes after a stack local
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial int PropVariantClear(ref PropVariant value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=7EA6F8
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

// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=6C0BBA
// Broiler-Falsified-If: Render, Capture and All are not 0, 1 and 2 as in mmdeviceapi.h EDataFlow, so a Capture enumeration or default-endpoint lookup returns render endpoints
// Broiler-Human:        PENDING
public enum EDataFlow
{
    Render = 0,
    Capture = 1,
    All = 2,
}

// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=502AAE
// Broiler-Falsified-If: Console, Multimedia and Communications are not 0, 1 and 2 as in mmdeviceapi.h ERole, so GetDefaultAudioEndpoint returns the default endpoint for a different role
// Broiler-Human:        PENDING
public enum ERole
{
    Console = 0,
    Multimedia = 1,
    Communications = 2,
}

// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=406EC2
// Broiler-Falsified-If: a flag differs from DEVICE_STATE_ACTIVE 0x1, DISABLED 0x2, NOTPRESENT 0x4 or UNPLUGGED 0x8 in mmdeviceapi.h, so an Active state mask also enumerates unplugged or disabled endpoints
// Broiler-Human:        PENDING
[Flags]
public enum DeviceState : uint
{
    Active = 0x00000001,
    Disabled = 0x00000002,
    NotPresent = 0x00000004,
    Unplugged = 0x00000008,
    All = 0x0000000F,
}

// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=6BC679
// Broiler-Falsified-If: Read is not STGM_READ (0), so OpenPropertyStore asks for write access to the endpoint property store and fails with E_ACCESSDENIED in a non-elevated process
// Broiler-Human:        PENDING
public enum StorageAccess
{
    Read = 0,
}

// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=AACE47
// Broiler-Falsified-If: Shared and Exclusive are not 0 and 1 as in audiosessiontypes.h AUDCLNT_SHAREMODE, so Initialize requests exclusive mode and takes the endpoint from other applications
// Broiler-Human:        PENDING
public enum AudioClientShareMode
{
    Shared = 0,
    Exclusive = 1,
}

// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=8FB445
// Broiler-Falsified-If: EventCallback is not AUDCLNT_STREAMFLAGS_EVENTCALLBACK 0x00040000 from audiosessiontypes.h, so Initialize does not enable event-driven buffering and SetEventHandle fails
// Broiler-Human:        PENDING
[Flags]
public enum AudioClientStreamFlags : uint
{
    None = 0,
    EventCallback = 0x00040000,
}

// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=56809F
// Broiler-Falsified-If: Silent is not AUDCLNT_BUFFERFLAGS_SILENT 0x2 from audioclient.h, so a packet the audio engine marks as silence is copied and delivered as captured audio
// Broiler-Human:        PENDING
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
    // Broiler-Falsified-If: a call made from inside an IMMNotificationClient callback blocks the audio service's notification thread that is running that callback
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
    // Broiler-Falsified-If: an index equal to the GetCount result returns E_INVALIDARG with a null device, and a caller that ignores the PreserveSig HRESULT dereferences that device
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Item(uint itemIndex, out IMMDevice device);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=37CE13
// Broiler-Falsified-If: Activate is handed a non-null activationParams pointer to fewer than the 24 bytes of a PROPVARIANT on x64, so the audio service reads past the caller's buffer
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("D666063F-1587-4E43-81F1-B948E807363F")]
public partial interface IMMDevice
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=86ECE4
    // Broiler-Falsified-If: a non-null activationParams pointing at the 16-byte managed PropVariant makes the audio service read a 24-byte PROPVARIANT past its end on x64
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Activate(ref Guid interfaceId, uint classContext, IntPtr activationParams, out IntPtr activatedInterface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=4D668C
    // Broiler-Falsified-If: access is not passed as the 4-byte DWORD stgmAccess of mmdeviceapi.h, so the store is opened with an access mode taken from undefined upper bits
    // Broiler-Human:        PENDING
    [PreserveSig]
    int OpenPropertyStore(StorageAccess access, out IPropertyStore properties);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=A54561
    // Broiler-Falsified-If: the LPWSTR it returns is released with anything other than CoTaskMemFree, so every endpoint-id lookup leaks the string or frees it on the wrong heap
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
    // Broiler-Falsified-If: an index equal to the GetCount result returns a failing HRESULT with a zeroed PropertyKey, and a caller that ignores the PreserveSig HRESULT passes that key to GetValue
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
    // Broiler-Falsified-If: Commit on a store opened with StorageAccess.Read returns STG_E_ACCESSDENIED, and a caller that ignores the PreserveSig HRESULT assumes the change persisted
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
// Broiler-Falsified-If: Initialize is given a format pointer whose cbSize claims more trailing bytes than the block holds, so the audio engine reads past the caller's WAVEFORMATEX
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("1CB9AD4C-DBFA-4C32-B178-C2F568A703B2")]
public partial interface IAudioClient
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=8F9E64
    // Broiler-Falsified-If: a format pointer to a WAVEFORMATEX whose cbSize exceeds the bytes allocated after its 18-byte header makes the audio engine read past the caller's block
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
    // Broiler-Falsified-If: a format pointer to a WAVEFORMATEX whose cbSize exceeds the bytes allocated after its 18-byte header makes the audio engine read past the caller's block
    // Broiler-Human:        PENDING
    [PreserveSig]
    int IsFormatSupported(AudioClientShareMode shareMode, IntPtr format, out IntPtr closestMatch);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=EB4C3A
    // Broiler-Falsified-If: the WAVEFORMATEX block it returns is released with anything other than CoTaskMemFree, so each capture start leaks the mix format or frees it on the wrong heap
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
    // Broiler-Falsified-If: the event handle is closed with CloseHandle while the stream is still running, so the audio engine signals a handle value that may already name another kernel object
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetEventHandle(IntPtr eventHandle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=DCDAC0
    // Broiler-Falsified-If: the serviceInterface pointer returned with S_OK carries a reference the caller never releases, so each capture-client lookup leaks the service object
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetService(ref Guid interfaceId, out IntPtr serviceInterface);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=E6F0E2
// Broiler-Falsified-If: the packet GetBuffer returns is read for more than framesToRead frames of the mix format's nBlockAlign, past the end of the buffer the audio engine lent
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("C8ADBD64-E71E-48A0-A4DE-185C395CD317")]
public partial interface IAudioCaptureClient
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=BE96C9
    // Broiler-Falsified-If: data is read beyond framesToRead times the mix format's nBlockAlign bytes, or after ReleaseBuffer, so the copy runs past the packet the audio engine lent
    // Broiler-Human:        PENDING
    [PreserveSig]
    int GetBuffer(out IntPtr data, out uint framesToRead, out AudioClientBufferFlags flags,
        out ulong devicePosition, out ulong qpcPosition);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D3903A
    // Broiler-Falsified-If: framesRead differs from both 0 and the framesToRead GetBuffer returned, so the engine returns AUDCLNT_E_INVALID_SIZE and the next GetBuffer fails with AUDCLNT_E_OUT_OF_ORDER
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
