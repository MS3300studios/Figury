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
                if (value <= 0) throw new ArgumentOutOfRangeException("wartość a musi być dodatnia");
                else a = value;       
            }
        }
       
        private double b; //this.b
        public double B
        {
            get => b; //można krócej zamiast { return a; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("wartość b musi być dodatnia");
                else b = value;
            }
        }
        private double c; //this.c
        public double C
        {
            get => c; //można krócej zamiast { return a; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("wartość c musi być dodatnia");
                else c = value;
            }
        }






        // konstruktory
        public Trojkat() //konstruktor domyślny (bez argumentów)
        {
            a = b = c = 1.0;
        }
        public Trojkat(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a) //jeżeli choć jedna z tych kombinacji boków będzie true to wszystko będzie true
            {
                throw new ArgumentException("niespełniony warunek trójkąta");
            }

            A = a; //(wcześniej było this.a tutaj) this.a zawsze będzie zmienną z klasy
            B = b;
            C = c;
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
