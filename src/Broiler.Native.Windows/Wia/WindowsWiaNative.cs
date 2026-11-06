// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// HAIRS Code Assurance
// --------------------
// Relevant units:   36
// Annotated:        36/36
// Exempt:           100
// Human-reviewed:   0/36
// IP risk:          Low
// Security risk:    Critical
// Criteria:         34/34
// Resource impact:  3/10 max
// Unverified:       36
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Broiler.Native.Windows.Wia;

/// <summary>
/// Windows Image Acquisition (WIA 2.0) COM identifiers, property constants, format GUIDs, and
/// error codes from wiadef.h and wia_lh.h.
/// </summary>
// Hairs-AI:           Origin=AI; IP=Low; Security=None; Resources=0; Fingerprint=95E902
// Hairs-Human:        PENDING
public static partial class WindowsWiaNative
{
    public const int WIA_DEVINFO_ENUM_ALL = 0x0000000F;
    public const int WIA_DEVINFO_ENUM_LOCAL = 0x00000010;

    public const int StiDeviceTypeDefault = 0;
    public const int StiDeviceTypeScanner = 1;
    public const int StiDeviceTypeDigitalCamera = 2;

    public const uint PRSPEC_LPWSTR = 0;
    public const uint PRSPEC_PROPID = 1;

    // Device Information Properties (wiadef.h)
    public const uint WIA_DIP_DEV_ID = 2;
    public const uint WIA_DIP_VEND_DESC = 3;
    public const uint WIA_DIP_DEV_DESC = 4;
    public const uint WIA_DIP_DEV_TYPE = 5;
    public const uint WIA_DIP_DEV_NAME = 7;

    // Scanner Device & Item Properties (wiadef.h)
    public const uint WIA_DPS_HORIZONTAL_BED_SIZE = 3074;
    public const uint WIA_DPS_VERTICAL_BED_SIZE = 3075;
    public const uint WIA_DPS_DOCUMENT_HANDLING_CAPABILITIES = 3086;
    public const uint WIA_DPS_DOCUMENT_HANDLING_STATUS = 3087;
    public const uint WIA_DPS_DOCUMENT_HANDLING_SELECT = 3088;
    public const uint WIA_DPS_PAGES = 3096;

    public const uint WIA_IPA_ITEM_NAME = 4098;
    public const uint WIA_IPA_FULL_ITEM_NAME = 4099;
    public const uint WIA_IPA_ITEM_FLAGS = 4101;
    public const uint WIA_IPA_DATATYPE = 4103;
    public const uint WIA_IPA_DEPTH = 4104;
    public const uint WIA_IPA_FORMAT = 4106;
    public const uint WIA_IPA_CHANNELS_PER_PIXEL = 4109;
    public const uint WIA_IPA_BITS_PER_CHANNEL = 4110;
    public const uint WIA_IPA_PIXELS_PER_LINE = 4112;
    public const uint WIA_IPA_BYTES_PER_LINE = 4113;
    public const uint WIA_IPA_NUMBER_OF_LINES = 4114;
    public const uint WIA_IPA_ITEM_CATEGORY = 4125;

    public const uint WIA_IPS_CUR_INTENT = 6146;
    public const uint WIA_IPS_XRES = 6147;
    public const uint WIA_IPS_YRES = 6148;
    public const uint WIA_IPS_XPOS = 6149;
    public const uint WIA_IPS_YPOS = 6150;
    public const uint WIA_IPS_XEXTENT = 6151;
    public const uint WIA_IPS_YEXTENT = 6152;
    public const uint WIA_IPS_BRIGHTNESS = 6154;
    public const uint WIA_IPS_CONTRAST = 6155;
    public const uint WIA_IPS_ORIENTATION = 6156;
    public const uint WIA_IPS_ROTATION = 6157;

    // Document Handling Flags (wiadef.h)
    public const int FEEDER = 0x001;
    public const int FLATBED = 0x002;
    public const int DUPLEX = 0x004;
    public const int FRONT_FIRST = 0x008;
    public const int BACK_FIRST = 0x010;
    public const int FRONT_ONLY = 0x020;
    public const int BACK_ONLY = 0x040;
    public const int NEXT_PAGE = 0x080;
    public const int PREFEED = 0x100;
    public const int AUTO_SOURCE = 0x8000;

