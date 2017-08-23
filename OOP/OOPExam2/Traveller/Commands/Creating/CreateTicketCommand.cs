using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Traveller.Core.Contracts;
using Traveller.Models.Contracts;

using Traveller.Commands.Contracts;

namespace Traveller.Commands.Creating
{
    // TODO
    public class CreateTicketCommand : Contracts.ICommand
    {
    private readonly ITravellerFactory factory;
    private readonly IEngine engine;

    public CreateTicketCommand(ITravellerFactory factory, IEngine engine)
    {
        this.factory = factory;
        this.engine = engine;
    }

    public string Execute(IList<string> parameters)
    {
        int journeyID;
        decimal administartiveCosts;
        IJourney journey;

        try
        {
            journeyID = int.Parse(parameters[0]);
            administartiveCosts = decimal.Parse(parameters[1]);
            journey = this.engine.Journeys[journeyID];
        }
        catch
        {
            throw new ArgumentException("Failed to parse CreateTicket command parameters.");
        }

        var ticket = this.factory.CreateTicket(journey, administartiveCosts);
        this.engine.Tickets.Add(ticket);

        return $"Journey with ID {engine.Journeys.Count - 1} was created.";
    }
}
}
