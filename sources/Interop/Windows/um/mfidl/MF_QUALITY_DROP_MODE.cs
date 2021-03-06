// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_QUALITY_DROP_MODE
    {
        MF_DROP_MODE_NONE = 0,
        MF_DROP_MODE_1 = 0x1,
        MF_DROP_MODE_2 = 0x2,
        MF_DROP_MODE_3 = 0x3,
        MF_DROP_MODE_4 = 0x4,
        MF_DROP_MODE_5 = 0x5,
        MF_NUM_DROP_MODES = 0x6,
    }
}
