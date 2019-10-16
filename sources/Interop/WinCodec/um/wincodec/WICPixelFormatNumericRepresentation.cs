// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICPixelFormatNumericRepresentation
    {
        WICPixelFormatNumericRepresentationUnspecified = 0,
        WICPixelFormatNumericRepresentationIndexed = 0x1,
        WICPixelFormatNumericRepresentationUnsignedInteger = 0x2,
        WICPixelFormatNumericRepresentationSignedInteger = 0x3,
        WICPixelFormatNumericRepresentationFixed = 0x4,
        WICPixelFormatNumericRepresentationFloat = 0x5,
        WICPixelFormatNumericRepresentation_FORCE_DWORD = 0x7FFFFFFF,
    }
}
