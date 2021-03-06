// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("418726D8-DD99-4F5D-9886-157ADD20DE01")]
    [NativeTypeName("struct IAppxContentGroupMapReader : IUnknown")]
    public unsafe partial struct IAppxContentGroupMapReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxContentGroupMapReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppxContentGroupMapReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxContentGroupMapReader*, uint>)(lpVtbl[1]))((IAppxContentGroupMapReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxContentGroupMapReader*, uint>)(lpVtbl[2]))((IAppxContentGroupMapReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRequiredGroup([NativeTypeName("IAppxContentGroup **")] IAppxContentGroup** requiredGroup)
        {
            return ((delegate* unmanaged<IAppxContentGroupMapReader*, IAppxContentGroup**, int>)(lpVtbl[3]))((IAppxContentGroupMapReader*)Unsafe.AsPointer(ref this), requiredGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAutomaticGroups([NativeTypeName("IAppxContentGroupsEnumerator **")] IAppxContentGroupsEnumerator** automaticGroupsEnumerator)
        {
            return ((delegate* unmanaged<IAppxContentGroupMapReader*, IAppxContentGroupsEnumerator**, int>)(lpVtbl[4]))((IAppxContentGroupMapReader*)Unsafe.AsPointer(ref this), automaticGroupsEnumerator);
        }
    }
}
