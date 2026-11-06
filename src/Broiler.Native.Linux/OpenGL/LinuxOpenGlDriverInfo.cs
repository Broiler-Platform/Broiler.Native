// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// HAIRS Code Assurance
// --------------------
// Relevant units:   2
// Annotated:        2/2
// Exempt:           0
// Human-reviewed:   2/2
// IP risk:          Low
// Security risk:    Low
// Criteria:         0/0
// Resource impact:  1/10 max
// Unverified:       0
//
// GENERATED - DO NOT EDIT MANUALLY

namespace Broiler.Native.Linux.OpenGL;

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=1; Fingerprint=1A8EF8
// Hairs-Human:        MaiRat; Fingerprint=1A8EF8
public sealed record LinuxOpenGlDriverInfo(string Vendor, string Renderer, string Version, string ShadingLanguageVersion)
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=1; Fingerprint=77BC4A
    // Hairs-Human:        MaiRat; Fingerprint=77BC4A
    public string ToDiagnosticString() =>
        $"OpenGL vendor={Vendor}; renderer={Renderer}; version={Version}; glsl={ShadingLanguageVersion}.";
}
