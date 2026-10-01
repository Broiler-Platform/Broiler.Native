// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   5
// Annotated:        5/5
// Exempt:           17
// Human-reviewed:   0/5
// IP risk:          Low
// Security risk:    High
// Criteria:         5/5
// Resource impact:  2/10 max
// Unverified:       5
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.MediaFoundation;

/// <summary>Media Foundation platform startup, attribute creation, and error codes.</summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=48313E
// Broiler-Falsified-If: one of its mfplat.dll imports differs from the mfapi.h prototype it binds, STDAPI MFStartup(ULONG Version, DWORD dwFlags), STDAPI MFShutdown() or STDAPI MFCreateAttributes(IMFAttributes **ppMFAttributes, UINT32 cInitialSize)
// Broiler-Human:        PENDING
public static partial class MediaFoundationPlatformNative
{
    public const int MF_VERSION = 0x00020070;
    public const int MFSTARTUP_NOSOCKET = 0x1;
    public const int MF_E_PLATFORM_NOT_INITIALIZED = unchecked((int)0xC00D36B0);
    public const int MF_E_INVALIDMEDIATYPE = unchecked((int)0xC00D36B4);
    public const int MF_E_NOT_INITIALIZED = unchecked((int)0xC00D36B6);
    public const int MF_E_NO_MORE_TYPES = unchecked((int)0xC00D36B9);
    public const int MF_E_NOT_FOUND = unchecked((int)0xC00D36D5);
    public const int MF_E_NOT_AVAILABLE = unchecked((int)0xC00D36D6);
    public const int MF_E_ATTRIBUTENOTFOUND = unchecked((int)0xC00D36E6);
    public const int MF_E_DISABLED_IN_SAFEMODE = unchecked((int)0xC00D36EF);
    public const int MF_E_SHUTDOWN = unchecked((int)0xC00D3E85);
    public const int MF_E_VIDEO_RECORDING_DEVICE_INVALIDATED = unchecked((int)0xC00D3EA2);
    public const int MF_E_VIDEO_RECORDING_DEVICE_PREEMPTED = unchecked((int)0xC00D3EA3);
    public const int MF_E_VIDEO_DEVICE_LOCKED = unchecked((int)0xC00D4E24);
    public const int MF_E_NO_CAPTURE_DEVICES_AVAILABLE = unchecked((int)0xC00DABE0);
    public const int MF_E_CAPTURE_SOURCE_NO_VIDEO_STREAM_PRESENT = unchecked((int)0xC00DABE7);
    public const int MF_E_UNSUPPORTED_CAPTURE_DEVICE_PRESENT = unchecked((int)0xC00DABED);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=FB247B
    // Broiler-Falsified-If: differs from STDAPI MFStartup(ULONG Version, DWORD dwFlags) in mfapi.h
    // Broiler-Human:        PENDING
    [LibraryImport("mfplat.dll")]
    public static partial int MFStartup(int version, int flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=344711
    // Broiler-Falsified-If: differs from STDAPI MFShutdown() in mfapi.h
    // Broiler-Human:        PENDING
    [LibraryImport("mfplat.dll")]
    public static partial int MFShutdown();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=A9BFE4
    // Broiler-Falsified-If: differs from STDAPI MFCreateAttributes(IMFAttributes **ppMFAttributes, UINT32 cInitialSize) in mfapi.h, or the reference written to attributes is not Released once its managed wrapper holds it
    // Broiler-Human:        PENDING
    [LibraryImport("mfplat.dll")]
    public static partial int MFCreateAttributes(out IMFAttributes attributes, uint initialSize);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=E28897
    // Broiler-Falsified-If: differs from STDAPI MFCreateAttributes(IMFAttributes **ppMFAttributes, UINT32 cInitialSize) in mfapi.h, or the caller does not Release the IMFAttributes written to attributes
    // Broiler-Human:        PENDING
    [LibraryImport("mfplat.dll")]
    public static partial int MFCreateAttributes(out IntPtr attributes, uint initialSize);
}
