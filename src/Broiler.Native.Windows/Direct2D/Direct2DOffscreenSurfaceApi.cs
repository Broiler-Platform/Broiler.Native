// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   5
// Annotated:        5/5
// Exempt:           0
// Human-reviewed:   0/5
// IP risk:          Low
// Security risk:    Critical
// Criteria:         5/5
// Resource impact:  7/10 max
// Unverified:       5
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=1DD226
// Broiler-Falsified-If: a CreateBitmap1Proc call whose non-null sourceData holds fewer than pitch times size.Height bytes makes ID2D1DeviceContext::CreateBitmap read past the caller buffer
// Broiler-Human:        PENDING
public static class Direct2DOffscreenSurfaceApi
{

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=A118A6
    // Broiler-Falsified-If: a non-null sourceData holds fewer than pitch times size.Height bytes, so ID2D1DeviceContext::CreateBitmap reads past the end of the caller pixel buffer
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateBitmap1Proc(IntPtr self, D2DNative.D2D1_SIZE_U size, IntPtr sourceData, uint pitch,
        ref D2DNative.D2D1_BITMAP_PROPERTIES1 bitmapProperties, out IntPtr bitmap);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=622C7A
    // Broiler-Falsified-If: a non-null destinationPoint or sourceRect does not point at a D2D1_POINT_2U or D2D1_RECT_U, so CopyFromBitmap reads its coordinates from unrelated memory
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CopyFromBitmapProc(IntPtr self, IntPtr destinationPoint, IntPtr bitmap, IntPtr sourceRect);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=37BC4C
    // Broiler-Falsified-If: a reader takes more than Pitch times the bitmap pixel height bytes through the mapped Bits pointer, reading outside the mapped surface
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int MapProc(IntPtr self, D2DNative.D2D1_MAP_OPTIONS options, out D2DNative.D2D1_MAPPED_RECT mappedRect);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4A016C
    // Broiler-Falsified-If: a reader still dereferences the Bits pointer from MapProc after UnmapProc has returned for the same bitmap
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int UnmapProc(IntPtr self);

}
