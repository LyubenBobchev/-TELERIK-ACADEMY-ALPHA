using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart1
{
    class Teacher : Person
    {
        public Teacher(int age, string name, string sex) : base(age, name, sex)
        {

        }
        public Disciplines[] SetOfDisciplines { get; set; }
    }
}
