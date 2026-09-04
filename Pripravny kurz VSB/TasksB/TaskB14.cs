using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB14
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B14-----");

            Console.Write("Chcete skončit? (a/n): ");
            char choice = Console.ReadKey().KeyChar;
            if (choice == 'a')
            {
                Console.WriteLine("Skončili jste.");
            }
            else
            {
                Console.WriteLine("A stejně končím!");
            }
        }
    }
}
