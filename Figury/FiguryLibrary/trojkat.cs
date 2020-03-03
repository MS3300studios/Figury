using System;

namespace FiguryLibrary
{
    public class Trojkat
    {
        //dane obniektu (zmienne)
        private double a; //this.a
        public double A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość a musi być dodatnia");
                else if
                    (isSpelnionyWarunekTrojkata(value, b, c)) a = value;
                else //nie jest spełniony warunek trójkąta
                    throw new ArgumentException("nie jest spełniony warunek trojkata przy próbie zmiany A");

            }
        }

        private double b; //this.b
        public double B
        {
            get => b; //można krócej zamiast { return a; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("wartość b musi być dodatnia");
                else if
                    (isSpelnionyWarunekTrojkata(a, value, c)) b = value;
                else //nie jest spełniony warunek trójkąta
                    throw new ArgumentException("nie jest spełniony warunek trojkata przy próbie zmiany B");
            }
        }
        private double c; //this.c
        public double C
        {
            get => c; //można krócej zamiast { return a; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("wartość c musi być dodatnia");
                else if
                    (isSpelnionyWarunekTrojkata(a, b, value)) c = value;
                else //nie jest spełniony warunek trójkąta
                    throw new ArgumentException("nie jest spełniony warunek trojkata przy próbie zmiany C");
            }
        }

        private bool isSpelnionyWarunekTrojkata(double a, double b, double c)
        {

            if (a + b <= c || a + c <= b || b + c <= a) 
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }




        // konstruktory
        public Trojkat() //konstruktor domyślny (bez argumentów)
        {
            a = b = c = 1.0;
        }
        public Trojkat(double a, double b, double c) //te double są user inputem
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Boki muszą być dodatnie");

            if (!isSpelnionyWarunekTrojkata(a, b, c)) //jeżeli funkcja isSpelniony... nie wyrzuci wartości true
                throw new ArgumentException("Nie spełniony warunekt trójkąta!");

            this.a = a; //private double a = (user input) double a;
            this.b = b;
            this.c = c;
        }


        //tekstowa reprezentacja obiektu
        public override string ToString()
        {
            return $"Trojkąt(a: {a},b: {b},c: {c})";
        }


        //właściwości i metody
        public double GetObwod()            //java style
        {
            return a + b + c;
        }

        //property zwracające obwód tego trójkąta
        //piszemy w jednej liniice bo kod jest prosty
        public double Obwod => a + b + c;   //C# style

        //piszemy to w metodzie bo kod jest skomplikowany
        public double GetPole() //java style
        {
            var p = 0.5 * GetObwod();
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        public double Pole // C# style
        {
            get
            {
                var p = 0.5 * Obwod;
                var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }

        }

    }


}
