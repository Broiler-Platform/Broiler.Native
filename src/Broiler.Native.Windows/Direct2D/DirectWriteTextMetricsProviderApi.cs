using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

public static class DirectWriteTextMetricsProviderApi
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate int CreateTextFormatProc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName,
        IntPtr fontCollection, DWriteNative.DWRITE_FONT_WEIGHT fontWeight, DWriteNative.DWRITE_FONT_STYLE fontStyle,
        DWriteNative.DWRITE_FONT_STRETCH fontStretch, float fontSize, [MarshalAs(UnmanagedType.LPWStr)] string localeName,
        out IntPtr textFormat);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate int CreateTextLayoutProc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string text, uint textLength,
        IntPtr textFormat, float maxWidth, float maxHeight, out IntPtr textLayout);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetMetricsProc(IntPtr self, out DWriteNative.DWRITE_TEXT_METRICS metrics);
}
