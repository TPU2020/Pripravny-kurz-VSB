using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF12
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F12-----");

            Console.Write("Zadejte datum ve formátu DD/MM/YYYY: ");
            string inputDate = Console.ReadLine();


            string[] inputDateSplit = inputDate.Split('/');
            if (inputDateSplit.Length == 3)
            {
                int inputDay = int.Parse(inputDateSplit[0]);
                int inputMonth = int.Parse(inputDateSplit[1]);
                int inputYear = int.Parse(inputDateSplit[2]);
                int vysledek = DayOfYear(inputDay, inputMonth, inputYear);

                Console.WriteLine($"Počet dní od začátku roku {vysledek}");
            }
            else
            {
                Console.WriteLine("Neplatný formát");
            }
        }

        private static int DayOfYear(int inputDay, int inputMonth, int inputYear)
        {
            int daysOfMonth = DaysOfMonth(inputMonth, inputYear);
            int totalDays = 0;

            if (inputMonth < 1 || inputMonth > 12)
            {
                return -1;
            }
            if (daysOfMonth == -1)
            {
                return -1;
            }
            if (inputDay < 1 || inputDay > daysOfMonth)
            {
                return -1;
            }

            for (int i = 1; i < inputMonth; i++)
            {
                totalDays += DaysOfMonth(i, inputYear);
            }
            totalDays += inputDay;


            return totalDays;
        }

        private static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int DaysOfMonth(int month, int year)
        {
            int days = month switch
            {
                1 => 31,
                2 => IsLeapYear(year) ? 29 : 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => -1,
            };
            return days;
        }
    }
}
