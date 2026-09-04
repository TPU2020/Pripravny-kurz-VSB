using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF21
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F2-1-----");

            decimal[] peopleSavings = new decimal[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Zadejte úspory {i + 1}. osoby: ");
                peopleSavings[i] = decimal.Parse(Console.ReadLine());
            }

            Console.Write("Zadejte výší roční úrokové sazby: ");
            double interest = double.Parse(Console.ReadLine());

            decimal[] peopleSavingsWithInterest = CalculateInterests(peopleSavings, interest);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Celkové úspory {i + 1}. osoby = {peopleSavingsWithInterest[i]} Kč");
            }
        }

        public static decimal[] CalculateInterests(decimal[] savings, double interest)
        {
            decimal[] resultSavings = new decimal[savings.Length];
            for (int i = 0; i < savings.Length; i++)
            {
                resultSavings[i] = savings[i] + savings[i] * (decimal)(interest / 100.0);
            }

            return resultSavings;
        }
    }
}
