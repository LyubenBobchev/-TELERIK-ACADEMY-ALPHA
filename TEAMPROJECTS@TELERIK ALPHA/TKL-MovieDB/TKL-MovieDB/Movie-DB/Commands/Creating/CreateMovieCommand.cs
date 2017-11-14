using Models.Framework;
using Movie_DB.Commands.Abstarcts;
using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Creating
{
    public class CreateMovieCommand : AbstractCommand, ICommand
    {
        private List<string> movieData = new List<string>();
        private List<string> movieGenres = new List<string>();
        private List<string> movieCast = new List<string>();

        public CreateMovieCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
            : base(context, factory, reader, writer)
        {
        }

        public void CollectData()
        {
            writer.WriteLine("Enter Movie Title: "); // movieData[0]
            movieData.Add(reader.ReadLine());

            writer.WriteLine("Enter Genres: ");
            movieGenres.AddRange(reader.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries));

            writer.WriteLine("Enter Year: ");
            movieData.Add(reader.ReadLine()); //movieData[1]

            writer.WriteLine("Enter Release Date: ");
            movieData.Add(reader.ReadLine()); //movieData[2]

            writer.WriteLine("Enter Synopsis: ");
            movieData.Add(reader.ReadLine()); //movieData[3]

            writer.WriteLine("Enter Writer: ");
            movieData.Add(reader.ReadLine());//movieData[4]

            writer.WriteLine("Enter Director: ");
            movieData.Add(reader.ReadLine()); //movieData[5]

            writer.WriteLine("Enter Cast: ");
            movieCast.AddRange(reader.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries));

            writer.WriteLine("Enter Budget: ");
            movieData.Add(reader.ReadLine());//movieData[6]
        }

        public string Execute()
        {
            ICollection<Genre> movieGenresToAdd = new Collection<Genre>();
            ICollection<Person> actorsToAdd = new Collection<Person>();

            CollectData();
            var movieTitle = movieData[0];
            var writerName = movieData[4];
            var directorName = movieData[5];
            foreach (var genre in movieGenres)
            {
                Genre genreFromContext = context.Genres.Where(r => r.Name == genre).FirstOrDefault();

                if (genreFromContext != null && genre == genreFromContext.Name)
                {
                    movieGenresToAdd.Add(genreFromContext);
                }
                else
                {
                    writer.WriteLine("There is no such genre in our database, so we are going to create this one for you");
                    var newGenre = this.factory.CreateGenre(genre);

                    movieGenresToAdd.Add(newGenre);

                    writer.WriteLine("Genre created");
                    //context.Genres.Add(newGenre);
                    //context.SaveChanges();
                }
            }

            Person writerFromContext = context.Persons.Where(p => p.FirstName == writerName).FirstOrDefault();
            if (writerFromContext == null || writerFromContext.FirstName != writerName)
            {
                writer.WriteLine("There is no such writer in our database, so we are going to create this one for you");
                writer.WriteLine("Enter Last Name of the Writer:");
                var lastName = reader.ReadLine();
                var writerJob = "Writer";
                var newWriter = this.factory.CreatePerson(writerName, lastName, writerJob, movieTitle);

                writerFromContext = newWriter;

                writer.WriteLine("Writer created");

                //context.Persons.Add(newWriter);
                //context.SaveChanges();
            }

            Person directorFromContext = context.Persons.Where(p => p.FirstName == directorName).FirstOrDefault();
            if (directorFromContext == null || directorFromContext.FirstName != directorName)
            {
                writer.WriteLine("There is no such director in our database, so we are going to create this one for you");
                writer.WriteLine("Enter Last Name of the Director:");
                var lastName = reader.ReadLine();
                var directorJob = "Director";
                var newDirector = this.factory.CreatePerson(directorName, lastName, directorJob, movieTitle);
                
                writer.WriteLine("Director created");

                directorFromContext = newDirector;
                //context.Persons.Add(newDirector);
                //context.SaveChanges();
            }

            foreach (var person in movieCast)
            {
                string[] personFullName = person.Split(' ');
                string personFirstName = personFullName[0];
                string personLastName = personFullName[1];
                Person personFromContext = context.Persons.
                                        Where(n => n.FirstName == personFirstName && n.LastName == personLastName)
                                        .First();

                if (personFromContext != null && personFromContext.FirstName == personFirstName && personFromContext.LastName == personLastName)
                {
                    actorsToAdd.Add(personFromContext);
                }
                else
                {
                    string jobTitle = string.Empty;
                    writer.WriteLine("There is no such person in our database, so we are going to create this one for you");
                    writer.WriteLine("Enter job title for this person");
                    jobTitle = reader.ReadLine();
                    var newPerson = this.factory.CreatePerson(personFirstName, personLastName, jobTitle, movieTitle);

                    actorsToAdd.Add(newPerson);
                    //context.Persons.Add(newPerson);
                    //context.SaveChanges();
                }

            }

            var budgetDecimal = decimal.Parse(movieData[6]);
            var movie = this.factory.CreateMovie(movieData[0], movieGenresToAdd, movieData[1], movieData[2], movieData[3],
                writerFromContext, directorFromContext, actorsToAdd, budgetDecimal);

            context.Movies.Add(movie);

            context.SaveChanges();

            return "Movie Created!";
        }
    }
}
