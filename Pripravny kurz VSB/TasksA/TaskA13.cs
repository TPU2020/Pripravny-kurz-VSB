using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksA
{
    internal class TaskA13
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task A13-----");

            Console.Write("Zadejte délku první odvěsny pravoúhlého trojúhelníku: ");
            double sideLength1 = double.Parse(Console.ReadLine());
            Console.Write("Zadejte délku druhé odvěsny pravoúhlého trojúhelníku: ");
            double sideLength2 = double.Parse(Console.ReadLine());
            double hypotenuse = Math.Sqrt(sideLength1 * sideLength1 + sideLength2 * sideLength2);
            Console.WriteLine($"Délka přepony pravoúhlého trojúhelníku je {hypotenuse:F2}");
        }
    }
}
