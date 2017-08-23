using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.AcademyResources
{
    public abstract class Resource : ILectureResource
    {
        private string name;
        private string url;

        public Resource(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Resource name should be between 3 and 15 symbols long!");
                }

                this.name = value;
            }
        }

        public string Url
        {
            get
            {
                return this.url;
            }
            set
            {
                if (value == null || value.Length < 5 || value.Length > 150)
                {
                    throw new ArgumentException("Resource url should be between 5 and 150 symbols long!");
                }

                this.url = value;
            }
        }

        public abstract string TypeOfResource();

        public abstract string PrintInfo();

        public override string ToString()
        {
            return string.Format(@"    * Resource:
     - Name: {0}
     - Url: {1}
     - Type: {2}
    {3}",this.Name, this.Url, this.TypeOfResource(),this.PrintInfo());
        }

    }
}
