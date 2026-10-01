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
// Broiler-Falsified-If: a DrawTextProc call with textLength greater than text.Length makes ID2D1RenderTarget::DrawText read UTF-16 units past the marshalled string
// Broiler-Human:        PENDING
public static class Direct2DRendererApi
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=19DEFC
    // Broiler-Falsified-If: BeginDraw is declared with a return value or a parameter beyond self, so a 32-bit stdcall call leaves the stack unbalanced by the extra bytes
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void BeginDrawProc(IntPtr self);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=908727
    // Broiler-Falsified-If: tag1 or tag2 is neither null nor a pointer to an 8-byte D2D1_TAG, so EndDraw writes its UINT64 tags into smaller or unrelated memory
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int EndDrawProc(IntPtr self, IntPtr tag1, IntPtr tag2);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=AE36CF
    // Broiler-Falsified-If: the color is passed by value instead of as a pointer to a 16-byte D2D1_COLOR_F, so Clear dereferences the colour components as an address
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void ClearProc(IntPtr self, in D2DNative.D2D1_COLOR_F color);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=DF1DCC
    // Broiler-Falsified-If: the mode is not marshalled as the 32-bit D2D1_ANTIALIAS_MODE enum, so the value Direct2D reads carries bits the caller never set
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetAntialiasModeProc(IntPtr self, D2DNative.D2D1_ANTIALIAS_MODE antialiasMode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=0D0E8D
    // Broiler-Falsified-If: the mode is not marshalled as the 32-bit D2D1_TEXT_ANTIALIAS_MODE enum, so the value Direct2D reads carries bits the caller never set
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetTextAntialiasModeProc(IntPtr self, D2DNative.D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=698448
    // Broiler-Falsified-If: the matrix is passed by value instead of as a pointer to a 24-byte D2D1_MATRIX_3X2_F, so SetTransform reads its six floats from an address formed from matrix contents
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetTransformProc(IntPtr self, in D2DNative.D2D1_MATRIX_3X2_F transform);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=E7E385
    // Broiler-Falsified-If: a non-null brushProperties points at fewer than the 28 bytes of D2D1_BRUSH_PROPERTIES, so CreateSolidColorBrush reads opacity and transform past the caller buffer
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateSolidColorBrushProc(IntPtr self, in D2DNative.D2D1_COLOR_F color, IntPtr brushProperties,
        out IntPtr solidColorBrush);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=824F30
    // Broiler-Falsified-If: the rectangle is passed by value instead of as a pointer to a 16-byte D2D1_RECT_F, so FillRectangle dereferences the left and top coordinates as an address
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void FillRectangleProc(IntPtr self, in D2DNative.D2D1_RECT_F rect, IntPtr brush);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=7F9457
    // Broiler-Falsified-If: the ID2D1Factory written to factory carries a reference the caller never releases, so each call leaks one factory reference
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GetFactoryProc(IntPtr self, out IntPtr factory);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=263E64
    // Broiler-Falsified-If: the ID2D1PathGeometry written to pathGeometry is not released once per successful call, leaking a geometry per drawn shape
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreatePathGeometryProc(IntPtr self, out IntPtr pathGeometry);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=F267E0
    // Broiler-Falsified-If: the ID2D1GeometrySink written to sink is not released after Close, leaking a sink per opened geometry
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PathGeometryOpenProc(IntPtr self, out IntPtr sink);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=EA5E6B
    // Broiler-Falsified-If: the fill mode is not marshalled as the 32-bit D2D1_FILL_MODE enum, so the value Direct2D reads carries bits the caller never set
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GeometrySinkSetFillModeProc(IntPtr self, D2DNative.D2D1_FILL_MODE fillMode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=112802
    // Broiler-Falsified-If: startPoint is passed as a pointer instead of the 8-byte D2D1_POINT_2F by value, so BeginFigure starts the figure at coordinates taken from an address
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GeometrySinkBeginFigureProc(IntPtr self,
        D2DNative.D2D1_POINT_2F startPoint, D2DNative.D2D1_FIGURE_BEGIN figureBegin);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=1D7738
    // Broiler-Falsified-If: a call with pointsCount greater than points.Length makes AddLines read D2D1_POINT_2F values past the end of the marshalled array
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GeometrySinkAddLinesProc(IntPtr self, [In] D2DNative.D2D1_POINT_2F[] points, uint pointsCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B50897
    // Broiler-Falsified-If: the figure end is not marshalled as the 32-bit D2D1_FIGURE_END enum, so the value Direct2D reads carries bits the caller never set
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GeometrySinkEndFigureProc(IntPtr self, D2DNative.D2D1_FIGURE_END figureEnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=610C3C
    // Broiler-Falsified-If: Close is declared returning void, so its failure HRESULT is lost and an unclosed geometry reaches FillGeometry
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GeometrySinkCloseProc(IntPtr self);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=A97749
    // Broiler-Falsified-If: geometry or brush comes from a different ID2D1Factory than the render target, so the frame fails at EndDraw with D2DERR_WRONG_FACTORY
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void FillGeometryProc(IntPtr self, IntPtr geometry, IntPtr brush, IntPtr opacityBrush);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=3980C2
    // Broiler-Falsified-If: strokeWidth is not marshalled as a 32-bit float after the brush pointer, so DrawRectangle strokes with a width reinterpreted from other bits
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void DrawRectangleProc(IntPtr self, in D2DNative.D2D1_RECT_F rect,
        IntPtr brush, float strokeWidth, IntPtr strokeStyle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=53C94F
    // Broiler-Falsified-If: the rounded rectangle is not passed as a pointer to a 24-byte D2D1_ROUNDED_RECT with the radii after the rectangle, so the radii are read from the wrong offsets
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void FillRoundedRectangleProc(IntPtr self, in D2DNative.D2D1_ROUNDED_RECT roundedRect, IntPtr brush);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=5F1379
    // Broiler-Falsified-If: strokeWidth is not marshalled as a 32-bit float after the brush pointer, so DrawRoundedRectangle strokes with a width reinterpreted from other bits
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void DrawRoundedRectangleProc(IntPtr self, in D2DNative.D2D1_ROUNDED_RECT roundedRect, IntPtr brush,
        float strokeWidth, IntPtr strokeStyle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=B0981C
    // Broiler-Falsified-If: a call with textLength greater than text.Length makes DrawText read UTF-16 code units past the end of the marshalled string
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate void DrawTextProc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string text, uint textLength, IntPtr textFormat,
        in D2DNative.D2D1_RECT_F layoutRect, IntPtr brush, D2DNative.D2D1_DRAW_TEXT_OPTIONS options, DWriteNative.DWRITE_MEASURING_MODE measuringMode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=B19583
    // Broiler-Falsified-If: opacity is not marshalled as a 32-bit float between the destination pointer and the interpolation mode, so DrawBitmap draws with an opacity reinterpreted from other bits
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void DrawBitmapProc(IntPtr self, IntPtr bitmap, in D2DNative.D2D1_RECT_F destination, float opacity, uint interpolation,
        in D2DNative.D2D1_RECT_F source);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=7E94DC
    // Broiler-Falsified-If: a PushAxisAlignedClip is not matched by exactly one PopAxisAlignedClip before EndDraw, so EndDraw returns D2DERR_PUSH_POP_UNBALANCED
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void PushAxisAlignedClipProc(IntPtr self, in D2DNative.D2D1_RECT_F clipRect, D2DNative.D2D1_ANTIALIAS_MODE antialiasMode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=F1D399
    // Broiler-Falsified-If: a PopAxisAlignedClip with no matching PushAxisAlignedClip leaves the target unbalanced, so EndDraw returns D2DERR_PUSH_POP_UNBALANCED
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void PopAxisAlignedClipProc(IntPtr self);
}
