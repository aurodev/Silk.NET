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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_vertex_array_object")]
    public unsafe partial class AppleVertexArrayObject : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_vertex_array_object";
        [NativeApi(EntryPoint = "glBindVertexArrayAPPLE", Convention = CallingConvention.Winapi)]
        public partial void BindVertexArray([Flow(FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glDeleteVertexArraysAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArraysAPPLE", Convention = CallingConvention.Winapi)]
        public partial void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArraysAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] VertexArray* arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArraysAPPLE", Convention = CallingConvention.Winapi)]
        public partial void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in VertexArray arrays);

        [NativeApi(EntryPoint = "glGenVertexArraysAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glGenVertexArraysAPPLE", Convention = CallingConvention.Winapi)]
        public partial void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint arrays);

        [NativeApi(EntryPoint = "glGenVertexArraysAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] VertexArray* arrays);

        [NativeApi(EntryPoint = "glGenVertexArraysAPPLE", Convention = CallingConvention.Winapi)]
        public partial void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out VertexArray arrays);

        [NativeApi(EntryPoint = "glIsVertexArrayAPPLE", Convention = CallingConvention.Winapi)]
        public partial bool IsVertexArray([Flow(FlowDirection.In)] uint array);

        public unsafe void DeleteVertexArray([Count(Parameter = "n"), Flow(FlowDirection.In)] uint arrays)
        {
            // ArrayParameterOverloader
            DeleteVertexArrays(1, &arrays);
        }

        public unsafe void DeleteVertexArrays([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> arrays)
        {
            // ImplicitCountSpanOverloader
            DeleteVertexArrays((uint) arrays.Length, in arrays.GetPinnableReference());
        }

        public unsafe void DeleteVertexArrays([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<VertexArray> arrays)
        {
            // ImplicitCountSpanOverloader
            DeleteVertexArrays((uint) arrays.Length, in arrays.GetPinnableReference());
        }

        public unsafe uint GenVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenVertexArrays(n, &ret);
            return ret;
        }

        public unsafe void GenVertexArrays([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays)
        {
            // ImplicitCountSpanOverloader
            GenVertexArrays((uint) arrays.Length, out arrays.GetPinnableReference());
        }

        public unsafe void GenVertexArrays([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<VertexArray> arrays)
        {
            // ImplicitCountSpanOverloader
            GenVertexArrays((uint) arrays.Length, out arrays.GetPinnableReference());
        }

        public unsafe uint GenVertexArrays([Flow(FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            GenVertexArrays(n, out uint silkRet);
            return silkRet;
        }

        public AppleVertexArrayObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

