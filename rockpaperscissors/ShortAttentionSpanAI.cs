using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI : IPlayer
    {
        //Random random = new Random();
        int opponentMove;
        public int NextMove()
        {
                     
            //gets previous move of opponent and plays the move that would beat them
            if(opponentMove == 0)
            {
                return 1;
            }
            else if(opponentMove == 1)
            {
                return 2;
            }
            else
            {
                return 0;
            }   
             
        }

        public void SaveResult(int myMove, int otherMove)
        {
            opponentMove = otherMove;

        }

    }
}
