// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   3
// Annotated:        3/3
// Exempt:           0
// Human-reviewed:   0/3
// IP risk:          Low
// Security risk:    Low
// Criteria:         2/0
// Resource impact:  0/10 max
// Unverified:       3
//
// GENERATED - DO NOT EDIT MANUALLY

using System;

namespace Broiler.Native.Linux.Vulkan;

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=69C964
// Broiler-Human:        PENDING
public sealed class LinuxVulkanException : InvalidOperationException
{
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=8D9123
    // Broiler-Falsified-If: the message passed in is not the one Message returns
    // Broiler-Human:        PENDING
    public LinuxVulkanException(string message) : base(message) { }

    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=08D2EB
    // Broiler-Falsified-If: the innerException passed in is not the one InnerException returns
    // Broiler-Human:        PENDING
    public LinuxVulkanException(string message, Exception innerException) : base(message, innerException) { }
}
