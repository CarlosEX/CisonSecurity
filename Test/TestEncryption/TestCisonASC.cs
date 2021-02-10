using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cison.Security.Encryption;

namespace Test.TestCisonASC
{
    [TestClass]
    public class TestClassAsc
    {
        [TestMethod]
        public void TestCisonASC_CriptografarTexto_RetornaTextoCriptografado(){            
            
            string valorEsperado = "65#66#67";
            string valorPassado = "ABC";
            string valorReal = ASCIIBasicEncryption.Encrypt(valorPassado);

            Assert.AreEqual(valorEsperado,valorReal); 

        }
        [TestMethod]
        public void TestCisonASC_CriptografarTexto_RetornaTextoDescriptografado(){            
            
            string valorEsperado = "ABC";
            string valorPassado = "65#66#67";
            string valorReal = ASCIIBasicEncryption.Decrypt(valorPassado);

            Assert.AreEqual(valorEsperado,valorReal); 

        }
    }
}