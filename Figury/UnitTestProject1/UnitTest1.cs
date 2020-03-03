using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguryLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(3, 4, 5)] //(TUTAJ)
        [DataRow(2, 3, 4)]
        [DataRow(1, 1, 1)]
        public void ConstructorPoprawneDaneTrojkatUtworzony(double a, double b, double c) //DataRow wrzuci te argumenty w te miejsca
        {
            //AAA (act arrange assert)
            //Arrange
            //(arrange jest załatwione TUTAJ)
            //Act
            Trojkat t = new Trojkat(a, b, c);

            //Assert 
            Assert.AreEqual(a, t.A);
            Assert.AreEqual(b, t.B);
            Assert.AreEqual(c, t.C);



        }

        //testujemy konstruktory

        [TestMethod]
        public void ConstructorDefaultPoprawnie()
        {
            //Arrange
            //Act
            Trojkat t = new Trojkat();
            //Assert
            Assert.AreEqual(1, t.A);
            Assert.AreEqual(1, t.B); //sprawdza czy wartości są równe
            Assert.AreEqual(1, t.C);
        }

        [DataTestMethod] //opis dla innego software'u potrzebny aby framework testowy rozumiał co to za kod
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(-1,1,1)]
        [DataRow(1,-1,1)]
        [DataRow(1,1,-1)]
        public void ConstructorUjemnyParametr_ArgumentOutOfRangeExeption(double a,double b,double c)
        {
            Trojkat t = new Trojkat(a, b, c);
        }
    
        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(1,1,100)]
        [DataRow(100,1,1)]
        [DataRow(1,100,1)]
        public void ConstructorNieSpelnionyWarunekTrojkataWynikiemJestArgumentExeption(double a, double b, double c)
        {
            Trojkat t = new Trojkat(a, b, c);
        }
        
        [DataTestMethod]
        [DataRow(1,1,1,3)]
        [DataRow(3,4,5,12)] //wchodzą 4 dane
        public void PropertyObwodPoprawnie(double a, double b, double c, double wynik) //więc funkcja przyjmuje 4 argumenty
        {
            //Act
            var t = new Trojkat(a, b, c); //jak zawsze konstruujemy trójkąt 

            //Assert
            Assert.AreEqual(wynik, t.Obwod);

        }
        [DataTestMethod]
        //[DataRow(1,1,1,0.433012701892219)]
        [DataRow(3,4,5,6)]
        public void PropertyPolePoprawnie(double a, double b, double c, double wynik)
        {
            //Act
            var t = new Trojkat(3, 4, 5);

            //Assert
            Assert.AreEqual(wynik, t.Pole);
        
        }

    }
}
