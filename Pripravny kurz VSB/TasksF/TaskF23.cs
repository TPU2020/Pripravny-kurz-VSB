using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF23
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F2-3-----");

            int count = 0;
            Console.Write("Zadejte počet opakování znaku: ");
            count = int.Parse(Console.ReadLine());
            Console.Write("Zadejte opakovaný znak: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine($"Výsledek: {Opakovani(count, c)}");
        }

        private static string Opakovani(int repeat, char c)
        {
            string resultString = "";
            if (repeat <= 0)
            {
                return resultString;
            }
            for(int i = 0; i < repeat; i++)
            {
                resultString += c;
            }
            return resultString;
        }
    }
}
