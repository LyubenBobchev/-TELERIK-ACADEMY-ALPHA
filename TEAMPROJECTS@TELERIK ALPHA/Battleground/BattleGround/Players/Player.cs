using ProjectBattleGround.Players.Contracts;
using ProjectBattleGround.UserFolder.UserContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround.Players
{
    public abstract class Player : IPlayer
    {
        private IList<IBattleUnit> playerArmy;

        public Player(IUser playerArmy)
        {
            this.PlayerArmy = playerArmy.UserArmy;
        }

        public IList<IBattleUnit> PlayerArmy
        {
            get;
            private set;
        }

        public int ReturnArmySize()
        {
            int armySize=4;
            foreach(IBattleUnit unit in this.PlayerArmy)
            {
                if (unit.Health == 0)
                {
                    armySize--;
                }
            }
            return armySize;
        }
    }
}
