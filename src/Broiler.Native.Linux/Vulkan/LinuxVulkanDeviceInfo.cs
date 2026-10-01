// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   2
// Annotated:        2/2
// Exempt:           0
// Human-reviewed:   0/2
// IP risk:          Low
// Security risk:    Low
// Criteria:         0/0
// Resource impact:  1/10 max
// Unverified:       2
//
// GENERATED - DO NOT EDIT MANUALLY

namespace Broiler.Native.Linux.Vulkan;

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=1; Fingerprint=844002
// Broiler-Human:        PENDING
public sealed record LinuxVulkanDeviceInfo(string Name, string DeviceType, string ApiVersion, string DriverVersion, uint VendorId, uint DeviceId)
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=1; Fingerprint=7DD4B0
    // Broiler-Human:        PENDING
    public string ToDiagnosticString() =>
        $"Vulkan device={Name}; type={DeviceType}; api={ApiVersion}; driver={DriverVersion}; vendor=0x{VendorId:X4}; device=0x{DeviceId:X4}.";
}
