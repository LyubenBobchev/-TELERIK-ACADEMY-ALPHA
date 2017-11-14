using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using Movie_DB.Data;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Commands.Creating;
using Movie_DB.Core.Providers;
using Models.Framework;

namespace Movie_DB.UnitTests
{
    [TestClass]
    public class Execute_Should
    {
        [TestMethod]
        public void CreatePersonAndAddItToDatabase_WhenParametersAreCorrect()
        {

            // Arrange
            var contextMock = new Mock<IMovieDbContext>();
            var personMock = new Mock<Person>();
            var factoryMock = new Mock<IMovieFactory>();
            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();



            //    List<string> parameters = new List<string>()
            //    {
            //        "1",
            //        "100"
            //    };

            //    databaseMock.SetupGet(m => m.Journeys).Returns(journeys);
            //    databaseMock.SetupGet(m => m.Tickets).Returns(tickets);
            //    factoryMock.Setup(m => m.CreateTicket(secondJourneyMock.Object, 100)).Returns(ticketMock.Object);

            //    var command = new CreateTicketCommand(databaseMock.Object, factoryMock.Object);

            //    // Act
            //    command.Execute(parameters);

            //    // Assert
            //    Assert.AreEqual(1, databaseMock.Object.Tickets.Count);
            //    Assert.AreEqual(ticketMock.Object, databaseMock.Object.Tickets.Single());
            //}

            //[TestMethod]
            //public void ReturnCorrectText_WhenParametersAreCorrect()
            //{
            //    // Arrange
            //    var databaseMock = new Mock<IDatabase>();
            //    var factoryMock = new Mock<ITravellerFactory>();
            //    var firstJourneyMock = new Mock<IJourney>();
            //    var secondJourneyMock = new Mock<IJourney>();
            //    var firstTicketMock = new Mock<ITicket>();
            //    var secondTicketMock = new Mock<ITicket>();

            //    List<ITicket> tickets = new List<ITicket>()
            //    {
            //        firstTicketMock.Object
            //    };
            //    List<IJourney> journeys = new List<IJourney>()
            //    {
            //        firstJourneyMock.Object,
            //        secondJourneyMock.Object
            //    };

            //    List<string> parameters = new List<string>()
            //    {
            //        "1",
            //        "100"
            //    };

            //    string expectedResult = "Ticket with ID 1 was created.";

            //    databaseMock.SetupGet(m => m.Journeys).Returns(journeys);
            //    databaseMock.SetupGet(m => m.Tickets).Returns(tickets);
            //    factoryMock.Setup(m => m.CreateTicket(secondJourneyMock.Object, 100)).Returns(secondTicketMock.Object);

            //    var command = new CreateTicketCommand(databaseMock.Object, factoryMock.Object);

            //    // Act
            //    var result = command.Execute(parameters);

            //    // Assert
            //    Assert.AreEqual(expectedResult, result);
            //}

            //[TestMethod]
            //[DataRow("0", "invalid costs")]
            //[DataRow("invalid id", "100")]
            //[DataRow("1", "100")]
            //public void ThrowExeption_WhenParametersAreNotCorrect(string journeyId, string administrativeCosts)
            //{
            //    // Arrange
            //    var databaseMock = new Mock<IDatabase>();
            //    var factoryMock = new Mock<ITravellerFactory>();
            //    var firstJourneyMock = new Mock<IJourney>();

            //    List<ITicket> tickets = new List<ITicket>();
            //    List<IJourney> journeys = new List<IJourney>()
            //    {
            //        firstJourneyMock.Object
            //    };

            //    List<string> parameters = new List<string>()
            //    {
            //        journeyId,
            //        administrativeCosts
            //    };

            //    databaseMock.SetupGet(m => m.Journeys).Returns(journeys);
            //    databaseMock.SetupGet(m => m.Tickets).Returns(tickets);

            //    var command = new CreateTicketCommand(databaseMock.Object, factoryMock.Object);

            //    // Act & Assert
            //    Assert.ThrowsException<ArgumentException>(() => command.Execute(parameters));
            //}
        }

    }
}
