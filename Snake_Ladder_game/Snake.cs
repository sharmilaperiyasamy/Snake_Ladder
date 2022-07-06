using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder_game
{
    internal class Snake
    {
        int pos1 = 0;
        int player1;
        public void rollingDice()
        {
            Random rand = new Random();
            player1 = rand.Next(0, 7);
            int option1 = rand.Next(0, 3);

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
        }
    }
}
