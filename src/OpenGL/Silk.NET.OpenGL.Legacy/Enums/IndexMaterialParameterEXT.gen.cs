// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "IndexMaterialParameterEXT")]
    public enum IndexMaterialParameterEXT : int
    {
        [System.Obsolete]
        [NativeName("Name", "GL_INDEX_OFFSET")]
        IndexOffset = 0xD13,
    }
}
