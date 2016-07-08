using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors 
{
    class StubbornAI : IPlayer
    {
        Random random = new Random();

        public int FavoriteMove { get; set; } 

        public int NextMove()
        {
            return FavoriteMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //throw new NotImplementedException();C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\rock-paper-scissors\RockPaperScissors\RandomAI.cs
        }

        public StubbornAI(int favoriteMove)
        {
            FavoriteMove = favoriteMove;
        }

    }
}
