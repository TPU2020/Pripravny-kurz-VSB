using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksD
{
    internal class TaskD3
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task D3-----");
            Console.Write("Zadejte první člen lineární posloupnosti: ");
            double firstTerm = double.Parse(Console.ReadLine());
            Console.Write("Zadejte druhý člen lineární posloupnosti: ");
            double secondTerm = double.Parse(Console.ReadLine());
            Console.Write("Zadejte poslední člen lineární posloupnosti: ");
            double lastTerm = double.Parse(Console.ReadLine());

            double commonDifference = secondTerm - firstTerm;
            double currentTerm = firstTerm;

            if (commonDifference > 0)
            {
                while (currentTerm <= lastTerm)
                {
                    Console.WriteLine(currentTerm);
                    currentTerm += commonDifference;
                }
            }
            else if (commonDifference < 0)
            {
                while (currentTerm >= lastTerm)
                {
                    Console.WriteLine(currentTerm);
                    currentTerm += commonDifference;
                }
            }
            else
            {
                Console.WriteLine("Lineární posloupnost nemá rozdíl mezi členy.");
            }
        }
    }
}
