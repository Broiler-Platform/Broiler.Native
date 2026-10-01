// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   13
// Annotated:        13/13
// Exempt:           118
// Human-reviewed:   0/13
// IP risk:          Low
// Security risk:    Critical
// Criteria:         13/13
// Resource impact:  2/10 max
// Unverified:       13
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

/// <summary>
/// Direct2D interface IDs, enums and value structures.
/// The structures mirror the native D2D1 layout so they can be passed blittably to COM methods once
/// the vtable call sites are filled in.
/// </summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=5336C0
// Broiler-Falsified-If: a structure here is not laid out as in d2d1.h and d2d1_1.h, for example D2D1_MAPPED_RECT without Bits at offset 8 on x64, so the readback after Map copies Pitch times height bytes from a pointer that is not the mapped bitmap
// Broiler-Human:        PENDING
public static class D2DNative
{
    // ---- Interface IIDs --------------------------------------------------------------------------

    /// <summary>IID_ID2D1Factory.</summary>
    public static readonly Guid IID_ID2D1Factory = new("06152247-6f50-465a-9245-118bfd3b6007");

    /// <summary>IID_ID2D1Factory1 (device-based API).</summary>
    public static readonly Guid IID_ID2D1Factory1 = new("bb12d362-daee-4b9a-aa1d-14ba401cfa1f");

    /// <summary>IID_ID2D1Device.</summary>
    public static readonly Guid IID_ID2D1Device = new("47dd575d-ac05-4cdd-8049-9b02cd16f44c");

    /// <summary>IID_ID2D1DeviceContext.</summary>
    public static readonly Guid IID_ID2D1DeviceContext = new("e8f7fe7a-191c-466d-ad95-975678bda998");

    // ---- Vtable slots ----------------------------------------------------------------------------
    // ID2D1DeviceContext inherits ID2D1RenderTarget, which inherits ID2D1Resource (GetFactory) and
    // IUnknown. Slots: 0-2 IUnknown, 3 GetFactory, then the render-target methods begin at 4.

    /// <summary>ID2D1RenderTarget::CreateBitmap (first render-target method).</summary>
    public const int VtblCreateBitmap = 4;

    /// <summary>ID2D1RenderTarget::CreateSolidColorBrush.</summary>
    public const int VtblCreateSolidColorBrush = 8;

    /// <summary>ID2D1RenderTarget::DrawRectangle.</summary>
    public const int VtblDrawRectangle = 16;

    /// <summary>ID2D1RenderTarget::FillRectangle.</summary>
    public const int VtblFillRectangle = 17;

    /// <summary>ID2D1RenderTarget::DrawRoundedRectangle.</summary>
    public const int VtblDrawRoundedRectangle = 18;

    /// <summary>ID2D1RenderTarget::FillRoundedRectangle.</summary>
    public const int VtblFillRoundedRectangle = 19;

    /// <summary>ID2D1RenderTarget::DrawBitmap.</summary>
    public const int VtblDrawBitmap = 26;

    /// <summary>ID2D1RenderTarget::DrawText.</summary>
    public const int VtblDrawText = 27;

    /// <summary>ID2D1RenderTarget::SetTransform.</summary>
    public const int VtblSetTransform = 30;

    /// <summary>ID2D1RenderTarget::SetAntialiasMode.</summary>
    public const int VtblSetAntialiasMode = 32;

    /// <summary>ID2D1RenderTarget::SetTextAntialiasMode.</summary>
    public const int VtblSetTextAntialiasMode = 34;

    /// <summary>ID2D1RenderTarget::PushAxisAlignedClip.</summary>
    public const int VtblPushAxisAlignedClip = 45;

    /// <summary>ID2D1RenderTarget::PopAxisAlignedClip.</summary>
    public const int VtblPopAxisAlignedClip = 46;

    /// <summary>ID2D1RenderTarget::Clear.</summary>
    public const int VtblClear = 47;

    /// <summary>ID2D1RenderTarget::BeginDraw.</summary>
    public const int VtblBeginDraw = 48;

    /// <summary>ID2D1RenderTarget::EndDraw.</summary>
    public const int VtblEndDraw = 49;

    /// <summary>ID2D1RenderTarget::SetDpi.</summary>
    public const int VtblSetDpi = 51;

    /// <summary>ID2D1DeviceContext::CreateBitmapFromDxgiSurface.</summary>
    public const int VtblCreateBitmapFromDxgiSurface = 62;

    /// <summary>ID2D1DeviceContext::SetTarget.</summary>
    public const int VtblSetTarget = 74;

    /// <summary>ID2D1DeviceContext::CreateBitmap overload that returns ID2D1Bitmap1.</summary>
    public const int VtblCreateBitmap1 = 57;

    /// <summary>ID2D1Bitmap::CopyFromBitmap.</summary>
    public const int VtblBitmapCopyFromBitmap = 8;

