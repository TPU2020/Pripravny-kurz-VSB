using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksA
{
    internal class TaskA4
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task AA-----");

            Console.Write("Zadejte rychlost v m/s: ");
            double speed = double.Parse(Console.ReadLine());
            Console.WriteLine($"Rychlost v km/h: {speed * 3.6:F2}");
        }
    }
}
