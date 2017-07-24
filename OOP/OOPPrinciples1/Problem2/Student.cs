using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Student: Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Student's grade cannot be less than or equal to zero.");
                }
                else
                {
                    this.grade = value;
                }
            }
        }

        public override string ToString()
        {
            if (this.Grade == 1)
            {
                return string.Format("{0} {1} - {2}st grade",this.FirstName, this.LastName, this.Grade);
            }
            else if (this.Grade == 2)
            {
                return string.Format("{0} {1} - {2}nd grade", this.FirstName, this.LastName, this.Grade);
            }
            else if (this.Grade == 3)
            {
                return string.Format("{0} {1} - {2}rd grade", this.FirstName, this.LastName, this.Grade);
            }
            else
            {
                return string.Format("{0} {1} - {2}th grade", this.FirstName, this.LastName, this.Grade);
            }
        }
    }
}
