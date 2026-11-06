// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// HAIRS Code Assurance
// --------------------
// Relevant units:   19
// Annotated:        19/19
// Exempt:           79
// Human-reviewed:   0/19
// IP risk:          Low
// Security risk:    Critical
// Criteria:         19/19
// Resource impact:  3/10 max
// Unverified:       19
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Linux.Scanner;

/// <summary>
/// SANE (Scanner Access Now Easy) C API bindings for libsane.so.1 from sane/sane.h.
/// </summary>
// Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=658764
// Hairs-Falsified-If: an import here differs from its prototype in sane/sane.h, where SANE_Handle is void*, SANE_Int and SANE_Word are 32-bit ints, and strings are NUL-terminated UTF-8/ASCII
// Hairs-Human:        PENDING
public static partial class LinuxSaneNative
{
    /// <summary>The soname the imports bind.</summary>
    public const string Library = "libsane.so.1";

    public const int SANE_FALSE = 0;
    public const int SANE_TRUE = 1;
    public const int SANE_FIXED_SCALE_SHIFT = 16;

    // Option capability bits (sane/sane.h)
    public const int SANE_CAP_SOFT_SELECT = 1 << 0;
    public const int SANE_CAP_HARD_SELECT = 1 << 1;
    public const int SANE_CAP_SOFT_DETECT = 1 << 2;
    public const int SANE_CAP_EMULATED = 1 << 3;
    public const int SANE_CAP_AUTOMATIC = 1 << 4;
    public const int SANE_CAP_INACTIVE = 1 << 5;
    public const int SANE_CAP_ADVANCED = 1 << 6;

    // Control option info bits (sane/sane.h)
    public const int SANE_INFO_INEXACT = 1 << 0;
    public const int SANE_INFO_RELOAD_OPTIONS = 1 << 1;
    public const int SANE_INFO_RELOAD_PARAMS = 1 << 2;

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=2E4C7A
    // Hairs-Falsified-If: differs from SANE_Status sane_init(SANE_Int *version_code, SANE_Auth_Callback authorize) in sane/sane.h
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_init")]
    public static partial SaneStatus Init(out int versionCode, IntPtr authorizeCallback);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=5E3FAC
    // Hairs-Falsified-If: differs from void sane_exit(void) in sane/sane.h
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_exit")]
    public static partial void Exit();

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=5B8510
    // Hairs-Falsified-If: differs from SANE_Status sane_get_devices(const SANE_Device ***device_list, SANE_Bool local_only) in sane/sane.h, or the returned pointer-to-NULL-terminated-array is freed by the caller instead of remaining owned by libsane until sane_exit or the next sane_get_devices
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_get_devices")]
    public static partial SaneStatus GetDevices(out IntPtr deviceList, int localOnly);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=D60CA4
    // Hairs-Falsified-If: differs from SANE_Status sane_open(SANE_String_Const devicename, SANE_Handle *handle) in sane/sane.h, or an opened handle is not closed with sane_close
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_open", StringMarshalling = StringMarshalling.Utf8)]
    public static partial SaneStatus Open(string deviceName, out IntPtr handle);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D0FD2E
    // Hairs-Falsified-If: differs from void sane_close(SANE_Handle handle) in sane/sane.h
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_close")]
    public static partial void Close(IntPtr handle);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=8A7DF8
    // Hairs-Falsified-If: differs from const SANE_Option_Descriptor *sane_get_option_descriptor(SANE_Handle handle, SANE_Int option) in sane/sane.h, or the returned descriptor pointer is freed by the caller
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_get_option_descriptor")]
    public static partial IntPtr GetOptionDescriptor(IntPtr handle, int option);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=FBCA1B
    // Hairs-Falsified-If: differs from SANE_Status sane_control_option(SANE_Handle handle, SANE_Int option, SANE_Action action, void *value, SANE_Int *info) in sane/sane.h, or value points to fewer bytes than the option descriptor's size
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_control_option")]
    public static partial SaneStatus ControlOption(IntPtr handle, int option, SaneAction action, IntPtr value, out int info);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=2CEE03
    // Hairs-Falsified-If: differs from SANE_Status sane_get_parameters(SANE_Handle handle, SANE_Parameters *params) in sane/sane.h, or SaneParameters is not the 24-byte layout of SANE_Parameters
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_get_parameters")]
    public static partial SaneStatus GetParameters(IntPtr handle, out SaneParameters parameters);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=829A58
    // Hairs-Falsified-If: differs from SANE_Status sane_start(SANE_Handle handle) in sane/sane.h
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_start")]
    public static partial SaneStatus Start(IntPtr handle);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=65EF3B
    // Hairs-Falsified-If: differs from SANE_Status sane_read(SANE_Handle handle, SANE_Byte *data, SANE_Int max_length, SANE_Int *length) in sane/sane.h, which writes up to maxLength bytes at data
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_read")]
    public static partial SaneStatus Read(IntPtr handle, IntPtr data, int maxLength, out int length);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=277AF1
    // Hairs-Falsified-If: differs from void sane_cancel(SANE_Handle handle) in sane/sane.h
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_cancel")]
    public static partial void Cancel(IntPtr handle);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0F2862
    // Hairs-Falsified-If: differs from SANE_Status sane_set_io_mode(SANE_Handle handle, SANE_Bool non_blocking) in sane/sane.h
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_set_io_mode")]
    public static partial SaneStatus SetIoMode(IntPtr handle, int nonBlocking);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=F1429F
    // Hairs-Falsified-If: differs from SANE_Status sane_get_select_fd(SANE_Handle handle, SANE_Int *fd) in sane/sane.h
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_get_select_fd")]
    public static partial SaneStatus GetSelectFd(IntPtr handle, out int fd);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=018DED
    // Hairs-Falsified-If: differs from SANE_String_Const sane_strstatus(SANE_Status status) in sane/sane.h, or the returned static string pointer is freed
    // Hairs-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "sane_strstatus")]
    public static partial IntPtr StrStatus(SaneStatus status);
}

