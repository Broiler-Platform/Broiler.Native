using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Linux.OpenGL;

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

    [LibraryImport("libX11.so.6", EntryPoint = "XOpenDisplay")]
    public static partial IntPtr OpenDisplay(IntPtr displayName);

    [LibraryImport("libX11.so.6", EntryPoint = "XCloseDisplay")]
    public static partial int CloseDisplay(IntPtr display);

    [LibraryImport("libX11.so.6", EntryPoint = "XDefaultScreen")]
    public static partial int DefaultScreen(IntPtr display);

    [LibraryImport("libX11.so.6", EntryPoint = "XRootWindow")]
    public static partial IntPtr RootWindow(IntPtr display, int screenNumber);

    [LibraryImport("libX11.so.6", EntryPoint = "XBlackPixel")]
    public static partial IntPtr BlackPixel(IntPtr display, int screenNumber);

    [LibraryImport("libX11.so.6", EntryPoint = "XWhitePixel")]
    public static partial IntPtr WhitePixel(IntPtr display, int screenNumber);

    [LibraryImport("libX11.so.6", EntryPoint = "XCreateSimpleWindow")]
    public static partial IntPtr CreateSimpleWindow(IntPtr display, IntPtr parent,
        int x, int y, uint width, uint height, uint borderWidth, IntPtr border, IntPtr background);

    [LibraryImport("libX11.so.6", EntryPoint = "XStoreName")]
    public static partial int StoreName(IntPtr display, IntPtr window, [MarshalAs(UnmanagedType.LPStr)] string windowName);

    [LibraryImport("libX11.so.6", EntryPoint = "XSelectInput")]
    public static partial int SelectInput(IntPtr display, IntPtr window, long eventMask);

    [LibraryImport("libX11.so.6", EntryPoint = "XMapWindow")]
    public static partial int MapWindow(IntPtr display, IntPtr window);

    [LibraryImport("libX11.so.6", EntryPoint = "XResizeWindow")]
    public static partial int ResizeWindow(IntPtr display, IntPtr window, uint width, uint height);

    [LibraryImport("libX11.so.6", EntryPoint = "XDestroyWindow")]
    public static partial int DestroyWindow(IntPtr display, IntPtr window);

    [LibraryImport("libX11.so.6", EntryPoint = "XFlush")]
    public static partial int Flush(IntPtr display);

    [LibraryImport("libX11.so.6", EntryPoint = "XPending")]
    public static partial int Pending(IntPtr display);

    [LibraryImport("libX11.so.6", EntryPoint = "XNextEvent")]
    public static partial int NextEvent(IntPtr display, out XEvent inputEvent);

    [LibraryImport("libX11.so.6", EntryPoint = "XInternAtom")]
    public static partial IntPtr InternAtom(IntPtr display, [MarshalAs(UnmanagedType.LPStr)] string atomName, int onlyIfExists);

    /// <summary>
    /// Writes a window property. Needed for <c>_NET_WM_NAME</c>, which is the title a modern window
    /// manager actually reads: <c>XStoreName</c> writes the legacy <c>WM_NAME</c>, and that one is
    /// Latin-1, so a document called "Übung.docx" comes out mangled through it.
    /// </summary>
    [LibraryImport("libX11.so.6", EntryPoint = "XChangeProperty")]
    public static partial int ChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type,
        int format, int mode, byte[] data, int elementCount);

    [LibraryImport("libX11.so.6", EntryPoint = "XSetWMProtocols")]
    public static partial int SetWmProtocols(IntPtr display, IntPtr window, IntPtr[] protocols, int count);

    [LibraryImport("libX11.so.6", EntryPoint = "XSetInputFocus")]
    public static partial int SetInputFocus(IntPtr display, IntPtr focus, int revertTo, int time);

    [LibraryImport("libX11.so.6", EntryPoint = "XQueryPointer")]
    public static partial int QueryPointer(IntPtr display, IntPtr window, out IntPtr rootReturn, out IntPtr childReturn, 
        out int rootX, out int rootY, out int winX, out int winY, out uint maskReturn);

    [LibraryImport("libX11.so.6", EntryPoint = "XSync")]
    public static partial int Sync(IntPtr display, int discard);

    [LibraryImport("libX11.so.6", EntryPoint = "XGetInputFocus")]
    public static partial int GetInputFocus(IntPtr display, out IntPtr focusReturn, out int revertToReturn);

    // Installs an error handler so a premature/best-effort XSetInputFocus (e.g.
    // a BadMatch on a not-yet-viewable window) cannot abort the process. Xlib's
    // default handler calls exit(); returning from a custom handler is ignored.
    [LibraryImport("libX11.so.6", EntryPoint = "XSetErrorHandler")]
    public static partial IntPtr SetErrorHandler(IntPtr handler);

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
