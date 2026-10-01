// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   65
// Annotated:        65/65
// Exempt:           66
// Human-reviewed:   0/65
// IP risk:          Low
// Security risk:    Critical
// Criteria:         65/53
// Resource impact:  2/10 max
// Unverified:       65
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
// Broiler-Falsified-If: a slot constant here does not match the d2d1.h or d2d1_1.h vtable order, for example VtblCreateBitmap1 not being 57, so a caller's source pointer, pitch and size go to a different native method that reads outside the pixel buffer
// Broiler-Human:        PENDING
public static class D2DNative
{
    // ---- Interface IIDs --------------------------------------------------------------------------

    /// <summary>IID_ID2D1Factory.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=5DF65C
    // Broiler-Falsified-If: the GUID differs from IID_ID2D1Factory in d2d1.h (06152247-6f50-465a-9245-118bfd3b6007), so D2D1CreateFactory with it fails with E_NOINTERFACE or returns an interface whose vtable the ID2D1Factory slots here do not describe
    // Broiler-Human:        PENDING
    public static readonly Guid IID_ID2D1Factory = new("06152247-6f50-465a-9245-118bfd3b6007");

    /// <summary>IID_ID2D1Factory1 (device-based API).</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=66E3B6
    // Broiler-Falsified-If: the GUID differs from IID_ID2D1Factory1 in d2d1_1.h (bb12d362-daee-4b9a-aa1d-14ba401cfa1f), so D2D1CreateFactory in device setup fails with E_NOINTERFACE and no ID2D1Device can be created through slot 17
    // Broiler-Human:        PENDING
    public static readonly Guid IID_ID2D1Factory1 = new("bb12d362-daee-4b9a-aa1d-14ba401cfa1f");

    /// <summary>IID_ID2D1Device.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=6800FD
    // Broiler-Falsified-If: the GUID differs from IID_ID2D1Device in d2d1_1.h (47dd575d-ac05-4cdd-8049-9b02cd16f44c), so QueryInterface for it fails or yields a pointer on which slot 4 is not CreateDeviceContext
    // Broiler-Human:        PENDING
    public static readonly Guid IID_ID2D1Device = new("47dd575d-ac05-4cdd-8049-9b02cd16f44c");

    /// <summary>IID_ID2D1DeviceContext.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=4DD50A
    // Broiler-Falsified-If: the GUID differs from IID_ID2D1DeviceContext in d2d1_1.h (e8f7fe7a-191c-466d-ad95-975678bda998), so QueryInterface for it fails or yields a plain ID2D1RenderTarget on which slots 57 to 74 index past the vtable
    // Broiler-Human:        PENDING
    public static readonly Guid IID_ID2D1DeviceContext = new("e8f7fe7a-191c-466d-ad95-975678bda998");

    // ---- Vtable slots ----------------------------------------------------------------------------
    // ID2D1DeviceContext inherits ID2D1RenderTarget, which inherits ID2D1Resource (GetFactory) and
    // IUnknown. Slots: 0-2 IUnknown, 3 GetFactory, then the render-target methods begin at 4.

    /// <summary>ID2D1RenderTarget::CreateBitmap (first render-target method).</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=466548
    // Broiler-Falsified-If: slot 4 of the device context vtable is not ID2D1RenderTarget::CreateBitmap (GetFactory is 3, CreateBitmapFromWicBitmap 5), so the image upload's pinned source pointer, pitch and size reach a method that reads them as other arguments and walks memory outside the pixel buffer
    // Broiler-Human:        PENDING
    public const int VtblCreateBitmap = 4;

    /// <summary>ID2D1RenderTarget::CreateSolidColorBrush.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=A4A8BD
    // Broiler-Falsified-If: slot 8 is not ID2D1RenderTarget::CreateSolidColorBrush (CreateBitmapBrush is 7, CreateGradientStopCollection 9), so the brush out pointer receives another object or nothing and the following fill draws with it
    // Broiler-Human:        PENDING
    public const int VtblCreateSolidColorBrush = 8;

