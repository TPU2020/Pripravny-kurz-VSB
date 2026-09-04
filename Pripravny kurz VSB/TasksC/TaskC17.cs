using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC17
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C17-----");
            
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < random.Next(1, 21); j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
