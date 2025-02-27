// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_EXTEND_MODE")]
    public enum ExtendMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Clamp\"")]
        [NativeName("Name", "D2D1_EXTEND_MODE_CLAMP")]
        ExtendModeClamp = 0x0,
        [Obsolete("Deprecated in favour of \"Wrap\"")]
        [NativeName("Name", "D2D1_EXTEND_MODE_WRAP")]
        ExtendModeWrap = 0x1,
        [Obsolete("Deprecated in favour of \"Mirror\"")]
        [NativeName("Name", "D2D1_EXTEND_MODE_MIRROR")]
        ExtendModeMirror = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_EXTEND_MODE_FORCE_DWORD")]
        ExtendModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_EXTEND_MODE_CLAMP")]
        Clamp = 0x0,
        [NativeName("Name", "D2D1_EXTEND_MODE_WRAP")]
        Wrap = 0x1,
        [NativeName("Name", "D2D1_EXTEND_MODE_MIRROR")]
        Mirror = 0x2,
        [NativeName("Name", "D2D1_EXTEND_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
