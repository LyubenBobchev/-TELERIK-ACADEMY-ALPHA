using ProjectBattleGround.UserFolder.UserContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround.Players.Contracts
{
    public interface IPlayer
    {
        IList<IBattleUnit> PlayerArmy { get;}

        int ReturnArmySize();
    }
}
