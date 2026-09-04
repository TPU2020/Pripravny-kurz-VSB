using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB1
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B1-----");

            Console.WriteLine("Máme nerovnost (x + 3) < (5 * y - 1)");
            Console.Write("Zadejte číslo x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Zadejte číslo y: ");
            double y = double.Parse(Console.ReadLine());

            string comparisonResult = (x + 3) < (5 * y - 1) ? "splňuje" : "nesplňuje";

            Console.WriteLine($"Podmínka (x + 3) < (5 * y - 1) {comparisonResult} nerovnost.");
        }
    }
}       
