// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_4.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1BC6EA02-EF36-464F-BF0C-21CA39E5168A")]
    public unsafe struct IDXGIFactory4
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIFactory4* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIFactory4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIFactory4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGIFactory4* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGIFactory4* This, [NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGIFactory4* This, [NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGIFactory4* This, [NativeTypeName("REFIID")] Guid* riid, void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapters(IDXGIFactory4* This, [NativeTypeName("UINT")] uint Adapter, IDXGIAdapter** ppAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MakeWindowAssociation(IDXGIFactory4* This, [NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindowAssociation(IDXGIFactory4* This, [NativeTypeName("HWND")] IntPtr* pWindowHandle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChain(IDXGIFactory4* This, IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSoftwareAdapter(IDXGIFactory4* This, [NativeTypeName("HMODULE")] IntPtr Module, IDXGIAdapter** ppAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapters1(IDXGIFactory4* This, [NativeTypeName("UINT")] uint Adapter, IDXGIAdapter1** ppAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsCurrent(IDXGIFactory4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsWindowedStereoEnabled(IDXGIFactory4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForHwnd(IDXGIFactory4* This, IUnknown* pDevice, [NativeTypeName("HWND")] IntPtr hWnd, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForCoreWindow(IDXGIFactory4* This, IUnknown* pDevice, IUnknown* pWindow, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSharedResourceAdapterLuid(IDXGIFactory4* This, [NativeTypeName("HANDLE")] IntPtr hResource, LUID* pLuid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterStereoStatusWindow(IDXGIFactory4* This, [NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterStereoStatusEvent(IDXGIFactory4* This, [NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UnregisterStereoStatus(IDXGIFactory4* This, [NativeTypeName("DWORD")] uint dwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterOcclusionStatusWindow(IDXGIFactory4* This, [NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterOcclusionStatusEvent(IDXGIFactory4* This, [NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UnregisterOcclusionStatus(IDXGIFactory4* This, [NativeTypeName("UINT")] uint dwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForComposition(IDXGIFactory4* This, IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetCreationFlags(IDXGIFactory4* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapterByLuid(IDXGIFactory4* This, LUID AdapterLuid, [NativeTypeName("REFIID")] Guid* riid, void** ppvAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumWarpAdapter(IDXGIFactory4* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvAdapter);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, void* pData)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, Name, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* Name, IUnknown* pUnknown = null)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, Name, pUnknown);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* Name, [NativeTypeName("UINT")] uint* pDataSize, void* pData)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, Name, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("REFIID")] Guid* riid, void** ppParent)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(This, riid, ppParent);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters([NativeTypeName("UINT")] uint Adapter, IDXGIAdapter** ppAdapter)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumAdapters>(lpVtbl->EnumAdapters)(This, Adapter, ppAdapter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeWindowAssociation([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint Flags)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MakeWindowAssociation>(lpVtbl->MakeWindowAssociation)(This, WindowHandle, Flags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowAssociation([NativeTypeName("HWND")] IntPtr* pWindowHandle)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWindowAssociation>(lpVtbl->GetWindowAssociation)(This, pWindowHandle);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChain(IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain** ppSwapChain)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChain>(lpVtbl->CreateSwapChain)(This, pDevice, pDesc, ppSwapChain);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSoftwareAdapter([NativeTypeName("HMODULE")] IntPtr Module, IDXGIAdapter** ppAdapter)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSoftwareAdapter>(lpVtbl->CreateSoftwareAdapter)(This, Module, ppAdapter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters1([NativeTypeName("UINT")] uint Adapter, IDXGIAdapter1** ppAdapter)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumAdapters1>(lpVtbl->EnumAdapters1)(This, Adapter, ppAdapter);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsCurrent()
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsCurrent>(lpVtbl->IsCurrent)(This);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsWindowedStereoEnabled()
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsWindowedStereoEnabled>(lpVtbl->IsWindowedStereoEnabled)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForHwnd(IUnknown* pDevice, [NativeTypeName("HWND")] IntPtr hWnd, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForHwnd>(lpVtbl->CreateSwapChainForHwnd)(This, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForCoreWindow(IUnknown* pDevice, IUnknown* pWindow, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForCoreWindow>(lpVtbl->CreateSwapChainForCoreWindow)(This, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharedResourceAdapterLuid([NativeTypeName("HANDLE")] IntPtr hResource, LUID* pLuid)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSharedResourceAdapterLuid>(lpVtbl->GetSharedResourceAdapterLuid)(This, hResource, pLuid);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterStereoStatusWindow([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD")] uint* pdwCookie)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterStereoStatusWindow>(lpVtbl->RegisterStereoStatusWindow)(This, WindowHandle, wMsg, pdwCookie);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterStereoStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD")] uint* pdwCookie)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterStereoStatusEvent>(lpVtbl->RegisterStereoStatusEvent)(This, hEvent, pdwCookie);
            }
        }

        public void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_UnregisterStereoStatus>(lpVtbl->UnregisterStereoStatus)(This, dwCookie);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterOcclusionStatusWindow([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD")] uint* pdwCookie)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterOcclusionStatusWindow>(lpVtbl->RegisterOcclusionStatusWindow)(This, WindowHandle, wMsg, pdwCookie);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterOcclusionStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD")] uint* pdwCookie)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RegisterOcclusionStatusEvent>(lpVtbl->RegisterOcclusionStatusEvent)(This, hEvent, pdwCookie);
            }
        }

        public void UnregisterOcclusionStatus([NativeTypeName("UINT")] uint dwCookie)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_UnregisterOcclusionStatus>(lpVtbl->UnregisterOcclusionStatus)(This, dwCookie);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForComposition(IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForComposition>(lpVtbl->CreateSwapChainForComposition)(This, pDevice, pDesc, pRestrictToOutput, ppSwapChain);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCreationFlags>(lpVtbl->GetCreationFlags)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapterByLuid(LUID AdapterLuid, [NativeTypeName("REFIID")] Guid* riid, void** ppvAdapter)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumAdapterByLuid>(lpVtbl->EnumAdapterByLuid)(This, AdapterLuid, riid, ppvAdapter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumWarpAdapter([NativeTypeName("REFIID")] Guid* riid, void** ppvAdapter)
        {
            fixed (IDXGIFactory4* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumWarpAdapter>(lpVtbl->EnumWarpAdapter)(This, riid, ppvAdapter);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr GetPrivateData;

            public IntPtr GetParent;

            public IntPtr EnumAdapters;

            public IntPtr MakeWindowAssociation;

            public IntPtr GetWindowAssociation;

            public IntPtr CreateSwapChain;

            public IntPtr CreateSoftwareAdapter;

            public IntPtr EnumAdapters1;

            public IntPtr IsCurrent;

            public IntPtr IsWindowedStereoEnabled;

            public IntPtr CreateSwapChainForHwnd;

            public IntPtr CreateSwapChainForCoreWindow;

            public IntPtr GetSharedResourceAdapterLuid;

            public IntPtr RegisterStereoStatusWindow;

            public IntPtr RegisterStereoStatusEvent;

            public IntPtr UnregisterStereoStatus;

            public IntPtr RegisterOcclusionStatusWindow;

            public IntPtr RegisterOcclusionStatusEvent;

            public IntPtr UnregisterOcclusionStatus;

            public IntPtr CreateSwapChainForComposition;

            public IntPtr GetCreationFlags;

            public IntPtr EnumAdapterByLuid;

            public IntPtr EnumWarpAdapter;
        }
    }
}