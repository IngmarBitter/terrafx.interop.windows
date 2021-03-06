// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA7A8931-80E4-4FEC-8F3B-553F87B4966E")]
    [NativeTypeName("struct IVisualTreeServiceCallback : IUnknown")]
    public unsafe partial struct IVisualTreeServiceCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVisualTreeServiceCallback*, Guid*, void**, int>)(lpVtbl[0]))((IVisualTreeServiceCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVisualTreeServiceCallback*, uint>)(lpVtbl[1]))((IVisualTreeServiceCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVisualTreeServiceCallback*, uint>)(lpVtbl[2]))((IVisualTreeServiceCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnVisualTreeChange(ParentChildRelation relation, VisualElement element, VisualMutationType mutationType)
        {
            return ((delegate* unmanaged<IVisualTreeServiceCallback*, ParentChildRelation, VisualElement, VisualMutationType, int>)(lpVtbl[3]))((IVisualTreeServiceCallback*)Unsafe.AsPointer(ref this), relation, element, mutationType);
        }
    }
}
