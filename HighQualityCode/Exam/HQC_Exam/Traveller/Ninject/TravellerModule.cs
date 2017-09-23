using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;
using Traveller.Commands.Creating;
using Traveller.Commands.Decorators;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Factories;
using Traveller.Core.Providers;
using Traveller.Core.Providers.Contracts;
using Traveller.Core.Providers.Factory;

namespace Traveller.Ninject
{
    public class TravellerModule : NinjectModule
    {
        public override void Load()
        {
            //TODO :
            //DECORATOR:

            //Commands 

            //factories
            this.Bind<ITravellerFactory>().To<TravellerFactory>().InSingletonScope();
            this.Bind<ICommandFactory>().To<CommandFactory>().InSingletonScope();

            //parser
            this.Bind<ICommandParser>().To<CommandParser>();

            //engine
            this.Bind<IEngine>().To<Engine>().InSingletonScope().Named("Engine");

            //database
            this.Bind<IDatabase>().To<Database>().InSingletonScope();

            //creating
            this.Bind<ICommand>().To<CreateAirplaneCommand>().Named("createairplane");
            this.Bind<ICommand>().To<CreateBusCommand>().Named("createbus");
            this.Bind<ICommand>().To<CreateTrainCommand>().Named("createtrain");
            this.Bind<ICommand>().To<CreateJourneyCommand>().Named("createjourney");
            this.Bind<ICommand>().To<CreateTicketCommand>().Named("createticket");

            //listing
            this.Bind<ICommand>().To<ListJourneysCommand>().Named("listjourneys");
            this.Bind<ICommand>().To<ListTicketsCommand>().Named("listtickets");
            this.Bind<ICommand>().To<ListVehiclesCommand>().Named("listvehicles");

            //decorator
            this.Bind<IEngine>().To<EngineDecorator>().Named("EngineWithStopWatch").WithConstructorArgument(this.Kernel.Get<IEngine>("Engine"));
        }
    }
}
