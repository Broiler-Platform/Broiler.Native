// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   10
// Annotated:        10/10
// Exempt:           20
// Human-reviewed:   0/10
// IP risk:          Low
// Security risk:    Critical
// Criteria:         10/10
// Resource impact:  3/10 max
// Unverified:       10
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Broiler.Native.Linux.Input;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=C79A53
// Broiler-Falsified-If: Read's count is declared narrower than size_t, so on x86-64 read(2) takes a byte count with undefined upper bits and writes evdev bytes past the end of the pinned array
// Broiler-Human:        PENDING
public static partial class LinuxNativeMethods
{
    public const int O_RDONLY = 0;
    public const int O_NONBLOCK = 0x800;
    public const int O_CLOEXEC = 0x80000;

    public const short POLLIN = 0x0001;
    public const short POLLERR = 0x0008;
    public const short POLLHUP = 0x0010;
    public const short POLLNVAL = 0x0020;

    public const int EINTR = 4;
    public const int EIO = 5;
    public const int EAGAIN = 11;
    public const int EACCES = 13;
    public const int EBUSY = 16;
    public const int ENODEV = 19;
    public const int ENOENT = 2;
    public const int EPERM = 1;

    private const nuint EVIOCSCLOCKID = 0x400445a0;
    private const int CLOCK_MONOTONIC = 1;

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B96AC4
    // Broiler-Falsified-If: a pathname containing an embedded NUL character is truncated at the NUL by the UTF-8 marshaller, so open(2) opens a different node than the one named instead of failing
    // Broiler-Human:        PENDING
    [LibraryImport("libc", EntryPoint = "open", SetLastError = true)]
    public static partial int Open([MarshalAs(UnmanagedType.LPUTF8Str)] string pathname, int flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=B87244
    // Broiler-Falsified-If: count is declared narrower than size_t, so on x86-64 read(2) takes a byte count with undefined upper bits and writes evdev bytes past the end of the pinned array
    // Broiler-Human:        PENDING
    [LibraryImport("libc", EntryPoint = "read", SetLastError = true)]
    public static partial nint Read(int fd, byte[] buffer, nuint count);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=D0C8DE
    // Broiler-Falsified-If: nfds is declared narrower than nfds_t, so on x86-64 poll(2) takes an entry count with undefined upper bits and walks pollfd entries past the end of the pinned array
    // Broiler-Human:        PENDING
    [LibraryImport("libc", EntryPoint = "poll", SetLastError = true)]
    public static partial int Poll([In, Out] PollFd[] fds, nuint nfds, int timeout);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E09054
    // Broiler-Falsified-If: the clock id reaches ioctl(2) by value instead of as a pointer to a 32-bit int, so EVIOCSCLOCKID fails with EFAULT on every device
    // Broiler-Human:        PENDING
    [LibraryImport("libc", EntryPoint = "ioctl", SetLastError = true)]
    private static partial int IoctlClockId(int fd, nuint request, ref int clockId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=7FA6C0
    // Broiler-Falsified-If: request is declared narrower than unsigned long, so on x86-64 ioctl(2) receives an EVIOCGABS code with undefined upper bits and copies into the array under another request's size
    // Broiler-Human:        PENDING
    [LibraryImport("libc", EntryPoint = "ioctl", SetLastError = true)]
    private static partial int IoctlAbsInfo(int fd, nuint request, byte[] absInfo);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=3DDB0B
    // Broiler-Falsified-If: an EVIOCSCLOCKID ioctl that fails with -1 makes the method return true, so callers treat CLOCK_REALTIME event timestamps as monotonic
    // Broiler-Human:        PENDING
    public static bool TrySetMonotonicClock(int fd)
    {
        int clockId = CLOCK_MONOTONIC;
        return IoctlClockId(fd, EVIOCSCLOCKID, ref clockId) == 0;
    }

    /// <summary>
    /// Reads a `struct input_absinfo` for an absolute axis via EVIOCGABS so
    /// touchpad deltas can be normalized against the pad's real range/resolution.
    /// </summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=77BE13
    // Broiler-Falsified-If: the buffer allocated here is shorter than the 24-byte size EviocgAbs encodes in the request, so the kernel copy of struct input_absinfo runs past the end of the array
    // Broiler-Human:        PENDING
    public static bool TryGetAbsInfo(int fd, ushort absCode, out int minimum, out int maximum, out int resolution)
    {
        minimum = 0;
        maximum = 0;
        resolution = 0;

        // struct input_absinfo { int32 value, minimum, maximum, fuzz, flat, resolution; } => 24 bytes
        byte[] buffer = new byte[24];
        if (IoctlAbsInfo(fd, EviocgAbs(absCode), buffer) < 0)
            return false;

        minimum = BinaryPrimitives.ReadInt32LittleEndian(buffer.AsSpan(4, 4));
        maximum = BinaryPrimitives.ReadInt32LittleEndian(buffer.AsSpan(8, 4));
        resolution = BinaryPrimitives.ReadInt32LittleEndian(buffer.AsSpan(20, 4));

        return true;
    }

    // EVIOCGABS(abs) = _IOR('E', 0x40 + abs, struct input_absinfo)
    // _IOC(dir=2 read, type='E'=0x45, nr=0x40+abs, size=24).
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=817AD7
    // Broiler-Falsified-If: an abs argument above ABS_MAX (0x3f) is encoded without rejection, and 0xC6 yields 0x80184506, which is EVIOCGNAME(24) rather than an EVIOCGABS request
    // Broiler-Human:        PENDING
    private static nuint EviocgAbs(ushort abs) => (2u << 30) | (24u << 16) | ((uint)'E' << 8) | (0x40u + abs);

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=D2661F
    // Broiler-Falsified-If: PollFd is not 8 bytes with Events and Revents as 16-bit fields at offsets 4 and 6, so poll(2) reads the event mask from and writes revents into the wrong bytes
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct PollFd
    {
        public int Fd;
        public short Events;
        public short Revents;
    }
}
