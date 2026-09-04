using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE10
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E10-----");
            Random random = new Random();

            int[,] matrix = new int[4, 4];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 11);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int minValue = matrix[0, 0];
            int minValueRow = 0;
            int minValueCol = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < minValue)
                    {
                        minValue = matrix[i, j];
                        minValueRow = i;
                        minValueCol = j;
                    }
                }
            }

            Console.WriteLine($"Minimální hodnota {minValue} se nachází na pozici [{minValueRow},{minValueCol}]");

        }
    }
}
