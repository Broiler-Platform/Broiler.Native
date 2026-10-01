// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   25
// Annotated:        25/25
// Exempt:           17
// Human-reviewed:   0/25
// IP risk:          Low
// Security risk:    Critical
// Criteria:         25/25
// Resource impact:  3/10 max
// Unverified:       25
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Linux.OpenGL;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=96F4E9
// Broiler-Falsified-If: SetWmProtocols's Atom array does not use pointer-sized elements, so on x86-64 XSetWMProtocols reads 8-byte Atoms from 4-byte elements and runs past the end of the pinned array
// Broiler-Human:        PENDING
public static partial class LinuxX11Native
{
    public const int False = 0;

    public const int FocusIn = 9;
    public const int FocusOut = 10;
    public const int MapNotify = 19;
    public const int ConfigureNotify = 22;
    public const int ClientMessage = 33;

    /// <summary>XChangeProperty's PropModeReplace.</summary>
    public const int PropModeReplace = 0;

    /// <summary>A property of 8-bit items, which is what a UTF-8 title is.</summary>
    public const int Format8 = 8;

    public const int RevertToParent = 2;
    public const int CurrentTime = 0;

    public const long ExposureMask = 1L << 15;
    public const long StructureNotifyMask = 1L << 17;
    public const long FocusChangeMask = 1L << 21;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=929967
    // Broiler-Falsified-If: displayName is declared narrower than a pointer, so on x86-64 XOpenDisplay reads the display name through a truncated address
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XOpenDisplay")]
    public static partial IntPtr OpenDisplay(IntPtr displayName);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=876CC0
    // Broiler-Falsified-If: the display argument is declared narrower than a pointer, so on x86-64 XCloseDisplay receives a truncated Display* and frees memory at an unrelated address
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XCloseDisplay")]
    public static partial int CloseDisplay(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=84D7AA
    // Broiler-Falsified-If: the import binds XDefaultScreenOfDisplay rather than XDefaultScreen, so a Screen* truncated to int is returned as the screen number
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XDefaultScreen")]
    public static partial int DefaultScreen(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0B2C4A
    // Broiler-Falsified-If: the Window return is declared narrower than C unsigned long, so on x86-64 the root window id read back is truncated and XCreateSimpleWindow is given another parent
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XRootWindow")]
    public static partial IntPtr RootWindow(IntPtr display, int screenNumber);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=224BE2
    // Broiler-Falsified-If: the pixel return is declared narrower than C unsigned long, so on x86-64 the border colour passed on to XCreateSimpleWindow carries undefined upper bits
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XBlackPixel")]
    public static partial IntPtr BlackPixel(IntPtr display, int screenNumber);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=48663B
    // Broiler-Falsified-If: the pixel return is declared narrower than C unsigned long, so on x86-64 the background colour passed on to XCreateSimpleWindow carries undefined upper bits
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XWhitePixel")]
    public static partial IntPtr WhitePixel(IntPtr display, int screenNumber);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=464005
    // Broiler-Falsified-If: border or background is declared narrower than C unsigned long, so these stack-passed arguments reach XCreateSimpleWindow with undefined upper bytes on x86-64
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XCreateSimpleWindow")]
    public static partial IntPtr CreateSimpleWindow(IntPtr display, IntPtr parent,
        int x, int y, uint width, uint height, uint borderWidth, IntPtr border, IntPtr background);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=EEE573
    // Broiler-Falsified-If: the title is marshalled as UTF-16 or without a terminating NUL, so XStoreName reads past the end of the marshalled buffer
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XStoreName")]
    public static partial int StoreName(IntPtr display, IntPtr window, [MarshalAs(UnmanagedType.LPStr)] string windowName);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=46FCB1
    // Broiler-Falsified-If: eventMask is passed with a width other than C long, so on LP64 Xlib reads undefined upper bits and selects event classes that were not requested
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XSelectInput")]
    public static partial int SelectInput(IntPtr display, IntPtr window, long eventMask);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=8B669F
    // Broiler-Falsified-If: the window XID is declared narrower than C unsigned long, so XMapWindow receives an XID with undefined upper bits and maps another window or raises BadWindow
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XMapWindow")]
    public static partial int MapWindow(IntPtr display, IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=98C0F3
    // Broiler-Falsified-If: width and height reach XResizeWindow in swapped positions, so a resize to 800 by 600 is followed by a ConfigureNotify reporting 600 by 800
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XResizeWindow")]
    public static partial int ResizeWindow(IntPtr display, IntPtr window, uint width, uint height);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=79BA88
    // Broiler-Falsified-If: the display and window arguments reach XDestroyWindow(Display*, Window) in swapped positions, so Xlib dereferences the window id as the connection pointer
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XDestroyWindow")]
    public static partial int DestroyWindow(IntPtr display, IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=F8DD82
    // Broiler-Falsified-If: the import binds XSync or another export instead of XFlush, so the call blocks on a server round trip or drops queued events instead of only sending buffered requests
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XFlush")]
    public static partial int Flush(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B97E6E
    // Broiler-Falsified-If: the import binds XEventsQueued or another export instead of XPending, so events still unread on the connection are not counted and the loop stops reading while events are waiting
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XPending")]
    public static partial int Pending(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=70D77F
    // Broiler-Falsified-If: Xlib's XEvent on the target is larger than the 192-byte managed struct, so XNextEvent writes past the out local
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XNextEvent")]
    public static partial int NextEvent(IntPtr display, out XEvent inputEvent);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=C1DAEF
    // Broiler-Falsified-If: the atom name is marshalled as UTF-16 or without a terminating NUL, so the server interns a different atom than the one named, such as _NET_WM_NAME
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XInternAtom")]
    public static partial IntPtr InternAtom(IntPtr display, [MarshalAs(UnmanagedType.LPStr)] string atomName, int onlyIfExists);

    /// <summary>
    /// Writes a window property. Needed for <c>_NET_WM_NAME</c>, which is the title a modern window
    /// manager actually reads: <c>XStoreName</c> writes the legacy <c>WM_NAME</c>, and that one is
    /// Latin-1, so a document called "Übung.docx" comes out mangled through it.
    /// </summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=618340
    // Broiler-Falsified-If: data and elementCount reach XChangeProperty in swapped positions, so the element count is dereferenced as the property data and the array address is taken as the count
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XChangeProperty")]
    public static partial int ChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
        int format, int mode, byte[] data, int elementCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=D252C5
    // Broiler-Falsified-If: protocols is not marshalled as an array of pointer-sized Atoms, so on x86-64 XSetWMProtocols reads 8-byte Atoms from 4-byte elements and runs past the end of the pinned array
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XSetWMProtocols")]
    public static partial int SetWmProtocols(IntPtr display, IntPtr window, IntPtr[] protocols, int count);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=54C7BF
    // Broiler-Falsified-If: time is declared int while Xlib's Time is a 64-bit unsigned long on LP64, so XSetInputFocus receives a register whose upper half the caller never defined
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XSetInputFocus")]
    public static partial int SetInputFocus(IntPtr display, IntPtr focus, int revertTo, int time);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=C89EB0
    // Broiler-Falsified-If: rootReturn or childReturn is declared narrower than the 64-bit Window Xlib writes, so XQueryPointer writes past those out locals
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XQueryPointer")]
    public static partial int QueryPointer(IntPtr display, IntPtr window, out IntPtr rootReturn, out IntPtr childReturn, 
        out int rootX, out int rootY, out int winX, out int winY, out uint maskReturn);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B4629B
    // Broiler-Falsified-If: the import binds an export other than XSync, such as XFlush, so a sync returns before the server has processed the queued requests and the ConfigureNotify they cause is not yet queued
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XSync")]
    public static partial int Sync(IntPtr display, int discard);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=1B3468
    // Broiler-Falsified-If: focusReturn is declared narrower than the 64-bit Window Xlib writes, so XGetInputFocus writes past the out local
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XGetInputFocus")]
    public static partial int GetInputFocus(IntPtr display, out IntPtr focusReturn, out int revertToReturn);

    // Installs an error handler so a premature/best-effort XSetInputFocus (e.g.
    // a BadMatch on a not-yet-viewable window) cannot abort the process. Xlib's
    // default handler calls exit(); returning from a custom handler is ignored.
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=36F83B
    // Broiler-Falsified-If: the handler argument or the previous-handler return is declared narrower than a function pointer, so on x86-64 Xlib installs a truncated handler address and the next protocol error jumps to it
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XSetErrorHandler")]
    public static partial IntPtr SetErrorHandler(IntPtr handler);

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=803926
    // Broiler-Falsified-If: on 64-bit Linux the bytes at offsets 56 and 60 are not XConfigureEvent width and height, or offset 56 is not XClientMessageEvent data.l[0], so resizes and close requests are read from the wrong bytes
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public struct XEvent
    {
        [FieldOffset(0)]
        public int Type;

        // XClientMessageEvent.data.l[0] on the 64-bit Linux targets in the
        // Phase 0 baseline. It is only read when Type == ClientMessage.
        [FieldOffset(56)]
        public IntPtr ClientMessageData0;

        // XConfigureEvent.width/height on 64-bit Linux. These overlap the
        // XClientMessageEvent union storage and are read only for ConfigureNotify.
        [FieldOffset(56)]
        public int ConfigureWidth;

        [FieldOffset(60)]
        public int ConfigureHeight;
    }
}