    /// <summary>ID2D1RenderTarget::DrawRectangle.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=3421D5
    // Broiler-Falsified-If: slot 16 is not ID2D1RenderTarget::DrawRectangle (DrawLine is 15, FillRectangle 17), so a stroked rectangle's rect pointer, brush, width and stroke style are passed as another method's parameters
    // Broiler-Human:        PENDING
    public const int VtblDrawRectangle = 16;

    /// <summary>ID2D1RenderTarget::FillRectangle.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=B55F29
    // Broiler-Falsified-If: slot 17 is not ID2D1RenderTarget::FillRectangle, so the rectangle pointer and brush go to DrawRectangle (16) or DrawRoundedRectangle (18), which read a stroke width and style that were never passed
    // Broiler-Human:        PENDING
    public const int VtblFillRectangle = 17;

    /// <summary>ID2D1RenderTarget::DrawRoundedRectangle.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=AE9CCF
    // Broiler-Falsified-If: slot 18 is not ID2D1RenderTarget::DrawRoundedRectangle (FillRectangle is 17, FillRoundedRectangle 19), so the D2D1_ROUNDED_RECT pointer is read by a neighbouring method as a plain rectangle or the outline is filled instead
    // Broiler-Human:        PENDING
    public const int VtblDrawRoundedRectangle = 18;

    /// <summary>ID2D1RenderTarget::FillRoundedRectangle.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=1C4F61
    // Broiler-Falsified-If: slot 19 is not ID2D1RenderTarget::FillRoundedRectangle (DrawEllipse is 20), so the rounded rectangle is read as a D2D1_ELLIPSE or a stroke width is read from an argument that was never passed
    // Broiler-Human:        PENDING
    public const int VtblFillRoundedRectangle = 19;

    /// <summary>ID2D1RenderTarget::DrawBitmap.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=75113E
    // Broiler-Falsified-If: slot 26 is not ID2D1RenderTarget::DrawBitmap (FillOpacityMask is 25, DrawText 27), so the bitmap, destination, opacity, interpolation and source rectangle are read as another method's arguments
    // Broiler-Human:        PENDING
    public const int VtblDrawBitmap = 26;

    /// <summary>ID2D1RenderTarget::DrawText.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=413EFF
    // Broiler-Falsified-If: slot 27 is not ID2D1RenderTarget::DrawText (DrawTextLayout is 28), so the page text pointer and its UTF-16 length reach a method that reads them as other arguments and walks memory past the marshalled string
    // Broiler-Human:        PENDING
    public const int VtblDrawText = 27;

    /// <summary>ID2D1RenderTarget::SetTransform.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=439DEF
    // Broiler-Falsified-If: slot 30 is not ID2D1RenderTarget::SetTransform (GetTransform is 31), so the matrix argument is written through by the getter instead of read and page content is drawn under the previous transform
    // Broiler-Human:        PENDING
    public const int VtblSetTransform = 30;

    /// <summary>ID2D1RenderTarget::SetAntialiasMode.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=F2EF04
    // Broiler-Falsified-If: slot 32 is not ID2D1RenderTarget::SetAntialiasMode (GetAntialiasMode is 33), so the mode argument is ignored and the frame renders with the previous antialias mode
    // Broiler-Human:        PENDING
    public const int VtblSetAntialiasMode = 32;

    /// <summary>ID2D1RenderTarget::SetTextAntialiasMode.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=CB1743
    // Broiler-Falsified-If: slot 34 is not ID2D1RenderTarget::SetTextAntialiasMode (GetTextAntialiasMode is 35), so the text mode argument is ignored and text renders with the previous antialias mode
    // Broiler-Human:        PENDING
    public const int VtblSetTextAntialiasMode = 34;

    /// <summary>ID2D1RenderTarget::PushAxisAlignedClip.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=83E746
    // Broiler-Falsified-If: slot 45 is not ID2D1RenderTarget::PushAxisAlignedClip (RestoreDrawingState is 44, PopAxisAlignedClip 46), so the clip rectangle pointer is read as a drawing-state block or the clip is popped instead of pushed and content paints outside its clip
    // Broiler-Human:        PENDING
    public const int VtblPushAxisAlignedClip = 45;

