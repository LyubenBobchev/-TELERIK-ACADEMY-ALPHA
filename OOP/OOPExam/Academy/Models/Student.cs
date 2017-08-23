using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils.Contracts;
using Academy.Models.Enums;

namespace Academy.Models
{
    class Student : IStudent
    {
        private string username;
        private Track track;

        public Student(string username, string track)
        {
            this.Username = username;

            Track parsedTrack;

            bool isParsedTrack = Enum.TryParse<Track>(track, out parsedTrack);

            if (!isParsedTrack)
            {
                throw new ArgumentException("The provided track is not valid!");
            }

            this.Track = parsedTrack;

            this.CourseResults = new List<ICourseResult>();

        }

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

        public Track Track
        {
            get
            {
                return this.track;
            }
            set
            {
                if (!Enum.IsDefined(typeof(Track), value))
                {
                    throw new ArgumentException("The provided track is not valid!");
                }

                this.track = value;
            }
        }

        public IList<ICourseResult> CourseResults { get; set; }

        public override string ToString()
        {
            string noCoursesResultsMsg = "  * User has no course results!";

            return string.Format(@"* Student:
 - Username: {0}
 - Track: {1}
 - Course results:
{2}", this.Username, this.Track, this.CourseResults.Count == 0 ? noCoursesResultsMsg : string.Join("\n", this.CourseResults));
        }
    }
}
