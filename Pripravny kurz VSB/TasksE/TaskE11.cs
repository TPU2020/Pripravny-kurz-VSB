using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE11
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E11-----");
            Random random = new Random();

            int[,] matrix = new int[4, 4];
            int[,] matrixTranspose = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 11);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                for(int j = 0;j < matrix.GetLength(1); j++)
                {
                    matrixTranspose[i,j] = matrix[j,i];
                    Console.Write(matrixTranspose[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
