using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Versioning;
using Broiler.Native.Windows.Wic;

namespace Broiler.Native.Windows;

[GeneratedComInterface]
[Guid("0000000c-0000-0000-C000-000000000046")]
public partial interface IStream
{
    [PreserveSig]
    int Read(IntPtr pv, uint cb, out uint pcbRead);

    [PreserveSig]
    int Write(IntPtr pv, uint cb, out uint pcbWritten);

    [PreserveSig]
    int Seek(long dlibMove, uint dwOrigin, out ulong plibNewPosition);

    [PreserveSig]
    int SetSize(ulong libNewSize);

    [PreserveSig]
    int CopyTo(IStream pstm, ulong cb, out ulong pcbRead, out ulong pcbWritten);

    [PreserveSig]
    int Commit(uint grfCommitFlags);

    [PreserveSig]
    int Revert();

    [PreserveSig]
    int LockRegion(ulong libOffset, ulong cb, uint dwLockType);

    [PreserveSig]
    int UnlockRegion(ulong libOffset, ulong cb, uint dwLockType);

    [PreserveSig]
    int Stat(IntPtr pstatstg, uint grfStatFlag);

    [PreserveSig]
    int Clone(out IStream ppstm);
}

/// <summary>Shared COM initialization, activation, allocation, and ownership operations.</summary>
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

    private static readonly StrategyBasedComWrappers s_comWrappers = new();

    [LibraryImport("ole32.dll")]
    public static partial int CoInitializeEx(IntPtr reserved, uint coInit);

    [LibraryImport("ole32.dll")]
    public static partial void CoUninitialize();

    [LibraryImport("ole32.dll")]
    public static partial void CoTaskMemFree(IntPtr value);

    [LibraryImport("ole32.dll")]
    public static partial int CoCreateInstance(in Guid rclsid, IntPtr pUnkOuter, uint dwClsContext, in Guid riid, out IntPtr ppv);

    [DllImport("ole32.dll")]
    public static extern int CoCreateInstance(ref Guid classId, IntPtr outerUnknown, uint classContext,
        ref Guid interfaceId, [MarshalAs(UnmanagedType.IUnknown)] out object? instance);

    [LibraryImport("ole32.dll")]
    public static partial int CoCreateInstance(in Guid rclsid, IntPtr pUnkOuter, uint dwClsContext, in Guid riid, out WicNative.IWICImagingFactory ppv);

    [LibraryImport("ole32.dll")]
    public static partial int CreateStreamOnHGlobal(IntPtr hGlobal, [MarshalAs(UnmanagedType.Bool)] bool fDeleteOnRelease, out IStream ppstm);

    /// <summary>
    /// Wraps a raw COM interface pointer into a source-generated COM interface instance, AOT-safely.
    /// </summary>
    public static TInterface? GetOrCreateComObject<TInterface>(IntPtr comPointer) where TInterface : class
    {
        if (comPointer == IntPtr.Zero)
            return null;

        return (TInterface)s_comWrappers.GetOrCreateObjectForComInstance(comPointer, CreateObjectFlags.None);
    }

    public static void ReleaseIUnknown(IntPtr value)
    {
        if (value != IntPtr.Zero)
            Marshal.Release(value);
    }

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
