// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   10
// Annotated:        10/10
// Exempt:           4
// Human-reviewed:   0/10
// IP risk:          Low
// Security risk:    Critical
// Criteria:         10/10
// Resource impact:  1/10 max
// Unverified:       10
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Input;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=B1A9F1
// Broiler-Falsified-If: RegisterRawInputDevices is given a deviceCount larger than rawInputDevices.Length and user32 reads RAWINPUTDEVICE entries past the end of the pinned array
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
    // Broiler-Falsified-If: a deviceCount larger than rawInputDevices.Length makes user32 read RAWINPUTDEVICE entries past the end of the pinned array
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool RegisterRawInputDevices([In] RawInputDevice[] rawInputDevices, uint deviceCount, uint rawInputDeviceSize);
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=EB47D1
    // Broiler-Falsified-If: the value is not HID usage page 0x01 (Generic Desktop), so RegisterRawInputDevices subscribes to no mouse or keyboard and WM_INPUT never arrives
    // Broiler-Human:        PENDING
    public const ushort GenericDesktopUsagePage = 0x01;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E0FE7B
    // Broiler-Falsified-If: the value is not Generic Desktop usage 0x02 (Mouse), so the mouse registration subscribes to a different device class and no raw mouse input arrives
    // Broiler-Human:        PENDING
    public const ushort MouseUsage = 0x02;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=4F870A
    // Broiler-Falsified-If: the value is not Generic Desktop usage 0x06 (Keyboard), so the keyboard registration subscribes to a different device class and no raw key input arrives
    // Broiler-Human:        PENDING
    public const ushort KeyboardUsage = 0x06;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=6A73CF
    // Broiler-Falsified-If: the value is not winuser.h's RIDEV_REMOVE 0x00000001, so unregistering a device leaves its WM_INPUT registration active after the owner is gone
    // Broiler-Human:        PENDING
    public const uint RidevRemove = 0x00000001;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=129CED
    // Broiler-Falsified-If: the value is not winuser.h's RIDEV_NOLEGACY 0x00000030, so legacy WM_KEYDOWN and WM_MOUSEMOVE messages keep arriving beside WM_INPUT and input is delivered twice
    // Broiler-Human:        PENDING
    public const uint RidevNoLegacy = 0x00000030;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=397AAC
    // Broiler-Falsified-If: the value is not winuser.h's RIDEV_INPUTSINK 0x00000100, so a window registered for background input stops receiving WM_INPUT once it loses the foreground
    // Broiler-Human:        PENDING
    public const uint RidevInputSink = 0x00000100;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E83D3A
    // Broiler-Falsified-If: the value is not winuser.h's RIDEV_DEVNOTIFY 0x00002000, so WM_INPUT_DEVICE_CHANGE is not sent when a mouse or keyboard is attached or removed
    // Broiler-Human:        PENDING
    public const uint RidevDevNotify = 0x00002000;
}
