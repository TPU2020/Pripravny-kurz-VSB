using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksA
{
    internal class TaskA8
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task A8-----");
            Console.Write("Zadejte číslo: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Druhá mocnina čísla {number} je {number * number}");
        }
    }
}
