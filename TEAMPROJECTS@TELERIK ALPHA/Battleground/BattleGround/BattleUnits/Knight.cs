using System;

namespace ProjectBattleGround
{
    public class Knight : BattleUnit, IMove, ITakeDamage
    {

        //constructor with default values.
        public Knight(int health = 200, int damage = 50) : base(health, damage)
        {
        }

        //methods
        public override char ReturnBattleUnitLetter()
        {
            return 'K';
        }
    }
}
