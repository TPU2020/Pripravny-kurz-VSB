using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB3
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B3-----");

            Console.Write("Zadejte číslo x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Zadejte číslo y: ");
            double y = double.Parse(Console.ReadLine());

            if (x * y != 0)
            {
                double result = 1/(x * y);
                Console.WriteLine($"Výsledek dělení 1 / (x * y) je: {result}");
            }
            else
            {
                Console.WriteLine("Nelze dělit nulou.");
            }
        }
    }
}
