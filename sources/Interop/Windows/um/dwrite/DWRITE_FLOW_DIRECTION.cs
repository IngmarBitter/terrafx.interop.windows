// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DWRITE_FLOW_DIRECTION
    {
        DWRITE_FLOW_DIRECTION_TOP_TO_BOTTOM = 0,
        DWRITE_FLOW_DIRECTION_BOTTOM_TO_TOP = 1,
        DWRITE_FLOW_DIRECTION_LEFT_TO_RIGHT = 2,
        DWRITE_FLOW_DIRECTION_RIGHT_TO_LEFT = 3,
    }
}
