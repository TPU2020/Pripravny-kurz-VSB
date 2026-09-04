using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksD
{
    internal class TaskD7
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task D7-----");

            Random random = new Random();
            int roll = 0;
            int attempts = 0;
            do
            {
                roll = random.Next(1, 7);
                Console.WriteLine($"Hážu kostkou... {roll}");
                attempts++;
            }
            while (roll != 6);
            Console.WriteLine("Gratulujeme! Vyhráli jste!");
            Console.WriteLine($"Počet pokusů: {attempts}");

        }
    }
}
