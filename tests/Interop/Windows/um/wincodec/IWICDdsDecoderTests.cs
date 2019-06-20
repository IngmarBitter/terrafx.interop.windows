// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.WinCodec;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICDdsDecoder" /> struct.</summary>
    public static class IWICDdsDecoderTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICDdsDecoder" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICDdsDecoder).GUID, Is.EqualTo(IID_IWICDdsDecoder));
        }

        /// <summary>Validates that the layout of the <see cref="IWICDdsDecoder" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICDdsDecoder).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IWICDdsDecoder" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IWICDdsDecoder>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IWICDdsDecoder>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IWICDdsDecoder.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IWICDdsDecoder" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IWICDdsDecoder.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IWICDdsDecoder" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IWICDdsDecoder.Vtbl>(), Is.EqualTo(40));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IWICDdsDecoder.Vtbl>(), Is.EqualTo(20));
                }
            }
        }
    }
}
