// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   3
// Annotated:        3/3
// Exempt:           41
// Human-reviewed:   0/3
// IP risk:          Low
// Security risk:    High
// Criteria:         3/3
// Resource impact:  2/10 max
// Unverified:       3
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

/// <summary>
/// DirectWrite interface IDs and enums needed to create a factory and text formats.
/// </summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=564421
// Broiler-Falsified-If: a structure here is not laid out as in dwrite.h, for example DWRITE_TEXT_METRICS not being the 36 bytes IDWriteTextLayout::GetMetrics writes, so the measured sizes and LineCount are read from the wrong bytes
// Broiler-Human:        PENDING
public static class DWriteNative
{
    // ---- Interface IIDs --------------------------------------------------------------------------

    /// <summary>IID_IDWriteFactory.</summary>
    public static readonly Guid IID_IDWriteFactory = new("b859ee5a-d838-4b5b-a2e8-1adc7d93db48");

    // ---- Vtable slots ----------------------------------------------------------------------------

    /// <summary>IDWriteFactory::GetSystemFontCollection.</summary>
    public const int VtblGetSystemFontCollection = 3;

    /// <summary>IDWriteFontCollection::GetFontFamilyCount.</summary>
    public const int VtblGetFontFamilyCount = 3;

    /// <summary>IDWriteFontCollection::GetFontFamily.</summary>
    public const int VtblGetFontFamily = 4;

    /// <summary>IDWriteFontFamily::GetFamilyNames, after the five slots it inherits from IDWriteFontList.</summary>
    public const int VtblGetFamilyNames = 6;

    /// <summary>IDWriteLocalizedStrings::FindLocaleName.</summary>
    public const int VtblFindLocaleName = 4;

    /// <summary>IDWriteLocalizedStrings::GetStringLength.</summary>
    public const int VtblGetStringLength = 7;

    /// <summary>IDWriteLocalizedStrings::GetString.</summary>
    public const int VtblGetString = 8;

    /// <summary>IDWriteFactory::CreateTextFormat.</summary>
    public const int VtblCreateTextFormat = 15;

    /// <summary>IDWriteFactory::CreateTextLayout.</summary>
    public const int VtblCreateTextLayout = 18;

    /// <summary>IDWriteTextLayout::GetMetrics.</summary>
    public const int VtblGetMetrics = 60;

    // ---- Enums -----------------------------------------------------------------------------------

    public enum DWRITE_FACTORY_TYPE : uint
    {
        SHARED = 0,
        ISOLATED = 1,
    }

    public enum DWRITE_FONT_WEIGHT : uint
    {
        THIN = 100,
        LIGHT = 300,
        NORMAL = 400,
        MEDIUM = 500,
        SEMI_BOLD = 600,
        BOLD = 700,
        BLACK = 900,
    }

    public enum DWRITE_FONT_STYLE : uint
    {
        NORMAL = 0,
        OBLIQUE = 1,
        ITALIC = 2,
    }

    public enum DWRITE_FONT_STRETCH : uint
    {
        NORMAL = 5,
    }

    public enum DWRITE_MEASURING_MODE : uint
    {
        NATURAL = 0,
        GDI_CLASSIC = 1,
        GDI_NATURAL = 2,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=71E01C
    // Broiler-Falsified-If: Marshal.SizeOf is not the 36 bytes IDWriteTextLayout::GetMetrics writes, or LineCount is not at offset 32 after seven floats and MaxBidiReorderingDepth
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_TEXT_METRICS
    {
        public float Left;
        public float Top;
        public float Width;
        public float WidthIncludingTrailingWhitespace;
        public float Height;
        public float LayoutWidth;
        public float LayoutHeight;
        public uint MaxBidiReorderingDepth;
        public uint LineCount;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=3000F3
    // Broiler-Falsified-If: fontFamilyName or localeName is marshalled as ANSI instead of NUL-terminated UTF-16, so a non-ASCII page-supplied family name reaches CreateTextFormat mangled
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate int CreateTextFormatProc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, IntPtr fontCollection,
        DWriteNative.DWRITE_FONT_WEIGHT fontWeight, DWriteNative.DWRITE_FONT_STYLE fontStyle, DWriteNative.DWRITE_FONT_STRETCH fontStretch,
        float fontSize, [MarshalAs(UnmanagedType.LPWStr)] string localeName, out IntPtr textFormat);
}
