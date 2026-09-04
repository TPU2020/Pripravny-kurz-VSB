using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksA
{
    internal class TaskA5
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task A5-----");

            Console.Write("Zadejte částku peněz (Kč): ");
            double amount = double.Parse(Console.ReadLine());
            Console.Write("Zadejte úrok (%): ");
            double interest = double.Parse(Console.ReadLine());
            Console.Write("Zadejte počet let uložení: ");
            int years = int.Parse(Console.ReadLine());
            double finalAmount = amount * Math.Pow(1 + interest / 100, years);
            Console.WriteLine($"Částka po {years} letech: {finalAmount:F2} Kč");
        }
    }
}
