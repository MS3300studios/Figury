using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    abstract public class Figure
    {
        public string Color { get; set; } //read-write

        public Figure (string color = "black")   //konstruktor
        {
            Color = color;
        }
        
        public void Print()
        {
            Console.WriteLine($"figure {this}, color = {Color}"); //this to konkretny obiekt na rzecz której 
                                                                    //wywołana jest metoda print
        }
        abstract public void Draw(); //rysowanie figury za pomocą maszyny do pisania
        
    
    }
}
