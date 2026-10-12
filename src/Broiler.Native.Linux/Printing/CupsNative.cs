// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   18
// Annotated:        18/18
// Exempt:           19
// Human-reviewed:   0/18
// IP risk:          Low
// Security risk:    Critical
// Criteria:         17/17
// Resource impact:  2/10 max
// Unverified:       18
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Linux.Printing;

/// <summary>
/// The CUPS client library (libcups.so.2): the destinations a user can print to, what media
/// each takes, and submitting a file to one.
/// </summary>
/// <remarks>
/// <para>
/// Every call passes a null connection, which libcups reads as CUPS_HTTP_DEFAULT: the
/// scheduler the user's environment names, through a connection the library opens and
/// keeps per thread. No call here takes a credential.
/// </para>
/// <para>
/// libcups is not part of every Linux image. Probe <see cref="Library"/> with
/// <see cref="NativeLibraryProbe.IsAvailable"/> before the first call; a missing library
/// otherwise surfaces as a <see cref="DllNotFoundException"/> from whichever call came first.
/// </para>
/// </remarks>
// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=C74984
// Broiler-Falsified-If: an import here differs from its prototype in cups/cups.h, where http_t, cups_dest_t, cups_dinfo_t and cups_option_t are passed by pointer and strings are NUL-terminated UTF-8
// Broiler-Human:        PENDING
public static partial class CupsNative
{
    /// <summary>The soname the imports bind.</summary>
    public const string Library = "libcups.so.2";

