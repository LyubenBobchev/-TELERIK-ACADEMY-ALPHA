using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Framework
{
    public class Genre
    {
        private ICollection<Movie> movies;


        public Genre()
        {
            this.Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }

        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

        public override string ToString()
        {
            return string.Format(@"
|| Name: {0}", this.Name);

        }
    }
}
