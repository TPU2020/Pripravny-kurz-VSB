using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksA
{
    internal class TaskA1
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task A1-----");

            Console.Write("Zadejte počet dnů: ");
            int days = int.Parse(Console.ReadLine());
            Console.Write("Zadejte počet hodin: ");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine($"Celkový počet hodin: {days * 24 + hours}");
        }
    }
}