    // Data Types (WIA_IPA_DATATYPE)
    public const int WIA_DATA_THRESHOLD = 0;
    public const int WIA_DATA_GRAYSCALE = 2;
    public const int WIA_DATA_COLOR = 3;

    // Transfer callback messages (wia_lh.h)
    public const int WIA_TRANSFER_MSG_STATUS = 0x00001;
    public const int WIA_TRANSFER_MSG_END_OF_STREAM = 0x00002;
    public const int WIA_TRANSFER_MSG_END_OF_TRANSFER = 0x00003;
    public const int WIA_TRANSFER_MSG_DEVICE_STATUS = 0x00005;
    public const int WIA_TRANSFER_MSG_NEW_PAGE = 0x00006;

    // WIA HRESULTs (Facility 33 = 0x80210000, wiadef.h)
    public const int WIA_ERROR_GENERAL_ERROR = unchecked((int)0x80210001);
    public const int WIA_ERROR_PAPER_JAM = unchecked((int)0x80210002);
    public const int WIA_ERROR_PAPER_EMPTY = unchecked((int)0x80210003);
    public const int WIA_ERROR_PAPER_PROBLEM = unchecked((int)0x80210004);
    public const int WIA_ERROR_OFFLINE = unchecked((int)0x80210005);
    public const int WIA_ERROR_BUSY = unchecked((int)0x80210006);
    public const int WIA_ERROR_WARMING_UP = unchecked((int)0x80210007);
    public const int WIA_ERROR_USER_INTERVENTION = unchecked((int)0x80210008);
    public const int WIA_ERROR_ITEM_DELETED = unchecked((int)0x80210009);
    public const int WIA_ERROR_DEVICE_COMMUNICATION = unchecked((int)0x8021000A);
    public const int WIA_ERROR_INVALID_COMMAND = unchecked((int)0x8021000B);
    public const int WIA_ERROR_INCORRECT_HARDWARE_SETTING = unchecked((int)0x8021000C);
    public const int WIA_ERROR_DEVICE_LOCKED = unchecked((int)0x8021000D);
    public const int WIA_ERROR_EXCEPTION_IN_DRIVER = unchecked((int)0x8021000E);
    public const int WIA_ERROR_INVALID_DRIVER_RESPONSE = unchecked((int)0x8021000F);
    public const int WIA_ERROR_COVER_OPEN = unchecked((int)0x80210010);
    public const int WIA_ERROR_LAMP_OFF = unchecked((int)0x80210011);
    public const int WIA_ERROR_MULTI_FEED = unchecked((int)0x80210014);
    public const int WIA_S_NO_DEVICE_AVAILABLE = unchecked((int)0x80210015);

    public static readonly Guid ClsidWiaDevMgr2 = new("B6C292BC-7C88-41EE-8B54-8EC92617E599");
    public static readonly Guid IidIWiaDevMgr2 = new("79C07CF1-CBDD-41EE-8EC3-F00080CADA7A");
    public static readonly Guid IidIEnumWiaDevInfo = new("5E38B83C-8CF1-11D1-BF92-0060081ED811");
    public static readonly Guid IidIWiaPropertyStorage = new("98B5E8A0-29CC-491A-AAC0-E6DB4FDCCEB6");
    public static readonly Guid IidIWiaItem2 = new("6CBA0075-1287-407D-9B77-CF0E030435CC");
    public static readonly Guid IidIEnumWiaItem2 = new("59970AF4-CD0D-44D9-AB24-52295630E582");
    public static readonly Guid IidIWiaTransfer = new("C39D6942-2F4E-4D04-92FE-4EF4D3A1DE5A");
    public static readonly Guid IidIWiaTransferCallback = new("27D4EA4F-5D06-4095-8E0F-ECE2E6E2D24E");

    public static readonly Guid WiaImgFmt_RAW = new("B96B3CA9-0728-11D3-9D7B-0000F81EF32E");
    public static readonly Guid WiaImgFmt_MEMORYBMP = new("B96B3CAA-0728-11D3-9D7B-0000F81EF32E");
    public static readonly Guid WiaImgFmt_BMP = new("B96B3CAB-0728-11D3-9D7B-0000F81EF32E");

