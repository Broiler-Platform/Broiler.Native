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
// Broiler-Falsified-If: CreateBitmapProc's sourceData and pitch reach ID2D1RenderTarget::CreateBitmap(D2D1_SIZE_U, const void*, UINT32, const D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**) in swapped positions, so Direct2D reads decoded pixels from the address given by the pitch
// Broiler-Human:        PENDING
public static class Direct2DImageStoreApi
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=B276F6
    // Broiler-Falsified-If: sourceData and pitch reach ID2D1RenderTarget::CreateBitmap(D2D1_SIZE_U, const void*, UINT32, const D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**) in swapped positions, so Direct2D reads decoded pixels from the address given by the pitch
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CreateBitmapProc(IntPtr self, D2DNative.D2D1_SIZE_U size, IntPtr sourceData, uint pitch, 
        ref D2DNative.D2D1_BITMAP_PROPERTIES properties, out IntPtr bitmap);
}
