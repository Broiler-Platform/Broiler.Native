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
// Criteria:         1/0
// Resource impact:  1/10 max
// Unverified:       2
//
// GENERATED - DO NOT EDIT MANUALLY

namespace Broiler.Native.Android;

/// <summary>Identifies the OpenGL ES driver a session is running on.</summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=1; Fingerprint=87D2FA
// Broiler-Human:        PENDING
public sealed record AndroidOpenGlEsDriverInfo(string Vendor, string Renderer, string Version, string ShadingLanguageVersion)
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=1; Fingerprint=345A91
    // Broiler-Falsified-If: a field is printed under another field's label, such as the renderer string printed under the version label
    // Broiler-Human:        PENDING
    public string ToDiagnosticString() =>
        $"OpenGL ES vendor={Vendor}; renderer={Renderer}; version={Version}; glsl={ShadingLanguageVersion}.";
}
