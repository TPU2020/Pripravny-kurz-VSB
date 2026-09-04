using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksB
{
    internal class TaskB15
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task B15-----");

            Console.Write("Jak je venku? (vedro/zima/déšť/mlha/tma/chumelenice): ");
            string weather = Console.ReadLine();
            
            string message = weather switch
            {
                "vedro" => "Jdi plavet.",
                "zima" => "Dobře se obleč.",
                "déšť" => "Hrej na PC.",
                "mlha" => "Vem si šálu.",
                "tma" => "Vem si baterku.",
                "chumelenice" => "Jsou to chumelenice.",
                _ => "Neznámý počasí."
            };
            Console.WriteLine(message);
        }
    }
}
