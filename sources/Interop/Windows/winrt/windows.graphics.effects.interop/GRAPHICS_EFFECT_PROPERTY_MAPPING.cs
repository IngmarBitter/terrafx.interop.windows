// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.effects.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum GRAPHICS_EFFECT_PROPERTY_MAPPING
    {
        GRAPHICS_EFFECT_PROPERTY_MAPPING_UNKNOWN,
        GRAPHICS_EFFECT_PROPERTY_MAPPING_DIRECT,
        GRAPHICS_EFFECT_PROPERTY_MAPPING_VECTORX,
        GRAPHICS_EFFECT_PROPERTY_MAPPING_VECTORY,
        GRAPHICS_EFFECT_PROPERTY_MAPPING_VECTORZ,
        GRAPHICS_EFFECT_PROPERTY_MAPPING_VECTORW,
        GRAPHICS_EFFECT_PROPERTY_MAPPING_RECT_TO_VECTOR4,
        GRAPHICS_EFFECT_PROPERTY_MAPPING_RADIANS_TO_DEGREES,
        GRAPHICS_EFFECT_PROPERTY_MAPPING_COLORMATRIX_ALPHA_MODE,
        GRAPHICS_EFFECT_PROPERTY_MAPPING_COLOR_TO_VECTOR3,
        GRAPHICS_EFFECT_PROPERTY_MAPPING_COLOR_TO_VECTOR4,
    }
}
