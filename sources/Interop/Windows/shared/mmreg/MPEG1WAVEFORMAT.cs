// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct MPEG1WAVEFORMAT
    {
        public WAVEFORMATEX wfx;

        [NativeTypeName("WORD")]
        public ushort fwHeadLayer;

        [NativeTypeName("DWORD")]
        public uint dwHeadBitrate;

        [NativeTypeName("WORD")]
        public ushort fwHeadMode;

        [NativeTypeName("WORD")]
        public ushort fwHeadModeExt;

        [NativeTypeName("WORD")]
        public ushort wHeadEmphasis;

        [NativeTypeName("WORD")]
        public ushort fwHeadFlags;

        [NativeTypeName("DWORD")]
        public uint dwPTSLow;

        [NativeTypeName("DWORD")]
        public uint dwPTSHigh;
    }
}