    /// <summary>ID2D1RenderTarget::PopAxisAlignedClip.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E692BC
    // Broiler-Falsified-If: slot 46 is not ID2D1RenderTarget::PopAxisAlignedClip, so a pop leaves the clip pushed or calls Clear (47) with no color pointer, and EndDraw fails the frame for unbalanced clips
    // Broiler-Human:        PENDING
    public const int VtblPopAxisAlignedClip = 46;

    /// <summary>ID2D1RenderTarget::Clear.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=4DCAE7
    // Broiler-Falsified-If: slot 47 is not ID2D1RenderTarget::Clear, so the clear-color pointer goes to PopAxisAlignedClip (46) or BeginDraw (48) and the frame starts over the previous contents
    // Broiler-Human:        PENDING
    public const int VtblClear = 47;

    /// <summary>ID2D1RenderTarget::BeginDraw.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=621675
    // Broiler-Falsified-If: slot 48 is not ID2D1RenderTarget::BeginDraw (EndDraw is 49), so a frame starts by ending the previous one and drawing calls before EndDraw fail with D2DERR_WRONG_STATE
    // Broiler-Human:        PENDING
    public const int VtblBeginDraw = 48;

    /// <summary>ID2D1RenderTarget::EndDraw.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E6239B
    // Broiler-Falsified-If: slot 49 is not ID2D1RenderTarget::EndDraw, so the HRESULT the renderer compares with D2DERR_RECREATE_TARGET comes from BeginDraw (48) or GetPixelFormat (50) and a lost device is never reported
    // Broiler-Human:        PENDING
    public const int VtblEndDraw = 49;

    /// <summary>ID2D1RenderTarget::SetDpi.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=D8A223
    // Broiler-Falsified-If: slot 51 is not ID2D1RenderTarget::SetDpi (GetDpi is 52), so the two DPI floats are taken as out pointers and the getter writes through them
    // Broiler-Human:        PENDING
    public const int VtblSetDpi = 51;

    /// <summary>ID2D1DeviceContext::CreateBitmapFromDxgiSurface.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=A55210
    // Broiler-Falsified-If: slot 62 is not ID2D1DeviceContext::CreateBitmapFromDxgiSurface in d2d1_1.h (CreateColorContextFromWicColorContext is 61, CreateEffect 63), so the swap-chain surface and properties pointer reach another creation method and the out pointer is not an ID2D1Bitmap1
    // Broiler-Human:        PENDING
    public const int VtblCreateBitmapFromDxgiSurface = 62;

    /// <summary>ID2D1DeviceContext::SetTarget.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=3FF6A9
    // Broiler-Falsified-If: slot 74 is not ID2D1DeviceContext::SetTarget (GetDevice is 73, GetTarget 75), so the target bitmap pointer is used as an out parameter and written through instead of becoming the drawing target
    // Broiler-Human:        PENDING
    public const int VtblSetTarget = 74;

    /// <summary>ID2D1DeviceContext::CreateBitmap overload that returns ID2D1Bitmap1.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=C5E4A9
    // Broiler-Falsified-If: slot 57 is not the ID2D1DeviceContext::CreateBitmap taking D2D1_BITMAP_PROPERTIES1 (the first method after ID2D1RenderTarget's 4 to 56), so size, source pointer and pitch are read as CreateBitmapFromWicBitmap (58) arguments and the source pointer is dereferenced as a WIC object
    // Broiler-Human:        PENDING
    public const int VtblCreateBitmap1 = 57;

    /// <summary>ID2D1Bitmap::CopyFromBitmap.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=A843FD
    // Broiler-Falsified-If: slot 8 of ID2D1Bitmap is not CopyFromBitmap (GetDpi is 7, CopyFromRenderTarget 9), so the readback bitmap receives no copy or treats the target bitmap as a render target and ReadToBitmap returns stale pixels
    // Broiler-Human:        PENDING
    public const int VtblBitmapCopyFromBitmap = 8;

