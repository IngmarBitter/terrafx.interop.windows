// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DXSampleHelper.h in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using TerraFX.Interop;
using static TerraFX.Interop.Windows;

namespace TerraFX.Samples.DirectX
{
    public static unsafe class DXSampleHelper
    {
        public static void ThrowIfFailed(string _, HRESULT hr)
        {
            if (FAILED(hr))
            {
                Marshal.ThrowExceptionForHR(hr);
            }
        }

        public static string GetAssetsPath()
        {
            var entryAssembly = Assembly.GetEntryAssembly()!;
            return Path.GetDirectoryName(entryAssembly.Location)!;
        }

        public static byte[] ReadDataFromFile(string filename)
        {
            byte[] data;

            using (var fileReader = File.OpenRead(filename))
            {
                var endOfFile = fileReader.Length;

                if (endOfFile > int.MaxValue)
                {
                    throw new IOException();
                }

                var size = (int)endOfFile;
                data = new byte[size];

                _ = fileReader.Read(data, 0, size);
            }

            return data;
        }

        [Conditional("DEBUG")]
        public static void SetName(ID3D12Object* pObject, string name)
        {
            fixed (char* pName = name)
            {
                _ = pObject->SetName((ushort*)pName);
            }
        }

        [Conditional("DEBUG")]
        public static void SetNameIndexed(ID3D12Object* pObject, string name, uint index)
        {
            var fullName = $"{name}[{index}]";
            SetName(pObject, fullName);
        }
    }
}
