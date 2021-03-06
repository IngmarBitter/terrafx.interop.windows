// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2256999D-D617-42F1-880E-0BA4542319D5")]
    [NativeTypeName("struct IAppxManifestPackageId2 : IAppxManifestPackageId")]
    public unsafe partial struct IAppxManifestPackageId2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestPackageId2*, uint>)(lpVtbl[1]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestPackageId2*, uint>)(lpVtbl[2]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId2*, ushort**, int>)(lpVtbl[3]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetArchitecture([NativeTypeName("APPX_PACKAGE_ARCHITECTURE *")] APPX_PACKAGE_ARCHITECTURE* architecture)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId2*, APPX_PACKAGE_ARCHITECTURE*, int>)(lpVtbl[4]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), architecture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId2*, ushort**, int>)(lpVtbl[5]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), publisher);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT64 *")] ulong* packageVersion)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId2*, ulong*, int>)(lpVtbl[6]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), packageVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceId([NativeTypeName("LPWSTR *")] ushort** resourceId)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId2*, ushort**, int>)(lpVtbl[7]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), resourceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ComparePublisher([NativeTypeName("LPCWSTR")] ushort* other, [NativeTypeName("BOOL *")] int* isSame)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId2*, ushort*, int*, int>)(lpVtbl[8]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), other, isSame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageFullName([NativeTypeName("LPWSTR *")] ushort** packageFullName)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId2*, ushort**, int>)(lpVtbl[9]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), packageFullName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageFamilyName([NativeTypeName("LPWSTR *")] ushort** packageFamilyName)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId2*, ushort**, int>)(lpVtbl[10]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), packageFamilyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetArchitecture2([NativeTypeName("APPX_PACKAGE_ARCHITECTURE2 *")] APPX_PACKAGE_ARCHITECTURE2* architecture)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId2*, APPX_PACKAGE_ARCHITECTURE2*, int>)(lpVtbl[11]))((IAppxManifestPackageId2*)Unsafe.AsPointer(ref this), architecture);
        }
    }
}
