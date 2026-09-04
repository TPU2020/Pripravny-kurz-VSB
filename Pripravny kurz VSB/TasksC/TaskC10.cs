
using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksC
{
    internal class TaskC10
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task C10-----");

            Random random = new Random();
            int score = 0;
            int totalQuestions = 10;
            for (int i = 0; i < totalQuestions; i++)
            {
                int num1 = random.Next(1, 11);
                int num2 = random.Next(1, 11);
                Console.Write($"{num1} * {num2} = ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == num1 * num2)
                {
                    score++;
                }
                else
                {
                    Console.WriteLine($"Špatně! Správná odpověď je: {num1 * num2}");
                }
            }

            Console.WriteLine($"Konec kvízu! Celkové skóre: {score}. Počet chyb: {totalQuestions - score}");
        }
    }
}
