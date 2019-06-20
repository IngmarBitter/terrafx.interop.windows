// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Defines the type of SVG POD attribute to set or get.</summary>
    public enum D2D1_SVG_ATTRIBUTE_POD_TYPE : uint
    {
        /// <summary>The attribute is a FLOAT.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT = 0,

        /// <summary>The attribute is a D2D1_COLOR_F.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR = 1,

        /// <summary>The attribute is a D2D1_FILL_MODE.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE = 2,

        /// <summary>The attribute is a D2D1_SVG_DISPLAY.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY = 3,

        /// <summary>The attribute is a D2D1_SVG_OVERFLOW.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW = 4,

        /// <summary>The attribute is a D2D1_SVG_LINE_CAP.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP = 5,

        /// <summary>The attribute is a D2D1_SVG_LINE_JOIN.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN = 6,

        /// <summary>The attribute is a D2D1_SVG_VISIBILITY.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY = 7,

        /// <summary>The attribute is a D2D1_MATRIX_3X2_F.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX = 8,

        /// <summary>The attribute is a D2D1_SVG_UNIT_TYPE.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE = 9,

        /// <summary>The attribute is a D2D1_EXTEND_MODE.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE = 10,

        /// <summary>The attribute is a D2D1_SVG_PRESERVE_ASPECT_RATIO.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO = 11,

        /// <summary>The attribute is a D2D1_SVG_VIEWBOX.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_VIEWBOX = 12,

        /// <summary>The attribute is a D2D1_SVG_LENGTH.</summary>
        D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH = 13,

        D2D1_SVG_ATTRIBUTE_POD_TYPE_FORCE_DWORD = 0xFFFFFFFF
    }
}
