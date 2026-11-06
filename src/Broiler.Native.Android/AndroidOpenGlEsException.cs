// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// HAIRS Code Assurance
// --------------------
// Relevant units:   3
// Annotated:        3/3
// Exempt:           0
// Human-reviewed:   3/3
// IP risk:          Low
// Security risk:    Low
// Criteria:         0/0
// Resource impact:  0/10 max
// Unverified:       0
//
// GENERATED - DO NOT EDIT MANUALLY

using System;

namespace Broiler.Native.Android;

/// <summary>An EGL or OpenGL ES operation failed.</summary>
// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3D13C8
// Hairs-Human:        MaiRat; Fingerprint=3D13C8
public sealed class AndroidOpenGlEsException : InvalidOperationException
{
    // Hairs-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=AECDA5
    // Hairs-Human:        MaiRat; Fingerprint=AECDA5
    public AndroidOpenGlEsException(string message) : base(message) { }

    // Hairs-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=3A5B77
    // Hairs-Human:        MaiRat; Fingerprint=3A5B77
    public AndroidOpenGlEsException(string message, Exception innerException) : base(message, innerException) { }
}
