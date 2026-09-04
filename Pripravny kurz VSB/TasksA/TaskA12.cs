using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksA
{
    internal class TaskA12
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task A12-----");
            Console.Write("Zadejte průměr krohového bazénu: ");
            double diameter = double.Parse(Console.ReadLine());
            Console.Write("Zadejte hloubku bazénu: ");
            double height = double.Parse(Console.ReadLine());
            double radius = diameter / 2;
            double volume = Math.PI * radius * radius * height;
            Console.WriteLine($"Do bazénu se vejde {volume:F2} t vody");
        }
    }
}
