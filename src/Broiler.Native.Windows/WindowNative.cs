// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   86
// Annotated:        86/86
// Exempt:           183
// Human-reviewed:   0/86
// IP risk:          Low
// Security risk:    Critical
// Criteria:         70/70
// Resource impact:  5/10 max
// Unverified:       86
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
    // Broiler-Falsified-If: differs from typedef LRESULT (CALLBACK* WNDPROC)(HWND, UINT, WPARAM, LPARAM) in winuser.h, CALLBACK being stdcall on 32-bit x86
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate IntPtr WndProc(IntPtr hwnd, uint message, IntPtr wParam, IntPtr lParam);

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=637957
    // Broiler-Falsified-If: Marshal.SizeOf is not 80 on 64-bit (48 on 32-bit) or, on 64-bit, LpfnWndProc is not at offset 8 and LpszClassName at 64, the layout of WNDCLASSEXW in winuser.h
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
    // Broiler-Falsified-If: Marshal.SizeOf is not 16 or Left, Top, Right and Bottom are not at offsets 0, 4, 8 and 12, the layout of RECT (LONG left, top, right, bottom) in windef.h
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
    // Broiler-Falsified-If: Marshal.SizeOf is not 8 or Y is not at offset 4, the layout of POINT (LONG x, LONG y) in windef.h
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;
    }

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=E547C3
    // Broiler-Falsified-If: Marshal.SizeOf is not 24 on 64-bit (16 on 32-bit) or HwndTrack is not at offset 8, the layout of TRACKMOUSEEVENT (DWORD cbSize, DWORD dwFlags, HWND hwndTrack, DWORD dwHoverTime) in winuser.h
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
    // Broiler-Falsified-If: Marshal.SizeOf is not 48 on 64-bit (28 on 32-bit) or, on 64-bit, LParam is not at offset 24 and Pt at 36, the layout of MSG (HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam, DWORD time, POINT pt) in winuser.h
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
    // Broiler-Falsified-If: Marshal.SizeOf is not 80 on 64-bit (48 on 32-bit), LpCreateParams is not at offset 0 or, on 64-bit, LpszName is not at 56, the layout of CREATESTRUCTW in winuser.h
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
    // Broiler-Falsified-If: differs from HMODULE GetModuleHandleW(LPCWSTR lpModuleName) in libloaderapi.h, where moduleName must arrive as a UTF-16 pointer and a null moduleName as a null pointer rather than an empty string
    // Broiler-Human:        PENDING
    [LibraryImport("kernel32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16, EntryPoint = "GetModuleHandleW")]
    public static partial IntPtr GetModuleHandle(string? moduleName);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=2D2FB1
    // Broiler-Falsified-If: differs from ATOM RegisterClassExW(CONST WNDCLASSEXW *) in winuser.h, CharSet.Unicode binding the W export and the struct passed by pointer with UTF-16 lpszMenuName and lpszClassName
    // Broiler-Human:        PENDING
    [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern ushort RegisterClassEx(ref WNDCLASSEX windowClass);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=B8CB64
    // Broiler-Falsified-If: differs from HWND CreateWindowExW(DWORD dwExStyle, LPCWSTR lpClassName, LPCWSTR lpWindowName, DWORD dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, LPVOID lpParam) in winuser.h, both strings passed as UTF-16
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "CreateWindowExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    public static partial IntPtr CreateWindowEx(uint exStyle, string className, string windowName, uint style,
        int x, int y, int width, int height, IntPtr hwndParent, IntPtr menu, IntPtr instance, IntPtr param);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C0C181
    // Broiler-Falsified-If: differs from BOOL AdjustWindowRectEx(LPRECT lpRect, DWORD dwStyle, BOOL bMenu, DWORD dwExStyle) in winuser.h, with bMenu and the result marshalled as a 4-byte BOOL
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool AdjustWindowRectEx(ref RECT rect, uint style, [MarshalAs(UnmanagedType.Bool)] bool menu, uint exStyle);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=6C102F
    // Broiler-Falsified-If: differs from BOOL AdjustWindowRectExForDpi(LPRECT lpRect, DWORD dwStyle, BOOL bMenu, DWORD dwExStyle, UINT dpi) in winuser.h, with bMenu and the result marshalled as a 4-byte BOOL
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool AdjustWindowRectExForDpi(ref RECT rect, uint style, [MarshalAs(UnmanagedType.Bool)] bool menu, uint exStyle, uint dpi);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=BF4309
    // Broiler-Falsified-If: differs from int GetSystemMetrics(int nIndex) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial int GetSystemMetrics(int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=BCA376
    // Broiler-Falsified-If: differs from BOOL ShowWindow(HWND hWnd, int nCmdShow) in winuser.h, with the result marshalled as a 4-byte BOOL
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ShowWindow(IntPtr hwnd, int commandShow);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=59BCAA
    // Broiler-Falsified-If: differs from BOOL UpdateWindow(HWND hWnd) in winuser.h, with the result marshalled as a 4-byte BOOL
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool UpdateWindow(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=91B735
    // Broiler-Falsified-If: differs from BOOL GetMessageW(LPMSG lpMsg, HWND hWnd, UINT wMsgFilterMin, UINT wMsgFilterMax) in winuser.h, whose BOOL result can be -1 and so must stay an int rather than a marshalled bool
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true, EntryPoint = "GetMessageW")]
    public static partial int GetMessage(out MSG message, IntPtr hwnd, uint filterMin, uint filterMax);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=9CEEB7
    // Broiler-Falsified-If: differs from BOOL TranslateMessage(CONST MSG *lpMsg) in winuser.h, the MSG passed by pointer and the result marshalled as a 4-byte BOOL
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool TranslateMessage(ref MSG message);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=4EEAC8
    // Broiler-Falsified-If: differs from LRESULT DispatchMessageW(CONST MSG *lpMsg) in winuser.h, the MSG passed by pointer
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "DispatchMessageW")]
    public static partial IntPtr DispatchMessage(ref MSG message);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=6D1BFB
    // Broiler-Falsified-If: differs from LRESULT DefWindowProcW(HWND hWnd, UINT Msg, WPARAM wParam, LPARAM lParam) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "DefWindowProcW")]
    public static partial IntPtr DefWindowProc(IntPtr hwnd, uint message, IntPtr wParam, IntPtr lParam);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=28D17C
    // Broiler-Falsified-If: differs from VOID PostQuitMessage(int nExitCode) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial void PostQuitMessage(int exitCode);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=785298
    // Broiler-Falsified-If: differs from BOOL PostMessageW(HWND hWnd, UINT Msg, WPARAM wParam, LPARAM lParam) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true, EntryPoint = "PostMessageW")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool PostMessage(IntPtr hwnd, uint message, IntPtr wParam, IntPtr lParam);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=11E879
    // Broiler-Falsified-If: differs from BOOL InvalidateRect(HWND hWnd, CONST RECT *lpRect, BOOL bErase) in winuser.h, with bErase and the result marshalled as a 4-byte BOOL
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool InvalidateRect(IntPtr hwnd, IntPtr rect, [MarshalAs(UnmanagedType.Bool)] bool erase);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=3194D3
    // Broiler-Falsified-If: differs from BOOL ValidateRect(HWND hWnd, CONST RECT *lpRect) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ValidateRect(IntPtr hwnd, IntPtr rect);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=19633F
    // Broiler-Falsified-If: differs from BOOL MoveWindow(HWND hWnd, int X, int Y, int nWidth, int nHeight, BOOL bRepaint) in winuser.h, with bRepaint and the result marshalled as a 4-byte BOOL
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool MoveWindow(IntPtr hwnd, int x, int y, int width, int height, [MarshalAs(UnmanagedType.Bool)] bool repaint);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=005B01
    // Broiler-Falsified-If: differs from BOOL DestroyWindow(HWND hWnd) in winuser.h, imported with SetLastError so the error code read after a failure is this call's own
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DestroyWindow(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E7F331
    // Broiler-Falsified-If: differs from HWND GetParent(HWND hWnd) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial IntPtr GetParent(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=3A2024
    // Broiler-Falsified-If: differs from UINT_PTR SetTimer(HWND hWnd, UINT_PTR nIDEvent, UINT uElapse, TIMERPROC lpTimerFunc) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial UIntPtr SetTimer(IntPtr hwnd, nuint eventId, uint elapseMs, IntPtr timerFunc);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=24FCA7
    // Broiler-Falsified-If: differs from BOOL KillTimer(HWND hWnd, UINT_PTR uIDEvent) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool KillTimer(IntPtr hwnd, nuint eventId);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=AD9CC7
    // Broiler-Falsified-If: differs from HWND SetFocus(HWND hWnd) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial IntPtr SetFocus(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=54C5B0
    // Broiler-Falsified-If: differs from SHORT GetKeyState(int nVirtKey) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial short GetKeyState(int virtualKey);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D0E8CE
    // Broiler-Falsified-If: differs from BOOL ScreenToClient(HWND hWnd, LPPOINT lpPoint) in winuser.h, the 8-byte POINT passed by pointer and written back
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ScreenToClient(IntPtr hwnd, ref POINT point);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0C9D2E
    // Broiler-Falsified-If: differs from BOOL TrackMouseEvent(LPTRACKMOUSEEVENT lpEventTrack) in winuser.h, the TRACKMOUSEEVENT passed by pointer
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool TrackMouseEvent(ref TRACKMOUSEEVENT trackMouseEvent);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=212BE0
    // Broiler-Falsified-If: differs from BOOL GetClientRect(HWND hWnd, LPRECT lpRect) in winuser.h, the 16-byte RECT passed as an out pointer
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool GetClientRect(IntPtr hwnd, out RECT rect);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=81749E
    // Broiler-Falsified-If: differs from UINT GetDpiForWindow(HWND hwnd) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial uint GetDpiForWindow(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=58339A
    // Broiler-Falsified-If: differs from HDC GetDC(HWND hWnd) in winuser.h, whose returned DC the caller holds until ReleaseDC
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial IntPtr GetDC(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=089DAA
    // Broiler-Falsified-If: differs from int ReleaseDC(HWND hWnd, HDC hDC) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial int ReleaseDC(IntPtr hwnd, IntPtr hdc);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A5C5DC
    // Broiler-Falsified-If: differs from int GetDeviceCaps(HDC hdc, int index) in wingdi.h
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll")]
    public static partial int GetDeviceCaps(IntPtr hdc, int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=178AF0
    // Broiler-Falsified-If: differs from HCURSOR LoadCursorW(HINSTANCE hInstance, LPCWSTR lpCursorName) in winuser.h, with lpCursorName carried as a MAKEINTRESOURCE integer in a pointer-sized IntPtr rather than a marshalled string
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true, EntryPoint = "LoadCursorW")]
    public static partial IntPtr LoadCursor(IntPtr instance, IntPtr cursorName);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=C66880
    // Broiler-Falsified-If: differs from HICON LoadIconW(HINSTANCE hInstance, LPCWSTR lpIconName) in winuser.h, with lpIconName carried as a MAKEINTRESOURCE integer in a pointer-sized IntPtr rather than a marshalled string
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true, EntryPoint = "LoadIconW")]
    public static partial IntPtr LoadIcon(IntPtr instance, IntPtr iconName);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=CDE6AD
    // Broiler-Falsified-If: differs from HBRUSH GetSysColorBrush(int nIndex) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial IntPtr GetSysColorBrush(int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0ACA59
    // Broiler-Falsified-If: differs from LONG_PTR SetWindowLongPtrW(HWND hWnd, int nIndex, LONG_PTR dwNewLong) in winuser.h, which declares that export only under _WIN64
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "SetWindowLongPtrW")]
    public static partial IntPtr SetWindowLongPtr64(IntPtr hwnd, int index, IntPtr value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B10A49
    // Broiler-Falsified-If: differs from LONG SetWindowLongW(HWND hWnd, int nIndex, LONG dwNewLong) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "SetWindowLongW")]
    public static partial int SetWindowLong32(IntPtr hwnd, int index, int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=5B314E
    // Broiler-Falsified-If: differs from LONG_PTR GetWindowLongPtrW(HWND hWnd, int nIndex) in winuser.h, which declares that export only under _WIN64
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "GetWindowLongPtrW")]
    public static partial IntPtr GetWindowLongPtr64(IntPtr hwnd, int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=EDCE2B
    // Broiler-Falsified-If: differs from LONG GetWindowLongW(HWND hWnd, int nIndex) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "GetWindowLongW")]
    public static partial int GetWindowLong32(IntPtr hwnd, int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=3B4FE6
    // Broiler-Falsified-If: differs from ULONG_PTR GetClassLongPtrW(HWND hWnd, int nIndex) in winuser.h, which declares that export only under _WIN64
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "GetClassLongPtrW")]
    public static partial IntPtr GetClassLongPtr64(IntPtr hwnd, int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=3B5E17
    // Broiler-Falsified-If: differs from DWORD GetClassLongW(HWND hWnd, int nIndex) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "GetClassLongW")]
    public static partial int GetClassLong32(IntPtr hwnd, int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=D43A2E
    // Broiler-Falsified-If: differs from BOOL SetWindowTextW(HWND hWnd, LPCWSTR lpString) in winuser.h, the title passed as a null-terminated UTF-16 string
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "SetWindowTextW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SetWindowText(IntPtr hwnd, string title);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=A75408
    // Broiler-Falsified-If: differs from LRESULT SendMessageW(HWND hWnd, UINT Msg, WPARAM wParam, LPARAM lParam) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "SendMessageW")]
    public static partial IntPtr SendMessage(IntPtr hwnd, uint message, IntPtr wParam, IntPtr lParam);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=4BCCEF
    // Broiler-Falsified-If: differs from BOOL ReleaseCapture(VOID) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ReleaseCapture();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A814E8
    // Broiler-Falsified-If: differs from BOOL IsIconic(HWND hWnd) in winuser.h, with the result marshalled as a 4-byte BOOL
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsIconic(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=6E1CF7
    // Broiler-Falsified-If: differs from BOOL IsZoomed(HWND hWnd) in winuser.h, with the result marshalled as a 4-byte BOOL
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool IsZoomed(IntPtr hwnd);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7E4EBC
    // Broiler-Falsified-If: differs from BOOL GetWindowRect(HWND hWnd, LPRECT lpRect) in winuser.h, the 16-byte RECT passed as an out pointer
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool GetWindowRect(IntPtr hwnd, out RECT rect);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E8219B
    // Broiler-Falsified-If: differs from HMONITOR MonitorFromWindow(HWND hwnd, DWORD dwFlags) in winuser.h
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial IntPtr MonitorFromWindow(IntPtr hwnd, uint flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=7EA744
    // Broiler-Falsified-If: differs from BOOL GetMonitorInfoW(HMONITOR hMonitor, LPMONITORINFO lpmi) in winuser.h, the 40-byte MONITORINFO passed by pointer, which a cbSize of 104 (MONITORINFOEXW) would overrun
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "GetMonitorInfoW")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool GetMonitorInfo(IntPtr monitor, ref MONITORINFO info);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=9BE911
    // Broiler-Falsified-If: differs from BOOL DestroyIcon(HICON hIcon) in winuser.h, with the result marshalled as a 4-byte BOOL
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DestroyIcon(IntPtr icon);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=86BA93
    // Broiler-Falsified-If: differs from HICON CreateIconIndirect(PICONINFO piconinfo) in winuser.h, the ICONINFO passed by pointer and the returned HICON held by the caller until DestroyIcon
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial IntPtr CreateIconIndirect(ref ICONINFO iconInfo);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=9DDFFE
    // Broiler-Falsified-If: differs from HBITMAP CreateDIBSection(HDC hdc, CONST BITMAPINFO *pbmi, UINT usage, VOID **ppvBits, HANDLE hSection, DWORD offset) in wingdi.h, where passing only the 40-byte BITMAPINFOHEADER holds only while biBitCount is above 8 and biCompression is BI_RGB
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", SetLastError = true)]
    public static partial IntPtr CreateDIBSection(IntPtr hdc, ref BITMAPINFOHEADER header, uint usage, 
        out IntPtr bits, IntPtr section, uint offset);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=5; Fingerprint=C60669
    // Broiler-Falsified-If: differs from HBITMAP CreateBitmap(int nWidth, int nHeight, UINT nPlanes, UINT nBitCount, CONST VOID *lpBits) in wingdi.h
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll", SetLastError = true)]
    public static partial IntPtr CreateBitmap(int width, int height, uint planes, uint bitsPerPixel, IntPtr bits);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C1D6A1
    // Broiler-Falsified-If: differs from BOOL DeleteObject(HGDIOBJ ho) in wingdi.h
    // Broiler-Human:        PENDING
    [LibraryImport("gdi32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool DeleteObject(IntPtr gdiObject);

    // Broiler-AI:           Origin=AI; IP=None; Security=High; Resources=0; Fingerprint=85EE60
    // Broiler-Falsified-If: Marshal.SizeOf is not 40 or RcWork is not at offset 20 and DwFlags at 36, the layout of MONITORINFO (DWORD cbSize, RECT rcMonitor, RECT rcWork, DWORD dwFlags) in winuser.h
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
    // Broiler-Falsified-If: Marshal.SizeOf is not 32 on 64-bit (20 on 32-bit) or HbmMask is not at offset 16 (12 on 32-bit), the layout of ICONINFO (BOOL fIcon, DWORD xHotspot, DWORD yHotspot, HBITMAP hbmMask, HBITMAP hbmColor) in winuser.h
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
    // Broiler-Falsified-If: Marshal.SizeOf is not 40 or BiBitCount is not at offset 14 and BiCompression at 16, the layout of BITMAPINFOHEADER in wingdi.h
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
    // Broiler-Falsified-If: differs from BOOL SetProcessDpiAwarenessContext(DPI_AWARENESS_CONTEXT value) in winuser.h, the context passed as the pointer-sized handle windef.h declares
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SetProcessDpiAwarenessContext(IntPtr dpiContext);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=3; Fingerprint=139E0E
    // Broiler-Falsified-If: differs from int GetWindowTextW(HWND hWnd, LPWSTR lpString, int nMaxCount) in winuser.h, where nMaxCount counts the UTF-16 chars lpString can hold, terminator included
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

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=5F72E7
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential)]
    public struct MINMAXINFO
    {
        public POINT ptReserved;
        public POINT ptMaxSize;
        public POINT ptMaxPosition;
        public POINT ptMinTrackSize;
        public POINT ptMaxTrackSize;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=CF5D9B
    // Broiler-Human:        PENDING
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct HIGHCONTRAST
    {
        public uint cbSize;
        public uint dwFlags;
        public IntPtr lpszDefaultScheme;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=69D7DD
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate IntPtr SubclassProc(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam, nuint uIdSubclass, nuint dwRefData);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=7504B9
    // Broiler-Human:        PENDING
    [LibraryImport("comctl32.dll", EntryPoint = "SetWindowSubclass", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial bool SetSubclass(IntPtr hWnd, IntPtr pfnSubclass, nuint uIdSubclass, nuint dwRefData);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=08FAEF
    // Broiler-Human:        PENDING
    public static bool SetWindowSubclass(IntPtr hWnd, SubclassProc callback, nuint id, nuint data) =>
        SetSubclass(hWnd, Marshal.GetFunctionPointerForDelegate(callback), id, data);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=7ABDD6
    // Broiler-Human:        PENDING
    [LibraryImport("comctl32.dll", EntryPoint = "RemoveWindowSubclass", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial bool RemoveSubclass(IntPtr hWnd, IntPtr pfnSubclass, nuint uIdSubclass);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=61E11C
    // Broiler-Human:        PENDING
    public static bool RemoveWindowSubclass(IntPtr hWnd, SubclassProc callback, nuint id) =>
        RemoveSubclass(hWnd, Marshal.GetFunctionPointerForDelegate(callback), id);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=C54513
    // Broiler-Human:        PENDING
    [LibraryImport("comctl32.dll", SetLastError = true)]
    public static partial IntPtr DefSubclassProc(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=AE7924
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    public static partial IntPtr GetFocus();

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=CCFDDC
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ClientToScreen(IntPtr hwnd, ref POINT lpPoint);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=9CC26C
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SetWindowPos(IntPtr hwnd, IntPtr insertAfter, int x, int y, int width, int height, uint flags);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=6884C1
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll")]
    public static partial uint GetSysColor(int index);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=900E14
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "SystemParametersInfoW", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SystemParametersInfo(uint uiAction, uint uiParam, ref HIGHCONTRAST pvParam, uint fWinIni);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Low; Resources=0; Fingerprint=CF689C
    // Broiler-Human:        PENDING
    [LibraryImport("user32.dll", EntryPoint = "SystemParametersInfoW", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SystemParametersInfo(uint uiAction, uint uiParam, [MarshalAs(UnmanagedType.Bool)] ref bool pvParam, uint fWinIni);

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
    public const uint WmActivate = 0x0006;
    public const uint WmKillFocus = 0x0008;
    public const uint WmDeadChar = 0x0103;
    public const uint WmSysKeyUp = 0x0105;
    public const uint WmSysChar = 0x0106;
    public const uint WmSysDeadChar = 0x0107;
    public const uint WmUniChar = 0x0109;
    public const uint WmGetMinMaxInfo = 0x0024;
    public const uint SwpNoZOrder = 0x0004;
    public const uint SwpNoActivate = 0x0010;
    public const uint SwpNoMove = 0x0002;
    public const uint SwpNoSize = 0x0001;
    public const int GwlStyle = -16;
    public const int GwlExStyle = -20;
    public const int VkLButton = 0x01;
    public const int VkRButton = 0x02;
    public const int VkMButton = 0x04;
    public const int WaInactive = 0;
    public const int WaActive = 1;
    public const int WaClickActive = 2;
    public const int ColorWindowText = 8;
    public const int ColorHighlight = 13;
    public const int ColorHighlightText = 14;
    public const int ColorBtnFace = 15;
    public const int ColorButtonFace = 15;
    public const int ColorGrayText = 17;
    public const int ColorBtnText = 18;
    public const int ColorButtonText = 18;
    public const int ColorHotLight = 26;
    public const uint SpiGetHighContrast = 0x0042;
    public const uint HcfHighContrastOn = 0x00000001;
    public const uint SpiGetClientAreaAnimation = 0x1042;
}
