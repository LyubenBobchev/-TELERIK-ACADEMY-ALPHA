using ProjectBattleGround.UserFolder.UserContracts;

namespace ProjectBattleGround.UserFolder
{
    class UserDoge : User, IUser
    {
        public UserDoge( ) : base()
        {

        }

        public override void BuildUserArmy()
        {
            this.UserArmy.Add(new Archer());
            this.UserArmy.Add(new Healer());
            this.UserArmy.Add(new Knight(health: 225));
            this.UserArmy.Add(new Magician());
        }
    }
}
