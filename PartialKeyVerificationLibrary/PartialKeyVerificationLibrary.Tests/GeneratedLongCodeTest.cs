using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerificationLibrary.Verificator;
using PartialKeyVerificationLibrary.Verificator.Checksum;
using PartialKeyVerificationLibrary.Verificator.Hash;

namespace PartialKeyVerificationLibrary.Tests
{
    /// <summary>
    /// Summary description for GeneratedCodeTest
    /// </summary>
    [TestClass]
    public class GeneratedLongCodeTest
    {
        public GeneratedLongCodeTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private static bool ValidateKey(string userName, string key)
        {
            var seed = PartialKeyValidator.GetSerialNumberFromKey(key);
            var blacklist = new List<uint> { 1518008798, };
            if (blacklist.Contains(seed))
                return false;

            // Validation for key with index 0
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Fnv1A(), key, 0, 3805288664, userName))
                return false;

            // Validation for key with index 3
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new SuperFast(), key, 3, 3244489209, userName))
                return false;

            // Validation for key with index 6
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(), key, 6, 2055159233, userName))
                return false;

            // Validation for key with index 9
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(), key, 9, 1214538031, userName))
                return false;

            // Validation for key with index 14
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new SuperFast(), key, 14, 4183406825, userName))
                return false;

            // Validation for key with index 17
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new OneAtATime(), key, 17, 1724296759, userName))
                return false;

            // Validation for key with index 20
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new OneAtATime(), key, 20, 2648676312, userName))
                return false;

            // Validation for key with index 22
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(), key, 22, 2002795508, userName))
                return false;

            // Validation for key with index 27
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Fnv1A(), key, 27, 3973426099, userName))
                return false;

            // Validation for key with index 29
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(), key, 29, 2363305399, userName))
                return false;

            // Validation for key with index 33
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new OneAtATime(), key, 33, 2008357872, userName))
                return false;

            // Validation for key with index 36
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new SuperFast(), key, 36, 3705717340, userName))
                return false;

            // Validation for key with index 38
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new GeneralizedCrc(), key, 38, 1869347822, userName))
                return false;

            // Validation for key with index 41
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(), key, 41, 3261555846, userName))
                return false;

            // Validation for key with index 45
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(), key, 45, 696771626, userName))
                return false;

            // Validation for key with index 48
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(), key, 48, 3718059442, userName))
                return false;

            // Validation for key with index 51
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new GeneralizedCrc(), key, 51, 1826198764, userName))
                return false;

            // Validation for key with index 54
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Crc32(), key, 54, 4130428571, userName))
                return false;

            // Validation for key with index 60
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new GeneralizedCrc(), key, 60, 2690376970, userName))
                return false;

            // Validation for key with index 65
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Fnv1A(), key, 65, 161580699, userName))
                return false;

            // Validation for key with index 69
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new OneAtATime(), key, 69, 23540271, userName))
                return false;

            // Validation for key with index 72
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new SuperFast(), key, 72, 3463187118, userName))
                return false;

            // Validation for key with index 77
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(), key, 77, 2246949605, userName))
                return false;

            // Validation for key with index 83
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new GeneralizedCrc(), key, 83, 2337749006, userName))
                return false;

            // Validation for key with index 86
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new GeneralizedCrc(), key, 86, 1754935977, userName))
                return false;

            // Validation for key with index 89
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Crc32(), key, 89, 3561939657, userName))
                return false;

            // Validation for key with index 92
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Crc32(), key, 92, 4166860687, userName))
                return false;

            // Validation for key with index 95
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Fnv1A(), key, 95, 118560136, userName))
                return false;

            // Validation for key with index 97
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(), key, 97, 69116611, userName))
                return false;

            return true;
        }



        [TestMethod]
        public void TestCorrectKey()
        {
            const string key = "HL65W5JSLG3IS6HEWGYQMMYNCAXK2RQAJSL3I2U5WAD33LQ2WA77MZPFKWNKD5FWDAGB5DTA342V3QGMVREL7JYKME4O3CJQMQYCYLNFO66YKKJUO7TWCSAEFKAL6H6INWRQXSRYNQXGLOI4RCKP4NGDJMIQEQ5JJ7VIG2OYCKWN33PKKXJWHE74MXDBDAZJ74NR2MERJPG2H2CXHSOHMVC47566QY4FTRMHYY4NVBT4RTV2B55EKDSTVUNYF2VUQJYRS4PKLJNC6J33W6FXTMUNDMG7MPKPAOIKCOHTNQPHV5KOX7BILI6T4A6D2IHT6TERIF65TYTDQSZGTMT5PZZFMCURZ6FGAHNJ5UI6RZ6KS6DFJ4QCAJF3O4NWDWL5X2FMCKY6KZZOVUH53FXVIAKAB5MCM7SGHO7KZIPTS54KQ2PD73OY4JIB5SVN7DXLEQ2SDCQ7L43GNHY5GHETKEY7XN6ZSHZ2THX6I43GP52JSOFDCLOYONYPNKM6VFNV5METHY6MFV676E2VUHBZAANRBOKFHRQAHKNA7QGJKK775GRS2KKI26B7U7TUSJ2GHFXQUD25ELEDWP3XKSL4VYYTM5DAL7C5WFM3ERU75ZB53O7UOY4SRZDZBC5VWP6NL4OB3VFPNU";
            const uint serial = 1977351482;
            const string name = "Correct Key";

            Assert.IsTrue(ValidateKey(name, key));
            Assert.AreEqual(serial, PartialKeyValidator.GetSerialNumberFromKey(key));
        }


        [TestMethod]
        public void TestCorrectKeyButIncorrectName()
        {
            const string key = "T7VLQ5YLFNMCP4XBWNZIYNQP2MVNOSV2F4DNNJOK4ZSEYXWPCA3VM3LJRAMITSZ3TVUQGN7K3I3Z5JY37OJV4M7ZKNAYZZ32NJQ36MZPOK7UNIZROUSEOOFGYQBXBG5AIYLO4FFG252QTQMMG4WINBGAYCNQOQLKIJ27AFB3BNZ6UKQ4V4I3NHDOIBJPCFF2WVWHH2I3J3HWAYSSHZPSS23JKZECCYS4LI7Q57QIBUTN325THTXEAQDYQGAE7VH6BB2BXMXEAVVKARQI5IDIBHMEZ2P7RLMRXSMQTGEXLTPB3IM3Z35JSULNFOYBOLNGP3GBNVAUVROIUJZZAAKV3YRHUNGSZ62GRPPZYEXVBHLA6BNN2MRZARCNXZ4VJXJKUFL2IOZUXP5NJF7UEDMO54FZAAB5PM7YZIBR564G6TX7BKZOEYUP7E4BOIDFBRINQI7VWQDO463ZVJR5YKW47JALUPWV7HTX5GZ6MNYXUVKTJGSOHVC33QGVV2WEC55BO3OIIUSGFB7TY2Q6D6GX2AZA6ML5GFVHDEP24ITHB3ZJRVWDIAJMBHYBO5WUYJMFWNVARTAHG5E2A2BL5TTEBZQRUTGAB7U6HNOLBBMCX662UMPROT5IMYPO64YV4PIOUCCFUAFNNE";
            const uint serial = 2008607391;
            const string name = "Correct Key But Incorrect Name";

            Assert.IsFalse(ValidateKey(name, key));
            Assert.AreEqual(serial, PartialKeyValidator.GetSerialNumberFromKey(key));
        }


        [TestMethod]
        public void TestBlacklistedKey()
        {
            const string key = "334XUWW2HV7PKORKNDZUJ7OUKLKEAPPZ6UDBKMXE5BIIGBVHQTCIFTUKCKX2MLNRNMIOJAZCCHWB7FW6T7UEBD52SRFRBQYA5E7NV37HXFSMO272V2SXS52TUB2VFDYV6RPMVKXYO5UBTTH5KPXP7HJV2BJ4ZGXLUL6EJT4GVEZAQAYZDHXQ7GVTKFG3JAAKI7PTKTWTQUKODKUZ4XPBLRJY24ZQBIMHZ7DKSOBOWJLNOARNO55BMGWW6SMILOCDYC74AM2TSAKRX63AK7J5SJDNJW7EWRAZXAVVMWY4I7NQ52XHMJDRVA356NGOUXFAWYD42VPRXU6KPYXOSQJJKKP4EJR2C2HYIMKEPE6BPJ6K5CQLP23P7CW3R36LTCPBRUBBFWDA644CKTJVCHTUQAIIJC5NYB6DNNKVLKYDJTIQSJVAASCBHIRKMBIDXUOY47RKL6VPCONX6LN2HRX5YRS6Y7LJM6XWSLV3TG5S35IYULY7NET3JBHK3L2UWMNARXZMCDUO4OSL3PMJR55TIBSJPGH2RFXX6S77YIBKKBVDTBNGURQA6PHUHSSYP7QEPOQ5GTJCMPKY2IR3QVOIQLOKEUCMWJI76OLWWBATEHBMN6J2V555OM4OZH4ZLZUPXGSTH5IKBM";
            const uint serial = 1518008798;
            const string name = "Blacklisted Key";

            Assert.IsFalse(ValidateKey(name, key));
            Assert.AreEqual(serial, PartialKeyValidator.GetSerialNumberFromKey(key));
        }
    }
}