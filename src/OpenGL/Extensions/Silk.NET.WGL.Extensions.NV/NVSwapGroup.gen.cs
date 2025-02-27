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
using Silk.NET.WGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.NV
{
    [Extension("NV_swap_group")]
    public unsafe partial class NVSwapGroup : NativeExtension<WGL>
    {
        public const string ExtensionName = "NV_swap_group";
        [NativeApi(EntryPoint = "wglBindSwapBarrierNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 BindSwapBarrier([Flow(FlowDirection.In)] uint group, [Flow(FlowDirection.In)] uint barrier);

        [NativeApi(EntryPoint = "wglJoinSwapGroupNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 JoinSwapGroup([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] uint group);

        [NativeApi(EntryPoint = "wglQueryFrameCountNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryFrameCount([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.Out)] uint* count);

        [NativeApi(EntryPoint = "wglQueryFrameCountNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 QueryFrameCount([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.Out)] out uint count);

        [NativeApi(EntryPoint = "wglQueryMaxSwapGroupsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryMaxSwapGroups([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.Out)] uint* maxGroups, [Flow(FlowDirection.Out)] uint* maxBarriers);

        [NativeApi(EntryPoint = "wglQueryMaxSwapGroupsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryMaxSwapGroups([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.Out)] uint* maxGroups, [Flow(FlowDirection.Out)] out uint maxBarriers);

        [NativeApi(EntryPoint = "wglQueryMaxSwapGroupsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryMaxSwapGroups([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.Out)] out uint maxGroups, [Flow(FlowDirection.Out)] uint* maxBarriers);

        [NativeApi(EntryPoint = "wglQueryMaxSwapGroupsNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 QueryMaxSwapGroups([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.Out)] out uint maxGroups, [Flow(FlowDirection.Out)] out uint maxBarriers);

        [NativeApi(EntryPoint = "wglQuerySwapGroupNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QuerySwapGroup([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.Out)] uint* group, [Flow(FlowDirection.Out)] uint* barrier);

        [NativeApi(EntryPoint = "wglQuerySwapGroupNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QuerySwapGroup([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.Out)] uint* group, [Flow(FlowDirection.Out)] out uint barrier);

        [NativeApi(EntryPoint = "wglQuerySwapGroupNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QuerySwapGroup([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.Out)] out uint group, [Flow(FlowDirection.Out)] uint* barrier);

        [NativeApi(EntryPoint = "wglQuerySwapGroupNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 QuerySwapGroup([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.Out)] out uint group, [Flow(FlowDirection.Out)] out uint barrier);

        [NativeApi(EntryPoint = "wglResetFrameCountNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 ResetFrameCount([Flow(FlowDirection.In)] nint hDC);

        public NVSwapGroup(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

