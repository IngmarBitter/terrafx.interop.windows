// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Roundness of letterform. Present for families: 2-text</summary>
    public enum DWRITE_PANOSE_LETTERFORM
    {
        DWRITE_PANOSE_LETTERFORM_ANY = 0,

        DWRITE_PANOSE_LETTERFORM_NO_FIT = 1,

        DWRITE_PANOSE_LETTERFORM_NORMAL_CONTACT = 2,

        DWRITE_PANOSE_LETTERFORM_NORMAL_WEIGHTED = 3,

        DWRITE_PANOSE_LETTERFORM_NORMAL_BOXED = 4,

        DWRITE_PANOSE_LETTERFORM_NORMAL_FLATTENED = 5,

        DWRITE_PANOSE_LETTERFORM_NORMAL_ROUNDED = 6,

        DWRITE_PANOSE_LETTERFORM_NORMAL_OFF_CENTER = 7,

        DWRITE_PANOSE_LETTERFORM_NORMAL_SQUARE = 8,

        DWRITE_PANOSE_LETTERFORM_OBLIQUE_CONTACT = 9,

        DWRITE_PANOSE_LETTERFORM_OBLIQUE_WEIGHTED = 10,

        DWRITE_PANOSE_LETTERFORM_OBLIQUE_BOXED = 11,

        DWRITE_PANOSE_LETTERFORM_OBLIQUE_FLATTENED = 12,

        DWRITE_PANOSE_LETTERFORM_OBLIQUE_ROUNDED = 13,

        DWRITE_PANOSE_LETTERFORM_OBLIQUE_OFF_CENTER = 14,

        DWRITE_PANOSE_LETTERFORM_OBLIQUE_SQUARE = 15
    }
}
