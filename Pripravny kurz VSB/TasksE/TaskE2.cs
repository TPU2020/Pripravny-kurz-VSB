using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE2
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E2-----");
            Random random = new Random();
            int[] arrayValues = new int[10];
            for (int i = 0; i < arrayValues.Length; i++) arrayValues[i] = random.Next(1, 6);
            Console.WriteLine(string.Join(" ", arrayValues));

            Console.Write("Vyberte již zadané číslo: ");
            int searchValue = int.Parse(Console.ReadLine());
            int searchValueCount = 0;

            for (int i = 0; i < arrayValues.Length; i++)
                if (arrayValues[i] == searchValue)
                    searchValueCount++;

            Console.WriteLine("Počet výskytů vybraného čísla: " + searchValueCount);
        }
    }
}
