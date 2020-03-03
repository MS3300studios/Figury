using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguryLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorPoprawneDaneTrojkatUtworzony()
        {
            //AAA (act arrange assert)
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            //Act
            Trojkat t = new Trojkat(a, b, c);

            //Assert 
            Assert.AreEqual(a, t.A);
            Assert.AreEqual(b, t.B);
            Assert.AreEqual(c, t.C);



        }
    }
}
