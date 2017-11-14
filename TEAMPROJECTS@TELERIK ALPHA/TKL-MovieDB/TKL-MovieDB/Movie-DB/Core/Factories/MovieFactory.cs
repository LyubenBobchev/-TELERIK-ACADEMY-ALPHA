using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie_DB.Models;

namespace Movie_DB.Commands.Core.Factories
{
    public class MovieFactory : IMovieFactory
    {
        public Person CreatePerson(string firstName, string lasttName, string job, string movie)
        {
            Person person = new Person()
            {
                FirstName = firstName,
                LastName = lasttName,
                Job = job,
                Movie = movie
            };

            return person;
        }

        public Genre CreateGenre(string name)
        {
            Genre genre = new Genre()
            {
                Name = name
            };

            return genre;
        }

        public Movie CreateMovie(string title, ICollection<Genre> genres, string year, string releaseDate,/* int rating,*/ string synopsis,
           Person writer, Person director, ICollection<Person> cast, decimal budget)
        {
            Movie movie = new Movie()
            {
                Title = title,
                Genres = genres,
                Year = year,
                ReleaseDate = releaseDate,
                Synopsis = synopsis,
                Writer = writer,
                Director = director,
                Cast = cast,
                Budget = budget
            };

            return movie;
        }



        public Series CreateSeries(string name, Genre genre, ICollection<Person> creators,
             ICollection<Person> writers, ICollection<Person> stars, string ongoing,
             int numberOfSeasons, int episodesPerSeason)
        {

            var series = new Series
            {
                Name = name,
                Genre = genre,
                Creators = creators,
                Writers = writers,
                Stars = stars,
                Ongoing = ongoing,
                NumberOfSeasons = numberOfSeasons,
                EpisodesPerSeason = episodesPerSeason
            };

            return series;
        }

        public Synopsis CreateSynopsis(string movieTitle, string text)
        {
            Synopsis synopsis = new Synopsis
            {
                MovieTitle = movieTitle,
                Text = text

            };

            return synopsis;
        }
    }
}




