using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE9
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E9-----");
            Random random = new Random();
            int[] counts = new int[6];
            int atempts = 0;

            Console.Write("Zvolte počet hodů kostkou (>5): ");
            do
            { 
                atempts = int.Parse(Console.ReadLine());
                if(atempts > 5)
                {
                    break;
                }
                else
                {
                    Console.Write("Hodnota musí být větší než 5: ");
                }

            } while (true);


            int[] arrayValues = new int[atempts];
            for (int i = 0; i < arrayValues.Length; i++)
            {
                arrayValues[i] = random.Next(1, 7);
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
