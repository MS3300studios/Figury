using System;
using System.Collections.Generic;
using System.Text;






//TODO: make surface property for Triangle class






namespace FiguryLibrary
{

    /// <summary>
    /// Trojkat w wersji immutable (niezmiennej) (nikt nie ma prawa zmodyfikować trójkąta po jego utworzeniu)
    /// </summary>
    public class Triangle : Figure
    {
        //trójkąt jest niezmienny bo ma private set
        public double A //automatic properties 
        {
            get;    //kompilator sam da w to miejsce: {return a;}
            private set;    //a tutaj da {a=value;} (ale my daliśmy private więc jest Read Only)
        }
        public double B
        {
            get;
            private set;  //więc B jest Read Only
        }
        public double C
        {
            get;
            private set;
        }

        public Triangle(double a = 1, double b = 1, double c = 1) //jeżeli odpalisz pusty konstruktor 
        {                                                         //to to będzie wersja default
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Boki powinny być dodatnie");

            if (a + b <= c || a + c <= b || c + b <= a)
                throw new ArgumentException("Niespełniony warunek trójkąta.");

            A = a;
            B = b;
            C = c;
        }

        public override string ToString() //metoda wypisująca nam obiekt
        {
            return $"triangle(a: {A}, b: {B}, c: {C})";
        }

        public double Perimeter => A + B + C;
        

        public Triangle Scale(double factor) //metoda produkująca nowy obiekt 
                                             //o żądanych wartościach w oparciu o stary obiekt
        {
            if (factor < 0)
                throw new ArgumentOutOfRangeException("współczynnik skalowania musi byc dodatni");
            
            return new Triangle(A * factor, B * factor, C * factor);
        }

        public override void Draw()
        {
            Console.WriteLine("rysowanie trojkata");
        }
    }
}
