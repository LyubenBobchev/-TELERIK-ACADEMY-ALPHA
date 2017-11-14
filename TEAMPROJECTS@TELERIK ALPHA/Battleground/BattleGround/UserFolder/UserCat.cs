using ProjectBattleGround.UserFolder.UserContracts;

namespace ProjectBattleGround.UserFolder
{
    class UserCat : User, IUser
    {
        public UserCat() : base()
        {

        }

        public override void BuildUserArmy()
        {

            this.UserArmy.Add(new Archer(damage: 30));
            this.UserArmy.Add(new Healer());
            this.UserArmy.Add(new Knight());
            this.UserArmy.Add(new Magician());

        }
    }
}
