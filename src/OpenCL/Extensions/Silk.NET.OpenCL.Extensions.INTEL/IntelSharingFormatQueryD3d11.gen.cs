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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_sharing_format_query_d3d11")]
    public unsafe partial class IntelSharingFormatQueryD3d11 : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_sharing_format_query_d3d11";
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* d3d11_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats);

        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* d3d11_formats, [Flow(FlowDirection.Out)] out uint num_texture_formats);

        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out uint d3d11_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats);

        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out uint d3d11_formats, [Flow(FlowDirection.Out)] out uint num_texture_formats);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* d3d11_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* d3d11_formats, [Flow(FlowDirection.Out)] out uint num_texture_formats);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out uint d3d11_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out uint d3d11_formats, [Flow(FlowDirection.Out)] out uint num_texture_formats);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* d3d11_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* d3d11_formats, [Flow(FlowDirection.Out)] out uint num_texture_formats);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out uint d3d11_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out uint d3d11_formats, [Flow(FlowDirection.Out)] out uint num_texture_formats);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* d3d11_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* d3d11_formats, [Flow(FlowDirection.Out)] out uint num_texture_formats);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out uint d3d11_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats);

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clGetSupportedD3D11TextureFormatsINTEL", Convention = CallingConvention.Winapi)]
        public partial int GetSupportedD3D11TextureFormats([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] out uint d3d11_formats, [Flow(FlowDirection.Out)] out uint num_texture_formats);

        public IntelSharingFormatQueryD3d11(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

