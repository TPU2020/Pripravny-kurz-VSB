using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF5
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F5-----");

            Console.Write("Zadejte částku v CZK: ");
            double money = double.Parse(Console.ReadLine());
            Console.Write("Zadejte zkratku měny pro převod (EUR, USD, GBP): ");
            string curency = Console.ReadLine().ToUpper();

            Console.WriteLine($"Částka {money} CZK je {Kurs(money, curency):F2x} {curency}");

        }

        private static double Kurs(double money, string? curency)
        {
            double moneyConverted = curency switch
            {
                "USD" => money * 0.041,
                "EUR" => money * 0.048,
                "GBP" => money * 0.035,
                _ => money
            };
            return moneyConverted;
        }
    }

}
