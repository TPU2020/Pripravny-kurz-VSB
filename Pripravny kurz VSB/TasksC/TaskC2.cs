using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC2
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C2-----");

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                double randomValue = random.Next(-100, 101);
                string inRange = randomValue > 35 && randomValue < 63 ? "je" : "není";
                Console.WriteLine($"Náhodné číslo {randomValue} {inRange} v rozmezí 35-63");
            }
        }
    }
}
