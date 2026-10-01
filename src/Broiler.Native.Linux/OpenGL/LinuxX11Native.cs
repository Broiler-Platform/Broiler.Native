// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   38
// Annotated:        38/38
// Exempt:           4
// Human-reviewed:   0/38
// IP risk:          Low
// Security risk:    Critical
// Criteria:         38/38
// Resource impact:  3/10 max
// Unverified:       38
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Linux.OpenGL;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=96F4E9
// Broiler-Falsified-If: XChangeProperty or XSetWMProtocols is handed an element count larger than its managed array, and Xlib reads past the end of the pinned data
// Broiler-Human:        PENDING
public static partial class LinuxX11Native
{
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=5A4444
    // Broiler-Falsified-If: the value is nonzero, so XSync(display, False) discards queued events such as a pending ConfigureNotify and InternAtom only looks up atoms that already exist
    // Broiler-Human:        PENDING
    public const int False = 0;

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=0B2AC7
    // Broiler-Falsified-If: the value differs from X.h's FocusIn (9), so a focus gain read from XNextEvent is never recognised or another event type is taken for one
    // Broiler-Human:        PENDING
    public const int FocusIn = 9;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=513968
    // Broiler-Falsified-If: the value differs from X.h's FocusOut (10), so a focus loss read from XNextEvent is never recognised or another event type is taken for one
    // Broiler-Human:        PENDING
    public const int FocusOut = 10;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=1108B2
    // Broiler-Falsified-If: the value differs from X.h's MapNotify (19), so the window-mapped event is never recognised and the post-map focus request never runs
    // Broiler-Human:        PENDING
    public const int MapNotify = 19;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=DAA504
    // Broiler-Falsified-If: the value differs from X.h's ConfigureNotify (22), so XEvent bytes 56 and 60 of another event type are read as the new window width and height
    // Broiler-Human:        PENDING
    public const int ConfigureNotify = 22;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=F416DA
    // Broiler-Falsified-If: the value differs from X.h's ClientMessage (33), so XEvent byte 56 of another event type is compared against WM_DELETE_WINDOW and a close request is missed or invented
    // Broiler-Human:        PENDING
    public const int ClientMessage = 33;

    /// <summary>XChangeProperty's PropModeReplace.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=29F3D4
    // Broiler-Falsified-If: the value differs from X.h's PropModeReplace (0), so each title change prepends or appends to _NET_WM_NAME instead of replacing it
    // Broiler-Human:        PENDING
    public const int PropModeReplace = 0;

    /// <summary>A property of 8-bit items, which is what a UTF-8 title is.</summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=0082CC
    // Broiler-Falsified-If: the value is not 8, so XChangeProperty given a UTF-8 byte array with its byte length as the element count reads 2 or 8 times that many bytes from the array
    // Broiler-Human:        PENDING
    public const int Format8 = 8;

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=6AD7EF
    // Broiler-Falsified-If: the value differs from X.h's RevertToParent (2), so XSetInputFocus raises BadValue or focus reverts to the root instead of the parent when the window is unmapped
    // Broiler-Human:        PENDING
    public const int RevertToParent = 2;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=34E752
    // Broiler-Falsified-If: the value is not 0 (X.h's CurrentTime), so XSetInputFocus carries a stale timestamp and the server ignores the focus request
    // Broiler-Human:        PENDING
    public const int CurrentTime = 0;

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=027160
    // Broiler-Falsified-If: the value differs from X.h's ExposureMask (bit 15), so XSelectInput requests a different event class than Expose
    // Broiler-Human:        PENDING
    public const long ExposureMask = 1L << 15;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=F90552
    // Broiler-Falsified-If: the value differs from X.h's StructureNotifyMask (bit 17), so ConfigureNotify and MapNotify are never delivered and window resizes go unseen
    // Broiler-Human:        PENDING
    public const long StructureNotifyMask = 1L << 17;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=9A9639
    // Broiler-Falsified-If: the value differs from X.h's FocusChangeMask (bit 21), so FocusIn and FocusOut are never delivered to the window
    // Broiler-Human:        PENDING
    public const long FocusChangeMask = 1L << 21;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=929967
    // Broiler-Falsified-If: a non-zero displayName that does not point to a NUL-terminated byte string is read past its end by XOpenDisplay
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XOpenDisplay")]
    public static partial IntPtr OpenDisplay(IntPtr displayName);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=876CC0
    // Broiler-Falsified-If: a Display* is passed to any other X call after CloseDisplay returned for it, so Xlib touches freed connection memory
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XCloseDisplay")]
    public static partial int CloseDisplay(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=84D7AA
    // Broiler-Falsified-If: a null Display* from a failed OpenDisplay reaches XDefaultScreen, which dereferences it without a null test and crashes the process
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XDefaultScreen")]
    public static partial int DefaultScreen(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0B2C4A
    // Broiler-Falsified-If: a screenNumber outside 0 to ScreenCount minus 1 is passed, and XRootWindow indexes past Xlib's screen array without a bounds test
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XRootWindow")]
    public static partial IntPtr RootWindow(IntPtr display, int screenNumber);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=224BE2
    // Broiler-Falsified-If: a screenNumber outside 0 to ScreenCount minus 1 is passed, and XBlackPixel indexes past Xlib's screen array without a bounds test
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XBlackPixel")]
    public static partial IntPtr BlackPixel(IntPtr display, int screenNumber);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=48663B
    // Broiler-Falsified-If: a screenNumber outside 0 to ScreenCount minus 1 is passed, and XWhitePixel indexes past Xlib's screen array without a bounds test
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
    // Broiler-Falsified-If: a zero width or height reaches XResizeWindow, and the resulting BadValue error goes to Xlib's default handler, which exits the process when no custom handler is installed
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XResizeWindow")]
    public static partial int ResizeWindow(IntPtr display, IntPtr window, uint width, uint height);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=79BA88
    // Broiler-Falsified-If: the window is destroyed after its Display* was closed, so XDestroyWindow writes into freed connection memory
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XDestroyWindow")]
    public static partial int DestroyWindow(IntPtr display, IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=F8DD82
    // Broiler-Falsified-If: Flush runs on one thread while another thread issues requests on the same Display* without XInitThreads, corrupting Xlib's output buffer
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XFlush")]
    public static partial int Flush(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B97E6E
    // Broiler-Falsified-If: Pending and NextEvent run on a thread other than the one issuing requests on the same Display* without XInitThreads, corrupting Xlib's event queue
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
    // Broiler-Falsified-If: an elementCount larger than data.Length, or format 16 or 32 with elementCount equal to the byte length, makes Xlib read past the end of the pinned array (format 32 items are 8-byte C longs on LP64)
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XChangeProperty")]
    public static partial int ChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
        int format, int mode, byte[] data, int elementCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=D252C5
    // Broiler-Falsified-If: a count larger than protocols.Length makes XSetWMProtocols read Atom values past the end of the pinned array
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
    // Broiler-Falsified-If: Sync is called with a nonzero discard, and queued FocusIn, MapNotify and ConfigureNotify events are dropped before the event loop can read them
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
    // Broiler-Falsified-If: the handler pointer comes from a delegate the GC can collect, or one not using the C calling convention, so the next X protocol error calls freed or mismatched thunk code
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
