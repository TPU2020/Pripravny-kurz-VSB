using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksA
{
    internal class TaskA6
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task A6-----");

            Console.Write("Zadejte poloměr kruhu: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Obsah kruhu: {(Math.PI * radius * radius):F2}");
            Console.WriteLine($"Obvod kruhu: {(2 * Math.PI * radius):F2}");
        }
    }
}
