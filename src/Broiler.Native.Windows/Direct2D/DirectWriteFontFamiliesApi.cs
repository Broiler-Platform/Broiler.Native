using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

public static class DirectWriteFontFamiliesApi
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetSystemFontCollectionProc(IntPtr self,
        out IntPtr collection, [MarshalAs(UnmanagedType.Bool)] bool checkForUpdates);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint GetFontFamilyCountProc(IntPtr self);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetFontFamilyProc(IntPtr self, uint index, out IntPtr family);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetFamilyNamesProc(IntPtr self, out IntPtr names);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    public delegate int FindLocaleNameProc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string localeName, 
        out uint index, [MarshalAs(UnmanagedType.Bool)] out bool exists);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetStringLengthProc(IntPtr self, uint index, out uint length);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GetStringProc(IntPtr self, uint index, IntPtr buffer, uint size);
}
