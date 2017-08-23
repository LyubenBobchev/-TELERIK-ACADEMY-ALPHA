using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Trainer : ITrainer
    {
        private string username;

        public Trainer(string username, string technologies)
        {
            this.Username = username;
            this.Technologies = technologies.Split(',').Select(x => x.Trim()).ToList(); // engine requires string whe creating a trainer
        }

        public IList<string> Technologies { get; set; }

        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                if (value == null || value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
                }

                this.username = value;
            }
        }

        public override string ToString()
        {
            return string.Format(@"* Trainer:
 - Username: {0}
 - Technologies: {1}", this.Username, string.Join("; ",this.Technologies));
        }
    }
}
