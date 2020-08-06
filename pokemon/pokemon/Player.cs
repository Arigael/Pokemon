using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class Player
    {
        public Queue<Critter> Team { get; set; }
        public string PlayerName { get; private set; }
        
        public Player (string name, Queue<Critter> team)
        {
            Team = team;
            PlayerName = name;
        }
    }
}
