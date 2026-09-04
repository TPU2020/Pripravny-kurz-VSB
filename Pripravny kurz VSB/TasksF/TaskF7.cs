using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF7
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F7-----");

            Console.Write("Zadejte znak: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine($"Znak ({ch}) je {CharType(ch)}");
        }

        private static string CharType(char ch)
        {
            if (char.IsAsciiDigit(ch))
            {
                return "Číslice";
            }
            else if (char.IsAsciiLetterLower(ch))
            {
                return "Malé písmeno";
            }
            else if (char.IsAsciiLetterUpper(ch))
            {
                return "Velké písmeno";
            }
            else
            {
                return "Ostatní";
            }
        }
    }
}
