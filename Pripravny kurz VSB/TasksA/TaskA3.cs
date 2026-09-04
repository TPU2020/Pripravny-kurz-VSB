using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksA
{
    internal class TaskA3
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task A3-----");

            double tempSum = 0;

            Console.Write("Zadejte teplotu v 6:00 (°C): ");
            tempSum += double.Parse(Console.ReadLine());

            Console.Write("Zadejte teplotu v 12:00 (°C): ");
            tempSum += double.Parse(Console.ReadLine());

            Console.Write("Zadejte teplotu v 18:00 (°C): ");
            tempSum += double.Parse(Console.ReadLine());

            double averageTemp = tempSum / 3;
            Console.WriteLine($"Průměrná teplota: {averageTemp:F2} °C");

        }
    }
}
