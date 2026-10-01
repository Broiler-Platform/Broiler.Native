// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   2
// Annotated:        2/2
// Exempt:           0
// Human-reviewed:   0/2
// IP risk:          Low
// Security risk:    Critical
// Criteria:         2/2
// Resource impact:  7/10 max
// Unverified:       2
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=BF5EB3
// Broiler-Falsified-If: CreateBitmapProc, the one delegate here, is not slot 4 of ID2D1RenderTarget, HRESULT CreateBitmap(D2D1_SIZE_U size, CONST void *srcData, UINT32 pitch, CONST D2D1_BITMAP_PROPERTIES *bitmapProperties, ID2D1Bitmap **bitmap) in d2d1.h, which reads size.height rows pitch bytes apart from srcData
// Broiler-Human:        PENDING
public static class Direct2DImageStoreApi
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=B276F6
    // Broiler-Falsified-If: CreateBitmapProc is not slot 4 of ID2D1RenderTarget, HRESULT CreateBitmap(D2D1_SIZE_U size, CONST void *srcData, UINT32 pitch, CONST D2D1_BITMAP_PROPERTIES *bitmapProperties, ID2D1Bitmap **bitmap) in d2d1.h, which reads size.height rows pitch bytes apart from srcData
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateBitmapProc(IntPtr self, D2DNative.D2D1_SIZE_U size, IntPtr sourceData, uint pitch, 
        ref D2DNative.D2D1_BITMAP_PROPERTIES properties, out IntPtr bitmap);
}
