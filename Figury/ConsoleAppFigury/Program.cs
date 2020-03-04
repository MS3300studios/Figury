using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguryLibrary; //dołączony namespace

namespace ConsoleAppFigury
{
    class Program
    {
        static void Main()
        {
            var t = new Triangle();
            Console.WriteLine(t);
            Console.WriteLine(t.Color);
            t.Print();

            var s = new Sphere(10);
            Console.WriteLine($"s:{s}");
            Console.WriteLine(s.Surface);
            Console.WriteLine(s.Perimeter);
        }
        static void Main2()
        {
            Triangle t = new Triangle();
            Console.WriteLine(t);

            var t1 = new Triangle(1.5, 1, 1);
            Console.WriteLine(t1);

            //var t2 = new Triangle(3); //pozostałe boki == 1
           // Console.WriteLine(t2);

            var t3 = t1.Scale(2); //utwórz trójkąt 2 razy wiekszy od t1
            Console.WriteLine($"t3: {t3}");  



        }
        static void Main1(string[] args)
        {
            Trojkat t1; //deklaracja zmiennej typu Trojkat
            t1 = new Trojkat(); //new używamy zawsze do tworzenia obiektu

            Trojkat t2 = new Trojkat(3, 4, 5);
            var t3 = new Trojkat(c: 1, b: 2, a: 2); //inny sposób na tworzenie obiektu
                                                    //^zamiast pisać trójkąt to to jest oczywiste że var jest trójkątem, krótszy zapis



            /*Console.WriteLine(t1);
            Console.WriteLine($"obwód: {t1.GetObwod()}"); //uzycie zmiennej liczącej obwód
            Console.WriteLine($"obwód: {t1.Obwod}");      //uzycie property o nazwie obwód
            Console.WriteLine($"Pole: {t1.GetPole()}");   
            Console.WriteLine($"Pole: {t1.Pole}");
            
            Console.WriteLine(t1);
            Console.WriteLine(t1.Pole);

            Console.WriteLine("===============================================");
            t2.A = 100;
            Console.WriteLine(t2);*/

            //Console.WriteLine("Pole 111");
            //Console.WriteLine(t1.Pole);
            Console.WriteLine("Pole 345");
            Console.WriteLine(t2.Pole);
            
           
           




        }
    }
}
