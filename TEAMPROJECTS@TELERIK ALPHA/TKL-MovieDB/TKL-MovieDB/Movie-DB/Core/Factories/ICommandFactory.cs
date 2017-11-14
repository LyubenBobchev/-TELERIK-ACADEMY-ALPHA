using Models.Framework;
using Movie_DB.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Core.Factories
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandChoice);
    }
}
