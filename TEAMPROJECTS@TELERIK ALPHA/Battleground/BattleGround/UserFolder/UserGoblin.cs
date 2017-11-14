using ProjectBattleGround.UserFolder.UserContracts;

namespace ProjectBattleGround.UserFolder
{
    public class UserGoblin : User, IUser
    {
        public UserGoblin( ) : base()
        {
        }

        public override void BuildUserArmy()
        {
            this.UserArmy.Add(new Archer());
            this.UserArmy.Add(new Healer());
            this.UserArmy.Add(new Knight());
            this.UserArmy.Add(new Magician(health: 100));
        }
    }
}
