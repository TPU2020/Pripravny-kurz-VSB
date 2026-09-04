using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF1
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F1-----");

            Console.Write("Zadejte stupně: ");
            double degrese = double.Parse(Console.ReadLine());
            Console.Write("Zadejte minuty: ");
            double minutes = double.Parse(Console.ReadLine());

            double rads = DegToRad(degrese, minutes);
            Console.WriteLine($"Úhel {degrese}° {minutes}' je {rads:F4} radiánů.");
        }

        private static double DegToRad(double degs, double mins)
        {
            double totalDegs = degs + (mins/60);
            double rads = (totalDegs * Math.PI) / 180;

            return rads;
        }
    }
}
