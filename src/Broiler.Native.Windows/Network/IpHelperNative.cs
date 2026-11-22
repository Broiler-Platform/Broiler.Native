// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Network;

/// <summary>
/// Windows IP Helper (iphlpapi.dll) socket table bindings from iphlpapi.h.
/// </summary>
public static partial class IpHelperNative
{
    [LibraryImport("iphlpapi.dll")]
    public static partial uint GetExtendedTcpTable(
        IntPtr tcpTable,
        ref int size,
        [MarshalAs(UnmanagedType.Bool)] bool order,
        int addressFamily,
        int tableClass,
        uint reserved);

    [LibraryImport("iphlpapi.dll")]
    public static partial uint GetExtendedUdpTable(
        IntPtr udpTable,
        ref int size,
        [MarshalAs(UnmanagedType.Bool)] bool order,
        int addressFamily,
        int tableClass,
        uint reserved);
}
