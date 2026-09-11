using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

public static class Direct2DDeviceApi
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateD2DDeviceProc(IntPtr self, IntPtr dxgiDevice, out IntPtr d2dDevice);
}
