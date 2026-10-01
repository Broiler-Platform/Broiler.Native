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
// Criteria:         0/0
// Resource impact:  0/10 max
// Unverified:       3
//
// GENERATED - DO NOT EDIT MANUALLY

using System;

namespace Broiler.Native.Linux.OpenGL;

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3783A6
// Broiler-Human:        PENDING
public sealed class LinuxOpenGlException : InvalidOperationException
{
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=17299A
    // Broiler-Human:        PENDING
    public LinuxOpenGlException(string message) : base(message) { }

    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=0F8965
    // Broiler-Human:        PENDING
    public LinuxOpenGlException(string message, Exception innerException) : base(message, innerException) { }
}
