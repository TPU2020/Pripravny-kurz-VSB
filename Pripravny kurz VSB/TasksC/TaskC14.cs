using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC14
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C14-----");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++) Console.Write("*");
                Console.WriteLine();
            }
            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < i; j++) Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
