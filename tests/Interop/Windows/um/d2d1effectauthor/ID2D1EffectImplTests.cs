// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.D2D1;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID2D1EffectImpl" /> struct.</summary>
    public static class ID2D1EffectImplTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID2D1EffectImpl" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ID2D1EffectImpl).GUID, Is.EqualTo(IID_ID2D1EffectImpl));
        }

        /// <summary>Validates that the layout of the <see cref="ID2D1EffectImpl" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID2D1EffectImpl).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID2D1EffectImpl" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID2D1EffectImpl>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID2D1EffectImpl>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID2D1EffectImpl.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID2D1EffectImpl" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID2D1EffectImpl.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID2D1EffectImpl" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID2D1EffectImpl.Vtbl>(), Is.EqualTo(48));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID2D1EffectImpl.Vtbl>(), Is.EqualTo(24));
                }
            }
        }
    }
}
