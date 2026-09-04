using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC16
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C16-----");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++) Console.Write($"{j.ToString()}");
                Console.WriteLine();
            }
        }
    }
}
