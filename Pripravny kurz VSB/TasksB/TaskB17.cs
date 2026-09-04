using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB17
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B17-----");

            Console.Write("Zadejte částku v Kč: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.Write("Zadejte měnu (USD/EUR/GBP): ");
            string currency = Console.ReadLine().ToUpper();

            string result = currency switch
            {
                "USD" => (amount * 0.0480m).ToString("F2") + " USD",
                "EUR" => (amount * 0.0414m).ToString("F2") + " EUR",
                "GBP" => (amount * 0.0355m).ToString("F2") + " GBP",
                _ => "Neznámá měna."
            };
            Console.WriteLine($"Výsledek: {result}");

        }
    }
}
