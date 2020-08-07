using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class Player
    {
        public Queue<Critter> CritterTeam { get; private set; }
        public string PlayerName { get; private set; }

        public Player(string name, Queue<Critter>newCritterTeam)
        {
            PlayerName = name;
            CritterTeam = newCritterTeam;
        }
    }
}
