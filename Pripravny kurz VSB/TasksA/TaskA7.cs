using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksA
{
    internal class TaskA7
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task A7-----");

            Console.Write("Zadejte počet sudů: ");
            int barrelCount = int.Parse(Console.ReadLine());
            Console.Write("Zadejte počet litrů v sudu: ");
            int litersPerBarrel = int.Parse(Console.ReadLine());

            Console.WriteLine($"Celkový počet litrů: {barrelCount * litersPerBarrel}");

        }
    }
}
