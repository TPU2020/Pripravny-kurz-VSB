using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB5
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B5-----");

            Console.Write("Zadejte jméno prvního žáka: ");
            string student1Name = Console.ReadLine();
            Console.Write("Zadejte výšku prvního žáka (v cm): ");
            double student1Height = double.Parse(Console.ReadLine());
            Console.Write("Zadejte jméno druhého žáka: ");
            string student2Name = Console.ReadLine();
            Console.Write("Zadejte výšku druhého žáka (v cm): ");
            double student2Height = double.Parse(Console.ReadLine());

            if (student1Height > student2Height)
            {
                Console.WriteLine($"{student1Name} je vyšší než {student2Name}.");
            }
            else if (student1Height < student2Height)
            {
                Console.WriteLine($"{student2Name} je vyšší než {student1Name}.");
            }
            else
            {
                Console.WriteLine($"{student1Name} a {student2Name} mají stejnou výšku.");
            }

        }
    }
}
