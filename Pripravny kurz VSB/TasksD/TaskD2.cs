using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksD
{
    internal class TaskD2
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task D2-----");

            double receiptSum = 0;
            int receiptCount = 0;
            int receiptOver100Count = 0;
            do
            {
                Console.Write($"Zadejte částku {receiptCount + 1} (0 -> konec): ");
                double receiptAmount = double.Parse(Console.ReadLine());

                if (receiptAmount <= 0)
                    break;

                receiptSum += receiptAmount;
                receiptCount++;
                if (receiptAmount > 100)
                {
                    receiptOver100Count++;
                }
            } while (true);

            if (receiptCount > 0)
            {
                Console.WriteLine($"Celková částka: {receiptSum:F2}");
                Console.WriteLine($"Počet účtenek nad 100 Kč: {receiptOver100Count}");
            }
        }
    }
}
