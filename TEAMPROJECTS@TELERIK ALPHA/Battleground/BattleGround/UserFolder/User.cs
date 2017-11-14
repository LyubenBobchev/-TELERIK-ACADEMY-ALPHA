using ProjectBattleGround.UserFolder.UserContracts;
using System.Collections.Generic;

namespace ProjectBattleGround.UserFolder
{
    public abstract class User : IUser
    {
        //fields

        //contains the army of every user.
        private IList<IBattleUnit> userArmy;

        //constructors
        public User()
        {
            this.UserArmy = new List<IBattleUnit>();
            this.BuildUserArmy();
        }

        //properties
        public IList<IBattleUnit> UserArmy
        {
            get
            {
                return this.userArmy;
            }
            private set
            {
                this.userArmy = value;
            }
        }

        //methods

        //builds the army and is implemented by every of the types differently with each having their own more powerful units.
        public abstract void BuildUserArmy();
    }
}
