using Movie_DB.Commands;
using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Commands.Creating;
using Movie_DB.Commands.Listing;
using Movie_DB.Commands.Remove;
using Movie_DB.Core.Commands;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Ninject
{
    public class MovieModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IMovieDbContext>().To<MovieDbContext>();
            this.Bind<IReader>().To<ConsoleReader>();
            this.Bind<IWriter>().To<ConsoleWriter>();
            this.Bind<IParser>().To<CommandParser>();

            this.Bind<IMovieFactory>().To<MovieFactory>();
            this.Bind<ICommandFactory>().To<CommandFactory>();
            this.Bind<ICommand>().To<CreatePersonCommand>().Named("Create Person");
            this.Bind<ICommand>().To<CreateGenreCommand>().Named("Create Genre");
            this.Bind<ICommand>().To<CreateMovieCommand>().Named("Create Movie");
            this.Bind<ICommand>().To<CreateSeriesCommand>().Named("Create Series");

            this.Bind<ICommand>().To<ListPersonsCommand>().Named("List Persons");
            this.Bind<ICommand>().To<ListMoviesCommand>().Named("List Movies");
            this.Bind<ICommand>().To<ListSeriesCommand>().Named("List Series");

            this.Bind<ICommand>().To<RemovePersonCommand>().Named("Remove Person");
            this.Bind<ICommand>().To<RemoveMovieCommand>().Named("Remove Movie");
            this.Bind<ICommand>().To<RemoveSeriesCommand>().Named("Remove Series");

            this.Bind<ICommand>().To<PDFExportCommand>().Named("Create PDF");


            this.Bind<ICommand>().To<HelpCommand>().Named("/help");
        }
    }
}
