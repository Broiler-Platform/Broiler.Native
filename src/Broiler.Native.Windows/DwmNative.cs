// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   2
// Annotated:        2/2
// Exempt:           1
// Human-reviewed:   0/2
// IP risk:          Low
// Security risk:    Low
// Criteria:         0/0
// Resource impact:  0/10 max
// Unverified:       2
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows;

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=6E9EA3
// Broiler-Human:        PENDING
public static partial class DwmNative
{
    public const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=23C8A7
    // Broiler-Human:        PENDING
    [LibraryImport("dwmapi.dll")]
    public static partial int DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, uint cbAttribute);
}
