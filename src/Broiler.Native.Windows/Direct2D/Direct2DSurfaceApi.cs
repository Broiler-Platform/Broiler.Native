using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

public static class Direct2DSurfaceApi
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateSwapChainForCompositionProc(IntPtr self, IntPtr device, ref DxgiNative.DXGI_SWAP_CHAIN_DESC1 desc,
        IntPtr restrictToOutput, out IntPtr swapChain);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateSwapChainForHwndProc(IntPtr self, IntPtr device, IntPtr hwnd, ref DxgiNative.DXGI_SWAP_CHAIN_DESC1 desc,
        IntPtr fullscreenDesc, IntPtr restrictToOutput, out IntPtr swapChain);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetBufferProc(IntPtr self, uint buffer, ref Guid riid, out IntPtr surface);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ResizeBuffersProc(IntPtr self, uint bufferCount, uint width, uint height, DxgiNative.DXGI_FORMAT format, uint flags);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateBitmapFromDxgiSurfaceProc(IntPtr self, IntPtr dxgiSurface, 
        ref D2DNative.D2D1_BITMAP_PROPERTIES1 bitmapProperties, out IntPtr bitmap);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetDpiProc(IntPtr self, float dpiX, float dpiY);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PresentProc(IntPtr self, uint syncInterval, uint flags);
}
