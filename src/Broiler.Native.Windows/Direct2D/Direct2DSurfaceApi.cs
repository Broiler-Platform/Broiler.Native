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
// Broiler-Falsified-If: CreateSwapChainForHwndProc passes the DXGI_SWAP_CHAIN_DESC1 pointer and fullscreenDesc to IDXGIFactory2::CreateSwapChainForHwnd in swapped positions, so DXGI reads the fullscreen description from the 48-byte swap-chain descriptor and dereferences null as the descriptor
// Broiler-Human:        PENDING
public static class Direct2DSurfaceApi
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=5; Fingerprint=7753C7
    // Broiler-Falsified-If: desc is not passed as a pointer to the 48-byte DXGI_SWAP_CHAIN_DESC1, so DXGI allocates swap-chain buffers from misread width, height or buffer count
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateSwapChainForCompositionProc(IntPtr self, IntPtr device, ref DxgiNative.DXGI_SWAP_CHAIN_DESC1 desc,
        IntPtr restrictToOutput, out IntPtr swapChain);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=25B49B
    // Broiler-Falsified-If: the DXGI_SWAP_CHAIN_DESC1 pointer and fullscreenDesc reach IDXGIFactory2::CreateSwapChainForHwnd in swapped positions, so DXGI reads the fullscreen description from the 48-byte swap-chain descriptor and dereferences null as the descriptor
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateSwapChainForHwndProc(IntPtr self, IntPtr device, IntPtr hwnd, ref DxgiNative.DXGI_SWAP_CHAIN_DESC1 desc,
        IntPtr fullscreenDesc, IntPtr restrictToOutput, out IntPtr swapChain);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=CC68D0
    // Broiler-Falsified-If: buffer and riid reach IDXGISwapChain::GetBuffer(UINT, REFIID, void**) in swapped positions, so the back-buffer index is dereferenced as the IID pointer
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetBufferProc(IntPtr self, uint buffer, ref Guid riid, out IntPtr surface);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=5; Fingerprint=FA3C79
    // Broiler-Falsified-If: bufferCount, width, height, format and flags reach IDXGISwapChain::ResizeBuffers out of that order, so a resize to 1280 by 720 leaves back buffers whose description reports another size
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ResizeBuffersProc(IntPtr self, uint bufferCount, uint width, uint height, DxgiNative.DXGI_FORMAT format, uint flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=3A939B
    // Broiler-Falsified-If: the ColorContext field of bitmapProperties does not land at offset 24 on x64 after four padding bytes, so Direct2D dereferences padding as an ID2D1ColorContext
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateBitmapFromDxgiSurfaceProc(IntPtr self, IntPtr dxgiSurface, 
        ref D2DNative.D2D1_BITMAP_PROPERTIES1 bitmapProperties, out IntPtr bitmap);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=07F303
    // Broiler-Falsified-If: dpiX and dpiY are not marshalled as 32-bit floats, so SetDpi scales every later draw by values reinterpreted from other bits
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetDpiProc(IntPtr self, float dpiX, float dpiY);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=F5376C
    // Broiler-Falsified-If: syncInterval and flags reach IDXGISwapChain::Present(UINT SyncInterval, UINT Flags) in swapped positions, so Present(1, 0) is issued as Present(0, DXGI_PRESENT_TEST) and no frame reaches the window
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PresentProc(IntPtr self, uint syncInterval, uint flags);
}
