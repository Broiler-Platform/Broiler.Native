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
// Broiler-Falsified-If: CreateBitmap1Proc is not slot 57 of ID2D1DeviceContext, HRESULT CreateBitmap(D2D1_SIZE_U size, CONST void *sourceData, UINT32 pitch, CONST D2D1_BITMAP_PROPERTIES1 *bitmapProperties, ID2D1Bitmap1 **bitmap) in d2d1_1.h, which reads size.height rows pitch bytes apart from sourceData
// Broiler-Human:        PENDING
public static class Direct2DOffscreenSurfaceApi
{

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=A118A6
    // Broiler-Falsified-If: CreateBitmap1Proc is not slot 57 of ID2D1DeviceContext, HRESULT CreateBitmap(D2D1_SIZE_U size, CONST void *sourceData, UINT32 pitch, CONST D2D1_BITMAP_PROPERTIES1 *bitmapProperties, ID2D1Bitmap1 **bitmap) in d2d1_1.h, which reads size.height rows pitch bytes apart from sourceData
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateBitmap1Proc(IntPtr self, D2DNative.D2D1_SIZE_U size, IntPtr sourceData, uint pitch,
        ref D2DNative.D2D1_BITMAP_PROPERTIES1 bitmapProperties, out IntPtr bitmap);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=622C7A
    // Broiler-Falsified-If: CopyFromBitmapProc is not slot 8 of ID2D1Bitmap, HRESULT CopyFromBitmap(CONST D2D1_POINT_2U *destPoint, ID2D1Bitmap *bitmap, CONST D2D1_RECT_U *srcRect) in d2d1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CopyFromBitmapProc(IntPtr self, IntPtr destinationPoint, IntPtr bitmap, IntPtr sourceRect);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=37BC4C
    // Broiler-Falsified-If: MapProc is not slot 14 of ID2D1Bitmap1, HRESULT Map(D2D1_MAP_OPTIONS options, D2D1_MAPPED_RECT *mappedRect) in d2d1_1.h, whose D2D1_MAPPED_RECT is 16 bytes on 64-bit with bits at offset 8
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int MapProc(IntPtr self, D2DNative.D2D1_MAP_OPTIONS options, out D2DNative.D2D1_MAPPED_RECT mappedRect);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4A016C
    // Broiler-Falsified-If: UnmapProc is not slot 15 of ID2D1Bitmap1, HRESULT Unmap() in d2d1_1.h
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int UnmapProc(IntPtr self);

}
