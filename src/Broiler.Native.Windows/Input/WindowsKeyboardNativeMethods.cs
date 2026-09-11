using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Input;

public static partial class WindowsKeyboardNativeMethods
{
    [LibraryImport("user32.dll")]
    public static partial short GetKeyState(int virtualKey);
}
