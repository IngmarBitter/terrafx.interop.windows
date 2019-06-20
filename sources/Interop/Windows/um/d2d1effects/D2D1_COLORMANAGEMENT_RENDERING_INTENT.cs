// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies which ICC rendering intent the Color management effect should use.</summary>
    public enum D2D1_COLORMANAGEMENT_RENDERING_INTENT : uint
    {
        D2D1_COLORMANAGEMENT_RENDERING_INTENT_PERCEPTUAL = 0,

        D2D1_COLORMANAGEMENT_RENDERING_INTENT_RELATIVE_COLORIMETRIC = 1,

        D2D1_COLORMANAGEMENT_RENDERING_INTENT_SATURATION = 2,

        D2D1_COLORMANAGEMENT_RENDERING_INTENT_ABSOLUTE_COLORIMETRIC = 3,

        D2D1_COLORMANAGEMENT_RENDERING_INTENT_FORCE_DWORD = 0xFFFFFFFF
    }
}
