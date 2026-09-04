using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE15
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E15-----");

            Console.Write("Zadejte vstupní řetězec slov (Bez diakritiky): ");
            string inputSentece = Console.ReadLine();
            string resultSentence = "";

            for(int i = 0; i < inputSentece.Length; i++)
            {
                char ch = inputSentece[i];
                string chMorse = "";

                switch (char.ToUpper(ch))
                {
                    case 'A': chMorse = ".-"; break;
                    case 'B': chMorse = "-..."; break;
                    case 'C': chMorse = "-.-."; break;
                    case 'D': chMorse = "-.."; break;
                    case 'E': chMorse = "."; break;
                    case 'F': chMorse = "..-."; break;
                    case 'G': chMorse = "--."; break;
                    case 'H': chMorse = "...."; break;
                    case 'I': chMorse = ".."; break;
                    case 'J': chMorse = ".---"; break;
                    case 'K': chMorse = "-.-"; break;
                    case 'L': chMorse = ".-.."; break;
                    case 'M': chMorse = "--"; break;
                    case 'N': chMorse = "-."; break;
                    case 'O': chMorse = "---"; break;
                    case 'P': chMorse = ".--."; break;
                    case 'Q': chMorse = "--.-"; break;
                    case 'R': chMorse = ".-."; break;
                    case 'S': chMorse = "..."; break;
                    case 'T': chMorse = "-"; break;
                    case 'U': chMorse = "..-"; break;
                    case 'V': chMorse = "...-"; break;
                    case 'W': chMorse = ".--"; break;
                    case 'X': chMorse = "-..-"; break;
                    case 'Y': chMorse = "-.--"; break;
                    case 'Z': chMorse = "--.."; break;
                    case '1': chMorse = ".----"; break;
                    case '2': chMorse = "..---"; break;
                    case '3': chMorse = "...--"; break;
                    case '4': chMorse = "....-"; break;
                    case '5': chMorse = "....."; break;
                    case '6': chMorse = "-...."; break;
                    case '7': chMorse = "--..."; break;
                    case '8': chMorse = "---.."; break;
                    case '9': chMorse = "----."; break;
                    case '0': chMorse = "-----"; break;
                    case ' ': chMorse = "/"; break;
                    default: chMorse = ""; break;
                }
                resultSentence += chMorse;
            }

            Console.WriteLine($"Výstupní řetězec v Morseově kódu: {resultSentence}");
        }
    }
}
