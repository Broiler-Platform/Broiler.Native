// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.HyperV;

/// <summary>
/// Windows Hypervisor Platform (WinHvPlatform.dll and WinHvEmulation.dll) bindings.
/// </summary>
public static unsafe partial class WhvNative
{
    public const string PlatformLibrary = "WinHvPlatform.dll";
    public const string EmulationLibrary = "WinHvEmulation.dll";

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvGetCapability")]
    public static partial int WHvGetCapability(
        WhvCapabilityCode capabilityCode,
        void* capabilityBuffer,
        uint capabilityBufferSizeInBytes,
        uint* writtenSizeInBytes);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvCreatePartition")]
    public static partial int WHvCreatePartition(nint* partition);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvSetupPartition")]
    public static partial int WHvSetupPartition(nint partition);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvDeletePartition")]
    public static partial int WHvDeletePartition(nint partition);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvSetPartitionProperty")]
    public static partial int WHvSetPartitionProperty(
        nint partition,
        WhvPartitionPropertyCode propertyCode,
        void* propertyBuffer,
        uint propertyBufferSizeInBytes);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvGetPartitionProperty")]
    public static partial int WHvGetPartitionProperty(
        nint partition,
        WhvPartitionPropertyCode propertyCode,
        void* propertyBuffer,
        uint propertyBufferSizeInBytes,
        uint* writtenSizeInBytes);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvMapGpaRange")]
    public static partial int WHvMapGpaRange(
        nint partition,
        void* sourceAddress,
        ulong guestAddress,
        ulong sizeInBytes,
        WhvMapGpaRangeFlags flags);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvUnmapGpaRange")]
    public static partial int WHvUnmapGpaRange(nint partition, ulong guestAddress, ulong sizeInBytes);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvTranslateGva")]
    public static partial int WHvTranslateGva(
        nint partition,
        uint vpIndex,
        ulong gva,
        WhvTranslateGvaFlags translateFlags,
        WhvTranslateGvaResultCode* translationResult,
        ulong* gpa);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvCreateVirtualProcessor")]
    public static partial int WHvCreateVirtualProcessor(nint partition, uint vpIndex, uint flags);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvDeleteVirtualProcessor")]
    public static partial int WHvDeleteVirtualProcessor(nint partition, uint vpIndex);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvRunVirtualProcessor")]
    public static partial int WHvRunVirtualProcessor(
        nint partition,
        uint vpIndex,
        void* exitContext,
        uint exitContextSizeInBytes);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvCancelRunVirtualProcessor")]
    public static partial int WHvCancelRunVirtualProcessor(nint partition, uint vpIndex, uint flags);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvGetVirtualProcessorRegisters")]
    public static partial int WHvGetVirtualProcessorRegisters(
        nint partition,
        uint vpIndex,
        WhvRegisterName* registerNames,
        uint registerCount,
        WhvRegisterValue* registerValues);

    [LibraryImport(PlatformLibrary, EntryPoint = "WHvSetVirtualProcessorRegisters")]
    public static partial int WHvSetVirtualProcessorRegisters(
        nint partition,
        uint vpIndex,
        WhvRegisterName* registerNames,
        uint registerCount,
        WhvRegisterValue* registerValues);

    [LibraryImport(EmulationLibrary, EntryPoint = "WHvEmulatorCreateEmulator")]
    public static partial int WHvEmulatorCreateEmulator(WhvEmulatorCallbacks* callbacks, nint* emulator);

    [LibraryImport(EmulationLibrary, EntryPoint = "WHvEmulatorDestroyEmulator")]
    public static partial int WHvEmulatorDestroyEmulator(nint emulator);

    [LibraryImport(EmulationLibrary, EntryPoint = "WHvEmulatorTryIoEmulation")]
    public static partial int WHvEmulatorTryIoEmulation(
        nint emulator,
        void* context,
        WhvVpExitContext* vpContext,
        WhvIoPortAccessContext* ioInstructionContext,
        WhvEmulatorStatus* emulatorReturnStatus);

    [LibraryImport(EmulationLibrary, EntryPoint = "WHvEmulatorTryMmioEmulation")]
    public static partial int WHvEmulatorTryMmioEmulation(
        nint emulator,
        void* context,
        WhvVpExitContext* vpContext,
        WhvMemoryAccessContext* mmioInstructionContext,
        WhvEmulatorStatus* emulatorReturnStatus);
}
