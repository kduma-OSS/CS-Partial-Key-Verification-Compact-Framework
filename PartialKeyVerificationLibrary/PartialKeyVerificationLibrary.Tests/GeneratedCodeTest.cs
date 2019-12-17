using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerification;
using PartialKeyVerificationLibrary.Verificator;
using PartialKeyVerificationLibrary.Verificator.Checksum;
using PartialKeyVerificationLibrary.Verificator.Hash;

namespace PartialKeyVerificationLibrary.Tests
{
    /// <summary>
    /// Summary description for GeneratedCodeTest
    /// </summary>
    [TestClass]
    public class GeneratedCodeTest
    {
        public GeneratedCodeTest()
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

            // Validation for key with index 1
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new OneAtATime(), key, 1, 766109221, userName))
                return false;

            // Validation for key with index 4
            if (!PartialKeyValidator.ValidateKey(new Adler16(), new SuperFast(), key, 4, 4072442218, userName))
                return false;

            return true;
        }


        [TestMethod]
        public void TestCorrectKey()
        {
            const string key = "HL65W5-KK6Y34-OBG32G-DM522M-H2ZI2E-4366ZG-UP57MM";
            const uint serial = 1977351482;
            const string name = "Correct Key";

            Assert.IsTrue(ValidateKey(name, key));
            Assert.AreEqual(serial, PartialKeyValidator.GetSerialNumberFromKey(key));
        }


        [TestMethod]
        public void TestCorrectKeyButIncorrectName()
        {
            const string key = "LO3PLL-FWQ3MQ-JPC4OI-4XUGGM-Z6EVVP-DTGWJ2-MZW6BE";
            const uint serial = 2901784155;
            const string name = "Correct Key But Incorrect Name";

            Assert.IsFalse(ValidateKey(name, key));
            Assert.AreEqual(serial, PartialKeyValidator.GetSerialNumberFromKey(key));
        }


        [TestMethod]
        public void TestBlacklistedKey()
        {
            const string key = "334XUW-WDB6RD-MLHYSP-CLJU7H-66DPW5-G3CZK3-P2S5LM";
            const uint serial = 1518008798;
            const string name = "Blacklisted Key";

            Assert.IsFalse(ValidateKey(name, key));
            Assert.AreEqual(serial, PartialKeyValidator.GetSerialNumberFromKey(key));
        }
    }
}
