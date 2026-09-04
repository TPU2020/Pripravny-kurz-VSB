using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC13
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C13-----");

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    string output = (i == 0 && j == 0) ? "\t" : $"{(i == 0 ? 1 : i) * (j == 0 ? 1 : j)}\t";
                    Console.Write(output);
                }
                Console.WriteLine();
            }
        }
    }
}
