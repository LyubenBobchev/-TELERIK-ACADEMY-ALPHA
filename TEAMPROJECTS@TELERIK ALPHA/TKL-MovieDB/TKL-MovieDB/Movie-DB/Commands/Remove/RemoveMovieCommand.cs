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

namespace Movie_DB.Commands.Remove
{

    public class RemoveMovieCommand : AbstractCommand, ICommand
    {

        List<string> removeData = new List<string>();

        public RemoveMovieCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
             : base(context, factory, reader, writer)
        {

        }
        public void CollectData()

        {
            writer.WriteLine("=================");
            writer.WriteLine("Enter Name of the Movie:");
            removeData.Add(reader.ReadLine());
        }

        public string Execute()
        {
            CollectData();
            var title = removeData[0];

            var removeByName = context.Movies.SingleOrDefault(x => x.Title == title);
            context.Movies.Remove(removeByName);
            context.SaveChanges();

            return @"=================
Movie Removed!
=================";
        }
    }
}

