using Models.Framework;
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
    public class ListPersonsCommand : AbstractCommand, ICommand
    {
        private readonly List<string> listData = new List<string>();

        public ListPersonsCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
            : base(context, factory, reader, writer)
        {

        }

        public void CollectData()
        {
            writer.WriteLine("=================");
            writer.WriteLine("List Persons by:....");
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
                writer.Write(string.Join("\n", context.Persons.ToList()));
            }
            else
            {
                switch (listedObjectsBy)
                {
                    case "First Name":
                        var ordByFirstName = context.Persons.Where(x => x.FirstName == listByParameter).ToList();
                        writer.Write(string.Join("\n", ordByFirstName));
                        break;
                    case "Last Name":
                        var ordByLastName = context.Persons.Where(x => x.LastName == listByParameter).ToList();
                        writer.Write(string.Join("\n", ordByLastName));
                        break;
                    case "Job":
                        var ordByJob = context.Persons.Where(x => x.Job == listByParameter).ToList(); ;
                        writer.Write(string.Join("\n", ordByJob));
                        break;
                }
            }
            return @"=================
Persons Listed!
=================";
        }
    }
}
