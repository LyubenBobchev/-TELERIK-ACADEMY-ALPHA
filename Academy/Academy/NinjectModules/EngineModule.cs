using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Academy.Core.Contracts;
using Academy.Core.Providers;
using Academy.Core;
using Academy.Core.Factories;
using Academy.Commands.Contracts;
using Academy.Commands.Adding;
using Academy.Commands.Creating;
using Academy.Commands.Listing;

namespace Academy.NinjectModules
{
    public class EngineModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IWriter>().To<ConsoleWriter>();
            this.Bind<IReader>().To<ConsoleReader>();
            this.Bind<IParser>().To<CommandParser>();
            this.Bind<IDatabase>().To<Database>().InSingletonScope();
            this.Bind<IEngine>().To<Engine>();
            this.Bind<ICommandFactory>().To<CommandFactory>().InSingletonScope();
            this.Bind<IAcademyFactory>().To<AcademyFactory>().InSingletonScope();

            //commands

            //Creating
            this.Bind<ICommand>().To<CreateSeasonCommand>().Named("CreateSeason");
            this.Bind<ICommand>().To<CreateStudentCommand>().Named("CreateStudent");
            this.Bind<ICommand>().To<CreateTrainerCommand>().Named("CreateTrainer");
            this.Bind<ICommand>().To<CreateCourseCommand>().Named("CreateCourse");
            this.Bind<ICommand>().To<CreateCourseResultCommand>().Named("CreateCourseResult");
            this.Bind<ICommand>().To<CreateLectureCommand>().Named("CreateLecture");
            //??? this.Bind<ICommand>().To<CreateLectureResourceCommand>().Named("CreateLectureResource");

            //adding
            this.Bind<ICommand>().To<AddTrainerToSeasonCommand>().Named("AddTrainerToSeason");
            this.Bind<ICommand>().To<AddStudentToSeasonCommand>().Named("AddStudentToSeason");
            this.Bind<ICommand>().To<AddStudentToCourseCommand>().Named("AddStudentToCourse");

            //listing
            this.Bind<ICommand>().To<ListUsersCommand>().Named("ListUsers");
            this.Bind<ICommand>().To<ListUsersInSeasonCommand>().Named("ListUsersInSeason");
            this.Bind<ICommand>().To<ListCoursesInSeasonCommand>().Named("ListCoursesInSeason");

        }
    }
}
