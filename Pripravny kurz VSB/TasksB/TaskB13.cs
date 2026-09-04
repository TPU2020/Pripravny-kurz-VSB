using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB13
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B13-----");

            Console.Write("Zadejte a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = Math.Sqrt(b * b - 4 * a * c);

            if (discriminant > 0)
            {
                double x1 = (-b + discriminant) / (2 * a);
                double x2 = (-b - discriminant) / (2 * a);
                Console.WriteLine("Rovnice má dva kořeny: {0} a {1}", x1, x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Rovnice má jeden kořen: {x}");
            }
            else
            {
                Console.WriteLine("Rovnice nemá řešení v oboru reálných čísel.");
            }
        }
    }
}
