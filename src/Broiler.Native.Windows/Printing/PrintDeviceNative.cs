// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   13
// Annotated:        13/13
// Exempt:           58
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

namespace Broiler.Native.Windows.Printing;

/// <summary>
/// A printer device context (gdi32): open one on a printer, run a document of pages through
/// it, and draw device-independent bitmaps onto each page.
/// </summary>
/// <remarks>
/// The device's own geometry - its resolution, the physical sheet and where the printable
/// area starts on it - comes from <see cref="WindowNative.GetDeviceCaps"/> with the indexes
/// declared here; that import is owned by <see cref="WindowNative"/> and not repeated.
/// </remarks>
// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=7D93A1
// Broiler-Falsified-If: a binding below differs from its wingdi.h prototype, or a DC from CreateDCW reaches no DeleteDC
// Broiler-Human:        PENDING
public static partial class PrintDeviceNative
{
    public const int HORZRES = 8;
    public const int VERTRES = 10;
    public const int LOGPIXELSX = 88;
    public const int LOGPIXELSY = 90;
    public const int PHYSICALWIDTH = 110;
    public const int PHYSICALHEIGHT = 111;
    public const int PHYSICALOFFSETX = 112;
    public const int PHYSICALOFFSETY = 113;

    public const int SP_ERROR = -1;
    public const int GDI_ERROR = -1;

    public const uint DIB_RGB_COLORS = 0;
    public const uint SRCCOPY = 0x00CC0020;
    public const uint BI_RGB = 0;

    public const int HALFTONE = 4;
    public const int COLORONCOLOR = 3;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=795966
    // Broiler-Falsified-If: differs from HDC CreateDCW(LPCWSTR pwszDriver, LPCWSTR pwszDevice, LPCWSTR pszPort, const DEVMODEW *pdm) in wingdi.h, or pdm is not NULL and not a DEVMODEW the printer's driver produced at the size DocumentPropertiesW reported
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", EntryPoint = "CreateDCW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    public static partial IntPtr CreateDC(string? driver, string device, string? port, IntPtr devMode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=767842
    // Broiler-Falsified-If: differs from BOOL DeleteDC(HDC hdc) in wingdi.h, or a DC is deleted twice
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DeleteDC(IntPtr hdc);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=CF9414
    // Broiler-Falsified-If: differs from int StartDocW(HDC hdc, const DOCINFOW *lpdi) in wingdi.h, or the strings DOCINFOW points to are freed before the call returns
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", EntryPoint = "StartDocW", SetLastError = true)]
    public static partial int StartDoc(IntPtr hdc, in DOCINFOW docInfo);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=9F565D
    // Broiler-Falsified-If: differs from int EndDoc(HDC hdc) in wingdi.h
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", SetLastError = true)]
    public static partial int EndDoc(IntPtr hdc);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=F1ABA4
    // Broiler-Falsified-If: differs from int AbortDoc(HDC hdc) in wingdi.h
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", SetLastError = true)]
    public static partial int AbortDoc(IntPtr hdc);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=00D264
    // Broiler-Falsified-If: differs from int StartPage(HDC hdc) in wingdi.h
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", SetLastError = true)]
    public static partial int StartPage(IntPtr hdc);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C69AB4
    // Broiler-Falsified-If: differs from int EndPage(HDC hdc) in wingdi.h
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", SetLastError = true)]
    public static partial int EndPage(IntPtr hdc);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=3D9BA0
    // Broiler-Falsified-If: differs from int StretchDIBits(HDC hdc, int xDest, int yDest, int DestWidth, int DestHeight, int xSrc, int ySrc, int SrcWidth, int SrcHeight, const VOID *lpBits, const BITMAPINFO *lpbmi, UINT iUsage, DWORD rop) in wingdi.h, where passing only the 40-byte BITMAPINFOHEADER holds only for 32 bits per pixel BI_RGB, or bits holds fewer than abs(biHeight) rows of biWidth * 4 bytes
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", SetLastError = true)]
    public static unsafe partial int StretchDIBits(IntPtr hdc, int xDest, int yDest, int destWidth, int destHeight,
        int xSource, int ySource, int sourceWidth, int sourceHeight, byte* bits, in WindowNative.BITMAPINFOHEADER header,
        uint usage, uint rasterOperation);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=27CA80
    // Broiler-Falsified-If: differs from int SetStretchBltMode(HDC hdc, int mode) in wingdi.h
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", SetLastError = true)]
    public static partial int SetStretchBltMode(IntPtr hdc, int mode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=69DC6D
    // Broiler-Falsified-If: differs from BOOL SetBrushOrgEx(HDC hdc, int x, int y, LPPOINT lppt) in wingdi.h with lppt passed NULL
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SetBrushOrgEx(IntPtr hdc, int x, int y, IntPtr previous);
}

/// <summary>
/// DOCINFOW: a print document's name, an optional output file that replaces the printer's
/// port, and the data type. Strings are native UTF-16 pointers the caller keeps alive for
/// the <see cref="PrintDeviceNative.StartDoc"/> call.
/// </summary>
// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=001F3D
// Broiler-Falsified-If: Marshal.SizeOf is not 40 on 64-bit and 20 on 32-bit, with lpszDocName at one pointer (after cbSize and its padding), lpszOutput at two, lpszDatatype at three and fwType after it, the layout of DOCINFOW in wingdi.h
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct DOCINFOW
{
    public int Size;
    public IntPtr DocumentName;
    public IntPtr Output;
    public IntPtr DataType;
    public uint Type;
}

/// <summary>
/// The public part of DEVMODEW, as an overlay on the front of the buffer a printer driver
/// fills: the driver's private bytes (<see cref="DriverExtra"/> of them) follow
/// <see cref="Size"/> bytes in, so a device mode is always handled as the driver's buffer
/// and never copied into this struct alone.
/// </summary>
// Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=2E053C
// Broiler-Falsified-If: Marshal.SizeOf is not 220, or dmSize is not at 68, dmFields at 72, dmOrientation at 76, dmPaperSize at 78, dmCopies at 86, dmPrintQuality at 90, dmColor at 92, dmDuplex at 94, dmYResolution at 96 and dmCollate at 100, the printer layout of DEVMODEW in wingdi.h
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Explicit, Size = 220, CharSet = CharSet.Unicode)]
public struct DEVMODEW
{
    public const int DeviceNameLength = 32;

