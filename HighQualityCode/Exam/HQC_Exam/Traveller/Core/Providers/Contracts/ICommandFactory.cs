using System;
using Traveller.Commands.Contracts;

namespace Traveller.Core.Providers
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandName);
    }
}