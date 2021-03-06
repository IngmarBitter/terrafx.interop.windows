// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1AC56374-6198-4D6B-92E4-749D5AB8A895")]
    [NativeTypeName("struct IAppxManifestPackageDependency3 : IUnknown")]
    public unsafe partial struct IAppxManifestPackageDependency3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestPackageDependency3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency3*, uint>)(lpVtbl[1]))((IAppxManifestPackageDependency3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency3*, uint>)(lpVtbl[2]))((IAppxManifestPackageDependency3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIsOptional([NativeTypeName("BOOL *")] int* isOptional)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency3*, int*, int>)(lpVtbl[3]))((IAppxManifestPackageDependency3*)Unsafe.AsPointer(ref this), isOptional);
        }
    }
}
