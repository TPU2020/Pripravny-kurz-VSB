using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB12
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B12-----");

            Console.Write("Je den (a/n)? ");
            char isDay = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Je horko (a/n)? ");
            char isHot = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (isDay == 'a' && isHot == 'a')
            {
                Console.WriteLine("Jdi si zaplavat.");
            }
            else
            {
                Console.WriteLine("Zůstaň doma.");

            }
        }
    }
}
