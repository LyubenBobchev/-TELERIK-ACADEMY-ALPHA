using System;
using System.Windows.Input;
using Traveller.Core.Contracts;
using Traveller.Commands.Contracts;
using System.Collections.Generic;

public abstract class CreateVehicleCommand : Traveller.Commands.Contracts.ICommand
{
    protected readonly ITravellerFactory factory;
    protected readonly IEngine engine;

    public CreateVehicleCommand(ITravellerFactory factory, IEngine engine)
    {
        this.factory = factory;
        this.engine = engine;
    }


    public abstract string Execute(IList<string> parameters);
   
}