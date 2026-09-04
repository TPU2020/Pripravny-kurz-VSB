using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC1
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C1-----");

            for (double i = 0; i <= 2 * Math.PI; i += 0.1)
            {
                Console.WriteLine($"sinus ({i:F2}) \t {Math.Sin(i):F2}");
            }
        }
    }
}
