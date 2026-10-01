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

namespace Broiler.Native.Linux.OpenGL;

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=1; Fingerprint=1A8EF8
// Broiler-Human:        PENDING
public sealed record LinuxOpenGlDriverInfo(string Vendor, string Renderer, string Version, string ShadingLanguageVersion)
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=1; Fingerprint=77BC4A
    // Broiler-Human:        PENDING
    public string ToDiagnosticString() =>
        $"OpenGL vendor={Vendor}; renderer={Renderer}; version={Version}; glsl={ShadingLanguageVersion}.";
}
