using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

namespace pokemon
{
    class AtkSkill : Skill
    {
        private float affinityMultiplier;

        public AtkSkill(string name, float power, Affinity affinityType, int movimientos) 
        {
            Name = name;
            Movimientos = movimientos;
            if (power >=1 && power <=10)
            {
                Power = power;
            }
            else if (power < 1)
            {
                Power = 1;
            }
            else if (power > 10)
            {
                Power = 10;
            }
            AffinitySkillType = affinityType;
        }


        private float AffinityMultiplier (Critter target, AtkSkill skill)
        {
            switch (skill.AffinitySkillType)
            {
                case Affinity.Fire:
                    switch (target.AffinityType)
                    {
                        case Critter.Affinity.Fire:
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        case Critter.Affinity.Wind:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Earth:
                            affinityMultiplier = 0;
                            return affinityMultiplier;
                        case Critter.Affinity.Dark:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Water:
                            affinityMultiplier = 2f;
                            return affinityMultiplier;
                        case Critter.Affinity.Light:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                    }
                    return affinityMultiplier;

                case Affinity.Wind:
                    switch (target.AffinityType)
                    {
                        case Critter.Affinity.Fire:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Wind:
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        case Critter.Affinity.Earth:
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        case Critter.Affinity.Dark:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Water:
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        case Critter.Affinity.Light:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                    }
                    return affinityMultiplier;

                case Affinity.Earth:
                    switch (target.AffinityType)
                    {
                        case Critter.Affinity.Fire:
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        case Critter.Affinity.Wind:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Earth:
                            affinityMultiplier = 0;
                            return affinityMultiplier;
                        case Critter.Affinity.Dark:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Water:
                            affinityMultiplier = 2f;
                            return affinityMultiplier;
                        case Critter.Affinity.Light:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                    }
                    return affinityMultiplier;

                case Affinity.Dark:
                    switch (target.AffinityType)
                    {
                        case Critter.Affinity.Fire:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Wind:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Earth:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Dark:
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        case Critter.Affinity.Water:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Light:
                            affinityMultiplier = 2;
                            return affinityMultiplier;
                    }
                    return affinityMultiplier;

                case Affinity.Water:
                    switch (target.AffinityType)
                    {
                        case Critter.Affinity.Fire:
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        case Critter.Affinity.Wind:
                            affinityMultiplier = 2;
                            return affinityMultiplier;
                        case Critter.Affinity.Earth:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Dark:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Water:
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        case Critter.Affinity.Light:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                    }
                    return affinityMultiplier;

                case Affinity.Light:
                    switch (target.AffinityType)
                    {
                        case Critter.Affinity.Fire:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Wind:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Earth:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Dark:
                            affinityMultiplier = 2;
                            return affinityMultiplier;
                        case Critter.Affinity.Water:
                            affinityMultiplier = 1;
                            return affinityMultiplier;
                        case Critter.Affinity.Light:
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                    }
                    return affinityMultiplier;
            }
            return affinityMultiplier;
        }

        public bool SkillMoveLeft(Skill skill)
        {
            if (skill.Movimientos > 0)
            {
                return true;
            }
            else
                return false;
        }

        public float UsingSkill(Critter target, Critter caster, float additionalAttack)
        {
            float dmgValue;

            if (target != null && target != caster)
            {
                dmgValue = ((caster.BaseAttack + additionalAttack) + Power) * AffinityMultiplier(target, this) ;
                return dmgValue;
            }

            return dmgValue = 0;
        }

    }
}
