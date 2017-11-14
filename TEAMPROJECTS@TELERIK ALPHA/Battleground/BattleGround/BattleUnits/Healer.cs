using System;

namespace ProjectBattleGround
{
    public class Healer : BattleUnit, IHealer
    {
        //fields
        private int healingPower;

        //constructor with default values.
        public Healer(int health = 50, int damage = 5, int healingPower = 25) : base(health, damage)
        {
            this.HealingPower = healingPower;
        }

        //properties
        public int HealingPower
        {
            get
            {
                return this.healingPower;
            }
            private set
            {
                this.healingPower = value;
            }
        }

        public override char ReturnBattleUnitLetter()
        {
            return 'H' ;
        }
    }
}
