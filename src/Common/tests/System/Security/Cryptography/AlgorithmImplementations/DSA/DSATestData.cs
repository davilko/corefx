// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text;
using Test.Cryptography;

namespace System.Security.Cryptography.Dsa.Tests
{
    // Note to contributors:
    //   Keys contained in this file should be randomly generated for the purpose of inclusion here,
    //   or obtained from some fixed set of test data. (Please) DO NOT use any key that has ever been
    //   used for any real purpose.
    //
    // Note to readers:
    //   The keys contained in this file should all be treated as compromised. That means that you
    //   absolutely SHOULD NOT use these keys on anything that you actually want to be protected.
    internal class DSATestData
    {
        public static readonly byte[] HelloBytes = new ASCIIEncoding().GetBytes("Hello");

        internal static DSAParameters Dsa512Parameters = new DSAParameters
        {
            P = (
                "D6A8B7F1CAF7A6964D07663FC691D22F6ABCD55C37AEF58D20746740D82FE14E" +
                "146363627D91925142DCDEE384BE0A1E04ED5BF5F471486F4D986D42A2E7DF95").HexToByteArray(),

            Q = "FAB5F625D5D5E16430A1EF630EBE33897CC224F9".HexToByteArray(),

            G = (
                "0844C490E52EF58E05902C636D64D1D5EB2C6082A0D4F3BFD1CE078E87B43A7E" +
                "F7BBECE19A4EFE2A6D9C229D360083CEA9F721F39B05BAF97052DEFC67A58A2B").HexToByteArray(),

            X = "2E3D7A84C85B66785E1F6FE796982B22B0CB98BC".HexToByteArray(),

            Y = (
                "C300E0E67D877E6CED39FEEAAAC1F2C2BD568E6A32467227E12B6AE45A8D9478" +
                "541A480AC80038AAC863827D6E3984061A25905C18BD2499A839663C3CA45605").HexToByteArray(),
        };

        internal static DSAParameters Dsa576Parameters = new DSAParameters
        {
            P = (
                "E2167306BFFD86BB62F4327B778BBFA07BA42323EC567B106B9563882BDDD6D7" +
                "F2EE7360F299888DE9F40A61C78D0BD8442EFA9C322B868AD367B3941D72B7A3" +
                "32C954EB1629132B").HexToByteArray(),

            Q = "CCDCECCF5F0B2C8FE238E2F06F22137F17FAEB1B".HexToByteArray(),

            G = (
                "AF17D4061302079E33034A77A058DDB4B832ACB114B7B8D2D3AE4451DFF85EB8" +
                "DD75D4474218369D485B2206506406044AB4E6407FDAA5A29E95D4964CA559E8" +
                "1C6F7CFCDA872665").HexToByteArray(),

            X = "AC32693E1CD72AD63E1A0B6E8157EBBCA671D3DB".HexToByteArray(),

            Y = (
                "815A549B6FD0CEDAF044B00B7CFE1351902D7727D6D7FB736003A4E1C4CD8DFB" +
                "F431E4FF4733F3FA92C765F0CFF944E3ED56A85B75953EB16901248985BB5F89" +
                "1398EAB5E39645E7").HexToByteArray(),
        };

