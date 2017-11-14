using System.Collections.Generic;

namespace ProjectBattleGround.UserFolder.UserContracts
{
    public interface IUser
    {
        IList<IBattleUnit> UserArmy { get; }
        void BuildUserArmy();    
    }
}
