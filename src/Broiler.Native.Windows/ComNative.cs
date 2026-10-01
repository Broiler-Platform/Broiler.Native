// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   24
// Annotated:        24/24
// Exempt:           8
// Human-reviewed:   0/24
// IP risk:          Low
// Security risk:    Critical
// Criteria:         24/24
// Resource impact:  3/10 max
// Unverified:       24
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Versioning;
using Broiler.Native.Windows.Wic;

namespace Broiler.Native.Windows;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=72C7E0
// Broiler-Falsified-If: the member order differs from ISequentialStream then IStream in objidlbase.h, whose vtable runs from Read at slot 3 to Clone at slot 13 after the three IUnknown slots
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("0000000c-0000-0000-C000-000000000046")]
public partial interface IStream
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=EBC476
    // Broiler-Falsified-If: is not slot 3 of IStream, HRESULT Read(void *pv, ULONG cb, ULONG *pcbRead) of ISequentialStream in objidlbase.h, which writes up to cb bytes at pv
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Read(IntPtr pv, uint cb, out uint pcbRead);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=2AC1C9
    // Broiler-Falsified-If: is not slot 4 of IStream, HRESULT Write(const void *pv, ULONG cb, ULONG *pcbWritten) of ISequentialStream in objidlbase.h, which reads cb bytes at pv
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Write(IntPtr pv, uint cb, out uint pcbWritten);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=2AF8C4
    // Broiler-Falsified-If: is not slot 5 of IStream, HRESULT Seek(LARGE_INTEGER dlibMove, DWORD dwOrigin, ULARGE_INTEGER *plibNewPosition) in objidlbase.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Seek(long dlibMove, uint dwOrigin, out ulong plibNewPosition);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=107363
    // Broiler-Falsified-If: is not slot 6 of IStream, HRESULT SetSize(ULARGE_INTEGER libNewSize) in objidlbase.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetSize(ulong libNewSize);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=8B6736
    // Broiler-Falsified-If: is not slot 7 of IStream, HRESULT CopyTo(IStream *pstm, ULARGE_INTEGER cb, ULARGE_INTEGER *pcbRead, ULARGE_INTEGER *pcbWritten) in objidlbase.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CopyTo(IStream pstm, ulong cb, out ulong pcbRead, out ulong pcbWritten);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=6A4557
    // Broiler-Falsified-If: is not slot 8 of IStream, HRESULT Commit(DWORD grfCommitFlags) in objidlbase.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Commit(uint grfCommitFlags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=94840D
    // Broiler-Falsified-If: is not slot 9 of IStream, HRESULT Revert(void) in objidlbase.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Revert();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=DD2680
    // Broiler-Falsified-If: is not slot 10 of IStream, HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, DWORD dwLockType) in objidlbase.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int LockRegion(ulong libOffset, ulong cb, uint dwLockType);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0DB8D7
    // Broiler-Falsified-If: is not slot 11 of IStream, HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, DWORD dwLockType) in objidlbase.h
    // Broiler-Human:        PENDING
    [PreserveSig]
    int UnlockRegion(ulong libOffset, ulong cb, uint dwLockType);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=D1A188
    // Broiler-Falsified-If: is not slot 12 of IStream, HRESULT Stat(STATSTG *pstatstg, DWORD grfStatFlag) in objidlbase.h, or pstatstg addresses fewer than the 80 bytes a STATSTG takes on 64-bit
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Stat(IntPtr pstatstg, uint grfStatFlag);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=C91B52
    // Broiler-Falsified-If: is not slot 13 of IStream, HRESULT Clone(IStream **ppstm) in objidlbase.h, or the reference written to *ppstm is still held after the returned wrapper is released
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Clone(out IStream ppstm);
}