    public const uint DM_ORIENTATION = 0x00000001;
    public const uint DM_PAPERSIZE = 0x00000002;
    public const uint DM_PAPERLENGTH = 0x00000004;
    public const uint DM_PAPERWIDTH = 0x00000008;
    public const uint DM_COPIES = 0x00000100;
    public const uint DM_PRINTQUALITY = 0x00000400;
    public const uint DM_COLOR = 0x00000800;
    public const uint DM_DUPLEX = 0x00001000;
    public const uint DM_YRESOLUTION = 0x00002000;
    public const uint DM_COLLATE = 0x00008000;

    public const short DMORIENT_PORTRAIT = 1;
    public const short DMORIENT_LANDSCAPE = 2;
    public const short DMCOLOR_MONOCHROME = 1;
    public const short DMCOLOR_COLOR = 2;
    public const short DMDUP_SIMPLEX = 1;
    public const short DMDUP_VERTICAL = 2;
    public const short DMDUP_HORIZONTAL = 3;
    public const short DMCOLLATE_FALSE = 0;
    public const short DMCOLLATE_TRUE = 1;

    [FieldOffset(64)] public ushort SpecVersion;
    [FieldOffset(66)] public ushort DriverVersion;
    [FieldOffset(68)] public ushort Size;
    [FieldOffset(70)] public ushort DriverExtra;
    [FieldOffset(72)] public uint Fields;
    [FieldOffset(76)] public short Orientation;
    [FieldOffset(78)] public short PaperSize;
    [FieldOffset(80)] public short PaperLength;
    [FieldOffset(82)] public short PaperWidth;
    [FieldOffset(84)] public short Scale;
    [FieldOffset(86)] public short Copies;
    [FieldOffset(88)] public short DefaultSource;
    [FieldOffset(90)] public short PrintQuality;
    [FieldOffset(92)] public short Color;
    [FieldOffset(94)] public short Duplex;
    [FieldOffset(96)] public short YResolution;
    [FieldOffset(98)] public short TrueTypeOption;
    [FieldOffset(100)] public short Collate;
}
