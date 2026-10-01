// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   11
// Annotated:        11/11
// Exempt:           3
// Human-reviewed:   0/11
// IP risk:          Low
// Security risk:    Critical
// Criteria:         11/11
// Resource impact:  1/10 max
// Unverified:       11
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

/// <summary>
/// Minimal owning wrapper around a COM interface pointer. Calls <c>IUnknown::Release</c> through the
/// object's vtable on disposal. Consumers retain responsibility for transferring ownership correctly.
/// </summary>
/// <remarks>
/// The IUnknown vtable layout is fixed: slot 0 = QueryInterface, slot 1 = AddRef, slot 2 = Release.
/// Calls go through <see cref="ComVtable"/>, which resolves each slot to a cached managed delegate —
/// no <c>unsafe</c> context required.
/// </remarks>
// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=2776DD
// Broiler-Falsified-If: Dispose racing on two threads lets both read the same non-zero pointer and call IUnknown::Release twice for the one owned reference
// Broiler-Human:        PENDING
public sealed class ComPtr : IDisposable
{
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=0E802B
    // Broiler-Falsified-If: on 32-bit x86 a call through this delegate leaves the stack unbalanced or returns a garbage result, showing its convention or parameters differ from IUnknown::QueryInterface(this, REFIID, void**)
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private delegate int QueryInterfaceProc(IntPtr self, ref Guid iid, out IntPtr result);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=BE262F
    // Broiler-Falsified-If: on 32-bit x86 a call through this delegate leaves the stack unbalanced, showing its convention or parameters differ from IUnknown::AddRef(this)
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private delegate uint AddRefProc(IntPtr self);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=CAFAC2
    // Broiler-Falsified-If: on 32-bit x86 a call through this delegate leaves the stack unbalanced, showing its convention or parameters differ from IUnknown::Release(this)
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private delegate uint ReleaseProc(IntPtr self);

    private IntPtr _ptr;

    public ComPtr(IntPtr ptr) => _ptr = ptr;

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=B0CA08
    // Broiler-Falsified-If: a default-constructed ComPtr holds a non-zero pointer, so Dispose calls IUnknown::Release through a vtable it never acquired
    // Broiler-Human:        PENDING
    public ComPtr() => _ptr = IntPtr.Zero;

    /// <summary>The raw interface pointer. Do not store beyond the lifetime of this wrapper.</summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=2A0CD4
    // Broiler-Falsified-If: Pointer still returns the old interface pointer after Release or Dispose cleared the wrapper, letting a caller call through a released object
    // Broiler-Human:        PENDING
    public IntPtr Pointer => _ptr;

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A657E9
    // Broiler-Falsified-If: IsNull is false for a wrapper holding IntPtr.Zero, so a caller passes a null object to ComVtable.Method and reads address zero
    // Broiler-Human:        PENDING
    public bool IsNull => _ptr == IntPtr.Zero;

    /// <summary>
    /// Takes ownership of a freshly created interface pointer. The caller passes the address of a
    /// local <see cref="IntPtr"/> to the native creation function, then attaches the result here.
    /// Releases any previously held pointer first.
    /// </summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=3AC576
    // Broiler-Falsified-If: attaching a fresh +1 reference equal to the pointer already held returns early, so one of the two references is never released
    // Broiler-Human:        PENDING
    public void Attach(IntPtr ptr)
    {
        if (_ptr == ptr)
            return;

        if (_ptr != IntPtr.Zero)
            Release();
        
        _ptr = ptr;
    }

    /// <summary>Calls <c>IUnknown::AddRef</c>. Returns the new reference count.</summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=C690D9
    // Broiler-Falsified-If: AddRef calls a vtable slot other than 1, so the native count Marshal.AddRef reports afterwards is not exactly one higher
    // Broiler-Human:        PENDING
    public uint AddRef()
    {
        if (_ptr == IntPtr.Zero)
            return 0;

        return ComVtable.Method<AddRefProc>(_ptr, 1)(_ptr);
    }

    /// <summary>
    /// Calls <c>IUnknown::QueryInterface</c> for <paramref name="iid"/>. Returns the HRESULT and, on
    /// success, the requested interface pointer in <paramref name="result"/>.
    /// </summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=58EA68
    // Broiler-Falsified-If: QueryInterface for IID_IUnknown returns S_OK with a result different from Marshal.QueryInterface's for the same object, showing slot 0 or the riid pointer is mis-marshalled
    // Broiler-Human:        PENDING
    public int QueryInterface(in Guid iid, out IntPtr result)
    {
        result = IntPtr.Zero;
        if (_ptr == IntPtr.Zero)
            return unchecked((int)0x80004003); // E_POINTER

        // Copy to a mutable local so it can be passed by ref (marshalled as the [in] riid pointer).
        Guid localIid = iid;
        return ComVtable.Method<QueryInterfaceProc>(_ptr, 0)(_ptr, ref localIid, out result);
    }

    /// <summary>Calls <c>IUnknown::Release</c> and clears the pointer. Returns the new reference count.</summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=AA80BA
    // Broiler-Falsified-If: a second Release or Dispose after the first calls slot 2 again instead of returning 0, dropping the native count below the references held
    // Broiler-Human:        PENDING
    public uint Release()
    {
        if (_ptr == IntPtr.Zero)
            return 0;

        uint count = ComVtable.Method<ReleaseProc>(_ptr, 2)(_ptr);
        _ptr = IntPtr.Zero;
        return count;
    }

    public void Dispose() => Release();
}
