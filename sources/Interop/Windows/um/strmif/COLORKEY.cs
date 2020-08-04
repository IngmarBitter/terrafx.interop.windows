// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct COLORKEY
    {
        [NativeTypeName("DWORD")]
        public uint KeyType;

        [NativeTypeName("DWORD")]
        public uint PaletteIndex;

        [NativeTypeName("COLORREF")]
        public uint LowColorValue;

        [NativeTypeName("COLORREF")]
        public uint HighColorValue;
    }
}