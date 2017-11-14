using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Framework
{

    public class Movie
    {
        private ICollection<Genre> genres;

        private ICollection<Person> cast;




        public Movie()
        {
            this.genres = new HashSet<Genre>();
            this.Cast = new HashSet<Person>();
        }

        public int Id { get; set; }
        public int WriterId { get; set; }
        public int DirectorId{ get; set; }
       

        
        [StringLength(50, MinimumLength = 2, 
            ErrorMessage = "The Name's length cannot be less than 5 or more than 50 symbols long.")]
        [JsonProperty("title")]
        public string Title { get; set; }

        [Required]
        [JsonProperty("genres")]
        public virtual ICollection<Genre> Genres { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }

        //[JsonProperty("rating")]
        //public int Rating { get; set; }

        
        [StringLength(300, MinimumLength = 2,
            ErrorMessage = "The Movie's Synopsis' length cannot be less than 80 or more than 300 symbols long.")]
        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("writers")]
        public virtual Person Writer { get; set; }
        
        [JsonProperty("directors")]
        public virtual Person Director { get; set; }

        [JsonProperty("cast")]
        public virtual ICollection<Person> Cast { get; set; }

        [JsonProperty("budget")]
        public decimal Budget { get; set; }

        public override string ToString()
        {
            return string.Format(@"
|| Title: {0}
|| Year: {1}", this.Title, this.Year);

        }
    }
}
