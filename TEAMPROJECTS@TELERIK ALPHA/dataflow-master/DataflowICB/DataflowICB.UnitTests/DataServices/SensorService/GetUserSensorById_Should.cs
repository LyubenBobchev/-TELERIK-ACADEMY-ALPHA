﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dataflow.Services.Contracts;
using DataflowICB.Database;
using Moq;
using Dataflow.DataServices.Contracts;
using DataflowICB.Database.Models;
using System.Collections.Generic;
using System.Data.Entity;
using DataflowICB.App_Start.Contracts;

namespace DataflowICB.UnitTests.DataServices.SensorService
{
    [TestClass]
    public class GetUserSensorById_Should
    {
        [TestMethod]
        public void CallSensorsOnceAndReturnSensorWithId_WhenSensorIsExistent()
        {
            //Arrange
            var dbContextMock = new Mock<ApplicationDbContext>();
            var httpClientMock = new Mock<IHttpClientProvider>();
            var emailServiceMock = new Mock<IEmailService>();
            var sensorMock = new Mock<ISensorDataModel>();
            int Id = 2;
            sensorMock.Setup(x => x.Id).Returns(Id);

            var userMock = new Mock<ApplicationUser>();

            var termometer = new ValueTypeSensor()
            {
                MinValue = 15,
                Maxvalue = 30,
                CurrentValue = 20,
                MeasurementType = "Temperatura"
            };

            var door = new BoolTypeSensor()
            {
                CurrentValue = true,
                MeasurementType = "Open/Close"
            };

            List<Sensor> sensors = new List<Sensor>()
            {
                new Sensor()
                {
                    Id = Id,
                    Name = "termometur",
                    IsBoolType = false,
                    URL = "theGreatUrl",
                    PollingInterval = 20,
                    ValueTypeSensor = termometer,
                    IsPublic = true,
                    IsShared = false,
                    OwnerId = "stringId",
                    Owner = userMock.Object,
                    IsDeleted = false
                },

                new Sensor()
                {
                    Id = 7,
                    Name = "Door",
                    IsBoolType = true,
                    URL = "theGreatUrlPart2",
                    PollingInterval = 25,
                    BoolTypeSensor = door,
                    IsPublic = false,
                    IsShared = false,
                    OwnerId = "stringId",
                    Owner = userMock.Object,
                    IsDeleted = false
                },
            };

            var sensorsSetMock = new Mock<DbSet<Sensor>>().SetupData(sensors);

            dbContextMock.SetupGet(m => m.Sensors).Returns(sensorsSetMock.Object);

            var sensorServices = new Dataflow.DataServices.SensorService(dbContextMock.Object, httpClientMock.Object, emailServiceMock.Object);

            //Act
            var resultSensor = sensorServices.GetUserSensorById(Id);

            //Assert
            Assert.AreEqual(Id, resultSensor.Id);
            dbContextMock.Verify(d => d.Sensors, Times.Once());
        }
    }
}
