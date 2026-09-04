using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB8
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B8-----");

            Console.Write("Zadej znak: ");
            char character = char.Parse(Console.ReadLine());

            if (char.IsLetter(character))
            {
                Console.WriteLine("Znak je písmeno");
            }       
            else if (char.IsDigit(character)) {
                Console.WriteLine("Znak je číslice");
            }
            else {
                Console.WriteLine("Znak není písmeno ani číslice");
            }
        }
    }
}
