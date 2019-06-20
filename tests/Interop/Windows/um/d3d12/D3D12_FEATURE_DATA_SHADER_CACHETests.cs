// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D12_FEATURE_DATA_SHADER_CACHE" /> struct.</summary>
    public static class D3D12_FEATURE_DATA_SHADER_CACHETests
    {
        /// <summary>Validates that the layout of the <see cref="D3D12_FEATURE_DATA_SHADER_CACHE" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D12_FEATURE_DATA_SHADER_CACHE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="D3D12_FEATURE_DATA_SHADER_CACHE" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<D3D12_FEATURE_DATA_SHADER_CACHE>(), Is.EqualTo(4));
        }
    }
}
