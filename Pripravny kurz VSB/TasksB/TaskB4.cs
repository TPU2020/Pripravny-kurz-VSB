using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB4
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B4-----");

            Console.Write("Zadejte první číslo: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Zadejte druhé číslo: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Zadejte třetí číslo: ");
            double num3 = double.Parse(Console.ReadLine());

            double highest;
            double lowest;

            if (num1 >= num2)
            {
                if (num1 >= num3)
                {
                    highest = num1;
                }
                else
                {
                    highest = num3;
                }
            }
            else
            {
                if (num2 >= num3)
                {
                    highest = num2;
                }
                else
                {
                    highest = num3;
                }
            }

            if (num1 <= num2)
            {
                if (num1 <= num3)
                {
                    lowest = num1;
                }
                else
                {
                    lowest = num3;
                }
            }
            else
            {
                if (num2 <= num3)
                {
                    lowest = num2;
                }
                else
                {
                    lowest = num3;
                }
            }

            Console.WriteLine($"Největší číslo je: {highest}");
            Console.WriteLine($"Nejmenší číslo je: {lowest}");

        }
    }
}
