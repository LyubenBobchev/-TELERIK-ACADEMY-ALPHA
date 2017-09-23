using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Traveller.Core.Providers;

namespace Traveller.UnitTests.Core.Providers.CommandParserTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void ThrowException_WhenCommandFactoryIsNull()
        {
            //Arrange
            var commandFactory = new Mock<ICommandFactory>();

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new CommandParser(null));
        }
    }
}
