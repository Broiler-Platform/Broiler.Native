// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   25
// Annotated:        25/25
// Exempt:           0
// Human-reviewed:   0/25
// IP risk:          Low
// Security risk:    Critical
// Criteria:         25/25
// Resource impact:  4/10 max
// Unverified:       25
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=5AD2D2
// Broiler-Falsified-If: DrawTextProc is not slot 27 of ID2D1RenderTarget, void DrawText(CONST WCHAR *string, UINT32 stringLength, IDWriteTextFormat *textFormat, CONST D2D1_RECT_F *layoutRect, ID2D1Brush *defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode) in d2d1.h, whose string is UTF-16 and stringLength counts its WCHARs
// Broiler-Human:        PENDING
public static class Direct2DRendererApi
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=19DEFC
    // Broiler-Falsified-If: BeginDrawProc is not slot 48 of ID2D1RenderTarget, void BeginDraw() in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void BeginDrawProc(IntPtr self);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=908727
    // Broiler-Falsified-If: EndDrawProc is not slot 49 of ID2D1RenderTarget, HRESULT EndDraw(D2D1_TAG *tag1, D2D1_TAG *tag2) in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int EndDrawProc(IntPtr self, IntPtr tag1, IntPtr tag2);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=AE36CF
    // Broiler-Falsified-If: ClearProc is not slot 47 of ID2D1RenderTarget, void Clear(CONST D2D1_COLOR_F *clearColor) in d2d1.h, whose clearColor points at a 16-byte D2D1_COLOR_F
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void ClearProc(IntPtr self, in D2DNative.D2D1_COLOR_F color);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=DF1DCC
    // Broiler-Falsified-If: SetAntialiasModeProc is not slot 32 of ID2D1RenderTarget, void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode) in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetAntialiasModeProc(IntPtr self, D2DNative.D2D1_ANTIALIAS_MODE antialiasMode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=0D0E8D
    // Broiler-Falsified-If: SetTextAntialiasModeProc is not slot 34 of ID2D1RenderTarget, void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode) in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetTextAntialiasModeProc(IntPtr self, D2DNative.D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=698448
    // Broiler-Falsified-If: SetTransformProc is not slot 30 of ID2D1RenderTarget, void SetTransform(CONST D2D1_MATRIX_3X2_F *transform) in d2d1.h, whose transform points at a 24-byte D2D1_MATRIX_3X2_F
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetTransformProc(IntPtr self, in D2DNative.D2D1_MATRIX_3X2_F transform);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=E7E385
    // Broiler-Falsified-If: CreateSolidColorBrushProc is not slot 8 of ID2D1RenderTarget, HRESULT CreateSolidColorBrush(CONST D2D1_COLOR_F *color, CONST D2D1_BRUSH_PROPERTIES *brushProperties, ID2D1SolidColorBrush **solidColorBrush) in d2d1.h, whose color points at a 16-byte D2D1_COLOR_F
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateSolidColorBrushProc(IntPtr self, in D2DNative.D2D1_COLOR_F color, IntPtr brushProperties,
        out IntPtr solidColorBrush);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=824F30
    // Broiler-Falsified-If: FillRectangleProc is not slot 17 of ID2D1RenderTarget, void FillRectangle(CONST D2D1_RECT_F *rect, ID2D1Brush *brush) in d2d1.h, whose rect points at a 16-byte D2D1_RECT_F
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void FillRectangleProc(IntPtr self, in D2DNative.D2D1_RECT_F rect, IntPtr brush);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=7F9457
    // Broiler-Falsified-If: GetFactoryProc is not slot 3 of ID2D1Resource, void GetFactory(ID2D1Factory **factory) CONST in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GetFactoryProc(IntPtr self, out IntPtr factory);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=263E64
    // Broiler-Falsified-If: CreatePathGeometryProc is not slot 10 of ID2D1Factory, HRESULT CreatePathGeometry(ID2D1PathGeometry **pathGeometry) in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreatePathGeometryProc(IntPtr self, out IntPtr pathGeometry);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=F267E0
    // Broiler-Falsified-If: PathGeometryOpenProc is not slot 17 of ID2D1PathGeometry, HRESULT Open(ID2D1GeometrySink **geometrySink) in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PathGeometryOpenProc(IntPtr self, out IntPtr sink);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=EA5E6B
    // Broiler-Falsified-If: GeometrySinkSetFillModeProc is not slot 3 of ID2D1SimplifiedGeometrySink, void SetFillMode(D2D1_FILL_MODE fillMode) in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GeometrySinkSetFillModeProc(IntPtr self, D2DNative.D2D1_FILL_MODE fillMode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=112802
    // Broiler-Falsified-If: GeometrySinkBeginFigureProc is not slot 5 of ID2D1SimplifiedGeometrySink, void BeginFigure(D2D1_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin) in d2d1.h, whose startPoint is an 8-byte D2D1_POINT_2F passed by value
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GeometrySinkBeginFigureProc(IntPtr self,
        D2DNative.D2D1_POINT_2F startPoint, D2DNative.D2D1_FIGURE_BEGIN figureBegin);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=1D7738
    // Broiler-Falsified-If: GeometrySinkAddLinesProc is not slot 6 of ID2D1SimplifiedGeometrySink, void AddLines(CONST D2D1_POINT_2F *points, UINT32 pointsCount) in d2d1.h, which reads pointsCount 8-byte points from the array
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GeometrySinkAddLinesProc(IntPtr self, [In] D2DNative.D2D1_POINT_2F[] points, uint pointsCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B50897
    // Broiler-Falsified-If: GeometrySinkEndFigureProc is not slot 8 of ID2D1SimplifiedGeometrySink, void EndFigure(D2D1_FIGURE_END figureEnd) in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GeometrySinkEndFigureProc(IntPtr self, D2DNative.D2D1_FIGURE_END figureEnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=610C3C
    // Broiler-Falsified-If: GeometrySinkCloseProc is not slot 9 of ID2D1SimplifiedGeometrySink, HRESULT Close() in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GeometrySinkCloseProc(IntPtr self);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=A97749
    // Broiler-Falsified-If: FillGeometryProc is not slot 23 of ID2D1RenderTarget, void FillGeometry(ID2D1Geometry *geometry, ID2D1Brush *brush, ID2D1Brush *opacityBrush) in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void FillGeometryProc(IntPtr self, IntPtr geometry, IntPtr brush, IntPtr opacityBrush);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=3980C2
    // Broiler-Falsified-If: DrawRectangleProc is not slot 16 of ID2D1RenderTarget, void DrawRectangle(CONST D2D1_RECT_F *rect, ID2D1Brush *brush, FLOAT strokeWidth, ID2D1StrokeStyle *strokeStyle) in d2d1.h, whose rect points at a 16-byte D2D1_RECT_F
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void DrawRectangleProc(IntPtr self, in D2DNative.D2D1_RECT_F rect,
        IntPtr brush, float strokeWidth, IntPtr strokeStyle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=53C94F
    // Broiler-Falsified-If: FillRoundedRectangleProc is not slot 19 of ID2D1RenderTarget, void FillRoundedRectangle(CONST D2D1_ROUNDED_RECT *roundedRect, ID2D1Brush *brush) in d2d1.h, whose roundedRect points at a 24-byte D2D1_ROUNDED_RECT with radiusX at offset 16
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void FillRoundedRectangleProc(IntPtr self, in D2DNative.D2D1_ROUNDED_RECT roundedRect, IntPtr brush);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=5F1379
    // Broiler-Falsified-If: DrawRoundedRectangleProc is not slot 18 of ID2D1RenderTarget, void DrawRoundedRectangle(CONST D2D1_ROUNDED_RECT *roundedRect, ID2D1Brush *brush, FLOAT strokeWidth, ID2D1StrokeStyle *strokeStyle) in d2d1.h, whose roundedRect points at a 24-byte D2D1_ROUNDED_RECT
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void DrawRoundedRectangleProc(IntPtr self, in D2DNative.D2D1_ROUNDED_RECT roundedRect, IntPtr brush,
        float strokeWidth, IntPtr strokeStyle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=B0981C
    // Broiler-Falsified-If: DrawTextProc is not slot 27 of ID2D1RenderTarget, void DrawText(CONST WCHAR *string, UINT32 stringLength, IDWriteTextFormat *textFormat, CONST D2D1_RECT_F *layoutRect, ID2D1Brush *defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode) in d2d1.h, whose string is UTF-16 and stringLength counts its WCHARs
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate void DrawTextProc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string text, uint textLength, IntPtr textFormat,
        in D2DNative.D2D1_RECT_F layoutRect, IntPtr brush, D2DNative.D2D1_DRAW_TEXT_OPTIONS options, DWriteNative.DWRITE_MEASURING_MODE measuringMode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=B19583
    // Broiler-Falsified-If: DrawBitmapProc is not slot 26 of ID2D1RenderTarget, void DrawBitmap(ID2D1Bitmap *bitmap, CONST D2D1_RECT_F *destinationRectangle, FLOAT opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, CONST D2D1_RECT_F *sourceRectangle) in d2d1.h, whose two rectangles point at 16-byte D2D1_RECT_F values
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void DrawBitmapProc(IntPtr self, IntPtr bitmap, in D2DNative.D2D1_RECT_F destination, float opacity, uint interpolation,
        in D2DNative.D2D1_RECT_F source);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=7E94DC
    // Broiler-Falsified-If: PushAxisAlignedClipProc is not slot 45 of ID2D1RenderTarget, void PushAxisAlignedClip(CONST D2D1_RECT_F *clipRect, D2D1_ANTIALIAS_MODE antialiasMode) in d2d1.h, whose clipRect points at a 16-byte D2D1_RECT_F
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void PushAxisAlignedClipProc(IntPtr self, in D2DNative.D2D1_RECT_F clipRect, D2DNative.D2D1_ANTIALIAS_MODE antialiasMode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=F1D399
    // Broiler-Falsified-If: PopAxisAlignedClipProc is not slot 46 of ID2D1RenderTarget, void PopAxisAlignedClip() in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void PopAxisAlignedClipProc(IntPtr self);
}
