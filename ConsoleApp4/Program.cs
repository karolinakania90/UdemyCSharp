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
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);

            Console.Write("Podaj wiek: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.WriteLine("Możesz się napić piwa!");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadź poprawny wiek!");
            }
            else
            {
                Console.WriteLine("Zostań przy mleku :)");
            }
            Console.ReadKey();

        }
    }
}
