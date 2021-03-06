// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D2FFD834-958B-426D-8470-2A13879C6A91")]
    [NativeTypeName("struct IBurnVerification : IUnknown")]
    public unsafe partial struct IBurnVerification
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IBurnVerification*, Guid*, void**, int>)(lpVtbl[0]))((IBurnVerification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBurnVerification*, uint>)(lpVtbl[1]))((IBurnVerification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBurnVerification*, uint>)(lpVtbl[2]))((IBurnVerification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BurnVerificationLevel(IMAPI_BURN_VERIFICATION_LEVEL value)
        {
            return ((delegate* unmanaged<IBurnVerification*, IMAPI_BURN_VERIFICATION_LEVEL, int>)(lpVtbl[3]))((IBurnVerification*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BurnVerificationLevel([NativeTypeName("IMAPI_BURN_VERIFICATION_LEVEL *")] IMAPI_BURN_VERIFICATION_LEVEL* value)
        {
            return ((delegate* unmanaged<IBurnVerification*, IMAPI_BURN_VERIFICATION_LEVEL*, int>)(lpVtbl[4]))((IBurnVerification*)Unsafe.AsPointer(ref this), value);
        }
    }
}
