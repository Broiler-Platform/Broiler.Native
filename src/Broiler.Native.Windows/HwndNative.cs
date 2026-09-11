using System.Runtime.InteropServices;

namespace Broiler.Native.Windows;

public static partial class HwndNative
{
    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsWindow(nint hwnd);
}