    public static readonly Guid WiaItemCategoryRoot = new("F193526F-59B8-4A26-9888-E16E4F97CE10");
    public static readonly Guid WiaItemCategoryFlatbed = new("FB607B1F-43F3-488B-855B-FB703EC342A6");
    public static readonly Guid WiaItemCategoryFeeder = new("FE131934-F84C-42AD-8DA4-6129CDDD7288");
    public static readonly Guid WiaItemCategoryFeederFront = new("4823175C-3B28-487B-A7E6-EEBC17614FD1");
    public static readonly Guid WiaItemCategoryFeederBack = new("FC0606C0-F2C9-4242-8C43-6E1F9E269A6B");
}

/// <summary>The propidl.h PROPSPEC: a kind selector (PRSPEC_LPWSTR or PRSPEC_PROPID) and a pointer-sized union.</summary>
// Hairs-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=34C8C1
// Hairs-Falsified-If: Marshal.SizeOf of PropSpec is not 16 on 64-bit and 8 on 32-bit, or Marshal.OffsetOf Value is not 8 on 64-bit, the layout of PROPSPEC (ULONG ulKind; union { PROPID propid; LPOLESTR lpwstr; }) in propidl.h
// Hairs-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct PropSpec
{
    public uint Kind;
    public IntPtr Value;

    // Hairs-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=CE9863
    // Hairs-Human:        PENDING
    public static PropSpec FromPropertyId(uint propertyId) => new()
    {
        Kind = WindowsWiaNative.PRSPEC_PROPID,
        Value = (IntPtr)propertyId,
    };
}

/// <summary>The wia_lh.h WiaTransferParams structure passed to IWiaTransferCallback.TransferCallback.</summary>
// Hairs-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=C30E29
// Hairs-Falsified-If: Marshal.SizeOf of WiaTransferParams is not 24, or Marshal.OffsetOf TransferredBytes and ErrorStatus are not 8 and 16, the layout of WiaTransferParams (LONG lMessage, LONG lPercentComplete, ULONGLONG ulTransferredBytes, HRESULT hrErrorStatus) in wia_lh.h
// Hairs-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct WiaTransferParams
{
    public int Message;
    public int PercentComplete;
    public ulong TransferredBytes;
    public int ErrorStatus;
}

/// <summary>WIA 2.0 device manager contract (IWiaDevMgr2 in wia_lh.h).</summary>
// Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=5CE227
// Hairs-Falsified-If: its vtable is not the IWiaDevMgr2 order of wia_lh.h, EnumDeviceInfo at slot 3 and CreateDevice at slot 4
// Hairs-Human:        PENDING
[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16)]
[Guid("79C07CF1-CBDD-41EE-8EC3-F00080CADA7A")]
public partial interface IWiaDevMgr2
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4CDAE7
    // Hairs-Falsified-If: is not slot 3 of IWiaDevMgr2, HRESULT EnumDeviceInfo(LONG lFlags, IEnumWIA_DEV_INFO **ppIEnum) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int EnumDeviceInfo(int flags, out IEnumWIA_DEV_INFO enumDevInfo);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=25B59C
    // Hairs-Falsified-If: is not slot 4 of IWiaDevMgr2, HRESULT CreateDevice(LONG lFlags, BSTR bstrDeviceID, IWiaItem2 **ppWiaItem2Root) in wia_lh.h, or deviceId is not marshalled as a BSTR
    // Hairs-Human:        PENDING
    [PreserveSig]
    int CreateDevice(int flags, [MarshalAs(UnmanagedType.BStr)] string deviceId, out IWiaItem2 rootItem);
}

/// <summary>WIA device info enumerator contract (IEnumWIA_DEV_INFO in wia_lh.h).</summary>
// Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=F753D5
// Hairs-Falsified-If: its vtable is not the IEnumWIA_DEV_INFO order of wia_lh.h, Next at slot 3 through GetCount at slot 7
// Hairs-Human:        PENDING
[GeneratedComInterface]
[Guid("5E38B83C-8CF1-11D1-BF92-0060081ED811")]
public partial interface IEnumWIA_DEV_INFO
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=0BA763
    // Hairs-Falsified-If: is not slot 3 of IEnumWIA_DEV_INFO, HRESULT Next(ULONG celt, IWiaPropertyStorage **rgelt, ULONG *pceltFetched) in wia_lh.h, whose single-element call writes one IWiaPropertyStorage pointer that the caller must wrap and release
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Next(uint count, out IntPtr propertyStorage, out uint fetched);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7524B9
    // Hairs-Falsified-If: is not slot 4 of IEnumWIA_DEV_INFO, HRESULT Skip(ULONG celt) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Skip(uint count);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C17181
    // Hairs-Falsified-If: is not slot 5 of IEnumWIA_DEV_INFO, HRESULT Reset(void) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Reset();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=687FC7
    // Hairs-Falsified-If: is not slot 6 of IEnumWIA_DEV_INFO, HRESULT Clone(IEnumWIA_DEV_INFO **ppIEnum) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Clone(out IEnumWIA_DEV_INFO cloned);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=9DEF9C
    // Hairs-Falsified-If: is not slot 7 of IEnumWIA_DEV_INFO, HRESULT GetCount(ULONG *celt) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetCount(out uint count);
}

