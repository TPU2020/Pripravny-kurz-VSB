using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE6
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E6-----");
            Random random = new Random();
            char[] arrayValues = new char[10];
            for (int i = 0; i < arrayValues.Length; i++)
            {
                char value = (char)(random.Next(97, 123));
                if (!arrayValues.Contains(value))
                {
                    arrayValues[i] = value;
                }
                else
                {
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ", arrayValues));

            string[] randomWords = new string[10];
            for (int i = 0; i < 10; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < 5; j++)
                {
                    sb.Append(arrayValues[random.Next(0, 10)]);
                }
                randomWords[i] = sb.ToString();
            }
            Console.WriteLine(string.Join("\n", randomWords));
        }
    }
}
