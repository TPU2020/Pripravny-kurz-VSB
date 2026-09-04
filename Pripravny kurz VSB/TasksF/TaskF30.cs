using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF30
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F2-10-----");
            Random random = new Random();

            int[] values = new int[50];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(1, 101);
            }
            Console.WriteLine($"Náhodná řada s hodnotami\n{string.Join(" ", values)}\nje seřazena\n{string.Join(" ",SerazenePole(values))}");
        }

        private static int[] SerazenePole(int[] values)
        {
            if (values == null || values.Length < 2)
            {
                return values;
            }
            int j = values.Length - 2;
            int temp = 0;
            bool swapped = true;
            int[] sortedValues = new int[values.Length];
            Array.Copy(values, sortedValues, values.Length);
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i <= j; i++)
                {
                    if (sortedValues[i] > sortedValues[i + 1])
                    {
                        temp = sortedValues[i];
                        sortedValues[i] = sortedValues[i + 1];
                        sortedValues[i + 1] = temp;
                        swapped = true;
                    }
                }
                j--;
            }

            return sortedValues;

        }
    }
}