        internal static DSAParameters GetDSA1024Params()
        {
            DSAParameters p = new DSAParameters();
            p.G = (
                "6BC366B66355545E098F1FE90E5469B567E09FA79D817F2B367B45DECD4301A59C81D6911F7691D370E15AC692C04BC11872" +
                "C171A7FE654E963D7DDA575A9E98CE026FB7D3934A258608134A8EC5ED69A2AEDC89401B67ADDE427F17EDAEB72D7AF45D9A" +
                "B1D59E1B13D4EFBD17C764330267DDE352C20E05B80DB3C109FE8B9C").HexToByteArray();
            p.P = (
                "C16D26C74D6C1627799C0918548E553FE58C7881DA484629CAF64311F4B27CFEF6BDB0F21206B0FFC4999A2FED53B43B9EE2" +
                "910C68DA2C436A8018F4938F6472369F5647D005BCC96E22590CC15E3CD4EA0D132F5DA5AF6AAA0807B0CC4EF3404AF542F4" +
                "546B37BDD6A47E641130837DB99397C845635D7DC36D0537E4A84B31").HexToByteArray();
            p.Q = "D83C0ECB73551E2FE30D51FCF4236C651883ADD7".HexToByteArray();
            p.X = "C02678007779E52E360682214BD47F8FAF42BC2D".HexToByteArray();
            p.Y = (
                "690BB37A9145E05D6E7B47C457898AAEDD72501C9D16E79B1AD75A872CF017AA90BBFB90F1B3B7F5C03C87E46E8725665526" +
                "FD34157B26F596A1F0997F59F3E65EFC615A552D5E7569C5FFC4593D5A0299110E71C97E1221A5A03FE9A6935AEDD88EF0B3" +
                "B2F79D3A99ED75F7B871E6EAF2680D96D574A5F4C13BACE3B4B44DE1").HexToByteArray();
            return p;
        }

        // Whitespace (or lack of) must be exact here to compare against ToXmlString output
        private const string Dsa1024PartialXml =
            "<DSAKeyValue><P>wW0mx01sFid5nAkYVI5VP+WMeIHaSEYpyvZDEfSyfP72vbDyEgaw/8SZmi/tU7Q7nuKRDGjaLENqgBj0k49k" +
            "cjafVkfQBbzJbiJZDMFePNTqDRMvXaWvaqoIB7DMTvNASvVC9FRrN73WpH5kETCDfbmTl8hFY119w20FN+SoSzE=</P>" +
            "<Q>2DwOy3NVHi/jDVH89CNsZRiDrdc=</Q>" +
            "<G>a8NmtmNVVF4Jjx/pDlRptWfgn6edgX8rNntF3s1DAaWcgdaRH3aR03DhWsaSwEvBGHLBcaf+ZU6WPX3aV1qemM4Cb7fTk0olh" +
            "ggTSo7F7WmirtyJQBtnrd5CfxftrrctevRdmrHVnhsT1O+9F8dkMwJn3eNSwg4FuA2zwQn+i5w=</G>" +
            "<Y>aQuzepFF4F1ue0fEV4mKrt1yUBydFuebGtdahyzwF6qQu/uQ8bO39cA8h+RuhyVmVSb9NBV7JvWWofCZf1nz5l78YVpVLV51a" +
            "cX/xFk9WgKZEQ5xyX4SIaWgP+mmk1rt2I7ws7L3nTqZ7XX3uHHm6vJoDZbVdKX0wTus47S0TeE=</Y>";

        private const string Dsa1024XmlPrivateKey = Dsa1024PartialXml + "<X>wCZ4AHd55S42BoIhS9R/j69CvC0=</X></DSAKeyValue>";

        private const string Dsa1024XmlNoPrivateKey = Dsa1024PartialXml + "</DSAKeyValue>";

        internal static string GetDSA1024Xml(bool includePrivate)
        {
            return includePrivate ? Dsa1024XmlPrivateKey : Dsa1024XmlNoPrivateKey;
        }

