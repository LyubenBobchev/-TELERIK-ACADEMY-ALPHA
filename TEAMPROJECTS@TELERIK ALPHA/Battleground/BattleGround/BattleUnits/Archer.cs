using System;

namespace ProjectBattleGround
{
    public class Archer : BattleUnit, ITakeDamage, IMove
    {

        //constructor with default values.
        public Archer(int health = 100, int damage = 20) : base(health, damage)
        {
        }

        //method
        public override char ReturnBattleUnitLetter()
        {
            return 'A';
        }
    }
}
