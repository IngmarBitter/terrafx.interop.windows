// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("70528852-2F26-4AEA-8C96-215150578932")]
    [NativeTypeName("struct ITfDisplayAttributeInfo : IUnknown")]
    public unsafe partial struct ITfDisplayAttributeInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeInfo*, Guid*, void**, int>)(lpVtbl[0]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeInfo*, uint>)(lpVtbl[1]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeInfo*, uint>)(lpVtbl[2]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeInfo*, Guid*, int>)(lpVtbl[3]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDesc)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeInfo*, ushort**, int>)(lpVtbl[4]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), pbstrDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributeInfo([NativeTypeName("TF_DISPLAYATTRIBUTE *")] TF_DISPLAYATTRIBUTE* pda)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeInfo*, TF_DISPLAYATTRIBUTE*, int>)(lpVtbl[5]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), pda);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAttributeInfo([NativeTypeName("const TF_DISPLAYATTRIBUTE *")] TF_DISPLAYATTRIBUTE* pda)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeInfo*, TF_DISPLAYATTRIBUTE*, int>)(lpVtbl[6]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), pda);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeInfo*, int>)(lpVtbl[7]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this));
        }
    }
}
