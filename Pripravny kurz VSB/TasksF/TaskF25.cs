using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksF
{
    internal class TaskF25
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task F2-5-----");

            Random random = new Random();
            int atempts = 30;
            int[] values = new int[atempts];
            for (int i = 0; i < atempts; i++)
            {
                values[i] = random.Next(1, 7);
            }
            Console.WriteLine($"Pro hody\n{string.Join(" ", values)}\nbyly napočítány pro jednotlivé hodnoty tyto počty (1-6)\n{string.Join("\t",PocetPadlych(values, atempts))}");

        }

        private static int[] PocetPadlych(int[] values, int atempts)
        {
            int[] atemptsCount = new int[6];

            if (values == null || atempts == 0)
            {
                return atemptsCount;
            }

            foreach (int i in values)
            {
                switch (i)
                {
                    case 1: atemptsCount[0]++; break;
                    case 2: atemptsCount[1]++; break;
                    case 3: atemptsCount[2]++; break;
                    case 4: atemptsCount[3]++; break;
                    case 5: atemptsCount[4]++; break;
                    case 6: atemptsCount[5]++; break;
                    default:
                        break;
                }
            }
            return atemptsCount;
        }
    }
}
