// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   7
// Annotated:        7/7
// Exempt:           0
// Human-reviewed:   0/7
// IP risk:          Low
// Security risk:    Critical
// Criteria:         7/7
// Resource impact:  2/10 max
// Unverified:       7
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

/// <summary>
/// P/Invoke entry points for the DirectX factory-creation functions. These are the only DLL exports
/// the backend needs to bootstrap; every other call goes through COM vtables (see <see cref="ComPtr"/>).
/// All members are <c>public</c>. <see cref="LibraryImport"/> is used for AOT/trimming friendliness.
/// </summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=C630AC
// Broiler-Falsified-If: D3D11CreateDevice receives pFeatureLevels and featureLevels in swapped positions, so the level count is dereferenced as the D3D_FEATURE_LEVEL array
// Broiler-Human:        PENDING
public static partial class NativeMethods
{
    // ---- d3d11.dll -------------------------------------------------------------------------------

    /// <summary>
    /// Creates a Direct3D 11 device used as the backing device for Direct2D interop.
    /// The backend passes a null adapter and feature-level list so the runtime chooses the default
    /// hardware/WARP capabilities for the installed Direct3D runtime.
    /// </summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=B9D586
    // Broiler-Falsified-If: pFeatureLevels and featureLevels reach D3D11CreateDevice in swapped positions, so the level count is dereferenced as the D3D_FEATURE_LEVEL array
    // Broiler-Human:        PENDING
    [LibraryImport("d3d11.dll")]
    public static partial int D3D11CreateDevice(IntPtr pAdapter, D3D11Native.D3D_DRIVER_TYPE driverType, IntPtr software,
        uint flags, IntPtr pFeatureLevels, uint featureLevels, uint sdkVersion, out IntPtr ppDevice,
        out D3D11Native.D3D_FEATURE_LEVEL pFeatureLevel, out IntPtr ppImmediateContext);

    // ---- dxgi.dll --------------------------------------------------------------------------------

    /// <summary>Creates a DXGI 1.1 factory. <paramref name="riid"/> is typically IID_IDXGIFactory1.</summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=260F5E
    // Broiler-Falsified-If: riid is passed as the 16-byte GUID value instead of a REFIID pointer, so dxgi.dll reads the first bytes of the IID as an address
    // Broiler-Human:        PENDING
    [LibraryImport("dxgi.dll")]
    public static partial int CreateDXGIFactory1(in Guid riid, out IntPtr ppFactory);

    // ---- d2d1.dll --------------------------------------------------------------------------------

    /// <summary>
    /// Creates a Direct2D factory. The options blob is optional (pass <see cref="IntPtr.Zero"/>).
    /// </summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=3563F3
    // Broiler-Falsified-If: riid and pFactoryOptions reach D2D1CreateFactory(D2D1_FACTORY_TYPE, REFIID, const D2D1_FACTORY_OPTIONS*, void**) in swapped positions, so d2d1.dll reads the factory options from the IID and dereferences the options pointer as the IID
    // Broiler-Human:        PENDING
    [LibraryImport("d2d1.dll")]
    public static partial int D2D1CreateFactory(D2DNative.D2D1_FACTORY_TYPE factoryType, in Guid riid, IntPtr pFactoryOptions,
        out IntPtr ppIFactory);

    // ---- dwrite.dll ------------------------------------------------------------------------------

    /// <summary>Creates a DirectWrite factory. <paramref name="iid"/> is IID_IDWriteFactory.</summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=F2E7BF
    // Broiler-Falsified-If: iid is passed as the 16-byte GUID value instead of a REFIID pointer, so dwrite.dll reads the first bytes of the IID as an address
    // Broiler-Human:        PENDING
    [LibraryImport("dwrite.dll")]
    public static partial int DWriteCreateFactory(DWriteNative.DWRITE_FACTORY_TYPE factoryType, in Guid iid, out IntPtr factory);

    /// <summary>Returns <c>true</c> for a successful HRESULT (S_OK and other non-negative codes).</summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=74416D
    // Broiler-Falsified-If: an HRESULT with the severity bit set, such as 0x887A0005, returns true, so the caller attaches an out pointer the failed call never wrote
    // Broiler-Human:        PENDING
    public static bool Succeeded(int hr) => hr >= 0;

    /// <summary>Throws a <see cref="MarshalDirectiveException"/>-free wrapper if the HRESULT is a failure.</summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=88558B
    // Broiler-Falsified-If: a failing HRESULT such as 0x80004005 returns without throwing, so the caller attaches the zero out pointer and calls through it
    // Broiler-Human:        PENDING
    public static void ThrowIfFailed(int hr, string what)
    {
        if (hr < 0)
            throw new InvalidOperationException($"{what} failed with HRESULT 0x{hr:X8}.");
    }
}
