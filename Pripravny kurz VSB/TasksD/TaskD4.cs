using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Pripravny_kurz_VSB.TasksD
{
    internal class TaskD4
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task D4-----");

            string highestStudentName = "";
            double highestStudentHeight = 0.0;

            do
            {
                Console.Write("Zadejte jméno studenta: ");
                string studentName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(studentName))
                {
                    break;
                }

                Console.Write("Zadejte výšku studenta v m: ");
                double studentHeight = double.Parse(Console.ReadLine());

                if (studentHeight > highestStudentHeight)
                {
                    highestStudentHeight = studentHeight;
                    highestStudentName = studentName;
                }

            } while (true);

            if (string.IsNullOrWhiteSpace(highestStudentName))
            {
                Console.WriteLine("Nebyl zadán žádný student.");
                return;
            }
            Console.WriteLine($"Nejvyšší student: {highestStudentName}, Výška: {highestStudentHeight} m");
        }
    }
}
