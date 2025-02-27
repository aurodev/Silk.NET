// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_GAUSSIANBLUR_PROP")]
    public enum GaussianblurProp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"StandardDeviation\"")]
        [NativeName("Name", "D2D1_GAUSSIANBLUR_PROP_STANDARD_DEVIATION")]
        GaussianblurPropStandardDeviation = 0x0,
        [Obsolete("Deprecated in favour of \"Optimization\"")]
        [NativeName("Name", "D2D1_GAUSSIANBLUR_PROP_OPTIMIZATION")]
        GaussianblurPropOptimization = 0x1,
        [Obsolete("Deprecated in favour of \"BorderMode\"")]
        [NativeName("Name", "D2D1_GAUSSIANBLUR_PROP_BORDER_MODE")]
        GaussianblurPropBorderMode = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_GAUSSIANBLUR_PROP_FORCE_DWORD")]
        GaussianblurPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_GAUSSIANBLUR_PROP_STANDARD_DEVIATION")]
        StandardDeviation = 0x0,
        [NativeName("Name", "D2D1_GAUSSIANBLUR_PROP_OPTIMIZATION")]
        Optimization = 0x1,
        [NativeName("Name", "D2D1_GAUSSIANBLUR_PROP_BORDER_MODE")]
        BorderMode = 0x2,
        [NativeName("Name", "D2D1_GAUSSIANBLUR_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
