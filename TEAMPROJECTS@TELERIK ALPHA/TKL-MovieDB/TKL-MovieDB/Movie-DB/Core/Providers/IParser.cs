using Movie_DB.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Core.Providers
{
    public interface IParser
    {
        ICommand ParseCommand(string fullCommand);
    }
}
