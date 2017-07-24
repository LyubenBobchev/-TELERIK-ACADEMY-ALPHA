using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Student : Person
    {
        public Student(int age, string name, string sex, long uniqueClassNumber) : base(age, name, sex)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }
        public long UniqueClassNumber { get; set; }
    }
}
