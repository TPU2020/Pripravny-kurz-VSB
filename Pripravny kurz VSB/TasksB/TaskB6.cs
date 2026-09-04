using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB6
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B6-----");

            Console.Write("Zadejte trasu prvního auta (v km): ");
            double car1Route = double.Parse(Console.ReadLine());
            Console.Write("Zadejte čas prvního auta (v minutách): ");
            double car1Time = double.Parse(Console.ReadLine());
            Console.Write("Zadejte trasu druhého auta (v km): ");
            double car2Route = double.Parse(Console.ReadLine());
            Console.Write("Zadejte čas druhého auta (v minutách): ");
            double car2Time = double.Parse(Console.ReadLine());

            double car1AvgSpeed = car1Route / car1Time * 60;
            double car2AvgSpeed = car2Route / car2Time * 60;

            string fasterCar = car1AvgSpeed > car2AvgSpeed ? "První" : "Druhé";

            Console.WriteLine($"{fasterCar} auto je rychlejší o {Math.Abs(car1AvgSpeed - car2AvgSpeed):F2} km/h.");
        }
    }
}
