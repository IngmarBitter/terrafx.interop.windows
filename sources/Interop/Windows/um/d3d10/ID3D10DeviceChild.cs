// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E4C00-342C-4106-A19F-4F2704F689F0")]
    [NativeTypeName("struct ID3D10DeviceChild : IUnknown")]
    public unsafe partial struct ID3D10DeviceChild
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10DeviceChild*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10DeviceChild*, uint>)(lpVtbl[1]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10DeviceChild*, uint>)(lpVtbl[2]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice([NativeTypeName("ID3D10Device **")] ID3D10Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D10DeviceChild*, ID3D10Device**, void>)(lpVtbl[3]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D10DeviceChild*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D10DeviceChild*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D10DeviceChild*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D10DeviceChild*)Unsafe.AsPointer(ref this), guid, pData);
        }
    }
}
