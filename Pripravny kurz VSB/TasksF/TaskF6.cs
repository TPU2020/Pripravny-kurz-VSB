using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF6
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F6-----");

            Console.Write("Zadejte číslo dne (1-7): ");
            int dayNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Číslo {dayNumber} je {DayName(dayNumber).ToLower()}");
        }

        private static string DayName(int dayNumber)
        {
            string dayName = dayNumber switch
            {
                1 => "Pondělí",
                2 => "Úterý",
                3 => "Středa",
                4 => "Čtvrtek",
                5 => "Pátek",
                6 => "Sobota",
                7 => "Neděle",
                _ => "Neplatné číslo"
            };
            return dayName;
        }
    }
}
