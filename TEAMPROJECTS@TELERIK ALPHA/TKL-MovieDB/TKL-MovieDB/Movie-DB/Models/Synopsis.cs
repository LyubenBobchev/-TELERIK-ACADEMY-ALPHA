using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Models
{
    public class Synopsis
    {
        public Synopsis()
        {

        }

        public int Id { get; set; }

        public string MovieTitle { get; set; }

        public string Text { get; set; }
    }
}
