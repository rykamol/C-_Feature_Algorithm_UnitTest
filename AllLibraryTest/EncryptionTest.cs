using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllLibraryTest
{
    [TestClass]
    public class EncryptionTest
    {

        [TestMethod]
        public void DecryptString_MatchEncryptString_ReturnTrue()
        {
            Encryption.Encryption aEncryption = new Encryption.Encryption();

            var en = aEncryption.EncryptString("kamol");

            var dec = aEncryption.DecryptString(en);

            Assert.AreEqual("kamol", dec);
        }
    }
}
