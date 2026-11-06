// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// HAIRS Code Assurance
// --------------------
// Relevant units:   39
// Annotated:        39/39
// Exempt:           8
// Human-reviewed:   0/39
// IP risk:          Low
// Security risk:    Critical
// Criteria:         39/39
// Resource impact:  8/10 max
// Unverified:       39
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Broiler.Native.Windows.Wic;

// Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=5EFA14
// Hairs-Falsified-If: a nested interface differs from its wincodec.h declaration of IWICBitmapFrameDecode, IWICFormatConverter, IWICBitmapDecoder or IWICImagingFactory in slot order or in a member prototype
// Hairs-Human:        PENDING
public static partial class WicNative
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=1783FD
    // Hairs-Falsified-If: its vtable is not the IWICBitmapFrameDecode order of wincodec.h, IWICBitmapSource GetSize at slot 3 through CopyPixels at slot 7, then GetMetadataQueryReader at slot 8 through GetThumbnail at slot 10
    // Hairs-Human:        PENDING
    [GeneratedComInterface]
    [Guid("3b16811b-6a43-4ec9-a813-3d930c13b940")]
    public partial interface IWICBitmapFrameDecode
    {
        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7C536B
        // Hairs-Falsified-If: is not slot 3 of IWICBitmapFrameDecode, HRESULT GetSize(UINT *puiWidth, UINT *puiHeight) of IWICBitmapSource in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetSize(out uint puiWidth, out uint puiHeight);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=69EFDA
        // Hairs-Falsified-If: is not slot 4 of IWICBitmapFrameDecode, HRESULT GetPixelFormat(WICPixelFormatGUID *pPixelFormat) of IWICBitmapSource in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetPixelFormat(out Guid pPixelFormat);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2054F8
        // Hairs-Falsified-If: is not slot 5 of IWICBitmapFrameDecode, HRESULT GetResolution(double *pDpiX, double *pDpiY) of IWICBitmapSource in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetResolution(out double pDpiX, out double pDpiY);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACA555
        // Hairs-Falsified-If: is not slot 6 of IWICBitmapFrameDecode, HRESULT CopyPalette(IWICPalette *pIPalette) of IWICBitmapSource in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CopyPalette(IntPtr pIPalette);

        // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=19BB8D
        // Hairs-Falsified-If: is not slot 7 of IWICBitmapFrameDecode, HRESULT CopyPixels(const WICRect *prc, UINT cbStride, UINT cbBufferSize, BYTE *pbBuffer) of IWICBitmapSource in wincodec.h, or pbBuffer holds fewer than the cbBufferSize bytes passed with it
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CopyPixels(IntPtr prc, uint cbStride, uint cbBufferSize, IntPtr pbBuffer);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=5B4345
        // Hairs-Falsified-If: is not slot 8 of IWICBitmapFrameDecode, HRESULT GetMetadataQueryReader(IWICMetadataQueryReader **ppIMetadataQueryReader) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetMetadataQueryReader(out IntPtr ppIMetadataQueryReader);

        // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=2E33A1
        // Hairs-Falsified-If: is not slot 9 of IWICBitmapFrameDecode, HRESULT GetColorContexts(UINT cCount, IWICColorContext **ppIColorContexts, UINT *pcActualCount) in wincodec.h, or ppIColorContexts holds fewer than cCount pointers
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetColorContexts(uint cCount, IntPtr ppIColorContexts, out uint pcActualCount);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=F83FCD
        // Hairs-Falsified-If: is not slot 10 of IWICBitmapFrameDecode, HRESULT GetThumbnail(IWICBitmapSource **ppIThumbnail) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetThumbnail(out IntPtr ppIThumbnail);
    }

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=EBC48E
    // Hairs-Falsified-If: its vtable is not the IWICFormatConverter order of wincodec.h, IWICBitmapSource GetSize at slot 3 through CopyPixels at slot 7, then Initialize at slot 8 and CanConvert at slot 9
    // Hairs-Human:        PENDING
    [GeneratedComInterface]
    [Guid("00000301-a8f2-4877-ba0a-fd2b6645fb94")]
    public partial interface IWICFormatConverter
    {
        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7C536B
        // Hairs-Falsified-If: is not slot 3 of IWICFormatConverter, HRESULT GetSize(UINT *puiWidth, UINT *puiHeight) of IWICBitmapSource in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetSize(out uint puiWidth, out uint puiHeight);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=69EFDA
        // Hairs-Falsified-If: is not slot 4 of IWICFormatConverter, HRESULT GetPixelFormat(WICPixelFormatGUID *pPixelFormat) of IWICBitmapSource in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetPixelFormat(out Guid pPixelFormat);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2054F8
        // Hairs-Falsified-If: is not slot 5 of IWICFormatConverter, HRESULT GetResolution(double *pDpiX, double *pDpiY) of IWICBitmapSource in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetResolution(out double pDpiX, out double pDpiY);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACA555
        // Hairs-Falsified-If: is not slot 6 of IWICFormatConverter, HRESULT CopyPalette(IWICPalette *pIPalette) of IWICBitmapSource in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CopyPalette(IntPtr pIPalette);

        // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=19BB8D
        // Hairs-Falsified-If: is not slot 7 of IWICFormatConverter, HRESULT CopyPixels(const WICRect *prc, UINT cbStride, UINT cbBufferSize, BYTE *pbBuffer) of IWICBitmapSource in wincodec.h, or pbBuffer holds fewer than the cbBufferSize bytes passed with it
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CopyPixels(IntPtr prc, uint cbStride, uint cbBufferSize, IntPtr pbBuffer);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=F22BAE
        // Hairs-Falsified-If: is not slot 8 of IWICFormatConverter, HRESULT Initialize(IWICBitmapSource *pISource, REFWICPixelFormatGUID dstFormat, WICBitmapDitherType dither, IWICPalette *pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate) in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int Initialize(IWICBitmapFrameDecode pISource, ref Guid dstFormat, int dither, IntPtr pIPalette,
            double alphaThresholdPercent, int paletteTranslate);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C957AB
        // Hairs-Falsified-If: is not slot 9 of IWICFormatConverter, HRESULT CanConvert(REFWICPixelFormatGUID srcPixelFormat, REFWICPixelFormatGUID dstPixelFormat, BOOL *pfCanConvert) in wincodec.h, or pfCanConvert is received in other than the 4 bytes of a BOOL
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CanConvert(ref Guid srcPixelFormat, ref Guid dstPixelFormat, out int pfCanConvert);
    }

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=F3A325
    // Hairs-Falsified-If: its vtable is not the IWICBitmapDecoder order of wincodec.h, QueryCapability at slot 3 through GetFrame at slot 13
    // Hairs-Human:        PENDING
    [GeneratedComInterface]
    [Guid("9edde9e7-8dee-47ea-99df-e6faf2ed44bf")]
    public partial interface IWICBitmapDecoder
    {
        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=E9B82A
        // Hairs-Falsified-If: is not slot 3 of IWICBitmapDecoder, HRESULT QueryCapability(IStream *pIStream, DWORD *pdwCapability) in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int QueryCapability(IStream pIStream, out uint pdwCapability);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=7; Fingerprint=BFEDCC
        // Hairs-Falsified-If: is not slot 4 of IWICBitmapDecoder, HRESULT Initialize(IStream *pIStream, WICDecodeOptions cacheOptions) in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int Initialize(IStream pIStream, int cacheOptions);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=DCE272
        // Hairs-Falsified-If: is not slot 5 of IWICBitmapDecoder, HRESULT GetContainerFormat(GUID *pguidContainerFormat) in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetContainerFormat(out Guid pguidContainerFormat);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=51BF48
        // Hairs-Falsified-If: is not slot 6 of IWICBitmapDecoder, HRESULT GetDecoderInfo(IWICBitmapDecoderInfo **ppIDecoderInfo) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetDecoderInfo(out IntPtr ppIDecoderInfo);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACA555
        // Hairs-Falsified-If: is not slot 7 of IWICBitmapDecoder, HRESULT CopyPalette(IWICPalette *pIPalette) in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CopyPalette(IntPtr pIPalette);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=5B4345
        // Hairs-Falsified-If: is not slot 8 of IWICBitmapDecoder, HRESULT GetMetadataQueryReader(IWICMetadataQueryReader **ppIMetadataQueryReader) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetMetadataQueryReader(out IntPtr ppIMetadataQueryReader);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=E2D6CB
        // Hairs-Falsified-If: is not slot 9 of IWICBitmapDecoder, HRESULT GetPreview(IWICBitmapSource **ppIBitmapSource) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetPreview(out IntPtr ppIBitmapSource);

        // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=2E33A1
        // Hairs-Falsified-If: is not slot 10 of IWICBitmapDecoder, HRESULT GetColorContexts(UINT cCount, IWICColorContext **ppIColorContexts, UINT *pcActualCount) in wincodec.h, or ppIColorContexts holds fewer than cCount pointers
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetColorContexts(uint cCount, IntPtr ppIColorContexts, out uint pcActualCount);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=F83FCD
        // Hairs-Falsified-If: is not slot 11 of IWICBitmapDecoder, HRESULT GetThumbnail(IWICBitmapSource **ppIThumbnail) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetThumbnail(out IntPtr ppIThumbnail);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=C7763B
        // Hairs-Falsified-If: is not slot 12 of IWICBitmapDecoder, HRESULT GetFrameCount(UINT *pCount) in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetFrameCount(out uint pCount);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=7; Fingerprint=ABCC93
        // Hairs-Falsified-If: is not slot 13 of IWICBitmapDecoder, HRESULT GetFrame(UINT index, IWICBitmapFrameDecode **ppIBitmapFrame) in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int GetFrame(uint index, out IWICBitmapFrameDecode ppIBitmapFrame);
    }

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=A8CD55
    // Hairs-Falsified-If: its first slots are not the IWICImagingFactory order of wincodec.h, CreateDecoderFromFilename at slot 3 through CreateFormatConverter at slot 10
    // Hairs-Human:        PENDING
    [GeneratedComInterface]
    [Guid("ec5ec8a9-c395-4314-9c77-54d7a935ff70")]
    public partial interface IWICImagingFactory
    {
        // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=777C84
        // Hairs-Falsified-If: is not slot 3 of IWICImagingFactory, HRESULT CreateDecoderFromFilename(LPCWSTR wzFilename, const GUID *pguidVendor, DWORD dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder **ppIDecoder) in wincodec.h, or wzFilename is marshalled as other than NUL-terminated UTF-16
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CreateDecoderFromFilename([MarshalAs(UnmanagedType.LPWStr)] string wzFilename, IntPtr pguidVendor,
            uint dwDesiredAccess, int metadataOptions, out IWICBitmapDecoder ppIDecoder);

        // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=A96950
        // Hairs-Falsified-If: is not slot 4 of IWICImagingFactory, HRESULT CreateDecoderFromStream(IStream *pIStream, const GUID *pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder **ppIDecoder) in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CreateDecoderFromStream(IStream pIStream, IntPtr pguidVendor, int metadataOptions, out IWICBitmapDecoder ppIDecoder);

        // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=0FCBE9
        // Hairs-Falsified-If: is not slot 5 of IWICImagingFactory, HRESULT CreateDecoderFromFileHandle(ULONG_PTR hFile, const GUID *pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder **ppIDecoder) in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CreateDecoderFromFileHandle(IntPtr hFile, IntPtr pguidVendor, int metadataOptions, out IWICBitmapDecoder ppIDecoder);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=84A58A
        // Hairs-Falsified-If: is not slot 6 of IWICImagingFactory, HRESULT CreateComponentInfo(REFCLSID clsidComponent, IWICComponentInfo **ppIInfo) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CreateComponentInfo(ref Guid clsidComponent, out IntPtr ppIInfo);

        // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=B0ED40
        // Hairs-Falsified-If: is not slot 7 of IWICImagingFactory, HRESULT CreateDecoder(REFGUID guidContainerFormat, const GUID *pguidVendor, IWICBitmapDecoder **ppIDecoder) in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CreateDecoder(ref Guid guidContainerFormat, IntPtr pguidVendor, out IWICBitmapDecoder ppIDecoder);

        // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=F89366
        // Hairs-Falsified-If: is not slot 8 of IWICImagingFactory, HRESULT CreateEncoder(REFGUID guidContainerFormat, const GUID *pguidVendor, IWICBitmapEncoder **ppIEncoder) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CreateEncoder(ref Guid guidContainerFormat, IntPtr pguidVendor, out IntPtr ppIEncoder);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=592ED9
        // Hairs-Falsified-If: is not slot 9 of IWICImagingFactory, HRESULT CreatePalette(IWICPalette **ppIPalette) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CreatePalette(out IntPtr ppIPalette);

        // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=903F42
        // Hairs-Falsified-If: is not slot 10 of IWICImagingFactory, HRESULT CreateFormatConverter(IWICFormatConverter **ppIFormatConverter) in wincodec.h
        // Hairs-Human:        PENDING
        [PreserveSig]
        int CreateFormatConverter(out IWICFormatConverter ppIFormatConverter);
    }
    public const int WinCodecErrUnknownImageFormat = unchecked((int)0x88982F07);
    public const int WinCodecErrComponentNotFound = unchecked((int)0x88982F50);
    public const int WinCodecErrInvalidRegistration = unchecked((int)0x88982F8A);
    public const int WinCodecErrComponentInitializeFailure = unchecked((int)0x88982F8B);
    public static readonly Guid ClsidWicImagingFactory = new("cacaf262-9370-4615-a13b-9f5539da4c0a");
    public static readonly Guid IidWicImagingFactory = new("ec5ec8a9-c395-4314-9c77-54d7a935ff70");
    public static readonly Guid PixelFormat32bppRgba = new("f5c7ad2d-6a8d-43dd-a7a8-a29935261ae9");
    public static readonly Guid PixelFormat32bppBgra = new("6fddc324-4e03-4bfe-b185-3d77768dc90f");
}
