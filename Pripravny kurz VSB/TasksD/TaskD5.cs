using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksD
{
    internal class TaskD5
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task D5-----");
            int sum = 0;
            int count = 0;
            int minimum = 0;
            int maximum = 0;
            string numbersString = "";
            string evenNumbersString = "";
            do
            {
                Console.Write($"Zadejte číslo {count + 1} (0 -> konec): ");
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                    break;
                sum += number;
                count++;
                numbersString += number + " ";
                if (number % 2 == 0)
                {
                    evenNumbersString += number + " ";
                }
                if (count == 1)
                {
                    minimum = number;
                    maximum = number;
                }
                else
                {
                    if (number < minimum)
                        minimum = number;
                    if (number > maximum)
                        maximum = number;
                }
            } while (true);
            if (count > 0)
            {
                Console.WriteLine($"Zadaná čísla: {numbersString}");
                Console.WriteLine($"Sudá čísla: {evenNumbersString}");
                Console.WriteLine($"Součet zadaných čísel: {sum}");
                Console.WriteLine($"Průměr zadaných čísel: {(double)sum / count:F2}");
                Console.WriteLine($"Minimální hodnota: {minimum}");
                Console.WriteLine($"Maximální hodnota: {maximum}");
            }
        }
    }
}
