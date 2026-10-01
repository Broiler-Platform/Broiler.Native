// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   8
// Annotated:        8/8
// Exempt:           0
// Human-reviewed:   0/8
// IP risk:          Low
// Security risk:    Critical
// Criteria:         8/8
// Resource impact:  5/10 max
// Unverified:       8
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=062529
// Broiler-Falsified-If: CreateSwapChainForHwndProc is not slot 15 of IDXGIFactory2, HRESULT CreateSwapChainForHwnd(IUnknown *pDevice, HWND hWnd, const DXGI_SWAP_CHAIN_DESC1 *pDesc, const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *pFullscreenDesc, IDXGIOutput *pRestrictToOutput, IDXGISwapChain1 **ppSwapChain) in dxgi1_2.h, whose pDesc points at a 48-byte DXGI_SWAP_CHAIN_DESC1
// Broiler-Human:        PENDING
public static class Direct2DSurfaceApi
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=5; Fingerprint=7753C7
    // Broiler-Falsified-If: CreateSwapChainForCompositionProc is not slot 24 of IDXGIFactory2, HRESULT CreateSwapChainForComposition(IUnknown *pDevice, const DXGI_SWAP_CHAIN_DESC1 *pDesc, IDXGIOutput *pRestrictToOutput, IDXGISwapChain1 **ppSwapChain) in dxgi1_2.h, whose pDesc points at a 48-byte DXGI_SWAP_CHAIN_DESC1
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateSwapChainForCompositionProc(IntPtr self, IntPtr device, ref DxgiNative.DXGI_SWAP_CHAIN_DESC1 desc,
        IntPtr restrictToOutput, out IntPtr swapChain);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=25B49B
    // Broiler-Falsified-If: CreateSwapChainForHwndProc is not slot 15 of IDXGIFactory2, HRESULT CreateSwapChainForHwnd(IUnknown *pDevice, HWND hWnd, const DXGI_SWAP_CHAIN_DESC1 *pDesc, const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *pFullscreenDesc, IDXGIOutput *pRestrictToOutput, IDXGISwapChain1 **ppSwapChain) in dxgi1_2.h, whose pDesc points at a 48-byte DXGI_SWAP_CHAIN_DESC1
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateSwapChainForHwndProc(IntPtr self, IntPtr device, IntPtr hwnd, ref DxgiNative.DXGI_SWAP_CHAIN_DESC1 desc,
        IntPtr fullscreenDesc, IntPtr restrictToOutput, out IntPtr swapChain);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=CC68D0
    // Broiler-Falsified-If: GetBufferProc is not slot 9 of IDXGISwapChain, HRESULT GetBuffer(UINT Buffer, REFIID riid, void **ppSurface) in dxgi.h, whose riid is passed as the address of a 16-byte IID
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetBufferProc(IntPtr self, uint buffer, ref Guid riid, out IntPtr surface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=5; Fingerprint=FA3C79
    // Broiler-Falsified-If: ResizeBuffersProc is not slot 13 of IDXGISwapChain, HRESULT ResizeBuffers(UINT BufferCount, UINT Width, UINT Height, DXGI_FORMAT NewFormat, UINT SwapChainFlags) in dxgi.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ResizeBuffersProc(IntPtr self, uint bufferCount, uint width, uint height, DxgiNative.DXGI_FORMAT format, uint flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=3A939B
    // Broiler-Falsified-If: CreateBitmapFromDxgiSurfaceProc is not slot 62 of ID2D1DeviceContext, HRESULT CreateBitmapFromDxgiSurface(IDXGISurface *surface, CONST D2D1_BITMAP_PROPERTIES1 *bitmapProperties, ID2D1Bitmap1 **bitmap) in d2d1_1.h, whose D2D1_BITMAP_PROPERTIES1 is 32 bytes on 64-bit with colorContext at offset 24
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateBitmapFromDxgiSurfaceProc(IntPtr self, IntPtr dxgiSurface, 
        ref D2DNative.D2D1_BITMAP_PROPERTIES1 bitmapProperties, out IntPtr bitmap);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=07F303
    // Broiler-Falsified-If: SetDpiProc is not slot 51 of ID2D1RenderTarget, void SetDpi(FLOAT dpiX, FLOAT dpiY) in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetDpiProc(IntPtr self, float dpiX, float dpiY);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=F5376C
    // Broiler-Falsified-If: PresentProc is not slot 8 of IDXGISwapChain, HRESULT Present(UINT SyncInterval, UINT Flags) in dxgi.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PresentProc(IntPtr self, uint syncInterval, uint flags);
}
