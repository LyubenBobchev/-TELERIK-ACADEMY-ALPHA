using Academy.Models.AcademyResources;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class DemoResource : Resource, ILectureResource
    {
        public DemoResource(string name, string url) : base(name, url)
        {

        }

        public override string PrintInfo()
        {
            return "";
        }

        public override string TypeOfResource()
        {
            return string.Format("Demo");
        }
    }
}
