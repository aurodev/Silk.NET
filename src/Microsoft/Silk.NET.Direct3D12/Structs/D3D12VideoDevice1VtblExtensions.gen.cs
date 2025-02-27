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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12VideoDevice1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDevice1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDevice1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDevice1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDevice1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12VideoDevice1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12VideoDevice1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckFeatureSupport(this ComPtr<ID3D12VideoDevice1> thisVtbl, FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, FeatureVideo, void*, uint, int>)@this->LpVtbl[3])(@this, FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, FeatureVideo FeatureVideo, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, FeatureVideo, void*, uint, int>)@this->LpVtbl[3])(@this, FeatureVideo, pFeatureSupportDataPtr, FeatureSupportDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderDesc* pDesc, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riid, ppVideoDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderDesc* pDesc, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riid, ppVideoDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderDesc* pDesc, ref Guid riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderDesc* pDesc, ref Guid riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoDecoderDesc pDesc, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoDecoderDesc pDesc, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoDecoderDesc pDesc, ref Guid riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riidPtr, ppVideoDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoDecoderDesc pDesc, ref Guid riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riidPtr, ppVideoDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riidPtr, ppVideoDecoderHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riidPtr, ppVideoDecoderHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessor);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimatorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionEstimator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionEstimatorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimatorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimator);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimatorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionEstimator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionEstimatorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionEstimator);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionEstimatorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimator);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimatorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimator);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimatorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionVectorHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeap);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeapPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDevice1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDevice1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, FeatureVideo FeatureVideo, Span<T0> pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckFeatureSupport(FeatureVideo, ref pFeatureSupportData.GetPinnableReference(), FeatureSupportDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderDesc* pDesc, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderDesc* pDesc, Span<Guid> riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(pDesc, ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderDesc* pDesc, Span<Guid> riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(pDesc, ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(in pDesc.GetPinnableReference(), riid, ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoder<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoDecoderDesc pDesc, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(in pDesc.GetPinnableReference(), riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Span<Guid> riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Span<Guid> riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<Guid> riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<Guid> riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc.GetPinnableReference(), riid, ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoderHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc.GetPinnableReference(), riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<Guid> riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<Guid> riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] in VideoProcessInputStreamDesc pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] in VideoProcessInputStreamDesc pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0, TI1>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionEstimator = default;
        return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionEstimator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionEstimator = default;
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionEstimator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoMotionEstimator<TI0, TI1>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionEstimator = default;
        return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionEstimator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionEstimator = default;
        return @this->CreateVideoMotionEstimator(in pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionEstimator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0, TI1>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionVectorHeap = default;
        return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionVectorHeap = default;
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoMotionVectorHeap<TI0, TI1>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionVectorHeap = default;
        return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionVectorHeap = default;
        return @this->CreateVideoMotionVectorHeap(in pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoder<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoDecoder<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoDecoderDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder(in pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoderHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoDecoderHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoDecoderHeapDesc pVideoDecoderHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] in VideoProcessInputStreamDesc pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, uint NodeMask, [Flow(FlowDirection.In)] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(FlowDirection.In)] in VideoProcessInputStreamDesc pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateVideoMotionEstimator<TI0, TI1>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateVideoMotionEstimator<TI0, TI1>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(in pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(in pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateVideoMotionVectorHeap<TI0, TI1>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateVideoMotionVectorHeap<TI0, TI1>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(in pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice1> thisVtbl, [Flow(FlowDirection.In)] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(in pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
