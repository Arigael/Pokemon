using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace pokemon
{
    class SuppSkill : Skill
    {
        private int atkBuffCount, defBuffCount, spdDownCount;

        public enum StatBuffed
        {
            atk,
            def,
            spd
        }

        private StatBuffed statChanged;

        public StatBuffed StatChanged { get; private set; }


        public SuppSkill(string name, float power, int movimientos, StatBuffed statToChange) 
        {
            statChanged = statToChange;
            Movimientos = movimientos;
            Name = name;
            if (power == 0)
            {
                Power = power;
            }
            else
                Power = 0;
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

        public float UsingSkill(Critter target, StatBuffed statToChange)
        {
            float statChanged;

            if (target != null)
            {
                switch (statToChange)
                {
                    case StatBuffed.atk:
                        if (atkBuffCount < 3)
                        {
                            statChanged = target.BaseAttack * 0.20f;
                            atkBuffCount++;
                            return statChanged;
                        }
                        return statChanged = 0;
                    case StatBuffed.def:
                        if (defBuffCount < 3)
                        {
                            statChanged = target.BaseDefense * 0.20f;
                            return statChanged;
                        }
                        return statChanged = 0;
                    case StatBuffed.spd:
                        if (spdDownCount < 3)
                        {
                            statChanged = target.BaseSpeed * 0.30f;
                            return statChanged;
                        }
                        return statChanged = 0;
                }
            }
            return statChanged = 0;
        }

    }
}
