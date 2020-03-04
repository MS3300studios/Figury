using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Sphere : Circle
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
    }
}
