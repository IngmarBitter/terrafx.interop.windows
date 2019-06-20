// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1;

namespace TerraFX.Interop
{
    /// <summary>This is used to specify the quality of image scaling with ID2D1DeviceContext::DrawImage and with the 2D Affine Transform Effect.</summary>
    public enum D2D1_INTERPOLATION_MODE : uint
    {
        D2D1_INTERPOLATION_MODE_NEAREST_NEIGHBOR = D2D1_INTERPOLATION_MODE_DEFINITION_NEAREST_NEIGHBOR,

        D2D1_INTERPOLATION_MODE_LINEAR = D2D1_INTERPOLATION_MODE_DEFINITION_LINEAR,

        D2D1_INTERPOLATION_MODE_CUBIC = D2D1_INTERPOLATION_MODE_DEFINITION_CUBIC,

        D2D1_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR = D2D1_INTERPOLATION_MODE_DEFINITION_MULTI_SAMPLE_LINEAR,

        D2D1_INTERPOLATION_MODE_ANISOTROPIC = D2D1_INTERPOLATION_MODE_DEFINITION_ANISOTROPIC,

        D2D1_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC = D2D1_INTERPOLATION_MODE_DEFINITION_HIGH_QUALITY_CUBIC,

        D2D1_INTERPOLATION_MODE_FORCE_DWORD = 0xFFFFFFFF
    }
}
