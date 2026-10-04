// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   38
// Annotated:        38/38
// Exempt:           53
// Human-reviewed:   0/38
// IP risk:          Low
// Security risk:    Critical
// Criteria:         25/25
// Resource impact:  3/10 max
// Unverified:       38
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Linux.OpenGL;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=96F4E9
// Broiler-Falsified-If: an import here differs from its prototype in X11/Xlib.h, where the connection is Display*, Window, Atom and Time are unsigned long in X11/X.h, and Bool and Status are int
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

    public const int SelectionClear = 29;
    public const int SelectionRequest = 30;
    public const int SelectionNotify = 31;
    public const int PropertyNotify = 28;

    public const int PropertyNewValue = 0;
    public const int PropertyDelete = 1;
    public const long PropertyChangeMask = 1L << 22;

    public const int XaAtom = 4;
    public const int XaString = 31;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=929967
    // Broiler-Falsified-If: differs from Display *XOpenDisplay(_Xconst char *display_name) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XOpenDisplay")]
    public static partial IntPtr OpenDisplay(IntPtr displayName);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=876CC0
    // Broiler-Falsified-If: differs from int XCloseDisplay(Display *display) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XCloseDisplay")]
    public static partial int CloseDisplay(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=84D7AA
    // Broiler-Falsified-If: differs from int XDefaultScreen(Display *display) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XDefaultScreen")]
    public static partial int DefaultScreen(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0B2C4A
    // Broiler-Falsified-If: differs from Window XRootWindow(Display *display, int screen_number) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XRootWindow")]
    public static partial IntPtr RootWindow(IntPtr display, int screenNumber);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=224BE2
    // Broiler-Falsified-If: differs from unsigned long XBlackPixel(Display *display, int screen_number) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XBlackPixel")]
    public static partial IntPtr BlackPixel(IntPtr display, int screenNumber);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=48663B
    // Broiler-Falsified-If: differs from unsigned long XWhitePixel(Display *display, int screen_number) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XWhitePixel")]
    public static partial IntPtr WhitePixel(IntPtr display, int screenNumber);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=464005
    // Broiler-Falsified-If: differs from Window XCreateSimpleWindow(Display *display, Window parent, int x, int y, unsigned int width, unsigned int height, unsigned int border_width, unsigned long border, unsigned long background) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XCreateSimpleWindow")]
    public static partial IntPtr CreateSimpleWindow(IntPtr display, IntPtr parent,
        int x, int y, uint width, uint height, uint borderWidth, IntPtr border, IntPtr background);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=EEE573
    // Broiler-Falsified-If: windowName is not marshalled as a NUL-terminated 8-bit string, the _Xconst char *window_name of int XStoreName(Display *display, Window w, _Xconst char *window_name) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XStoreName")]
    public static partial int StoreName(IntPtr display, IntPtr window, [MarshalAs(UnmanagedType.LPStr)] string windowName);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=46FCB1
    // Broiler-Falsified-If: differs from int XSelectInput(Display *display, Window w, long event_mask) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XSelectInput")]
    public static partial int SelectInput(IntPtr display, IntPtr window, long eventMask);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=8B669F
    // Broiler-Falsified-If: differs from int XMapWindow(Display *display, Window w) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XMapWindow")]
    public static partial int MapWindow(IntPtr display, IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=98C0F3
    // Broiler-Falsified-If: differs from int XResizeWindow(Display *display, Window w, unsigned int width, unsigned int height) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XResizeWindow")]
    public static partial int ResizeWindow(IntPtr display, IntPtr window, uint width, uint height);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=79BA88
    // Broiler-Falsified-If: differs from int XDestroyWindow(Display *display, Window w) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XDestroyWindow")]
    public static partial int DestroyWindow(IntPtr display, IntPtr window);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=F8DD82
    // Broiler-Falsified-If: differs from int XFlush(Display *display) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XFlush")]
    public static partial int Flush(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B97E6E
    // Broiler-Falsified-If: differs from int XPending(Display *display) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XPending")]
    public static partial int Pending(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=70D77F
    // Broiler-Falsified-If: the out XEvent is smaller than 192 bytes on 64-bit, the size of union _XEvent with its long pad[24], into which int XNextEvent(Display *display, XEvent *event_return) in X11/Xlib.h writes
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XNextEvent")]
    public static partial int NextEvent(IntPtr display, out XEvent inputEvent);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=C1DAEF
    // Broiler-Falsified-If: atomName is not marshalled as a NUL-terminated 8-bit string, or onlyIfExists not as the int that Bool is, against Atom XInternAtom(Display *display, _Xconst char *atom_name, Bool only_if_exists) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XInternAtom")]
    public static partial IntPtr InternAtom(IntPtr display, [MarshalAs(UnmanagedType.LPStr)] string atomName, int onlyIfExists);

    /// <summary>
    /// Writes a window property. Needed for <c>_NET_WM_NAME</c>, which is the title a modern window
    /// manager actually reads: <c>XStoreName</c> writes the legacy <c>WM_NAME</c>, and that one is
    /// Latin-1, so a document called "Übung.docx" comes out mangled through it.
    /// </summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=618340
    // Broiler-Falsified-If: elementCount counts more items than data holds at the given format, one byte each at format 8, against int XChangeProperty(Display *display, Window w, Atom property, Atom type, int format, int mode, _Xconst unsigned char *data, int nelements) in X11/Xlib.h, which reads nelements items from data
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XChangeProperty")]
    public static partial int ChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
        int format, int mode, byte[] data, int elementCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=D252C5
    // Broiler-Falsified-If: count is larger than protocols.Length, the IntPtr-sized slots from which Status XSetWMProtocols(Display *display, Window w, Atom *protocols, int count) in X11/Xlib.h reads count Atoms, Atom being unsigned long in X11/X.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XSetWMProtocols")]
    public static partial int SetWmProtocols(IntPtr display, IntPtr window, IntPtr[] protocols, int count);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=54C7BF
    // Broiler-Falsified-If: differs from int XSetInputFocus(Display *display, Window focus, int revert_to, Time time) in X11/Xlib.h, where Time is unsigned long in X11/X.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XSetInputFocus")]
    public static partial int SetInputFocus(IntPtr display, IntPtr focus, int revertTo, int time);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=C89EB0
    // Broiler-Falsified-If: differs from Bool XQueryPointer(Display *display, Window w, Window *root_return, Window *child_return, int *root_x_return, int *root_y_return, int *win_x_return, int *win_y_return, unsigned int *mask_return) in X11/Xlib.h, where Bool is int
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XQueryPointer")]
    public static partial int QueryPointer(IntPtr display, IntPtr window, out IntPtr rootReturn, out IntPtr childReturn, 
        out int rootX, out int rootY, out int winX, out int winY, out uint maskReturn);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=B4629B
    // Broiler-Falsified-If: differs from int XSync(Display *display, Bool discard) in X11/Xlib.h, where Bool is int
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XSync")]
    public static partial int Sync(IntPtr display, int discard);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=1B3468
    // Broiler-Falsified-If: differs from int XGetInputFocus(Display *display, Window *focus_return, int *revert_to_return) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XGetInputFocus")]
    public static partial int GetInputFocus(IntPtr display, out IntPtr focusReturn, out int revertToReturn);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=532BDD
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XSetSelectionOwner")]
    public static partial int SetSelectionOwner(IntPtr display, IntPtr selection, IntPtr owner, IntPtr time);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=D22241
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XGetSelectionOwner")]
    public static partial IntPtr GetSelectionOwner(IntPtr display, IntPtr selection);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=5CD1C1
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XConvertSelection")]
    public static partial int ConvertSelection(IntPtr display, IntPtr selection, IntPtr target, IntPtr property, IntPtr requestor, IntPtr time);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=15C52D
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XChangeProperty")]
    public static partial int ChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
        int format, int mode, IntPtr[] data, int elementCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=6E7416
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XDeleteProperty")]
    public static partial int DeleteProperty(IntPtr display, IntPtr window, IntPtr property);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=47A3EE
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XGetWindowProperty")]
    public static partial int GetWindowProperty(
        IntPtr display,
        IntPtr window,
        IntPtr property,
        IntPtr offset,
        IntPtr length,
        int delete,
        IntPtr requestedType,
        out IntPtr actualType,
        out int actualFormat,
        out IntPtr items,
        out IntPtr bytesAfter,
        out IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=B7BA32
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XSendEvent")]
    public static partial int SendEvent(IntPtr display, IntPtr window, int propagate, long mask, ref XEvent sendEvent);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=09E92C
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XMaxRequestSize")]
    public static partial long MaxRequestSize(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=1C2D8D
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XExtendedMaxRequestSize")]
    public static partial long ExtendedMaxRequestSize(IntPtr display);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=4C1527
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XFree")]
    public static partial int Free(IntPtr data);

    // Installs an error handler so a premature/best-effort XSetInputFocus (e.g.
    // a BadMatch on a not-yet-viewable window) cannot abort the process. Xlib's
    // default handler calls exit(); returning from a custom handler is ignored.
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=36F83B
    // Broiler-Falsified-If: handler is not a function of the XErrorHandler type int (*)(Display *display, XErrorEvent *error_event) that stays callable while installed, against XErrorHandler XSetErrorHandler(XErrorHandler handler) in X11/Xlib.h
    // Broiler-Human:        PENDING
    [LibraryImport("libX11.so.6", EntryPoint = "XSetErrorHandler")]
    public static partial IntPtr SetErrorHandler(IntPtr handler);

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=803926
    // Broiler-Falsified-If: Marshal.SizeOf is not 192 on 64-bit, the size of union _XEvent with its long pad[24] in X11/Xlib.h, or ConfigureWidth, ConfigureHeight and ClientMessageData0 are not at offsets 56, 60 and 56, where XConfigureEvent puts width and height and XClientMessageEvent puts data.l[0]
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

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=8A6F1E
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct XSelectionRequestEvent
    {
        public int Type;
        public IntPtr Serial;
        public int SendEvent;
        public IntPtr Display;
        public IntPtr Owner;
        public IntPtr Requestor;
        public IntPtr Selection;
        public IntPtr Target;
        public IntPtr Property;
        public IntPtr Time;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=379F58
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct XSelectionEvent
    {
        public int Type;
        public IntPtr Serial;
        public int SendEvent;
        public IntPtr Display;
        public IntPtr Requestor;
        public IntPtr Selection;
        public IntPtr Target;
        public IntPtr Property;
        public IntPtr Time;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=26B460
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct XPropertyEvent
    {
        public int Type;
        public IntPtr Serial;
        public int SendEvent;
        public IntPtr Display;
        public IntPtr Window;
        public IntPtr Atom;
        public IntPtr Time;
        public int State;
    }
}
