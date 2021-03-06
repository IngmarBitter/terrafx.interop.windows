// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FCA6C349-A12F-43A3-8DD6-5A5A4282577B")]
    [NativeTypeName("struct ITfFnCustomSpeechCommand : ITfFunction")]
    public unsafe partial struct ITfFnCustomSpeechCommand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnCustomSpeechCommand*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnCustomSpeechCommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnCustomSpeechCommand*, uint>)(lpVtbl[1]))((ITfFnCustomSpeechCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnCustomSpeechCommand*, uint>)(lpVtbl[2]))((ITfFnCustomSpeechCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnCustomSpeechCommand*, ushort**, int>)(lpVtbl[3]))((ITfFnCustomSpeechCommand*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSpeechCommandProvider([NativeTypeName("IUnknown *")] IUnknown* pspcmdProvider)
        {
            return ((delegate* unmanaged<ITfFnCustomSpeechCommand*, IUnknown*, int>)(lpVtbl[4]))((ITfFnCustomSpeechCommand*)Unsafe.AsPointer(ref this), pspcmdProvider);
        }
    }
}
