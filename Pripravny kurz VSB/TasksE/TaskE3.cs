using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE3
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E3-----");
            Random random = new Random();
            int[] arrayValues = new int[20];
            int[] counts = new int[6];

            for (int i = 0; i < arrayValues.Length; i++) 
            {
                int value = int.Parse(Console.ReadLine());
                if (value < 1 || value > 6)
                {
                    Console.WriteLine("Neplatný vstup. Zadejte číslo mezi 1 a 6.");
                    i--;
                    continue;
                }
                arrayValues[i] = value;
                counts[arrayValues[i] - 1]++;
            }
            Console.WriteLine("Hody kostkou:");
            Console.WriteLine(string.Join(" ", arrayValues));

            Console.WriteLine("Počet výskytů jednotlivých čísel:");
            for (int i = 0; i < counts.Length; i++)
                Console.WriteLine($"Číslo {i + 1}: {counts[i]} ({Math.Round((double)counts[i] / arrayValues.Length * 100, 2)}%)");
        }
    }
}
