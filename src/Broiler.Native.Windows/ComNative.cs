// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   32
// Annotated:        32/32
// Exempt:           0
// Human-reviewed:   0/32
// IP risk:          Low
// Security risk:    Critical
// Criteria:         32/31
// Resource impact:  3/10 max
// Unverified:       32
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
    // Broiler-Falsified-If: a cb larger than the writable buffer at pv lets the native stream copy up to cb bytes past the end of the caller's memory
    // Broiler-Human:        PENDING
    [PreserveSig]
    int Read(IntPtr pv, uint cb, out uint pcbRead);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=2AC1C9
    // Broiler-Falsified-If: a cb larger than the readable buffer at pv makes the native stream copy bytes from beyond the end of the caller's memory into the stream
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
    // Broiler-Falsified-If: a pstatstg buffer smaller than the native STATSTG (80 bytes on x64, 72 on x86) is overrun when Stat writes the structure
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
// Broiler-Falsified-If: a block or interface pointer that one owner already freed (through CoTaskMemFree, ReleaseIUnknown, or an HGLOBAL a stream deletes on release) is freed or released a second time through these helpers
// Broiler-Human:        PENDING
public static partial class ComNative
{
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=AD5C7E
    // Broiler-Falsified-If: a value other than 0 makes callers that pair a successful CoInitializeEx with CoUninitialize skip it, leaving the thread's apartment initialised after the capture or decode work ends
    // Broiler-Human:        PENDING
    public const int S_OK = 0;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=72A585
    // Broiler-Falsified-If: a value other than 1 makes a nested CoInitializeEx on an already initialised thread skip its matching CoUninitialize, leaving the apartment's initialisation count unbalanced
    // Broiler-Human:        PENDING
    public const int S_FALSE = 1;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=0C6B23
    // Broiler-Falsified-If: a value other than 0x80070005 makes an OS refusal of camera or microphone access surface as a generic native failure instead of PermissionDenied
    // Broiler-Human:        PENDING
    public const int E_ACCESSDENIED = unchecked((int)0x80070005);
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=A76EE8
    // Broiler-Falsified-If: a value other than 0x80070490 makes a machine with no default capture endpoint throw instead of reporting that no microphone is present
    // Broiler-Human:        PENDING
    public const int E_NOTFOUND = unchecked((int)0x80070490);
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=84F45B
    // Broiler-Falsified-If: a value other than 0x80010106 makes COM users on a thread already in a single-threaded apartment fail initialisation instead of continuing without a matching CoUninitialize
    // Broiler-Human:        PENDING
    public const int RPC_E_CHANGED_MODE = unchecked((int)0x80010106);
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=6774C3
    // Broiler-Falsified-If: a value other than 0, such as COINIT_APARTMENTTHREADED (2), puts capture and decode threads in a single-threaded apartment whose interface pointers are then called from other threads
    // Broiler-Human:        PENDING
    public const uint COINIT_MULTITHREADED = 0x0;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E7EBD8
    // Broiler-Falsified-If: a value other than 1 lets CoCreateInstance activate a local or remote server process instead of the in-process WIC, MMDevice or Media Engine library
    // Broiler-Human:        PENDING
    public const uint CLSCTX_INPROC_SERVER = 0x1;
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=FCD1C0
    // Broiler-Falsified-If: a value other than 0x80004002 makes microphone diagnostics print an unnamed HRESULT for a failed interface query
    // Broiler-Human:        PENDING
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
    // Broiler-Falsified-If: a thread calls CoUninitialize more times than CoInitializeEx returned S_OK or S_FALSE on it, tearing down the apartment while interface pointers created there are still released later
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial void CoUninitialize();

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=396F43
    // Broiler-Falsified-If: a pointer not allocated by CoTaskMemAlloc, such as a Marshal.AllocHGlobal block, or one already freed reaches CoTaskMemFree and corrupts the COM task heap
    // Broiler-Human:        PENDING
    [LibraryImport("ole32.dll")]
    public static partial void CoTaskMemFree(IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=F9E5E6
    // Broiler-Falsified-If: the +1 reference returned in ppv on success is not released exactly once by its caller through ReleaseIUnknown or ComPtr, leaking the in-process server or releasing it under another holder
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
    // Broiler-Falsified-If: an hGlobal handed over with fDeleteOnRelease true is also freed by the caller, so the stream's final Release frees the block a second time
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
