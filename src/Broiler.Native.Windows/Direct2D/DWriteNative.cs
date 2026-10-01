// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   19
// Annotated:        19/19
// Exempt:           25
// Human-reviewed:   0/19
// IP risk:          Low
// Security risk:    Critical
// Criteria:         19/14
// Resource impact:  2/10 max
// Unverified:       19
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

/// <summary>
/// DirectWrite interface IDs and enums needed to create a factory and text formats.
/// </summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=564421
// Broiler-Falsified-If: a slot constant here differs from its dwrite.h vtable index (GetString 8, CreateTextLayout 18), so ComVtable.Method hands a caller buffer and length to a native method with a different parameter list
// Broiler-Human:        PENDING
public static class DWriteNative
{
    // ---- Interface IIDs --------------------------------------------------------------------------

    /// <summary>IID_IDWriteFactory.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=581012
    // Broiler-Falsified-If: DWriteCreateFactory called with this IID returns an object whose slots 3, 15 and 18 are not GetSystemFontCollection, CreateTextFormat and CreateTextLayout
    // Broiler-Human:        PENDING
    public static readonly Guid IID_IDWriteFactory = new("b859ee5a-d838-4b5b-a2e8-1adc7d93db48");

    // ---- Vtable slots ----------------------------------------------------------------------------

    /// <summary>IDWriteFactory::GetSystemFontCollection.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=0F85FF
    // Broiler-Falsified-If: slot 3 of an IDWriteFactory vtable is not GetSystemFontCollection, so the out collection pointer and BOOL argument are handed to another method
    // Broiler-Human:        PENDING
    public const int VtblGetSystemFontCollection = 3;

    /// <summary>IDWriteFontCollection::GetFontFamilyCount.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=A76FAF
    // Broiler-Falsified-If: slot 3 of an IDWriteFontCollection vtable is not GetFontFamilyCount, so the count that bounds GetFontFamily indices comes from an unrelated method
    // Broiler-Human:        PENDING
    public const int VtblGetFontFamilyCount = 3;

    /// <summary>IDWriteFontCollection::GetFontFamily.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=9B8BB8
    // Broiler-Falsified-If: slot 4 of an IDWriteFontCollection vtable is not GetFontFamily, so the pointer later indexed with IDWriteFontFamily slots is not a font family
    // Broiler-Human:        PENDING
    public const int VtblGetFontFamily = 4;

    /// <summary>IDWriteFontFamily::GetFamilyNames, after the five slots it inherits from IDWriteFontList.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=00AE41
    // Broiler-Falsified-If: slot 6 of an IDWriteFontFamily vtable, the first after IUnknown and the three IDWriteFontList methods, is not GetFamilyNames, so the pointer used as IDWriteLocalizedStrings is another interface
    // Broiler-Human:        PENDING
    public const int VtblGetFamilyNames = 6;

    /// <summary>IDWriteLocalizedStrings::FindLocaleName.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=DAD018
    // Broiler-Falsified-If: slot 4 of an IDWriteLocalizedStrings vtable is not FindLocaleName, so the locale string and the index and BOOL out-parameters reach another method
    // Broiler-Human:        PENDING
    public const int VtblFindLocaleName = 4;

    /// <summary>IDWriteLocalizedStrings::GetStringLength.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=F2CBFC
    // Broiler-Falsified-If: slot 7 of an IDWriteLocalizedStrings vtable is not GetStringLength, so the length that sizes the GetString buffer comes from another method
    // Broiler-Human:        PENDING
    public const int VtblGetStringLength = 7;

    /// <summary>IDWriteLocalizedStrings::GetString.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=58CFD4
    // Broiler-Falsified-If: slot 8 of an IDWriteLocalizedStrings vtable is not GetString, so the caller buffer and its size reach a method that writes a different amount into it
    // Broiler-Human:        PENDING
    public const int VtblGetString = 8;

    /// <summary>IDWriteFactory::CreateTextFormat.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=AB06DE
    // Broiler-Falsified-If: slot 15 of an IDWriteFactory vtable is not CreateTextFormat, so the family-name and locale pointers and the font enums are read by another method
    // Broiler-Human:        PENDING
    public const int VtblCreateTextFormat = 15;

    /// <summary>IDWriteFactory::CreateTextLayout.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=45DAEA
    // Broiler-Falsified-If: slot 18 of an IDWriteFactory vtable is not CreateTextLayout, so the text pointer and caller-supplied length reach a method with a different parameter list
    // Broiler-Human:        PENDING
    public const int VtblCreateTextLayout = 18;

    /// <summary>IDWriteTextLayout::GetMetrics.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=EA1B94
    // Broiler-Falsified-If: slot 60 of an IDWriteTextLayout vtable is not GetMetrics but a neighbour such as GetLineMetrics, so the DWRITE_TEXT_METRICS out buffer receives a different structure
    // Broiler-Human:        PENDING
    public const int VtblGetMetrics = 60;

    // ---- Enums -----------------------------------------------------------------------------------

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=91544C
    // Broiler-Falsified-If: SHARED or ISOLATED differs from the 0 and 1 dwrite.h defines, so DWriteCreateFactory creates the other kind of factory or fails with E_INVALIDARG
    // Broiler-Human:        PENDING
    public enum DWRITE_FACTORY_TYPE : uint
    {
        SHARED = 0,
        ISOLATED = 1,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=EAFC54
    // Broiler-Falsified-If: a member differs from its dwrite.h weight (THIN 100 through BLACK 900), so CreateTextFormat selects a lighter or heavier face than the caller asked for
    // Broiler-Human:        PENDING
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

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=104D70
    // Broiler-Falsified-If: NORMAL, OBLIQUE or ITALIC differs from the 0, 1 and 2 dwrite.h defines, so CreateTextFormat selects or synthesizes the wrong slant
    // Broiler-Human:        PENDING
    public enum DWRITE_FONT_STYLE : uint
    {
        NORMAL = 0,
        OBLIQUE = 1,
        ITALIC = 2,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=5E30C9
    // Broiler-Falsified-If: NORMAL is not 5 as dwrite.h defines, so CreateTextFormat selects a condensed or expanded face or rejects the undefined value 0
    // Broiler-Human:        PENDING
    public enum DWRITE_FONT_STRETCH : uint
    {
        NORMAL = 5,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=92FDEF
    // Broiler-Falsified-If: NATURAL, GDI_CLASSIC or GDI_NATURAL differs from the 0, 1 and 2 dwrite.h defines, so DrawText places glyphs with a different measuring mode than the text was measured in
    // Broiler-Human:        PENDING
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
