// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   5
// Annotated:        5/5
// Exempt:           21
// Human-reviewed:   0/5
// IP risk:          Low
// Security risk:    Critical
// Criteria:         5/5
// Resource impact:  3/10 max
// Unverified:       5
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Input;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=33D29B
// Broiler-Falsified-If: GetRawInputData passes data and size to user32 in swapped positions, so the RAWINPUT is written through the size's address and the byte count into the caller's buffer
// Broiler-Human:        PENDING
public static partial class RawInputReaderNative
{
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=777845
    // Broiler-Falsified-If: Marshal.SizeOf is not sizeof(RAWINPUTHEADER), 24 bytes on x64 and 16 on x86, so GetRawInputData rejects the header size and the payload is read from the wrong offset
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInputHeader
    {
        public uint Type;
        public uint Size;
        public IntPtr Device;
        public IntPtr WParam;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=42EB0C
    // Broiler-Falsified-If: ButtonFlags is read from offset 2, which is padding, instead of usButtonFlags at offset 4, so a left-button press arrives in ButtonData and the wheel delta at offset 6 is never read
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct RawMouse
    {
        public ushort Flags;
        public ushort ButtonFlags;
        public ushort ButtonData;
        public uint RawButtons;
        public int LastX;
        public int LastY;
        public uint ExtraInformation;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=09BBF5
    // Broiler-Falsified-If: VKey is not read from offset 6 of RAWKEYBOARD (MakeCode 0, Flags 2, Reserved 4, VKey 6, Message 8, ExtraInformation 12), so a key press reports another field as its virtual-key code
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct RawKeyboard
    {
        public ushort MakeCode;
        public ushort Flags;
        public ushort Reserved;
        public ushort VKey;
        public uint Message;
        public uint ExtraInformation;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=DCA974
    // Broiler-Falsified-If: data and size reach GetRawInputData(HRAWINPUT, UINT, LPVOID, PUINT, UINT) in swapped positions, so user32 writes the RAWINPUT through the size's address and the byte count into the caller's buffer
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial uint GetRawInputData(IntPtr rawInput, uint command, IntPtr data, ref uint size, uint headerSize);
    public const uint RidInput = 0x10000003;
    public const uint RimTypeMouse = 0;
    public const uint RimTypeKeyboard = 1;
    public const ushort MouseMoveAbsolute = 0x0001;
}
