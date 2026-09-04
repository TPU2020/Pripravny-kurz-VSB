using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksD
{
    internal class TaskD1
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task D1-----");
            int classCount = 0;
            int totalStudents = 0;
            do
            {
                Console.Write($"Zadejte počet žáků ve třídě {classCount + 1} (0 -> konec): ");
                int studentCount = int.Parse(Console.ReadLine());
                if (studentCount <= 0)
                {
                    break;
                }
                totalStudents += studentCount;
                classCount++;
            } while (true);

            if (classCount > 0)
            {
                Console.WriteLine($"Celkový počet žáků: {totalStudents}");
                Console.WriteLine($"Průměrný počet žáků na třídu: {((double)totalStudents / classCount):F2}");
            }
        }
    }
}
