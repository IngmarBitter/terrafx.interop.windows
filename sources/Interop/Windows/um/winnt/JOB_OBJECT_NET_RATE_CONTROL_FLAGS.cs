// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum JOB_OBJECT_NET_RATE_CONTROL_FLAGS
    {
        JOB_OBJECT_NET_RATE_CONTROL_ENABLE = 0x1,
        JOB_OBJECT_NET_RATE_CONTROL_MAX_BANDWIDTH = 0x2,
        JOB_OBJECT_NET_RATE_CONTROL_DSCP_TAG = 0x4,
        JOB_OBJECT_NET_RATE_CONTROL_VALID_FLAGS = 0x7,
    }
}
