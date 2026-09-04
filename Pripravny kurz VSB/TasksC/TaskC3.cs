using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC3
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C3-----");

            Random random = new Random();
            string choosenNumbers = "Výsledné čísla Sportky:";
            for (int i = 0; i < 5; i++)
            {
                int randomValue = random.Next(1, 50);
                choosenNumbers += $" {randomValue}";
            }
            Console.WriteLine(choosenNumbers);
        }
    }
}
