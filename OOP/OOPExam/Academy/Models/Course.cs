using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    class Course : ICourse
    {
        private string name;
        private int lecturesPerWeek;
        
        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = int.Parse(lecturesPerWeek);
            this.StartingDate = Convert.ToDateTime(startingDate);
            this.EndingDate = Convert.ToDateTime(startingDate).AddDays(30);
            this.OnsiteStudents = new List<IStudent>();
            this.OnlineStudents = new List<IStudent>();
            this.Lectures = new List<ILecture>();
        }
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value.Count() < 3 || value.Count() > 45)
                {
                    throw new ArgumentException("The name of the course must be between 3 and 45 symbols!");
                }

                this.name = value;
            }
        }

        public int LecturesPerWeek
        {
            get
            {
                return this.lecturesPerWeek;
            }
            set
            {
                if (value < 1 || value > 7)
                {
                    throw new ArgumentException("The number of lectures per week must be between 1 and 7!");
                }
                this.lecturesPerWeek = value;
            }
        }

        public DateTime StartingDate { get; set; }

        public DateTime EndingDate { get; set; }

        public IList<IStudent> OnsiteStudents { get; set; }

        public IList<IStudent> OnlineStudents { get; set; }

        public IList<ILecture> Lectures { get; set; }

        public override string ToString()
        {
            string noLecturesMsg = "  * There are no lectures in this course!";


            return string.Format(@"* Course:
 - Name: {0}
 - Lectures per week: {1}
 - Starting date: {2}
 - Ending date: {3}
 - Onsite students: {4}
 - Online students: {5}
 - Lectures:
{6}", this.Name, this.LecturesPerWeek, this.StartingDate, this.EndingDate,this.OnsiteStudents.Count,this.OnlineStudents.Count, this.Lectures.Count == 0 ? noLecturesMsg : string.Join("\n",this.Lectures));

        }
    }
}
