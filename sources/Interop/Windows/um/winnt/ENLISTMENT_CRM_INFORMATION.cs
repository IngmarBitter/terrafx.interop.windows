// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct ENLISTMENT_CRM_INFORMATION
    {
        [NativeTypeName("GUID")]
        public Guid CrmTransactionManagerId;

        [NativeTypeName("GUID")]
        public Guid CrmResourceManagerId;

        [NativeTypeName("GUID")]
        public Guid CrmEnlistmentId;
    }
}
