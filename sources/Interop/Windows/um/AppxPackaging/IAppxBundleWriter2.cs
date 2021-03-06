// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D8FE971-01CC-49A0-B685-233851279962")]
    [NativeTypeName("struct IAppxBundleWriter2 : IUnknown")]
    public unsafe partial struct IAppxBundleWriter2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleWriter2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleWriter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleWriter2*, uint>)(lpVtbl[1]))((IAppxBundleWriter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleWriter2*, uint>)(lpVtbl[2]))((IAppxBundleWriter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddExternalPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, [NativeTypeName("IStream *")] IStream* inputStream)
        {
            return ((delegate* unmanaged<IAppxBundleWriter2*, ushort*, IStream*, int>)(lpVtbl[3]))((IAppxBundleWriter2*)Unsafe.AsPointer(ref this), fileName, inputStream);
        }
    }
}
