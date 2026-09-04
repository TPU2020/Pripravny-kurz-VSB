using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB10
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B10-----");

            Console.Write("Zadejte číslo: ");
            double number = double.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"Druhá odmocnina čísla {number} je {Math.Sqrt(number)}");
            }
            else
            {
                Console.WriteLine("Nelze vypočítat druhou odmocninu záporného čísla nebo nuly.");
            }

        }
    }
}
