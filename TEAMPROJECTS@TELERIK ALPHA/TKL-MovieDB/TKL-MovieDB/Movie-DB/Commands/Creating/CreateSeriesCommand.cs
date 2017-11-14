using Models.Framework;
using Movie_DB.Commands.Abstarcts;
using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using System.Collections.Generic;
using System.Linq;


namespace Movie_DB.Commands.Creating
{
    public class CreateSeriesCommand : AbstractCommand, ICommand
    {
        private string name;
        private string genreName;
        private string ongoing;
        private int numberOfSeasons;
        private int episodesPerSeason;
        private ICollection<Person> sCreators;
        private ICollection<Person> sWriters;
        private ICollection<Person> sStars;

        public CreateSeriesCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
            : base(context, factory, reader, writer)
        {
        }

        public void CollectData()
        {
            writer.WriteLine("Enter Series Name:");
            name = reader.ReadLine();
            writer.WriteLine("Enter Series Genre:");
            genreName = reader.ReadLine();
            writer.WriteLine("Enter Number Of Seasons:");
            numberOfSeasons = int.Parse(reader.ReadLine());
            writer.WriteLine("Enter Episodes Per Season:");
            episodesPerSeason = int.Parse(reader.ReadLine());
            writer.WriteLine("Enter Series ongoing status (yes/no):");
            ongoing = reader.ReadLine();

            // get creators
            foreach (var p in context.Persons)
            {
                // if(p.se = )
            }
        }

        public string Execute()
        {
            CollectData();
            var genre = context.Genres.FirstOrDefault(g => g.Name == genreName);
            if (genre == null)
            {
                genre = new Genre() { Name = genreName };
                context.Genres.Add(genre);
                context.SaveChanges();
                genre = context.Genres.FirstOrDefault(g => g.Name == genreName);
            }

            foreach (var p in context.Persons)
            {
                if (p.Movie == name && p.Job == "creator")
                {
                    var person = context.Persons.FirstOrDefault(pr => pr.FirstName == p.FirstName);
                    sCreators.Add(person);
                }
                if (p.Movie == name && p.Job == "writer")
                {
                    var person = context.Persons.FirstOrDefault(pr => pr.FirstName == p.FirstName);
                    sWriters.Add(person);
                }
                if (p.Movie == name && p.Job == "actor")
                {
                    var person = context.Persons.FirstOrDefault(pr => pr.FirstName == p.FirstName);
                    sStars.Add(person);
                }
            }

            var series = this.factory.CreateSeries(name, genre, sCreators, sWriters, sStars, ongoing,numberOfSeasons,episodesPerSeason);

            context.SeriesCollection.Add(series);

            context.SaveChanges();

            return "Series Created";
        }
    }
}
