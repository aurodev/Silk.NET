// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SATURATION_PROP")]
    public enum SaturationProp : int
    {
        [Obsolete("Deprecated in favour of \"Saturation\"")]
        [NativeName("Name", "D2D1_SATURATION_PROP_SATURATION")]
        SaturationPropSaturation = 0x0,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SATURATION_PROP_FORCE_DWORD")]
        SaturationPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SATURATION_PROP_SATURATION")]
        Saturation = 0x0,
        [NativeName("Name", "D2D1_SATURATION_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
