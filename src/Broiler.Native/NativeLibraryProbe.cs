using System;
using System.Runtime.InteropServices;

namespace Broiler.Native;

/// <summary>Probes native library availability without retaining a loaded handle.</summary>
public static class NativeLibraryProbe
{
    public static bool IsAvailable(string libraryName)
    {
        if (string.IsNullOrWhiteSpace(libraryName))
            return false;
        if (!NativeLibrary.TryLoad(libraryName, out IntPtr handle))
            return false;
        NativeLibrary.Free(handle);
        return true;
    }
}
