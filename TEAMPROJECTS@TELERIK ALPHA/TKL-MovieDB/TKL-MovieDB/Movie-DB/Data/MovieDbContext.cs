using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using Movie_DB.Migrations;

namespace Movie_DB.Data
{
    public class MovieDbContext : DbContext, IMovieDbContext
    {
        public MovieDbContext()
            : base("MovieDbConnection")
        {
        }
        
        public IDbSet<Movie> Movies { get; set; }
        public IDbSet<Person> Persons { get; set; }
        public IDbSet<Genre> Genres { get; set; }
        public IDbSet<Series> SeriesCollection { get; set; }

        // https://stackoverflow.com/questions/5559043/entity-framework-code-first-two-foreign-keys-from-same-table 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                   .HasRequired(m => m.Writer)
                   .WithMany(t => t.MoviesAsWriter)
                   .HasForeignKey(m => m.WriterId)
                   .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                   .HasRequired(m => m.Director)
                   .WithMany(t => t.MoviesAsDirector)
                   .HasForeignKey(m => m.DirectorId)
                   .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasMany<Person>(m => m.Cast)
                .WithMany(c => c.MoviesAsActor);

        }

    }
}
