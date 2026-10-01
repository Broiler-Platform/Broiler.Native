// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   155
// Annotated:        155/155
// Exempt:           60
// Human-reviewed:   0/155
// IP risk:          Low
// Security risk:    Critical
// Criteria:         155/75
// Resource impact:  5/10 max
// Unverified:       155
//
// GENERATED - DO NOT EDIT MANUALLY

using System.Text;
using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=3B0E79
// Broiler-Falsified-If: GetWindowText(IntPtr, Span<char>) passes a count other than text.Length to GetWindowTextW, so a title longer than the span is written past its end
// Broiler-Human:        PENDING
public static partial class WindowNative
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=16DDCC
    // Broiler-Falsified-If: on a 64-bit process the call reaches SetWindowLongW rather than SetWindowLongPtrW, so the GCHandle pointer stored at GWLP_USERDATA keeps only its low 32 bits and GCHandle.FromIntPtr later resolves a truncated handle
    // Broiler-Human:        PENDING
    public static IntPtr SetWindowLongPtr(IntPtr hwnd, int index, IntPtr value)
    {
        return IntPtr.Size == 8
            ? SetWindowLongPtr64(hwnd, index, value)
            : new IntPtr(SetWindowLong32(hwnd, index, value.ToInt32()));
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=DD2B69
    // Broiler-Falsified-If: on a 64-bit process the call reaches GetWindowLongW rather than GetWindowLongPtrW, so the GWLP_USERDATA pointer read back is sign-extended from 32 bits and GCHandle.FromIntPtr dereferences a different handle
    // Broiler-Human:        PENDING
    public static IntPtr GetWindowLongPtr(IntPtr hwnd, int index)
    {
        return IntPtr.Size == 8
            ? GetWindowLongPtr64(hwnd, index)
            : new IntPtr(GetWindowLong32(hwnd, index));
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D4D0DB
    // Broiler-Falsified-If: on a 64-bit process the call reaches GetClassLongW rather than GetClassLongPtrW, so the GCLP_HICON value read back loses its high 32 bits and no longer equals the icon the class registered
    // Broiler-Human:        PENDING
    public static IntPtr GetClassLongPtr(IntPtr hwnd, int index)
    {
        return IntPtr.Size == 8
            ? GetClassLongPtr64(hwnd, index)
            : new IntPtr(GetClassLong32(hwnd, index));
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=AE2EBF
    // Broiler-Falsified-If: the delegate is declared Cdecl rather than Winapi, so on 32-bit x86 the stdcall WNDPROC caller in user32 finds 16 bytes of arguments left on its stack after every dispatched message
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate IntPtr WndProc(IntPtr hwnd, uint message, IntPtr wParam, IntPtr lParam);

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=637957
    // Broiler-Falsified-If: a field is out of winuser.h WNDCLASSEXW order or Marshal.SizeOf is not 80 on x64 (48 on x86), so RegisterClassExW takes lpfnWndProc or lpszClassName from the wrong offset and the class calls a non-function address
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WNDCLASSEX
    {
        public uint CbSize;
        public uint Style;
        public WndProc LpfnWndProc;
        public int CbClsExtra;
        public int CbWndExtra;
        public IntPtr HInstance;
        public IntPtr HIcon;
        public IntPtr HCursor;
        public IntPtr HbrBackground;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string? LpszMenuName;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string LpszClassName;
        public IntPtr HIconSm;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=563E6D
    // Broiler-Falsified-If: Marshal.SizeOf is not 16 or the fields are not in left, top, right, bottom order, so GetWindowRect or AdjustWindowRectExForDpi writes a frame edge into the wrong member
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct RECT(int left, int top, int right, int bottom)
    {
        public readonly int Left = left;
        public readonly int Top = top;
        public readonly int Right = right;
        public readonly int Bottom = bottom;

        // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=F4DA91
        // Broiler-Falsified-If: Width is not Right minus Left, so a client rect from 0 to 1280 reports a width other than 1280
        // Broiler-Human:        PENDING
        public int Width => Right - Left;

        // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=800389
        // Broiler-Falsified-If: Height is not Bottom minus Top, so a client rect from 0 to 720 reports a height other than 720
        // Broiler-Human:        PENDING
        public int Height => Bottom - Top;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=AA2E46
    // Broiler-Falsified-If: Marshal.SizeOf is not 8 or Y precedes X, so ScreenToClient converts a wheel event's screen coordinates with the axes swapped
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E547C3
    // Broiler-Falsified-If: Marshal.SizeOf is not 24 on x64 (16 on x86) or HwndTrack is not the third field, so TrackMouseEvent rejects the cbSize or arms leave tracking for a handle read from the flags
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct TRACKMOUSEEVENT
    {
        public uint CbSize;
        public uint DwFlags;
        public IntPtr HwndTrack;
        public uint DwHoverTime;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=2C3C7D
    // Broiler-Falsified-If: Marshal.SizeOf is not 48 on x64 (28 on x86) or a field is out of winuser.h order, so DispatchMessageW hands the window procedure wParam in place of lParam
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct MSG
    {
        public IntPtr Hwnd;
        public uint Message;
        public IntPtr WParam;
        public IntPtr LParam;
        public uint Time;
        public POINT Pt;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=39F0BA
    // Broiler-Falsified-If: a field is out of winuser.h CREATESTRUCTW order, so Marshal.PtrToStructure on the WM_NCCREATE lParam reads LpCreateParams from another member and GCHandle.FromIntPtr resolves a value that is not a handle
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct CREATESTRUCT
    {
        public IntPtr LpCreateParams;
        public IntPtr HInstance;
        public IntPtr HMenu;
        public IntPtr HwndParent;
        public int Cy;
        public int Cx;
        public int Y;
        public int X;
        public int Style;
        public IntPtr LpszName;
        public IntPtr LpszClass;
        public uint DwExStyle;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=150856
    // Broiler-Falsified-If: a null module name is marshalled as an empty string rather than a null pointer, so GetModuleHandleW returns zero instead of the executable's HINSTANCE and the window class is registered against no module
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16, EntryPoint = "GetModuleHandleW")]
    public static partial IntPtr GetModuleHandle(string? moduleName);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=2D2FB1
    // Broiler-Falsified-If: the import binds RegisterClassExA rather than RegisterClassExW, so the UTF-16 class name is read as a one-character ANSI string and CreateWindowExW cannot find the class
    // Broiler-Human:        PENDING
    [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern ushort RegisterClassEx(ref WNDCLASSEX windowClass);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=B8CB64
    // Broiler-Falsified-If: the parameters are not in user32 CreateWindowExW order (exStyle, class, name, style, x, y, width, height, parent, menu, instance, param), so the style lands in the extended style or the GCHandle passed as param reaches hMenu
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "CreateWindowExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    public static partial IntPtr CreateWindowEx(uint exStyle, string className, string windowName, uint style,
        int x, int y, int width, int height, IntPtr hwndParent, IntPtr menu, IntPtr instance, IntPtr param);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C0C181
    // Broiler-Falsified-If: menu is marshalled as a 1-byte bool rather than a 4-byte BOOL, so user32 reads three stray bytes and adds a menu bar's height to a window that has none
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool AdjustWindowRectEx(ref RECT rect, uint style, [MarshalAs(UnmanagedType.Bool)] bool menu, uint exStyle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=6C102F
    // Broiler-Falsified-If: exStyle and dpi are swapped relative to user32's (LPRECT, DWORD, BOOL, DWORD, UINT), so the frame is computed for a DPI read from the extended style and a 144-DPI window gets a 96-DPI border
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool AdjustWindowRectExForDpi(ref RECT rect, uint style, [MarshalAs(UnmanagedType.Bool)] bool menu, uint exStyle, uint dpi);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=BF4309
    // Broiler-Falsified-If: index or the return is declared other than a 32-bit int, so SM_CXSCREEN and SM_CYSCREEN read back a register half and a window with no explicit position is centred on a garbage screen size
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial int GetSystemMetrics(int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=BCA376
    // Broiler-Falsified-If: the BOOL return is marshalled as a 1-byte bool, so the previous-visibility result reads three stray register bytes and a hidden window reports as previously visible
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ShowWindow(IntPtr hwnd, int commandShow);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=59BCAA
    // Broiler-Falsified-If: the BOOL return is marshalled as a 1-byte bool, so an UpdateWindow on a destroyed handle reads stray register bytes and reports success
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool UpdateWindow(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=91B735
    // Broiler-Falsified-If: the return is marshalled as bool rather than int, so the -1 that GetMessageW returns for an invalid window handle reads as true and the loop spins dispatching an unfilled MSG
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true, EntryPoint = "GetMessageW")]
    public static partial int GetMessage(out MSG message, IntPtr hwnd, uint filterMin, uint filterMax);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=9CEEB7
    // Broiler-Falsified-If: the MSG is passed by value rather than by pointer, so user32 reads a WM_KEYDOWN's virtual key from the wrong address and no WM_CHAR is posted for typed text
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool TranslateMessage(ref MSG message);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4EEAC8
    // Broiler-Falsified-If: DispatchMessage binds DispatchMessageA, so a WM_CHAR for a character outside the ANSI code page reaches the Unicode window procedure converted through the code page as a question mark
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "DispatchMessageW")]
    public static partial IntPtr DispatchMessage(ref MSG message);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=6D1BFB
    // Broiler-Falsified-If: DefWindowProc binds DefWindowProcA, so WM_NCCREATE copies CREATESTRUCT.lpszName as ANSI and a window created with a non-ASCII title shows a truncated caption
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "DefWindowProcW")]
    public static partial IntPtr DefWindowProc(IntPtr hwnd, uint message, IntPtr wParam, IntPtr lParam);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=28D17C
    // Broiler-Falsified-If: the import is not bound to user32's PostQuitMessage, so destroying the window that owns the loop leaves GetMessage blocking and the process running with no window
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial void PostQuitMessage(int exitCode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=785298
    // Broiler-Falsified-If: wParam or lParam is declared as a 32-bit int, so on 64-bit a pointer-sized payload posted to the window arrives with its high half cleared
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true, EntryPoint = "PostMessageW")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool PostMessage(IntPtr hwnd, uint message, IntPtr wParam, IntPtr lParam);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=11E879
    // Broiler-Falsified-If: erase is marshalled as a 1-byte bool rather than a 4-byte BOOL, so user32 reads three stray bytes and a false erase sends WM_ERASEBKGND, flashing the class brush behind animation frames
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool InvalidateRect(IntPtr hwnd, IntPtr rect, [MarshalAs(UnmanagedType.Bool)] bool erase);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=3194D3
    // Broiler-Falsified-If: rect is declared as a 32-bit int, so on 64-bit the IntPtr.Zero meaning the whole client area arrives with undefined high bits and user32 reads a RECT through it
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ValidateRect(IntPtr hwnd, IntPtr rect);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=19633F
    // Broiler-Falsified-If: repaint is marshalled as a 1-byte bool rather than a 4-byte BOOL, so user32 reads three stray bytes and a moved render host is repainted or left unpainted against the caller's choice
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool MoveWindow(IntPtr hwnd, int x, int y, int width, int height, [MarshalAs(UnmanagedType.Bool)] bool repaint);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=005B01
    // Broiler-Falsified-If: the import does not set SetLastError, so a DestroyWindow refused for a window owned by another thread reports a stale error code instead of ERROR_ACCESS_DENIED
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DestroyWindow(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E7F331
    // Broiler-Falsified-If: the HWND return is declared narrower than a pointer, so on 64-bit the parent handle read back is truncated and the render host resolves another window's GWLP_USERDATA
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial IntPtr GetParent(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=3A2024
    // Broiler-Falsified-If: eventId or the return is declared 32-bit rather than UINT_PTR, so on 64-bit the timer id compared against AnimationTimerId in WM_TIMER never matches and animation ticks fall through to DefWindowProc
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial UIntPtr SetTimer(IntPtr hwnd, nuint eventId, uint elapseMs, IntPtr timerFunc);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=24FCA7
    // Broiler-Falsified-If: eventId is declared 32-bit rather than UINT_PTR, so on 64-bit KillTimer names another timer and the animation timer keeps posting WM_TIMER after it is stopped
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool KillTimer(IntPtr hwnd, nuint eventId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=AD9CC7
    // Broiler-Falsified-If: the return is declared as a BOOL rather than the previously focused HWND, so a caller restoring focus passes 1 as a window handle
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial IntPtr SetFocus(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=54C5B0
    // Broiler-Falsified-If: the return is declared wider than SHORT without sign extension, so the down bit of a held VK_CONTROL lands outside the 0x8000 mask callers test and modifiers read as released
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial short GetKeyState(int virtualKey);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D0E8CE
    // Broiler-Falsified-If: point is passed by value rather than by reference, so user32 writes the client coordinates to a copy and wheel events keep their screen coordinates
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ScreenToClient(IntPtr hwnd, ref POINT point);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0C9D2E
    // Broiler-Falsified-If: trackMouseEvent is passed by value rather than by reference, so user32 reads the TRACKMOUSEEVENT from an address formed from its CbSize and flags
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool TrackMouseEvent(ref TRACKMOUSEEVENT trackMouseEvent);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=212BE0
    // Broiler-Falsified-If: rect is passed by value rather than as an out pointer, so user32 writes the 16-byte client rectangle through an address formed from the struct's first field
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool GetClientRect(IntPtr hwnd, out RECT rect);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=81749E
    // Broiler-Falsified-If: the import binds GetDpiForSystem or another export instead of GetDpiForWindow, so a window on a 144-DPI monitor reports the system DPI
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial uint GetDpiForWindow(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=58339A
    // Broiler-Falsified-If: the HDC return is declared narrower than a pointer, so on 64-bit GetDeviceCaps and ReleaseDC receive a truncated device-context handle
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial IntPtr GetDC(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=089DAA
    // Broiler-Falsified-If: hwnd and hdc are passed in swapped order, so user32 releases nothing, returns 0 and the window DC from GetDC leaks
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial int ReleaseDC(IntPtr hwnd, IntPtr hdc);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A5C5DC
    // Broiler-Falsified-If: index or the return is declared other than a 32-bit int, so LOGPIXELSX reads back a register half and the fallback DPI is not 96 on a 100% display
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll")]
    public static partial int GetDeviceCaps(IntPtr hdc, int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=178AF0
    // Broiler-Falsified-If: cursorName is marshalled as a string rather than passed as the MAKEINTRESOURCE integer, so IDC_ARROW (32512) is looked up as a resource name and the class gets no cursor
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true, EntryPoint = "LoadCursorW")]
    public static partial IntPtr LoadCursor(IntPtr instance, IntPtr cursorName);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=C66880
    // Broiler-Falsified-If: iconName is marshalled as a string rather than passed as the MAKEINTRESOURCE integer, so IDI_APPLICATION is looked up by name, the executable's icon is not found and the class falls back to the generic window glyph
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true, EntryPoint = "LoadIconW")]
    public static partial IntPtr LoadIcon(IntPtr instance, IntPtr iconName);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=CDE6AD
    // Broiler-Falsified-If: the import binds GetSysColor instead of GetSysColorBrush, so a COLORREF value is stored as WNDCLASSEX.HbrBackground and the class background paints with an invalid brush handle
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial IntPtr GetSysColorBrush(int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0ACA59
    // Broiler-Falsified-If: value or the return is declared 32-bit, so on 64-bit the GCHandle pointer stored at GWLP_USERDATA keeps only its low half
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "SetWindowLongPtrW")]
    public static partial IntPtr SetWindowLongPtr64(IntPtr hwnd, int index, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B10A49
    // Broiler-Falsified-If: this import is reached on a 64-bit process, so a pointer stored through it keeps only its low 32 bits
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "SetWindowLongW")]
    public static partial int SetWindowLong32(IntPtr hwnd, int index, int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=5B314E
    // Broiler-Falsified-If: the return is declared 32-bit, so on 64-bit the GWLP_USERDATA value read back is truncated and GCHandle.FromIntPtr resolves another handle or throws
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "GetWindowLongPtrW")]
    public static partial IntPtr GetWindowLongPtr64(IntPtr hwnd, int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=EDCE2B
    // Broiler-Falsified-If: this import is reached on a 64-bit process, so GWLP_USERDATA reads back only its low 32 bits
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "GetWindowLongW")]
    public static partial int GetWindowLong32(IntPtr hwnd, int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=3B4FE6
    // Broiler-Falsified-If: the return is declared 32-bit, so on 64-bit GCLP_HICON reads back a truncated handle that compares unequal to the icon the class registered
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "GetClassLongPtrW")]
    public static partial IntPtr GetClassLongPtr64(IntPtr hwnd, int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=3B5E17
    // Broiler-Falsified-If: this import is reached on a 64-bit process, so a GCLP_HICON value is read through GetClassLongW and its high 32 bits are lost
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "GetClassLongW")]
    public static partial int GetClassLong32(IntPtr hwnd, int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=D43A2E
    // Broiler-Falsified-If: title is marshalled as ANSI or the import binds SetWindowTextA, so a page title outside the ANSI code page shows as question marks in the caption and taskbar
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "SetWindowTextW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SetWindowText(IntPtr hwnd, string title);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=A75408
    // Broiler-Falsified-If: wParam or lParam is declared 32-bit, so on 64-bit a message whose lParam carries a pointer, such as WM_SETTEXT, makes the window procedure dereference a truncated address
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "SendMessageW")]
    public static partial IntPtr SendMessage(IntPtr hwnd, uint message, IntPtr wParam, IntPtr lParam);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=4BCCEF
    // Broiler-Falsified-If: the import binds to an export other than user32's ReleaseCapture, so a window that captured the mouse on button-down keeps it and the WM_NCLBUTTONDOWN move or size loop sent next does not start
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ReleaseCapture();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A814E8
    // Broiler-Falsified-If: the BOOL return is marshalled as a 1-byte bool, so a nonzero result whose low byte is zero reads as false and a minimised window reports the normal state
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsIconic(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=6E1CF7
    // Broiler-Falsified-If: the BOOL return is marshalled as a 1-byte bool, so a nonzero result whose low byte is zero reads as false and a maximised window keeps its owner-drawn resize border
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsZoomed(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7E4EBC
    // Broiler-Falsified-If: rect is passed by value rather than as an out pointer, so user32 writes the 16-byte screen rectangle through an address formed from the struct's first field
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool GetWindowRect(IntPtr hwnd, out RECT rect);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E8219B
    // Broiler-Falsified-If: flags is not passed through as a 32-bit DWORD, so MONITOR_DEFAULTTONEAREST reaches user32 as MONITOR_DEFAULTTONULL and a window positioned off every monitor gets a zero HMONITOR that GetMonitorInfo rejects
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial IntPtr MonitorFromWindow(IntPtr hwnd, uint flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=7EA744
    // Broiler-Falsified-If: a MONITORINFO whose CbSize names the 104-byte MONITORINFOEXW lets user32 write the device name past the end of the 40-byte managed struct
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "GetMonitorInfoW")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool GetMonitorInfo(IntPtr monitor, ref MONITORINFO info);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=9BE911
    // Broiler-Falsified-If: the BOOL result is read as a 1-byte bool, so a failed DestroyIcon reports success and the caller treats a still-allocated icon handle as freed
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DestroyIcon(IntPtr icon);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=86BA93
    // Broiler-Falsified-If: iconInfo is passed by value rather than by reference, so CreateIconIndirect reads the ICONINFO from an address formed from its FIcon and hotspot fields
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial IntPtr CreateIconIndirect(ref ICONINFO iconInfo);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=9DDFFE
    // Broiler-Falsified-If: a header with BiBitCount of 8 or less, or BI_BITFIELDS compression, makes gdi32 read a colour table or masks past the end of the 40-byte BITMAPINFOHEADER passed by reference
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", SetLastError = true)]
    public static partial IntPtr CreateDIBSection(IntPtr hdc, ref BITMAPINFOHEADER header, uint usage, 
        out IntPtr bits, IntPtr section, uint offset);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=C60669
    // Broiler-Falsified-If: width and bitsPerPixel reach CreateBitmap(int, int, UINT, UINT, const void*) in swapped positions, so a 32-pixel-wide one-bit mask is read as a one-pixel-wide 32-bit bitmap from a non-null bits pointer
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", SetLastError = true)]
    public static partial IntPtr CreateBitmap(int width, int height, uint planes, uint bitsPerPixel, IntPtr bits);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C1D6A1
    // Broiler-Falsified-If: the gdiObject argument is declared narrower than a pointer, so on 64-bit DeleteObject receives a truncated handle and the bitmap leaks
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DeleteObject(IntPtr gdiObject);

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=85EE60
    // Broiler-Falsified-If: Marshal.SizeOf is not 40 or RcWork precedes RcMonitor, so GetMonitorInfo fills the wrong rectangle and a maximised owner-drawn window is clamped to the whole monitor and covers the taskbar
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct MONITORINFO
    {
        public uint CbSize;
        public RECT RcMonitor;
        public RECT RcWork;
        public uint DwFlags;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=3ED120
    // Broiler-Falsified-If: FIcon, XHotspot and YHotspot are not three 4-byte fields ahead of the two bitmap handles, so on 64-bit CreateIconIndirect reads HbmMask from padding and builds the icon from a garbage bitmap handle
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct ICONINFO
    {
        public int FIcon;
        public int XHotspot;
        public int YHotspot;
        public IntPtr HbmMask;
        public IntPtr HbmColor;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=C8BD94
    // Broiler-Falsified-If: Marshal.SizeOf is not 40 or BiPlanes and BiBitCount are not 16-bit, so CreateDIBSection reads BiCompression from BiBitCount's bytes and allocates a DIB of another depth whose bits the caller then overruns
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct BITMAPINFOHEADER
    {
        public uint BiSize;
        public int BiWidth;
        public int BiHeight;
        public ushort BiPlanes;
        public ushort BiBitCount;
        public uint BiCompression;
        public uint BiSizeImage;
        public int BiXPelsPerMeter;
        public int BiYPelsPerMeter;
        public uint BiClrUsed;
        public uint BiClrImportant;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=F83A05
    // Broiler-Falsified-If: the BOOL result is read as a 1-byte bool, so a call refused because the awareness was already set reports success
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SetProcessDpiAwarenessContext(IntPtr dpiContext);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=139E0E
    // Broiler-Falsified-If: lpString and maxCount reach GetWindowTextW(HWND, LPWSTR, int) in swapped positions, so the window title is written to the address given by the count
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "GetWindowTextW", SetLastError = true)]
    public static unsafe partial int GetWindowText(IntPtr hwnd, char* lpString, int maxCount);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=E80171
    // Broiler-Falsified-If: the count passed to GetWindowTextW is not text.Length, so a title longer than the span is written past the end of the pinned span
    // Broiler-Human:        PENDING
    public static unsafe int GetWindowText(IntPtr hwnd, Span<char> text)
    {
        if (text.IsEmpty) return 0;
        fixed (char* ptr = text)
        {
            return GetWindowText(hwnd, ptr, text.Length);
        }
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=6D9166
    // Broiler-Falsified-If: a maxCount different from the length of the char[] it pins lets GetWindowTextW write past the array's end
    // Broiler-Human:        PENDING
    public static int GetWindowText(IntPtr hwnd, StringBuilder text, int maxCount)
    {
        if (maxCount <= 0) return 0;
        char[] buffer = new char[maxCount];
        int count;
        unsafe
        {
            fixed (char* ptr = buffer)
            {
                count = GetWindowText(hwnd, ptr, maxCount);
            }
        }
        if (count > 0)
        {
            text.Append(buffer, 0, count);
        }
        return count;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=563198
    // Broiler-Falsified-If: the value is not winerror.h's ERROR_CLASS_ALREADY_EXISTS (1410), so a second window's RegisterClassEx failure for the already-registered class throws Win32Exception instead of reusing the class
    // Broiler-Human:        PENDING
    public const int ErrorClassAlreadyExists = 1410;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=F3FFA5
    // Broiler-Falsified-If: the value is not winuser.h's CW_USEDEFAULT (0x80000000), so CreateWindowEx places a window without an explicit position at that literal coordinate rather than at the system default
    // Broiler-Human:        PENDING
    public const int CwUseDefault = unchecked((int)0x80000000);
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=0ADB11
    // Broiler-Falsified-If: the value is not winuser.h's CS_HREDRAW (0x0002), so a width change does not invalidate the whole client area and stale pixels remain in the newly exposed strip
    // Broiler-Human:        PENDING
    public const uint CsHRedraw = 0x0002;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=C43CC5
    // Broiler-Falsified-If: the value is not winuser.h's CS_VREDRAW (0x0001), so a height change does not invalidate the whole client area and stale pixels remain in the newly exposed strip
    // Broiler-Human:        PENDING
    public const uint CsVRedraw = 0x0001;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=435859
    // Broiler-Falsified-If: the value is not winuser.h's WS_OVERLAPPEDWINDOW (0x00CF0000), so the top-level window is created without some of its caption, system menu, sizing border and minimise and maximise boxes
    // Broiler-Human:        PENDING
    public const uint WsOverlappedWindow = 0x00CF0000;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=48284F
    // Broiler-Falsified-If: the value is not winuser.h's WS_CHILD (0x40000000), so CreateWindowEx makes the render host a top-level window that is neither clipped to nor moved with its owner
    // Broiler-Human:        PENDING
    public const uint WsChild = 0x40000000;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=9C8D1D
    // Broiler-Falsified-If: the value is not winuser.h's WS_VISIBLE (0x10000000), so the render host child is created hidden and never paints
    // Broiler-Human:        PENDING
    public const uint WsVisible = 0x10000000;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=33D697
    // Broiler-Falsified-If: the value is not winuser.h's WS_CLIPCHILDREN (0x02000000), so painting the top-level window draws over its render host child and every frame flickers
    // Broiler-Human:        PENDING
    public const uint WsClipChildren = 0x02000000;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=F377A5
    // Broiler-Falsified-If: the value is not winuser.h's WS_CLIPSIBLINGS (0x04000000), so overlapping child windows paint over each other
    // Broiler-Human:        PENDING
    public const uint WsClipSiblings = 0x04000000;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=B4E022
    // Broiler-Falsified-If: the value is not winuser.h's WS_THICKFRAME (0x00040000), so masking it out of a non-resizable window's style leaves the sizing border in place or clears another style bit
    // Broiler-Human:        PENDING
    public const uint WsThickFrame = 0x00040000;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=EDDF9C
    // Broiler-Falsified-If: the value is not winuser.h's WS_MAXIMIZEBOX (0x00010000), so masking it out of a non-resizable window's style leaves the maximise button active or clears another style bit
    // Broiler-Human:        PENDING
    public const uint WsMaximizeBox = 0x00010000;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=794847
    // Broiler-Falsified-If: the value is not winuser.h's SW_SHOW (5), so the first ShowWindow after CreateWindowEx leaves the window hidden or shows it minimised or maximised
    // Broiler-Human:        PENDING
    public const int SwShow = 5;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=EC13C7
    // Broiler-Falsified-If: the value is not winuser.h's SW_MAXIMIZE (3), so requesting the maximised state sends another show command and the window is not maximised
    // Broiler-Human:        PENDING
    public const int SwMaximize = 3;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=EE6D80
    // Broiler-Falsified-If: the value is not winuser.h's SW_MINIMIZE (6), so requesting the minimised state sends another show command and the window stays on screen
    // Broiler-Human:        PENDING
    public const int SwMinimize = 6;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=D567AE
    // Broiler-Falsified-If: the value is not winuser.h's SW_RESTORE (9), so leaving the minimised or maximised state does not restore the window's previous size and position
    // Broiler-Human:        PENDING
    public const int SwRestore = 9;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=CDC25D
    // Broiler-Falsified-If: the value is not winuser.h's SIZE_MINIMIZED (1), so the WM_SIZE sent on minimise is not recognised and the surface is resized to a zero client area
    // Broiler-Human:        PENDING
    public const int SizeMinimized = 1;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=73C692
    // Broiler-Falsified-If: the value is not winuser.h's SM_CXSCREEN (0), so centring a window with no explicit position uses another metric as the screen width
    // Broiler-Human:        PENDING
    public const int SmCxScreen = 0;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=43C5AF
    // Broiler-Falsified-If: the value is not winuser.h's SM_CYSCREEN (1), so centring a window with no explicit position uses another metric as the screen height
    // Broiler-Human:        PENDING
    public const int SmCyScreen = 1;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=E5BE6C
    // Broiler-Falsified-If: the value is not winuser.h's SM_CXSIZEFRAME (32), so the owner-drawn resize border width adds another metric to SM_CXPADDEDBORDER and no longer matches the native frame
    // Broiler-Human:        PENDING
    public const int SmCxSizeFrame = 32;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=FE7C5B
    // Broiler-Falsified-If: the value is not winuser.h's SM_CXPADDEDBORDER (92), so the owner-drawn resize border omits the padded border, or adds another metric, and no longer matches the native frame
    // Broiler-Human:        PENDING
    public const int SmCxPaddedBorder = 92;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=D79778
    // Broiler-Falsified-If: the value is not winuser.h's GWLP_USERDATA (-21), so the GCHandle stored on WM_NCCREATE overwrites another window slot such as GWLP_WNDPROC (-4) or GWLP_HINSTANCE (-6) and the next message runs through the overwritten slot
    // Broiler-Human:        PENDING
    public const int GwlUserData = -21;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=9B9195
    // Broiler-Falsified-If: the value is not winuser.h's GCLP_HICON (-14), so reading the class icon returns another class slot such as GCLP_HCURSOR (-12) and compares unequal to the registered icon
    // Broiler-Human:        PENDING
    public const int GclpHIcon = -14;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=6A46B8
    // Broiler-Falsified-If: the value is not winuser.h's GCLP_HICONSM (-34), so reading the small class icon returns another class slot and reports a missing or wrong small icon
    // Broiler-Human:        PENDING
    public const int GclpHIconSm = -34;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=2AEA97
    // Broiler-Falsified-If: the value is not winuser.h's COLOR_WINDOW (5), so the class background brush is another system colour and the window shows that colour before the first frame
    // Broiler-Human:        PENDING
    public const int ColorWindow = 5;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=1F51B8
    // Broiler-Falsified-If: the value is not wingdi.h's LOGPIXELSX (88), so the GetDeviceCaps DPI fallback returns another device capability and the window is scaled by it
    // Broiler-Human:        PENDING
    public const int LogPixelsX = 88;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=FD202E
    // Broiler-Falsified-If: the value is not winuser.h's HTTRANSPARENT (-1), so the render host's border hit test does not pass through to the top-level window and the owner-drawn resize border cannot be dragged
    // Broiler-Human:        PENDING
    public const int HtTransparent = -1;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=DDA4ED
    // Broiler-Falsified-If: the value is not winuser.h's HTCLIENT (1), so the render host compares hit-test results against another area code and either swallows client-area clicks or passes them through to the frame
    // Broiler-Human:        PENDING
    public const int HtClient = 1;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=584B5B
    // Broiler-Falsified-If: the value is not winuser.h's HTCAPTION (2), so a move drag sends WM_NCLBUTTONDOWN with another hit code and starts a resize, or nothing, instead of moving the window
    // Broiler-Human:        PENDING
    public const int HtCaption = 2;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=D5A456
    // Broiler-Falsified-If: the value is not winuser.h's HTLEFT (10), so dragging the left owner-drawn border resizes another edge or does nothing
    // Broiler-Human:        PENDING
    public const int HtLeft = 10;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=EC0570
    // Broiler-Falsified-If: the value is not winuser.h's HTRIGHT (11), so dragging the right owner-drawn border resizes another edge or does nothing
    // Broiler-Human:        PENDING
    public const int HtRight = 11;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=C896B1
    // Broiler-Falsified-If: the value is not winuser.h's HTTOP (12), so dragging the top owner-drawn border resizes another edge or does nothing
    // Broiler-Human:        PENDING
    public const int HtTop = 12;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=E5E637
    // Broiler-Falsified-If: the value is not winuser.h's HTTOPLEFT (13), so dragging the top-left owner-drawn corner resizes another edge or does nothing
    // Broiler-Human:        PENDING
    public const int HtTopLeft = 13;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=C2FCF3
    // Broiler-Falsified-If: the value is not winuser.h's HTTOPRIGHT (14), so dragging the top-right owner-drawn corner resizes another edge or does nothing
    // Broiler-Human:        PENDING
    public const int HtTopRight = 14;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=07F885
    // Broiler-Falsified-If: the value is not winuser.h's HTBOTTOM (15), so dragging the bottom owner-drawn border resizes another edge or does nothing
    // Broiler-Human:        PENDING
    public const int HtBottom = 15;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=38DF7E
    // Broiler-Falsified-If: the value is not winuser.h's HTBOTTOMLEFT (16), so dragging the bottom-left owner-drawn corner resizes another edge or does nothing
    // Broiler-Human:        PENDING
    public const int HtBottomLeft = 16;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=614BB3
    // Broiler-Falsified-If: the value is not winuser.h's HTBOTTOMRIGHT (17), so dragging the bottom-right owner-drawn corner resizes another edge or does nothing
    // Broiler-Human:        PENDING
    public const int HtBottomRight = 17;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=6C361E
    // Broiler-Falsified-If: the value is not winuser.h's ICON_SMALL (0), so WM_SETICON replaces the large icon twice and the caption keeps the class's small icon
    // Broiler-Human:        PENDING
    public const int IconSmall = 0;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=4D6C98
    // Broiler-Falsified-If: the value is not winuser.h's ICON_BIG (1), so WM_SETICON replaces the small icon twice and the taskbar and Alt+Tab keep the class's large icon
    // Broiler-Human:        PENDING
    public const int IconBig = 1;
    /// <summary>
    /// IDI_APPLICATION: the stock application icon when loaded without a module, and the resource
    /// id the C# compiler gives an executable's <c>ApplicationIcon</c> when loaded from one.
    /// </summary>
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=96BA8F
    // Broiler-Falsified-If: the value is not winuser.h's IDI_APPLICATION (32512), so LoadIcon on the executable module finds no icon resource and the class registers with the generic window glyph
    // Broiler-Human:        PENDING
    public const int IdiApplication = 32512;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=D1227E
    // Broiler-Falsified-If: the value is not wingdi.h's DIB_RGB_COLORS (0), so CreateDIBSection reads the colour table as DIB_PAL_COLORS palette indices and fails or builds the icon bitmap against the device palette
    // Broiler-Human:        PENDING
    public const uint DibRgbColors = 0;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=C9D0FD
    // Broiler-Falsified-If: the value is not winuser.h's MONITOR_DEFAULTTONEAREST (2), so a window off every monitor gets a zero HMONITOR from MonitorFromWindow and the maximised work-area clamp is skipped
    // Broiler-Human:        PENDING
    public const uint MonitorDefaultToNearest = 2;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=905B6E
    // Broiler-Falsified-If: the value is not winuser.h's WM_NCCREATE (0x0081), so the window procedure reads another message's lParam as a CREATESTRUCT pointer and GCHandle.FromIntPtr resolves a garbage handle
    // Broiler-Human:        PENDING
    public const uint WmNccreate = 0x0081;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=9A3CC4
    // Broiler-Falsified-If: the value is not winuser.h's WM_NCDESTROY (0x0082), so the GCHandle in GWLP_USERDATA is freed on another message or never, so later messages resolve a freed handle or the window object leaks
    // Broiler-Human:        PENDING
    public const uint WmNcdestroy = 0x0082;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=1FEEFE
    // Broiler-Falsified-If: the value is not winuser.h's WM_CREATE (0x0001), so the render host and graphics resources are created on another message or never
    // Broiler-Human:        PENDING
    public const uint WmCreate = 0x0001;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=BC5922
    // Broiler-Falsified-If: the value is not winuser.h's WM_DESTROY (0x0002), so graphics resources are not released and PostQuitMessage is not posted when the window that owns the loop is destroyed
    // Broiler-Human:        PENDING
    public const uint WmDestroy = 0x0002;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=708A97
    // Broiler-Falsified-If: the value is not winuser.h's WM_SIZE (0x0005), so the surface is not resized and the frame is stretched after the window is resized
    // Broiler-Human:        PENDING
    public const uint WmSize = 0x0005;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=7458AF
    // Broiler-Falsified-If: the value is not winuser.h's WM_COMMAND (0x0111), so menu and accelerator commands arriving while the window closes are not suppressed
    // Broiler-Human:        PENDING
    public const uint WmCommand = 0x0111;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=DE53C7
    // Broiler-Falsified-If: the value is not winuser.h's WM_PAINT (0x000F), so the window procedure never validates the client area and user32 resends WM_PAINT in a busy loop
    // Broiler-Human:        PENDING
    public const uint WmPaint = 0x000F;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=C2853A
    // Broiler-Falsified-If: the value is not winuser.h's WM_ERASEBKGND (0x0014), so the render host's background erase is not suppressed and each frame flickers through the class brush
    // Broiler-Human:        PENDING
    public const uint WmEraseBkgnd = 0x0014;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=E8068D
    // Broiler-Falsified-If: the value is not winuser.h's WM_DPICHANGED (0x02E0), so moving the window to a monitor with another scale does not resize the surface and the frame renders at the old DPI
    // Broiler-Human:        PENDING
    public const uint WmDpiChanged = 0x02E0;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=89F5F6
    // Broiler-Falsified-If: the value is not winuser.h's WM_TIMER (0x0113), so the animation timer's ticks reach DefWindowProc and animations never advance
    // Broiler-Human:        PENDING
    public const uint WmTimer = 0x0113;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=AB91DA
    // Broiler-Falsified-If: the value is not winuser.h's WM_MOUSEMOVE (0x0200), so pointer moves over the render host are not reported and hover and drag never update
    // Broiler-Human:        PENDING
    public const uint WmMouseMove = 0x0200;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=A70806
    // Broiler-Falsified-If: the value is not winuser.h's WM_LBUTTONDOWN (0x0201), so left-button presses over the render host are not reported as pointer-down
    // Broiler-Human:        PENDING
    public const uint WmLButtonDown = 0x0201;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=87A58A
    // Broiler-Falsified-If: the value is not winuser.h's WM_LBUTTONUP (0x0202), so left-button releases are not reported and a drag started with the left button never ends
    // Broiler-Human:        PENDING
    public const uint WmLButtonUp = 0x0202;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=35F273
    // Broiler-Falsified-If: the value is not winuser.h's WM_RBUTTONDOWN (0x0204), so right-button presses over the render host are not reported as pointer-down
    // Broiler-Human:        PENDING
    public const uint WmRButtonDown = 0x0204;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=389F9F
    // Broiler-Falsified-If: the value is not winuser.h's WM_RBUTTONUP (0x0205), so right-button releases are not reported and a context-menu gesture never completes
    // Broiler-Human:        PENDING
    public const uint WmRButtonUp = 0x0205;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=8D5BF1
    // Broiler-Falsified-If: the value is not winuser.h's WM_MBUTTONDOWN (0x0207), so middle-button presses over the render host are not reported as pointer-down
    // Broiler-Human:        PENDING
    public const uint WmMButtonDown = 0x0207;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=947FD5
    // Broiler-Falsified-If: the value is not winuser.h's WM_MBUTTONUP (0x0208), so middle-button releases are not reported and a middle-button gesture never ends
    // Broiler-Human:        PENDING
    public const uint WmMButtonUp = 0x0208;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=2E8C7B
    // Broiler-Falsified-If: the value is not winuser.h's WM_MOUSEWHEEL (0x020A), so vertical wheel input is not reported and content does not scroll
    // Broiler-Human:        PENDING
    public const uint WmMouseWheel = 0x020A;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=4BB58B
    // Broiler-Falsified-If: the value is not winuser.h's WM_MOUSEHWHEEL (0x020E), so horizontal wheel input is not reported and content does not scroll sideways
    // Broiler-Human:        PENDING
    public const uint WmMouseHWheel = 0x020E;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=A5ED52
    // Broiler-Falsified-If: the value is not winuser.h's WM_MOUSELEAVE (0x02A3), so the pointer leaving the render host is not reported and hover state sticks
    // Broiler-Human:        PENDING
    public const uint WmMouseLeave = 0x02A3;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=59D4F4
    // Broiler-Falsified-If: the value is not winuser.h's WM_KEYDOWN (0x0100), so key presses are not reported to the window's key handlers
    // Broiler-Human:        PENDING
    public const uint WmKeyDown = 0x0100;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=5469E2
    // Broiler-Falsified-If: the value is not winuser.h's WM_KEYUP (0x0101), so key releases are not reported and a released key still reads as held in the handlers
    // Broiler-Human:        PENDING
    public const uint WmKeyUp = 0x0101;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=DD18B3
    // Broiler-Falsified-If: the value is not winuser.h's WM_CHAR (0x0102), so translated character input is not reported and text cannot be typed
    // Broiler-Human:        PENDING
    public const uint WmChar = 0x0102;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=951DB1
    // Broiler-Falsified-If: the value is not winuser.h's WM_SYSKEYDOWN (0x0104), so Alt-modified key presses are not reported to the window's key handlers
    // Broiler-Human:        PENDING
    public const uint WmSysKeyDown = 0x0104;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=C29429
    // Broiler-Falsified-If: the value is not winuser.h's WM_SETFOCUS (0x0007), so a handler for keyboard focus arriving runs on another message or never
    // Broiler-Human:        PENDING
    public const uint WmSetFocus = 0x0007;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=64C94B
    // Broiler-Falsified-If: the value is not winuser.h's WM_CLOSE (0x0010), so the close button does not raise the close request and a secondary window is destroyed under its owner
    // Broiler-Human:        PENDING
    public const uint WmClose = 0x0010;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=D310EC
    // Broiler-Falsified-If: the value is not winuser.h's WM_SETICON (0x0080), so the caption and taskbar keep their old icons and the replaced icons are destroyed while still set on the window
    // Broiler-Human:        PENDING
    public const uint WmSetIcon = 0x0080;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=B5DCC0
    // Broiler-Falsified-If: the value is not winuser.h's WM_GETICON (0x007F), so reading a window's icon returns another message's result instead of the HICON set through WM_SETICON
    // Broiler-Human:        PENDING
    public const uint WmGetIcon = 0x007F;
    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=91C039
    // Broiler-Falsified-If: the value is not winuser.h's WM_NCCALCSIZE (0x0083), so owner-drawn chrome does not report the whole window as client area and Windows draws its own caption and border over the UI's title bar
    // Broiler-Human:        PENDING
    public const uint WmNccalcsize = 0x0083;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=4D8EEB
    // Broiler-Falsified-If: the value is not winuser.h's WM_NCHITTEST (0x0084), so the owner-drawn frame is never hit-tested and its resize border cannot be dragged
    // Broiler-Human:        PENDING
    public const uint WmNchittest = 0x0084;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=55BAC8
    // Broiler-Falsified-If: the value is not winuser.h's WM_NCACTIVATE (0x0086), so activating or deactivating the window lets DefWindowProc repaint the native caption over the owner-drawn title bar
    // Broiler-Human:        PENDING
    public const uint WmNcactivate = 0x0086;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=2E49A0
    // Broiler-Falsified-If: the value is not winuser.h's WM_NCLBUTTONDOWN (0x00A1), so a move or resize drag sends another message and DefWindowProc never enters its move or size loop
    // Broiler-Human:        PENDING
    public const uint WmNcLButtonDown = 0x00A1;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=BF9AF2
    // Broiler-Falsified-If: the value is not winuser.h's MK_LBUTTON (0x0001), so the left-button state in a mouse message's wParam is decoded as another button and drags report the wrong buttons
    // Broiler-Human:        PENDING
    public const int MkLButton = 0x0001;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=EC2C68
    // Broiler-Falsified-If: the value is not winuser.h's MK_CONTROL (0x0008), so Ctrl held during a wheel or click is decoded as another key and Ctrl+wheel zoom does not trigger
    // Broiler-Human:        PENDING
    public const int MkControl = 0x0008;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=DF5B3C
    // Broiler-Falsified-If: the value is not winuser.h's MK_SHIFT (0x0004), so Shift held during a click is decoded as another key and Shift+click does not extend a selection
    // Broiler-Human:        PENDING
    public const int MkShift = 0x0004;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=E958D6
    // Broiler-Falsified-If: the value is not winuser.h's MK_RBUTTON (0x0002), so the right-button state in a mouse message's wParam is decoded as another button
    // Broiler-Human:        PENDING
    public const int MkRButton = 0x0002;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=8DD374
    // Broiler-Falsified-If: the value is not winuser.h's MK_MBUTTON (0x0010), so the middle-button state in a mouse message's wParam is decoded as another button
    // Broiler-Human:        PENDING
    public const int MkMButton = 0x0010;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=0A938A
    // Broiler-Falsified-If: the value is not winuser.h's VK_CONTROL (0x11), so GetKeyState reports another key's state as the Ctrl modifier
    // Broiler-Human:        PENDING
    public const int VkControl = 0x11;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=08A3D7
    // Broiler-Falsified-If: the value is not winuser.h's VK_SHIFT (0x10), so GetKeyState reports another key's state as the Shift modifier
    // Broiler-Human:        PENDING
    public const int VkShift = 0x10;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=EE1A5E
    // Broiler-Falsified-If: the value is not winuser.h's VK_MENU (0x12), so GetKeyState reports another key's state as the Alt modifier
    // Broiler-Human:        PENDING
    public const int VkMenu = 0x12;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=F3C491
    // Broiler-Falsified-If: the value is not winuser.h's WHEEL_DELTA (120), so one notch of the wheel scrolls by a fraction or a multiple of a line step
    // Broiler-Human:        PENDING
    public const int WheelDelta = 120;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=E93D95
    // Broiler-Falsified-If: the value is not winuser.h's TME_LEAVE (0x00000002), so TrackMouseEvent arms hover or another notification and WM_MOUSELEAVE is never posted
    // Broiler-Human:        PENDING
    public const uint TmeLeave = 0x00000002;
}
