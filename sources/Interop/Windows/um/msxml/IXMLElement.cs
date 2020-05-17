// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3F7F31AC-E15F-11D0-9C25-00C04FC99C8E")]
    public unsafe partial struct IXMLElement
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IXMLElement* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IXMLElement* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IXMLElement* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfoCount(IXMLElement* pThis, [NativeTypeName("UINT *")] uint* pctinfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfo(IXMLElement* pThis, [NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetIDsOfNames(IXMLElement* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Invoke(IXMLElement* pThis, [NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_tagName(IXMLElement* pThis, [NativeTypeName("BSTR *")] ushort** p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_tagName(IXMLElement* pThis, [NativeTypeName("BSTR")] ushort* p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_parent(IXMLElement* pThis, [NativeTypeName("IXMLElement **")] IXMLElement** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _setAttribute(IXMLElement* pThis, [NativeTypeName("BSTR")] ushort* strPropertyName, VARIANT PropertyValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _getAttribute(IXMLElement* pThis, [NativeTypeName("BSTR")] ushort* strPropertyName, [NativeTypeName("VARIANT *")] VARIANT* PropertyValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _removeAttribute(IXMLElement* pThis, [NativeTypeName("BSTR")] ushort* strPropertyName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_children(IXMLElement* pThis, [NativeTypeName("IXMLElementCollection **")] IXMLElementCollection** pp);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_type(IXMLElement* pThis, [NativeTypeName("long *")] int* plType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_text(IXMLElement* pThis, [NativeTypeName("BSTR *")] ushort** p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_text(IXMLElement* pThis, [NativeTypeName("BSTR")] ushort* p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _addChild(IXMLElement* pThis, [NativeTypeName("IXMLElement *")] IXMLElement* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _removeChild(IXMLElement* pThis, [NativeTypeName("IXMLElement *")] IXMLElement* pChildElem);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IXMLElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IXMLElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IXMLElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoCount>(lpVtbl->GetTypeInfoCount)((IXMLElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)((IXMLElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIDsOfNames>(lpVtbl->GetIDsOfNames)((IXMLElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return Marshal.GetDelegateForFunctionPointer<_Invoke>(lpVtbl->Invoke)((IXMLElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_tagName([NativeTypeName("BSTR *")] ushort** p)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_tagName>(lpVtbl->get_tagName)((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_tagName([NativeTypeName("BSTR")] ushort* p)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_tagName>(lpVtbl->put_tagName)((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parent([NativeTypeName("IXMLElement **")] IXMLElement** ppParent)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_parent>(lpVtbl->get_parent)((IXMLElement*)Unsafe.AsPointer(ref this), ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, VARIANT PropertyValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_setAttribute>(lpVtbl->setAttribute)((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] ushort* strPropertyName, [NativeTypeName("VARIANT *")] VARIANT* PropertyValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_getAttribute>(lpVtbl->getAttribute)((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName, PropertyValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] ushort* strPropertyName)
        {
            return Marshal.GetDelegateForFunctionPointer<_removeAttribute>(lpVtbl->removeAttribute)((IXMLElement*)Unsafe.AsPointer(ref this), strPropertyName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_children([NativeTypeName("IXMLElementCollection **")] IXMLElementCollection** pp)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_children>(lpVtbl->get_children)((IXMLElement*)Unsafe.AsPointer(ref this), pp);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("long *")] int* plType)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_type>(lpVtbl->get_type)((IXMLElement*)Unsafe.AsPointer(ref this), plType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** p)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_text>(lpVtbl->get_text)((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* p)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_text>(lpVtbl->put_text)((IXMLElement*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int addChild([NativeTypeName("IXMLElement *")] IXMLElement* pChildElem, [NativeTypeName("long")] int lIndex, [NativeTypeName("long")] int lReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_addChild>(lpVtbl->addChild)((IXMLElement*)Unsafe.AsPointer(ref this), pChildElem, lIndex, lReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLElement *")] IXMLElement* pChildElem)
        {
            return Marshal.GetDelegateForFunctionPointer<_removeChild>(lpVtbl->removeChild)((IXMLElement*)Unsafe.AsPointer(ref this), pChildElem);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public IntPtr GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public IntPtr GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public IntPtr Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_tagName;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public IntPtr put_tagName;

            [NativeTypeName("HRESULT (IXMLElement **) __attribute__((stdcall))")]
            public IntPtr get_parent;

            [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
            public IntPtr setAttribute;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public IntPtr getAttribute;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public IntPtr removeAttribute;

            [NativeTypeName("HRESULT (IXMLElementCollection **) __attribute__((stdcall))")]
            public IntPtr get_children;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public IntPtr get_type;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public IntPtr put_text;

            [NativeTypeName("HRESULT (IXMLElement *, long, long) __attribute__((stdcall))")]
            public IntPtr addChild;

            [NativeTypeName("HRESULT (IXMLElement *) __attribute__((stdcall))")]
            public IntPtr removeChild;
        }
    }
}