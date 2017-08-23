using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Lecture : ILecture
    {
        private string name;

        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = Convert.ToDateTime(date);
            this.Trainer = trainer;
            this.Resources = new List<ILectureResource>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value.Length < 5 || value.Length > 30)
                {
                    throw new ArgumentException("Lecture's name should be between 5 and 30 symbols long!");
                }
                this.name = value;
            }
        }

        public DateTime Date { get; set; }

        public ITrainer Trainer { get; set; }

        public IList<ILectureResource> Resources { get; set; }

        public override string ToString()
        {
            string noResourcesMsg = "    * There are no resources in this lecture.";

            return string.Format(@"  * Lecture:
   - Name: {0}
   - Date: {1}
   - Trainer username: {2}
   - Resources:
{3}", this.Name, this.Date, this.Trainer.Username, this.Resources.Count == 0 ? noResourcesMsg : this.Resources.ToString());//string.Join("\n",this.Resources));
        }
    }
}
