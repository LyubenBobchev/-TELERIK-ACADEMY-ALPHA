using Models.Framework;
using Movie_DB.Commands.Admin;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core;
using Movie_DB.Data;
using Movie_DB.Migrations;
using Movie_DB.Ninject;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Movie_DB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieDbContext, Configuration>());

            IKernel kernel = new StandardKernel(new MovieModule());

            IEngine engine = kernel.Get<Engine>();
            engine.Start();

            //using(var context = new MovieDbContext())
            //{
            //    var genre = context.Genres.Where(x=>x.Name == "comedy").ToString();
            //    Console.WriteLine(genre.ToString());
            //}

            // JSON manual test
            //Genre genre = new Genre()
            //{
            //    Name = "Comedy"
            //};

            //JSONController.SaveToFile(genre);
            //JSONController.ReadGenresFromJSON();



        }
    }
}
