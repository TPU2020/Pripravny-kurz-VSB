using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE8
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E8-----");
            string[] words = new string[10];
            int index = 0;
            do
            {
                Console.Write("Zadejte slovo (předchozí slovo nebo stisnki Enter pro ukončení): ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input) || words[words.Length - 1] != null)
                {
                    break;
                }

                words[index] = input;
                index++;

            } while (true);

            int wordsCount = 0;
            if (words.Contains(null))
            {
                wordsCount = Array.IndexOf(words, null);
            }
            else
            {
                wordsCount = words.Length;
            }

            for (int i = wordsCount - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }

            for (int i = 0; i < wordsCount; i += 2)
            {
                Console.WriteLine(words[i]);
            }

            for (int i = 1; i < wordsCount; i += 2)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
