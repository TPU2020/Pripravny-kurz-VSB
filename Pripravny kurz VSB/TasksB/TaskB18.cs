using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB18
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B18-----");

            Console.Write("Zadejte číslo měsíce (1-12): ");
            int month = int.Parse(Console.ReadLine());

            string monthDaysCount = month switch
            {
                1 => "Leden má 31 dní.",
                2 => "Únor má 28.",
                3 => "Březen má 31 dní.",
                4 => "Duben má 30 dní.",
                5 => "Květen má 31 dní.",
                6 => "Červen má 30 dní.",
                7 => "Červenec má 31 dní.",
                8 => "Srpen má 31 dní.",
                9 => "Září má 30 dní.",
                10 => "Říjen má 31 dní.",
                11 => "Listopad má 30 dní.",
                12 => "Prosinec má 31 dní.",
                _ => "Neplatné číslo měsíce."
            };
            Console.WriteLine(monthDaysCount);
        }
    }
}
