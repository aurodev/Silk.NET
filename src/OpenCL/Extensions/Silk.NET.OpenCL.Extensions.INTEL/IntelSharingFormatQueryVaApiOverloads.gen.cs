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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    public static class IntelSharingFormatQueryVaApiOverloads
    {
        public static unsafe int GetSupportedVAApimediaSurfaceFormats(this IntelSharingFormatQueryVaApi thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] void* va_api_formats, [Flow(FlowDirection.Out)] Span<uint> num_surface_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedVAApimediaSurfaceFormats(context, flags, image_type, plane, num_entries, va_api_formats, out num_surface_formats.GetPinnableReference());
        }

        public static unsafe int GetSupportedVAApimediaSurfaceFormats<T0>(this IntelSharingFormatQueryVaApi thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<T0> va_api_formats, [Flow(FlowDirection.Out)] uint* num_surface_formats) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSupportedVAApimediaSurfaceFormats(context, flags, image_type, plane, num_entries, out va_api_formats.GetPinnableReference(), num_surface_formats);
        }

        public static unsafe int GetSupportedVAApimediaSurfaceFormats<T0>(this IntelSharingFormatQueryVaApi thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<T0> va_api_formats, [Flow(FlowDirection.Out)] Span<uint> num_surface_formats) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSupportedVAApimediaSurfaceFormats(context, flags, image_type, plane, num_entries, out va_api_formats.GetPinnableReference(), out num_surface_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedVAApimediaSurfaceFormats(this IntelSharingFormatQueryVaApi thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] void* va_api_formats, [Flow(FlowDirection.Out)] Span<uint> num_surface_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedVAApimediaSurfaceFormats(context, flags, image_type, plane, num_entries, va_api_formats, out num_surface_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedVAApimediaSurfaceFormats<T0>(this IntelSharingFormatQueryVaApi thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<T0> va_api_formats, [Flow(FlowDirection.Out)] uint* num_surface_formats) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSupportedVAApimediaSurfaceFormats(context, flags, image_type, plane, num_entries, out va_api_formats.GetPinnableReference(), num_surface_formats);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedVAApimediaSurfaceFormats<T0>(this IntelSharingFormatQueryVaApi thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<T0> va_api_formats, [Flow(FlowDirection.Out)] Span<uint> num_surface_formats) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSupportedVAApimediaSurfaceFormats(context, flags, image_type, plane, num_entries, out va_api_formats.GetPinnableReference(), out num_surface_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedVAApimediaSurfaceFormats(this IntelSharingFormatQueryVaApi thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] void* va_api_formats, [Flow(FlowDirection.Out)] Span<uint> num_surface_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedVAApimediaSurfaceFormats(context, flags, image_type, plane, num_entries, va_api_formats, out num_surface_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedVAApimediaSurfaceFormats<T0>(this IntelSharingFormatQueryVaApi thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<T0> va_api_formats, [Flow(FlowDirection.Out)] uint* num_surface_formats) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSupportedVAApimediaSurfaceFormats(context, flags, image_type, plane, num_entries, out va_api_formats.GetPinnableReference(), num_surface_formats);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedVAApimediaSurfaceFormats<T0>(this IntelSharingFormatQueryVaApi thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<T0> va_api_formats, [Flow(FlowDirection.Out)] Span<uint> num_surface_formats) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSupportedVAApimediaSurfaceFormats(context, flags, image_type, plane, num_entries, out va_api_formats.GetPinnableReference(), out num_surface_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedVAApimediaSurfaceFormats(this IntelSharingFormatQueryVaApi thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] void* va_api_formats, [Flow(FlowDirection.Out)] Span<uint> num_surface_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedVAApimediaSurfaceFormats(context, flags, image_type, plane, num_entries, va_api_formats, out num_surface_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedVAApimediaSurfaceFormats<T0>(this IntelSharingFormatQueryVaApi thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<T0> va_api_formats, [Flow(FlowDirection.Out)] uint* num_surface_formats) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSupportedVAApimediaSurfaceFormats(context, flags, image_type, plane, num_entries, out va_api_formats.GetPinnableReference(), num_surface_formats);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedVAApimediaSurfaceFormats<T0>(this IntelSharingFormatQueryVaApi thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<T0> va_api_formats, [Flow(FlowDirection.Out)] Span<uint> num_surface_formats) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetSupportedVAApimediaSurfaceFormats(context, flags, image_type, plane, num_entries, out va_api_formats.GetPinnableReference(), out num_surface_formats.GetPinnableReference());
        }

    }
}

