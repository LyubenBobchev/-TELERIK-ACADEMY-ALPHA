using ProjectBattleGround.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround.BattleFieldGenerator
{
    public class BattleField
    {
        //fields
        private IPlayer redPlayer;
        private IPlayer bluePlayer;
        private char?[,] battleFieldArray = new char?[3, 8];

        //constructor
        public BattleField(IPlayer redPlayer, IPlayer bluePlayer)
        {
            this.redPlayer = redPlayer;
            this.bluePlayer = bluePlayer;
            this.MakeBattleFIeld();
        }

        //methods
        //creates a battlefield with the 
        public void MakeBattleFIeld()
        {
            //puts the red player army in the right places in the array
            for (int i = 0; i < redPlayer.PlayerArmy.Count; i++)
            {
                if (this.redPlayer.PlayerArmy[i].Health > 0)
                {
                    int x = this.redPlayer.PlayerArmy[i].UnitPossition.VerticalPossition;
                    int y = this.redPlayer.PlayerArmy[i].UnitPossition.HorizontalPossition;
                    this.battleFieldArray[x, y] = this.redPlayer.PlayerArmy[i].ReturnBattleUnitLetter();
                }
            }

            //puts the blue player army in the right places in the array
            for (int i = 0; i < this.bluePlayer.PlayerArmy.Count; i++)
            {
                if (this.bluePlayer.PlayerArmy[i].Health>0)
                {
                    int x = this.bluePlayer.PlayerArmy[i].UnitPossition.VerticalPossition;
                    int y = this.bluePlayer.PlayerArmy[i].UnitPossition.HorizontalPossition;
                    this.battleFieldArray[x, y] = this.bluePlayer.PlayerArmy[i].ReturnBattleUnitLetter();
                }
            }

            //fills the rest of the array with empty chars
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!this.battleFieldArray[i, j].HasValue)
                    {
                        this.battleFieldArray[i, j] = ' ';
                    }
                }
            }
        }

        public bool IsPossitionEmpty(int horizontal,int vertical, IPlayer redPlayer, IPlayer bluePlayer)
        {
           
            for (int i = 0; i < 4; i++)
            {
                if (redPlayer.PlayerArmy[i].UnitPossition.VerticalPossition==vertical
                  &&redPlayer.PlayerArmy[i].UnitPossition.HorizontalPossition==horizontal)
                {
                    return false;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (bluePlayer.PlayerArmy[i].UnitPossition.VerticalPossition == vertical
                  && bluePlayer.PlayerArmy[i].UnitPossition.HorizontalPossition == horizontal)
                {
                    return false;
                }
            }


            return true;
        }
        public char? ReturnUnitInPossition(int verticalPossition, int HorrizontalPossition)
        {
            return this.battleFieldArray[verticalPossition, HorrizontalPossition];
        }
    }
}
