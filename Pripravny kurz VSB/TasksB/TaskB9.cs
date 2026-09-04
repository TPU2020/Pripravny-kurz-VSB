using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB9
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B9-----");

            Console.Write("Zadejte první číslo: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Zadejte druhé číslo: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"První číslo je větší");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"První číslo je menší");
            }
            else
            {
                Console.WriteLine("Obě čísla jsou stejná.");
            }
        }
    }
}
