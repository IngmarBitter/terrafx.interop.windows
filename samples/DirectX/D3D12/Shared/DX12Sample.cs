// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using TerraFX.Interop;
using static TerraFX.Interop.D3D_FEATURE_LEVEL;
using static TerraFX.Interop.D3D12_CLEAR_FLAGS;
using static TerraFX.Interop.D3D12_COMMAND_LIST_TYPE;
using static TerraFX.Interop.D3D12_DESCRIPTOR_HEAP_TYPE;
using static TerraFX.Interop.D3D12_DSV_DIMENSION;
using static TerraFX.Interop.D3D12_FENCE_FLAGS;
using static TerraFX.Interop.D3D12_HEAP_FLAGS;
using static TerraFX.Interop.D3D12_HEAP_TYPE;
using static TerraFX.Interop.D3D12_RESOURCE_FLAGS;
using static TerraFX.Interop.D3D12_RESOURCE_STATES;
using static TerraFX.Interop.DXGI_SWAP_EFFECT;
using static TerraFX.Interop.Windows;
using static TerraFX.Samples.DirectX.DXSampleHelper;

namespace TerraFX.Samples.DirectX.D3D12
{
    public abstract unsafe class DX12Sample : DXSample
    {
        private ID3D12Device* _d3dDevice;
        private IDXGIAdapter1* _dxgiAdapter;
        private IDXGIFactory4* _dxgiFactory;
        private IDXGISwapChain3* _swapChain;
        private ID3D12Resource*[] _renderTargets;
        private ID3D12Resource* _depthStencil;
        private ID3D12DescriptorHeap* _rtvHeap;
        private ID3D12DescriptorHeap* _dsvHeap;
        private ID3D12CommandQueue* _commandQueue;
        private ID3D12CommandAllocator*[] _commandAllocators;
        private D3D12_VIEWPORT _viewport;
        private RECT _scissorRect;
        private uint _rtvDescriptorSize;

        private ID3D12Fence* _fence;
        private ulong[] _fenceValues;
        private IntPtr _fenceEvent;

        private ID3D12GraphicsCommandList*[] _graphicsCommandLists;
        private ID3D12RootSignature* _rootSignature;
        private ID3D12PipelineState* _pipelineState;

        protected DX12Sample(string name) : base(name)
        {
            _renderTargets = new ID3D12Resource*[2];
            _commandAllocators = new ID3D12CommandAllocator*[2];
            _fenceValues = new ulong[2];
            _graphicsCommandLists = new ID3D12GraphicsCommandList*[2];
        }

        public ID3D12CommandAllocator* CommandAllocator => _commandAllocators[FrameIndex];

        public ID3D12CommandQueue* CommandQueue => _commandQueue;

        public ID3D12Device* D3DDevice => _d3dDevice;

        public ID3D12Resource* DepthStencil => _depthStencil;

        public ID3D12DescriptorHeap* DSVHeap => _dsvHeap;

        public IDXGIAdapter1* DxgiAdapter => _dxgiAdapter;

        public IDXGIFactory4* DxgiFactory => _dxgiFactory;

        public ID3D12Fence* Fence => _fence;

        public IntPtr FenceEvent => _fenceEvent;

        public ref ulong FenceValue => ref _fenceValues[FrameIndex];

        public ID3D12GraphicsCommandList* GraphicsCommandList => _graphicsCommandLists[FrameIndex];

        public ID3D12PipelineState* PipelineState => _pipelineState;

        public ID3D12Resource* RenderTarget => _renderTargets[FrameIndex];

        public ID3D12RootSignature* RootSignature => _rootSignature;

        public uint RTVDescriptorSize => _rtvDescriptorSize;

        public ID3D12DescriptorHeap* RTVHeap => _rtvHeap;

        public ref RECT ScissorRect => ref _scissorRect;

        public IDXGISwapChain3* SwapChain => _swapChain;

        public ref D3D12_VIEWPORT Viewport => ref _viewport;

        public override void OnDestroy()
        {
            WaitForGpu(moveToNextFrame: false);
            base.OnDestroy();
        }

