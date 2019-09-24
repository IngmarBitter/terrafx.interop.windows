// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_PIXEL_FORMAT" /> struct.</summary>
    public static class D2D1_PIXEL_FORMATTests
    {
        /// <summary>Validates that the layout of the <see cref="D2D1_PIXEL_FORMAT" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_PIXEL_FORMAT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="D2D1_PIXEL_FORMAT" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_PIXEL_FORMAT>(), Is.EqualTo(8));
        }
    }
}