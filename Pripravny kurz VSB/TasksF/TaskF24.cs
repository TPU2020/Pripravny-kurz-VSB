using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF24
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F2-4-----");
            Random random = new Random();

            int[] values = new int[20];
            int searchedValue = 0;
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(1, 11);
            }
            Console.Write("Zadejte hledané číslo (1-10): ");
            searchedValue = int.Parse(Console.ReadLine());


            Console.WriteLine($"Počet opakování čísla {searchedValue} v řadě\n {string.Join(" ", values)} \nje {PocetOpakovani(values, searchedValue)}");
        }

        public static int PocetOpakovani(int[] values, int searchedNumber)
        {
            int foundCounter = 0;
            if (values == null || values.Length <= 0)
            {
                return 0;
            }

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == searchedNumber)
                {
                    foundCounter++;
                }
            }

            return foundCounter;
        }
    }
}
