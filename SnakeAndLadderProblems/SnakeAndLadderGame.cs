using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblems
{
    public class SnakeAndLadderGame
    {
        const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        int position = 0, option; 
        public int DieRoll()
        {
            Random random = new Random();
            int diePosition = random.Next(1, 7);
            return diePosition;
        }
        public void Player()
        {
            Random random = new Random();
            option = random.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    this.position = this.position;
                    break;
                case SNAKE:
                    this.position -= this.DieRoll();
                    break;
                default :
                    LADDER: this.position += this.DieRoll();
                    break;
            }


            
        }
    }
    
}
