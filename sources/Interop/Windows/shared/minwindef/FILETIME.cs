// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\minwindef.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct FILETIME
    {
        #region Fields
        [NativeTypeName("DWORD")]
        public uint dwLowDateTime;

        [NativeTypeName("DWORD")]
        public uint dwHighDateTime;
        #endregion
    }
}
