using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF9
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F9-----");

            Console.Write("Zadejte text: ");
            string inputText = Console.ReadLine();

            Console.WriteLine($"Obrácený text: {ObratText(inputText)}");
        }

        private static string ObratText(string? inputText)
        {
            string reversedText = "";
            if (inputText != null)
            {
                for (int i = inputText.Length - 1; i >= 0; i--)
                {
                    reversedText += inputText[i];
                }
            }
            return reversedText;
        }
    }
}
