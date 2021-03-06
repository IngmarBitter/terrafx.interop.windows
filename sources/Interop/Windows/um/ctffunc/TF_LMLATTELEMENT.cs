// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct TF_LMLATTELEMENT
    {
        [NativeTypeName("DWORD")]
        public uint dwFrameStart;

        [NativeTypeName("DWORD")]
        public uint dwFrameLen;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("TF_LMLATTELEMENT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ctffunc.h:2273:36)")]
        public _Anonymous_e__Union Anonymous;

        public ref int iCost
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.iCost, 1));
            }
        }

        [NativeTypeName("BSTR")]
        public ushort* bstrText;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("INT")]
            public int iCost;
        }
    }
}
