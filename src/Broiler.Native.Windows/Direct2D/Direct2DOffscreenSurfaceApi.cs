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
// Broiler-Falsified-If: CreateBitmap1Proc's sourceData and pitch reach ID2D1DeviceContext::CreateBitmap(D2D1_SIZE_U, const void*, UINT32, const D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**) in swapped positions, so Direct2D reads pixels from the address given by the pitch
// Broiler-Human:        PENDING
public static class Direct2DOffscreenSurfaceApi
{

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=A118A6
    // Broiler-Falsified-If: sourceData and pitch reach ID2D1DeviceContext::CreateBitmap(D2D1_SIZE_U, const void*, UINT32, const D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**) in swapped positions, so Direct2D reads pixels from the address given by the pitch
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateBitmap1Proc(IntPtr self, D2DNative.D2D1_SIZE_U size, IntPtr sourceData, uint pitch,
        ref D2DNative.D2D1_BITMAP_PROPERTIES1 bitmapProperties, out IntPtr bitmap);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=622C7A
    // Broiler-Falsified-If: destinationPoint and bitmap reach ID2D1Bitmap::CopyFromBitmap(const D2D1_POINT_2U*, ID2D1Bitmap*, const D2D1_RECT_U*) in swapped positions, so Direct2D reads the destination point from the source bitmap object and calls through null as the bitmap
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CopyFromBitmapProc(IntPtr self, IntPtr destinationPoint, IntPtr bitmap, IntPtr sourceRect);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=37BC4C
    // Broiler-Falsified-If: options and the mapped-rect out reach ID2D1Bitmap1::Map(D2D1_MAP_OPTIONS, D2D1_MAPPED_RECT*) in swapped positions, so Map writes the pitch and bits pointer through the options value as an address
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int MapProc(IntPtr self, D2DNative.D2D1_MAP_OPTIONS options, out D2DNative.D2D1_MAPPED_RECT mappedRect);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4A016C
    // Broiler-Falsified-If: UnmapProc is declared with a parameter beyond self, so a 32-bit stdcall call to ID2D1Bitmap1::Unmap leaves the stack unbalanced by the extra bytes
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int UnmapProc(IntPtr self);

}
