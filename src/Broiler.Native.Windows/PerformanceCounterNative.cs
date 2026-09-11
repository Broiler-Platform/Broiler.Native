using System.Runtime.InteropServices;

namespace Broiler.Native.Windows;

public static partial class PerformanceCounterNative
{
    [LibraryImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool QueryPerformanceCounter(out long performanceCount);

    [LibraryImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool QueryPerformanceFrequency(out long frequency);
}
