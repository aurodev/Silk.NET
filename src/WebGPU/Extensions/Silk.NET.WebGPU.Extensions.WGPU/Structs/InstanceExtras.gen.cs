// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUInstanceExtras")]
    public unsafe partial struct InstanceExtras
    {
        public InstanceExtras
        (
            ChainedStruct? chain = null,
            uint? backends = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (backends is not null)
            {
                Backends = backends.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUInstanceBackendFlags")]
        [NativeName("Type.Name", "WGPUInstanceBackendFlags")]
        [NativeName("Name", "backends")]
        public uint Backends;
    }
}
