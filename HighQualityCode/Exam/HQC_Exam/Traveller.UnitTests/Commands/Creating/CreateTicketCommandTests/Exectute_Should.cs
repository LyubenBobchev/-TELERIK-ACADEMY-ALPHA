using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Traveller.Core;
using Moq;
using Traveller.Core.Contracts;
using Traveller.Commands.Creating;
using Traveller.Models.Abstractions;
using Traveller.Models;
using System.Linq;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.UnitTests.Commands.Creating.CreateTicketCommandTests
{
    [TestClass]
    public class Exectute_Should
    {
        [TestMethod]
        public void CreateTicketAndAddItToDatabase_WhenParametersAreCorrect()
        {
            //Arrange
            List<string> parameters = new List<string>()
            {
                "0",                    //journey index in journeys
                "300",                  // price
            };

          
            var journey = new Mock<IJourney>();
            var database = new Mock<IDatabase>();
            var factory = new Mock<ITravellerFactory>();
            var ticket = new Mock<ITicket>();


            //database.SetupGet(x => x.Tickets).Returns(tickets);
            

           // factory.Setup(m => m.CreateTicket();

            var command = new CreateTicketCommand(factory.Object, database.Object);

            //Act
            command.Execute(parameters);

            //Assert
            Assert.AreEqual(1, database.Object.Tickets.Count);
            Assert.AreEqual(ticket.Object, database.Object.Tickets.Single());
        }
    }
}
