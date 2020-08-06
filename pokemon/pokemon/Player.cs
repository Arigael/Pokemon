using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class Player
    {
        private Queue<Critter> team;
        private string playerName;
        
        public string PlayerName   // property
        {
            get { return playerName; }   // get method
            set { playerName = value; }  // set method
        }
    }
}
