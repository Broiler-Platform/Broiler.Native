// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   8
// Annotated:        8/8
// Exempt:           21
// Human-reviewed:   0/8
// IP risk:          Low
// Security risk:    Critical
// Criteria:         8/8
// Resource impact:  1/10 max
// Unverified:       8
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Printing;

/// <summary>
/// The print spooler (winspool.drv): the printers a user can reach, the default printer,
/// and a printer's device mode and capabilities.
/// </summary>
/// <remarks>
/// Every buffer here is sized by asking first: each function reports the size it needs when
/// given none, and the caller allocates exactly that. A printer can change between the two
/// calls, so a caller must treat a second failure as an answer, not retry forever.
/// </remarks>
// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=AC3395
// Broiler-Falsified-If: a binding below differs from its winspool.h prototype, or a caller sizes a buffer from a count other than the pcbNeeded or return value the previous call reported
// Broiler-Human:        PENDING
public static partial class PrintSpoolerNative
{
    public const uint PRINTER_ENUM_LOCAL = 0x00000002;
    public const uint PRINTER_ENUM_CONNECTIONS = 0x00000004;

    public const uint PRINTER_ATTRIBUTE_NETWORK = 0x00000010;

    public const uint DM_OUT_BUFFER = 2;
    public const uint DM_IN_PROMPT = 4;
    public const uint DM_IN_BUFFER = 8;

    public const int IDOK = 1;
    public const int IDCANCEL = 2;

    public const ushort DC_PAPERS = 2;
    public const ushort DC_PAPERSIZE = 3;
    public const ushort DC_DUPLEX = 7;
    public const ushort DC_ENUMRESOLUTIONS = 13;
    public const ushort DC_PAPERNAMES = 16;
    public const ushort DC_ORIENTATION = 17;
    public const ushort DC_COPIES = 18;
    public const ushort DC_COLLATE = 22;
    public const ushort DC_COLORDEVICE = 32;

    /// <summary>Characters in one DC_PAPERNAMES entry, terminator included when it fits.</summary>
    public const int PaperNameLength = 64;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=759BB3
    // Broiler-Falsified-If: differs from BOOL EnumPrintersW(DWORD Flags, LPWSTR Name, DWORD Level, LPBYTE pPrinterEnum, DWORD cbBuf, LPDWORD pcbNeeded, LPDWORD pcReturned) in winspool.h, or cbBuf is larger than the buffer pPrinterEnum points to
    // Broiler-Human:        PENDING
    [LibraryImport("winspool.drv", EntryPoint = "EnumPrintersW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool EnumPrinters(uint flags, string? name, uint level, IntPtr printerEnum, uint bufferSize,
        out uint bytesNeeded, out uint returned);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=AD85EE
    // Broiler-Falsified-If: differs from BOOL GetDefaultPrinterW(LPWSTR pszBuffer, LPDWORD pcchBuffer) in winspool.h, where pcchBuffer counts UTF-16 chars including the terminator, or the count passed exceeds the buffer
    // Broiler-Human:        PENDING
    [LibraryImport("winspool.drv", EntryPoint = "GetDefaultPrinterW", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static unsafe partial bool GetDefaultPrinter(char* buffer, ref uint length);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=FAE754
    // Broiler-Falsified-If: differs from BOOL OpenPrinterW(LPWSTR pPrinterName, LPHANDLE phPrinter, LPPRINTER_DEFAULTSW pDefault) in winspool.h with pDefault passed NULL, or an opened handle reaches no ClosePrinter
    // Broiler-Human:        PENDING
    [LibraryImport("winspool.drv", EntryPoint = "OpenPrinterW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool OpenPrinter(string printerName, out IntPtr printer, IntPtr defaults);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=CF9236
    // Broiler-Falsified-If: differs from BOOL ClosePrinter(HANDLE hPrinter) in winspool.h, or a handle is closed twice
    // Broiler-Human:        PENDING
    [LibraryImport("winspool.drv", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ClosePrinter(IntPtr printer);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=EAC497
    // Broiler-Falsified-If: differs from LONG DocumentPropertiesW(HWND hWnd, HANDLE hPrinter, LPWSTR pDeviceName, PDEVMODEW pDevModeOutput, PDEVMODEW pDevModeInput, DWORD fMode) in winspool.h, or with DM_OUT_BUFFER the output buffer is smaller than the size the same call returned with fMode 0
    // Broiler-Human:        PENDING
    [LibraryImport("winspool.drv", EntryPoint = "DocumentPropertiesW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    public static partial int DocumentProperties(IntPtr owner, IntPtr printer, string deviceName, IntPtr devModeOutput,
        IntPtr devModeInput, uint mode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=B3BFBC
    // Broiler-Falsified-If: differs from int DeviceCapabilitiesW(LPCWSTR pDevice, LPCWSTR pPort, WORD fwCapability, LPWSTR pOutput, const DEVMODEW *pDevMode) in winspool.h, or pOutput is smaller than the element count the call returns with pOutput NULL times that capability's element size
    // Broiler-Human:        PENDING
    [LibraryImport("winspool.drv", EntryPoint = "DeviceCapabilitiesW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    public static partial int DeviceCapabilities(string device, string? port, ushort capability, IntPtr output, IntPtr devMode);
}

/// <summary>PRINTER_INFO_4W: a printer's name, its server, and its attributes.</summary>
// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=511DF3
// Broiler-Falsified-If: Marshal.SizeOf is not 24 on 64-bit and 12 on 32-bit, with pPrinterName at 0, pServerName at one pointer and Attributes at two, the layout of PRINTER_INFO_4W in winspool.h
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct PRINTER_INFO_4W
{
    public IntPtr PrinterName;
    public IntPtr ServerName;
    public uint Attributes;
}
