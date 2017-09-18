using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Contracts
{
    public interface IDatabase
    {
         IList<ISeason> Seasons { get; set; }

         IList<IStudent> Students { get; set; }

         IList<ITrainer> Trainers { get; set; }
    }
}
