// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7E9FDA85-6C92-4053-BC47-7AE3530DB4D3")]
    public unsafe partial struct IDWriteFontSet1
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontSet1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontSet1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontSet1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontCount(IDWriteFontSet1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFaceReference(IDWriteFontSet1* pThis, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindFontFaceReference(IDWriteFontSet1* pThis, [NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("UINT32 *")] uint* listIndex, [NativeTypeName("BOOL *")] int* exists);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindFontFace(IDWriteFontSet1* pThis, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("UINT32 *")] uint* listIndex, [NativeTypeName("BOOL *")] int* exists);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertyValues(IDWriteFontSet1* pThis, [NativeTypeName("UINT32")] uint listIndex, DWRITE_FONT_PROPERTY_ID propertyId, [NativeTypeName("BOOL *")] int* exists, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** values);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertyValues1(IDWriteFontSet1* pThis, DWRITE_FONT_PROPERTY_ID propertyID, [NativeTypeName("const WCHAR *")] ushort* preferredLocaleNames, [NativeTypeName("IDWriteStringList **")] IDWriteStringList** values);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertyValues2(IDWriteFontSet1* pThis, DWRITE_FONT_PROPERTY_ID propertyID, [NativeTypeName("IDWriteStringList **")] IDWriteStringList** values);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertyOccurrenceCount(IDWriteFontSet1* pThis, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* property, [NativeTypeName("UINT32 *")] uint* propertyOccurrenceCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMatchingFonts(IDWriteFontSet1* pThis, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** filteredSet);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMatchingFonts1(IDWriteFontSet1* pThis, [NativeTypeName("const WCHAR *")] ushort* familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** filteredSet);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMatchingFonts2(IDWriteFontSet1* pThis, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* fontProperty, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** matchingFonts);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFirstFontResources(IDWriteFontSet1* pThis, [NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** filteredFontSet);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFilteredFonts(IDWriteFontSet1* pThis, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, [NativeTypeName("BOOL")] int selectAnyProperty, [NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** filteredFontSet);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFilteredFonts1(IDWriteFontSet1* pThis, [NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, [NativeTypeName("BOOL")] int selectAnyRange, [NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** filteredFontSet);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFilteredFonts2(IDWriteFontSet1* pThis, [NativeTypeName("const UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint indexCount, [NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** filteredFontSet);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFilteredFontIndices(IDWriteFontSet1* pThis, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, [NativeTypeName("BOOL")] int selectAnyProperty, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFilteredFontIndices1(IDWriteFontSet1* pThis, [NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, [NativeTypeName("BOOL")] int selectAnyRange, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontAxisRanges(IDWriteFontSet1* pThis, [NativeTypeName("DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontAxisRanges1(IDWriteFontSet1* pThis, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFaceReference1(IDWriteFontSet1* pThis, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFontFaceReference1 **")] IDWriteFontFaceReference1** fontFaceReference);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontResource(IDWriteFontSet1* pThis, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFontResource **")] IDWriteFontResource** fontResource);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFace(IDWriteFontSet1* pThis, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFontFace5 **")] IDWriteFontFace5** fontFace);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_LOCALITY _GetFontLocality(IDWriteFontSet1* pThis, [NativeTypeName("UINT32")] uint listIndex);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteFontSet1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteFontSet1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontCount>(lpVtbl->GetFontCount)((IDWriteFontSet1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFaceReference>(lpVtbl->GetFontFaceReference)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFontFaceReference([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("UINT32 *")] uint* listIndex, [NativeTypeName("BOOL *")] int* exists)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindFontFaceReference>(lpVtbl->FindFontFaceReference)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontFaceReference, listIndex, exists);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFontFace([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("UINT32 *")] uint* listIndex, [NativeTypeName("BOOL *")] int* exists)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindFontFace>(lpVtbl->FindFontFace)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontFace, listIndex, exists);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValues([NativeTypeName("UINT32")] uint listIndex, DWRITE_FONT_PROPERTY_ID propertyId, [NativeTypeName("BOOL *")] int* exists, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** values)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertyValues>(lpVtbl->GetPropertyValues)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, propertyId, exists, values);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, [NativeTypeName("const WCHAR *")] ushort* preferredLocaleNames, [NativeTypeName("IDWriteStringList **")] IDWriteStringList** values)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertyValues1>(lpVtbl->GetPropertyValues1)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), propertyID, preferredLocaleNames, values);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, [NativeTypeName("IDWriteStringList **")] IDWriteStringList** values)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertyValues2>(lpVtbl->GetPropertyValues2)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), propertyID, values);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyOccurrenceCount([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* property, [NativeTypeName("UINT32 *")] uint* propertyOccurrenceCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertyOccurrenceCount>(lpVtbl->GetPropertyOccurrenceCount)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), property, propertyOccurrenceCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** filteredSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMatchingFonts>(lpVtbl->GetMatchingFonts)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), properties, propertyCount, filteredSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** filteredSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMatchingFonts1>(lpVtbl->GetMatchingFonts1)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), familyName, fontWeight, fontStretch, fontStyle, filteredSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* fontProperty, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** matchingFonts)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMatchingFonts2>(lpVtbl->GetMatchingFonts2)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontProperty, fontAxisValues, fontAxisValueCount, matchingFonts);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFirstFontResources([NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** filteredFontSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFirstFontResources>(lpVtbl->GetFirstFontResources)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), filteredFontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFilteredFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, [NativeTypeName("BOOL")] int selectAnyProperty, [NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** filteredFontSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFilteredFonts>(lpVtbl->GetFilteredFonts)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, filteredFontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFilteredFonts([NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, [NativeTypeName("BOOL")] int selectAnyRange, [NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** filteredFontSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFilteredFonts1>(lpVtbl->GetFilteredFonts1)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, filteredFontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFilteredFonts([NativeTypeName("const UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint indexCount, [NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** filteredFontSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFilteredFonts2>(lpVtbl->GetFilteredFonts2)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), indices, indexCount, filteredFontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFilteredFontIndices([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, [NativeTypeName("BOOL")] int selectAnyProperty, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFilteredFontIndices>(lpVtbl->GetFilteredFontIndices)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFilteredFontIndices([NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, [NativeTypeName("BOOL")] int selectAnyRange, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFilteredFontIndices1>(lpVtbl->GetFilteredFontIndices1)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, indices, maxIndexCount, actualIndexCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisRanges([NativeTypeName("DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontAxisRanges>(lpVtbl->GetFontAxisRanges)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisRanges([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontAxisRanges1>(lpVtbl->GetFontAxisRanges1)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFontFaceReference1 **")] IDWriteFontFaceReference1** fontFaceReference)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFaceReference1>(lpVtbl->GetFontFaceReference1)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontResource([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFontResource **")] IDWriteFontResource** fontResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontResource>(lpVtbl->CreateFontResource)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFontFace5 **")] IDWriteFontFace5** fontFace)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFace>(lpVtbl->CreateFontFace)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontFace);
        }

        public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontLocality>(lpVtbl->GetFontLocality)((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontCount;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFaceReference;

            [NativeTypeName("HRESULT (IDWriteFontFaceReference *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FindFontFaceReference;

            [NativeTypeName("HRESULT (IDWriteFontFace *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FindFontFace;

            [NativeTypeName("HRESULT (UINT32, DWRITE_FONT_PROPERTY_ID, BOOL *, IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPropertyValues;

            [NativeTypeName("HRESULT (DWRITE_FONT_PROPERTY_ID, const WCHAR *, IDWriteStringList **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPropertyValues1;

            [NativeTypeName("HRESULT (DWRITE_FONT_PROPERTY_ID, IDWriteStringList **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPropertyValues2;

            [NativeTypeName("HRESULT (const DWRITE_FONT_PROPERTY *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPropertyOccurrenceCount;

            [NativeTypeName("HRESULT (const DWRITE_FONT_PROPERTY *, UINT32, IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMatchingFonts;

            [NativeTypeName("HRESULT (const WCHAR *, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMatchingFonts1;

            [NativeTypeName("HRESULT (const DWRITE_FONT_PROPERTY *, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMatchingFonts2;

            [NativeTypeName("HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFirstFontResources;

            [NativeTypeName("HRESULT (const DWRITE_FONT_PROPERTY *, UINT32, BOOL, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFilteredFonts;

            [NativeTypeName("HRESULT (const DWRITE_FONT_AXIS_RANGE *, UINT32, BOOL, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFilteredFonts1;

            [NativeTypeName("HRESULT (const UINT32 *, UINT32, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFilteredFonts2;

            [NativeTypeName("HRESULT (const DWRITE_FONT_PROPERTY *, UINT32, BOOL, UINT32 *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFilteredFontIndices;

            [NativeTypeName("HRESULT (const DWRITE_FONT_AXIS_RANGE *, UINT32, BOOL, UINT32 *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFilteredFontIndices1;

            [NativeTypeName("HRESULT (DWRITE_FONT_AXIS_RANGE *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontAxisRanges;

            [NativeTypeName("HRESULT (UINT32, DWRITE_FONT_AXIS_RANGE *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontAxisRanges1;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontFaceReference1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFaceReference1;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontResource **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontResource;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontFace5 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFace;

            [NativeTypeName("DWRITE_LOCALITY (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontLocality;
        }
    }
}