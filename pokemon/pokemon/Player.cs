using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class Player
    {
        private Queue<Critter> team;
        private string playerName;
        
        private string PlayerName   // property
        {
            get => playerName;    // get method
            set => playerName = value;   // set method
        }
    }
}
