// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Description of a pixel format.</summary>
    [Unmanaged]
    public struct D2D1_PIXEL_FORMAT
    {
        #region Fields
        public DXGI_FORMAT format;

        public D2D1_ALPHA_MODE alphaMode;
        #endregion
    }
}
