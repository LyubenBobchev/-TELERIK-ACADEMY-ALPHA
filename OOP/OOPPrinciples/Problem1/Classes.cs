using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Classes
    {
        public Classes(string name, string identifier)
        {
            this.Name = name;
            this.UniqueTextIdentifier = identifier;
        }

        public string Name { get; set; }
        public string UniqueTextIdentifier { get; set; }
    }
}