        internal static DSAParameters GetDSA2048Params()
        {
            DSAParameters p = new DSAParameters();
            p.G = (
                "44A7D22DEBA29CE19D678D2DC11F118BAA10E3BEA94DE29C3EC36C10AB4D688004A1B7F4387FC1CC9613E6851FEDBBD54531" +
                "9EDE544B94E4FAE9C1069E7734F9E6AFC8A0B840696CDFFE286E1AF1AD6E39629D0C8C6016AC625F100BACF5FF74B2325C9D" +
                "99A6D8B0310B268F63E35F5D1C8DA663F94ABA90244CECCF9A8CE5DB5479B006F9131E5EA78222A32E2A103C1FEF16929B15" +
                "6E3230C954295CDA3E5F91F71B567FA3B774B842F128CD0D343D5468DB90734A678035E65E6A21CC7301F4F53E6B66718A83" +
                "FF285A6FDE89CA5AE1D1B9633A25A34A926F9D2808F9BF795D936787FF4C7286BC7FC4A82AFA9B06C9125109A923BAF3E377" +
                "55F1574BAFB5").HexToByteArray();
            p.P = (
                "AF8FB9B2B147C96F392360639BDAA6544FF2CD086B604A3324F485595F02CEAF32D2D49F2DD3AD9F5384DD09D03182DB8F0A" +
                "A06CE0A0FCA2366A5B031BD0E2FAD797BADC874A0C6781529C01E0D69704B43DF371AE4A9B3DD81EB03F5DAE283780112568" +
                "66337B73A824F7E8ACA61981A7C67649363D2D7D12CC2305308D084BEC68CC3B1B3EF577053A5E23449FBA3C3EB6F8CD8EA6" +
                "9F116B3748BD237F97F4F7E911C41C394D6F7D2D53B767618F0DED48E7BD7F30C6568948264A54C00D358A76E9826ED791C6" +
                "B6CBF8C29C245173B1D8D219438E59373CE7554EF49C7840A8C55CE2E5E2C33C10AAD8D90F28C7CB2EF14AD5ED8C4E6992B4" +
                "1ECEC65288F5").HexToByteArray();
            p.Q = "C93AB229237282997F23541A399BBF75CECD30BE0BE9592C07043ED30221EACB".HexToByteArray();
            p.X = "B8BFF7B3328E6B6DBC8325A275A1193EF81C975ECF88B340C468B770FB5E2658".HexToByteArray();
            p.Y = (
                "011BD85986A2C41315FF01C554A45E5A9C45B38EBDCC2660B6D17889604E800A6FDE8E017CED3793F4A6FBAFBB7613FEB7BA" +
                "87841ABD59935D18858939C00A6E4619B6562475955D6D72B2134BECF5AB34118F60D84B1FF268753F188E861255132D84CA" +
                "0AAB681B8551873394F18E0DAEF6B5F9577EC7CA2AA63281B539AF5894283E3FB6DCC5537D92C8BFE7C0723AC212EEF3B771" +
                "8D35C3FDD99F7AE0912CC7C47521A56FA511BE31712D979AE67F17A7BCC4E5810EA9CA138DEED3D78239EEEF239A772942D2" +
                "3C2810C2972219525646127F9C4B81612C12AEDC2DC91E81153B0A207C1FBC00795B3EB8E86796CED29AC1247FF7122A1EAF" +
                "081025751572").HexToByteArray();
            return p;
        }

        // The parameters and signature come from FIPS 186-2 APPENDIX 5. EXAMPLE OF THE DSA
        internal static void GetDSA1024_186_2(out DSAParameters parameters, out byte[] signature, out byte[] data)
        {
            parameters = new DSAParameters()
            {
                P = (
                "8df2a494492276aa3d25759bb06869cbeac0d83afb8d0cf7cbb8324f0d7882e5d0762fc5b7210eafc2e9adac32ab7aac" +
                "49693dfbf83724c2ec0736ee31c80291").HexToByteArray(),
                Q = ("c773218c737ec8ee993b4f2ded30f48edace915f").HexToByteArray(),
                G = (
                "626d027839ea0a13413163a55b4cb500299d5522956cefcb3bff10f399ce2c2e71cb9de5fa24babf58e5b79521925c9c" +
                "c42e9f6f464b088cc572af53e6d78802").HexToByteArray(),
                X = ("2070b3223dba372fde1c0ffc7b2e3b498b260614").HexToByteArray(),
                Y = (
                "19131871d75b1612a819f29d78d1b0d7346f7aa77bb62a859bfd6c5675da9d212d3a36ef1672ef660b8c7c255cc0ec74" +
                "858fba33f44c06699630a76b030ee333").HexToByteArray()
            };

            signature = (
                // r
                "8bac1ab66410435cb7181f95b16ab97c92b341c0" +
                // s
                "41e2345f1f56df2458f426d155b4ba2db6dcd8c8"
                ).HexToByteArray();

            data = Encoding.ASCII.GetBytes("abc");
        }
    }
}
