using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cison.Security.Encryption;

namespace Test.TestCisonASC
{
    [TestClass]
    public class TestClassBase
    {
        [TestMethod]
        public void TestClasseBase_ExtractLastCaracter_ReturnsTextWithLastCharacteristicRemoved(){
            
            CisonASC cisonASC = new CisonASC();
            
            string valorEsperado = "CARLOS";
            string valorPassado = "CARLOS2";
            string valorReal = cisonASC.StractLastCaracter(valorPassado);

            Assert.AreEqual(valorEsperado,valorReal);

        }

        [TestMethod]
        public void TestClassBase_IsTextValidate_TextIsValidade(){
            
            CisonASC cisonASC = new CisonASC();
            
            Assert.AreEqual(true,cisonASC.IsTextValidate("xxx"));

        }
        [TestMethod]
        public void TestClassBase_IsTextValidate_TextIsNullValidade(){
            
            CisonASC cisonASC = new CisonASC();
            
            Assert.AreEqual(false,cisonASC.IsTextValidate(null));

        }
        [TestMethod]
        public void TestClassBase_IsTextValidate_TextIsEmptyValidade(){
            
            CisonASC cisonASC = new CisonASC();
            
            Assert.AreEqual(false,cisonASC.IsTextValidate(string.Empty));

        }
        [TestMethod]
        public void TestClassBase_IsTextValidate_TextIsSpaceValidade(){
            
            CisonASC cisonASC = new CisonASC();
            
            Assert.AreEqual(false,cisonASC.IsTextValidate(" "));
        }
    }
}