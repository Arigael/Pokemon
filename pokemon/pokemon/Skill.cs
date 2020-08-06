using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class Skill
    {
        private string Name;
        private float Power;

        private enum Type
        {
            AttackSkill,
            SupportSkill
        }

        private Type skillType;
        

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

        public Skill (string name, float power, Type type, Affinity affinity)
        {
            Name = name;
            Power = power;
            skillType = Type;
            affinityType = affinity;
        }
    }
}
