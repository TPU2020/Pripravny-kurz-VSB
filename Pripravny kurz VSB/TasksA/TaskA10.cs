using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksA
{
    internal class TaskA10
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task A10-----");

            Console.Write("Zadejte úhel v radianech: ");
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine($"Úhel {angle} v radianech je {angle * (180 / Math.PI):F2} stupňů");
        }
    }
}
