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
// Broiler-Falsified-If: a member declared out of objidl.h IStream order (Read, Write, Seek, SetSize, CopyTo, Commit, Revert, LockRegion, UnlockRegion, Stat, Clone after IUnknown) sends a call such as Read with a caller buffer to a different native slot
// Broiler-Human:        PENDING
[GeneratedComInterface]
[Guid("0000000c-0000-0000-C000-000000000046")]
public partial interface IStream
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=EBC476
    // Broiler-Falsified-If: Read is not vtable slot 3, the first ISequentialStream method after IUnknown, so a read request reaches Write and the stream copies cb bytes out of the caller's buffer instead of into it
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Read(IntPtr pv, uint cb, out uint pcbRead);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=2AC1C9
    // Broiler-Falsified-If: Write is not vtable slot 4, directly after Read, so a write request reaches Read and the stream copies cb bytes into the caller's buffer instead of out of it
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Write(IntPtr pv, uint cb, out uint pcbWritten);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=2AF8C4
    // Broiler-Falsified-If: Seek(-1, STREAM_SEEK_CUR) does not move the position back by one byte, showing dlibMove is not passed as a signed 64-bit LARGE_INTEGER
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Seek(long dlibMove, uint dwOrigin, out ulong plibNewPosition);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=107363
    // Broiler-Falsified-If: SetSize(n) followed by a seek to the end reports a position other than n, showing libNewSize does not reach IStream::SetSize as a 64-bit ULARGE_INTEGER
    // Broiler-Human:        PENDING
    [PreserveSig]
    int SetSize(ulong libNewSize);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=8B6736
    // Broiler-Falsified-If: after CopyTo of n bytes between two HGlobal streams pcbRead or pcbWritten differs from n, showing the two ULARGE_INTEGER out pointers are swapped or narrowed
    // Broiler-Human:        PENDING
    [PreserveSig]
    int CopyTo(IStream pstm, ulong cb, out ulong pcbRead, out ulong pcbWritten);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=6A4557
    // Broiler-Falsified-If: Commit(STGC_DEFAULT) on a CreateStreamOnHGlobal stream returns a failure or changes its size or position, showing the call reaches a slot other than IStream::Commit
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Commit(uint grfCommitFlags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=94840D
    // Broiler-Falsified-If: Revert on a CreateStreamOnHGlobal stream returns a failure or changes its size or seek position, showing the call reaches a slot other than IStream::Revert
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Revert();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=DD2680
    // Broiler-Falsified-If: LockRegion on a CreateStreamOnHGlobal stream returns something other than STG_E_INVALIDFUNCTION (0x80030001), showing the call reaches a slot other than IStream::LockRegion
    // Broiler-Human:        PENDING
    [PreserveSig]
    int LockRegion(ulong libOffset, ulong cb, uint dwLockType);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0DB8D7
    // Broiler-Falsified-If: UnlockRegion on a CreateStreamOnHGlobal stream returns something other than STG_E_INVALIDFUNCTION (0x80030001), showing the call reaches a slot other than IStream::UnlockRegion
    // Broiler-Human:        PENDING
    [PreserveSig]
    int UnlockRegion(ulong libOffset, ulong cb, uint dwLockType);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=D1A188
    // Broiler-Falsified-If: Stat is not vtable slot 12, after UnlockRegion, so a stat request reaches Clone and an IStream pointer is written into the STATSTG buffer
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Stat(IntPtr pstatstg, uint grfStatFlag);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=C91B52
    // Broiler-Falsified-If: moving the seek pointer of the stream returned by Clone also moves the original's, or the clone does not read the original's bytes, showing the call reaches a slot other than IStream::Clone
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
    // Broiler-Falsified-If: CoInitializeEx with COINIT_MULTITHREADED on a thread already in a single-threaded apartment returns something other than RPC_E_CHANGED_MODE, showing the HRESULT is not returned unchanged
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial int CoInitializeEx(IntPtr reserved, uint coInit);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=1CDFE8
    // Broiler-Falsified-If: the import binds an export other than ole32's CoUninitialize, so the thread's apartment initialisation count is not lowered and a later CoInitializeEx on it still returns S_FALSE
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial void CoUninitialize();

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=396F43
    // Broiler-Falsified-If: the import binds an export other than ole32's CoTaskMemFree, such as GlobalFree, so a string returned by IMMDevice.GetId is released to another heap
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial void CoTaskMemFree(IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=F9E5E6
    // Broiler-Falsified-If: rclsid or riid is passed by value rather than as a REFCLSID or REFIID pointer, so ole32 reads the first bytes of the GUID as an address
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial int CoCreateInstance(in Guid rclsid, IntPtr pUnkOuter, uint dwClsContext, in Guid riid, out IntPtr ppv);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=4C1BCE
    // Broiler-Falsified-If: the object returned on success is not a built-in runtime-callable wrapper, so ComNative.ReleaseComObject leaves the activation's native reference held until finalization
    // Broiler-Human:        PENDING
    [DllImport("ole32.dll")]
    public static extern int CoCreateInstance(ref Guid classId, IntPtr outerUnknown, uint classContext,
        ref Guid interfaceId, [MarshalAs(UnmanagedType.IUnknown)] out object? instance);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=DE546D
    // Broiler-Falsified-If: after a successful call the activation's own +1 out reference is still held once the managed IWICImagingFactory wrapper has been collected, showing the generated marshaller kept it as well as the wrapper's reference
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial int CoCreateInstance(in Guid rclsid, IntPtr pUnkOuter, uint dwClsContext, in Guid riid, out WicNative.IWICImagingFactory ppv);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=B90342
    // Broiler-Falsified-If: fDeleteOnRelease is not marshalled as a 4-byte BOOL, so a false request reaches ole32 with stray upper bytes and the stream frees an HGLOBAL the caller still owns
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
