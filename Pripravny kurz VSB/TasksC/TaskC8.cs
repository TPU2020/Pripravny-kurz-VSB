using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC8
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C8-----");

            Console.Write("Zadejte celé číslo: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= number; i++)
                sum += i;

            Console.WriteLine($"Součet čísel od 1 do {number} je {sum}");
        }
    }
}
