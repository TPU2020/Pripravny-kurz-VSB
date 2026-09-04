using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE14
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E14-----");
            Random random = new Random();

            int[] arrayOfNumbers = new int[20];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next(1, 11);
            }
            Console.WriteLine($"Hodnoty [{string.Join(", ", arrayOfNumbers)}]");

            int j = arrayOfNumbers.Length - 2;
            int temp = 0;
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for (int i = 0; i <= j; i++)
                {
                    if (arrayOfNumbers[i] > arrayOfNumbers[i + 1])
                    {
                        temp = arrayOfNumbers[i];
                        arrayOfNumbers[i] = arrayOfNumbers[i + 1];
                        arrayOfNumbers[i + 1] = temp;
                        swapped = true;
                    }
                }
                j--;
            }

            Console.WriteLine($"Hodnoty [{string.Join(", ", arrayOfNumbers)}]");
        }
    }
}
