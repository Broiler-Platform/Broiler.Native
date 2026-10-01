// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   27
// Annotated:        27/27
// Exempt:           3
// Human-reviewed:   0/27
// IP risk:          Low
// Security risk:    Critical
// Criteria:         27/27
// Resource impact:  3/10 max
// Unverified:       27
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Broiler.Native.Linux.Input;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=C79A53
// Broiler-Falsified-If: Read is called with a count larger than buffer.Length and read(2) writes evdev bytes past the end of the pinned managed array
// Broiler-Human:        PENDING
public static partial class LinuxNativeMethods
{
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=C25069
    // Broiler-Falsified-If: O_RDONLY differs from 0, so open(2) asks for write access to the evdev node and fails with EACCES for a user who may only read input devices
    // Broiler-Human:        PENDING
    public const int O_RDONLY = 0;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=22552B
    // Broiler-Falsified-If: O_NONBLOCK differs from 0x800 (04000 octal on x86-64 and arm64), so a read on an idle event device blocks the read loop instead of returning EAGAIN
    // Broiler-Human:        PENDING
    public const int O_NONBLOCK = 0x800;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=69C944
    // Broiler-Falsified-If: O_CLOEXEC differs from 0x80000 (02000000 octal), so the evdev descriptor is inherited by child processes the host spawns
    // Broiler-Human:        PENDING
    public const int O_CLOEXEC = 0x80000;

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=B28418
    // Broiler-Falsified-If: POLLIN differs from 0x0001, so poll(2) never reports the event device readable and the read loop only wakes on its timeout
    // Broiler-Human:        PENDING
    public const short POLLIN = 0x0001;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=AC1DCE
    // Broiler-Falsified-If: POLLERR differs from 0x0008, so an event device in an error state is not recognised in revents and the loop keeps polling a dead descriptor
    // Broiler-Human:        PENDING
    public const short POLLERR = 0x0008;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=06CE9C
    // Broiler-Falsified-If: POLLHUP differs from 0x0010, so an unplugged event device is not recognised in revents and is not reported as removed
    // Broiler-Human:        PENDING
    public const short POLLHUP = 0x0010;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=06ECDE
    // Broiler-Falsified-If: POLLNVAL differs from 0x0020, so polling a closed descriptor is not recognised in revents and the loop spins on it
    // Broiler-Human:        PENDING
    public const short POLLNVAL = 0x0020;

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=BC45A0
    // Broiler-Falsified-If: EINTR differs from 4, so a poll or read interrupted by a signal is reported as a device fault instead of being retried
    // Broiler-Human:        PENDING
    public const int EINTR = 4;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=F96002
    // Broiler-Falsified-If: EIO differs from 5, so a read that fails after the device is unplugged is classified as a generic fault instead of a removed device
    // Broiler-Human:        PENDING
    public const int EIO = 5;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=14B507
    // Broiler-Falsified-If: EAGAIN differs from 11, so a nonblocking read with no pending events is reported as a fault and stops the read loop
    // Broiler-Human:        PENDING
    public const int EAGAIN = 11;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=10AC33
    // Broiler-Falsified-If: EACCES differs from 13, so an open refused by the input group permissions is not classified as permission denied
    // Broiler-Human:        PENDING
    public const int EACCES = 13;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=1FA33E
    // Broiler-Falsified-If: EBUSY differs from 16, so a device another process holds is not classified as busy
    // Broiler-Human:        PENDING
    public const int EBUSY = 16;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=D76B4A
    // Broiler-Falsified-If: ENODEV differs from 19, so a read on a removed event device is not classified as a removed device and recovery is skipped
    // Broiler-Human:        PENDING
    public const int ENODEV = 19;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=61565D
    // Broiler-Falsified-If: ENOENT differs from 2, so opening a missing /dev/input node is not classified as device not found
    // Broiler-Human:        PENDING
    public const int ENOENT = 2;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=8E279A
    // Broiler-Falsified-If: EPERM differs from 1, so an open refused by a seat or container policy is not classified as permission denied
    // Broiler-Human:        PENDING
    public const int EPERM = 1;

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=136EA3
    // Broiler-Falsified-If: EVIOCSCLOCKID differs from 0x400445a0, the encoding of _IOW('E', 0xa0, int), so the clock switch fails with EINVAL and event timestamps stay on CLOCK_REALTIME
    // Broiler-Human:        PENDING
    private const nuint EVIOCSCLOCKID = 0x400445a0;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=80FE56
    // Broiler-Falsified-If: CLOCK_MONOTONIC differs from 1, so EVIOCSCLOCKID selects another clock or fails and event timestamps jump when the wall clock is adjusted
    // Broiler-Human:        PENDING
    private const int CLOCK_MONOTONIC = 1;

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B96AC4
    // Broiler-Falsified-If: a pathname containing an embedded NUL character is truncated at the NUL by the UTF-8 marshaller, so open(2) opens a different node than the one named instead of failing
    // Broiler-Human:        PENDING
    [LibraryImport("libc", EntryPoint = "open", SetLastError = true)]
    public static partial int Open([MarshalAs(UnmanagedType.LPUTF8Str)] string pathname, int flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=B87244
    // Broiler-Falsified-If: a count larger than buffer.Length reaches read(2), which writes the excess bytes past the end of the pinned managed array
    // Broiler-Human:        PENDING
    [LibraryImport("libc", EntryPoint = "read", SetLastError = true)]
    public static partial nint Read(int fd, byte[] buffer, nuint count);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=D0C8DE
    // Broiler-Falsified-If: an nfds larger than fds.Length reaches poll(2), which reads pollfd entries and writes revents past the end of the pinned array
    // Broiler-Human:        PENDING
    [LibraryImport("libc", EntryPoint = "poll", SetLastError = true)]
    public static partial int Poll([In, Out] PollFd[] fds, nuint nfds, int timeout);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E09054
    // Broiler-Falsified-If: the clock id reaches ioctl(2) by value instead of as a pointer to a 32-bit int, so EVIOCSCLOCKID fails with EFAULT on every device
    // Broiler-Human:        PENDING
    [LibraryImport("libc", EntryPoint = "ioctl", SetLastError = true)]
    private static partial int IoctlClockId(int fd, nuint request, ref int clockId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=7FA6C0
    // Broiler-Falsified-If: an absInfo array shorter than the size encoded in the request lets the kernel copy struct input_absinfo past the end of the pinned array
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
