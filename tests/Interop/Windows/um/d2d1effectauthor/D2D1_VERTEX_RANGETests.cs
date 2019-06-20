// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_VERTEX_RANGE" /> struct.</summary>
    public static class D2D1_VERTEX_RANGETests
    {
        /// <summary>Validates that the layout of the <see cref="D2D1_VERTEX_RANGE" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_VERTEX_RANGE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="D2D1_VERTEX_RANGE" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_VERTEX_RANGE>(), Is.EqualTo(8));
        }
    }
}
