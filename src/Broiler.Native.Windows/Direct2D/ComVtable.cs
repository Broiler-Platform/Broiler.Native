// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   3
// Annotated:        3/3
// Exempt:           0
// Human-reviewed:   0/3
// IP risk:          Low
// Security risk:    Critical
// Criteria:         3/3
// Resource impact:  1/10 max
// Unverified:       3
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Broiler.Native.Windows.Direct2D;

/// <summary>
/// Safe (no <c>unsafe</c> context) access to COM interface methods through an object's vtable.
/// A COM object's first machine word points at its vtable; the entry at <c>slot</c> — counting
/// <c>IUnknown</c>'s QueryInterface/AddRef/Release as 0/1/2 — is the function pointer for a method.
/// </summary>
/// <remarks>
/// Function pointers are turned into managed delegates with
/// <see cref="Marshal.GetDelegateForFunctionPointer{TDelegate}(IntPtr)"/> and cached by pointer value.
/// Every object of a given COM class shares one vtable, so a method's pointer is stable: the delegate is
/// created once and reused for all instances. The per-call cost is two <see cref="Marshal.ReadIntPtr(IntPtr)"/>
/// reads (JIT intrinsics, no allocation) plus a concurrent-dictionary lookup — the closest fully-managed
/// equivalent of the previous <c>delegate* unmanaged</c> call sites.
/// </remarks>
// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=A7E366
// Broiler-Falsified-If: a function pointer shared by two methods with different signatures is called through the delegate type cached for the other method, corrupting the arguments or the stack
// Broiler-Human:        PENDING
public static class ComVtable
{
    // Keyed by function pointer and delegate type. Some COM implementations reuse a function pointer
    // for methods with the same ABI signature, while call sites still ask for distinct delegate types.
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=907F1B
    // Broiler-Falsified-If: a lookup for one function pointer with two delegate types returns the delegate built for the first type
    // Broiler-Human:        PENDING
    private static readonly ConcurrentDictionary<(IntPtr Function, Type DelegateType), Delegate> Delegates = new();

    /// <summary>
    /// Returns the method at <paramref name="slot"/> in <paramref name="comObject"/>'s vtable as a
    /// <typeparamref name="TDelegate"/>. <paramref name="comObject"/> must be non-null.
    /// </summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=22A61E
    // Broiler-Falsified-If: the function returned for slot n is not the pointer stored at the vtable plus n times IntPtr.Size, for example slot 2 on x64 yields the entry at byte 8 instead of byte 16
    // Broiler-Human:        PENDING
    public static TDelegate Method<TDelegate>(IntPtr comObject, int slot) where TDelegate : Delegate
    {
        IntPtr vtable = Marshal.ReadIntPtr(comObject);
        IntPtr function = Marshal.ReadIntPtr(vtable, slot * IntPtr.Size);

        return (TDelegate)Delegates.GetOrAdd((function, typeof(TDelegate)), 
            static key => Marshal.GetDelegateForFunctionPointer<TDelegate>(key.Function));
    }
}
