using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class Control
    {

        public float additionalAtk, additionalDef, spdDown;
        public void StartCombat(Player player1, Player player2)
        {
            Console.WriteLine("Se ha iniciado un combate entre el jugador {0} y el jugador {1}", player1.PlayerName + player2.PlayerName);

            Turn1(player1, player2);
        }

        public void Combat (Player FirstPlayer, Player SecondPlayer)
        {

        }


        public void CritterTurn(Critter target, Critter critter, int skill)
        {
            if (critter.MoveSet[skill] is AtkSkill)
            {
                AtkSkill skillToUse = (AtkSkill)critter.MoveSet[skill];
                skillToUse.UsingSkill(target, critter, additionalAtk);
            }

            if (critter.MoveSet[skill] is SuppSkill)
            {
                SuppSkill skillToUse = (SuppSkill)critter.MoveSet[skill];
                if (skillToUse.SkillMoveLeft(skillToUse))
                {
                    switch (skillToUse.StatChanged)
                    {
                        case SuppSkill.StatBuffed.atk:
                            additionalAtk = skillToUse.UsingSkill(critter, skillToUse.StatChanged);
                            break;
                        case SuppSkill.StatBuffed.def:
                            additionalDef = skillToUse.UsingSkill(critter, skillToUse.StatChanged);
                            break;
                        case SuppSkill.StatBuffed.spd:
                            spdDown = skillToUse.UsingSkill(target, skillToUse.StatChanged);
                            break;
                    }
                }
            }

        }





        public Critter Turn1(Player player1, Player player2)
        {
            Critter firstCritterPlayer1 = player1.CritterTeam.Peek();
            Critter firstCritterPlayer2 = player2.CritterTeam.Peek();

            if (firstCritterPlayer1.BaseSpeed == Math.Max(firstCritterPlayer1.BaseSpeed, firstCritterPlayer2.BaseSpeed))
            {
                return firstCritterPlayer1;
            }
            else
                return firstCritterPlayer2;

            return null;
        }


    }
}
