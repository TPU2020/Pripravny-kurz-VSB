using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksD
{
    internal class TaskD8
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task D8-----");

            do
            {
                Console.Write("Zadejte znak: ");
                char character = Console.ReadKey().KeyChar;
                if (char.IsDigit(character))
                {
                    Console.WriteLine($"\nZnak '{character}' je číslice.");
                    if (character == '0')
                        break;
                }
                else if (char.IsLetter(character))
                {
                    Console.WriteLine($"\nZnak '{character}' je písmeno.");
                }
                else
                {
                    Console.WriteLine($"\nZnak '{character}' není ani číslice, ani písmeno.");
                }
            } while (true);

        }
    }
}
