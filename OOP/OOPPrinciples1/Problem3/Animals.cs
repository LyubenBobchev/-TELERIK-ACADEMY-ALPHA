using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Animals
    {
        public Animals(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
    }
}
