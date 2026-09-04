using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF29
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F2-9-----");

            Random random = new Random();

            int[] values = new int[30];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = i * 3;
            }
            values[10] = 29;

            Console.WriteLine($"Řada s hodnotami\n{string.Join(" ", values)}\n{(JeAritmetickaRada(values) ? "je" : "není")} aritmetická řada.");

        }

        private static bool JeAritmetickaRada(int[] values)
        {
            int aritmeticDifference = values[1] - values[0];

            for (int i = 0; i < values.Length - 1; i++)
            {
                if ((values[i + 1] - values[i]) != aritmeticDifference)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
