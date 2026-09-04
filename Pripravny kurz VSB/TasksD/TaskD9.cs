using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksD
{
    internal class TaskD9
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task D9-----");
            int tempCount = 0;
            double tempMax = 0;
            int tempMaxIndex = 0;
            string tempValueString = "";

            do
            {
                Console.Write("Zadejte teplotu (100+ -> konec): ");
                double temperature = double.Parse(Console.ReadLine());
                if (temperature > 100)
                    break;
                tempValueString += temperature + " ";
                tempCount++;
                if (temperature > tempMax)
                {
                    tempMax = temperature;
                    tempMaxIndex = tempCount;
                }
            } while (true);

            Console.WriteLine("Zadané teploty: " + tempValueString);
            Console.WriteLine($"Nejvyšší teplota: {tempMax} °C (pořadí: {tempMaxIndex})");
        }
    }
}
