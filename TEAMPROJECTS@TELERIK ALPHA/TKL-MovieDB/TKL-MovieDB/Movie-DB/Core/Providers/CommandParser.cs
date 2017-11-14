using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using Bytes2you.Validation;

namespace Movie_DB.Core.Providers
{
    public class CommandParser : IParser
    {
        private readonly ICommandFactory factory;

        public CommandParser(ICommandFactory factory)
        {
            Guard.WhenArgument(factory, "factory").IsNull().Throw();

            this.factory = factory;
        }

        public ICommand ParseCommand(string fullCommand)
        {
            var commandName = fullCommand;

            return this.factory.CreateCommand(commandName);
        }
    }
}