    /// <summary>ID2D1Bitmap1::Map.</summary>
    public const int VtblBitmap1Map = 14;

    /// <summary>ID2D1Bitmap1::Unmap.</summary>
    public const int VtblBitmap1Unmap = 15;

    /// <summary>ID2D1Device::CreateDeviceContext.</summary>
    public const int VtblCreateDeviceContext = 4;

    /// <summary>ID2D1Factory1::CreateDevice.</summary>
    public const int VtblCreateDevice = 17;

    // Geometry. A triangle is the one primitive Direct2D has no dedicated call for, so it goes
    // through a path geometry: ID2D1Resource::GetFactory off the context, CreatePathGeometry,
    // Open, one closed figure, Close, then ID2D1RenderTarget::FillGeometry.

    /// <summary>ID2D1Resource::GetFactory (the first method after IUnknown on every D2D object).</summary>
    public const int VtblGetFactory = 3;

    /// <summary>ID2D1Factory::CreatePathGeometry.</summary>
    public const int VtblCreatePathGeometry = 10;

    /// <summary>ID2D1PathGeometry::Open (ID2D1Geometry contributes slots 4-16).</summary>
    public const int VtblPathGeometryOpen = 17;

    /// <summary>ID2D1PathGeometry::GetFigureCount, which is how a test proves the sink was driven.</summary>
    public const int VtblPathGeometryGetFigureCount = 20;

    /// <summary>ID2D1SimplifiedGeometrySink::SetFillMode.</summary>
    public const int VtblGeometrySinkSetFillMode = 3;

    /// <summary>ID2D1SimplifiedGeometrySink::BeginFigure.</summary>
    public const int VtblGeometrySinkBeginFigure = 5;

    /// <summary>ID2D1SimplifiedGeometrySink::AddLines.</summary>
    public const int VtblGeometrySinkAddLines = 6;

    /// <summary>ID2D1SimplifiedGeometrySink::EndFigure.</summary>
    public const int VtblGeometrySinkEndFigure = 8;

    /// <summary>ID2D1SimplifiedGeometrySink::Close.</summary>
    public const int VtblGeometrySinkClose = 9;

    /// <summary>ID2D1RenderTarget::FillGeometry.</summary>
    public const int VtblFillGeometry = 23;

    /// <summary>Direct2D signals this from EndDraw when target resources must be recreated.</summary>
    public const int D2DERR_RECREATE_TARGET = unchecked((int)0x8899000C);

    // ---- Enums -----------------------------------------------------------------------------------

    public enum D2D1_FACTORY_TYPE : uint
    {
        SINGLE_THREADED = 0,
        MULTI_THREADED = 1,
    }

    public enum D2D1_ALPHA_MODE : uint
    {
        UNKNOWN = 0,
        PREMULTIPLIED = 1,
        STRAIGHT = 2,
        IGNORE = 3,
    }

    public enum D2D1_ANTIALIAS_MODE : uint
    {
        PER_PRIMITIVE = 0,
        ALIASED = 1,
    }

    public enum D2D1_TEXT_ANTIALIAS_MODE : uint
    {
        DEFAULT = 0,
        CLEARTYPE = 1,
        GRAYSCALE = 2,
        ALIASED = 3,
    }

    [Flags]
    public enum D2D1_DRAW_TEXT_OPTIONS : uint
    {
        NONE = 0,
        CLIP = 0x00000002,
    }

    public enum D2D1_BITMAP_INTERPOLATION_MODE : uint
    {
        NEAREST_NEIGHBOR = 0,
        LINEAR = 1,
    }

    [Flags]
    public enum D2D1_MAP_OPTIONS : uint
    {
        NONE = 0,
        READ = 1,
        WRITE = 2,
        DISCARD = 4,
    }

    [Flags]
    public enum D2D1_BITMAP_OPTIONS : uint
    {
        NONE = 0,
        TARGET = 0x00000001,
        CANNOT_DRAW = 0x00000002,
        CPU_READ = 0x00000004,
        GDI_COMPATIBLE = 0x00000008,
    }

    [Flags]
    public enum D2D1_FILL_MODE : uint
    {
        ALTERNATE = 0,
        WINDING = 1,
    }

    public enum D2D1_FIGURE_BEGIN : uint
    {
        FILLED = 0,
        HOLLOW = 1,
    }

    public enum D2D1_FIGURE_END : uint
    {
        OPEN = 0,
        CLOSED = 1,
    }

    public enum D2D1_DEVICE_CONTEXT_OPTIONS : uint
    {
        NONE = 0,
        ENABLE_MULTITHREADED_OPTIMIZATIONS = 1,
    }

