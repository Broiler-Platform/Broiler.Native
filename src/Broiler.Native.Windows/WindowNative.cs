// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   72
// Annotated:        72/72
// Exempt:           143
// Human-reviewed:   0/72
// IP risk:          Low
// Security risk:    Critical
// Criteria:         70/70
// Resource impact:  5/10 max
// Unverified:       72
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
        // Broiler-Human:        PENDING
        public int Width => Right - Left;

        // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=800389
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

    public const int ErrorClassAlreadyExists = 1410;
    public const int CwUseDefault = unchecked((int)0x80000000);
    public const uint CsHRedraw = 0x0002;
    public const uint CsVRedraw = 0x0001;
    public const uint WsOverlappedWindow = 0x00CF0000;
    public const uint WsChild = 0x40000000;
    public const uint WsVisible = 0x10000000;
    public const uint WsClipChildren = 0x02000000;
    public const uint WsClipSiblings = 0x04000000;
    public const uint WsThickFrame = 0x00040000;
    public const uint WsMaximizeBox = 0x00010000;
    public const int SwShow = 5;
    public const int SwMaximize = 3;
    public const int SwMinimize = 6;
    public const int SwRestore = 9;
    public const int SizeMinimized = 1;
    public const int SmCxScreen = 0;
    public const int SmCyScreen = 1;
    public const int SmCxSizeFrame = 32;
    public const int SmCxPaddedBorder = 92;
    public const int GwlUserData = -21;
    public const int GclpHIcon = -14;
    public const int GclpHIconSm = -34;
    public const int ColorWindow = 5;
    public const int LogPixelsX = 88;
    public const int HtTransparent = -1;
    public const int HtClient = 1;
    public const int HtCaption = 2;
    public const int HtLeft = 10;
    public const int HtRight = 11;
    public const int HtTop = 12;
    public const int HtTopLeft = 13;
    public const int HtTopRight = 14;
    public const int HtBottom = 15;
    public const int HtBottomLeft = 16;
    public const int HtBottomRight = 17;
    public const int IconSmall = 0;
    public const int IconBig = 1;
    /// <summary>
    /// IDI_APPLICATION: the stock application icon when loaded without a module, and the resource
    /// id the C# compiler gives an executable's <c>ApplicationIcon</c> when loaded from one.
    /// </summary>
    public const int IdiApplication = 32512;
    public const uint DibRgbColors = 0;
    public const uint MonitorDefaultToNearest = 2;
    public const uint WmNccreate = 0x0081;
    public const uint WmNcdestroy = 0x0082;
    public const uint WmCreate = 0x0001;
    public const uint WmDestroy = 0x0002;
    public const uint WmSize = 0x0005;
    public const uint WmCommand = 0x0111;
    public const uint WmPaint = 0x000F;
    public const uint WmEraseBkgnd = 0x0014;
    public const uint WmDpiChanged = 0x02E0;
    public const uint WmTimer = 0x0113;
    public const uint WmMouseMove = 0x0200;
    public const uint WmLButtonDown = 0x0201;
    public const uint WmLButtonUp = 0x0202;
    public const uint WmRButtonDown = 0x0204;
    public const uint WmRButtonUp = 0x0205;
    public const uint WmMButtonDown = 0x0207;
    public const uint WmMButtonUp = 0x0208;
    public const uint WmMouseWheel = 0x020A;
    public const uint WmMouseHWheel = 0x020E;
    public const uint WmMouseLeave = 0x02A3;
    public const uint WmKeyDown = 0x0100;
    public const uint WmKeyUp = 0x0101;
    public const uint WmChar = 0x0102;
    public const uint WmSysKeyDown = 0x0104;
    public const uint WmSetFocus = 0x0007;
    public const uint WmClose = 0x0010;
    public const uint WmSetIcon = 0x0080;
    public const uint WmGetIcon = 0x007F;
    public const uint WmNccalcsize = 0x0083;
    public const uint WmNchittest = 0x0084;
    public const uint WmNcactivate = 0x0086;
    public const uint WmNcLButtonDown = 0x00A1;
    public const int MkLButton = 0x0001;
    public const int MkControl = 0x0008;
    public const int MkShift = 0x0004;
    public const int MkRButton = 0x0002;
    public const int MkMButton = 0x0010;
    public const int VkControl = 0x11;
    public const int VkShift = 0x10;
    public const int VkMenu = 0x12;
    public const int WheelDelta = 120;
    public const uint TmeLeave = 0x00000002;
}
