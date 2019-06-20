// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Indicates whether the given figure is filled or hollow.</summary>
    public enum D2D1_FIGURE_BEGIN : uint
    {
        D2D1_FIGURE_BEGIN_FILLED = 0,

        D2D1_FIGURE_BEGIN_HOLLOW = 1,

        D2D1_FIGURE_BEGIN_FORCE_DWORD = 0xFFFFFFFF
    }
}
