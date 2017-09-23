using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Factories;

namespace Traveller.Commands.Creating
{
    public class CreateAirplaneCommand : ICommand
    {
        private readonly ITravellerFactory factory;
        private readonly IDatabase database;

        public CreateAirplaneCommand(ITravellerFactory factory, IDatabase database)
        {
            Guard.WhenArgument(factory, "factory").IsNull().Throw();
            Guard.WhenArgument(database, "database").IsNull().Throw();

            this.factory = factory;
            this.database = database;
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            bool hasFreeFood;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                hasFreeFood = bool.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateAirplane command parameters.");
            }

            var airplane = this.factory.CreateAirplane(passengerCapacity, pricePerKilometer, hasFreeFood);
            this.database.Vehicles.Add(airplane);//QUESTION??
                       
            return $"Vehicle with ID {this.database.Vehicles.Count - 1} was created.";
        }
    }
}
