using Traveller.Core.Providers.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Traveller.Core.Contracts;
using Traveller.Core;

namespace Traveller.UnitTests.Core.Providers.CommandParserTests
{
    //Remember that only the right object returns for the methods in the class should be tested!!!
    //That is what this class is responsible for.

    [TestClass]
    public class Parse_Should
    {
        [TestMethod]
        public void SuccessfullParseCommand_WhenParametersAreCorrect()
        {
            //Arrange
            var factoryMock = new Mock<ITravellerFactory>();
            var databaseMock = new Mock<IDatabase>();

            string commandName = "createbus 10 0.7";


            //Act

            //Assert
        }

        [TestMethod]
        public void SuccessfullParseParameters_WhenParametersAreCorrect()
        {
            //Arrange
            var factoryMock = new Mock<ITravellerFactory>();
            var databaseMock = new Mock<IDatabase>();

            string commandName = "createbus 10 0.7";


            //Act

            //Assert
        }
    }
}