        public override void OnRender()
        {
            PopulateGraphicsCommandList();
            ExecuteGraphicsCommandList();

            ThrowIfFailed(nameof(IDXGISwapChain3.Present), _swapChain->Present(SyncInterval: 1, Flags: 0));
            WaitForGpu(moveToNextFrame: true);

            void PopulateGraphicsCommandList()
            {
                WaitForGpu(moveToNextFrame: false);

                ThrowIfFailed(nameof(ID3D12CommandAllocator.Reset), CommandAllocator->Reset());
                ThrowIfFailed(nameof(ID3D12GraphicsCommandList.Reset), GraphicsCommandList->Reset(CommandAllocator, PipelineState));

                SetGraphicsCommandListState();

                TransitionForRender();

                var backgroundColor = BackgroundColor;

                var rtvHandle = new D3D12_CPU_DESCRIPTOR_HANDLE(RTVHeap->GetCPUDescriptorHandleForHeapStart(), (int)FrameIndex, RTVDescriptorSize);
                GraphicsCommandList->ClearRenderTargetView(rtvHandle, (float*)&backgroundColor, 0, null);

                var dsvHandle = DSVHeap->GetCPUDescriptorHandleForHeapStart();
                GraphicsCommandList->ClearDepthStencilView(dsvHandle, D3D12_CLEAR_FLAG_DEPTH, D3D12_MAX_DEPTH, 0, 0, null);

                GraphicsCommandList->OMSetRenderTargets(1, &rtvHandle, FALSE, &dsvHandle);

                Draw();
                TransitionForPresent();

                ThrowIfFailed(nameof(ID3D12GraphicsCommandList.Close), GraphicsCommandList->Close());
            }
        }

        protected virtual void CreateAssets()
        {
            ThrowIfFailed(nameof(ID3D12GraphicsCommandList.Close), GraphicsCommandList->Close());
            ExecuteGraphicsCommandList();
            WaitForGpu(moveToNextFrame: false);
        }

        protected virtual ID3D12Resource* CreateDepthStencil()
        {
            ID3D12Resource* depthStencil;

            var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_DEFAULT);

            var resourceDesc = D3D12_RESOURCE_DESC.Tex2D(DepthBufferFormat, (uint)Size.Width, (uint)Size.Height, mipLevels: 1);
            resourceDesc.Flags |= D3D12_RESOURCE_FLAG_ALLOW_DEPTH_STENCIL;

            var clearValue = new D3D12_CLEAR_VALUE(DepthBufferFormat, 1.0f, 0);

            var iid = IID_ID3D12Resource;
            ThrowIfFailed(nameof(ID3D12Device.CreateCommittedResource), D3DDevice->CreateCommittedResource(&heapProperties, D3D12_HEAP_FLAG_NONE, &resourceDesc, D3D12_RESOURCE_STATE_DEPTH_WRITE, &clearValue, &iid, (void**)&depthStencil));

            var dsvDesc = new D3D12_DEPTH_STENCIL_VIEW_DESC {
                Format = DepthBufferFormat,
                ViewDimension = D3D12_DSV_DIMENSION_TEXTURE2D,
            };
            D3DDevice->CreateDepthStencilView(depthStencil, &dsvDesc, DSVHeap->GetCPUDescriptorHandleForHeapStart());

            return depthStencil;
        }

