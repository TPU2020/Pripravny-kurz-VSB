using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF2
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F2-----");

            Console.Write("Zadejte znak: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine($"Znak {ch} je v Ascii {CharacterToAscii(ch)}");
        }

        private static int CharacterToAscii(char ch)
        {
            return (int)ch;
        }
    }
}
