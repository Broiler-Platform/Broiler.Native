// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// HAIRS Code Assurance
// --------------------
// Relevant units:   118
// Annotated:        118/118
// Exempt:           171
// Human-reviewed:   0/118
// IP risk:          Low
// Security risk:    Low
// Criteria:         0/0
// Resource impact:  0/10 max
// Unverified:       118
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Broiler.Native.Windows.Accessibility;

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=8EEEA0
// Hairs-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct UiaRect
{
    public double Left;
    public double Top;
    public double Width;
    public double Height;

    public UiaRect(double left, double top, double width, double height)
    {
        Left = left;
        Top = top;
        Width = width;
        Height = height;
    }
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=4A8927
// Hairs-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct UiaPoint
{
    public double X;
    public double Y;

    public UiaPoint(double x, double y)
    {
        X = x;
        Y = y;
    }
}

[Flags]
public enum ProviderOptions
{
    ClientSideProvider = 0x0001,
    ServerSideProvider = 0x0002,
    NonClientAreaProvider = 0x0004,
    OverrideProvider = 0x0008,
    ProviderOwnsSetFocus = 0x0010,
    UseComThreading = 0x0020,
}

public enum NavigateDirection
{
    Parent = 0,
    NextSibling = 1,
    PreviousSibling = 2,
    FirstChild = 3,
    LastChild = 4,
}

public enum ToggleState
{
    Off = 0,
    On = 1,
    Indeterminate = 2,
}

public enum ExpandCollapseState
{
    Collapsed = 0,
    Expanded = 1,
    PartiallyExpanded = 2,
    LeafNode = 3,
}

/// <summary>UIA <c>NotificationKind</c>: what a notification event reports.</summary>
public enum NotificationKind
{
    ItemAdded = 0,
    ItemRemoved = 1,
    ActionCompleted = 2,
    ActionAborted = 3,
    Other = 4,
}

/// <summary>UIA <c>NotificationProcessing</c>: how a client queues a notification against earlier ones.</summary>
public enum NotificationProcessing
{
    ImportantAll = 0,
    ImportantMostRecent = 1,
    All = 2,
    MostRecent = 3,
    CurrentThenMostRecent = 4,
}

/// <summary>UIA <c>LiveSetting</c>: whether and how politely a live region's changes are read.</summary>
public enum LiveSetting
{
    Off = 0,
    Polite = 1,
    Assertive = 2,
}

public enum StructureChangeType
{
    ChildAdded = 0,
    ChildRemoved = 1,
    ChildrenInvalidated = 2,
    ChildrenBulkAdded = 3,
    ChildrenBulkRemoved = 4,
    ChildrenReordered = 5,
}

/// <summary>UIA text units. Values match the native <c>TextUnit</c> enumeration.</summary>
public enum TextUnit
{
    Character = 0,
    Format = 1,
    Word = 2,
    Line = 3,
    Paragraph = 4,
    Page = 5,
    Document = 6,
}

/// <summary>UIA range endpoints. Values match the native <c>TextPatternRangeEndpoint</c> enumeration.</summary>
public enum TextPatternRangeEndpoint
{
    Start = 0,
    End = 1,
}

/// <summary>Values match the native <c>SupportedTextSelection</c> enumeration.</summary>
public enum SupportedTextSelection
{
    None = 0,
    Single = 1,
    Multiple = 2,
}

// Blittable ABI storage for VARIANT: 8-byte header followed by an 8-byte value or
// two record pointers (16 bytes on 64-bit Windows). ComVariant supplies allocation
// and disposal, while this boundary type needs no runtime struct marshaller.
// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=5C0948
// Hairs-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct AutomationVariant
{
    public ulong Header;
    public VariantData Data;

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=2F6795
    // Hairs-Human:        PENDING
    [StructLayout(LayoutKind.Explicit)]
    public struct VariantData
    {
        [FieldOffset(0)] public long Value;
        [FieldOffset(0)] public RecordPointers Record;
    }

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=96DFD4
    // Hairs-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct RecordPointers { public IntPtr Record; public IntPtr RecordInfo; }

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=047E8E
    // Hairs-Human:        PENDING
    public static AutomationVariant From(ComVariant value) => Unsafe.BitCast<ComVariant, AutomationVariant>(value);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=11287A
    // Hairs-Human:        PENDING
    public ComVariant ToVariant() => Unsafe.BitCast<AutomationVariant, ComVariant>(this);
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=6A22EF
// Hairs-Human:        PENDING
public interface IRawElementProviderSimple
{
    ProviderOptions ProviderOptions { get; }
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=D9F449
    // Hairs-Human:        PENDING
    object? GetPatternProvider(int patternId);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=E75AB1
    // Hairs-Human:        PENDING
    object? GetPropertyValue(int propertyId);
    IRawElementProviderSimple? HostRawElementProvider { get; }
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=471911
// Hairs-Human:        PENDING
public interface IRawElementProviderFragment : IRawElementProviderSimple
{
    new ProviderOptions ProviderOptions { get; }
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=99334F
    // Hairs-Human:        PENDING
    new object? GetPatternProvider(int patternId);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=19F652
    // Hairs-Human:        PENDING
    new object? GetPropertyValue(int propertyId);
    new IRawElementProviderSimple? HostRawElementProvider { get; }
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=FA151F
    // Hairs-Human:        PENDING
    IRawElementProviderFragment? Navigate(NavigateDirection direction);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=43D0C1
    // Hairs-Human:        PENDING
    int[]? GetRuntimeId();
    UiaRect BoundingRectangle { get; }
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=90317C
    // Hairs-Human:        PENDING
    IRawElementProviderSimple[]? GetEmbeddedFragmentRoots();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A71F75
    // Hairs-Human:        PENDING
    void SetFocus();
    IRawElementProviderFragmentRoot? FragmentRoot { get; }
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=CF4D08
// Hairs-Human:        PENDING
public interface IRawElementProviderFragmentRoot : IRawElementProviderFragment
{
    new ProviderOptions ProviderOptions { get; }
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=99334F
    // Hairs-Human:        PENDING
    new object? GetPatternProvider(int patternId);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=19F652
    // Hairs-Human:        PENDING
    new object? GetPropertyValue(int propertyId);
    new IRawElementProviderSimple? HostRawElementProvider { get; }
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=D586AA
    // Hairs-Human:        PENDING
    new IRawElementProviderFragment? Navigate(NavigateDirection direction);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=849995
    // Hairs-Human:        PENDING
    new int[]? GetRuntimeId();
    new UiaRect BoundingRectangle { get; }
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=FD0437
    // Hairs-Human:        PENDING
    new IRawElementProviderSimple[]? GetEmbeddedFragmentRoots();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=9EB2D0
    // Hairs-Human:        PENDING
    new void SetFocus();
    new IRawElementProviderFragmentRoot? FragmentRoot { get; }
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=4DA22C
    // Hairs-Human:        PENDING
    IRawElementProviderFragment? ElementProviderFromPoint(double x, double y);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=E19084
    // Hairs-Human:        PENDING
    IRawElementProviderFragment? GetFocus();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=899FF7
// Hairs-Human:        PENDING
public interface IInvokeProvider
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=331255
    // Hairs-Human:        PENDING
    void Invoke();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3A6B1D
// Hairs-Human:        PENDING
public interface IValueProvider
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=795341
    // Hairs-Human:        PENDING
    void SetValue(string value);
    string Value { get; }
    bool IsReadOnly { get; }
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=6C0341
// Hairs-Human:        PENDING
public interface ISelectionItemProvider
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=04AB86
    // Hairs-Human:        PENDING
    void Select();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=478D2F
    // Hairs-Human:        PENDING
    void AddToSelection();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3C1E5A
    // Hairs-Human:        PENDING
    void RemoveFromSelection();
    bool IsSelected { get; }
    IRawElementProviderSimple? SelectionContainer { get; }
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=38F0F0
// Hairs-Human:        PENDING
public interface ISelectionProvider
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=488B54
    // Hairs-Human:        PENDING
    IRawElementProviderSimple[]? GetSelection();
    bool CanSelectMultiple { get; }
    bool IsSelectionRequired { get; }
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=842DE8
// Hairs-Human:        PENDING
public interface IToggleProvider
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=4E7622
    // Hairs-Human:        PENDING
    void Toggle();
    ToggleState ToggleState { get; }
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3CB104
// Hairs-Human:        PENDING
public interface IExpandCollapseProvider
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=94BF96
    // Hairs-Human:        PENDING
    void Expand();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=47F0C8
    // Hairs-Human:        PENDING
    void Collapse();
    ExpandCollapseState ExpandCollapseState { get; }
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=FB7B7E
// Hairs-Human:        PENDING
public interface IScrollItemProvider
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A594DF
    // Hairs-Human:        PENDING
    void ScrollIntoView();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=35AAA8
// Hairs-Human:        PENDING
[GeneratedComInterface, Guid("d6dd68d1-86fd-4332-8666-9abedea2d24c")]
public partial interface INativeSimple
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=287EEF
    // Hairs-Human:        PENDING
    ProviderOptions GetProviderOptions();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=70D92E
    // Hairs-Human:        PENDING
    IntPtr GetPatternProvider(int patternId);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=568A40
    // Hairs-Human:        PENDING
    AutomationVariant GetPropertyValue(int propertyId);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=D1B927
    // Hairs-Human:        PENDING
    INativeSimple? GetHostRawElementProvider();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=5B9152
// Hairs-Human:        PENDING
[GeneratedComInterface, Guid("f7063da8-8359-439c-9297-bbc5299a7d87")]
public partial interface INativeFragment
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B82872
    // Hairs-Human:        PENDING
    INativeFragment? Navigate(NavigateDirection direction);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=E26C70
    // Hairs-Human:        PENDING
    IntPtr GetRuntimeId();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=AF28EB
    // Hairs-Human:        PENDING
    UiaRect GetBoundingRectangle();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B8092B
    // Hairs-Human:        PENDING
    IntPtr GetEmbeddedFragmentRoots();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A71F75
    // Hairs-Human:        PENDING
    void SetFocus();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3573B5
    // Hairs-Human:        PENDING
    INativeFragmentRoot? GetFragmentRoot();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=234BE4
// Hairs-Human:        PENDING
[GeneratedComInterface, Guid("620ce2a5-ab8f-40a9-86cb-de3c75599b58")]
public partial interface INativeFragmentRoot
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=746E5D
    // Hairs-Human:        PENDING
    INativeFragment? ElementProviderFromPoint(double x, double y);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=998927
    // Hairs-Human:        PENDING
    INativeFragment? GetFocus();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=DA27BA
// Hairs-Human:        PENDING
[GeneratedComInterface, Guid("54fcb24b-e18e-47a2-b4d3-eccbe77599a2")]
public partial interface INativeInvoke
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=331255
    // Hairs-Human:        PENDING
    void Invoke();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=01DBDE
// Hairs-Human:        PENDING
[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16), Guid("c7935180-6fb3-4201-b174-7df73adbf64a")]
public partial interface INativeValue
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=795341
    // Hairs-Human:        PENDING
    void SetValue(string value);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=12A91C
    // Hairs-Human:        PENDING
    [return: MarshalAs(UnmanagedType.BStr)] string GetValue();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=726788
    // Hairs-Human:        PENDING
    [return: MarshalAs(UnmanagedType.Bool)] bool GetIsReadOnly();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=75649E
// Hairs-Human:        PENDING
[GeneratedComInterface, Guid("2acad808-b2d4-452d-a407-91ff1ad167b2")]
public partial interface INativeSelectionItem
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=04AB86
    // Hairs-Human:        PENDING
    void Select();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=478D2F
    // Hairs-Human:        PENDING
    void AddToSelection();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3C1E5A
    // Hairs-Human:        PENDING
    void RemoveFromSelection();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=8548EA
    // Hairs-Human:        PENDING
    [return: MarshalAs(UnmanagedType.Bool)] bool GetIsSelected();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=AFAC6B
    // Hairs-Human:        PENDING
    INativeSimple? GetSelectionContainer();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=2AD339
// Hairs-Human:        PENDING
[GeneratedComInterface, Guid("fb8b03af-3bdf-48d4-bd36-1a65793be168")]
public partial interface INativeSelection
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=274C84
    // Hairs-Human:        PENDING
    IntPtr GetSelection();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=1F00C6
    // Hairs-Human:        PENDING
    [return: MarshalAs(UnmanagedType.Bool)] bool GetCanSelectMultiple();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=53E878
    // Hairs-Human:        PENDING
    [return: MarshalAs(UnmanagedType.Bool)] bool GetIsSelectionRequired();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=6DC829
// Hairs-Human:        PENDING
[GeneratedComInterface, Guid("56d00bd0-c4f4-433c-a836-1a52a57e0892")]
public partial interface INativeToggle
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=4E7622
    // Hairs-Human:        PENDING
    void Toggle();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=16EC2D
    // Hairs-Human:        PENDING
    ToggleState GetToggleState();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=464F3D
// Hairs-Human:        PENDING
[GeneratedComInterface, Guid("d847d3a5-cab0-4a98-8c32-ecb45c59ad24")]
public partial interface INativeExpandCollapse
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=94BF96
    // Hairs-Human:        PENDING
    void Expand();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=47F0C8
    // Hairs-Human:        PENDING
    void Collapse();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=1D4E54
    // Hairs-Human:        PENDING
    ExpandCollapseState GetExpandCollapseState();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=7064A8
// Hairs-Human:        PENDING
[GeneratedComInterface, Guid("2360c714-4bf1-4b26-ba65-9b21316127eb")]
public partial interface INativeScrollItem
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A594DF
    // Hairs-Human:        PENDING
    void ScrollIntoView();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B51CAE
// Hairs-Human:        PENDING
[GeneratedComInterface, Guid("3589c92c-63f3-4367-99bb-ada653b77cf2")]
public partial interface INativeText
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=274C84
    // Hairs-Human:        PENDING
    IntPtr GetSelection();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B8BBDA
    // Hairs-Human:        PENDING
    IntPtr GetVisibleRanges();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B767DF
    // Hairs-Human:        PENDING
    INativeTextRange? RangeFromChild(INativeSimple? childElement);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=F8E5B1
    // Hairs-Human:        PENDING
    INativeTextRange? RangeFromPoint(UiaPoint point);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A3398E
    // Hairs-Human:        PENDING
    INativeTextRange? GetDocumentRange();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=8BCAF6
    // Hairs-Human:        PENDING
    SupportedTextSelection GetSupportedTextSelection();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=DB519F
// Hairs-Human:        PENDING
[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16), Guid("5347ad7b-c355-46f8-aff5-909033582f63")]
public partial interface INativeTextRange
{
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=62D716
    // Hairs-Human:        PENDING
    INativeTextRange Clone();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A5BEAD
    // Hairs-Human:        PENDING
    [return: MarshalAs(UnmanagedType.Bool)] bool Compare(INativeTextRange range);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=C4F134
    // Hairs-Human:        PENDING
    int CompareEndpoints(TextPatternRangeEndpoint endpoint, INativeTextRange targetRange, TextPatternRangeEndpoint targetEndpoint);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=65AF04
    // Hairs-Human:        PENDING
    void ExpandToEnclosingUnit(TextUnit unit);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3A0E27
    // Hairs-Human:        PENDING
    INativeTextRange? FindAttribute(int attributeId, AutomationVariant value, [MarshalAs(UnmanagedType.Bool)] bool backward);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=9746B9
    // Hairs-Human:        PENDING
    INativeTextRange? FindText([MarshalAs(UnmanagedType.BStr)] string text, [MarshalAs(UnmanagedType.Bool)] bool backward, [MarshalAs(UnmanagedType.Bool)] bool ignoreCase);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=6C05C0
    // Hairs-Human:        PENDING
    AutomationVariant GetAttributeValue(int attributeId);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3D7A90
    // Hairs-Human:        PENDING
    IntPtr GetBoundingRectangles();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=830AD2
    // Hairs-Human:        PENDING
    INativeSimple? GetEnclosingElement();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=50D08F
    // Hairs-Human:        PENDING
    [return: MarshalAs(UnmanagedType.BStr)] string GetText(int maxLength);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=30F83D
    // Hairs-Human:        PENDING
    int Move(TextUnit unit, int count);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=FF7F14
    // Hairs-Human:        PENDING
    int MoveEndpointByUnit(TextPatternRangeEndpoint endpoint, TextUnit unit, int count);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=58ED87
    // Hairs-Human:        PENDING
    void MoveEndpointByRange(TextPatternRangeEndpoint endpoint, INativeTextRange targetRange, TextPatternRangeEndpoint targetEndpoint);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=04AB86
    // Hairs-Human:        PENDING
    void Select();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=478D2F
    // Hairs-Human:        PENDING
    void AddToSelection();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3C1E5A
    // Hairs-Human:        PENDING
    void RemoveFromSelection();
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=870343
    // Hairs-Human:        PENDING
    void ScrollIntoView([MarshalAs(UnmanagedType.Bool)] bool alignToTop);
    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=5D364B
    // Hairs-Human:        PENDING
    IntPtr GetChildren();
}

// Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=82DAA4
// Hairs-Human:        PENDING
public static partial class UiaNative
{
    public const int UiaRootObjectId = -25;
    public const uint WmGetObject = 0x003D;

    // Pattern IDs
    public const int UiaInvokePatternId = 10000;
    public const int UiaSelectionPatternId = 10001;
    public const int UiaValuePatternId = 10002;
    public const int UiaRangeValuePatternId = 10003;
    public const int UiaScrollPatternId = 10004;
    public const int UiaExpandCollapsePatternId = 10005;
    public const int UiaSelectionItemPatternId = 10010;
    public const int UiaTogglePatternId = 10015;
    public const int UiaScrollItemPatternId = 10017;
    public const int UiaTextPatternId = 10014;

    // Control Type IDs
    public const int UiaButtonControlTypeId = 50000;
    public const int UiaCheckBoxControlTypeId = 50002;
    public const int UiaComboBoxControlTypeId = 50003;
    public const int UiaEditControlTypeId = 50004;
    public const int UiaHyperlinkControlTypeId = 50005;
    public const int UiaImageControlTypeId = 50006;
    public const int UiaListItemControlTypeId = 50007;
    public const int UiaListControlTypeId = 50008;
    public const int UiaMenuControlTypeId = 50009;
    public const int UiaMenuItemControlTypeId = 50011;
    public const int UiaProgressBarControlTypeId = 50012;
    public const int UiaRadioButtonControlTypeId = 50013;
    public const int UiaScrollBarControlTypeId = 50014;
    public const int UiaSliderControlTypeId = 50015;
    public const int UiaSpinnerControlTypeId = 50016;
    public const int UiaStatusBarControlTypeId = 50017;
    public const int UiaTabControlTypeId = 50018;
    public const int UiaTabItemControlTypeId = 50019;
    public const int UiaTextControlTypeId = 50020;
    public const int UiaToolBarControlTypeId = 50021;
    public const int UiaToolTipControlTypeId = 50022;
    public const int UiaCustomControlTypeId = 50025;
    public const int UiaGroupControlTypeId = 50026;
    public const int UiaPaneControlTypeId = 50033;
    public const int CodeSeparatorControlTypeId = 50038;
    public const int UiaSeparatorControlTypeId = 50038;

    // Property IDs
    public const int UiaRuntimeIdPropertyId = 30000;
    public const int UiaBoundingRectanglePropertyId = 30001;
    public const int UiaProcessIdPropertyId = 30002;
    public const int UiaControlTypePropertyId = 30003;
    public const int UiaLocalizedControlTypePropertyId = 30004;
    public const int UiaNamePropertyId = 30005;
    public const int UiaAcceleratorKeyPropertyId = 30006;
    public const int UiaAccessKeyPropertyId = 30007;
    public const int UiaHasKeyboardFocusPropertyId = 30008;
    public const int UiaIsKeyboardFocusablePropertyId = 30009;
    public const int UiaIsEnabledPropertyId = 30010;
    public const int UiaAutomationIdPropertyId = 30011;
    public const int UiaClassNamePropertyId = 30012;
    public const int UiaHelpTextPropertyId = 30013;
    public const int UiaIsControlElementPropertyId = 30016;
    public const int UiaIsContentElementPropertyId = 30017;
    public const int UiaLabeledByPropertyId = 30018;
    public const int UiaIsPasswordPropertyId = 30019;
    public const int UiaNativeWindowHandlePropertyId = 30020;
    public const int UiaIsOffscreenPropertyId = 30022;
    public const int UiaOrientationPropertyId = 30023;
    public const int UiaItemStatusPropertyId = 30028;
    public const int UiaLiveSettingPropertyId = 30135;

    // Pattern Property IDs
    public const int UiaValueValuePropertyId = 30045;
    public const int UiaValueIsReadOnlyPropertyId = 30046;
    public const int UiaSelectionSelectionPropertyId = 30059;
    public const int UiaSelectionCanSelectMultiplePropertyId = 30060;
    public const int UiaSelectionIsSelectionRequiredPropertyId = 30061;
    public const int UiaSelectionItemIsSelectedPropertyId = 30079;
    public const int UiaSelectionItemSelectionContainerPropertyId = 30080;
    public const int UiaToggleToggleStatePropertyId = 30086;
    public const int UiaExpandCollapseExpandCollapseStatePropertyId = 30070;

    // Event IDs
    public const int UiaStructureChangedEventId = 20002;
    public const int UiaAutomationPropertyChangedEventId = 20004;
    public const int UiaAutomationFocusChangedEventId = 20005;
    public const int UiaInvoke_InvokedEventId = 20009;
    public const int UiaSelectionItem_ElementSelectedEventId = 20012;
    public const int UiaLiveRegionChangedEventId = 20024;
    public const int UiaNotificationEventId = 20035;
    public const int UiaText_TextSelectionChangedEventId = 20014;
    public const int UiaText_TextChangedEventId = 20015;

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=E499A7
    // Hairs-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll", EntryPoint = "UiaReturnRawElementProvider")]
    public static partial IntPtr UiaReturnRawElementProvider(IntPtr hwnd, IntPtr wParam, IntPtr lParam, INativeSimple provider);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B1D4CE
    // Hairs-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll")]
    public static partial int UiaHostProviderFromHwnd(IntPtr hwnd, out INativeSimple? provider);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A59524
    // Hairs-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll")]
    public static partial int UiaGetReservedNotSupportedValue(out IntPtr notSupportedValue);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B218D1
    // Hairs-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool UiaClientsAreListening();

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=86A3FD
    // Hairs-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll", EntryPoint = "UiaRaiseAutomationEvent")]
    public static partial int UiaRaiseAutomationEvent(INativeSimple provider, int eventId);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=C1E16B
    // Hairs-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll", EntryPoint = "UiaRaiseAutomationPropertyChangedEvent")]
    public static partial int UiaRaiseAutomationPropertyChangedEvent(INativeSimple provider, int propertyId, AutomationVariant oldValue, AutomationVariant newValue);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=5BF310
    // Hairs-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll", EntryPoint = "UiaRaiseNotificationEvent")]
    public static partial int UiaRaiseNotificationEvent(INativeSimple provider, NotificationKind kind, NotificationProcessing processing,
        [MarshalAs(UnmanagedType.BStr)] string displayString, [MarshalAs(UnmanagedType.BStr)] string activityId);

    // Hairs-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=480DB2
    // Hairs-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll", EntryPoint = "UiaRaiseStructureChangedEvent")]
    public static partial int UiaRaiseStructureChangedEvent(INativeSimple provider, StructureChangeType change,
        [MarshalUsing(CountElementName = nameof(length))] int[]? runtimeId, int length);
}
