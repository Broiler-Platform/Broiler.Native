// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
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

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=8EEEA0
// Broiler-Human:        PENDING
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

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=4A8927
// Broiler-Human:        PENDING
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
// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=5C0948
// Broiler-Human:        PENDING
[StructLayout(LayoutKind.Sequential)]
public struct AutomationVariant
{
    public ulong Header;
    public VariantData Data;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=2F6795
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Explicit)]
    public struct VariantData
    {
        [FieldOffset(0)] public long Value;
        [FieldOffset(0)] public RecordPointers Record;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=96DFD4
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct RecordPointers { public IntPtr Record; public IntPtr RecordInfo; }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=047E8E
    // Broiler-Human:        PENDING
    public static AutomationVariant From(ComVariant value) => Unsafe.BitCast<ComVariant, AutomationVariant>(value);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=11287A
    // Broiler-Human:        PENDING
    public ComVariant ToVariant() => Unsafe.BitCast<AutomationVariant, ComVariant>(this);
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=6A22EF
// Broiler-Human:        PENDING
public interface IRawElementProviderSimple
{
    ProviderOptions ProviderOptions { get; }
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=D9F449
    // Broiler-Human:        PENDING
    object? GetPatternProvider(int patternId);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=E75AB1
    // Broiler-Human:        PENDING
    object? GetPropertyValue(int propertyId);
    IRawElementProviderSimple? HostRawElementProvider { get; }
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=471911
// Broiler-Human:        PENDING
public interface IRawElementProviderFragment : IRawElementProviderSimple
{
    new ProviderOptions ProviderOptions { get; }
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=99334F
    // Broiler-Human:        PENDING
    new object? GetPatternProvider(int patternId);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=19F652
    // Broiler-Human:        PENDING
    new object? GetPropertyValue(int propertyId);
    new IRawElementProviderSimple? HostRawElementProvider { get; }
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=FA151F
    // Broiler-Human:        PENDING
    IRawElementProviderFragment? Navigate(NavigateDirection direction);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=43D0C1
    // Broiler-Human:        PENDING
    int[]? GetRuntimeId();
    UiaRect BoundingRectangle { get; }
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=90317C
    // Broiler-Human:        PENDING
    IRawElementProviderSimple[]? GetEmbeddedFragmentRoots();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A71F75
    // Broiler-Human:        PENDING
    void SetFocus();
    IRawElementProviderFragmentRoot? FragmentRoot { get; }
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=CF4D08
// Broiler-Human:        PENDING
public interface IRawElementProviderFragmentRoot : IRawElementProviderFragment
{
    new ProviderOptions ProviderOptions { get; }
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=99334F
    // Broiler-Human:        PENDING
    new object? GetPatternProvider(int patternId);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=19F652
    // Broiler-Human:        PENDING
    new object? GetPropertyValue(int propertyId);
    new IRawElementProviderSimple? HostRawElementProvider { get; }
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=D586AA
    // Broiler-Human:        PENDING
    new IRawElementProviderFragment? Navigate(NavigateDirection direction);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=849995
    // Broiler-Human:        PENDING
    new int[]? GetRuntimeId();
    new UiaRect BoundingRectangle { get; }
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=FD0437
    // Broiler-Human:        PENDING
    new IRawElementProviderSimple[]? GetEmbeddedFragmentRoots();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=9EB2D0
    // Broiler-Human:        PENDING
    new void SetFocus();
    new IRawElementProviderFragmentRoot? FragmentRoot { get; }
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=4DA22C
    // Broiler-Human:        PENDING
    IRawElementProviderFragment? ElementProviderFromPoint(double x, double y);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=E19084
    // Broiler-Human:        PENDING
    IRawElementProviderFragment? GetFocus();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=899FF7
// Broiler-Human:        PENDING
public interface IInvokeProvider
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=331255
    // Broiler-Human:        PENDING
    void Invoke();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3A6B1D
// Broiler-Human:        PENDING
public interface IValueProvider
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=795341
    // Broiler-Human:        PENDING
    void SetValue(string value);
    string Value { get; }
    bool IsReadOnly { get; }
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=6C0341
// Broiler-Human:        PENDING
public interface ISelectionItemProvider
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=04AB86
    // Broiler-Human:        PENDING
    void Select();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=478D2F
    // Broiler-Human:        PENDING
    void AddToSelection();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3C1E5A
    // Broiler-Human:        PENDING
    void RemoveFromSelection();
    bool IsSelected { get; }
    IRawElementProviderSimple? SelectionContainer { get; }
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=38F0F0
// Broiler-Human:        PENDING
public interface ISelectionProvider
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=488B54
    // Broiler-Human:        PENDING
    IRawElementProviderSimple[]? GetSelection();
    bool CanSelectMultiple { get; }
    bool IsSelectionRequired { get; }
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=842DE8
// Broiler-Human:        PENDING
public interface IToggleProvider
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=4E7622
    // Broiler-Human:        PENDING
    void Toggle();
    ToggleState ToggleState { get; }
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3CB104
// Broiler-Human:        PENDING
public interface IExpandCollapseProvider
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=94BF96
    // Broiler-Human:        PENDING
    void Expand();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=47F0C8
    // Broiler-Human:        PENDING
    void Collapse();
    ExpandCollapseState ExpandCollapseState { get; }
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=FB7B7E
// Broiler-Human:        PENDING
public interface IScrollItemProvider
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A594DF
    // Broiler-Human:        PENDING
    void ScrollIntoView();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=35AAA8
// Broiler-Human:        PENDING
[GeneratedComInterface, Guid("d6dd68d1-86fd-4332-8666-9abedea2d24c")]
public partial interface INativeSimple
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=287EEF
    // Broiler-Human:        PENDING
    ProviderOptions GetProviderOptions();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=70D92E
    // Broiler-Human:        PENDING
    IntPtr GetPatternProvider(int patternId);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=568A40
    // Broiler-Human:        PENDING
    AutomationVariant GetPropertyValue(int propertyId);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=D1B927
    // Broiler-Human:        PENDING
    INativeSimple? GetHostRawElementProvider();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=5B9152
// Broiler-Human:        PENDING
[GeneratedComInterface, Guid("f7063da8-8359-439c-9297-bbc5299a7d87")]
public partial interface INativeFragment
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B82872
    // Broiler-Human:        PENDING
    INativeFragment? Navigate(NavigateDirection direction);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=E26C70
    // Broiler-Human:        PENDING
    IntPtr GetRuntimeId();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=AF28EB
    // Broiler-Human:        PENDING
    UiaRect GetBoundingRectangle();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B8092B
    // Broiler-Human:        PENDING
    IntPtr GetEmbeddedFragmentRoots();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A71F75
    // Broiler-Human:        PENDING
    void SetFocus();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3573B5
    // Broiler-Human:        PENDING
    INativeFragmentRoot? GetFragmentRoot();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=234BE4
// Broiler-Human:        PENDING
[GeneratedComInterface, Guid("620ce2a5-ab8f-40a9-86cb-de3c75599b58")]
public partial interface INativeFragmentRoot
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=746E5D
    // Broiler-Human:        PENDING
    INativeFragment? ElementProviderFromPoint(double x, double y);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=998927
    // Broiler-Human:        PENDING
    INativeFragment? GetFocus();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=DA27BA
// Broiler-Human:        PENDING
[GeneratedComInterface, Guid("54fcb24b-e18e-47a2-b4d3-eccbe77599a2")]
public partial interface INativeInvoke
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=331255
    // Broiler-Human:        PENDING
    void Invoke();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=01DBDE
// Broiler-Human:        PENDING
[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16), Guid("c7935180-6fb3-4201-b174-7df73adbf64a")]
public partial interface INativeValue
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=795341
    // Broiler-Human:        PENDING
    void SetValue(string value);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=12A91C
    // Broiler-Human:        PENDING
    [return: MarshalAs(UnmanagedType.BStr)] string GetValue();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=726788
    // Broiler-Human:        PENDING
    [return: MarshalAs(UnmanagedType.Bool)] bool GetIsReadOnly();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=75649E
// Broiler-Human:        PENDING
[GeneratedComInterface, Guid("2acad808-b2d4-452d-a407-91ff1ad167b2")]
public partial interface INativeSelectionItem
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=04AB86
    // Broiler-Human:        PENDING
    void Select();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=478D2F
    // Broiler-Human:        PENDING
    void AddToSelection();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3C1E5A
    // Broiler-Human:        PENDING
    void RemoveFromSelection();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=8548EA
    // Broiler-Human:        PENDING
    [return: MarshalAs(UnmanagedType.Bool)] bool GetIsSelected();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=AFAC6B
    // Broiler-Human:        PENDING
    INativeSimple? GetSelectionContainer();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=2AD339
// Broiler-Human:        PENDING
[GeneratedComInterface, Guid("fb8b03af-3bdf-48d4-bd36-1a65793be168")]
public partial interface INativeSelection
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=274C84
    // Broiler-Human:        PENDING
    IntPtr GetSelection();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=1F00C6
    // Broiler-Human:        PENDING
    [return: MarshalAs(UnmanagedType.Bool)] bool GetCanSelectMultiple();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=53E878
    // Broiler-Human:        PENDING
    [return: MarshalAs(UnmanagedType.Bool)] bool GetIsSelectionRequired();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=6DC829
// Broiler-Human:        PENDING
[GeneratedComInterface, Guid("56d00bd0-c4f4-433c-a836-1a52a57e0892")]
public partial interface INativeToggle
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=4E7622
    // Broiler-Human:        PENDING
    void Toggle();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=16EC2D
    // Broiler-Human:        PENDING
    ToggleState GetToggleState();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=464F3D
// Broiler-Human:        PENDING
[GeneratedComInterface, Guid("d847d3a5-cab0-4a98-8c32-ecb45c59ad24")]
public partial interface INativeExpandCollapse
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=94BF96
    // Broiler-Human:        PENDING
    void Expand();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=47F0C8
    // Broiler-Human:        PENDING
    void Collapse();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=1D4E54
    // Broiler-Human:        PENDING
    ExpandCollapseState GetExpandCollapseState();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=7064A8
// Broiler-Human:        PENDING
[GeneratedComInterface, Guid("2360c714-4bf1-4b26-ba65-9b21316127eb")]
public partial interface INativeScrollItem
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A594DF
    // Broiler-Human:        PENDING
    void ScrollIntoView();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B51CAE
// Broiler-Human:        PENDING
[GeneratedComInterface, Guid("3589c92c-63f3-4367-99bb-ada653b77cf2")]
public partial interface INativeText
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=274C84
    // Broiler-Human:        PENDING
    IntPtr GetSelection();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B8BBDA
    // Broiler-Human:        PENDING
    IntPtr GetVisibleRanges();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B767DF
    // Broiler-Human:        PENDING
    INativeTextRange? RangeFromChild(INativeSimple? childElement);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=F8E5B1
    // Broiler-Human:        PENDING
    INativeTextRange? RangeFromPoint(UiaPoint point);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A3398E
    // Broiler-Human:        PENDING
    INativeTextRange? GetDocumentRange();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=8BCAF6
    // Broiler-Human:        PENDING
    SupportedTextSelection GetSupportedTextSelection();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=DB519F
// Broiler-Human:        PENDING
[GeneratedComInterface(StringMarshalling = StringMarshalling.Utf16), Guid("5347ad7b-c355-46f8-aff5-909033582f63")]
public partial interface INativeTextRange
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=62D716
    // Broiler-Human:        PENDING
    INativeTextRange Clone();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A5BEAD
    // Broiler-Human:        PENDING
    [return: MarshalAs(UnmanagedType.Bool)] bool Compare(INativeTextRange range);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=C4F134
    // Broiler-Human:        PENDING
    int CompareEndpoints(TextPatternRangeEndpoint endpoint, INativeTextRange targetRange, TextPatternRangeEndpoint targetEndpoint);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=65AF04
    // Broiler-Human:        PENDING
    void ExpandToEnclosingUnit(TextUnit unit);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3A0E27
    // Broiler-Human:        PENDING
    INativeTextRange? FindAttribute(int attributeId, AutomationVariant value, [MarshalAs(UnmanagedType.Bool)] bool backward);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=9746B9
    // Broiler-Human:        PENDING
    INativeTextRange? FindText([MarshalAs(UnmanagedType.BStr)] string text, [MarshalAs(UnmanagedType.Bool)] bool backward, [MarshalAs(UnmanagedType.Bool)] bool ignoreCase);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=6C05C0
    // Broiler-Human:        PENDING
    AutomationVariant GetAttributeValue(int attributeId);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3D7A90
    // Broiler-Human:        PENDING
    IntPtr GetBoundingRectangles();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=830AD2
    // Broiler-Human:        PENDING
    INativeSimple? GetEnclosingElement();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=50D08F
    // Broiler-Human:        PENDING
    [return: MarshalAs(UnmanagedType.BStr)] string GetText(int maxLength);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=30F83D
    // Broiler-Human:        PENDING
    int Move(TextUnit unit, int count);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=FF7F14
    // Broiler-Human:        PENDING
    int MoveEndpointByUnit(TextPatternRangeEndpoint endpoint, TextUnit unit, int count);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=58ED87
    // Broiler-Human:        PENDING
    void MoveEndpointByRange(TextPatternRangeEndpoint endpoint, INativeTextRange targetRange, TextPatternRangeEndpoint targetEndpoint);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=04AB86
    // Broiler-Human:        PENDING
    void Select();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=478D2F
    // Broiler-Human:        PENDING
    void AddToSelection();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=3C1E5A
    // Broiler-Human:        PENDING
    void RemoveFromSelection();
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=870343
    // Broiler-Human:        PENDING
    void ScrollIntoView([MarshalAs(UnmanagedType.Bool)] bool alignToTop);
    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=5D364B
    // Broiler-Human:        PENDING
    IntPtr GetChildren();
}

// Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=82DAA4
// Broiler-Human:        PENDING
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

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=E499A7
    // Broiler-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll", EntryPoint = "UiaReturnRawElementProvider")]
    public static partial IntPtr UiaReturnRawElementProvider(IntPtr hwnd, IntPtr wParam, IntPtr lParam, INativeSimple provider);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B1D4CE
    // Broiler-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll")]
    public static partial int UiaHostProviderFromHwnd(IntPtr hwnd, out INativeSimple? provider);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=A59524
    // Broiler-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll")]
    public static partial int UiaGetReservedNotSupportedValue(out IntPtr notSupportedValue);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B218D1
    // Broiler-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool UiaClientsAreListening();

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=86A3FD
    // Broiler-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll", EntryPoint = "UiaRaiseAutomationEvent")]
    public static partial int UiaRaiseAutomationEvent(INativeSimple provider, int eventId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=C1E16B
    // Broiler-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll", EntryPoint = "UiaRaiseAutomationPropertyChangedEvent")]
    public static partial int UiaRaiseAutomationPropertyChangedEvent(INativeSimple provider, int propertyId, AutomationVariant oldValue, AutomationVariant newValue);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=5BF310
    // Broiler-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll", EntryPoint = "UiaRaiseNotificationEvent")]
    public static partial int UiaRaiseNotificationEvent(INativeSimple provider, NotificationKind kind, NotificationProcessing processing,
        [MarshalAs(UnmanagedType.BStr)] string displayString, [MarshalAs(UnmanagedType.BStr)] string activityId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=480DB2
    // Broiler-Human:        PENDING
    [LibraryImport("UIAutomationCore.dll", EntryPoint = "UiaRaiseStructureChangedEvent")]
    public static partial int UiaRaiseStructureChangedEvent(INativeSimple provider, StructureChangeType change,
        [MarshalUsing(CountElementName = nameof(length))] int[]? runtimeId, int length);
}
