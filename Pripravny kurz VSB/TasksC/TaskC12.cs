using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC12
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C12-----");

            Random random = new Random();
            int hitSum = 0;
            bool firstHit = false;
            for (int i = 0; i < 100; i++)
            {
                double hit = random.NextDouble() + random.Next(2,4);
                if (hit >= 2.95 && hit <= 3.05) {
                    hitSum++;
                    if (!firstHit)
                    {
                        Console.WriteLine($"První zásah při {i} pokusu! {hit:0.00}");
                        firstHit = true;
                    }
                    else
                    {
                        Console.WriteLine($"Zásah! {hit:0.00}");
                    }
                }
            }
            Console.WriteLine($"Počet zásahů: {hitSum}");
        }
    }
}
