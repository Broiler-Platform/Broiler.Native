using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows;

public static partial class HwndNative
{
    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool IsWindow(nint hwnd);
}
