// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   22
// Annotated:        22/22
// Exempt:           0
// Human-reviewed:   0/22
// IP risk:          Low
// Security risk:    High
// Criteria:         22/6
// Resource impact:  2/10 max
// Unverified:       22
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.MediaFoundation;

/// <summary>Media Foundation platform startup, attribute creation, and error codes.</summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=48313E
// Broiler-Falsified-If: an mfplat.dll import differs from its mfapi.h prototype in pointer width, so a 64-bit caller of MFCreateAttributes wraps and Releases a truncated IMFAttributes address
// Broiler-Human:        PENDING
public static partial class MediaFoundationPlatformNative
{
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=083E15
    // Broiler-Falsified-If: the value is not mfapi.h's MF_SDK_VERSION<<16 | MF_API_VERSION (0x00020070), so MFStartup rejects it with MF_E_BAD_STARTUP_VERSION or starts the platform at an API level the declared interfaces do not assume
    // Broiler-Human:        PENDING
    public const int MF_VERSION = 0x00020070;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=20B68F
    // Broiler-Falsified-If: the value is not mfapi.h's 0x1, so MFStartup runs a full startup that also initialises the sockets layer, or rejects an undefined flag, in a process that only needs local playback and capture
    // Broiler-Human:        PENDING
    public const int MFSTARTUP_NOSOCKET = 0x1;
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=683182
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00D36B0, so a Media Foundation call made before MFStartup is not recognised and is reported as a generic native failure instead of an unavailable host
    // Broiler-Human:        PENDING
    public const int MF_E_PLATFORM_NOT_INITIALIZED = unchecked((int)0xC00D36B0);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=834B18
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00D36B4, so a media type rejected by a source or engine is not recognised and is reported as a generic native failure instead of an unsupported format
    // Broiler-Human:        PENDING
    public const int MF_E_INVALIDMEDIATYPE = unchecked((int)0xC00D36B4);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=B88454
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00D36B6, so an object used before its own initialisation is not recognised as an unavailable host and falls through to a generic native failure
    // Broiler-Human:        PENDING
    public const int MF_E_NOT_INITIALIZED = unchecked((int)0xC00D36B6);
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=27B4DF
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00D36B9, so the end of an IMFSourceReader native media type enumeration is not recognised and format negotiation throws instead of stopping after the last index
    // Broiler-Human:        PENDING
    public const int MF_E_NO_MORE_TYPES = unchecked((int)0xC00D36B9);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=011577
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00D36D5, so a capture device that cannot be found is reported as a generic native failure instead of a missing device
    // Broiler-Human:        PENDING
    public const int MF_E_NOT_FOUND = unchecked((int)0xC00D36D5);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=76DC1C
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00D36D6, so a platform feature reported as unavailable is not recognised as an unavailable host and falls through to a generic native failure
    // Broiler-Human:        PENDING
    public const int MF_E_NOT_AVAILABLE = unchecked((int)0xC00D36D6);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=255495
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00D36E6, so an IMFAttributes getter's missing-key result cannot be told apart from a failed read
    // Broiler-Human:        PENDING
    public const int MF_E_ATTRIBUTENOTFOUND = unchecked((int)0xC00D36E6);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=93A586
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00D36EF, so Media Foundation refusing to run in safe mode is not recognised as an unavailable host and falls through to a generic native failure
    // Broiler-Human:        PENDING
    public const int MF_E_DISABLED_IN_SAFEMODE = unchecked((int)0xC00D36EF);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=11F2F5
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00D3E85, so a source reader or media engine that was already shut down is not recognised and a removed camera is reported as a generic native failure
    // Broiler-Human:        PENDING
    public const int MF_E_SHUTDOWN = unchecked((int)0xC00D3E85);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=DFD5BA
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00D3EA2, so a camera unplugged during capture is not reported as a removed device
    // Broiler-Human:        PENDING
    public const int MF_E_VIDEO_RECORDING_DEVICE_INVALIDATED = unchecked((int)0xC00D3EA2);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=58A734
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00D3EA3, so a camera taken over by a higher-priority application is not reported as a busy device
    // Broiler-Human:        PENDING
    public const int MF_E_VIDEO_RECORDING_DEVICE_PREEMPTED = unchecked((int)0xC00D3EA3);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=54A931
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00D4E24, so a camera held exclusively by another process is not reported as a busy device
    // Broiler-Human:        PENDING
    public const int MF_E_VIDEO_DEVICE_LOCKED = unchecked((int)0xC00D4E24);
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=7C25C5
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00DABE0, so MFEnumDeviceSources on a machine without a camera throws instead of yielding an empty device list
    // Broiler-Human:        PENDING
    public const int MF_E_NO_CAPTURE_DEVICES_AVAILABLE = unchecked((int)0xC00DABE0);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=C5D9FD
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00DABE7, so a capture source without a video stream is not reported as a missing device
    // Broiler-Human:        PENDING
    public const int MF_E_CAPTURE_SOURCE_NO_VIDEO_STREAM_PRESENT = unchecked((int)0xC00DABE7);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=1E4826
    // Broiler-Falsified-If: the value is not mferror.h's 0xC00DABED, so an unsupported capture device is not reported as an unsupported capability
    // Broiler-Human:        PENDING
    public const int MF_E_UNSUPPORTED_CAPTURE_DEVICE_PRESENT = unchecked((int)0xC00DABED);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=FB247B
    // Broiler-Falsified-If: the import declares a calling convention other than the WINAPI default that STDAPI requires, so on 32-bit x86 the version and flags arguments are popped by both sides and the caller's stack is unbalanced after MFStartup returns
    // Broiler-Human:        PENDING
    [LibraryImport("mfplat.dll")]
    public static partial int MFStartup(int version, int flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=344711
    // Broiler-Falsified-If: the import binds to an export other than mfplat.dll's MFShutdown, so the platform reference a successful MFStartup takes is never dropped and Media Foundation work-queue threads outlive the last disposed scope
    // Broiler-Human:        PENDING
    [LibraryImport("mfplat.dll")]
    public static partial int MFShutdown();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=A9BFE4
    // Broiler-Falsified-If: the typed overload wraps the IMFAttributes** result without releasing the reference MFCreateAttributes returned, so each attribute store created through it outlives the release of its wrapper
    // Broiler-Human:        PENDING
    [LibraryImport("mfplat.dll")]
    public static partial int MFCreateAttributes(out IMFAttributes attributes, uint initialSize);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=E28897
    // Broiler-Falsified-If: the out parameter is narrower than pointer width, so on 64-bit the upper half of the returned IMFAttributes pointer is dropped and the caller wraps and Releases a truncated address
    // Broiler-Human:        PENDING
    [LibraryImport("mfplat.dll")]
    public static partial int MFCreateAttributes(out IntPtr attributes, uint initialSize);
}
