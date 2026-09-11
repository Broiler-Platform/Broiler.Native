using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Input;

public static partial class RawInputReaderNative
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInputHeader
    {
        public uint Type;
        public uint Size;
        public IntPtr Device;
        public IntPtr WParam;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RawMouse
    {
        public ushort Flags;
        public ushort ButtonFlags;
        public ushort ButtonData;
        public uint RawButtons;
        public int LastX;
        public int LastY;
        public uint ExtraInformation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RawKeyboard
    {
        public ushort MakeCode;
        public ushort Flags;
        public ushort Reserved;
        public ushort VKey;
        public uint Message;
        public uint ExtraInformation;
    }

    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial uint GetRawInputData(IntPtr rawInput, uint command, IntPtr data, ref uint size, uint headerSize);
    public const uint RidInput = 0x10000003;
    public const uint RimTypeMouse = 0;
    public const uint RimTypeKeyboard = 1;
    public const ushort MouseMoveAbsolute = 0x0001;
}