    // ---- Value structures ------------------------------------------------------------------------

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=9B8A78
    // Broiler-Falsified-If: Marshal.SizeOf is not 8 or Height is not at offset 4, the layout of D2D_SIZE_U { UINT32 width; UINT32 height; } in dcommon.h that d2d1.h names D2D1_SIZE_U
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_SIZE_U
    {
        public uint Width;
        public uint Height;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=A8FA51
    // Broiler-Falsified-If: Marshal.SizeOf is not 16 on 64-bit or Bits is not at offset 8, the layout of D2D1_MAPPED_RECT { UINT32 pitch; BYTE *bits; } in d2d1_1.h
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_MAPPED_RECT
    {
        public uint Pitch;
        public IntPtr Bits;
    }

    /// <summary>A DXGI format paired with how its alpha channel is interpreted.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=89F880
    // Broiler-Falsified-If: Marshal.SizeOf is not 8 or AlphaMode is not at offset 4, the layout of D2D1_PIXEL_FORMAT { DXGI_FORMAT format; D2D1_ALPHA_MODE alphaMode; } in dcommon.h
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_PIXEL_FORMAT
    {
        public DxgiNative.DXGI_FORMAT Format;
        public D2D1_ALPHA_MODE AlphaMode;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=D33E87
    // Broiler-Falsified-If: Marshal.SizeOf is not 16 or DpiX is not at offset 8, the layout of D2D1_BITMAP_PROPERTIES { D2D1_PIXEL_FORMAT pixelFormat; FLOAT dpiX; FLOAT dpiY; } in d2d1.h
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_BITMAP_PROPERTIES
    {
        public D2D1_PIXEL_FORMAT PixelFormat;
        public float DpiX;
        public float DpiY;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=651843
    // Broiler-Falsified-If: Marshal.SizeOf is not 32 on 64-bit or ColorContext is not at offset 24, the layout of D2D1_BITMAP_PROPERTIES1 { D2D1_PIXEL_FORMAT pixelFormat; FLOAT dpiX; FLOAT dpiY; D2D1_BITMAP_OPTIONS bitmapOptions; ID2D1ColorContext *colorContext; } in d2d1_1.h
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_BITMAP_PROPERTIES1
    {
        public D2D1_PIXEL_FORMAT PixelFormat;
        public float DpiX;
        public float DpiY;
        public D2D1_BITMAP_OPTIONS BitmapOptions;
        public IntPtr ColorContext;
    }

    /// <summary>Direct2D uses 32-bit floats and premultiplied colors at the GPU level.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=20006A
    // Broiler-Falsified-If: Marshal.SizeOf is not 16 or R, G, B and A are not at offsets 0, 4, 8 and 12, the layout of D3DCOLORVALUE { float r; float g; float b; float a; } in dxgitype.h that d2dbasetypes.h names D2D_COLOR_F
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_COLOR_F
    {
        public float R;
        public float G;
        public float B;
        public float A;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=FDCA31
    // Broiler-Falsified-If: Marshal.SizeOf is not 8 or Y is not at offset 4, the layout of D2D_POINT_2F { FLOAT x; FLOAT y; } in dcommon.h that d2d1.h names D2D1_POINT_2F
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_POINT_2F
    {
        public float X;
        public float Y;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=5A4C8B
    // Broiler-Falsified-If: Marshal.SizeOf is not 16 or Left, Top, Right and Bottom are not at offsets 0, 4, 8 and 12, the layout of D2D_RECT_F { FLOAT left; FLOAT top; FLOAT right; FLOAT bottom; } in dcommon.h
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_RECT_F
    {
        public float Left;
        public float Top;
        public float Right;
        public float Bottom;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=B27539
    // Broiler-Falsified-If: Marshal.SizeOf is not 24 or RadiusX is not at offset 16, the layout of D2D1_ROUNDED_RECT { D2D1_RECT_F rect; FLOAT radiusX; FLOAT radiusY; } in d2d1.h
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_ROUNDED_RECT
    {
        public D2D1_RECT_F Rect;
        public float RadiusX;
        public float RadiusY;
    }

    /// <summary>Direct2D's 3x2 transform (row-major, translation in the last row).</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=440448
    // Broiler-Falsified-If: Marshal.SizeOf is not 24 or M11, M12, M21, M22, Dx and Dy are not at offsets 0 to 20 in steps of 4, the m11, m12, m21, m22, dx, dy order of D2D_MATRIX_3X2_F in dcommon.h
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_MATRIX_3X2_F
    {
        public float M11;
        public float M12;
        public float M21;
        public float M22;
        public float Dx;
        public float Dy;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=F3DA9B
    // Broiler-Falsified-If: differs from slot 4 of ID2D1Device, HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext **deviceContext) in d2d1_1.h, with this as the explicit first argument
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateDeviceContextProc(IntPtr self, D2DNative.D2D1_DEVICE_CONTEXT_OPTIONS options, out IntPtr deviceContext);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=307319
    // Broiler-Falsified-If: differs from slot 74 of ID2D1DeviceContext, void SetTarget(ID2D1Image *image) in d2d1_1.h, with this as the explicit first argument
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetTargetProc(IntPtr self, IntPtr image);
}