public enum SaneStatus
{
    Good = 0,
    Unsupported = 1,
    Cancelled = 2,
    DeviceBusy = 3,
    Invalid = 4,
    Eof = 5,
    Jammed = 6,
    NoDocs = 7,
    CoverOpen = 8,
    IoError = 9,
    NoMem = 10,
    AccessDenied = 11,
}

public enum SaneValueType
{
    Bool = 0,
    Int = 1,
    Fixed = 2,
    String = 3,
    Button = 4,
    Group = 5,
}

public enum SaneUnit
{
    None = 0,
    Pixel = 1,
    Bit = 2,
    Mm = 3,
    Dpi = 4,
    Percent = 5,
    Microsecond = 6,
}

public enum SaneAction
{
    GetValue = 0,
    SetValue = 1,
    SetAuto = 2,
}

public enum SaneFrame
{
    Gray = 0,
    Rgb = 1,
    Red = 2,
    Green = 3,
    Blue = 4,
}

public enum SaneConstraintType
{
    None = 0,
    Range = 1,
    WordList = 2,
    StringList = 3,
}

/// <summary>SANE_Device in sane/sane.h: four const char* fields (name, vendor, model, type).</summary>
// Hairs-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=F8B3E3
// Hairs-Falsified-If: Marshal.SizeOf of SaneDevice is not 32 on 64-bit and 16 on 32-bit, with Name, Vendor, Model and Type at pointer-sized offsets, the layout of SANE_Device in sane/sane.h
// Hairs-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct SaneDevice
{
    public IntPtr Name;
    public IntPtr Vendor;
    public IntPtr Model;
    public IntPtr Type;
}

/// <summary>SANE_Option_Descriptor in sane/sane.h.</summary>
// Hairs-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=620ED8
// Hairs-Falsified-If: Marshal.SizeOf of SaneOptionDescriptor is not 56 on 64-bit and 36 on 32-bit, or Marshal.OffsetOf Constraint is not 48 on 64-bit, the layout of SANE_Option_Descriptor in sane/sane.h
// Hairs-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct SaneOptionDescriptor
{
    public IntPtr Name;
    public IntPtr Title;
    public IntPtr Desc;
    public SaneValueType Type;
    public SaneUnit Unit;
    public int Size;
    public int Cap;
    public SaneConstraintType ConstraintType;
    public IntPtr Constraint;
}

/// <summary>SANE_Range in sane/sane.h: min, max, and quantization step.</summary>
// Hairs-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=32D872
// Hairs-Falsified-If: Marshal.SizeOf of SaneRange is not 12, the layout of SANE_Range (SANE_Word min, SANE_Word max, SANE_Word quant) in sane/sane.h
// Hairs-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct SaneRange
{
    public int Min;
    public int Max;
    public int Quant;
}

/// <summary>SANE_Parameters in sane/sane.h: frame format, last_frame flag, geometry, and bit depth.</summary>
// Hairs-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=38DAE8
// Hairs-Falsified-If: Marshal.SizeOf of SaneParameters is not 24, with Format at 0 through Depth at 20, the layout of SANE_Parameters in sane/sane.h
// Hairs-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct SaneParameters
{
    public SaneFrame Format;
    public int LastFrame;
    public int BytesPerLine;
    public int PixelsPerLine;
    public int Lines;
    public int Depth;
}
