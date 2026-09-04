using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE7
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E7-----");
            string[] words = new string[10];
            int index = 0;
            do
            {
                Console.Write("Zadejte slovo (předchozí slovo nebo stisnki Enter pro ukončení): ");
                string input = Console.ReadLine();
                if (words.Contains(input) || string.IsNullOrWhiteSpace(input) || words[words.Length - 1] != null)
                {
                    if(words.Contains(input))
                    {
                        Console.WriteLine($"Slovo již existuje na indexu {Array.IndexOf(words, input)}.");
                    }
                    break;
                }

                words[index] = input;
                index++;

            }while (true);
        }
    }
}
