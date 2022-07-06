using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder_game
{
    internal class Snake
    {
        int pos1 = 0, pos2 = 0, count = 0;
        int player1, player2;
        public void rollingDice()
        {
            Random rand = new Random();
            while (pos1 != 100 && pos2 != 100)
            {
                player1 = rand.Next(0, 7);
                player2 = rand.Next(0, 7);
                int option1 = rand.Next(0, 3);
                int option2 = rand.Next(0, 3);
                count++;

                switch (option1)
                {
                    case 0:
                        break;
                    case 1:
                        pos1 += player1;
                        break;
                    case 2:
                        pos1 -= player1;
                        break;
                }
                if (pos1 < 0)
                {
                    pos1 = 0;
                }
                if (pos1 > 100)
                {
                    pos1 -= player1;
                }

                switch (option2)
                {
                    case 0:
                        break;
                    case 1:
                        pos2 += player2;
                        break;
                    case 2:
                        pos2 -= player2;
                        break;
                }
                if (pos2 < 0)
                {
                    pos2 = 0;
                }
                if (pos2 > 100)
                {
                    pos2 -= player2;
                }
                Console.WriteLine("Position of player1: " + pos1);
                Console.WriteLine("Position of player2: " + pos2);
            }
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------");
            if (pos1 == 100)
            {
                Console.WriteLine("Player 1 won the match");
            }
            else
            {
                Console.WriteLine("Player 2 won the match");
            }
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Dice rolled for " + count + "times");

        }
    }
}