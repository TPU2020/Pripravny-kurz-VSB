using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB7
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B7-----");

            Console.Write("Zadejte rok (od 1600): ");

            if (int.TryParse(Console.ReadLine(), out int year))
            {
                if (year < 1600)
                {
                    Console.WriteLine("Rok musí být 1600 nebo vyšší.");
                }
                else if (year <= 1804)
                {
                    Console.WriteLine("Habsburská monarchie");
                }
                else if (year <= 1867)
                {
                    Console.WriteLine("Rakouské císařství");
                }
                else if (year <= 1918)
                {
                    Console.WriteLine("Rakousko-Uhersko");
                }
                else if (year <= 1938)
                {
                    Console.WriteLine("Československá republika");
                }
                else if (year <= 1945)
                {
                    Console.WriteLine("Protektorát Böhmen und Mähren");
                }
                else if (year <= 1992)
                {
                    Console.WriteLine("Československo (ČSR / ČSSR / ČSFR)");
                }
                else
                {
                    Console.WriteLine("Česká republika");
                }
            }
            else
            {
                Console.WriteLine("Neplatný formát roku.");
            }

        }
    }
}
