using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksA
{
    internal class TaskA11
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task A11-----");

            Console.Write("Zadejte délku běžecké trati v metrech: ");
            double trackLength = double.Parse(Console.ReadLine());
            Console.Write("Zadejte čas běhu ve vteřinách: ");
            double time = double.Parse(Console.ReadLine());
            Console.WriteLine($"Průměrná rychlost běžecké trati je {trackLength / time} m/s");
        }
    }
}