/// <summary>Shared COM initialization, activation, allocation, and ownership operations.</summary>
// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=E10EF6
// Broiler-Falsified-If: ReleaseIUnknown lowers a non-null pointer's reference count by other than exactly one, or CoTaskMemFree binds an export other than ole32's, so an object or block another holder still uses is freed
// Broiler-Human:        PENDING
public static partial class ComNative
{
    public const int S_OK = 0;
    public const int S_FALSE = 1;
    public const int E_ACCESSDENIED = unchecked((int)0x80070005);
    public const int E_NOTFOUND = unchecked((int)0x80070490);
    public const int RPC_E_CHANGED_MODE = unchecked((int)0x80010106);
    public const uint COINIT_MULTITHREADED = 0x0;
    public const uint CLSCTX_INPROC_SERVER = 0x1;
    public const int E_NOINTERFACE = unchecked((int)0x80004002);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=2EB7A1
    // Broiler-Falsified-If: a pointer wrapped through this instance cannot be cast to a [GeneratedComInterface] interface the native object implements, showing the instance lacks the source-generated interface strategy
    // Broiler-Human:        PENDING
    private static readonly StrategyBasedComWrappers s_comWrappers = new();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=29F17C
    // Broiler-Falsified-If: differs from HRESULT CoInitializeEx(LPVOID pvReserved, DWORD dwCoInit) in combaseapi.h
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial int CoInitializeEx(IntPtr reserved, uint coInit);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=1CDFE8
    // Broiler-Falsified-If: differs from void CoUninitialize(void) in combaseapi.h
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial void CoUninitialize();

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=396F43
    // Broiler-Falsified-If: differs from void CoTaskMemFree(LPVOID pv) in combaseapi.h
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial void CoTaskMemFree(IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=F9E5E6
    // Broiler-Falsified-If: differs from HRESULT CoCreateInstance(REFCLSID rclsid, LPUNKNOWN pUnkOuter, DWORD dwClsContext, REFIID riid, LPVOID *ppv) in combaseapi.h
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial int CoCreateInstance(in Guid rclsid, IntPtr pUnkOuter, uint dwClsContext, in Guid riid, out IntPtr ppv);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=4C1BCE
    // Broiler-Falsified-If: differs from HRESULT CoCreateInstance(REFCLSID rclsid, LPUNKNOWN pUnkOuter, DWORD dwClsContext, REFIID riid, LPVOID *ppv) in combaseapi.h, or the reference written to *ppv is still held after ComNative.ReleaseComObject releases the returned runtime-callable wrapper
    // Broiler-Human:        PENDING
    [DllImport("ole32.dll")]
    public static extern int CoCreateInstance(ref Guid classId, IntPtr outerUnknown, uint classContext,
        ref Guid interfaceId, [MarshalAs(UnmanagedType.IUnknown)] out object? instance);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=DE546D
    // Broiler-Falsified-If: differs from HRESULT CoCreateInstance(REFCLSID rclsid, LPUNKNOWN pUnkOuter, DWORD dwClsContext, REFIID riid, LPVOID *ppv) in combaseapi.h, or the reference written to *ppv is still held once the returned IWICImagingFactory wrapper has been collected
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial int CoCreateInstance(in Guid rclsid, IntPtr pUnkOuter, uint dwClsContext, in Guid riid, out WicNative.IWICImagingFactory ppv);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=B90342
    // Broiler-Falsified-If: fDeleteOnRelease is not marshalled as the 4-byte BOOL of HRESULT CreateStreamOnHGlobal(HGLOBAL hGlobal, BOOL fDeleteOnRelease, LPSTREAM *ppstm) in combaseapi.h
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial int CreateStreamOnHGlobal(IntPtr hGlobal, [MarshalAs(UnmanagedType.Bool)] bool fDeleteOnRelease, out IStream ppstm);

    /// <summary>
    /// Wraps a raw COM interface pointer into a source-generated COM interface instance, AOT-safely.
    /// </summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=92D005
    // Broiler-Falsified-If: after the caller releases its own reference to comPointer the returned wrapper points at a destroyed object, showing the wrapper took no native reference of its own
    // Broiler-Human:        PENDING
    public static TInterface? GetOrCreateComObject<TInterface>(IntPtr comPointer) where TInterface : class
    {
        if (comPointer == IntPtr.Zero)
            return null;

        return (TInterface)s_comWrappers.GetOrCreateObjectForComInstance(comPointer, CreateObjectFlags.None);
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=455A91
    // Broiler-Falsified-If: one call on a non-null pointer lowers its native reference count by other than exactly one
    // Broiler-Human:        PENDING
    public static void ReleaseIUnknown(IntPtr value)
    {
        if (value != IntPtr.Zero)
            Marshal.Release(value);
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=EFB4EB
    // Broiler-Falsified-If: a source-generated ComObject (from a [GeneratedComInterface] out parameter or GetOrCreateComObject) is neither IsComObject nor IDisposable, so the call returns with its native reference still held until finalization
    // Broiler-Human:        PENDING
    [SupportedOSPlatform("windows")]
    public static void ReleaseComObject(object? value)
    {
        if (value is null)
            return;

        try
        {
            if (Marshal.IsComObject(value))
            {
                Marshal.ReleaseComObject(value);
                return;
            }
        }
        catch (PlatformNotSupportedException)
        {
            // Built-in COM marshaling is disabled or unsupported under NativeAOT.
        }

        if (value is IDisposable disposable)
        {
            disposable.Dispose();
        }
    }
}