        protected virtual void CreateDescriptorHeaps()
        {
            _rtvHeap = CreateRTVHeap(out _rtvDescriptorSize);
            _dsvHeap = CreateDSVHeap();

            ID3D12DescriptorHeap* CreateDSVHeap()
            {
                var dsvHeapDesc = new D3D12_DESCRIPTOR_HEAP_DESC {
                    NumDescriptors = 1,
                    Type = D3D12_DESCRIPTOR_HEAP_TYPE_DSV,
                };

                ID3D12DescriptorHeap* dsvHeap;

                var iid = IID_ID3D12DescriptorHeap;
                ThrowIfFailed(nameof(ID3D12Device.CreateDescriptorHeap), D3DDevice->CreateDescriptorHeap(&dsvHeapDesc, &iid, (void**)&dsvHeap));

                return dsvHeap;
            }

            ID3D12DescriptorHeap* CreateRTVHeap(out uint rtvDescriptorSize)
            {
                var rtvHeapDesc = new D3D12_DESCRIPTOR_HEAP_DESC {
                    NumDescriptors = FrameCount,
                    Type = D3D12_DESCRIPTOR_HEAP_TYPE_RTV,
                };

                ID3D12DescriptorHeap* rtvHeap;

                var iid = IID_ID3D12DescriptorHeap;
                ThrowIfFailed(nameof(ID3D12Device.CreateDescriptorHeap), D3DDevice->CreateDescriptorHeap(&rtvHeapDesc, &iid, (void**)&rtvHeap));

                rtvDescriptorSize = D3DDevice->GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE_RTV);
                return rtvHeap;
            }
        }

        protected override void CreateDeviceDependentResources()
        {
            _dxgiFactory = CreateDxgiFactory();
            _dxgiAdapter = GetDxgiAdapter();
            _d3dDevice = CreateD3DDevice();
            _commandQueue = CreateCommandQueue();

            CreateDescriptorHeaps();

            for (int i = 0; i < FrameCount; i++)
            {
                _commandAllocators[i] = CreateCommandAllocator();
            }

            _fence = CreateFence();
            _fenceValues = CreateFenceValues();
            _fenceEvent = CreateFenceEvent();

            _rootSignature = CreateRootSignature();
            _pipelineState = CreatePipelineState();
            _graphicsCommandLists = CreateGraphicsCommandLists();

            ThrowIfFailed(nameof(ID3D12CommandAllocator.Reset), CommandAllocator->Reset());
            ThrowIfFailed(nameof(ID3D12GraphicsCommandList.Reset), GraphicsCommandList->Reset(CommandAllocator, PipelineState));

            CreateAssets();

            ID3D12CommandAllocator* CreateCommandAllocator()
            {
                ID3D12CommandAllocator* commandAllocator;

                var iid = IID_ID3D12CommandAllocator;
                ThrowIfFailed(nameof(ID3D12Device.CreateCommandAllocator), D3DDevice->CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE_DIRECT, &iid, (void**)&commandAllocator));

                return commandAllocator;
            }

            ID3D12CommandQueue* CreateCommandQueue()
            {
                var queueDesc = new D3D12_COMMAND_QUEUE_DESC();

                ID3D12CommandQueue* commandQueue;

                var iid = IID_ID3D12CommandQueue;
                ThrowIfFailed(nameof(ID3D12Device.CreateCommandQueue), D3DDevice->CreateCommandQueue(&queueDesc, &iid, (void**)&commandQueue));

                return commandQueue;
            }

            ID3D12Device* CreateD3DDevice()
            {
                ID3D12Device* d3dDevice;

                var iid = IID_ID3D12Device;
                ThrowIfFailed(nameof(D3D12CreateDevice), D3D12CreateDevice((IUnknown*)_dxgiAdapter, D3D_FEATURE_LEVEL_11_0, &iid, (void**)&d3dDevice));

                return d3dDevice;
            }

            IDXGIFactory4* CreateDxgiFactory()
            {
                var dxgiFactoryFlags = TryEnableDebugLayer() ? DXGI_CREATE_FACTORY_DEBUG : 0u;

                IDXGIFactory4* dxgiFactory;

                var iid = IID_IDXGIFactory4;
                ThrowIfFailed(nameof(CreateDXGIFactory2), CreateDXGIFactory2(dxgiFactoryFlags, &iid, (void**)&dxgiFactory));

                return dxgiFactory;
            }

            ID3D12Fence* CreateFence()
            {
                ID3D12Fence* fence;

                var iid = IID_ID3D12Fence;
                ThrowIfFailed(nameof(ID3D12Device.CreateFence), D3DDevice->CreateFence(InitialValue: 0, D3D12_FENCE_FLAG_NONE, &iid, (void**)&fence));

                return fence;
            }

            IntPtr CreateFenceEvent()
            {
                var fenceEvent = CreateEventW(lpEventAttributes: null, bManualReset: FALSE, bInitialState: FALSE, lpName: null);

                if (fenceEvent == IntPtr.Zero)
                {
                    var hr = Marshal.GetHRForLastWin32Error();
                    Marshal.ThrowExceptionForHR(hr);
                }

                return fenceEvent;
            }

            ulong[] CreateFenceValues()
            {
                var fenceValues = new ulong[FrameCount];
                fenceValues[0] = 1;
                return fenceValues;
            }

            ID3D12GraphicsCommandList*[] CreateGraphicsCommandLists()
            {
                var graphicsCommandLists = new ID3D12GraphicsCommandList*[FrameCount];

                for (uint i = 0u; i < FrameCount; i++)
                {
                    ID3D12GraphicsCommandList* graphicsCommandList;

                    var iid = IID_ID3D12GraphicsCommandList;
                    ThrowIfFailed(nameof(ID3D12Device.CreateCommandList), D3DDevice->CreateCommandList(nodeMask: 0, D3D12_COMMAND_LIST_TYPE_DIRECT, _commandAllocators[i], PipelineState, &iid, (void**)&graphicsCommandList));

                    ThrowIfFailed(nameof(ID3D12GraphicsCommandList.Close), graphicsCommandList->Close());
                    graphicsCommandLists[i] = graphicsCommandList;
                }

                return graphicsCommandLists;
            }

            IDXGIAdapter1* GetDxgiAdapter()
            {
                if (UseWarpDevice)
                {
                    IDXGIAdapter1* adapter;

                    var iid = IID_IDXGIAdapter;
                    ThrowIfFailed(nameof(IDXGIFactory4.EnumWarpAdapter), _dxgiFactory->EnumWarpAdapter(&iid, (void**)&adapter));

                    return adapter;
                }
                else
                {
                    return GetHardwareAdapter((IDXGIFactory1*)_dxgiFactory);
                }
            }

            bool TryEnableDebugLayer()
            {
#if DEBUG
                // Enable the debug layer (requires the Graphics Tools "optional feature").
                // NOTE: Enabling the debug layer after device creation will invalidate the active device.

                using ComPtr<ID3D12Debug> debugController = null;
                var iid = IID_ID3D12Debug;

                if (SUCCEEDED(D3D12GetDebugInterface(&iid, (void**)&debugController)))
                {
                    debugController.Get()->EnableDebugLayer();
                    return true;
                }
#endif

                return false;
            }
        }

        protected virtual ID3D12PipelineState* CreatePipelineState() => null;

        protected virtual void CreateRenderTargetViews()
        {
            var rtvHandle = RTVHeap->GetCPUDescriptorHandleForHeapStart();

            for (var i = 0u; i < FrameCount; i++)
            {
                D3DDevice->CreateRenderTargetView(_renderTargets[i], pDesc: null, rtvHandle);
                rtvHandle.Offset(1, RTVDescriptorSize);
            }
        }

        protected virtual void CreateResourceViews()
        {
            FrameIndex = SwapChain->GetCurrentBackBufferIndex();

            _renderTargets = CreateRenderTargets();
            _depthStencil = CreateDepthStencil();

            CreateRenderTargetViews();

            ID3D12Resource*[] CreateRenderTargets()
            {
                var renderTargets = new ID3D12Resource*[FrameCount];
                var iid = IID_ID3D12Resource;

                for (var i = 0u; i < FrameCount; i++)
                {
                    ID3D12Resource* renderTarget;
                    ThrowIfFailed(nameof(IDXGISwapChain3.GetBuffer), SwapChain->GetBuffer(i, &iid, (void**)&renderTarget));
                    renderTargets[unchecked((int)i)] = renderTarget;
                }

                return renderTargets;
            }
        }

        protected virtual ID3D12RootSignature* CreateRootSignature() => null;

        protected override void CreateWindowSizeDependentResources()
        {
            // Wait until all previous GPU work is complete.
            WaitForGpu(moveToNextFrame: false);

            // Clear the previous window size specific content and update the tracked fence values.
            for (var i = 0u; i < FrameCount; i++)
            {
                _renderTargets[i] = null;
                _fenceValues[i] = _fenceValues[FrameIndex];
            }

            if (_swapChain != null)
            {
                ThrowIfFailed(nameof(IDXGISwapChain3.ResizeBuffers), _swapChain->ResizeBuffers(FrameCount, (uint)Size.Width, (uint)Size.Height, BackBufferFormat, 0));
            }
            else
            {
                _swapChain = CreateSwapChain();
            }

            CreateResourceViews();

            _viewport = new D3D12_VIEWPORT {
                TopLeftX = 0,
                TopLeftY = 0,
                Width = Size.Width,
                Height = Size.Height,
                MinDepth = D3D12_MIN_DEPTH,
                MaxDepth = D3D12_MAX_DEPTH
            };

            _scissorRect = new RECT {
                left = 0,
                top = 0,
                right = Size.Width,
                bottom = Size.Height
            };

            IDXGISwapChain3* CreateSwapChain()
            {
                using ComPtr<IDXGISwapChain1> swapChain = null;

                var swapChainDesc = new DXGI_SWAP_CHAIN_DESC1 {
                    BufferCount = FrameCount,
                    Width = (uint)Size.Width,
                    Height = (uint)Size.Height,
                    Format = BackBufferFormat,
                    BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT,
                    SwapEffect = DXGI_SWAP_EFFECT_FLIP_DISCARD,
                    SampleDesc = new DXGI_SAMPLE_DESC(count: 1, quality: 0),
                };

                ThrowIfFailed(nameof(IDXGIFactory4.CreateSwapChainForHwnd), DxgiFactory->CreateSwapChainForHwnd(
                    (IUnknown*)_commandQueue,         // Swap chain needs the queue so that it can force a flush on it.
                    Hwnd,
                    &swapChainDesc,
                    pFullscreenDesc: null,
                    pRestrictToOutput: null,
                    swapChain.GetAddressOf()
                ));

                IDXGISwapChain3* swapChain3;

                var iid = IID_IDXGISwapChain3;
                ThrowIfFailed(nameof(IDXGISwapChain1.QueryInterface), swapChain.Get()->QueryInterface(&iid, (void**)&swapChain3));

                return swapChain3;
            }
        }

        protected virtual void DestroyAssets()
        {
        }

        protected virtual void DestroyDescriptorHeaps()
        {
            DestroyDSVHeap();
            DestroyRTVHeap();

            void DestroyDSVHeap()
            {
                var dsvHeap = _dsvHeap;

                if (dsvHeap != null)
                {
                    _dsvHeap = null;
                    _ = dsvHeap->Release();
                }
            }

            void DestroyRTVHeap()
            {
                var rtvHeap = _rtvHeap;

                if (rtvHeap != null)
                {
                    _rtvHeap = null;
                    _ = rtvHeap->Release();
                }
            }
        }

        protected override void DestroyDeviceDependentResources()
        {
            DestroyAssets();

            DestroyGraphicsCommandLists();
            DestroyPipelineState();
            DestroyRootSignature();

            DestroyFenceEvent();
            DestroyFence();

            DestroyCommandAllocators();

            DestroyDescriptorHeaps();

            DestroyCommandQueue();
            DestroyD3DDevice();
            DestroyDxgiAdapter();
            DestroyDxgiFactory();

            void DestroyCommandAllocators()
            {
                for (var i = 0; i < _commandAllocators.Length; i++)
                {
                    var commandAllocator = _commandAllocators[i];

                    if (commandAllocator != null)
                    {
                        _commandAllocators[i] = null;
                        _ = commandAllocator->Release();
                    }
                }
            }

            void DestroyCommandQueue()
            {
                var commandQueue = _commandQueue;

                if (commandQueue != null)
                {
                    _commandQueue = null;
                    _ = commandQueue->Release();
                }
            }

            void DestroyD3DDevice()
            {
                var d3dDevice = _d3dDevice;

                if (d3dDevice != null)
                {
                    _d3dDevice = null;
                    _ = d3dDevice->Release();
                }
            }

            void DestroyDxgiAdapter()
            {
                var dxgiAdapter = _dxgiAdapter;

                if (dxgiAdapter != null)
                {
                    _dxgiAdapter = null;
                    _ = dxgiAdapter->Release();
                }
            }

            void DestroyDxgiFactory()
            {
                var dxgiFactory = _dxgiFactory;

                if (dxgiFactory != null)
                {
                    _dxgiFactory = null;
                    _ = dxgiFactory->Release();
                }
            }

            void DestroyFence()
            {
                var fence = _fence;

                if (fence != null)
                {
                    _fence = null;
                    _ = fence->Release();
                }
            }

            void DestroyFenceEvent()
            {
                var fenceEvent = _fenceEvent;

                if (fenceEvent != IntPtr.Zero)
                {
                    _fenceEvent = IntPtr.Zero;
                    _ = CloseHandle(_fenceEvent);
                }
            }

            void DestroyGraphicsCommandLists()
            {
                for (var i = 0; i < _graphicsCommandLists.Length; i++)
                {
                    var graphicsCommandList = _graphicsCommandLists[i];

                    if (graphicsCommandList != null)
                    {
                        _graphicsCommandLists[i] = null;
                        _ = graphicsCommandList->Release();
                    }
                }
            }

            void DestroyPipelineState()
            {
                var pipelineState = _pipelineState;

                if (pipelineState != null)
                {
                    _pipelineState = null;
                    _ = pipelineState->Release();
                }
            }

            void DestroyRootSignature()
            {
                var rootSignature = _rootSignature;

                if (rootSignature != null)
                {
                    _rootSignature = null;
                    _ = rootSignature->Release();
                }
            }
        }

        protected virtual void DestroyResourceViews()
        {
            DestroyDepthStencil();
            DestroyRenderTargets();

            void DestroyDepthStencil()
            {
                var depthStencil = _depthStencil;

                if (depthStencil != null)
                {
                    _depthStencil = null;
                    _ = depthStencil->Release();
                }
            }

            void DestroyRenderTargets()
            {
                for (var i = 0; i < _renderTargets.Length; i++)
                {
                    var renderTarget = _renderTargets[i];

                    if (renderTarget != null)
                    {
                        _renderTargets[i] = null;
                        _ = renderTarget->Release();
                    }
                }
            }
        }

        protected override void DestroyWindowSizeDependentResources()
        {
            DestroyResourceViews();
            DestroySwapChain();

            void DestroySwapChain()
            {
                var swapChain = _swapChain;

                if (swapChain != null)
                {
                    _swapChain = null;
                    _ = swapChain->Release();
                }
            }
        }

        protected abstract void Draw();

        protected virtual void SetGraphicsCommandListState()
        {
            GraphicsCommandList->SetGraphicsRootSignature(RootSignature);

            fixed (D3D12_VIEWPORT* viewport = &Viewport)
            {
                GraphicsCommandList->RSSetViewports(1, viewport);
            }

            fixed (RECT* scissorRect = &ScissorRect)
            {
                GraphicsCommandList->RSSetScissorRects(1, scissorRect);
            }
        }

        protected virtual void TransitionForRender()
        {
            var barrier = D3D12_RESOURCE_BARRIER.InitTransition(RenderTarget, D3D12_RESOURCE_STATE_PRESENT, D3D12_RESOURCE_STATE_RENDER_TARGET);
            GraphicsCommandList->ResourceBarrier(1, &barrier);
        }

        protected virtual void TransitionForPresent()
        {
            var barrier = D3D12_RESOURCE_BARRIER.InitTransition(RenderTarget, D3D12_RESOURCE_STATE_RENDER_TARGET, D3D12_RESOURCE_STATE_PRESENT);
            GraphicsCommandList->ResourceBarrier(1, &barrier);
        }

        protected override unsafe bool SupportsRequiredDirect3DVersion(IDXGIAdapter1* adapter)
        {
            var iid = IID_ID3D12Device;
            return SUCCEEDED(D3D12CreateDevice((IUnknown*)adapter, D3D_FEATURE_LEVEL_11_0, &iid, null));
        }

        private void ExecuteGraphicsCommandList()
        {
            const int CommandListsCount = 1;
            var ppCommandLists = stackalloc ID3D12CommandList*[CommandListsCount] {
                (ID3D12CommandList*)GraphicsCommandList,
            };
            CommandQueue->ExecuteCommandLists(CommandListsCount, ppCommandLists);
        }

        private void WaitForGpu(bool moveToNextFrame)
        {
            // Schedule a Signal command in the queue.
            ThrowIfFailed(nameof(ID3D12CommandQueue.Signal), CommandQueue->Signal(Fence, FenceValue));


            if (Fence->GetCompletedValue() < FenceValue)
            {
                // Wait until the fence has been crossed.
                ThrowIfFailed(nameof(ID3D12Fence.SetEventOnCompletion), Fence->SetEventOnCompletion(FenceValue, FenceEvent));
                _ = WaitForSingleObjectEx(FenceEvent, INFINITE, FALSE);
            }

            if (moveToNextFrame)
            {
                FrameIndex = SwapChain->GetCurrentBackBufferIndex();
            }

            // Increment the fence value for the current frame.
            FenceValue++;
        }
    }
}
