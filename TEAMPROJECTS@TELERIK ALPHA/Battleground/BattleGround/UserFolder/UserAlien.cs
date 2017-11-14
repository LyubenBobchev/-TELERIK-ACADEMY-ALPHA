using ProjectBattleGround.UserFolder.UserContracts;

namespace ProjectBattleGround.UserFolder
{
    class UserAlien : User, IUser
    {
        public UserAlien() : base()
        {
            
        }

        public override void BuildUserArmy()
        {
            this.UserArmy.Add(new Archer());
            this.UserArmy.Add(new Healer(healingPower: 40));
            this.UserArmy.Add(new Knight());
            this.UserArmy.Add(new Magician());
        }
    }
}
