
using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Traveller.Commands.Contracts;
using Traveller.Core.Providers.Contracts;

namespace Traveller.Core.Providers
{
    public class CommandParser : ICommandParser
    {
        private readonly ICommandFactory commandFactory;

        public CommandParser(ICommandFactory commandFactory)
        {
            Guard.WhenArgument(commandFactory, "commandFactory").IsNull().Throw();

            this.commandFactory = commandFactory;
        }

        public ICommand ParseCommand(string fullCommand)
        {
            var commandName = fullCommand.Split()[0];
            var command = this.commandFactory.CreateCommand(commandName); ;
            return command;
        }

        public IList<string> ParseParameters(string fullCommand)
        {
            var commandParts = fullCommand.Split().Skip(1).ToList();
            if (commandParts.Count == 0)
            {
                return new List<string>();
            }

            return commandParts;
        }
    }
}
