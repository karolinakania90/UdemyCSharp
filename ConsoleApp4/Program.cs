using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ;)
            {
                Console.Write("Wpisz swoje imię: ");
                string name = Console.ReadLine();

                Console.WriteLine("Witaj, " + name);

                Console.Write("Podaj wiek: ");
                int age;
                bool result = int.TryParse(Console.ReadLine(), out age);

                if (age > 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Możesz się napić piwa!");
                }
                else if (result == false)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Wprowadź poprawny wiek!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zostań przy mleku :)");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }

           

        }
    }
}