    /// <summary>ID2D1Bitmap1::Map.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=DCA014
    // Broiler-Falsified-If: slot 14 of ID2D1Bitmap1 is not Map (GetSurface is 13, Unmap 15), so the D2D1_MAPPED_RECT out argument is filled by another method and the readback copy reads Pitch times height bytes from a pointer that is not a mapped bitmap
    // Broiler-Human:        PENDING
    public const int VtblBitmap1Map = 14;

    /// <summary>ID2D1Bitmap1::Unmap.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=6B7BCA
    // Broiler-Falsified-If: slot 15 of ID2D1Bitmap1 is not Unmap (Map is 14), so the readback bitmap stays mapped after ReadToBitmap and a later Map on it fails
    // Broiler-Human:        PENDING
    public const int VtblBitmap1Unmap = 15;

    /// <summary>ID2D1Device::CreateDeviceContext.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=0B7467
    // Broiler-Falsified-If: slot 4 of ID2D1Device is not CreateDeviceContext (GetFactory is 3, CreatePrintControl 5), so the out pointer receives something other than an ID2D1DeviceContext and every render-target slot in this class indexes a foreign vtable
    // Broiler-Human:        PENDING
    public const int VtblCreateDeviceContext = 4;

    /// <summary>ID2D1Factory1::CreateDevice.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=AEADB5
    // Broiler-Falsified-If: slot 17 of ID2D1Factory1 is not CreateDevice (the first method after ID2D1Factory's 3 to 16), so the IDXGIDevice is handed to CreateDCRenderTarget (16) or CreateStrokeStyle (18) and no ID2D1Device is returned
    // Broiler-Human:        PENDING
    public const int VtblCreateDevice = 17;

    // Geometry. A triangle is the one primitive Direct2D has no dedicated call for, so it goes
    // through a path geometry: ID2D1Resource::GetFactory off the context, CreatePathGeometry,
    // Open, one closed figure, Close, then ID2D1RenderTarget::FillGeometry.

    /// <summary>ID2D1Resource::GetFactory (the first method after IUnknown on every D2D object).</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=43D0C9
    // Broiler-Falsified-If: slot 3 is not ID2D1Resource::GetFactory on the device context, so the pointer used for CreatePathGeometry is another object and slot 10 is called through a foreign vtable
    // Broiler-Human:        PENDING
    public const int VtblGetFactory = 3;

    /// <summary>ID2D1Factory::CreatePathGeometry.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=17C770
    // Broiler-Falsified-If: slot 10 of ID2D1Factory is not CreatePathGeometry (CreateTransformedGeometry is 9, CreateStrokeStyle 11), so the out pointer used as an ID2D1PathGeometry holds another object and Open (17) indexes its vtable
    // Broiler-Human:        PENDING
    public const int VtblCreatePathGeometry = 10;

    /// <summary>ID2D1PathGeometry::Open (ID2D1Geometry contributes slots 4-16).</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=939685
    // Broiler-Falsified-If: slot 17 of ID2D1PathGeometry is not Open (ID2D1Geometry's 4 to 16 precede it), so the sink out pointer receives another object and the sink slots 3 to 9 are called through a foreign vtable
    // Broiler-Human:        PENDING
    public const int VtblPathGeometryOpen = 17;

    /// <summary>ID2D1PathGeometry::GetFigureCount, which is how a test proves the sink was driven.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=DBF720
    // Broiler-Falsified-If: slot 20 of ID2D1PathGeometry is not GetFigureCount (GetSegmentCount is 19), so the count reported for the triangle path is its segment count and a caller comparing it with one figure misjudges what the sink recorded
    // Broiler-Human:        PENDING
    public const int VtblPathGeometryGetFigureCount = 20;

    /// <summary>ID2D1SimplifiedGeometrySink::SetFillMode.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=961CFD
    // Broiler-Falsified-If: slot 3 of ID2D1SimplifiedGeometrySink is not SetFillMode (SetSegmentFlags is 4), so WINDING is applied as a segment flag and the triangle fills by the alternate rule
    // Broiler-Human:        PENDING
    public const int VtblGeometrySinkSetFillMode = 3;

