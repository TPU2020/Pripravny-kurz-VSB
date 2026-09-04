using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB16
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B16-----");

            Console.Write("Zadejte první číslo: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Zadejte druhé číslo: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Zvolte operaci (sčítání/odčítání/násobení/dělení): ");
            string operation = Console.ReadLine();

            string result = operation switch
            {
                "sčítání" => (num1 + num2).ToString(),
                "odčítání" => (num1 - num2).ToString(),
                "násobení" => (num1 * num2).ToString(),
                "dělení" => num2 != 0 ? (num1 / num2).ToString() : "Nelze dělit nulou.",
                _ => "Neznámá operace."
            };
            Console.WriteLine($"Výsledek: {result}");
        }
    }
}