using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksA
{
    internal class TaskA9
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task A9-----");

            Console.Write("Očekávaný zisk: ");
            double expectedProfit = double.Parse(Console.ReadLine());
            Console.Write("Skutečný zisk: ");
            double actualProfit = double.Parse(Console.ReadLine());

            Console.WriteLine($"Bylo dosaženo {(actualProfit / expectedProfit):P2} zisku");
        }
    }
}
