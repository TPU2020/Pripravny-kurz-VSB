using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF27
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F2-7-----");

            Random random = new Random();

            int[] values = new int[30];
            values = Enumerable.Range(1, 20).ToArray();
            values[10] = 1;

            Console.WriteLine($"Řada s hodnotami\n{string.Join(" ", values)}\n{(JeRadaSerazena(values) ? "je":"není")} seřazena vzestupně.");

        }

        private static bool JeRadaSerazena(int[] values)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                if (values[i] > values[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
