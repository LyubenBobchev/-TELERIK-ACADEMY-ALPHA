using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectBattleGround.UserFolder.UserContracts;

namespace ProjectBattleGround.Players
{
    public class RedPlayer : Player
    {
        public RedPlayer(IUser playerArmy) : base(playerArmy)
        {
            this.PlayerArmy[0].CurrentPossition(0, 0); // Archer
            this.PlayerArmy[1].CurrentPossition(1, 0); //Healer
            this.PlayerArmy[2].CurrentPossition(1, 1); //Knight
            this.PlayerArmy[3].CurrentPossition(2, 0); //Magician
        }
    }
}
