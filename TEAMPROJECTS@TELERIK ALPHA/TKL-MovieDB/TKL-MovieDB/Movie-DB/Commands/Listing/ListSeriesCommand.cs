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

    public class ListSeriesCommand : AbstractCommand, ICommand
    {
        private readonly List<string> listData = new List<string>();

        public ListSeriesCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
            : base(context, factory, reader, writer)
        {

        }

        public void CollectData()
        {
            writer.WriteLine("=================");
            writer.WriteLine("List Series by:....");
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
                writer.Write(string.Join("\n", context.SeriesCollection.ToList()));
            }
            else
            {

                switch (listedObjectsBy)
                {
                    case "Title":
                        var ordByFirstTitle = context.SeriesCollection.Where(x => x.Name == listByParameter).ToList();
                        writer.Write(string.Join("\n", ordByFirstTitle));
                        break;
                    case "Genre":
                        var ordByLastGenre = context.SeriesCollection.Where(x => x.Genre.Name == listByParameter).ToList(); 
                        writer.Write(string.Join("\n", ordByLastGenre));
                        break;
                    //case "Year":
                    //    var ordByYear = context.SeriesCollection.Where(x => x.Year == listByParameter).ToList();// waiting for Kristian
                    //    writer.Write(string.Join("\n", ordByYear));
                    //    break;
                }
            }
            return @"=================
Series Listed!
=================";
        }
    }
}
