using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC7
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C7-----");

            Random random = new Random();
            Console.WriteLine("Simulace kurzu měny (EUR)");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{random.NextDouble() + random.Next(24, 26):F2}{(i % 5 == 0 ? '\n' : '\t')}");
            }
        }
    }
}
