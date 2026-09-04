using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF22
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F2-2-----");
            Random random = new Random();

            int[] loteryNumbers = new int[20];

            for (int i = 0; i < 20; i++)
            {
                loteryNumbers[i] = random.Next(1, 50);
            }

            Console.WriteLine($"Losované čísla loterie ({loteryNumbers.Length})\n{string.Join("\t", loteryNumbers)}");

            int[] numbersWithoutDuplicates = RemoveDuplicates(loteryNumbers);
            Console.WriteLine($"Losované čísla loterie bez duplikátů ({numbersWithoutDuplicates.Length})\n{string.Join("\t", numbersWithoutDuplicates)}");
        }

        private static int[] RemoveDuplicates(int[] loteryNumbers)
        {
            int[] resultNumbers = new int[loteryNumbers.Length];
            int counter = 0;
            foreach (int i in loteryNumbers)
            {
                if (!resultNumbers.Contains(i))
                {
                    resultNumbers[counter] = i;
                    counter++;
                }
            }
            Array.Resize(ref resultNumbers, counter);
            return resultNumbers;
        }
    }
}
