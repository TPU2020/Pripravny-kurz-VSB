using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksD
{
    internal class TaskD6
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task D6-----");

            Random random = new Random();
            Console.WriteLine("Uhádní náhodné číslo v rozmezí 1-10");
            int target = random.Next(1, 11);
            int guess;

            do
            {
                Console.Write("Zadejte svůj náhodný tip: ");
                guess = int.Parse(Console.ReadLine());
            }
            while (guess != target);
            Console.WriteLine("Gratulujeme! Uhádli jste číslo.");
        }
    }
}
