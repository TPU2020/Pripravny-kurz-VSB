using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC6
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C6-----");
            
            Console.Write("Zadejte počet tříd: ");
            int classCount = int.Parse(Console.ReadLine());
            
            int studentCount = 0;
            for (int i = 0; i < classCount; i++) 
            {
                Console.Write($"Zadejte počet žáků v třídě {i + 1}: ");
                studentCount += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Celkový počet žáků ve škole je {studentCount} a průměrný počet žáků v jedné třídě je {studentCount / (double)classCount:F2}");
        }
    }
}