    /// <summary>ID2D1SimplifiedGeometrySink::BeginFigure.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=77EA65
    // Broiler-Falsified-If: slot 5 of ID2D1SimplifiedGeometrySink is not BeginFigure (SetSegmentFlags is 4, AddLines 6), so the start point and FILLED flag are read as another method's arguments and the start point is dereferenced as a points pointer
    // Broiler-Human:        PENDING
    public const int VtblGeometrySinkBeginFigure = 5;

    /// <summary>ID2D1SimplifiedGeometrySink::AddLines.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=42F553
    // Broiler-Falsified-If: slot 6 of ID2D1SimplifiedGeometrySink is not AddLines (AddBeziers is 7), so the points array is read as 24-byte D2D1_BEZIER_SEGMENT records instead of 8-byte points and pointsCount entries run past the managed array
    // Broiler-Human:        PENDING
    public const int VtblGeometrySinkAddLines = 6;

    /// <summary>ID2D1SimplifiedGeometrySink::EndFigure.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=D8E01B
    // Broiler-Falsified-If: slot 8 of ID2D1SimplifiedGeometrySink is not EndFigure (AddBeziers is 7, Close 9), so the triangle figure is never ended and Close fails with D2DERR_WRONG_STATE
    // Broiler-Human:        PENDING
    public const int VtblGeometrySinkEndFigure = 8;

    /// <summary>ID2D1SimplifiedGeometrySink::Close.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=540E43
    // Broiler-Falsified-If: slot 9 of ID2D1SimplifiedGeometrySink is not Close (EndFigure is 8), so the sink is never closed and FillGeometry on the path fails the frame with D2DERR_WRONG_STATE
    // Broiler-Human:        PENDING
    public const int VtblGeometrySinkClose = 9;

    /// <summary>ID2D1RenderTarget::FillGeometry.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E71DA5
    // Broiler-Falsified-If: slot 23 is not ID2D1RenderTarget::FillGeometry (DrawGeometry is 22, FillMesh 24), so the triangle is stroked with the brush argument read as a width or the geometry is read as an ID2D1Mesh
    // Broiler-Human:        PENDING
    public const int VtblFillGeometry = 23;

    /// <summary>Direct2D signals this from EndDraw when target resources must be recreated.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=42D9F6
    // Broiler-Falsified-If: the value is not 0x8899000C from d2derr.h, so an EndDraw that reports a lost target surfaces as a generic failure and the device is never recreated
    // Broiler-Human:        PENDING
    public const int D2DERR_RECREATE_TARGET = unchecked((int)0x8899000C);

