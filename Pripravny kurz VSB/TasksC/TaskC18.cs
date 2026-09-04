using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC18
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C18-----");

            for (int i = 2; i <= 1000; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
