// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E4E02-342C-4106-A19F-4F2704F689F0")]
    [NativeTypeName("struct ID3D10SwitchToRef : IUnknown")]
    public unsafe partial struct ID3D10SwitchToRef
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10SwitchToRef*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10SwitchToRef*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10SwitchToRef*, uint>)(lpVtbl[1]))((ID3D10SwitchToRef*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10SwitchToRef*, uint>)(lpVtbl[2]))((ID3D10SwitchToRef*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int SetUseRef([NativeTypeName("BOOL")] int UseRef)
        {
            return ((delegate* unmanaged<ID3D10SwitchToRef*, int, int>)(lpVtbl[3]))((ID3D10SwitchToRef*)Unsafe.AsPointer(ref this), UseRef);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetUseRef()
        {
            return ((delegate* unmanaged<ID3D10SwitchToRef*, int>)(lpVtbl[4]))((ID3D10SwitchToRef*)Unsafe.AsPointer(ref this));
        }
    }
}
