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
        }
    }
}
