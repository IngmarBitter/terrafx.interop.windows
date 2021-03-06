// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("43C9FE15-F494-4C17-9DE2-B8A4AC350AA8")]
    [NativeTypeName("struct ITfLanguageProfileNotifySink : IUnknown")]
    public unsafe partial struct ITfLanguageProfileNotifySink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLanguageProfileNotifySink*, Guid*, void**, int>)(lpVtbl[0]))((ITfLanguageProfileNotifySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLanguageProfileNotifySink*, uint>)(lpVtbl[1]))((ITfLanguageProfileNotifySink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLanguageProfileNotifySink*, uint>)(lpVtbl[2]))((ITfLanguageProfileNotifySink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnLanguageChange([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("BOOL *")] int* pfAccept)
        {
            return ((delegate* unmanaged<ITfLanguageProfileNotifySink*, ushort, int*, int>)(lpVtbl[3]))((ITfLanguageProfileNotifySink*)Unsafe.AsPointer(ref this), langid, pfAccept);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnLanguageChanged()
        {
            return ((delegate* unmanaged<ITfLanguageProfileNotifySink*, int>)(lpVtbl[4]))((ITfLanguageProfileNotifySink*)Unsafe.AsPointer(ref this));
        }
    }
}
