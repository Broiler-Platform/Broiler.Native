using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

public static class Direct2DOffscreenSurfaceApi
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateDeviceContextProc(
        IntPtr self,
        D2DNative.D2D1_DEVICE_CONTEXT_OPTIONS options,
        out IntPtr deviceContext);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateBitmap1Proc(
        IntPtr self,
        D2DNative.D2D1_SIZE_U size,
        IntPtr sourceData,
        uint pitch,
        ref D2DNative.D2D1_BITMAP_PROPERTIES1 bitmapProperties,
        out IntPtr bitmap);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CopyFromBitmapProc(
        IntPtr self,
        IntPtr destinationPoint,
        IntPtr bitmap,
        IntPtr sourceRect);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int MapProc(
        IntPtr self,
        D2DNative.D2D1_MAP_OPTIONS options,
        out D2DNative.D2D1_MAPPED_RECT mappedRect);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int UnmapProc(IntPtr self);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetTargetProc(IntPtr self, IntPtr image);
}
