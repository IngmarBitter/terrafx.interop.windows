// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum ReplacesCorHdrNumericDefines
    {
        COMIMAGE_FLAGS_ILONLY = 0x00000001,
        COMIMAGE_FLAGS_32BITREQUIRED = 0x00000002,
        COMIMAGE_FLAGS_IL_LIBRARY = 0x00000004,
        COMIMAGE_FLAGS_STRONGNAMESIGNED = 0x00000008,
        COMIMAGE_FLAGS_NATIVE_ENTRYPOINT = 0x00000010,
        COMIMAGE_FLAGS_TRACKDEBUGDATA = 0x00010000,
        COMIMAGE_FLAGS_32BITPREFERRED = 0x00020000,
        COR_VERSION_MAJOR_V2 = 2,
        COR_VERSION_MAJOR = COR_VERSION_MAJOR_V2,
        COR_VERSION_MINOR = 5,
        COR_DELETED_NAME_LENGTH = 8,
        COR_VTABLEGAP_NAME_LENGTH = 8,
        NATIVE_TYPE_MAX_CB = 1,
        COR_ILMETHOD_SECT_SMALL_MAX_DATASIZE = 0xFF,
        IMAGE_COR_MIH_METHODRVA = 0x01,
        IMAGE_COR_MIH_EHRVA = 0x02,
        IMAGE_COR_MIH_BASICBLOCK = 0x08,
        COR_VTABLE_32BIT = 0x01,
        COR_VTABLE_64BIT = 0x02,
        COR_VTABLE_FROM_UNMANAGED = 0x04,
        COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN = 0x08,
        COR_VTABLE_CALL_MOST_DERIVED = 0x10,
        IMAGE_COR_EATJ_THUNK_SIZE = 32,
        MAX_CLASS_NAME = 1024,
        MAX_PACKAGE_NAME = 1024,
    }
}
