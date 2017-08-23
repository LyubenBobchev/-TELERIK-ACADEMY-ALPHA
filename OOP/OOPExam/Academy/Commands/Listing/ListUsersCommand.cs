using System;
using System.Collections.Generic;
using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using System.Linq;
using Academy.Models;

namespace Academy.Commands.Listing
{
    public class ListUsersCommand : ICommand
    {
        private IEngine engine;
        private IAcademyFactory factory;

        public ListUsersCommand(IAcademyFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;

        }

        public string Execute(IList<string> parameters)
        {
            var list = this.engine.Trainers.Select(x => (IUser)x).ToList();
            list.AddRange(this.engine.Students);

            return string.Join("\n", list);
        }
    }
}
