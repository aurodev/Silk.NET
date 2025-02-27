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

namespace Silk.NET.DirectStorage
{
    [Guid("dd2f482c-5eff-41e8-9c9e-d2374b278128")]
    [NativeName("Name", "IDStorageQueue1")]
    public unsafe partial struct IDStorageQueue1 : IComVtbl<IDStorageQueue1>, IComVtbl<IDStorageQueue>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("dd2f482c-5eff-41e8-9c9e-d2374b278128");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDStorageQueue(IDStorageQueue1 val)
            => Unsafe.As<IDStorageQueue1, IDStorageQueue>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDStorageQueue1 val)
            => Unsafe.As<IDStorageQueue1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDStorageQueue1
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueRequest([Flow(FlowDirection.In)] Request* request)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, Request*, void>)@this->LpVtbl[3])(@this, request);
        }

        /// <summary>To be documented.</summary>
        public readonly void EnqueueRequest([Flow(FlowDirection.In)] in Request request)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Request* requestPtr = &request)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, Request*, void>)@this->LpVtbl[3])(@this, requestPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueStatus(IDStorageStatusArray* statusArray, uint index)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, IDStorageStatusArray*, uint, void>)@this->LpVtbl[4])(@this, statusArray, index);
        }

        /// <summary>To be documented.</summary>
        public readonly void EnqueueStatus(ref IDStorageStatusArray statusArray, uint index)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDStorageStatusArray* statusArrayPtr = &statusArray)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, IDStorageStatusArray*, uint, void>)@this->LpVtbl[4])(@this, statusArrayPtr, index);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueSignal(Silk.NET.Direct3D12.ID3D12Fence* fence, ulong value)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)@this->LpVtbl[5])(@this, fence, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void EnqueueSignal(ref Silk.NET.Direct3D12.ID3D12Fence fence, ulong value)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Direct3D12.ID3D12Fence* fencePtr = &fence)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)@this->LpVtbl[5])(@this, fencePtr, value);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void Submit()
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, void>)@this->LpVtbl[6])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void CancelRequestsWithTag(ulong mask, ulong value)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, ulong, ulong, void>)@this->LpVtbl[7])(@this, mask, value);
        }

        /// <summary>To be documented.</summary>
        public readonly void Close()
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, void>)@this->LpVtbl[8])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetErrorEvent()
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, void*>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RetrieveErrorRecord(ErrorRecord* record)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, ErrorRecord*, void>)@this->LpVtbl[10])(@this, record);
        }

        /// <summary>To be documented.</summary>
        public readonly void RetrieveErrorRecord(ref ErrorRecord record)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ErrorRecord* recordPtr = &record)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, ErrorRecord*, void>)@this->LpVtbl[10])(@this, recordPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Query(QueueInfo* info)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, QueueInfo*, void>)@this->LpVtbl[11])(@this, info);
        }

        /// <summary>To be documented.</summary>
        public readonly void Query(ref QueueInfo info)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (QueueInfo* infoPtr = &info)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, QueueInfo*, void>)@this->LpVtbl[11])(@this, infoPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueSetEvent(void* handle)
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, void*, void>)@this->LpVtbl[12])(@this, handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void EnqueueSetEvent<T0>(ref T0 handle) where T0 : unmanaged
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* handlePtr = &handle)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageQueue1*, void*, void>)@this->LpVtbl[12])(@this, handlePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void EnqueueStatus<TI0>(ComPtr<TI0> statusArray, uint index) where TI0 : unmanaged, IComVtbl<IDStorageStatusArray>, IComVtbl<TI0>
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EnqueueStatus((IDStorageStatusArray*) statusArray.Handle, index);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDStorageQueue1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
