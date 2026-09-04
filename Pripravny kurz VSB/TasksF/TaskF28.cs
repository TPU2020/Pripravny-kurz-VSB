using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF28
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F2-8-----");

            Random random = new Random();

            int[] values = new int[30];
            values = Enumerable.Range(1, 20).ToArray();
            values[10] = 1;
            int faultIndex = JeRadaSerazena(values);
            Console.WriteLine($"Řada s hodnotami\n{string.Join(" ", values)}\n{(faultIndex == -1 ? "je seřazena vzestupně" : ((faultIndex + 1) + " index narušuje řadu"))}");

        }

        private static int JeRadaSerazena(int[] values)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                if (values[i] > values[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
