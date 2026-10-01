// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
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

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=5EFA14
// Broiler-Falsified-If: a nested interface differs from its wincodec.h declaration of IWICBitmapFrameDecode, IWICFormatConverter, IWICBitmapDecoder or IWICImagingFactory in slot order or in a member prototype
// Broiler-Human:        PENDING
public static partial class WicNative
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=1783FD
    // Broiler-Falsified-If: its vtable is not the IWICBitmapFrameDecode order of wincodec.h, IWICBitmapSource GetSize at slot 3 through CopyPixels at slot 7, then GetMetadataQueryReader at slot 8 through GetThumbnail at slot 10
    // Broiler-Human:        PENDING
    [GeneratedComInterface]
    [Guid("3b16811b-6a43-4ec9-a813-3d930c13b940")]
    public partial interface IWICBitmapFrameDecode
    {
        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7C536B
        // Broiler-Falsified-If: is not slot 3 of IWICBitmapFrameDecode, HRESULT GetSize(UINT *puiWidth, UINT *puiHeight) of IWICBitmapSource in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetSize(out uint puiWidth, out uint puiHeight);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=69EFDA
        // Broiler-Falsified-If: is not slot 4 of IWICBitmapFrameDecode, HRESULT GetPixelFormat(WICPixelFormatGUID *pPixelFormat) of IWICBitmapSource in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetPixelFormat(out Guid pPixelFormat);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2054F8
        // Broiler-Falsified-If: is not slot 5 of IWICBitmapFrameDecode, HRESULT GetResolution(double *pDpiX, double *pDpiY) of IWICBitmapSource in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetResolution(out double pDpiX, out double pDpiY);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACA555
        // Broiler-Falsified-If: is not slot 6 of IWICBitmapFrameDecode, HRESULT CopyPalette(IWICPalette *pIPalette) of IWICBitmapSource in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CopyPalette(IntPtr pIPalette);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=19BB8D
        // Broiler-Falsified-If: is not slot 7 of IWICBitmapFrameDecode, HRESULT CopyPixels(const WICRect *prc, UINT cbStride, UINT cbBufferSize, BYTE *pbBuffer) of IWICBitmapSource in wincodec.h, or pbBuffer holds fewer than the cbBufferSize bytes passed with it
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CopyPixels(IntPtr prc, uint cbStride, uint cbBufferSize, IntPtr pbBuffer);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=5B4345
        // Broiler-Falsified-If: is not slot 8 of IWICBitmapFrameDecode, HRESULT GetMetadataQueryReader(IWICMetadataQueryReader **ppIMetadataQueryReader) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetMetadataQueryReader(out IntPtr ppIMetadataQueryReader);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=2E33A1
        // Broiler-Falsified-If: is not slot 9 of IWICBitmapFrameDecode, HRESULT GetColorContexts(UINT cCount, IWICColorContext **ppIColorContexts, UINT *pcActualCount) in wincodec.h, or ppIColorContexts holds fewer than cCount pointers
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetColorContexts(uint cCount, IntPtr ppIColorContexts, out uint pcActualCount);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=F83FCD
        // Broiler-Falsified-If: is not slot 10 of IWICBitmapFrameDecode, HRESULT GetThumbnail(IWICBitmapSource **ppIThumbnail) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetThumbnail(out IntPtr ppIThumbnail);
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=EBC48E
    // Broiler-Falsified-If: its vtable is not the IWICFormatConverter order of wincodec.h, IWICBitmapSource GetSize at slot 3 through CopyPixels at slot 7, then Initialize at slot 8 and CanConvert at slot 9
    // Broiler-Human:        PENDING
    [GeneratedComInterface]
    [Guid("00000301-a8f2-4877-ba0a-fd2b6645fb94")]
    public partial interface IWICFormatConverter
    {
        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7C536B
        // Broiler-Falsified-If: is not slot 3 of IWICFormatConverter, HRESULT GetSize(UINT *puiWidth, UINT *puiHeight) of IWICBitmapSource in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetSize(out uint puiWidth, out uint puiHeight);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=69EFDA
        // Broiler-Falsified-If: is not slot 4 of IWICFormatConverter, HRESULT GetPixelFormat(WICPixelFormatGUID *pPixelFormat) of IWICBitmapSource in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetPixelFormat(out Guid pPixelFormat);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2054F8
        // Broiler-Falsified-If: is not slot 5 of IWICFormatConverter, HRESULT GetResolution(double *pDpiX, double *pDpiY) of IWICBitmapSource in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetResolution(out double pDpiX, out double pDpiY);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACA555
        // Broiler-Falsified-If: is not slot 6 of IWICFormatConverter, HRESULT CopyPalette(IWICPalette *pIPalette) of IWICBitmapSource in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CopyPalette(IntPtr pIPalette);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=19BB8D
        // Broiler-Falsified-If: is not slot 7 of IWICFormatConverter, HRESULT CopyPixels(const WICRect *prc, UINT cbStride, UINT cbBufferSize, BYTE *pbBuffer) of IWICBitmapSource in wincodec.h, or pbBuffer holds fewer than the cbBufferSize bytes passed with it
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CopyPixels(IntPtr prc, uint cbStride, uint cbBufferSize, IntPtr pbBuffer);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=F22BAE
        // Broiler-Falsified-If: is not slot 8 of IWICFormatConverter, HRESULT Initialize(IWICBitmapSource *pISource, REFWICPixelFormatGUID dstFormat, WICBitmapDitherType dither, IWICPalette *pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate) in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int Initialize(IWICBitmapFrameDecode pISource, ref Guid dstFormat, int dither, IntPtr pIPalette,
            double alphaThresholdPercent, int paletteTranslate);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C957AB
        // Broiler-Falsified-If: is not slot 9 of IWICFormatConverter, HRESULT CanConvert(REFWICPixelFormatGUID srcPixelFormat, REFWICPixelFormatGUID dstPixelFormat, BOOL *pfCanConvert) in wincodec.h, or pfCanConvert is received in other than the 4 bytes of a BOOL
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CanConvert(ref Guid srcPixelFormat, ref Guid dstPixelFormat, out int pfCanConvert);
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=F3A325
    // Broiler-Falsified-If: its vtable is not the IWICBitmapDecoder order of wincodec.h, QueryCapability at slot 3 through GetFrame at slot 13
    // Broiler-Human:        PENDING
    [GeneratedComInterface]
    [Guid("9edde9e7-8dee-47ea-99df-e6faf2ed44bf")]
    public partial interface IWICBitmapDecoder
    {
        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=E9B82A
        // Broiler-Falsified-If: is not slot 3 of IWICBitmapDecoder, HRESULT QueryCapability(IStream *pIStream, DWORD *pdwCapability) in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int QueryCapability(IStream pIStream, out uint pdwCapability);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=7; Fingerprint=BFEDCC
        // Broiler-Falsified-If: is not slot 4 of IWICBitmapDecoder, HRESULT Initialize(IStream *pIStream, WICDecodeOptions cacheOptions) in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int Initialize(IStream pIStream, int cacheOptions);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=DCE272
        // Broiler-Falsified-If: is not slot 5 of IWICBitmapDecoder, HRESULT GetContainerFormat(GUID *pguidContainerFormat) in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetContainerFormat(out Guid pguidContainerFormat);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=51BF48
        // Broiler-Falsified-If: is not slot 6 of IWICBitmapDecoder, HRESULT GetDecoderInfo(IWICBitmapDecoderInfo **ppIDecoderInfo) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetDecoderInfo(out IntPtr ppIDecoderInfo);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACA555
        // Broiler-Falsified-If: is not slot 7 of IWICBitmapDecoder, HRESULT CopyPalette(IWICPalette *pIPalette) in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CopyPalette(IntPtr pIPalette);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=5B4345
        // Broiler-Falsified-If: is not slot 8 of IWICBitmapDecoder, HRESULT GetMetadataQueryReader(IWICMetadataQueryReader **ppIMetadataQueryReader) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetMetadataQueryReader(out IntPtr ppIMetadataQueryReader);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=E2D6CB
        // Broiler-Falsified-If: is not slot 9 of IWICBitmapDecoder, HRESULT GetPreview(IWICBitmapSource **ppIBitmapSource) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetPreview(out IntPtr ppIBitmapSource);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=2E33A1
        // Broiler-Falsified-If: is not slot 10 of IWICBitmapDecoder, HRESULT GetColorContexts(UINT cCount, IWICColorContext **ppIColorContexts, UINT *pcActualCount) in wincodec.h, or ppIColorContexts holds fewer than cCount pointers
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetColorContexts(uint cCount, IntPtr ppIColorContexts, out uint pcActualCount);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=F83FCD
        // Broiler-Falsified-If: is not slot 11 of IWICBitmapDecoder, HRESULT GetThumbnail(IWICBitmapSource **ppIThumbnail) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetThumbnail(out IntPtr ppIThumbnail);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=C7763B
        // Broiler-Falsified-If: is not slot 12 of IWICBitmapDecoder, HRESULT GetFrameCount(UINT *pCount) in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetFrameCount(out uint pCount);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=7; Fingerprint=ABCC93
        // Broiler-Falsified-If: is not slot 13 of IWICBitmapDecoder, HRESULT GetFrame(UINT index, IWICBitmapFrameDecode **ppIBitmapFrame) in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetFrame(uint index, out IWICBitmapFrameDecode ppIBitmapFrame);
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=A8CD55
    // Broiler-Falsified-If: its first slots are not the IWICImagingFactory order of wincodec.h, CreateDecoderFromFilename at slot 3 through CreateFormatConverter at slot 10
    // Broiler-Human:        PENDING
    [GeneratedComInterface]
    [Guid("ec5ec8a9-c395-4314-9c77-54d7a935ff70")]
    public partial interface IWICImagingFactory
    {
        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=777C84
        // Broiler-Falsified-If: is not slot 3 of IWICImagingFactory, HRESULT CreateDecoderFromFilename(LPCWSTR wzFilename, const GUID *pguidVendor, DWORD dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder **ppIDecoder) in wincodec.h, or wzFilename is marshalled as other than NUL-terminated UTF-16
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateDecoderFromFilename([MarshalAs(UnmanagedType.LPWStr)] string wzFilename, IntPtr pguidVendor,
            uint dwDesiredAccess, int metadataOptions, out IWICBitmapDecoder ppIDecoder);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=A96950
        // Broiler-Falsified-If: is not slot 4 of IWICImagingFactory, HRESULT CreateDecoderFromStream(IStream *pIStream, const GUID *pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder **ppIDecoder) in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateDecoderFromStream(IStream pIStream, IntPtr pguidVendor, int metadataOptions, out IWICBitmapDecoder ppIDecoder);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=0FCBE9
        // Broiler-Falsified-If: is not slot 5 of IWICImagingFactory, HRESULT CreateDecoderFromFileHandle(ULONG_PTR hFile, const GUID *pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder **ppIDecoder) in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateDecoderFromFileHandle(IntPtr hFile, IntPtr pguidVendor, int metadataOptions, out IWICBitmapDecoder ppIDecoder);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=84A58A
        // Broiler-Falsified-If: is not slot 6 of IWICImagingFactory, HRESULT CreateComponentInfo(REFCLSID clsidComponent, IWICComponentInfo **ppIInfo) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateComponentInfo(ref Guid clsidComponent, out IntPtr ppIInfo);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=B0ED40
        // Broiler-Falsified-If: is not slot 7 of IWICImagingFactory, HRESULT CreateDecoder(REFGUID guidContainerFormat, const GUID *pguidVendor, IWICBitmapDecoder **ppIDecoder) in wincodec.h
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateDecoder(ref Guid guidContainerFormat, IntPtr pguidVendor, out IWICBitmapDecoder ppIDecoder);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=F89366
        // Broiler-Falsified-If: is not slot 8 of IWICImagingFactory, HRESULT CreateEncoder(REFGUID guidContainerFormat, const GUID *pguidVendor, IWICBitmapEncoder **ppIEncoder) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateEncoder(ref Guid guidContainerFormat, IntPtr pguidVendor, out IntPtr ppIEncoder);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=592ED9
        // Broiler-Falsified-If: is not slot 9 of IWICImagingFactory, HRESULT CreatePalette(IWICPalette **ppIPalette) in wincodec.h, whose reference arrives as a raw IntPtr that no marshaller releases
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreatePalette(out IntPtr ppIPalette);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=903F42
        // Broiler-Falsified-If: is not slot 10 of IWICImagingFactory, HRESULT CreateFormatConverter(IWICFormatConverter **ppIFormatConverter) in wincodec.h
        // Broiler-Human:        PENDING
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
