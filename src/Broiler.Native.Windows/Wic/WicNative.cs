using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Broiler.Native.Windows.Wic;

public static partial class WicNative
{
    [DllImport("ole32.dll")]
    public static extern int CoCreateInstance(ref Guid rclsid, IntPtr pUnkOuter, uint dwClsContext, ref Guid riid,
        [MarshalAs(UnmanagedType.Interface)] out IWICImagingFactory ppv);

    [LibraryImport("ole32.dll")]
    public static partial int CoInitializeEx(IntPtr pvReserved, uint dwCoInit);

    [LibraryImport("ole32.dll")]
    public static partial void CoUninitialize();

    [DllImport("ole32.dll")]
    public static extern int CreateStreamOnHGlobal(IntPtr hGlobal, bool fDeleteOnRelease, out IStream ppstm);

    [ComImport]
    [Guid("3b16811b-6a43-4ec9-a813-3d930c13b940")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapFrameDecode
    {
        [PreserveSig]
        int GetSize(out uint puiWidth, out uint puiHeight);

        [PreserveSig]
        int GetPixelFormat(out Guid pPixelFormat);

        [PreserveSig]
        int GetResolution(out double pDpiX, out double pDpiY);

        [PreserveSig]
        int CopyPalette(IntPtr pIPalette);

        [PreserveSig]
        int CopyPixels(IntPtr prc, uint cbStride, uint cbBufferSize, IntPtr pbBuffer);

        [PreserveSig]
        int GetMetadataQueryReader(out IntPtr ppIMetadataQueryReader);

        [PreserveSig]
        int GetColorContexts(uint cCount, IntPtr ppIColorContexts, out uint pcActualCount);

        [PreserveSig]
        int GetThumbnail(out IntPtr ppIThumbnail);
    }

    [ComImport]
    [Guid("00000301-a8f2-4877-ba0a-fd2b6645fb94")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICFormatConverter
    {
        [PreserveSig]
        int GetSize(out uint puiWidth, out uint puiHeight);

        [PreserveSig]
        int GetPixelFormat(out Guid pPixelFormat);

        [PreserveSig]
        int GetResolution(out double pDpiX, out double pDpiY);

        [PreserveSig]
        int CopyPalette(IntPtr pIPalette);

        [PreserveSig]
        int CopyPixels(IntPtr prc, uint cbStride, uint cbBufferSize, IntPtr pbBuffer);

        [PreserveSig]
        int Initialize(IWICBitmapFrameDecode pISource, ref Guid dstFormat, int dither, IntPtr pIPalette,
            double alphaThresholdPercent, int paletteTranslate);

        [PreserveSig]
        int CanConvert(ref Guid srcPixelFormat, ref Guid dstPixelFormat, out int pfCanConvert);
    }

    [ComImport]
    [Guid("9edde9e7-8dee-47ea-99df-e6faf2ed44bf")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapDecoder
    {
        [PreserveSig]
        int QueryCapability(IStream pIStream, out uint pdwCapability);

        [PreserveSig]
        int Initialize(IStream pIStream, int cacheOptions);

        [PreserveSig]
        int GetContainerFormat(out Guid pguidContainerFormat);

        [PreserveSig]
        int GetDecoderInfo(out IntPtr ppIDecoderInfo);

        [PreserveSig]
        int CopyPalette(IntPtr pIPalette);

        [PreserveSig]
        int GetMetadataQueryReader(out IntPtr ppIMetadataQueryReader);

        [PreserveSig]
        int GetPreview(out IntPtr ppIBitmapSource);

        [PreserveSig]
        int GetColorContexts(uint cCount, IntPtr ppIColorContexts, out uint pcActualCount);

        [PreserveSig]
        int GetThumbnail(out IntPtr ppIThumbnail);

        [PreserveSig]
        int GetFrameCount(out uint pCount);

        [PreserveSig]
        int GetFrame(uint index, out IWICBitmapFrameDecode ppIBitmapFrame);
    }

    [ComImport]
    [Guid("ec5ec8a9-c395-4314-9c77-54d7a935ff70")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICImagingFactory
    {
        [PreserveSig]
        int CreateDecoderFromFilename([MarshalAs(UnmanagedType.LPWStr)] string wzFilename, IntPtr pguidVendor,
            uint dwDesiredAccess, int metadataOptions, out IWICBitmapDecoder ppIDecoder);

        [PreserveSig]
        int CreateDecoderFromStream(IStream pIStream, IntPtr pguidVendor, int metadataOptions, out IWICBitmapDecoder ppIDecoder);

        [PreserveSig]
        int CreateDecoderFromFileHandle(IntPtr hFile, IntPtr pguidVendor, int metadataOptions, out IWICBitmapDecoder ppIDecoder);

        [PreserveSig]
        int CreateComponentInfo(ref Guid clsidComponent, out IntPtr ppIInfo);

        [PreserveSig]
        int CreateDecoder(ref Guid guidContainerFormat, IntPtr pguidVendor, out IWICBitmapDecoder ppIDecoder);

        [PreserveSig]
        int CreateEncoder(ref Guid guidContainerFormat, IntPtr pguidVendor, out IntPtr ppIEncoder);

        [PreserveSig]
        int CreatePalette(out IntPtr ppIPalette);

        [PreserveSig]
        int CreateFormatConverter(out IWICFormatConverter ppIFormatConverter);
    }
    public const uint ClsctxInprocServer = 0x1;
    public const uint CoInitMultithreaded = 0x0;
    public const int RpcEChangedMode = unchecked((int)0x80010106);
    public const int WinCodecErrUnknownImageFormat = unchecked((int)0x88982F07);
    public const int WinCodecErrComponentNotFound = unchecked((int)0x88982F50);
    public const int WinCodecErrInvalidRegistration = unchecked((int)0x88982F8A);
    public const int WinCodecErrComponentInitializeFailure = unchecked((int)0x88982F8B);
    public static readonly Guid ClsidWicImagingFactory = new("cacaf262-9370-4615-a13b-9f5539da4c0a");
    public static readonly Guid IidWicImagingFactory = new("ec5ec8a9-c395-4314-9c77-54d7a935ff70");
    public static readonly Guid PixelFormat32bppRgba = new("f5c7ad2d-6a8d-43dd-a7a8-a29935261ae9");
    public static readonly Guid PixelFormat32bppBgra = new("6fddc324-4e03-4bfe-b185-3d77768dc90f");
}
