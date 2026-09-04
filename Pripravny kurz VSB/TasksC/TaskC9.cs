using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC9
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C9-----");

            Console.Write("Zadejte celé číslo 1-100: ");
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    Console.WriteLine("Dělitel: " + i);
            }
        }
    }
}
