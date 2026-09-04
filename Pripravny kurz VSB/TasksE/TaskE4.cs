using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE4
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E4-----");
            Random random = new Random();

            int[] arrayValues = new int[5];
            int i = 0;
            do
            {
                int value = random.Next(1, 50);
                if (arrayValues.Contains(value))
                {
                    continue;
                }
                arrayValues[i] = value;
                i++;
            } while (i < arrayValues.Length);

            Console.WriteLine($"Čísla Sportky: {string.Join(" ", arrayValues)}");
        }

    }
}
