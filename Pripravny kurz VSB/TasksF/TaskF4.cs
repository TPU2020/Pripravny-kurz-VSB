using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF4
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F4-----");

            Console.Write("Zadejte rok: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Rok {year} {(IsLeapYear(year) == true ? "je":"není")} přetupný.");
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
    }
}
