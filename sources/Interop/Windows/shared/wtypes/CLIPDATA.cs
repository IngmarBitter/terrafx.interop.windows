// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CLIPDATA
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("LONG")]
        public int ulClipFmt;

        [NativeTypeName("BYTE *")]
        public byte* pClipData;
    }
}
