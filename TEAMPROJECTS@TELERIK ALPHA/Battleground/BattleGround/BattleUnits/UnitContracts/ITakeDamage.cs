using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround
{
    public interface ITakeDamage
    {
        void TakeDamage(IBattleUnit damageDealer);
    }
}
