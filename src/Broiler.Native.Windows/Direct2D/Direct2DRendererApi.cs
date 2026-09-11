using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

public static class Direct2DRendererApi
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void BeginDrawProc(IntPtr self);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int EndDrawProc(IntPtr self, IntPtr tag1, IntPtr tag2);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void ClearProc(IntPtr self, in D2DNative.D2D1_COLOR_F color);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetAntialiasModeProc(IntPtr self, D2DNative.D2D1_ANTIALIAS_MODE antialiasMode);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetTextAntialiasModeProc(IntPtr self, D2DNative.D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SetTransformProc(IntPtr self, in D2DNative.D2D1_MATRIX_3X2_F transform);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateSolidColorBrushProc(
        IntPtr self,
        in D2DNative.D2D1_COLOR_F color,
        IntPtr brushProperties,
        out IntPtr solidColorBrush);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void FillRectangleProc(IntPtr self, in D2DNative.D2D1_RECT_F rect, IntPtr brush);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GetFactoryProc(IntPtr self, out IntPtr factory);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreatePathGeometryProc(IntPtr self, out IntPtr pathGeometry);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PathGeometryOpenProc(IntPtr self, out IntPtr sink);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GeometrySinkSetFillModeProc(IntPtr self, D2DNative.D2D1_FILL_MODE fillMode);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GeometrySinkBeginFigureProc(
        IntPtr self,
        D2DNative.D2D1_POINT_2F startPoint,
        D2DNative.D2D1_FIGURE_BEGIN figureBegin);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GeometrySinkAddLinesProc(
        IntPtr self,
        [In] D2DNative.D2D1_POINT_2F[] points,
        uint pointsCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GeometrySinkEndFigureProc(IntPtr self, D2DNative.D2D1_FIGURE_END figureEnd);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GeometrySinkCloseProc(IntPtr self);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void FillGeometryProc(IntPtr self, IntPtr geometry, IntPtr brush, IntPtr opacityBrush);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void DrawRectangleProc(
        IntPtr self,
        in D2DNative.D2D1_RECT_F rect,
        IntPtr brush,
        float strokeWidth,
        IntPtr strokeStyle);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void FillRoundedRectangleProc(
        IntPtr self,
        in D2DNative.D2D1_ROUNDED_RECT roundedRect,
        IntPtr brush);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void DrawRoundedRectangleProc(
        IntPtr self,
        in D2DNative.D2D1_ROUNDED_RECT roundedRect,
        IntPtr brush,
        float strokeWidth,
        IntPtr strokeStyle);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate int CreateTextFormatProc(
        IntPtr self,
        [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName,
        IntPtr fontCollection,
        DWriteNative.DWRITE_FONT_WEIGHT fontWeight,
        DWriteNative.DWRITE_FONT_STYLE fontStyle,
        DWriteNative.DWRITE_FONT_STRETCH fontStretch,
        float fontSize,
        [MarshalAs(UnmanagedType.LPWStr)] string localeName,
        out IntPtr textFormat);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate void DrawTextProc(
        IntPtr self,
        [MarshalAs(UnmanagedType.LPWStr)] string text,
        uint textLength,
        IntPtr textFormat,
        in D2DNative.D2D1_RECT_F layoutRect,
        IntPtr brush,
        D2DNative.D2D1_DRAW_TEXT_OPTIONS options,
        DWriteNative.DWRITE_MEASURING_MODE measuringMode);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void DrawBitmapProc(
        IntPtr self,
        IntPtr bitmap,
        in D2DNative.D2D1_RECT_F destination,
        float opacity,
        uint interpolation,
        in D2DNative.D2D1_RECT_F source);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void PushAxisAlignedClipProc(
        IntPtr self,
        in D2DNative.D2D1_RECT_F clipRect,
        D2DNative.D2D1_ANTIALIAS_MODE antialiasMode);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void PopAxisAlignedClipProc(IntPtr self);
}
