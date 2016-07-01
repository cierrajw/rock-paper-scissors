using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomAI : IPlayer
    {
        Random random = new Random(); //private instance variable to be constructed just once (not each time the method is run, so keep it outside the method)

        public int NextMove()
        {
            //0 = rock, 1 = paper, 2 = scissors
            return random.Next(0, 3); //This will not actually go up to three, just 0 thru 2. 
 
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //this method intentionally left blank
        }
    }
}
