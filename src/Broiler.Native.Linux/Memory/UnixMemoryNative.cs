// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;

namespace Broiler.Native.Linux.Memory;

/// <summary>
/// POSIX memory mapping bindings from sys/mman.h (libc).
/// </summary>
public static unsafe partial class UnixMemoryNative
{
    public const int ProtNone = 0x0;
    public const int ProtRead = 0x1;
    public const int ProtWrite = 0x2;
    public const int ProtExec = 0x4;

    public const int MapPrivate = 0x02;
    public const int MapAnonymousLinux = 0x20;
    public const int MapAnonymousMacOs = 0x1000;

    [LibraryImport("libc", EntryPoint = "mmap", SetLastError = true)]
    public static partial void* Mmap(
        void* address, nuint length, int protect, int flags, int descriptor, nint offset);

    [LibraryImport("libc", EntryPoint = "mprotect", SetLastError = true)]
    public static partial int Mprotect(void* address, nuint length, int protect);

    [LibraryImport("libc", EntryPoint = "munmap", SetLastError = true)]
    public static partial int Munmap(void* address, nuint length);
}