    // ---- Enums -----------------------------------------------------------------------------------

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=6850E8
    // Broiler-Falsified-If: MULTI_THREADED is not 1 as in d2d1.h, so a factory requested as multi-threaded is created single-threaded and calls from several threads race inside Direct2D
    // Broiler-Human:        PENDING
    public enum D2D1_FACTORY_TYPE : uint
    {
        SINGLE_THREADED = 0,
        MULTI_THREADED = 1,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=4EA25C
    // Broiler-Falsified-If: PREMULTIPLIED is not 1 or IGNORE is not 3 as in dcommon.h, so CreateBitmap treats uploaded premultiplied BGRA pixels as straight alpha, or an opaque surface's alpha channel as meaningful, and composites page images wrongly
    // Broiler-Human:        PENDING
    public enum D2D1_ALPHA_MODE : uint
    {
        UNKNOWN = 0,
        PREMULTIPLIED = 1,
        STRAIGHT = 2,
        IGNORE = 3,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=FA02ED
    // Broiler-Falsified-If: PER_PRIMITIVE is not 0 or ALIASED is not 1 as in d2d1.h, so SetAntialiasMode and PushAxisAlignedClip get the opposite mode or an out-of-range value that fails the frame at EndDraw
    // Broiler-Human:        PENDING
    public enum D2D1_ANTIALIAS_MODE : uint
    {
        PER_PRIMITIVE = 0,
        ALIASED = 1,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=B14994
    // Broiler-Falsified-If: a member differs from d2d1.h (DEFAULT 0, CLEARTYPE 1, GRAYSCALE 2, ALIASED 3), so SetTextAntialiasMode applies another text antialias mode than the frame options asked for or an out-of-range value that fails the frame at EndDraw
    // Broiler-Human:        PENDING
    public enum D2D1_TEXT_ANTIALIAS_MODE : uint
    {
        DEFAULT = 0,
        CLEARTYPE = 1,
        GRAYSCALE = 2,
        ALIASED = 3,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=7ABC57
    // Broiler-Falsified-If: CLIP is not 0x2 as in d2d1.h, so DrawText asked to clip draws page text outside its layout rectangle or turns on NO_SNAP (0x1) instead
    // Broiler-Human:        PENDING
    [Flags]
    public enum D2D1_DRAW_TEXT_OPTIONS : uint
    {
        NONE = 0,
        CLIP = 0x00000002,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=237502
    // Broiler-Falsified-If: NEAREST_NEIGHBOR is not 0 or LINEAR is not 1 as in d2d1.h, so DrawBitmap scales page images with the other filter or an out-of-range mode that fails the frame at EndDraw
    // Broiler-Human:        PENDING
    public enum D2D1_BITMAP_INTERPOLATION_MODE : uint
    {
        NEAREST_NEIGHBOR = 0,
        LINEAR = 1,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=F54725
    // Broiler-Falsified-If: READ is not 1 as in d2d1_1.h, so Map on the CPU_READ readback bitmap asks for WRITE or DISCARD access and fails, and ReadToBitmap throws instead of returning pixels
    // Broiler-Human:        PENDING
    [Flags]
    public enum D2D1_MAP_OPTIONS : uint
    {
        NONE = 0,
        READ = 1,
        WRITE = 2,
        DISCARD = 4,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=68A1FB
    // Broiler-Falsified-If: TARGET is not 0x1, CANNOT_DRAW is not 0x2 or CPU_READ is not 0x4 as in d2d1_1.h, so CreateBitmap1 makes a target bitmap SetTarget rejects or a readback bitmap Map refuses
    // Broiler-Human:        PENDING
    [Flags]
    public enum D2D1_BITMAP_OPTIONS : uint
    {
        NONE = 0,
        TARGET = 0x00000001,
        CANNOT_DRAW = 0x00000002,
        CPU_READ = 0x00000004,
        GDI_COMPATIBLE = 0x00000008,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=9CF115
    // Broiler-Falsified-If: WINDING is not 1 as in d2d1.h, so SetFillMode fills the triangle path by the alternate rule and disagrees with the CPU rasterizer's nonzero winding fill
    // Broiler-Human:        PENDING
    [Flags]
    public enum D2D1_FILL_MODE : uint
    {
        ALTERNATE = 0,
        WINDING = 1,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=E6C578
    // Broiler-Falsified-If: FILLED is not 0 as in d2d1.h, so BeginFigure starts a hollow figure and FillGeometry paints nothing for the triangle
    // Broiler-Human:        PENDING
    public enum D2D1_FIGURE_BEGIN : uint
    {
        FILLED = 0,
        HOLLOW = 1,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=DF6801
    // Broiler-Falsified-If: CLOSED is not 1 as in d2d1.h, so EndFigure leaves the triangle figure open and a stroke of the path misses its closing edge
    // Broiler-Human:        PENDING
    public enum D2D1_FIGURE_END : uint
    {
        OPEN = 0,
        CLOSED = 1,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=62F884
    // Broiler-Falsified-If: NONE is not 0 as in d2d1_1.h, so CreateDeviceContext asked for no options turns on multithreaded optimizations or rejects the call as an invalid option
    // Broiler-Human:        PENDING
    public enum D2D1_DEVICE_CONTEXT_OPTIONS : uint
    {
        NONE = 0,
        ENABLE_MULTITHREADED_OPTIMIZATIONS = 1,
    }

