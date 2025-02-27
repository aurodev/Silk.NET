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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVideoEncodeH265NaluSliceSegmentInfoEXT")]
    public unsafe partial struct VideoEncodeH265NaluSliceSegmentInfoEXT : IChainable
    {
        public VideoEncodeH265NaluSliceSegmentInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH265NaluSliceSegmentInfoExt,
            void* pNext = null,
            uint? ctbCount = null,
            VideoEncodeH265ReferenceListsInfoEXT* pReferenceFinalLists = null,
            Video.StdVideoEncodeH265SliceSegmentHeader* pSliceSegmentHeaderStd = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (ctbCount is not null)
            {
                CtbCount = ctbCount.Value;
            }

            if (pReferenceFinalLists is not null)
            {
                PReferenceFinalLists = pReferenceFinalLists;
            }

            if (pSliceSegmentHeaderStd is not null)
            {
                PSliceSegmentHeaderStd = pSliceSegmentHeaderStd;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "ctbCount")]
        public uint CtbCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265ReferenceListsInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH265ReferenceListsInfoEXT")]
        [NativeName("Name", "pReferenceFinalLists")]
        public VideoEncodeH265ReferenceListsInfoEXT* PReferenceFinalLists;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH265SliceSegmentHeader*")]
        [NativeName("Type.Name", "StdVideoEncodeH265SliceSegmentHeader")]
        [NativeName("Name", "pSliceSegmentHeaderStd")]
        public Video.StdVideoEncodeH265SliceSegmentHeader* PSliceSegmentHeaderStd;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265NaluSliceSegmentInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
