using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE13
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E13-----");
            Random random = new Random();

            int[] arrayOfNumbers = new int[20];
            int[] arrayOfSingletons = new int[arrayOfNumbers.Length];
            int arrayOfSingletonsCount = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next(1, 11);
            }
            Console.WriteLine($"Hodnoty [{string.Join(", ", arrayOfNumbers)}]");

            for (int i = 0;i < arrayOfNumbers.Length; i++)
            {
                if (!arrayOfSingletons.Contains(arrayOfNumbers[i]))
                {
                    arrayOfSingletons[arrayOfSingletonsCount] = arrayOfNumbers[i];
                    arrayOfSingletonsCount++;
                }
            }

            Console.WriteLine($"Hodnoty [{string.Join(", ", arrayOfSingletons)}]");
        }
    }
}
