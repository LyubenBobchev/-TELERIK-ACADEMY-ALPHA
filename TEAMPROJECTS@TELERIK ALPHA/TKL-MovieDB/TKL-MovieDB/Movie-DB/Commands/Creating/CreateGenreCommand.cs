using Movie_DB.Commands.Abstarcts;
using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Creating
{
    public class CreateGenreCommand : AbstractCommand, ICommand
    {
        private string genreName;

        public CreateGenreCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
            : base(context, factory, reader, writer)
        {
        }
        public void CollectData()
        {
            writer.WriteLine("Enter Genre Name:");
            genreName = reader.ReadLine();
        }

        public string Execute()
        {
            CollectData();
            var genre = this.factory.CreateGenre(genreName);

            context.Genres.Add(genre);
            context.SaveChanges();

            return @"=================
Genre Created!
=================";
        }
    }
}
