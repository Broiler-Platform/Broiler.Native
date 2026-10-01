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
// Broiler-Falsified-If: its import differs from BOOL RegisterRawInputDevices(PCRAWINPUTDEVICE pRawInputDevices, UINT uiNumDevices, UINT cbSize) in winuser.h
// Broiler-Human:        PENDING
public static partial class RawInputRegistrationNative
{
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=BCE2F9
    // Broiler-Falsified-If: Marshal.SizeOf is not 16 on 64-bit (12 on 32-bit) or TargetWindow is not at offset 8, the layout of RAWINPUTDEVICE (USHORT usUsagePage, USHORT usUsage, DWORD dwFlags, HWND hwndTarget) in winuser.h
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
    // Broiler-Falsified-If: differs from BOOL RegisterRawInputDevices(PCRAWINPUTDEVICE pRawInputDevices, UINT uiNumDevices, UINT cbSize) in winuser.h, where uiNumDevices counts the array's entries and cbSize must be sizeof(RAWINPUTDEVICE)
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
