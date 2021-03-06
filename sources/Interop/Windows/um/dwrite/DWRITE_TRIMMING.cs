// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_TRIMMING
    {
        public DWRITE_TRIMMING_GRANULARITY granularity;

        [NativeTypeName("UINT32")]
        public uint delimiter;

        [NativeTypeName("UINT32")]
        public uint delimiterCount;
    }
}
