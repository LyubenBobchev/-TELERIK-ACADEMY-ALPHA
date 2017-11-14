using Bytes2you.Validation;
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

namespace Movie_DB.Commands.Creating
{
    public class CreatePersonCommand : AbstractCommand, ICommand
    {
        private List<string> personData = new List<string>();

        public CreatePersonCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
            : base(context, factory, reader, writer)
        {
        }

        public void CollectData()
        {
            writer.WriteLine("=================");
            writer.WriteLine("Enter First Name:");
            personData.Add(reader.ReadLine());
            writer.WriteLine("Enter Last Name:");
            personData.Add(reader.ReadLine());
            writer.WriteLine("Enter Job:");
            personData.Add(reader.ReadLine());
            writer.WriteLine("Enter A Movie He/She is In:");
            personData.Add(reader.ReadLine());

        }

        public string Execute()
        {
            CollectData();
            var person = this.factory.CreatePerson(personData[0], personData[1], personData[2], personData[3]);
            
            writer.WriteLine("Creating a Person...");


            context.Persons.Add(person);
            context.SaveChanges();

            return @"=================
Person Created!
=================";
        }
    }
}
