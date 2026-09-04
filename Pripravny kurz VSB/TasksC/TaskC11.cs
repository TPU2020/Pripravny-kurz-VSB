using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC11
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C11-----");

            for (int i = 65; i <= 90; i++)
            {
                char znak = (char)i;
                Console.WriteLine($"{i}\t{znak}");
            }
        }
    }
}
