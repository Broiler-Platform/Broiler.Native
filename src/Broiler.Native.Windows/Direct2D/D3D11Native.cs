// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   1
// Annotated:        1/1
// Exempt:           21
// Human-reviewed:   0/1
// IP risk:          Low
// Security risk:    None
// Criteria:         0/0
// Resource impact:  0/10 max
// Unverified:       1
//
// GENERATED - DO NOT EDIT MANUALLY

using System;

namespace Broiler.Native.Windows.Direct2D;

/// <summary>
/// Direct3D 11 enums and constants needed to create the backing device for Direct2D interop.
/// We only need enough to call <see cref="NativeMethods.D3D11CreateDevice"/>.
/// </summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=None; Resources=0; Fingerprint=BC2851
// Broiler-Human:        PENDING
public static class D3D11Native
{
    public enum D3D_DRIVER_TYPE : uint
    {
        UNKNOWN = 0,
        HARDWARE = 1,
        REFERENCE = 2,
        NULL = 3,
        SOFTWARE = 4,
        WARP = 5,
    }

    public enum D3D_FEATURE_LEVEL : uint
    {
        LEVEL_9_1 = 0x9100,
        LEVEL_9_2 = 0x9200,
        LEVEL_9_3 = 0x9300,
        LEVEL_10_0 = 0xa000,
        LEVEL_10_1 = 0xa100,
        LEVEL_11_0 = 0xb000,
        LEVEL_11_1 = 0xb100,
    }

    [Flags]
    public enum D3D11_CREATE_DEVICE_FLAG : uint
    {
        NONE = 0,
        SINGLETHREADED = 0x1,
        DEBUG = 0x2,
        BGRA_SUPPORT = 0x20, // required for Direct2D interop
    }

    /// <summary>The value to pass for the SDKVersion parameter of D3D11CreateDevice.</summary>
    public const uint D3D11_SDK_VERSION = 7;
}
