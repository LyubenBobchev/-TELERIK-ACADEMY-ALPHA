using Academy.Models.AcademyResources;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Core.Providers;

namespace Academy.Models
{
    public class HomeWorkResource : Resource, ILectureResource
    {
        public HomeWorkResource(string name, string url, DateTime dueDate) : base(name, url)
        {
            this.DueDate = dueDate.AddDays(7);
        }

        public DateTime DueDate { get; set; }

        public override string PrintInfo()
        {
            return string.Format(" - Due date: {0}", this.DueDate);
        }

        public override string TypeOfResource()
        {
            return string.Format("Homework");
        }
    }
}
