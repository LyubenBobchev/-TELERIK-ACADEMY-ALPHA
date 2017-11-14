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

namespace Movie_DB.Commands.Listing
{
    public class ListMoviesCommand : AbstractCommand, ICommand
    {
        private readonly List<string> listData = new List<string>();

        public ListMoviesCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
            : base(context, factory, reader, writer)
        {

        }

        public void CollectData()
        {
            writer.WriteLine("=================");
            writer.WriteLine("List Movies by:....");
            listData.Add(reader.ReadLine());
            Console.WriteLine("List All(type 'List All') with that {0} or Enter a specific {0}:....", listData[0]);
            listData.Add(reader.ReadLine());
        }

        public string Execute()
        {
            CollectData();
            string listedObjectsBy = listData[0];
            string listByParameter = listData[1];
            writer.WriteLine("");
            writer.WriteLine("Listing....");

            if (listData[1] == "List All")
            {
                writer.Write(string.Join("\n", context.Movies.ToList()));
            }
            else
            {
                switch (listedObjectsBy)
                {
                    case "Title":
                        var ordByFirstTitle = context.Movies.Where(x => x.Title == listByParameter).ToList();
                        writer.WriteLine(string.Join("\n", ordByFirstTitle));
                        break;
                    case "Genre":
                        var ordByLastGenre = context.Movies.Where(x => x.Genres.Any(y => y.Name == listByParameter)).ToList(); // waiting for ceco
                        writer.WriteLine(string.Join("\n", ordByLastGenre.Select(m => m.Title)));
                        break;
                    case "Year":
                        var ordByYear = context.Movies.Where(x => x.Year == listByParameter).ToList(); ;
                        writer.WriteLine(string.Join("\n", ordByYear));
                        break;
                }
            }
            return @"=================
Movies Listed!
=================";
        }
    }
}
