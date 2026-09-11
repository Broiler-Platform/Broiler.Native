using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Input;

public static partial class WindowsMouseNativeMethods
{
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ScreenToClient(IntPtr hwnd, ref POINT point);

    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool TrackMouseEvent(ref TRACKMOUSEEVENT eventTrack);

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TRACKMOUSEEVENT
    {
        public uint CbSize;
        public uint Flags;
        public IntPtr HwndTrack;
        public uint HoverTime;
    }
}
