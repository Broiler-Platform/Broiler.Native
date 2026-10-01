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
// Broiler-Falsified-If: a struct or the import differs from its winuser.h counterpart: RAWINPUTHEADER, RAWMOUSE, RAWKEYBOARD or UINT GetRawInputData(HRAWINPUT, UINT, LPVOID, PUINT, UINT)
// Broiler-Human:        PENDING
public static partial class RawInputReaderNative
{
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=777845
    // Broiler-Falsified-If: Marshal.SizeOf is not 24 on 64-bit (16 on 32-bit) or Device is not at offset 8, the layout of RAWINPUTHEADER (DWORD dwType, DWORD dwSize, HANDLE hDevice, WPARAM wParam) in winuser.h
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
    // Broiler-Falsified-If: Marshal.OffsetOf of ButtonFlags is not 4 or of ButtonData not 6, where RAWMOUSE in winuser.h puts usButtonFlags and usButtonData in a union with ULONG ulButtons after USHORT usFlags
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
    // Broiler-Falsified-If: Marshal.SizeOf is not 16 or VKey is not at offset 6 and Message at 8, the layout of RAWKEYBOARD (USHORT MakeCode, Flags, Reserved, VKey, UINT Message, ULONG ExtraInformation) in winuser.h
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
    // Broiler-Falsified-If: differs from UINT GetRawInputData(HRAWINPUT hRawInput, UINT uiCommand, LPVOID pData, PUINT pcbSize, UINT cbSizeHeader) in winuser.h, where pcbSize is the byte size of pData and cbSizeHeader must be sizeof(RAWINPUTHEADER)
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial uint GetRawInputData(IntPtr rawInput, uint command, IntPtr data, ref uint size, uint headerSize);
    public const uint RidInput = 0x10000003;
    public const uint RimTypeMouse = 0;
    public const uint RimTypeKeyboard = 1;
    public const ushort MouseMoveAbsolute = 0x0001;
}
