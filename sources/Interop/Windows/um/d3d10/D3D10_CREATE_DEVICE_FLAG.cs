// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D10_CREATE_DEVICE_FLAG
    {
        D3D10_CREATE_DEVICE_SINGLETHREADED = 0x1,
        D3D10_CREATE_DEVICE_DEBUG = 0x2,
        D3D10_CREATE_DEVICE_SWITCH_TO_REF = 0x4,
        D3D10_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS = 0x8,
        D3D10_CREATE_DEVICE_ALLOW_NULL_FROM_MAP = 0x10,
        D3D10_CREATE_DEVICE_BGRA_SUPPORT = 0x20,
        D3D10_CREATE_DEVICE_PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY = 0x80,
        D3D10_CREATE_DEVICE_STRICT_VALIDATION = 0x200,
        D3D10_CREATE_DEVICE_DEBUGGABLE = 0x400,
    }
}
