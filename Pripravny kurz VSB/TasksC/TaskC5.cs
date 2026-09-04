using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC5
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C5-----");

            Random random = new Random();
            double randomSum = 0;
            for (int i = 0; i < 20; i++)
            {
                randomSum += random.Next(10, 51);
            }
            double randomAvg = randomSum / 20;
            Console.WriteLine($"Střední hodnota 20 náhodných čísel ({randomAvg:F2}) v rozsahu 10-50 se liší od středního intervalu (30) o: {Math.Abs(randomAvg - 30):F2}");
        }
    }
}
