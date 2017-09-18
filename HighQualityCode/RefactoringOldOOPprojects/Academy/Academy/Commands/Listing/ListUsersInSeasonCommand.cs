using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academy.Commands.Listing
{
    public class ListUsersInSeasonCommand : ICommand
    {
        private readonly IAcademyFactory factory;
        private readonly IEngine engine;
        private readonly IDatabase database;

        public ListUsersInSeasonCommand(IAcademyFactory factory, IEngine engine, IDatabase database)
        {
            this.factory = factory;
            this.engine = engine;
            this.database = database;
        }

        public string Execute(IList<string> parameters)
        {
            var seasonId = parameters[0];
            var season = this.database.Seasons[int.Parse(seasonId)];

            return season.ListUsers();
        }
    }
}
