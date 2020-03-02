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
        static void Main(string[] args)
        {
            Trojkat t1; //deklaracja zmiennej typu Trojkat
            t1 = new Trojkat(); //new używamy zawsze do tworzenia obiektu
            Trojkat t2 = new Trojkat(-1, 2, 1);
            var t3 = new Trojkat(c: 1, b: 2, a: 2); //inny sposób na tworzenie obiektu
           //^zamiast pisać trójkąt to to jest oczywiste że var jest trójkątem, krótszy zapis



            Console.WriteLine(t1);
            Console.WriteLine($"obwód: {t1.GetObwod()}"); //uzycie zmiennej liczącej obwód
            Console.WriteLine($"obwód: {t1.Obwod}");      //uzycie property o nazwie obwód
            Console.WriteLine($"Pole: {t1.GetPole()}");   
            Console.WriteLine($"Pole: {t1.Pole}");
            try
            {
                t1.A = -1;
                t1.B = -2;
                t1.C = -3;
            }   
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Nie wolno bokom przypisywać wartości ujemnych");
            }
            Console.WriteLine(t1);
            Console.WriteLine(t1.Pole);

            Console.WriteLine("===============================================");
            Console.WriteLine(t2);



            

    }
    }
}
