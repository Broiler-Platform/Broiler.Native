using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Input;

public static partial class RawInputRegistrationNative
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInputDevice
    {
        public ushort UsagePage;
        public ushort Usage;
        public uint Flags;
        public IntPtr TargetWindow;
    }

    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool RegisterRawInputDevices([In] RawInputDevice[] rawInputDevices, uint deviceCount, uint rawInputDeviceSize);
    public const ushort GenericDesktopUsagePage = 0x01;
    public const ushort MouseUsage = 0x02;
    public const ushort KeyboardUsage = 0x06;
    public const uint RidevRemove = 0x00000001;
    public const uint RidevNoLegacy = 0x00000030;
    public const uint RidevInputSink = 0x00000100;
    public const uint RidevDevNotify = 0x00002000;
}
