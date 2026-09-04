using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB2
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B2-----");

            Console.Write("Zadejte číslo x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Zadejte číslo y: ");
            double y = double.Parse(Console.ReadLine());
            string comparisonResult = (x % y == 0) && y != 0 ? "je" : "není";
            Console.WriteLine($"Číslo x {comparisonResult} dělitelné číslem y.");
        }
    }
}
