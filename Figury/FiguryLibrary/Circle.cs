using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Circle : Figure
    {
        public double R
        {
            get;
            private set;
        }

        public Circle (double r = 1)
        {
            if (r <= 0) throw new ArgumentOutOfRangeException("promień musi być dodatni");

            R = r;
        }

        public override string ToString()
        {
            return $"R: {R}";
        }

        public double Perimeter
        {
            get
            {
                var p = 2 * Math.PI * R;
                return p;
            }
        }
        public double Surface
        {
            get
            {
                var s = Math.PI * R * R;
                return s;
            }
        }

        public Circle Scale(double factor)
        {
            if (factor <= 0) throw new ArgumentException("wsp. musi być dodatni!");
            return new Circle(R*factor);
        }

        public override void Draw()
        {
            Console.WriteLine("Rysowanie kółka");
        }
    }
}
