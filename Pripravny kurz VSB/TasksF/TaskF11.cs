using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF11
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F11-----");

            Console.Write("Zadejte větu: ");
            string inputSentence = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Zadejte hledané slovo: ");
            string inputSearchWord = Console.ReadLine();
            Console.WriteLine();

            Console.Write($"Počet opakování ve větě {Vyskyt(inputSentence, inputSearchWord)}");
        }

        public static int Vyskyt(string sentence, string searchedWord)
        {
            int searchedWordLength = searchedWord.Length;
            int sentenceLength = sentence.Length;
            int searchedWordCounter = 0;

            if (searchedWordLength <= 0 || sentenceLength == 0 || sentenceLength < searchedWordLength)
                return 0;

            for (int i = 0; i < sentenceLength - searchedWordLength; i++)
            {
                string sentenceSubstring = sentence.Substring(i, searchedWordLength);
                if (sentenceSubstring == searchedWord)
                {
                    searchedWordCounter++;
                }
            }

            return searchedWordCounter;
        }
    }
}
