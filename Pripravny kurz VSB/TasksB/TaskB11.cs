using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB11
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B11-----");

            Console.Write("Zadejte délku první strany obdelníka: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Zadejte délku druhé strany obdelníka: ");
            double side2 = double.Parse(Console.ReadLine());

            if (side1 > 0 && side2 > 0)
            {
                if (side1 != side2)
                {
                    Console.WriteLine($"Obdelník má rozměry {side1} x {side2}");
                }
                else
                {
                    Console.WriteLine($"Čtverec má stranu délky {side1}");
                }
            }
            else
            {
                Console.WriteLine("Délky stran musí být kladné číslo.");
            }
        }
    }
}
