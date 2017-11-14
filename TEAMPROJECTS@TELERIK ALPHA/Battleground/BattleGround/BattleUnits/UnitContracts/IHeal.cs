using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround
{
    public interface IHeal
    {
        void Heal(IHealer healedUnit);
    }
}
