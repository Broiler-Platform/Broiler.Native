// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   32
// Annotated:        32/32
// Exempt:           38
// Human-reviewed:   0/32
// IP risk:          Low
// Security risk:    Critical
// Criteria:         32/29
// Resource impact:  2/10 max
// Unverified:       32
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Broiler.Native.Linux.Vulkan;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=E46435
// Broiler-Falsified-If: vkGetPhysicalDeviceProperties or a physical-device or queue-family enumeration writes past the HGlobal buffer or managed array it is given
// Broiler-Human:        PENDING
public static partial class LinuxVulkanNative
{
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E6373E
    // Broiler-Falsified-If: the value is not 0 (vulkan_core.h's VK_SUCCESS), so ThrowIfFailed throws on success or lets a failed vkCreateInstance hand back an unset handle
    // Broiler-Human:        PENDING
    public const int VK_SUCCESS = 0;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=1A4D80
    // Broiler-Falsified-If: the value is not 5 (vulkan_core.h's VK_INCOMPLETE), so ThrowIfFailed lets a different nonzero result such as VK_NOT_READY pass as success
    // Broiler-Human:        PENDING
    public const int VK_INCOMPLETE = 5;

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=748A1F
    // Broiler-Falsified-If: the value is not 0, so the loader rejects or misreads the VkApplicationInfo that pApplicationInfo points to
    // Broiler-Human:        PENDING
    public const uint VK_STRUCTURE_TYPE_APPLICATION_INFO = 0;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=414A99
    // Broiler-Falsified-If: the value is not 1, so vkCreateInstance rejects or misreads the create-info struct by its sType
    // Broiler-Human:        PENDING
    public const uint VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO = 1;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=AFF58A
    // Broiler-Falsified-If: the value is not 2, so vkCreateDevice rejects or misreads the queue create-info entries by their sType
    // Broiler-Human:        PENDING
    public const uint VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO = 2;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=649809
    // Broiler-Falsified-If: the value is not 3, so vkCreateDevice rejects or misreads the device create-info struct by its sType
    // Broiler-Human:        PENDING
    public const uint VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO = 3;

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=4C65A0
    // Broiler-Falsified-If: the value is not 0x1, so a compute-only or transfer-only queue family is selected as the graphics queue for vkCreateDevice and vkGetDeviceQueue
    // Broiler-Human:        PENDING
    public const uint VK_QUEUE_GRAPHICS_BIT = 0x00000001;

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=29F334
    // Broiler-Falsified-If: a variant above 7 is accepted and its high bits are shifted out, returning the same version as variant modulo 8
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
    // Broiler-Falsified-If: a version built by MakeApiVersion(0, 1, 3, 250) does not format as 1.3.250
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
    // Broiler-Falsified-If: an EnabledExtensionCount or EnabledLayerCount larger than the name array it describes makes the loader read name pointers past that allocation
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkCreateInstance")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int CreateInstance(ref VkInstanceCreateInfo createInfo, IntPtr allocator, out IntPtr instance);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=98A399
    // Broiler-Falsified-If: an instance is destroyed while a VkDevice created from it is still alive, or destroyed twice, so the loader frees dispatch tables still in use
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkDestroyInstance")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DestroyInstance(IntPtr instance, IntPtr allocator);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=0003C3
    // Broiler-Falsified-If: a physicalDeviceCount larger than physicalDevices.Length lets the loader write VkPhysicalDevice handles past the end of the pinned array
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkEnumeratePhysicalDevices")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int EnumeratePhysicalDevices(IntPtr instance, ref uint physicalDeviceCount, [Out] IntPtr[]? physicalDevices);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=8B21E9
    // Broiler-Falsified-If: a queueFamilyPropertyCount larger than queueFamilyProperties.Length lets the driver write 24-byte entries past the end of the pinned array
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GetPhysicalDeviceQueueFamilyProperties(IntPtr physicalDevice, ref uint queueFamilyPropertyCount,
        [Out] VkQueueFamilyProperties[]? queueFamilyProperties);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=89BCFE
    // Broiler-Falsified-If: properties points to fewer bytes than VkPhysicalDeviceProperties (824 on 64-bit), so the driver writes past the allocation
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkGetPhysicalDeviceProperties")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void GetPhysicalDeviceProperties(IntPtr physicalDevice, IntPtr properties);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=59040F
    // Broiler-Falsified-If: a QueueCreateInfoCount larger than the VkDeviceQueueCreateInfo entries at PQueueCreateInfos makes the driver read past that allocation
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkCreateDevice")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int CreateDevice(IntPtr physicalDevice, ref VkDeviceCreateInfo createInfo, IntPtr allocator, out IntPtr device);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=19195C
    // Broiler-Falsified-If: a device is destroyed while queue work is still executing because vkDeviceWaitIdle was not called first, so the driver frees resources the GPU is still using
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkDestroyDevice")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DestroyDevice(IntPtr device, IntPtr allocator);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=933A0D
    // Broiler-Falsified-If: a queueIndex at or above the QueueCount requested at device creation is passed, and the driver returns an invalid queue handle instead of failing
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkGetDeviceQueue")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GetDeviceQueue(IntPtr device, uint queueFamilyIndex, uint queueIndex, out IntPtr queue);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=3C80E2
    // Broiler-Falsified-If: DeviceWaitIdle runs while another thread submits to a queue of the same device, which Vulkan requires the caller to synchronize externally
    // Broiler-Human:        PENDING
    [LibraryImport("libvulkan.so.1", EntryPoint = "vkDeviceWaitIdle")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int DeviceWaitIdle(IntPtr device);

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=2B62F4
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

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=D473E7
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

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=CADF59
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
    // Broiler-Falsified-If: a code from vulkan_core.h maps to a different name, for example -9 reported as anything but VK_ERROR_INCOMPATIBLE_DRIVER
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
    // Broiler-Falsified-If: an offset above the allocation size minus 4 reads past the end of the HGlobal buffer, since the offset is not bounded
    // Broiler-Human:        PENDING
    private static uint ReadUInt32(IntPtr buffer, int offset) =>
        unchecked((uint)Marshal.ReadInt32(buffer, offset));

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=CDA262
    // Broiler-Falsified-If: VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU (2) is reported as anything other than discrete-gpu
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
