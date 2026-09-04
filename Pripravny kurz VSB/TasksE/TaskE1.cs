using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE1
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E1-----");

            Random random = new Random();

            int[] arrayValues = new int[10];
            int arrayMin = 0;
            int arrayMinCount = 0;

            for (int i = 0; i < arrayValues.Length; i++) arrayValues[i] = random.Next(1, 6);

            arrayMin = arrayValues.Min();
            for (int i = 0; i < arrayValues.Length; ++i)
                if (arrayValues[i] == arrayMin)
                    arrayMinCount++;

            Console.WriteLine(string.Join(" ", arrayValues));
            Console.WriteLine("Nejmenší hodnota: " + arrayValues.Min());
            Console.WriteLine("Počet výskytů nejmenší hodnoty: " + arrayMinCount);
        }
    }
}
