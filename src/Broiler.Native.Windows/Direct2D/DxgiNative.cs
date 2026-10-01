// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   20
// Annotated:        20/20
// Exempt:           27
// Human-reviewed:   0/20
// IP risk:          Low
// Security risk:    Critical
// Criteria:         20/14
// Resource impact:  0/10 max
// Unverified:       20
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

/// <summary>
/// DXGI interface IDs, enums and structures needed to create a swap chain and present frames.
/// Structures use <see cref="StructLayoutAttribute"/> with sequential layout so they
/// can be marshalled blittably.
/// </summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=AC7CA2
// Broiler-Falsified-If: DXGI_FORMAT.B8G8R8A8_UNORM is not 87 or R8G8B8A8_UNORM is not 28 as in dxgiformat.h, so a value naming a wider format such as R16G16B16A16_UNORM (11) makes CreateBitmap read 8 bytes per pixel from a source buffer the caller sized at 4
// Broiler-Human:        PENDING
public static class DxgiNative
{
    // ---- Interface IIDs --------------------------------------------------------------------------

    /// <summary>IID_IDXGIFactory1.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=0DB933
    // Broiler-Falsified-If: the GUID differs from dxgi.h's IID_IDXGIFactory1 770aae78-f26f-4dba-a829-253c83d1b387, so the factory pointer returned for it is not an IDXGIFactory1 and slots 12 and 13 index a different vtable
    // Broiler-Human:        PENDING
    public static readonly Guid IID_IDXGIFactory1 = new("770aae78-f26f-4dba-a829-253c83d1b387");

    /// <summary>IID_IDXGIFactory2 (for CreateSwapChainForHwnd).</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=16EECF
    // Broiler-Falsified-If: the GUID differs from dxgi1_2.h's IID_IDXGIFactory2 50c83a1c-e072-4c48-87b0-3630fa36a6d0, so the factory used at slots 15 and 24 is not an IDXGIFactory2 and ComVtable reads past a shorter vtable
    // Broiler-Human:        PENDING
    public static readonly Guid IID_IDXGIFactory2 = new("50c83a1c-e072-4c48-87b0-3630fa36a6d0");

    /// <summary>IID_IDXGIDevice.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=6002A0
    // Broiler-Falsified-If: the GUID differs from dxgi.h's IID_IDXGIDevice 54ec77fa-1377-44e6-8c32-88fd5f44c84c, so QueryInterface on the D3D11 device yields a pointer that ID2D1Factory1::CreateDevice calls as an IDXGIDevice through the wrong vtable
    // Broiler-Human:        PENDING
    public static readonly Guid IID_IDXGIDevice = new("54ec77fa-1377-44e6-8c32-88fd5f44c84c");

    /// <summary>IID_IDXGISurface.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=992E33
    // Broiler-Falsified-If: the GUID differs from dxgi.h's IID_IDXGISurface cafcb56c-6ac3-4889-bf47-9e23bbd260ec, so GetBuffer hands CreateBitmapFromDxgiSurface a back-buffer pointer that is not an IDXGISurface
    // Broiler-Human:        PENDING
    public static readonly Guid IID_IDXGISurface = new("cafcb56c-6ac3-4889-bf47-9e23bbd260ec");

    /// <summary>IID_IDXGISwapChain1.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=2768F7
    // Broiler-Falsified-If: the GUID differs from dxgi1_2.h's IID_IDXGISwapChain1 790a45f7-0d42-4876-983a-0a55cfe6f4aa, so a QueryInterface for it yields a pointer whose vtable does not match the IDXGISwapChain1 slots called through it
    // Broiler-Human:        PENDING
    public static readonly Guid IID_IDXGISwapChain1 = new("790a45f7-0d42-4876-983a-0a55cfe6f4aa");

    // ---- Vtable slots ----------------------------------------------------------------------------

    /// <summary>IDXGISwapChain::Present.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=144AEE
    // Broiler-Falsified-If: the slot is not 8 (IUnknown 0-2, IDXGIObject 3-6, IDXGIDeviceSubObject::GetDevice 7), so PresentProc's sync interval and flags reach GetDevice or GetBuffer instead of Present
    // Broiler-Human:        PENDING
    public const int VtblPresent = 8;

    /// <summary>IDXGISwapChain::GetBuffer.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=B5CF1C
    // Broiler-Falsified-If: the slot is not 9, the entry after Present in dxgi.h's IDXGISwapChain, so GetBufferProc's riid and out pointer reach Present or SetFullscreenState with a different signature
    // Broiler-Human:        PENDING
    public const int VtblGetBuffer = 9;

    /// <summary>IDXGISwapChain::ResizeBuffers.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=8F3A62
    // Broiler-Falsified-If: the slot is not 13 (after Present, GetBuffer, SetFullscreenState, GetFullscreenState and GetDesc), so ResizeBuffersProc's buffer count reaches ResizeTarget as a DXGI_MODE_DESC pointer
    // Broiler-Human:        PENDING
    public const int VtblResizeBuffers = 13;

