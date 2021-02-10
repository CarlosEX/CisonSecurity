using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cison.Security.Encryption;

namespace Test.TestCisonASC
{
    [TestClass]
    public class TestClassAsc
    {
        [TestMethod]
        public void TestCisonASC_CriptografarTexto_RetornaTextoCriptografado(){            
            
            CisonASC cisonASC = new CisonASC();
            
            string valorEsperado = "65#66#67";
            string valorPassado = "ABC";
            string valorReal = cisonASC.Encrypt();

            cisonASC.Value = valorPassado;

            cisonASC.Encrypt();

            Assert.AreEqual(valorEsperado,cisonASC.Encrypt()); 

        }
        [TestMethod]
        public void TestCisonASC_CriptografarTexto_RetornaTextoDescriptografado(){            
            
            CisonASC cisonASC = new CisonASC();
            
            string valorEsperado = "ABC";
            string valorPassado = "65#66#67";

            cisonASC.Value = valorPassado;

            Assert.AreEqual(valorEsperado,cisonASC.Decrypt()); 

        }
    }
}