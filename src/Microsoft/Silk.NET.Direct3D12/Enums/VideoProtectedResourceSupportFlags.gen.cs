// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS")]
    public enum VideoProtectedResourceSupportFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAG_NONE")]
        VideoProtectedResourceSupportFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Supported\"")]
        [NativeName("Name", "D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAG_SUPPORTED")]
        VideoProtectedResourceSupportFlagSupported = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAG_SUPPORTED")]
        Supported = 0x1,
    }
}
