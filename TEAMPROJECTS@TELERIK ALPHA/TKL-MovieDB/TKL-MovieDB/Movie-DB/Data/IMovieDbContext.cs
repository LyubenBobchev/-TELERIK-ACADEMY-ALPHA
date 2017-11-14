using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Data
{
    public interface IMovieDbContext
    {

        IDbSet<Person> Persons { get; set; }
        IDbSet<Genre> Genres { get; set; }
        IDbSet<Movie> Movies { get; set; }
        IDbSet<Series> SeriesCollection { get; set; }

        int SaveChanges();
    }
}
