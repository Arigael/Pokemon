using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class Critter
    {
        private string Name;
        private float BaseAttack;
        private float BaseDefense;
        private float BaseSpeed;
        private float HP;
        private List<> MoveSet;
        

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

        public Critter (string name, float baseAttack, float baseDefense, float baseSpeed, float hp, List<> moveSet,  Affinity affinity)
        {
            affinityType = affinity;
            Name = name;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
            BaseSpeed = baseSpeed;
            HP = hp;
            MoveSet = moveSet;

        }
    }
}
