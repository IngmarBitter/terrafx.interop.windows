// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies the pixel snapping policy when rendering color bitmap glyphs.</summary>
    public enum D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION : uint
    {
        /// <summary>Color bitmap glyph positions are snapped to the nearest pixel if the bitmap resolution matches that of the device context.</summary>
        D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DEFAULT = 0,

        /// <summary>Color bitmap glyph positions are not snapped.</summary>
        D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DISABLE = 1,

        D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_FORCE_DWORD = 0xFFFFFFFF
    }
}
