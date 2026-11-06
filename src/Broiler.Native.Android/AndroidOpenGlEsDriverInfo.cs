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

namespace Broiler.Native.Android;

/// <summary>Identifies the OpenGL ES driver a session is running on.</summary>
// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=1; Fingerprint=87D2FA
// Hairs-Human:        MaiRat; Fingerprint=87D2FA
public sealed record AndroidOpenGlEsDriverInfo(string Vendor, string Renderer, string Version, string ShadingLanguageVersion)
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=1; Fingerprint=345A91
    // Hairs-Human:        MaiRat; Fingerprint=345A91
    public string ToDiagnosticString() =>
        $"OpenGL ES vendor={Vendor}; renderer={Renderer}; version={Version}; glsl={ShadingLanguageVersion}.";
}
