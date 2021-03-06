// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2463FBF0-B0AF-11D2-AFC5-00105A2799B5")]
    [NativeTypeName("struct ITfCreatePropertyStore : IUnknown")]
    public unsafe partial struct ITfCreatePropertyStore
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfCreatePropertyStore*, Guid*, void**, int>)(lpVtbl[0]))((ITfCreatePropertyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfCreatePropertyStore*, uint>)(lpVtbl[1]))((ITfCreatePropertyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfCreatePropertyStore*, uint>)(lpVtbl[2]))((ITfCreatePropertyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsStoreSerializable([NativeTypeName("const GUID &")] Guid* guidProp, [NativeTypeName("ITfRange *")] ITfRange* pRange, [NativeTypeName("ITfPropertyStore *")] ITfPropertyStore* pPropStore, [NativeTypeName("BOOL *")] int* pfSerializable)
        {
            return ((delegate* unmanaged<ITfCreatePropertyStore*, Guid*, ITfRange*, ITfPropertyStore*, int*, int>)(lpVtbl[3]))((ITfCreatePropertyStore*)Unsafe.AsPointer(ref this), guidProp, pRange, pPropStore, pfSerializable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePropertyStore([NativeTypeName("const GUID &")] Guid* guidProp, [NativeTypeName("ITfRange *")] ITfRange* pRange, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("IStream *")] IStream* pStream, [NativeTypeName("ITfPropertyStore **")] ITfPropertyStore** ppStore)
        {
            return ((delegate* unmanaged<ITfCreatePropertyStore*, Guid*, ITfRange*, uint, IStream*, ITfPropertyStore**, int>)(lpVtbl[4]))((ITfCreatePropertyStore*)Unsafe.AsPointer(ref this), guidProp, pRange, cb, pStream, ppStore);
        }
    }
}
