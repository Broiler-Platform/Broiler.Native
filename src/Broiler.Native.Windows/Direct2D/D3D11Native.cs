// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   5
// Annotated:        5/5
// Exempt:           17
// Human-reviewed:   0/5
// IP risk:          Low
// Security risk:    High
// Criteria:         5/5
// Resource impact:  0/10 max
// Unverified:       5
//
// GENERATED - DO NOT EDIT MANUALLY

using System;

namespace Broiler.Native.Windows.Direct2D;

/// <summary>
/// Direct3D 11 enums and constants needed to create the backing device for Direct2D interop.
/// We only need enough to call <see cref="NativeMethods.D3D11CreateDevice"/>.
/// </summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=BC2851
// Broiler-Falsified-If: a value here differs from d3d11.h or d3dcommon.h, for example BGRA_SUPPORT not being 0x20, so D3D11CreateDevice builds a device on which ID2D1Factory1::CreateDevice fails
// Broiler-Human:        PENDING
public static class D3D11Native
{
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=86C69F
    // Broiler-Falsified-If: HARDWARE is not 1 or WARP is not 5 as in d3dcommon.h, so the WARP fallback after a failed hardware D3D11CreateDevice asks for SOFTWARE without a module handle and fails as well
    // Broiler-Human:        PENDING
    public enum D3D_DRIVER_TYPE : uint
    {
        UNKNOWN = 0,
        HARDWARE = 1,
        REFERENCE = 2,
        NULL = 3,
        SOFTWARE = 4,
        WARP = 5,
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=4B4341
    // Broiler-Falsified-If: a member differs from d3dcommon.h (LEVEL_11_0 is 0xb000) or the underlying type is not 32 bits, so the level D3D11CreateDevice writes through pFeatureLevel is misread or overruns its out slot
    // Broiler-Human:        PENDING
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

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=4351CA
    // Broiler-Falsified-If: BGRA_SUPPORT is not 0x20 as in d3d11.h, so the device is created without BGRA support and ID2D1Factory1::CreateDevice on its IDXGIDevice fails
    // Broiler-Human:        PENDING
    [Flags]
    public enum D3D11_CREATE_DEVICE_FLAG : uint
    {
        NONE = 0,
        SINGLETHREADED = 0x1,
        DEBUG = 0x2,
        BGRA_SUPPORT = 0x20, // required for Direct2D interop
    }

    /// <summary>The value to pass for the SDKVersion parameter of D3D11CreateDevice.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=0A1D63
    // Broiler-Falsified-If: the value is not 7 as d3d11.h defines D3D11_SDK_VERSION, so D3D11CreateDevice rejects both the hardware and the WARP attempt and no Direct2D device is created
    // Broiler-Human:        PENDING
    public const uint D3D11_SDK_VERSION = 7;
}
