using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using System.Collections.Generic;

namespace Academy.Commands.Listing
{
    public class ListCoursesInSeasonCommand : ICommand
    {
        private readonly IAcademyFactory factory;
        private readonly IEngine engine;
        private readonly IDatabase database;

        public ListCoursesInSeasonCommand(IAcademyFactory factory, IEngine engine, IDatabase database)
        {
            this.factory = factory;
            this.engine = engine;
            this.database = database;
        }

        public string Execute(IList<string> parameters)
        {
            var seasonId = parameters[0];
            var season = this.database.Seasons[int.Parse(seasonId)];

            return season.ListCourses();
        }
    }
}
