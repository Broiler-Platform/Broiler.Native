using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

public static class Direct2DImageStoreApi
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateBitmapProc(
        IntPtr self,
        D2DNative.D2D1_SIZE_U size,
        IntPtr sourceData,
        uint pitch,
        ref D2DNative.D2D1_BITMAP_PROPERTIES properties,
        out IntPtr bitmap);
}