/// <summary>WIA property storage contract (IWiaPropertyStorage in wia_lh.h).</summary>
// Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=2F30E1
// Hairs-Falsified-If: its vtable is not the IWiaPropertyStorage order of wia_lh.h, ReadMultiple at slot 3 and WriteMultiple at slot 4
// Hairs-Human:        PENDING
[GeneratedComInterface]
[Guid("98B5E8A0-29CC-491A-AAC0-E6DB4FDCCEB6")]
public partial interface IWiaPropertyStorage
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=83E799
    // Hairs-Falsified-If: is not slot 3 of IWiaPropertyStorage, HRESULT ReadMultiple(ULONG cpspec, const PROPSPEC rgpspec[], PROPVARIANT rgpropvar[]) in wia_lh.h, or specs and values do not address cpspec contiguous PropSpec and PropVariant elements
    // Hairs-Human:        PENDING
    [PreserveSig]
    int ReadMultiple(uint count, IntPtr specs, IntPtr values);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=7491FB
    // Hairs-Falsified-If: is not slot 4 of IWiaPropertyStorage, HRESULT WriteMultiple(ULONG cpspec, const PROPSPEC rgpspec[], const PROPVARIANT rgpropvar[], PROPID propidNameFirst) in wia_lh.h, or specs and values do not address cpspec contiguous PropSpec and PropVariant elements
    // Hairs-Human:        PENDING
    [PreserveSig]
    int WriteMultiple(uint count, IntPtr specs, IntPtr values, uint propidNameFirst);
}

/// <summary>WIA 2.0 item tree node contract (IWiaItem2 in wia_lh.h).</summary>
// Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=C93097
// Hairs-Falsified-If: its vtable is not the IWiaItem2 order of wia_lh.h, CreateChildItem at slot 3 through GetItemType at slot 8
// Hairs-Human:        PENDING
[GeneratedComInterface]
[Guid("6CBA0075-1287-407D-9B77-CF0E030435CC")]
public partial interface IWiaItem2
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=3F7F7E
    // Hairs-Falsified-If: is not slot 3 of IWiaItem2, HRESULT CreateChildItem(LONG lItemFlags, LONG lCreationFlags, BSTR bstrItemName, IWiaItem2 **ppIWiaItem2) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int CreateChildItem(int itemFlags, int creationFlags, [MarshalAs(UnmanagedType.BStr)] string itemName, out IWiaItem2 childItem);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D07BC3
    // Hairs-Falsified-If: is not slot 4 of IWiaItem2, HRESULT DeleteItem(LONG lFlags) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int DeleteItem(int flags);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=824F35
    // Hairs-Falsified-If: is not slot 5 of IWiaItem2, HRESULT EnumChildItems(const GUID *pCategoryGUID, IEnumWiaItem2 **ppIEnumWiaItem2) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int EnumChildItems(IntPtr categoryGuid, out IEnumWiaItem2 enumItems);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=AFA0B1
    // Hairs-Falsified-If: is not slot 6 of IWiaItem2, HRESULT FindItemByName(LONG lFlags, BSTR bstrFullItemName, IWiaItem2 **ppIWiaItem2) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int FindItemByName(int flags, [MarshalAs(UnmanagedType.BStr)] string fullItemName, out IWiaItem2 item);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=47BA62
    // Hairs-Falsified-If: is not slot 7 of IWiaItem2, HRESULT GetItemCategory(GUID *pItemCategoryGUID) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetItemCategory(out Guid itemCategoryGuid);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=9068E8
    // Hairs-Falsified-If: is not slot 8 of IWiaItem2, HRESULT GetItemType(LONG *pItemType) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetItemType(out int itemType);
}

