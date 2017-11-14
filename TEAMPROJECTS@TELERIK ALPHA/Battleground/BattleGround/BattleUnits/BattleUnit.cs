using System;

namespace ProjectBattleGround
{
    public abstract class BattleUnit : IBattleUnit
    {
        //fields
        private int health;
        private int damage;
        private CurrentUnitPossition unitPossition;

        //constructor
        public BattleUnit(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }

        //properties
        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value;
            }
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }
            private set
            {
                this.damage = value;
            }
        }

        public CurrentUnitPossition UnitPossition
        {
            get
            {
                return this.unitPossition;
            }
            set
            {
                this.unitPossition = value;
            }
        }
        

        //methods

        //this unit receives dmg
        public void TakeDamage(IBattleUnit damageDealer)
        {
            this.Health = this.Health - damageDealer.Damage;
            if (this.Health < 0)
            {
                this.Health = 0;
            }
        }

        //this unit takes dmg
        public void Heal(IHealer healerUnit)
        {
            this.health = this.health + healerUnit.HealingPower;
        }

        //returns the health of a unit within n size of spaces
        public string ReturnHealthInANumberOfSpaces(int numberOfSpaces)
        {
            string unitHealthInThreeSpaces = this.Health.ToString();
            int lenght = unitHealthInThreeSpaces.Length;
            for (int i = lenght; i < numberOfSpaces; i++)
            {
                unitHealthInThreeSpaces = " " + unitHealthInThreeSpaces;
            }
            return unitHealthInThreeSpaces;
        }

        //returns the dmg points of a unit within n size of spaces 
        public string ReturnDamagePointsInANumberOfSpaces(int numberOfSpaces)
        {
            string unitDamageInThreeSpaces = this.Damage.ToString();
            int lenght = unitDamageInThreeSpaces.Length;
            for (int i = lenght; i < numberOfSpaces; i++)
            {
                unitDamageInThreeSpaces = " " + unitDamageInThreeSpaces;
            }
            return unitDamageInThreeSpaces;
        }

        //gives this unit a current possition
        public void CurrentPossition(int verticalPossition, int horizontalPossition)
        {
            this.UnitPossition = new CurrentUnitPossition(verticalPossition, horizontalPossition);
        }

        //
        public abstract char ReturnBattleUnitLetter();
    }
}
