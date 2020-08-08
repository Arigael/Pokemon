using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace pokemon
{
    class Critter
    {
        public string Name { get; private set; }
        public float BaseAttack { get; private set; }
        public float BaseDefense { get; private set; }
        public float BaseSpeed { get; private set; }
        public float HP { get; private set; }
        public List<Skill> MoveSet { get; set; }
        

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

        public Affinity AffinityType { get; }

        public Critter (string name, float baseAttack, float baseDefense, float baseSpeed, float hp, List<Skill> moveSet,  Affinity affinity)
        {
            affinityType = affinity;
            Name = name;
            if (baseAttack >= 10 && baseAttack <=100)
            {
                BaseAttack = baseAttack;
            }
            else if (baseAttack <10)
            {
                BaseAttack = 10;
            }
            else if (baseAttack > 100)
            {
                BaseAttack = 100;
            }

            //----

            if (baseDefense >= 10 && baseDefense <= 100)
            {
                BaseDefense = baseDefense;
            }
            else if (baseAttack < 10)
            {
                BaseDefense = 10;
            }
            else if (baseDefense > 100)
            {
                BaseDefense = 100;
            }

            // ----

            if (baseSpeed >= 1 && baseSpeed <= 50)
            {
                BaseSpeed = baseSpeed;
            }
            else if (baseSpeed < 1)
            {
                BaseSpeed = 1;
            }
            else if (baseSpeed > 50)
            {
                BaseSpeed = 50;
            }
            BaseSpeed = baseSpeed;
            HP = hp;
            MoveSet = moveSet;
        }


        //devuelve siempre el valor resultado de lanzar una skill, en el caso de un atk devolvera el valor del daño que inflingira ese atk, en el caso de una skill supp
        //devolvera el valor a sumar en caso de aumentar el atk o defensa, si es para disminuir el spd devolvera el valor a reducir.
        public float ThrowSkill(Critter target, Critter caster, float additionalAtk, Skill skillToUse, float skillValueResult)
        {
            if (target != null && caster != null)
            {
                if (skillToUse is AtkSkill)
                {
                    AtkSkill atkSkill = (AtkSkill)skillToUse;
                    skillValueResult = atkSkill.UsingSkill(target,caster,additionalAtk);
                    return skillValueResult;
                }
                else if (skillToUse is SuppSkill)
                {
                    SuppSkill suppSkill = (SuppSkill)skillToUse;
                    skillValueResult =  suppSkill.UsingSkill(target, suppSkill.StatChanged);
                    return skillValueResult;
                }
            }

            return skillValueResult;
        }

    }
}
