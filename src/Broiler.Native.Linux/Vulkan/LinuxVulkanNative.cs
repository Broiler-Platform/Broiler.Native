// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   25
// Annotated:        25/25
// Exempt:           45
// Human-reviewed:   0/25
// IP risk:          Low
// Security risk:    Critical
// Criteria:         21/21
// Resource impact:  2/10 max
// Unverified:       25
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Broiler.Native.Linux.Vulkan;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=E46435
// Broiler-Falsified-If: an import here differs from its prototype in vulkan/vulkan_core.h, where VkInstance, VkPhysicalDevice, VkDevice and VkQueue are pointer handles, VkResult is an enum, and counts, versions and indices are uint32_t
// Broiler-Human:        PENDING
public static partial class LinuxVulkanNative
{
    public const int VK_SUCCESS = 0;
    public const int VK_INCOMPLETE = 5;

    public const uint VK_STRUCTURE_TYPE_APPLICATION_INFO = 0;
    public const uint VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO = 1;
    public const uint VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO = 2;
    public const uint VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO = 3;

    public const uint VK_QUEUE_GRAPHICS_BIT = 0x00000001;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=29F334
    // Broiler-Human:        PENDING
    public static uint MakeApiVersion(uint variant, int major, int minor, int patch)
    {
        if (major < 0 || major > 127)
            throw new ArgumentOutOfRangeException(nameof(major));

        if (minor < 0 || minor > 1023)
            throw new ArgumentOutOfRangeException(nameof(minor));

        if (patch < 0 || patch > 4095)
            throw new ArgumentOutOfRangeException(nameof(patch));

        return (variant << 29) | ((uint)major << 22) | ((uint)minor << 12) | (uint)patch;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=06A932
    // Broiler-Falsified-If: a Vulkan 1.0 loader that does not export vkEnumerateInstanceVersion makes the method throw instead of returning version 1.0.0
    // Broiler-Human:        PENDING
    public static uint GetSupportedInstanceVersion()
    {
        try
        {
            int result = EnumerateInstanceVersion(out uint version);
            ThrowIfFailed(result, "vkEnumerateInstanceVersion");
            return version;
        }
        catch (EntryPointNotFoundException)
        {
            return MakeApiVersion(0, 1, 0, 0);
        }
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=1B627A
    // Broiler-Falsified-If: a negative VkResult such as VK_ERROR_INITIALIZATION_FAILED (-3) returns without throwing, so the caller goes on to use the out handle of a failed call
    // Broiler-Human:        PENDING
    public static void ThrowIfFailed(int result, string operation)
    {
        if (result is VK_SUCCESS or VK_INCOMPLETE)
            return;

        throw new LinuxVulkanException($"{operation} failed with Vulkan result {ResultName(result)} ({result}).");
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=1; Fingerprint=BD02CB
    // Broiler-Human:        PENDING
    public static string FormatApiVersion(uint version)
    {
        uint major = (version >> 22) & 0x7F;
        uint minor = (version >> 12) & 0x3FF;
        uint patch = version & 0xFFF;
        return $"{major}.{minor}.{patch}";
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=1AD6E2
    // Broiler-Falsified-If: the 256-byte deviceName copy starts at an offset other than 20 of VkPhysicalDeviceProperties, so the reported name includes deviceType bytes or runs into pipelineCacheUUID
    // Broiler-Human:        PENDING
    public static LinuxVulkanDeviceInfo GetPhysicalDeviceInfo(IntPtr physicalDevice)
    {
        if (physicalDevice == IntPtr.Zero)
            throw new ArgumentException("A Vulkan physical-device handle is required.", nameof(physicalDevice));

        const int bufferSize = 4096;
        const int deviceNameOffset = 20;
        const int deviceNameLength = 256;
        IntPtr buffer = Marshal.AllocHGlobal(bufferSize);

        try
        {
            GetPhysicalDeviceProperties(physicalDevice, buffer);

            uint apiVersion = ReadUInt32(buffer, 0);
            uint driverVersion = ReadUInt32(buffer, 4);
            uint vendorId = ReadUInt32(buffer, 8);
            uint deviceId = ReadUInt32(buffer, 12);
            uint deviceType = ReadUInt32(buffer, 16);

            byte[] nameBytes = new byte[deviceNameLength];
            Marshal.Copy(IntPtr.Add(buffer, deviceNameOffset), nameBytes, 0, nameBytes.Length);

            int nameLength = Array.IndexOf(nameBytes, (byte)0);
            if (nameLength < 0)
                nameLength = nameBytes.Length;

            string name = Encoding.UTF8.GetString(nameBytes, 0, nameLength);
            if (string.IsNullOrWhiteSpace(name))
                name = "unknown";

            return new LinuxVulkanDeviceInfo(name,
                FormatPhysicalDeviceType(deviceType),
                FormatApiVersion(apiVersion), "0x" + driverVersion.ToString("X8"), vendorId, deviceId);
        }
        finally
        {
            Marshal.FreeHGlobal(buffer);
        }
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=205D93
    // Broiler-Falsified-If: differs from VkResult vkEnumerateInstanceVersion(uint32_t* pApiVersion) in vulkan/vulkan_core.h
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkEnumerateInstanceVersion")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial int EnumerateInstanceVersion(out uint apiVersion);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=5CE6EF
    // Broiler-Falsified-If: differs from VkResult vkCreateInstance(const VkInstanceCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkInstance* pInstance) in vulkan/vulkan_core.h, or the VkInstanceCreateInfo passed by ref is not the 64 bytes that header lays out on 64-bit
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkCreateInstance")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int CreateInstance(ref VkInstanceCreateInfo createInfo, IntPtr allocator, out IntPtr instance);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=98A399
    // Broiler-Falsified-If: differs from void vkDestroyInstance(VkInstance instance, const VkAllocationCallbacks* pAllocator) in vulkan/vulkan_core.h
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkDestroyInstance")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DestroyInstance(IntPtr instance, IntPtr allocator);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=0003C3
    // Broiler-Falsified-If: physicalDeviceCount is larger than physicalDevices.Length on entry to VkResult vkEnumeratePhysicalDevices(VkInstance instance, uint32_t* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices) in vulkan/vulkan_core.h, which writes up to that many pointer-sized handles
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkEnumeratePhysicalDevices")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int EnumeratePhysicalDevices(IntPtr instance, ref uint physicalDeviceCount, [Out] IntPtr[]? physicalDevices);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=8B21E9
    // Broiler-Falsified-If: queueFamilyPropertyCount is larger than queueFamilyProperties.Length on entry to void vkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint32_t* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties) in vulkan/vulkan_core.h, which writes up to that many 24-byte entries
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GetPhysicalDeviceQueueFamilyProperties(IntPtr physicalDevice, ref uint queueFamilyPropertyCount,
        [Out] VkQueueFamilyProperties[]? queueFamilyProperties);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=89BCFE
    // Broiler-Falsified-If: the buffer passed as properties is smaller than 824 bytes, the 64-bit size of the VkPhysicalDeviceProperties that void vkGetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties) in vulkan/vulkan_core.h writes
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkGetPhysicalDeviceProperties")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void GetPhysicalDeviceProperties(IntPtr physicalDevice, IntPtr properties);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=59040F
    // Broiler-Falsified-If: differs from VkResult vkCreateDevice(VkPhysicalDevice physicalDevice, const VkDeviceCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkDevice* pDevice) in vulkan/vulkan_core.h, or the VkDeviceCreateInfo passed by ref is not the 72 bytes that header lays out on 64-bit
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkCreateDevice")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int CreateDevice(IntPtr physicalDevice, ref VkDeviceCreateInfo createInfo, IntPtr allocator, out IntPtr device);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=19195C
    // Broiler-Falsified-If: differs from void vkDestroyDevice(VkDevice device, const VkAllocationCallbacks* pAllocator) in vulkan/vulkan_core.h
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkDestroyDevice")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DestroyDevice(IntPtr device, IntPtr allocator);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=933A0D
    // Broiler-Falsified-If: differs from void vkGetDeviceQueue(VkDevice device, uint32_t queueFamilyIndex, uint32_t queueIndex, VkQueue* pQueue) in vulkan/vulkan_core.h
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkGetDeviceQueue")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GetDeviceQueue(IntPtr device, uint queueFamilyIndex, uint queueIndex, out IntPtr queue);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=3C80E2
    // Broiler-Falsified-If: differs from VkResult vkDeviceWaitIdle(VkDevice device) in vulkan/vulkan_core.h
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkDeviceWaitIdle")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int DeviceWaitIdle(IntPtr device);

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=2B62F4
    // Broiler-Falsified-If: Marshal.SizeOf is not 48 on 64-bit, the size of VkApplicationInfo in vulkan/vulkan_core.h, or ApiVersion is not at offset 44
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct VkApplicationInfo
    {
        public uint SType;
        public IntPtr PNext;
        public IntPtr PApplicationName;
        public uint ApplicationVersion;
        public IntPtr PEngineName;
        public uint EngineVersion;
        public uint ApiVersion;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=D473E7
    // Broiler-Falsified-If: Marshal.SizeOf is not 64 on 64-bit, the size of VkInstanceCreateInfo in vulkan/vulkan_core.h, or PpEnabledExtensionNames is not at offset 56
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct VkInstanceCreateInfo
    {
        public uint SType;
        public IntPtr PNext;
        public uint Flags;
        public IntPtr PApplicationInfo;
        public uint EnabledLayerCount;
        public IntPtr PpEnabledLayerNames;
        public uint EnabledExtensionCount;
        public IntPtr PpEnabledExtensionNames;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=3020AD
    // Broiler-Falsified-If: Marshal.SizeOf is not 40 on 64-bit, the size of VkDeviceQueueCreateInfo in vulkan/vulkan_core.h, or PQueuePriorities is not at offset 32
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceQueueCreateInfo
    {
        public uint SType;
        public IntPtr PNext;
        public uint Flags;
        public uint QueueFamilyIndex;
        public uint QueueCount;
        public IntPtr PQueuePriorities;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=CADF59
    // Broiler-Falsified-If: Marshal.SizeOf is not 72 on 64-bit, the size of VkDeviceCreateInfo in vulkan/vulkan_core.h, or PEnabledFeatures is not at offset 64
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceCreateInfo
    {
        public uint SType;
        public IntPtr PNext;
        public uint Flags;
        public uint QueueCreateInfoCount;
        public IntPtr PQueueCreateInfos;
        public uint EnabledLayerCount;
        public IntPtr PpEnabledLayerNames;
        public uint EnabledExtensionCount;
        public IntPtr PpEnabledExtensionNames;
        public IntPtr PEnabledFeatures;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=243E73
    // Broiler-Falsified-If: Marshal.SizeOf is not 24, the size of VkQueueFamilyProperties in vulkan/vulkan_core.h, or MinImageTransferGranularity is not at offset 12
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueueFamilyProperties
    {
        public uint QueueFlags;
        public uint QueueCount;
        public uint TimestampValidBits;
        public VkExtent3D MinImageTransferGranularity;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=BD2FAE
    // Broiler-Falsified-If: Marshal.SizeOf is not 12, the size of VkExtent3D in vulkan/vulkan_core.h with its uint32_t width, height and depth
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExtent3D
    {
        public uint Width;
        public uint Height;
        public uint Depth;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=4F3114
    // Broiler-Human:        PENDING
    private static string ResultName(int result) =>
        result switch
        {
            VK_SUCCESS => "VK_SUCCESS",
            VK_INCOMPLETE => "VK_INCOMPLETE",
            1 => "VK_NOT_READY",
            2 => "VK_TIMEOUT",
            3 => "VK_EVENT_SET",
            4 => "VK_EVENT_RESET",
            -1 => "VK_ERROR_OUT_OF_HOST_MEMORY",
            -2 => "VK_ERROR_OUT_OF_DEVICE_MEMORY",
            -3 => "VK_ERROR_INITIALIZATION_FAILED",
            -4 => "VK_ERROR_DEVICE_LOST",
            -5 => "VK_ERROR_MEMORY_MAP_FAILED",
            -6 => "VK_ERROR_LAYER_NOT_PRESENT",
            -7 => "VK_ERROR_EXTENSION_NOT_PRESENT",
            -8 => "VK_ERROR_FEATURE_NOT_PRESENT",
            -9 => "VK_ERROR_INCOMPATIBLE_DRIVER",
            -10 => "VK_ERROR_TOO_MANY_OBJECTS",
            -11 => "VK_ERROR_FORMAT_NOT_SUPPORTED",
            -1000000000 => "VK_ERROR_SURFACE_LOST_KHR",
            -1000000001 => "VK_ERROR_NATIVE_WINDOW_IN_USE_KHR",
            1000001003 => "VK_SUBOPTIMAL_KHR",
            -1000001004 => "VK_ERROR_OUT_OF_DATE_KHR",
            _ => "UNKNOWN",
        };

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=B56DE7
    // Broiler-Falsified-If: the value is read at the buffer plus offset times four rather than plus offset, so vendorId at offset 8 is taken from byte 32
    // Broiler-Human:        PENDING
    private static uint ReadUInt32(IntPtr buffer, int offset) =>
        unchecked((uint)Marshal.ReadInt32(buffer, offset));

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=CDA262
    // Broiler-Human:        PENDING
    private static string FormatPhysicalDeviceType(uint deviceType) =>
        deviceType switch
        {
            1 => "integrated-gpu",
            2 => "discrete-gpu",
            3 => "virtual-gpu",
            4 => "cpu",
            _ => "other",
        };
}