/// <summary>WIA 2.0 child item enumerator contract (IEnumWiaItem2 in wia_lh.h).</summary>
// Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=7BA796
// Hairs-Falsified-If: its vtable is not the IEnumWiaItem2 order of wia_lh.h, Next at slot 3 through GetCount at slot 7
// Hairs-Human:        PENDING
[GeneratedComInterface]
[Guid("59970AF4-CD0D-44D9-AB24-52295630E582")]
public partial interface IEnumWiaItem2
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=2F61EC
    // Hairs-Falsified-If: is not slot 3 of IEnumWiaItem2, HRESULT Next(ULONG cElt, IWiaItem2 **ppIWiaItem2, ULONG *pcEltFetched) in wia_lh.h, whose single-element call writes one IWiaItem2 pointer that the caller must wrap and release
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Next(uint count, out IntPtr item, out uint fetched);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7524B9
    // Hairs-Falsified-If: is not slot 4 of IEnumWiaItem2, HRESULT Skip(ULONG cElt) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Skip(uint count);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C17181
    // Hairs-Falsified-If: is not slot 5 of IEnumWiaItem2, HRESULT Reset(void) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Reset();

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=55BC7F
    // Hairs-Falsified-If: is not slot 6 of IEnumWiaItem2, HRESULT Clone(IEnumWiaItem2 **ppIEnum) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Clone(out IEnumWiaItem2 cloned);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=9DEF9C
    // Hairs-Falsified-If: is not slot 7 of IEnumWiaItem2, HRESULT GetCount(ULONG *cElt) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetCount(out uint count);
}

/// <summary>WIA 2.0 stream transfer contract (IWiaTransfer in wia_lh.h).</summary>
// Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=FD96DB
// Hairs-Falsified-If: its vtable is not the IWiaTransfer order of wia_lh.h, Download at slot 3 through Cancel at slot 5
// Hairs-Human:        PENDING
[GeneratedComInterface]
[Guid("C39D6942-2F4E-4D04-92FE-4EF4D3A1DE5A")]
public partial interface IWiaTransfer
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=6EE19C
    // Hairs-Falsified-If: is not slot 3 of IWiaTransfer, HRESULT Download(LONG lFlags, IWiaTransferCallback *pIWiaTransferCallback) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Download(int flags, IWiaTransferCallback callback);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=F5E17C
    // Hairs-Falsified-If: is not slot 4 of IWiaTransfer, HRESULT Upload(LONG lFlags, IStream *pSource, IWiaTransferCallback *pIWiaTransferCallback) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Upload(int flags, IStream source, IWiaTransferCallback callback);

    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=27B666
    // Hairs-Falsified-If: is not slot 5 of IWiaTransfer, HRESULT Cancel(void) in wia_lh.h
    // Hairs-Human:        PENDING
    [PreserveSig]
    int Cancel();
}

/// <summary>WIA 2.0 transfer callback contract (IWiaTransferCallback in wia_lh.h). Public visibility is required for COM QueryInterface.</summary>
// Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=6F13B1
// Hairs-Falsified-If: its vtable is not the IWiaTransferCallback order of wia_lh.h, TransferCallback at slot 3 and GetNextStream at slot 4 under IID 27d4ea4f-5d06-4095-8e0f-ece2e6e2d24e
// Hairs-Human:        PENDING
[GeneratedComInterface]
[Guid("27D4EA4F-5D06-4095-8E0F-ECE2E6E2D24E")]
[EditorBrowsable(EditorBrowsableState.Never)]
public partial interface IWiaTransferCallback
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=EC25C3
    // Hairs-Falsified-If: is not slot 3 of IWiaTransferCallback, HRESULT TransferCallback(LONG lFlags, WiaTransferParams *pWiaTransferParams) in wia_lh.h, or WiaTransferParams is not the 24-byte layout pWiaTransferParams points to
    // Hairs-Human:        PENDING
    [PreserveSig]
    int TransferCallback(int flags, ref WiaTransferParams transferParams);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=9973BF
    // Hairs-Falsified-If: is not slot 4 of IWiaTransferCallback, HRESULT GetNextStream(LONG lFlags, BSTR bstrItemName, BSTR bstrFullItemName, IStream **ppDestination) in wia_lh.h, or itemName and fullItemName are not marshalled as BSTRs
    // Hairs-Human:        PENDING
    [PreserveSig]
    int GetNextStream(int flags, [MarshalAs(UnmanagedType.BStr)] string itemName,
        [MarshalAs(UnmanagedType.BStr)] string fullItemName, out IStream destination);
}