    /// <summary>IDXGIFactory2::CreateSwapChainForHwnd.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=8FEC5E
    // Broiler-Falsified-If: the slot is not 15 (IDXGIFactory 7-11, IDXGIFactory1 12-13, IsWindowedStereoEnabled 14), so the HWND and swap-chain descriptor reach CreateSwapChainForCoreWindow or IsWindowedStereoEnabled
    // Broiler-Human:        PENDING
    public const int VtblCreateSwapChainForHwnd = 15;

    /// <summary>IDXGIFactory2::CreateSwapChainForComposition.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=A5208F
    // Broiler-Falsified-If: the slot is not 24, the last IDXGIFactory2 method in dxgi1_2.h, so CreateSwapChainForCompositionProc's arguments reach UnregisterOcclusionStatus or an IDXGIFactory3 method
    // Broiler-Human:        PENDING
    public const int VtblCreateSwapChainForComposition = 24;

    // ---- Enums -----------------------------------------------------------------------------------

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=AE923C
    // Broiler-Falsified-If: B8G8R8A8_UNORM is not 87 or R8G8B8A8_UNORM is not 28 as in dxgiformat.h, so a value naming a wider format such as R16G16B16A16_UNORM (11) makes CreateBitmap read 8 bytes per pixel from a source buffer the caller sized at 4
    // Broiler-Human:        PENDING
    public enum DXGI_FORMAT : uint
    {
        UNKNOWN = 0,
        R8G8B8A8_UNORM = 28,
        B8G8R8A8_UNORM = 87,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=934555
    // Broiler-Falsified-If: FLIP_SEQUENTIAL is not 3 as in dxgi.h, so CreateSwapChainForComposition, which accepts only flip-model effects, returns DXGI_ERROR_INVALID_CALL
    // Broiler-Human:        PENDING
    public enum DXGI_SWAP_EFFECT : uint
    {
        DISCARD = 0,
        SEQUENTIAL = 1,
        FLIP_SEQUENTIAL = 3,
        FLIP_DISCARD = 4,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=62E17F
    // Broiler-Falsified-If: STRETCH is not 0 as in dxgi1_2.h, so CreateSwapChainForComposition, which accepts only DXGI_SCALING_STRETCH, returns DXGI_ERROR_INVALID_CALL
    // Broiler-Human:        PENDING
    public enum DXGI_SCALING : uint
    {
        STRETCH = 0,
        NONE = 1,
        ASPECT_RATIO_STRETCH = 2,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=B7E7AD
    // Broiler-Falsified-If: PREMULTIPLIED is not 1 as in dxgi1_2.h, so a composition swap chain interprets premultiplied pixels as straight alpha and translucent edges composite too dark
    // Broiler-Human:        PENDING
    public enum DXGI_ALPHA_MODE : uint
    {
        UNSPECIFIED = 0,
        PREMULTIPLIED = 1,
        STRAIGHT = 2,
        IGNORE = 3,
    }

    /// <summary>Common DXGI error codes surfaced as HRESULTs.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=FB32A3
    // Broiler-Falsified-If: the value differs from dxgi.h's 0x887A0005, so a Present that returns DXGI_ERROR_DEVICE_REMOVED is not recognised as device loss and the surface keeps drawing to the removed device
    // Broiler-Human:        PENDING
    public const int DXGI_ERROR_DEVICE_REMOVED = unchecked((int)0x887A0005);
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=BED815
    // Broiler-Falsified-If: the value differs from dxgi.h's 0x887A0007, so a DXGI_ERROR_DEVICE_RESET result is not recognised as device loss and the device is never recreated
    // Broiler-Human:        PENDING
    public const int DXGI_ERROR_DEVICE_RESET = unchecked((int)0x887A0007);

    /// <summary>Swap-chain buffer usage flag used for render-target back buffers.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=7A0151
    // Broiler-Falsified-If: the value differs from dxgi.h's 0x20 (1 shifted left by 1 + 4), so the back buffer cannot be bound as a Direct2D target and CreateBitmapFromDxgiSurface fails
    // Broiler-Human:        PENDING
    public const uint DXGI_USAGE_RENDER_TARGET_OUTPUT = 0x00000020;

    // ---- Structures ------------------------------------------------------------------------------

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=A550C9
    // Broiler-Falsified-If: Count and Quality are in the opposite order to dxgicommon.h, so a descriptor asking for Count 1 and Quality 0 reaches DXGI as Count 0 and swap-chain creation fails
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_SAMPLE_DESC
    {
        public uint Count;
        public uint Quality;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=DBD1C7
    // Broiler-Falsified-If: Marshal.SizeOf is not 48 or Stereo is not a 4-byte BOOL, so CreateSwapChainForHwnd reads SampleDesc and the later fields at shifted offsets
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_SWAP_CHAIN_DESC1
    {
        public uint Width;
        public uint Height;
        public DXGI_FORMAT Format;
        public int Stereo; // BOOL
        public DXGI_SAMPLE_DESC SampleDesc;
        public uint BufferUsage;
        public uint BufferCount;
        public DXGI_SCALING Scaling;
        public DXGI_SWAP_EFFECT SwapEffect;
        public DXGI_ALPHA_MODE AlphaMode;
        public uint Flags;
    }
}
