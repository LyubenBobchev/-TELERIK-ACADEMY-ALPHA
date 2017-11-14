using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Framework
{
    public class Person
    {
        private ICollection<Movie> moviesAsActor;
        private ICollection<Movie> moviesAsDirector;
        private ICollection<Movie> moviesAsWriter;

        public virtual ICollection<Movie> MoviesAsActor { get; set; }
        public virtual ICollection<Movie> MoviesAsDirector { get; set; }
        public virtual ICollection<Movie> MoviesAsWriter { get; set; }

        public Person()
        {
            this.MoviesAsActor = new HashSet<Movie>();
            this.MoviesAsDirector = new HashSet<Movie>();
            this.MoviesAsWriter = new HashSet<Movie>();
        }

        public int Id { get; set; }

        [Required]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [Required]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [Required]
        [JsonProperty("job")]
        public string Job { get; set; }

        [Required]
        [JsonProperty("movie")]
        public string Movie { get; set; }
        
        public override string ToString()
        {
            return string.Format(@"
|| First Name: {0}
|| Last Name: {1}
|| Job: {2}
", this.FirstName, this.LastName, this.Job);
        }
    }
}
