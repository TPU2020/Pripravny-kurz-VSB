using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE5
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E5-----");
            Random random = new Random();
            int[] arrayValues = new int[10];
            for (int i = 0; i < arrayValues.Length; i++) arrayValues[i] = random.Next(0, 11);
            Console.WriteLine(string.Join(" ", arrayValues));

            int arraySum = 0;
            foreach (int value in arrayValues)
            {
                arraySum += value;
            }

            double arrayAverage = (double)arraySum / arrayValues.Length;

            int arrayMaxValue = arrayValues[0];
            foreach (int value in arrayValues)
            {
                if (value > arrayMaxValue)
                {
                    arrayMaxValue = value;
                }
            }

            int arrayMin = arrayValues[0];
            foreach (int value in arrayValues)
            {
                if (value < arrayMin)
                {
                    arrayMin = value;
                }
            }

            int arrayZeroCount = 0;
            foreach (int value in arrayValues)
            {
                if (value == 0)
                {
                    arrayZeroCount++;
                }
            }

            Console.WriteLine($"Součet: {arraySum}");
            Console.WriteLine($"Průměr: {arrayAverage:F2}");
            Console.WriteLine($"Max Hodnota: {arrayMaxValue}");
            Console.WriteLine($"Min Hodnota: {arrayMin}");
            Console.WriteLine($"Počet Nul: {arrayZeroCount}");

        }
    }
}
