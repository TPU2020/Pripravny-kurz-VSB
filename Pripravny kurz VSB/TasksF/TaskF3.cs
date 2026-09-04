using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF3
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F3-----");

            Console.Write("Zadejte znak: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Zadejte počet kroků posunu: ");
            int steps = int.Parse(Console.ReadLine());

            Console.WriteLine($"Znak {ch} je v Ascii {Encrypt(ch, steps)}");
        }

        private static char Encrypt(char ch, int steps)
        {
            steps = steps % 26;
            if (ch + steps < 97)
            {
                return (char)(ch + steps + 26);
            }
            else if (ch + steps > 122)
            {
                return (char)(ch + steps - 26);
            }
            else
            {
                return (char)(ch + steps);
            }
        }
    }
}
