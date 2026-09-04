using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF10
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F9-----");

            Console.Write("Zadejte text: ");
            string inputText = Console.ReadLine();

            Console.WriteLine($"Text bez mezer: {BezMezer(inputText)}");
        }

        public static string BezMezer(string text)
        {
            string resultText = "";

            foreach (char c in text)
            {
                if(c != ' ')
                    resultText += c;
            }

            return resultText;
        }
    }
}
