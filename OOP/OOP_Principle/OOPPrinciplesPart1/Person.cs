using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart1
{
    class Person : IComment
    {
        public Person(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }

       public string AddComment(string comment)
        {

            return string.Format("Comment : {0}", comment);
        }
    }
}
