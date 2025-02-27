// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RESOURCE_DIMENSION")]
    public enum ResourceDimension : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3D12_RESOURCE_DIMENSION_UNKNOWN")]
        ResourceDimensionUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Buffer\"")]
        [NativeName("Name", "D3D12_RESOURCE_DIMENSION_BUFFER")]
        ResourceDimensionBuffer = 0x1,
        [Obsolete("Deprecated in favour of \"Texture1D\"")]
        [NativeName("Name", "D3D12_RESOURCE_DIMENSION_TEXTURE1D")]
        ResourceDimensionTexture1D = 0x2,
        [Obsolete("Deprecated in favour of \"Texture2D\"")]
        [NativeName("Name", "D3D12_RESOURCE_DIMENSION_TEXTURE2D")]
        ResourceDimensionTexture2D = 0x3,
        [Obsolete("Deprecated in favour of \"Texture3D\"")]
        [NativeName("Name", "D3D12_RESOURCE_DIMENSION_TEXTURE3D")]
        ResourceDimensionTexture3D = 0x4,
        [NativeName("Name", "D3D12_RESOURCE_DIMENSION_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D3D12_RESOURCE_DIMENSION_BUFFER")]
        Buffer = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_DIMENSION_TEXTURE1D")]
        Texture1D = 0x2,
        [NativeName("Name", "D3D12_RESOURCE_DIMENSION_TEXTURE2D")]
        Texture2D = 0x3,
        [NativeName("Name", "D3D12_RESOURCE_DIMENSION_TEXTURE3D")]
        Texture3D = 0x4,
    }
}
