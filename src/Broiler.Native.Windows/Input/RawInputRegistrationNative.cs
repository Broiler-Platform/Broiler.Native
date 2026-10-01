// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   3
// Annotated:        3/3
// Exempt:           11
// Human-reviewed:   0/3
// IP risk:          Low
// Security risk:    Critical
// Criteria:         3/3
// Resource impact:  1/10 max
// Unverified:       3
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Input;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=B1A9F1
// Broiler-Falsified-If: RegisterRawInputDevices passes deviceCount and rawInputDeviceSize to user32 in swapped positions, so user32 walks as many entries as the struct size names past the pinned array
// Broiler-Human:        PENDING
public static partial class RawInputRegistrationNative
{
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=BCE2F9
    // Broiler-Falsified-If: TargetWindow is not at offset 8 on x64 or 4 on x86 as in RAWINPUTDEVICE, so user32 reads hwndTarget from the wrong bytes and WM_INPUT goes to another window or none
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInputDevice
    {
        public ushort UsagePage;
        public ushort Usage;
        public uint Flags;
        public IntPtr TargetWindow;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=261907
    // Broiler-Falsified-If: deviceCount and rawInputDeviceSize reach RegisterRawInputDevices(PCRAWINPUTDEVICE, UINT, UINT) in swapped positions, so user32 walks as many entries as the struct size names past the pinned array
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool RegisterRawInputDevices([In] RawInputDevice[] rawInputDevices, uint deviceCount, uint rawInputDeviceSize);
    public const ushort GenericDesktopUsagePage = 0x01;
    public const ushort MouseUsage = 0x02;
    public const ushort KeyboardUsage = 0x06;
    public const uint RidevRemove = 0x00000001;
    public const uint RidevNoLegacy = 0x00000030;
    public const uint RidevInputSink = 0x00000100;
    public const uint RidevDevNotify = 0x00002000;
}
