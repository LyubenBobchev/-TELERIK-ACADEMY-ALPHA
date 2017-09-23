using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using Traveller.Core.Providers;
using Traveller.Core.Providers.Contracts;
using Traveller.Models;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core
{
    public class Engine : IEngine
    {
        private const string TerminationCommand = "Exit";
        private const string NullProvidersExceptionMessage = "cannot be null.";
        private StringBuilder Builder = new StringBuilder();

        private readonly ICommandParser commandParser;


        public Engine(ICommandParser commandParser)
        {
            Guard.WhenArgument(commandParser, "commandParser").IsNull().Throw();

            this.commandParser = commandParser;
        }

        public void Start()
        {
            while (true)
            {
                try
                {
                    var commandAsString = Console.ReadLine();

                    if (commandAsString.ToLower() == TerminationCommand.ToLower())
                    {
                        Console.Write(this.Builder.ToString());
                        break;
                    }

                    this.ProcessCommand(commandAsString);
                }
                catch (Exception ex)
                {
                    this.Builder.AppendLine(ex.Message);
                }
            }
        }

        private void ProcessCommand(string commandAsString)
        {
            if (string.IsNullOrWhiteSpace(commandAsString))
            {
                throw new ArgumentNullException("Command cannot be null or empty.");
            }

            var command = this.commandParser.ParseCommand(commandAsString);
            var parameters = this.commandParser.ParseParameters(commandAsString);

            var executionResult = command.Execute(parameters);
            this.Builder.AppendLine(executionResult);
        }
    }
}
