// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   47
// Annotated:        47/47
// Exempt:           0
// Human-reviewed:   0/47
// IP risk:          Low
// Security risk:    Critical
// Criteria:         47/41
// Resource impact:  8/10 max
// Unverified:       47
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Broiler.Native.Windows.Wic;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=5EFA14
// Broiler-Falsified-If: CopyPixels on a frame or format converter receives cbStride, cbBufferSize and pbBuffer out of order, so the codec writes decoded page-image rows to an address given by a size value
// Broiler-Human:        PENDING
public static partial class WicNative
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=1783FD
    // Broiler-Falsified-If: a member is out of wincodec.h order (IWICBitmapSource's GetSize to CopyPixels at slots 3-7, then GetMetadataQueryReader, GetColorContexts, GetThumbnail), so a call reaches a native method with another argument list that writes through its stride, size or index argument as a pointer
    // Broiler-Human:        PENDING
    [GeneratedComInterface]
    [Guid("3b16811b-6a43-4ec9-a813-3d930c13b940")]
    public partial interface IWICBitmapFrameDecode
    {
        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7C536B
        // Broiler-Falsified-If: GetSize is not vtable slot 3, the first IWICBitmapSource member, so a call reaches GetPixelFormat and native code writes a 16-byte GUID through the 4-byte width out
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetSize(out uint puiWidth, out uint puiHeight);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=69EFDA
        // Broiler-Falsified-If: GetPixelFormat is not vtable slot 4, directly after GetSize, so a call reaches GetResolution and native code writes a second double through an unset argument register
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetPixelFormat(out Guid pPixelFormat);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2054F8
        // Broiler-Falsified-If: pDpiX or pDpiY is declared as a 4-byte float or int rather than an 8-byte double, so native code writes 8 bytes into a 4-byte managed out slot
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetResolution(out double pDpiX, out double pDpiY);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACA555
        // Broiler-Falsified-If: CopyPalette is not vtable slot 6 of IWICBitmapSource, after GetResolution, so the palette pointer reaches CopyPixels as its rectangle and the codec writes pixel rows through unset arguments
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CopyPalette(IntPtr pIPalette);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=19BB8D
        // Broiler-Falsified-If: cbStride, cbBufferSize and pbBuffer reach IWICBitmapSource::CopyPixels(const WICRect*, UINT, UINT, BYTE*) in another order, so the codec writes decoded page-image rows to the address given by a size value
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CopyPixels(IntPtr prc, uint cbStride, uint cbBufferSize, IntPtr pbBuffer);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=5B4345
        // Broiler-Falsified-If: GetMetadataQueryReader is not vtable slot 8, the first after the IWICBitmapSource methods, so the call reaches GetColorContexts with the out pointer as its count and native code dereferences unset array arguments
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetMetadataQueryReader(out IntPtr ppIMetadataQueryReader);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=2E33A1
        // Broiler-Falsified-If: GetColorContexts is not vtable slot 9, after GetMetadataQueryReader, so the count and array pointer reach GetThumbnail and a bitmap-source pointer is written through the count value as an address
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetColorContexts(uint cCount, IntPtr ppIColorContexts, out uint pcActualCount);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=F83FCD
        // Broiler-Falsified-If: GetThumbnail is not vtable slot 10, after GetColorContexts, so the call reaches GetColorContexts with the out pointer as its count and native code dereferences unset array arguments
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetThumbnail(out IntPtr ppIThumbnail);
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=EBC48E
    // Broiler-Falsified-If: a member is out of wincodec.h order (IWICBitmapSource's GetSize to CopyPixels at slots 3-7, then Initialize at 8 and CanConvert at 9), so a call reaches a native method with another argument list that writes through one of its integer arguments as a pointer
    // Broiler-Human:        PENDING
    [GeneratedComInterface]
    [Guid("00000301-a8f2-4877-ba0a-fd2b6645fb94")]
    public partial interface IWICFormatConverter
    {
        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7C536B
        // Broiler-Falsified-If: GetSize is not vtable slot 3, the first IWICBitmapSource member, so a call reaches GetPixelFormat and native code writes a 16-byte GUID through the 4-byte width out that sizes the caller's pixel buffer
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetSize(out uint puiWidth, out uint puiHeight);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=69EFDA
        // Broiler-Falsified-If: GetPixelFormat is not vtable slot 4, directly after GetSize, so a call reaches GetResolution and native code writes a second double through an unset argument register
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetPixelFormat(out Guid pPixelFormat);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2054F8
        // Broiler-Falsified-If: pDpiX or pDpiY is declared as a 4-byte float or int rather than an 8-byte double, so native code writes 8 bytes into a 4-byte managed out slot
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetResolution(out double pDpiX, out double pDpiY);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACA555
        // Broiler-Falsified-If: CopyPalette is not vtable slot 6 of IWICBitmapSource, after GetResolution, so the palette pointer reaches CopyPixels as its rectangle and the codec writes pixel rows through unset arguments
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CopyPalette(IntPtr pIPalette);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=8; Fingerprint=19BB8D
        // Broiler-Falsified-If: cbStride, cbBufferSize and pbBuffer reach IWICBitmapSource::CopyPixels(const WICRect*, UINT, UINT, BYTE*) in another order, so the codec writes converted page-image rows to the address given by a size value
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CopyPixels(IntPtr prc, uint cbStride, uint cbBufferSize, IntPtr pbBuffer);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=F22BAE
        // Broiler-Falsified-If: pISource is marshalled as a pointer to an interface whose slots 3-7 are not IWICBitmapSource's GetSize to CopyPixels, so the converter pulls the source's size and pixels through the wrong native methods
        // Broiler-Human:        PENDING
        [PreserveSig]
        int Initialize(IWICBitmapFrameDecode pISource, ref Guid dstFormat, int dither, IntPtr pIPalette,
            double alphaThresholdPercent, int paletteTranslate);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C957AB
        // Broiler-Falsified-If: pfCanConvert is marshalled as a 1-byte bool rather than a 4-byte BOOL, so native code writes 3 bytes past the managed out slot
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CanConvert(ref Guid srcPixelFormat, ref Guid dstPixelFormat, out int pfCanConvert);
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=F3A325
    // Broiler-Falsified-If: a member is out of wincodec.h order (QueryCapability at slot 3 through GetFrame at slot 13), so a GetFrame call reaches GetFrameCount and native code writes the count through the frame index taken as a pointer
    // Broiler-Human:        PENDING
    [GeneratedComInterface]
    [Guid("9edde9e7-8dee-47ea-99df-e6faf2ed44bf")]
    public partial interface IWICBitmapDecoder
    {
        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=E9B82A
        // Broiler-Falsified-If: QueryCapability is not vtable slot 3, so a probe of page-supplied bytes reaches Initialize and the decoder binds to the stream with the capability out pointer taken as its cache option
        // Broiler-Human:        PENDING
        [PreserveSig]
        int QueryCapability(IStream pIStream, out uint pdwCapability);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=7; Fingerprint=BFEDCC
        // Broiler-Falsified-If: Initialize is not vtable slot 4, directly after QueryCapability, so a call reaches GetContainerFormat and native code writes a 16-byte GUID over the page-supplied IStream object its first argument points to
        // Broiler-Human:        PENDING
        [PreserveSig]
        int Initialize(IStream pIStream, int cacheOptions);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=DCE272
        // Broiler-Falsified-If: the container-format out is declared narrower than the 16-byte GUID, so native code writes the GUID_ContainerFormat value past the managed out slot
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetContainerFormat(out Guid pguidContainerFormat);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=51BF48
        // Broiler-Falsified-If: GetDecoderInfo is not vtable slot 6, after GetContainerFormat, so the call reaches GetContainerFormat and a 16-byte GUID is written through the 8-byte pointer out
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetDecoderInfo(out IntPtr ppIDecoderInfo);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=ACA555
        // Broiler-Falsified-If: CopyPalette is not vtable slot 7 of IWICBitmapDecoder, after GetDecoderInfo, so the palette pointer reaches GetMetadataQueryReader as its out argument and a reader pointer is written into the palette object
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CopyPalette(IntPtr pIPalette);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=5B4345
        // Broiler-Falsified-If: GetMetadataQueryReader is not vtable slot 8 of IWICBitmapDecoder, after CopyPalette, so the call reaches GetPreview and a bitmap source is returned where a metadata reader is expected
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetMetadataQueryReader(out IntPtr ppIMetadataQueryReader);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=E2D6CB
        // Broiler-Falsified-If: GetPreview is not vtable slot 9, after GetMetadataQueryReader, so the call reaches GetColorContexts with the out pointer as its count and native code dereferences unset array arguments
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetPreview(out IntPtr ppIBitmapSource);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=4; Fingerprint=2E33A1
        // Broiler-Falsified-If: GetColorContexts is not vtable slot 10 of IWICBitmapDecoder, after GetPreview, so the count and array pointer reach GetThumbnail and a bitmap-source pointer is written through the count value as an address
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetColorContexts(uint cCount, IntPtr ppIColorContexts, out uint pcActualCount);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=F83FCD
        // Broiler-Falsified-If: GetThumbnail is not vtable slot 11 of IWICBitmapDecoder, after GetColorContexts, so the call reaches GetFrameCount and a 4-byte count is written into the 8-byte pointer out the caller then dereferences
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetThumbnail(out IntPtr ppIThumbnail);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=C7763B
        // Broiler-Falsified-If: GetFrameCount is not vtable slot 12, directly before GetFrame, so a count query reaches GetThumbnail and native code writes an 8-byte interface pointer through the 4-byte count out
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetFrameCount(out uint pCount);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=7; Fingerprint=ABCC93
        // Broiler-Falsified-If: GetFrame is not vtable slot 13, the last IWICBitmapDecoder member, so the call reaches GetFrameCount and native code writes the frame count through the frame index taken as a pointer
        // Broiler-Human:        PENDING
        [PreserveSig]
        int GetFrame(uint index, out IWICBitmapFrameDecode ppIBitmapFrame);
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=A8CD55
    // Broiler-Falsified-If: a member is out of wincodec.h order (CreateDecoderFromFilename at slot 3 through CreateFormatConverter at slot 10), so CreateDecoderFromStream reaches CreateDecoderFromFilename and native code reads the IStream pointer as a NUL-terminated UTF-16 file name
    // Broiler-Human:        PENDING
    [GeneratedComInterface]
    [Guid("ec5ec8a9-c395-4314-9c77-54d7a935ff70")]
    public partial interface IWICImagingFactory
    {
        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=777C84
        // Broiler-Falsified-If: wzFilename is marshalled as an ANSI LPStr instead of LPWStr, so native code reads single-byte text as UTF-16 and opens a path other than the one passed, or runs past the marshalled buffer looking for a 2-byte terminator
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateDecoderFromFilename([MarshalAs(UnmanagedType.LPWStr)] string wzFilename, IntPtr pguidVendor,
            uint dwDesiredAccess, int metadataOptions, out IWICBitmapDecoder ppIDecoder);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=A96950
        // Broiler-Falsified-If: pIStream is marshalled as an IUnknown or other interface pointer instead of the IStream obtained for IID_IStream, so the codec's Read and Seek calls on page-supplied image bytes dispatch through the wrong vtable slots
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateDecoderFromStream(IStream pIStream, IntPtr pguidVendor, int metadataOptions, out IWICBitmapDecoder ppIDecoder);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=7; Fingerprint=0FCBE9
        // Broiler-Falsified-If: hFile is declared narrower than the pointer-sized ULONG_PTR, so on 64-bit the factory reads a truncated handle and decodes from whichever file that value names in the process
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateDecoderFromFileHandle(IntPtr hFile, IntPtr pguidVendor, int metadataOptions, out IWICBitmapDecoder ppIDecoder);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=84A58A
        // Broiler-Falsified-If: CreateComponentInfo is not vtable slot 6, after CreateDecoderFromFileHandle, so the CLSID pointer reaches CreateDecoderFromFileHandle as a file handle
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateComponentInfo(ref Guid clsidComponent, out IntPtr ppIInfo);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=B0ED40
        // Broiler-Falsified-If: guidContainerFormat is passed by value rather than as a REFGUID pointer, so native code dereferences the first 8 bytes of the GUID as an address
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateDecoder(ref Guid guidContainerFormat, IntPtr pguidVendor, out IWICBitmapDecoder ppIDecoder);

        // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=F89366
        // Broiler-Falsified-If: CreateEncoder is not vtable slot 8, after CreateDecoder, so an encoder request reaches CreateDecoder and a decoder is returned where an encoder is expected
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateEncoder(ref Guid guidContainerFormat, IntPtr pguidVendor, out IntPtr ppIEncoder);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=592ED9
        // Broiler-Falsified-If: CreatePalette is not vtable slot 9, after CreateEncoder, so the call reaches CreateFormatConverter and a converter is returned where a palette is expected
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreatePalette(out IntPtr ppIPalette);

        // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=903F42
        // Broiler-Falsified-If: CreateFormatConverter is not vtable slot 10, so the call reaches CreatePalette and the returned IWICPalette fails the cast to IWICFormatConverter, making every converted decode throw
        // Broiler-Human:        PENDING
        [PreserveSig]
        int CreateFormatConverter(out IWICFormatConverter ppIFormatConverter);
    }
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=CD41A9
    // Broiler-Falsified-If: the value is not wincodec.h's WINCODEC_ERR_UNKNOWNIMAGEFORMAT 0x88982F07, so bytes no registered WIC codec recognises are reported as a generic decode failure instead of a missing decoder
    // Broiler-Human:        PENDING
    public const int WinCodecErrUnknownImageFormat = unchecked((int)0x88982F07);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=215DCE
    // Broiler-Falsified-If: the value is not wincodec.h's WINCODEC_ERR_COMPONENTNOTFOUND 0x88982F50, so a machine without the optional WebP codec is not recognised as missing a decoder and the image is reported as malformed
    // Broiler-Human:        PENDING
    public const int WinCodecErrComponentNotFound = unchecked((int)0x88982F50);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=39F404
    // Broiler-Falsified-If: the value is not wincodec.h's WINCODEC_ERR_INVALIDREGISTRATION 0x88982F8A, so a codec with a broken registration is not recognised as an unavailable decoder and its failure is reported as malformed image data
    // Broiler-Human:        PENDING
    public const int WinCodecErrInvalidRegistration = unchecked((int)0x88982F8A);
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=E1A38A
    // Broiler-Falsified-If: the value is not wincodec.h's WINCODEC_ERR_COMPONENTINITIALIZEFAILURE 0x88982F8B, so a codec registered but not activatable, as on hosted CI images, is reported as malformed image data instead of an unavailable decoder
    // Broiler-Human:        PENDING
    public const int WinCodecErrComponentInitializeFailure = unchecked((int)0x88982F8B);
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=58F4DA
    // Broiler-Falsified-If: the value is neither wincodec.h's CLSID_WICImagingFactory1 {cacaf262-9370-4615-a13b-9f5539da4c0a} nor CLSID_WICImagingFactory2, so CoCreateInstance returns REGDB_E_CLASSNOTREG and no image is decoded through WIC
    // Broiler-Human:        PENDING
    public static readonly Guid ClsidWicImagingFactory = new("cacaf262-9370-4615-a13b-9f5539da4c0a");
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=958C80
    // Broiler-Falsified-If: the value differs from IWICImagingFactory's Guid attribute and wincodec.h's IID_IWICImagingFactory {ec5ec8a9-c395-4314-9c77-54d7a935ff70}, so CoCreateInstance asks the factory for another interface and fails with E_NOINTERFACE
    // Broiler-Human:        PENDING
    public static readonly Guid IidWicImagingFactory = new("ec5ec8a9-c395-4314-9c77-54d7a935ff70");
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=B7D3A3
    // Broiler-Falsified-If: the value is not wincodec.h's GUID_WICPixelFormat32bppRGBA {f5c7ad2d-6a8d-43dd-a7a8-a29935261ae9}, so a successful conversion yields a layout other than straight 8-bit RGBA and the decoded image has swapped or premultiplied channels
    // Broiler-Human:        PENDING
    public static readonly Guid PixelFormat32bppRgba = new("f5c7ad2d-6a8d-43dd-a7a8-a29935261ae9");
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=1F1023
    // Broiler-Falsified-If: the value is not wincodec.h's GUID_WICPixelFormat32bppBGRA {6fddc324-4e03-4bfe-b185-3d77768dc90f}, so the fallback conversion yields a layout other than straight BGRA and the caller's BGRA-to-RGBA swizzle produces wrong colours
    // Broiler-Human:        PENDING
    public static readonly Guid PixelFormat32bppBgra = new("6fddc324-4e03-4bfe-b185-3d77768dc90f");
}
