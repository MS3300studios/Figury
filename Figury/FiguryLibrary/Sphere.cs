using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Sphere : Circle, IMeasurable2D
    {
        public Sphere(double r = 1) : base(r) //konstuktor Circle z promieniem koła r =1
                                              //wkładamy tu zmienną r z tąd używając
                                              //konstruktora z Klasy Circle
        {
        }
        public override string ToString()
        {
            return $"Sphere ({R})";
        }
        public override double Surface => 4 * base.Surface;

        
        public new double Perimeter   //tworzymy nowy property żeby zasłonić stary (zamiast pisać override)
        {
            get
            {
                throw new NotSupportedException("Sfera nie ma obwodu");
            }
        }
        public new Sphere Scale(double factor)
        {
            if (factor <= 0)
                throw new ArgumentOutOfRangeException("bla bla bla");

            return new Sphere(R * factor);
        }

    }
}
