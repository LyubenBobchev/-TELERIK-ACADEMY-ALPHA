using Academy.Models.Contracts;
using Academy.Models.Utils.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Enums;

namespace Academy.Models
{
    public class CourseResult : ICourseResult
    {
        private float examPoints;
        private float coursePoints;
        private Grade grade;

        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            this.Course = course;
            this.ExamPoints = float.Parse(examPoints);
            this.CoursePoints = float.Parse(coursePoints);

            this.Grade = GradeCalculation(ExamPoints, CoursePoints);//automatic calculation of grade during object creation
        }

        public ICourse Course { get; set; }

        public float ExamPoints
        {
            get
            {
                return this.examPoints;
            }
            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentException("Course result's exam points should be between 0 and 1000!");
                }

                this.examPoints = value;
            }
        }

        public float CoursePoints
        {
            get
            {
                return this.coursePoints;
            }
            set
            {
                if (value < 0 || value > 125)
                {
                    throw new ArgumentException("Course result's course points should be between 0 and 125!");
                }

                this.coursePoints = value;
            }
        }

        public Grade Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                this.grade = value;
            }
            
        }

        public Grade GradeCalculation(float examPoints, float coursePoints)
        {
            if (ExamPoints >= 65 || CoursePoints >= 75)
            {
                this.Grade = Grade.Excellent;
                return this.Grade;
            }
            else if ((ExamPoints < 60 && ExamPoints >= 30) || (CoursePoints < 75 && CoursePoints >= 45))
            {
                this.Grade = Grade.Passed;
            }
            else
            {
                this.Grade = Grade.Failed;
            }
            return this.Grade;
        }

        public override string ToString()
        {
            return string.Format("  * {0}: Points - {1}, Grade - {2}", this.Course.Name, this.CoursePoints, this.Grade);
            
        }
    }
}