    public const uint CUPS_MEDIA_FLAGS_DEFAULT = 0x00;
    public const uint CUPS_MEDIA_FLAGS_BORDERLESS = 0x01;
    public const uint CUPS_MEDIA_FLAGS_READY = 0x08;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=1AFC3D
    // Broiler-Falsified-If: differs from int cupsGetDests2(http_t *http, cups_dest_t **dests) in cups/cups.h, or the array it returns reaches no cupsFreeDests with the count it returned
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsGetDests2")]
    public static partial int GetDests(IntPtr http, out IntPtr dests);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=B65EF9
    // Broiler-Falsified-If: differs from void cupsFreeDests(int num_dests, cups_dest_t *dests) in cups/cups.h, or the count passed is not the one cupsGetDests2 returned with that array
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsFreeDests")]
    public static partial void FreeDests(int count, IntPtr dests);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=8EE546
    // Broiler-Falsified-If: differs from const char *cupsGetOption(const char *name, int num_options, cups_option_t *options) in cups/cups.h, or the returned pointer, which the options own, is freed or read after they are
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsGetOption", StringMarshalling = StringMarshalling.Utf8)]
    public static partial IntPtr GetOption(string name, int count, IntPtr options);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=0DC047
    // Broiler-Falsified-If: differs from int cupsAddOption(const char *name, const char *value, int num_options, cups_option_t **options) in cups/cups.h, where the call may reallocate the array, or the array reaches no cupsFreeOptions
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsAddOption", StringMarshalling = StringMarshalling.Utf8)]
    public static partial int AddOption(string name, string value, int count, ref IntPtr options);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=AAB2B1
    // Broiler-Falsified-If: differs from void cupsFreeOptions(int num_options, cups_option_t *options) in cups/cups.h, or the count is not the last one cupsAddOption returned for that array
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsFreeOptions")]
    public static partial void FreeOptions(int count, IntPtr options);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=E2408E
    // Broiler-Falsified-If: differs from cups_dinfo_t *cupsCopyDestInfo(http_t *http, cups_dest_t *dest) in cups/cups.h, or a returned info reaches no cupsFreeDestInfo
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsCopyDestInfo")]
    public static partial IntPtr CopyDestInfo(IntPtr http, IntPtr dest);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C2810A
    // Broiler-Falsified-If: differs from void cupsFreeDestInfo(cups_dinfo_t *dinfo) in cups/cups.h, or an info is freed twice
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsFreeDestInfo")]
    public static partial void FreeDestInfo(IntPtr info);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=226A00
    // Broiler-Falsified-If: differs from int cupsGetDestMediaCount(http_t *http, cups_dest_t *dest, cups_dinfo_t *dinfo, unsigned flags) in cups/cups.h
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsGetDestMediaCount")]
    public static partial int GetDestMediaCount(IntPtr http, IntPtr dest, IntPtr info, uint flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=D6814B
    // Broiler-Falsified-If: differs from int cupsGetDestMediaByIndex(http_t *http, cups_dest_t *dest, cups_dinfo_t *dinfo, int n, unsigned flags, cups_size_t *size) in cups/cups.h, written into a CupsSize of 152 bytes
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsGetDestMediaByIndex")]
    public static partial int GetDestMediaByIndex(IntPtr http, IntPtr dest, IntPtr info, int index, uint flags, out CupsSize size);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=BA4649
    // Broiler-Falsified-If: differs from int cupsGetDestMediaDefault(http_t *http, cups_dest_t *dest, cups_dinfo_t *dinfo, unsigned flags, cups_size_t *size) in cups/cups.h, written into a CupsSize of 152 bytes
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsGetDestMediaDefault")]
    public static partial int GetDestMediaDefault(IntPtr http, IntPtr dest, IntPtr info, uint flags, out CupsSize size);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=CE7E70
    // Broiler-Falsified-If: differs from int cupsCheckDestSupported(http_t *http, cups_dest_t *dest, cups_dinfo_t *dinfo, const char *option, const char *value) in cups/cups.h
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsCheckDestSupported", StringMarshalling = StringMarshalling.Utf8)]
    public static partial int CheckDestSupported(IntPtr http, IntPtr dest, IntPtr info, string option, string? value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=945619
    // Broiler-Falsified-If: differs from int cupsPrintFile2(http_t *http, const char *name, const char *filename, const char *title, int num_options, cups_option_t *options) in cups/cups.h, whose zero return is a failure cupsLastErrorString describes
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsPrintFile2", StringMarshalling = StringMarshalling.Utf8)]
    public static partial int PrintFile(IntPtr http, string printer, string fileName, string title, int optionCount, IntPtr options);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=4DFCCA
    // Broiler-Falsified-If: differs from const char *cupsLastErrorString(void) in cups/cups.h, or the returned pointer, which libcups owns per thread, is freed
    // Broiler-Human:        PENDING
    [LibraryImport(Library, EntryPoint = "cupsLastErrorString")]
    public static partial IntPtr LastErrorString();
}

/// <summary>cups_dest_t: one destination (a printer or a class, with an optional instance).</summary>
// Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=684C2A
// Broiler-Falsified-If: Marshal.SizeOf is not 32 on 64-bit, with name at 0, instance at 8, is_default at 16, num_options at 20 and options at 24, the layout of cups_dest_t in cups/cups.h
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct CupsDest
{
    public IntPtr Name;
    public IntPtr Instance;
    public int IsDefault;
    public int OptionCount;
    public IntPtr Options;
}

/// <summary>cups_option_t: one name and value, both UTF-8.</summary>
// Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=192CA9
// Broiler-Falsified-If: Marshal.SizeOf is not 16 on 64-bit, with name at 0 and value at 8, the layout of cups_option_t in cups/cups.h
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct CupsOption
{
    public IntPtr Name;
    public IntPtr Value;
}

/// <summary>
/// cups_size_t: a medium's PWG self-describing name, its size and its hardware margins, all
/// lengths in hundredths of a millimetre.
/// </summary>
// Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=78193F
// Broiler-Falsified-If: Marshal.SizeOf is not 152, with media a 128-byte char array at 0 and width, length, bottom, left, right and top ints from 128, the layout of cups_size_t in cups/cups.h
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public unsafe struct CupsSize
{
    public const int MediaLength = 128;

    public fixed byte Media[MediaLength];
    public int Width;
    public int Length;
    public int Bottom;
    public int Left;
    public int Right;
    public int Top;

    /// <summary>The medium's name: the bytes up to the first NUL, as UTF-8.</summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=Medium; Resources=0; Fingerprint=994383
    // Broiler-Human:        PENDING
    public readonly string GetMediaName()
    {
        fixed (byte* media = Media)
        {
            int length = 0;
            while (length < MediaLength && media[length] != 0)
                length++;

            return System.Text.Encoding.UTF8.GetString(media, length);
        }
    }
}
