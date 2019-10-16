// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class WinCodec
    {
        public static readonly Guid GUID_MetadataFormatUnknown = new Guid(0xA45E592F, 0x9078, 0x4A7C, 0xAD, 0xB5, 0x4E, 0xDC, 0x4F, 0xD6, 0x1B, 0x1F);

        public static readonly Guid GUID_MetadataFormatIfd = new Guid(0x537396C6, 0x2D8A, 0x4BB6, 0x9B, 0xF8, 0x2F, 0x0A, 0x8E, 0x2A, 0x3A, 0xDF);

        public static readonly Guid GUID_MetadataFormatSubIfd = new Guid(0x58A2E128, 0x2DB9, 0x4E57, 0xBB, 0x14, 0x51, 0x77, 0x89, 0x1E, 0xD3, 0x31);

        public static readonly Guid GUID_MetadataFormatExif = new Guid(0x1C3C4F9D, 0xB84A, 0x467D, 0x94, 0x93, 0x36, 0xCF, 0xBD, 0x59, 0xEA, 0x57);

        public static readonly Guid GUID_MetadataFormatGps = new Guid(0x7134AB8A, 0x9351, 0x44AD, 0xAF, 0x62, 0x44, 0x8D, 0xB6, 0xB5, 0x02, 0xEC);

        public static readonly Guid GUID_MetadataFormatInterop = new Guid(0xED686F8E, 0x681F, 0x4C8B, 0xBD, 0x41, 0xA8, 0xAD, 0xDB, 0xF6, 0xB3, 0xFC);

        public static readonly Guid GUID_MetadataFormatApp0 = new Guid(0x79007028, 0x268D, 0x45D6, 0xA3, 0xC2, 0x35, 0x4E, 0x6A, 0x50, 0x4B, 0xC9);

        public static readonly Guid GUID_MetadataFormatApp1 = new Guid(0x8FD3DFC3, 0xF951, 0x492B, 0x81, 0x7F, 0x69, 0xC2, 0xE6, 0xD9, 0xA5, 0xB0);

        public static readonly Guid GUID_MetadataFormatApp13 = new Guid(0x326556A2, 0xF502, 0x4354, 0x9C, 0xC0, 0x8E, 0x3F, 0x48, 0xEA, 0xF6, 0xB5);

        public static readonly Guid GUID_MetadataFormatIPTC = new Guid(0x4FAB0914, 0xE129, 0x4087, 0xA1, 0xD1, 0xBC, 0x81, 0x2D, 0x45, 0xA7, 0xB5);

        public static readonly Guid GUID_MetadataFormatIRB = new Guid(0x16100D66, 0x8570, 0x4BB9, 0xB9, 0x2D, 0xFD, 0xA4, 0xB2, 0x3E, 0xCE, 0x67);

        public static readonly Guid GUID_MetadataFormat8BIMIPTC = new Guid(0x0010568C, 0x0852, 0x4E6A, 0xB1, 0x91, 0x5C, 0x33, 0xAC, 0x5B, 0x04, 0x30);

        public static readonly Guid GUID_MetadataFormat8BIMResolutionInfo = new Guid(0x739F305D, 0x81DB, 0x43CB, 0xAC, 0x5E, 0x55, 0x01, 0x3E, 0xF9, 0xF0, 0x03);

        public static readonly Guid GUID_MetadataFormat8BIMIPTCDigest = new Guid(0x1CA32285, 0x9CCD, 0x4786, 0x8B, 0xD8, 0x79, 0x53, 0x9D, 0xB6, 0xA0, 0x06);

        public static readonly Guid GUID_MetadataFormatXMP = new Guid(0xBB5ACC38, 0xF216, 0x4CEC, 0xA6, 0xC5, 0x5F, 0x6E, 0x73, 0x97, 0x63, 0xA9);

        public static readonly Guid GUID_MetadataFormatThumbnail = new Guid(0x243DCEE9, 0x8703, 0x40EE, 0x8E, 0xF0, 0x22, 0xA6, 0x00, 0xB8, 0x05, 0x8C);

        public static readonly Guid GUID_MetadataFormatChunktEXt = new Guid(0x568D8936, 0xC0A9, 0x4923, 0x90, 0x5D, 0xDF, 0x2B, 0x38, 0x23, 0x8F, 0xBC);

        public static readonly Guid GUID_MetadataFormatXMPStruct = new Guid(0x22383CF1, 0xED17, 0x4E2E, 0xAF, 0x17, 0xD8, 0x5B, 0x8F, 0x6B, 0x30, 0xD0);

        public static readonly Guid GUID_MetadataFormatXMPBag = new Guid(0x833CCA5F, 0xDCB7, 0x4516, 0x80, 0x6F, 0x65, 0x96, 0xAB, 0x26, 0xDC, 0xE4);

        public static readonly Guid GUID_MetadataFormatXMPSeq = new Guid(0x63E8DF02, 0xEB6C, 0x456C, 0xA2, 0x24, 0xB2, 0x5E, 0x79, 0x4F, 0xD6, 0x48);

        public static readonly Guid GUID_MetadataFormatXMPAlt = new Guid(0x7B08A675, 0x91AA, 0x481B, 0xA7, 0x98, 0x4D, 0xA9, 0x49, 0x08, 0x61, 0x3B);

        public static readonly Guid GUID_MetadataFormatLSD = new Guid(0xE256031E, 0x6299, 0x4929, 0xB9, 0x8D, 0x5A, 0xC8, 0x84, 0xAF, 0xBA, 0x92);

        public static readonly Guid GUID_MetadataFormatIMD = new Guid(0xBD2BB086, 0x4D52, 0x48DD, 0x96, 0x77, 0xDB, 0x48, 0x3E, 0x85, 0xAE, 0x8F);

        public static readonly Guid GUID_MetadataFormatGCE = new Guid(0x2A25CAD8, 0xDEEB, 0x4C69, 0xA7, 0x88, 0x0E, 0xC2, 0x26, 0x6D, 0xCA, 0xFD);

        public static readonly Guid GUID_MetadataFormatAPE = new Guid(0x2E043DC2, 0xC967, 0x4E05, 0x87, 0x5E, 0x61, 0x8B, 0xF6, 0x7E, 0x85, 0xC3);

        public static readonly Guid GUID_MetadataFormatJpegChrominance = new Guid(0xF73D0DCF, 0xCEC6, 0x4F85, 0x9B, 0x0E, 0x1C, 0x39, 0x56, 0xB1, 0xBE, 0xF7);

        public static readonly Guid GUID_MetadataFormatJpegLuminance = new Guid(0x86908007, 0xEDFC, 0x4860, 0x8D, 0x4B, 0x4E, 0xE6, 0xE8, 0x3E, 0x60, 0x58);

        public static readonly Guid GUID_MetadataFormatJpegComment = new Guid(0x220E5F33, 0xAFD3, 0x474E, 0x9D, 0x31, 0x7D, 0x4F, 0xE7, 0x30, 0xF5, 0x57);

        public static readonly Guid GUID_MetadataFormatGifComment = new Guid(0xC4B6E0E0, 0xCFB4, 0x4AD3, 0xAB, 0x33, 0x9A, 0xAD, 0x23, 0x55, 0xA3, 0x4A);

        public static readonly Guid GUID_MetadataFormatChunkgAMA = new Guid(0xF00935A5, 0x1D5D, 0x4CD1, 0x81, 0xB2, 0x93, 0x24, 0xD7, 0xEC, 0xA7, 0x81);

        public static readonly Guid GUID_MetadataFormatChunkbKGD = new Guid(0xE14D3571, 0x6B47, 0x4DEA, 0xB6, 0x0A, 0x87, 0xCE, 0x0A, 0x78, 0xDF, 0xB7);

        public static readonly Guid GUID_MetadataFormatChunkiTXt = new Guid(0xC2BEC729, 0x0B68, 0x4B77, 0xAA, 0x0E, 0x62, 0x95, 0xA6, 0xAC, 0x18, 0x14);

        public static readonly Guid GUID_MetadataFormatChunkcHRM = new Guid(0x9DB3655B, 0x2842, 0x44B3, 0x80, 0x67, 0x12, 0xE9, 0xB3, 0x75, 0x55, 0x6A);

        public static readonly Guid GUID_MetadataFormatChunkhIST = new Guid(0xC59A82DA, 0xDB74, 0x48A4, 0xBD, 0x6A, 0xB6, 0x9C, 0x49, 0x31, 0xEF, 0x95);

        public static readonly Guid GUID_MetadataFormatChunkiCCP = new Guid(0xEB4349AB, 0xB685, 0x450F, 0x91, 0xB5, 0xE8, 0x02, 0xE8, 0x92, 0x53, 0x6C);

        public static readonly Guid GUID_MetadataFormatChunksRGB = new Guid(0xC115FD36, 0xCC6F, 0x4E3F, 0x83, 0x63, 0x52, 0x4B, 0x87, 0xC6, 0xB0, 0xD9);

        public static readonly Guid GUID_MetadataFormatChunktIME = new Guid(0x6B00AE2D, 0xE24B, 0x460A, 0x98, 0xB6, 0x87, 0x8B, 0xD0, 0x30, 0x72, 0xFD);

        public static readonly Guid GUID_MetadataFormatDds = new Guid(0x4A064603, 0x8C33, 0x4E60, 0x9C, 0x29, 0x13, 0x62, 0x31, 0x70, 0x2D, 0x08);

        public static readonly Guid GUID_MetadataFormatHeif = new Guid(0x817EF3E1, 0x1288, 0x45F4, 0xA8, 0x52, 0x26, 0x0D, 0x9E, 0x7C, 0xCE, 0x83);

        public static readonly Guid GUID_MetadataFormatHeifHDR = new Guid(0x568B8D8A, 0x1E65, 0x438C, 0x89, 0x68, 0xD6, 0xE, 0x10, 0x12, 0xBE, 0xB9);

        public static readonly Guid GUID_MetadataFormatWebpANIM = new Guid(0x6DC4FDA6, 0x78E6, 0x4102, 0xAE, 0x35, 0xBC, 0xFA, 0x1E, 0xDC, 0xC7, 0x8B);

        public static readonly Guid GUID_MetadataFormatWebpANMF = new Guid(0x43C105EE, 0xB93B, 0x4ABB, 0xB0, 0x3, 0xA0, 0x8C, 0xD, 0x87, 0x4, 0x71);

        public static readonly Guid CLSID_WICUnknownMetadataReader = new Guid(0x699745C2, 0x5066, 0x4B82, 0xA8, 0xE3, 0xD4, 0x04, 0x78, 0xDB, 0xEC, 0x8C);

        public static readonly Guid CLSID_WICUnknownMetadataWriter = new Guid(0xA09CCA86, 0x27BA, 0x4F39, 0x90, 0x53, 0x12, 0x1F, 0xA4, 0xDC, 0x08, 0xFC);

        public static readonly Guid CLSID_WICApp0MetadataWriter = new Guid(0xF3C633A2, 0x46C8, 0x498E, 0x8F, 0xBB, 0xCC, 0x6F, 0x72, 0x1B, 0xBC, 0xDE);

        public static readonly Guid CLSID_WICApp0MetadataReader = new Guid(0x43324B33, 0xA78F, 0x480F, 0x91, 0x11, 0x96, 0x38, 0xAA, 0xCC, 0xC8, 0x32);

        public static readonly Guid CLSID_WICApp1MetadataWriter = new Guid(0xEE366069, 0x1832, 0x420F, 0xB3, 0x81, 0x04, 0x79, 0xAD, 0x06, 0x6F, 0x19);

        public static readonly Guid CLSID_WICApp1MetadataReader = new Guid(0xDDE33513, 0x774E, 0x4BCD, 0xAE, 0x79, 0x02, 0xF4, 0xAD, 0xFE, 0x62, 0xFC);

        public static readonly Guid CLSID_WICApp13MetadataWriter = new Guid(0x7B19A919, 0xA9D6, 0x49E5, 0xBD, 0x45, 0x02, 0xC3, 0x4E, 0x4E, 0x4C, 0xD5);

        public static readonly Guid CLSID_WICApp13MetadataReader = new Guid(0xAA7E3C50, 0x864C, 0x4604, 0xBC, 0x04, 0x8B, 0x0B, 0x76, 0xE6, 0x37, 0xF6);

        public static readonly Guid CLSID_WICIfdMetadataReader = new Guid(0x8F914656, 0x9D0A, 0x4EB2, 0x90, 0x19, 0x0B, 0xF9, 0x6D, 0x8A, 0x9E, 0xE6);

        public static readonly Guid CLSID_WICIfdMetadataWriter = new Guid(0xB1EBFC28, 0xC9BD, 0x47A2, 0x8D, 0x33, 0xB9, 0x48, 0x76, 0x97, 0x77, 0xA7);

        public static readonly Guid CLSID_WICSubIfdMetadataReader = new Guid(0x50D42F09, 0xECD1, 0x4B41, 0xB6, 0x5D, 0xDA, 0x1F, 0xDA, 0xA7, 0x56, 0x63);

        public static readonly Guid CLSID_WICSubIfdMetadataWriter = new Guid(0x8ADE5386, 0x8E9B, 0x4F4C, 0xAC, 0xF2, 0xF0, 0x00, 0x87, 0x06, 0xB2, 0x38);

        public static readonly Guid CLSID_WICExifMetadataReader = new Guid(0xD9403860, 0x297F, 0x4A49, 0xBF, 0x9B, 0x77, 0x89, 0x81, 0x50, 0xA4, 0x42);

        public static readonly Guid CLSID_WICExifMetadataWriter = new Guid(0xC9A14CDA, 0xC339, 0x460B, 0x90, 0x78, 0xD4, 0xDE, 0xBC, 0xFA, 0xBE, 0x91);

        public static readonly Guid CLSID_WICGpsMetadataReader = new Guid(0x3697790B, 0x223B, 0x484E, 0x99, 0x25, 0xC4, 0x86, 0x92, 0x18, 0xF1, 0x7A);

        public static readonly Guid CLSID_WICGpsMetadataWriter = new Guid(0xCB8C13E4, 0x62B5, 0x4C96, 0xA4, 0x8B, 0x6B, 0xA6, 0xAC, 0xE3, 0x9C, 0x76);

        public static readonly Guid CLSID_WICInteropMetadataReader = new Guid(0xB5C8B898, 0x0074, 0x459F, 0xB7, 0x00, 0x86, 0x0D, 0x46, 0x51, 0xEA, 0x14);

        public static readonly Guid CLSID_WICInteropMetadataWriter = new Guid(0x122EC645, 0xCD7E, 0x44D8, 0xB1, 0x86, 0x2C, 0x8C, 0x20, 0xC3, 0xB5, 0x0F);

        public static readonly Guid CLSID_WICThumbnailMetadataReader = new Guid(0xFB012959, 0xF4F6, 0x44D7, 0x9D, 0x09, 0xDA, 0xA0, 0x87, 0xA9, 0xDB, 0x57);

        public static readonly Guid CLSID_WICThumbnailMetadataWriter = new Guid(0xD049B20C, 0x5DD0, 0x44FE, 0xB0, 0xB3, 0x8F, 0x92, 0xC8, 0xE6, 0xD0, 0x80);

        public static readonly Guid CLSID_WICIPTCMetadataReader = new Guid(0x03012959, 0xF4F6, 0x44D7, 0x9D, 0x09, 0xDA, 0xA0, 0x87, 0xA9, 0xDB, 0x57);

        public static readonly Guid CLSID_WICIPTCMetadataWriter = new Guid(0x1249B20C, 0x5DD0, 0x44FE, 0xB0, 0xB3, 0x8F, 0x92, 0xC8, 0xE6, 0xD0, 0x80);

        public static readonly Guid CLSID_WICIRBMetadataReader = new Guid(0xD4DCD3D7, 0xB4C2, 0x47D9, 0xA6, 0xBF, 0xB8, 0x9B, 0xA3, 0x96, 0xA4, 0xA3);

        public static readonly Guid CLSID_WICIRBMetadataWriter = new Guid(0x5C5C1935, 0x0235, 0x4434, 0x80, 0xBC, 0x25, 0x1B, 0xC1, 0xEC, 0x39, 0xC6);

        public static readonly Guid CLSID_WIC8BIMIPTCMetadataReader = new Guid(0x0010668C, 0x0801, 0x4DA6, 0xA4, 0xA4, 0x82, 0x65, 0x22, 0xB6, 0xD2, 0x8F);

        public static readonly Guid CLSID_WIC8BIMIPTCMetadataWriter = new Guid(0x00108226, 0xEE41, 0x44A2, 0x9E, 0x9C, 0x4B, 0xE4, 0xD5, 0xB1, 0xD2, 0xCD);

        public static readonly Guid CLSID_WIC8BIMResolutionInfoMetadataReader = new Guid(0x5805137A, 0xE348, 0x4F7C, 0xB3, 0xCC, 0x6D, 0xB9, 0x96, 0x5A, 0x05, 0x99);

        public static readonly Guid CLSID_WIC8BIMResolutionInfoMetadataWriter = new Guid(0x4FF2FE0E, 0xE74A, 0x4B71, 0x98, 0xC4, 0xAB, 0x7D, 0xC1, 0x67, 0x07, 0xBA);

        public static readonly Guid CLSID_WIC8BIMIPTCDigestMetadataReader = new Guid(0x02805F1E, 0xD5AA, 0x415B, 0x82, 0xC5, 0x61, 0xC0, 0x33, 0xA9, 0x88, 0xA6);

        public static readonly Guid CLSID_WIC8BIMIPTCDigestMetadataWriter = new Guid(0x2DB5E62B, 0x0D67, 0x495F, 0x8F, 0x9D, 0xC2, 0xF0, 0x18, 0x86, 0x47, 0xAC);

        public static readonly Guid CLSID_WICPngTextMetadataReader = new Guid(0x4B59AFCC, 0xB8C3, 0x408A, 0xB6, 0x70, 0x89, 0xE5, 0xFA, 0xB6, 0xFD, 0xA7);

        public static readonly Guid CLSID_WICPngTextMetadataWriter = new Guid(0xB5EBAFB9, 0x253E, 0x4A72, 0xA7, 0x44, 0x07, 0x62, 0xD2, 0x68, 0x56, 0x83);

        public static readonly Guid CLSID_WICXMPMetadataReader = new Guid(0x72B624DF, 0xAE11, 0x4948, 0xA6, 0x5C, 0x35, 0x1E, 0xB0, 0x82, 0x94, 0x19);

        public static readonly Guid CLSID_WICXMPMetadataWriter = new Guid(0x1765E14E, 0x1BD4, 0x462E, 0xB6, 0xB1, 0x59, 0x0B, 0xF1, 0x26, 0x2A, 0xC6);

        public static readonly Guid CLSID_WICXMPStructMetadataReader = new Guid(0x01B90D9A, 0x8209, 0x47F7, 0x9C, 0x52, 0xE1, 0x24, 0x4B, 0xF5, 0x0C, 0xED);

        public static readonly Guid CLSID_WICXMPStructMetadataWriter = new Guid(0x22C21F93, 0x7DDB, 0x411C, 0x9B, 0x17, 0xC5, 0xB7, 0xBD, 0x06, 0x4A, 0xBC);

        public static readonly Guid CLSID_WICXMPBagMetadataReader = new Guid(0xE7E79A30, 0x4F2C, 0x4FAB, 0x8D, 0x00, 0x39, 0x4F, 0x2D, 0x6B, 0xBE, 0xBE);

        public static readonly Guid CLSID_WICXMPBagMetadataWriter = new Guid(0xED822C8C, 0xD6BE, 0x4301, 0xA6, 0x31, 0x0E, 0x14, 0x16, 0xBA, 0xD2, 0x8F);

        public static readonly Guid CLSID_WICXMPSeqMetadataReader = new Guid(0x7F12E753, 0xFC71, 0x43D7, 0xA5, 0x1D, 0x92, 0xF3, 0x59, 0x77, 0xAB, 0xB5);

        public static readonly Guid CLSID_WICXMPSeqMetadataWriter = new Guid(0x6D68D1DE, 0xD432, 0x4B0F, 0x92, 0x3A, 0x09, 0x11, 0x83, 0xA9, 0xBD, 0xA7);

        public static readonly Guid CLSID_WICXMPAltMetadataReader = new Guid(0xAA94DCC2, 0xB8B0, 0x4898, 0xB8, 0x35, 0x00, 0x0A, 0xAB, 0xD7, 0x43, 0x93);

        public static readonly Guid CLSID_WICXMPAltMetadataWriter = new Guid(0x076C2A6C, 0xF78F, 0x4C46, 0xA7, 0x23, 0x35, 0x83, 0xE7, 0x08, 0x76, 0xEA);

        public static readonly Guid CLSID_WICLSDMetadataReader = new Guid(0x41070793, 0x59E4, 0x479A, 0xA1, 0xF7, 0x95, 0x4A, 0xDC, 0x2E, 0xF5, 0xFC);

        public static readonly Guid CLSID_WICLSDMetadataWriter = new Guid(0x73C037E7, 0xE5D9, 0x4954, 0x87, 0x6A, 0x6D, 0xA8, 0x1D, 0x6E, 0x57, 0x68);

        public static readonly Guid CLSID_WICGCEMetadataReader = new Guid(0xB92E345D, 0xF52D, 0x41F3, 0xB5, 0x62, 0x08, 0x1B, 0xC7, 0x72, 0xE3, 0xB9);

        public static readonly Guid CLSID_WICGCEMetadataWriter = new Guid(0xAF95DC76, 0x16B2, 0x47F4, 0xB3, 0xEA, 0x3C, 0x31, 0x79, 0x66, 0x93, 0xE7);

        public static readonly Guid CLSID_WICIMDMetadataReader = new Guid(0x7447A267, 0x0015, 0x42C8, 0xA8, 0xF1, 0xFB, 0x3B, 0x94, 0xC6, 0x83, 0x61);

        public static readonly Guid CLSID_WICIMDMetadataWriter = new Guid(0x8C89071F, 0x452E, 0x4E95, 0x96, 0x82, 0x9D, 0x10, 0x24, 0x62, 0x71, 0x72);

        public static readonly Guid CLSID_WICAPEMetadataReader = new Guid(0x1767B93A, 0xB021, 0x44EA, 0x92, 0x0F, 0x86, 0x3C, 0x11, 0xF4, 0xF7, 0x68);

        public static readonly Guid CLSID_WICAPEMetadataWriter = new Guid(0xBD6EDFCA, 0x2890, 0x482F, 0xB2, 0x33, 0x8D, 0x73, 0x39, 0xA1, 0xCF, 0x8D);

        public static readonly Guid CLSID_WICJpegChrominanceMetadataReader = new Guid(0x50B1904B, 0xF28F, 0x4574, 0x93, 0xF4, 0x0B, 0xAD, 0xE8, 0x2C, 0x69, 0xE9);

        public static readonly Guid CLSID_WICJpegChrominanceMetadataWriter = new Guid(0x3FF566F0, 0x6E6B, 0x49D4, 0x96, 0xE6, 0xB7, 0x88, 0x86, 0x69, 0x2C, 0x62);

        public static readonly Guid CLSID_WICJpegLuminanceMetadataReader = new Guid(0x356F2F88, 0x05A6, 0x4728, 0xB9, 0xA4, 0x1B, 0xFB, 0xCE, 0x04, 0xD8, 0x38);

        public static readonly Guid CLSID_WICJpegLuminanceMetadataWriter = new Guid(0x1D583ABC, 0x8A0E, 0x4657, 0x99, 0x82, 0xA3, 0x80, 0xCA, 0x58, 0xFB, 0x4B);

        public static readonly Guid CLSID_WICJpegCommentMetadataReader = new Guid(0x9F66347C, 0x60C4, 0x4C4D, 0xAB, 0x58, 0xD2, 0x35, 0x86, 0x85, 0xF6, 0x07);

        public static readonly Guid CLSID_WICJpegCommentMetadataWriter = new Guid(0xE573236F, 0x55B1, 0x4EDA, 0x81, 0xEA, 0x9F, 0x65, 0xDB, 0x02, 0x90, 0xD3);

        public static readonly Guid CLSID_WICGifCommentMetadataReader = new Guid(0x32557D3B, 0x69DC, 0x4F95, 0x83, 0x6E, 0xF5, 0x97, 0x2B, 0x2F, 0x61, 0x59);

        public static readonly Guid CLSID_WICGifCommentMetadataWriter = new Guid(0xA02797FC, 0xC4AE, 0x418C, 0xAF, 0x95, 0xE6, 0x37, 0xC7, 0xEA, 0xD2, 0xA1);

        public static readonly Guid CLSID_WICPngGamaMetadataReader = new Guid(0x3692CA39, 0xE082, 0x4350, 0x9E, 0x1F, 0x37, 0x04, 0xCB, 0x08, 0x3C, 0xD5);

        public static readonly Guid CLSID_WICPngGamaMetadataWriter = new Guid(0xFF036D13, 0x5D4B, 0x46DD, 0xB1, 0x0F, 0x10, 0x66, 0x93, 0xD9, 0xFE, 0x4F);

        public static readonly Guid CLSID_WICPngBkgdMetadataReader = new Guid(0x0CE7A4A6, 0x03E8, 0x4A60, 0x9D, 0x15, 0x28, 0x2E, 0xF3, 0x2E, 0xE7, 0xDA);

        public static readonly Guid CLSID_WICPngBkgdMetadataWriter = new Guid(0x68E3F2FD, 0x31AE, 0x4441, 0xBB, 0x6A, 0xFD, 0x70, 0x47, 0x52, 0x5F, 0x90);

        public static readonly Guid CLSID_WICPngItxtMetadataReader = new Guid(0xAABFB2FA, 0x3E1E, 0x4A8F, 0x89, 0x77, 0x55, 0x56, 0xFB, 0x94, 0xEA, 0x23);

        public static readonly Guid CLSID_WICPngItxtMetadataWriter = new Guid(0x31879719, 0xE751, 0x4DF8, 0x98, 0x1D, 0x68, 0xDF, 0xF6, 0x77, 0x04, 0xED);

        public static readonly Guid CLSID_WICPngChrmMetadataReader = new Guid(0xF90B5F36, 0x367B, 0x402A, 0x9D, 0xD1, 0xBC, 0x0F, 0xD5, 0x9D, 0x8F, 0x62);

        public static readonly Guid CLSID_WICPngChrmMetadataWriter = new Guid(0xE23CE3EB, 0x5608, 0x4E83, 0xBC, 0xEF, 0x27, 0xB1, 0x98, 0x7E, 0x51, 0xD7);

        public static readonly Guid CLSID_WICPngHistMetadataReader = new Guid(0x877A0BB7, 0xA313, 0x4491, 0x87, 0xB5, 0x2E, 0x6D, 0x05, 0x94, 0xF5, 0x20);

        public static readonly Guid CLSID_WICPngHistMetadataWriter = new Guid(0x8A03E749, 0x672E, 0x446E, 0xBF, 0x1F, 0x2C, 0x11, 0xD2, 0x33, 0xB6, 0xFF);

        public static readonly Guid CLSID_WICPngIccpMetadataReader = new Guid(0xF5D3E63B, 0xCB0F, 0x4628, 0xA4, 0x78, 0x6D, 0x82, 0x44, 0xBE, 0x36, 0xB1);

        public static readonly Guid CLSID_WICPngIccpMetadataWriter = new Guid(0x16671E5F, 0x0CE6, 0x4CC4, 0x97, 0x68, 0xE8, 0x9F, 0xE5, 0x01, 0x8A, 0xDE);

        public static readonly Guid CLSID_WICPngSrgbMetadataReader = new Guid(0xFB40360C, 0x547E, 0x4956, 0xA3, 0xB9, 0xD4, 0x41, 0x88, 0x59, 0xBA, 0x66);

        public static readonly Guid CLSID_WICPngSrgbMetadataWriter = new Guid(0xA6EE35C6, 0x87EC, 0x47DF, 0x9F, 0x22, 0x1D, 0x5A, 0xAD, 0x84, 0x0C, 0x82);

        public static readonly Guid CLSID_WICPngTimeMetadataReader = new Guid(0xD94EDF02, 0xEFE5, 0x4F0D, 0x85, 0xC8, 0xF5, 0xA6, 0x8B, 0x30, 0x00, 0xB1);

        public static readonly Guid CLSID_WICPngTimeMetadataWriter = new Guid(0x1AB78400, 0xB5A3, 0x4D91, 0x8A, 0xCE, 0x33, 0xFC, 0xD1, 0x49, 0x9B, 0xE6);

        public static readonly Guid CLSID_WICDdsMetadataReader = new Guid(0x276C88CA, 0x7533, 0x4A86, 0xB6, 0x76, 0x66, 0xB3, 0x60, 0x80, 0xD4, 0x84);

        public static readonly Guid CLSID_WICDdsMetadataWriter = new Guid(0xFD688BBD, 0x31ED, 0x4DB7, 0xA7, 0x23, 0x93, 0x49, 0x27, 0xD3, 0x83, 0x67);

        public static readonly Guid CLSID_WICHeifMetadataReader = new Guid(0xACDDFC3F, 0x85EC, 0x41BC, 0xBD, 0xEF, 0x1B, 0xC2, 0x62, 0xE4, 0xDB, 0x05);

        public static readonly Guid CLSID_WICHeifMetadataWriter = new Guid(0x3AE45E79, 0x40BC, 0x4401, 0xAC, 0xE5, 0xDD, 0x3C, 0xB1, 0x6E, 0x6A, 0xFE);

        public static readonly Guid CLSID_WICHeifHDRMetadataReader = new Guid(0x2438DE3D, 0x94D9, 0x4BE8, 0x84, 0xA8, 0x4D, 0xE9, 0x5A, 0x57, 0x5E, 0x75);

        public static readonly Guid CLSID_WICWebpAnimMetadataReader = new Guid(0x76F9911, 0xA348, 0x465C, 0xA8, 0x7, 0xA2, 0x52, 0xF3, 0xF2, 0xD3, 0xDE);

        public static readonly Guid CLSID_WICWebpAnmfMetadataReader = new Guid(0x85A10B03, 0xC9F6, 0x439F, 0xBE, 0x5E, 0xC0, 0xFB, 0xEF, 0x67, 0x80, 0x7C);

        public static readonly Guid IID_IWICMetadataBlockReader = new Guid(0xFEAA2A8D, 0xB3F3, 0x43E4, 0xB2, 0x5C, 0xD1, 0xDE, 0x99, 0x0A, 0x1A, 0xE1);

        public static readonly Guid IID_IWICMetadataBlockWriter = new Guid(0x08FB9676, 0xB444, 0x41E8, 0x8D, 0xBE, 0x6A, 0x53, 0xA5, 0x42, 0xBF, 0xF1);

        public static readonly Guid IID_IWICMetadataReader = new Guid(0x9204FE99, 0xD8FC, 0x4FD5, 0xA0, 0x01, 0x95, 0x36, 0xB0, 0x67, 0xA8, 0x99);

        public static readonly Guid IID_IWICMetadataWriter = new Guid(0xF7836E16, 0x3BE0, 0x470B, 0x86, 0xBB, 0x16, 0x0D, 0x0A, 0xEC, 0xD7, 0xDE);

        public static readonly Guid IID_IWICStreamProvider = new Guid(0x449494BC, 0xB468, 0x4927, 0x96, 0xD7, 0xBA, 0x90, 0xD3, 0x1A, 0xB5, 0x05);

        public static readonly Guid IID_IWICPersistStream = new Guid(0x00675040, 0x6908, 0x45F8, 0x86, 0xA3, 0x49, 0xC7, 0xDF, 0xD6, 0xD9, 0xAD);

        public static readonly Guid IID_IWICMetadataHandlerInfo = new Guid(0xABA958BF, 0xC672, 0x44D1, 0x8D, 0x61, 0xCE, 0x6D, 0xF2, 0xE6, 0x82, 0xC2);

        public static readonly Guid IID_IWICMetadataReaderInfo = new Guid(0xEEBF1F5B, 0x07C1, 0x4447, 0xA3, 0xAB, 0x22, 0xAC, 0xAF, 0x78, 0xA8, 0x04);

        public static readonly Guid IID_IWICMetadataWriterInfo = new Guid(0xB22E3FBA, 0x3925, 0x4323, 0xB5, 0xC1, 0x9E, 0xBF, 0xC4, 0x30, 0xF2, 0x36);

        public static readonly Guid IID_IWICComponentFactory = new Guid(0x412D0C3A, 0x9650, 0x44FA, 0xAF, 0x5B, 0xDD, 0x2A, 0x06, 0xC8, 0xE8, 0xFB);
    }
}
