using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Bytes2you.Validation;

namespace Academy.Core
{
    public class Database : IDatabase
    {
        private readonly IList<ISeason> seasons;
        private readonly IList<IStudent> students;
        private readonly IList<ITrainer> trainers;

        public Database(IList<ISeason> seasons, IList<IStudent> students, IList<ITrainer> trainers)
        {
            Guard.WhenArgument(seasons, "seasons").IsNull().Throw();
            Guard.WhenArgument(students, "students").IsNull().Throw();
            Guard.WhenArgument(trainers, "trainers").IsNull().Throw();

            this.seasons = seasons;
            this.students = students;
            this.trainers = trainers;
        }

        public IList<ISeason> Seasons { get; set; }
        public IList<IStudent> Students { get; set; }
        public IList<ITrainer> Trainers { get; set; }
    }
}
