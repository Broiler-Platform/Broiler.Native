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
// Broiler-Falsified-If: vkEnumeratePhysicalDevices or vkGetPhysicalDeviceQueueFamilyProperties receives its count and array arguments in swapped positions, so the driver writes handles or 24-byte entries through the count's address
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
    // Broiler-Falsified-If: apiVersion is declared with a width other than uint32_t, so the loader's write leaves part of the out local undefined or overruns it
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkEnumerateInstanceVersion")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial int EnumerateInstanceVersion(out uint apiVersion);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=5CE6EF
    // Broiler-Falsified-If: createInfo and allocator reach vkCreateInstance(const VkInstanceCreateInfo*, const VkAllocationCallbacks*, VkInstance*) in swapped positions, so the loader calls through the create-info fields as allocation callbacks
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkCreateInstance")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int CreateInstance(ref VkInstanceCreateInfo createInfo, IntPtr allocator, out IntPtr instance);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=98A399
    // Broiler-Falsified-If: instance and allocator reach vkDestroyInstance(VkInstance, const VkAllocationCallbacks*) in swapped positions, so the loader reads allocation callbacks through the instance handle
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkDestroyInstance")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DestroyInstance(IntPtr instance, IntPtr allocator);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=0003C3
    // Broiler-Falsified-If: physicalDevices is not marshalled as an out array of pointer-sized handles, so the loader writes 8-byte VkPhysicalDevice handles into narrower elements and runs past the pinned array
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkEnumeratePhysicalDevices")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int EnumeratePhysicalDevices(IntPtr instance, ref uint physicalDeviceCount, [Out] IntPtr[]? physicalDevices);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=8B21E9
    // Broiler-Falsified-If: the count and the properties array reach vkGetPhysicalDeviceQueueFamilyProperties in swapped positions, so the driver writes the family count through the array and 24-byte entries through the count's address
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GetPhysicalDeviceQueueFamilyProperties(IntPtr physicalDevice, ref uint queueFamilyPropertyCount,
        [Out] VkQueueFamilyProperties[]? queueFamilyProperties);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=89BCFE
    // Broiler-Falsified-If: physicalDevice and properties reach vkGetPhysicalDeviceProperties in swapped positions, so the driver writes the 824-byte properties structure over the physical-device object
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkGetPhysicalDeviceProperties")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void GetPhysicalDeviceProperties(IntPtr physicalDevice, IntPtr properties);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=59040F
    // Broiler-Falsified-If: createInfo and allocator reach vkCreateDevice(VkPhysicalDevice, const VkDeviceCreateInfo*, const VkAllocationCallbacks*, VkDevice*) in swapped positions, so the driver calls through the create-info fields as allocation callbacks
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkCreateDevice")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int CreateDevice(IntPtr physicalDevice, ref VkDeviceCreateInfo createInfo, IntPtr allocator, out IntPtr device);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=19195C
    // Broiler-Falsified-If: device and allocator reach vkDestroyDevice(VkDevice, const VkAllocationCallbacks*) in swapped positions, so the driver reads allocation callbacks through the device handle
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkDestroyDevice")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DestroyDevice(IntPtr device, IntPtr allocator);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=933A0D
    // Broiler-Falsified-If: queueFamilyIndex and queueIndex reach vkGetDeviceQueue(VkDevice, uint32_t, uint32_t, VkQueue*) in swapped positions, so the queue at index 1 of family 0 is requested as index 0 of family 1
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkGetDeviceQueue")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GetDeviceQueue(IntPtr device, uint queueFamilyIndex, uint queueIndex, out IntPtr queue);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=3C80E2
    // Broiler-Falsified-If: the import binds an export other than vkDeviceWaitIdle, such as vkQueueWaitIdle, so the call returns while work on the device's other queues is still running
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkDeviceWaitIdle")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int DeviceWaitIdle(IntPtr device);

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=2B62F4
    // Broiler-Falsified-If: Marshal.SizeOf is not 48 on 64-bit or apiVersion is not at offset 44, so the loader reads the requested API version from the wrong bytes
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
    // Broiler-Falsified-If: Marshal.SizeOf is not 64 on 64-bit or ppEnabledExtensionNames is not at offset 56, so the loader treats a count or padding as a pointer
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
    // Broiler-Falsified-If: Marshal.SizeOf is not 40 on 64-bit or pQueuePriorities is not at offset 32, so the driver reads queue priorities through the wrong bytes
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
    // Broiler-Falsified-If: Marshal.SizeOf is not 72 on 64-bit or pEnabledFeatures is not at offset 64, so the driver dereferences a count or padding as the features pointer
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
    // Broiler-Falsified-If: Marshal.SizeOf is not 24, so the driver's array writes use a different stride than the managed elements and overrun the last one
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
    // Broiler-Falsified-If: a field is not a 32-bit unsigned value, so the struct is not 12 bytes and VkQueueFamilyProperties no longer matches the driver's 24-byte entries
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
