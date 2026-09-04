using System;
using System.Collections.Generic;
using System.Text;

namespace Pripravny_kurz_VSB.TasksE
{
    internal class TaskE16
    {
        public static void Mainx()
        {
            Console.WriteLine("-----Task E16-----");
            
            int[] cards = new int[32];
            int cardIndex = 0;
            int tieCounter = 0;

            int[] player1Cards = new int[16];
            int[] player2Cards = new int[16];

            int player1Score = 0;
            int player2Score = 0;

            string[] cardNames = {"7", "8", "9", "10", "spodek", "svršek", "král", "eso"};
            Random random = new Random();

            for (int i = 0; i < 4 ; i++)
            {
                for (int j = 7; j < 15; j++)
                {
                    cards[cardIndex] = j;
                    cardIndex++;
                }
            }
            Console.WriteLine($"Karty: {string.Join(" ", cards)}");
            for (int i = 0;i < 16 ; i++)
            {
                int selectedCard = random.Next(0, 32);
                if (cards[selectedCard] != 0)
                {
                    player1Cards[i] = cards[selectedCard];
                    cards[selectedCard] = 0;
                }
                else
                {
                    i--;
                }
            }

            for (int i = 0; i < 16; i++)
            {
                int selectedCard = random.Next(0, 32);
                if (cards[selectedCard] != 0)
                {
                    player2Cards[i] = cards[selectedCard];
                    cards[selectedCard] = 0;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Karty (Hráč 1): {string.Join(" ", player1Cards)}");
            Console.WriteLine($"Karty (Hráč 2): {string.Join(" ", player2Cards)}");
            Console.WriteLine();
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine($"Vyloženo: {cardNames[player1Cards[i] - 7]} proti {cardNames[player2Cards[i] - 7]}");
                if (player1Cards[i] > player2Cards[i])
                {
                    Console.WriteLine("Vyhrává Hráč 1!");
                    player1Score+= 1 + tieCounter;
                    tieCounter = 0;
                }
                else if(player1Cards[i] < player2Cards[i])
                {
                    Console.WriteLine("Vyhrává Hráč 2!");
                    player2Score+= 1 + tieCounter;
                    tieCounter = 0;
                }
                else
                {
                    Console.WriteLine("Remíza!");
                    tieCounter++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Výsledky: Hráč 1 ({player1Score}), Hráč 2 ({player2Score})");
            if(player1Score > player2Score)
            {
                Console.WriteLine("Vyhrává Hráč 1!");
            }
            else if (player1Score < player2Score)
            {
                Console.WriteLine("Vyhrává Hráč 2!");
            }
            else
            {
                Console.WriteLine("Remíza!");
            }
        }
    }
}