    // ---- Value structures ------------------------------------------------------------------------

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=9B8A78
    // Broiler-Falsified-If: the struct is not two consecutive 32-bit unsigned integers, Width then Height (8 bytes), so CreateBitmap reads more or wider rows from the pinned source buffer than the caller sized from Width and Height
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_SIZE_U
    {
        public uint Width;
        public uint Height;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=A8FA51
    // Broiler-Falsified-If: on x64 Bits is not at offset 8 after the 32-bit Pitch and 4 bytes of padding (16 bytes in all), so the readback copy after Map walks Pitch times height bytes from a pointer that is not the mapped bitmap
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_MAPPED_RECT
    {
        public uint Pitch;
        public IntPtr Bits;
    }

    /// <summary>A DXGI format paired with how its alpha channel is interpreted.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=89F880
    // Broiler-Falsified-If: Format and AlphaMode are not two consecutive 32-bit fields in that order (8 bytes), so CreateBitmap takes the alpha mode as the DXGI format and reads more bytes per pixel than the caller's pitch-by-height source buffer holds
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_PIXEL_FORMAT
    {
        public DxgiNative.DXGI_FORMAT Format;
        public D2D1_ALPHA_MODE AlphaMode;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=D33E87
    // Broiler-Falsified-If: the struct is not an 8-byte D2D1_PIXEL_FORMAT followed by DpiX and DpiY floats (16 bytes), so CreateBitmap takes its pixel format from the wrong bytes and sizes its read of the source buffer from a wrong bytes-per-pixel
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_BITMAP_PROPERTIES
    {
        public D2D1_PIXEL_FORMAT PixelFormat;
        public float DpiX;
        public float DpiY;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=651843
    // Broiler-Falsified-If: on x64 ColorContext is not at offset 24 after BitmapOptions and 4 bytes of padding (32 bytes in all), so CreateBitmap1 or CreateBitmapFromDxgiSurface dereferences a garbage ID2D1ColorContext pointer
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
    // Broiler-Falsified-If: the struct is not four consecutive floats R, G, B, A (16 bytes) as D3DCOLORVALUE, so Clear and CreateSolidColorBrush read the channels in another order
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
    // Broiler-Falsified-If: the struct is not two consecutive 32-bit floats, X then Y (8 bytes), so AddLines reads pointsCount entries at the native 8-byte stride past the end of a managed array laid out with another element size
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_POINT_2F
    {
        public float X;
        public float Y;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=5A4C8B
    // Broiler-Falsified-If: the struct is not four floats Left, Top, Right, Bottom in that order (16 bytes), so FillRectangle, PushAxisAlignedClip and the DrawText layout rectangle receive swapped edges and paint or clip page content in the wrong place
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
    // Broiler-Falsified-If: the struct is not a 16-byte D2D1_RECT_F followed by RadiusX and RadiusY floats (24 bytes), so FillRoundedRectangle and DrawRoundedRectangle take the radii from the rectangle
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
    // Broiler-Falsified-If: the six floats are not in the d2d1.h _11, _12, _21, _22, _31, _32 order, so SetTransform applies a transposed matrix or takes the translation from the shear terms and page content is drawn in the wrong place
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
    // Broiler-Falsified-If: the 32-bit options argument or the ID2D1DeviceContext** out parameter differs from ID2D1Device::CreateDeviceContext in d2d1_1.h, so the new context is written through a mismatched argument and its +1 reference is never released
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateDeviceContextProc(IntPtr self, D2DNative.D2D1_DEVICE_CONTEXT_OPTIONS options, out IntPtr deviceContext);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=307319
    // Broiler-Falsified-If: the void return or the single ID2D1Image* argument differs from ID2D1DeviceContext::SetTarget in d2d1_1.h, so the target bitmap lands in the wrong argument slot and the context keeps drawing to the previous target
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetTargetProc(IntPtr self, IntPtr image);
}
