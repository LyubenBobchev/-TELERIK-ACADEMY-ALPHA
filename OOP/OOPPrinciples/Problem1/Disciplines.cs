using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Disciplines
    {
        public Disciplines(string name, int numberOfLectures, int numberOfExcercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcercises = numberOfExcercises;

        }

        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExcercises { get; set; }
    }
}
