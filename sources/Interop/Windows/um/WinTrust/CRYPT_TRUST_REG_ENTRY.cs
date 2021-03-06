// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_TRUST_REG_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszDLLName;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszFunctionName;
    }
}
