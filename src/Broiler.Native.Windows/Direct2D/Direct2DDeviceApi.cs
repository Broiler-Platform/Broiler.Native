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
// Security risk:    High
// Criteria:         2/2
// Resource impact:  2/10 max
// Unverified:       2
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

// Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=A189CB
// Broiler-Falsified-If: CreateD2DDeviceProc, the one delegate here, is not slot 17 of ID2D1Factory1, HRESULT CreateDevice(IDXGIDevice *dxgiDevice, ID2D1Device **d2dDevice) in d2d1_1.h
// Broiler-Human:        PENDING
public static class Direct2DDeviceApi
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=6E40F2
    // Broiler-Falsified-If: CreateD2DDeviceProc is not slot 17 of ID2D1Factory1, HRESULT CreateDevice(IDXGIDevice *dxgiDevice, ID2D1Device **d2dDevice) in d2d1_1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateD2DDeviceProc(IntPtr self, IntPtr dxgiDevice, out IntPtr d2dDevice);
}
