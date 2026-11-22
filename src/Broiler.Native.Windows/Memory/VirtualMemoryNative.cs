// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Memory;

/// <summary>
/// Windows virtual memory and instruction cache bindings from memoryapi.h and processthreadsapi.h.
/// </summary>
public static unsafe partial class VirtualMemoryNative
{
    public const uint MemCommit = 0x00001000;
    public const uint MemReserve = 0x00002000;
    public const uint MemRelease = 0x00008000;

    public const uint PageNoAccess = 0x01;
    public const uint PageReadOnly = 0x02;
    public const uint PageReadWrite = 0x04;
    public const uint PageExecuteRead = 0x20;
    public const uint PageExecuteReadWrite = 0x40;

    [LibraryImport("kernel32.dll", EntryPoint = "VirtualAlloc", SetLastError = true)]
    public static partial void* VirtualAlloc(void* address, nuint size, uint allocationType, uint protect);

    [LibraryImport("kernel32.dll", EntryPoint = "VirtualProtect", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool VirtualProtect(void* address, nuint size, uint newProtect, uint* oldProtect);

    [LibraryImport("kernel32.dll", EntryPoint = "VirtualFree", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool VirtualFree(void* address, nuint size, uint freeType);

    [LibraryImport("kernel32.dll", EntryPoint = "FlushInstructionCache", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool FlushInstructionCache(void* process, void* baseAddress, nuint size);

    [LibraryImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
    public static partial void* GetCurrentProcess();
}
