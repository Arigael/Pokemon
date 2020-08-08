using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class Control
    {
        public float additionalAtk1, additionalDef1, spdDown1, currentCritterHp1;
        public float additionalAtk2, additionalDef2, spdDown2, currentCritterHp2;
        public float dmgDealt;
        public Critter currentCritterPlayer1, currentCritterPlayer2;
        public void StartCombat(Player player1, Player player2)
        {
            Console.WriteLine("Se ha iniciado un combate entre el jugador {0} y el jugador {1}", player1.PlayerName + player2.PlayerName);

            
            Combat(Turn1(player1,player2)[0], Turn1(player1, player2)[1]);
        }

        public void Combat (Player FirstPlayer, Player SecondPlayer)
        {
            if (FirstPlayer.CritterTeam.Count != 0)
            {
                //llamar aqui el turno del critter en cuestion, pedir el input para llenar los parametros del metodo CritterTurn();
                currentCritterPlayer1 = FirstPlayer.CritterTeam.Peek();
                currentCritterHp1 = currentCritterPlayer1.HP;

                // Asi el critter del jugador 1 atacaria al critter del jugador 2
                currentCritterHp2 = CritterTurn(SecondPlayer.CritterTeam.Peek(),FirstPlayer.CritterTeam.Peek(),1,dmgDealt);

                //crear un switch en donde se defina el tipo de acciones que pueda llevar acabo el jugador en su turno, al final de la accion llamar el turno del jugador 2
                
            }
        }


        public float CritterTurn(Critter target, Critter critterPlaying, int skill, float statAffected)
        {
            statAffected = critterPlaying.ThrowSkill(target,critterPlaying,additionalAtk1,critterPlaying.MoveSet[skill], statAffected);
            return statAffected;
        }


        public List<Player> Turn1(Player player1, Player player2)
        {
            Critter firstCritterPlayer1 = player1.CritterTeam.Peek();
            Critter firstCritterPlayer2 = player2.CritterTeam.Peek();
            List<Player> playerOrder = new List<Player>();

            if (firstCritterPlayer1.BaseSpeed == Math.Max(firstCritterPlayer1.BaseSpeed, firstCritterPlayer2.BaseSpeed))
            {
                playerOrder.Add(player1);
                return playerOrder;
            }
            else
                playerOrder.Add(player2);
                return playerOrder;
        }


    }
}
