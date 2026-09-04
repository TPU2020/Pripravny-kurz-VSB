using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC15
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C15-----");

            Random random = new Random();
            int prevNumber = 0;
            for (int i = 1; i <= 100; i++)
            {
                int currentNumber = random.Next(1, 6);
                Console.Write(currentNumber);
                if (currentNumber == prevNumber)
                    Console.WriteLine($" --> Stejná čísla s pořadovým číslem {i} a {i - 1}");
                else
                    Console.WriteLine();
                prevNumber = currentNumber;
            }
        }
    }
}
