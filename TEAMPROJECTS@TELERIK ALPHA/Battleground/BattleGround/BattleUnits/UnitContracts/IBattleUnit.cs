using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBattleGround
{
    public interface IBattleUnit : IHeal, IMove, ITakeDamage, IReturnHealthInANumberOfSpaces, IReturnDamageInNumberOfSpaces
    {
        int Health { get; }
        int Damage { get; }
        CurrentUnitPossition UnitPossition { get;}

        char ReturnBattleUnitLetter();
    }
}
