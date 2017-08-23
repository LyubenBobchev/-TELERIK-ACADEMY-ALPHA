using Academy.Models.AcademyResources;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class VideoResource : Resource, ILectureResource
    {
        public VideoResource(string name, string url,DateTime uploadedOn) : base(name, url)
        {
            this.UploadedOn = uploadedOn;
        }

        public DateTime UploadedOn { get; set; }

        public override string PrintInfo()
        {
            return string.Format(" - Uploaded on: {0}", this.UploadedOn);
        }

        public override string TypeOfResource()
        {
            return string.Format("Video");
        }
    }
}
