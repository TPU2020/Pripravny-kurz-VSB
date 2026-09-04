using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE12
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E12-----");
            Random random = new Random();

            int[] arrayOfNumbers = new int[20];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next(0, 11);
            }

            int[] localMaximaIndexes = new int[arrayOfNumbers.GetLength(0) / 2];
            int localMaximaCount = 0;

            for (int i = 1; i < arrayOfNumbers.Length - 1; i++)
            {
                if (arrayOfNumbers[i - 1] < arrayOfNumbers[i] && arrayOfNumbers[i + 1] < arrayOfNumbers[i])
                {
                    localMaximaIndexes[localMaximaCount] = i;
                    localMaximaCount++;
                }
            }
            Console.WriteLine($"Hodnoty [{string.Join(", ", arrayOfNumbers)}]");
            Console.WriteLine($"Indexy lokálních maxim [{string.Join(", ",localMaximaIndexes)}]");
        }
    }
}
