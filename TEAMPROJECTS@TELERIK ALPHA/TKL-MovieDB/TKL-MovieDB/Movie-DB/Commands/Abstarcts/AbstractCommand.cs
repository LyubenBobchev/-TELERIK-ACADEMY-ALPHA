using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Abstarcts
{
    public abstract class AbstractCommand
    {
        protected readonly IMovieDbContext context;
        protected readonly IMovieFactory factory;
        protected readonly IReader reader;
        protected readonly IWriter writer;

        public AbstractCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
        {
            this.context = context;
            this.factory = factory;
            this.reader = reader;
            this.writer = writer;
        }
    }
}
