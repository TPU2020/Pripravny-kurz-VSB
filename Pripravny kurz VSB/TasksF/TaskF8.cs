using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF8
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F8-----");

            Console.Write("Zadejte číslo měsíce (1-12): ");
            int monthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Číslo měsíce {monthNumber} je {GetMonthName(monthNumber)}");
        }

        private static string GetMonthName(int monthNumber)
        {
            string monthName = monthNumber switch
            {
                1 => "Leden",
                2 => "Únor",
                3 => "Březen",
                4 => "Duben",
                5 => "Květen",
                6 => "Červen",
                7 => "Červenec",
                8 => "Srpen",
                9 => "Září",
                10 => "Říjen",
                11 => "Listopad",
                12 => "Prosinec",
                _ => "neznámé"
            };

            return monthName;
        }
    }
}
