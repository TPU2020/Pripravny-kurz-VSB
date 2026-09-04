using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF26
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F2-6-----");
            Random random = new Random();

            int[] values = new int[30];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(1, 101);
            }
            Console.WriteLine($"Pro řadu čísel\n{string.Join(" ", values)}\n\nbyly odstraněny všechny lichá čísla a zůstala tato řada\n{string.Join(" ",SudaCislaZPole(values))}");

        }

        private static int[] SudaCislaZPole(int[] values)
        {
            int[] result = new int[values.Length];
            int evenCounter = 0;

            foreach (int i in values)
            {
                if (i % 2 == 0)
                {
                    result[evenCounter] = i;
                    evenCounter++;
                }
            }

            Array.Resize(ref result, evenCounter);
            return result;
        }
    }
}
