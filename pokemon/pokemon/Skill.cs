using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace pokemon
{
    public class Skill
    {
        public string Name { get; protected set; }
        public float Power { get; protected set; }

        public int Movimientos { get; protected set; }

        public enum Affinity 
        {
            Fire, 
            Wind,
            Earth,
            Dark,
            Water,
            Light
        }
        
        private Affinity affinityType;

        public Affinity AffinityType { get; protected set; }



    }
}
