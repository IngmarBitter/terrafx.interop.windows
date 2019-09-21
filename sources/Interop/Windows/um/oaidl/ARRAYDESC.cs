// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public struct ARRAYDESC
    {
        #region Fields
        public TYPEDESC tdescElem;

        [NativeTypeName("USHORT")]
        public ushort cDims;

        [NativeTypeName("SAFEARRAYBOUND[1]")]
        public _rgbounds_e__FixedBuffer rgbounds;
        #endregion

        #region Structs
        public unsafe struct _rgbounds_e__FixedBuffer
        {
            #region Fields
            public SAFEARRAYBOUND e0;
            #endregion

            #region Properties
            public ref SAFEARRAYBOUND this[int index] => ref AsSpan(int.MaxValue)[index];
            #endregion

            public Span<SAFEARRAYBOUND> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
        #endregion
    }
}
