using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Common;

namespace Dealership.Models.Users
{
    public class User : IUser
    {
        private readonly string username;
        private readonly string firstName;
        private readonly string lastName;
        private readonly string password;
        private Role role;

        public User(string username, string firstName, string lastName, string password, string role)
        {

            ValidateIsNullOrEmpty(username, "Username");
            Validator.ValidateSymbols(username, Constants.UsernamePattern, string.Format(Constants.InvalidSymbols, "Username"));
            Validator.ValidateIntRange
                (username.Length,
                Constants.MinNameLength,
                Constants.MaxNameLength,
                string.Format(Constants.StringMustBeBetweenMinAndMax, "Username", Constants.MinNameLength, Constants.MaxNameLength));
            this.username = username;

            ValidateIsNullOrEmpty(firstName, "First name");
            Validator.ValidateIntRange
                (firstName.Length,
                Constants.MinNameLength,
                Constants.MaxNameLength,
                string.Format(Constants.StringMustBeBetweenMinAndMax, "Firstname", Constants.MinNameLength, Constants.MaxNameLength));
            this.firstName = firstName;

            ValidateIsNullOrEmpty(lastName, "Last name");
            Validator.ValidateIntRange
                (lastName.Length,
                Constants.MinNameLength,
                Constants.MaxNameLength,
                string.Format(Constants.StringMustBeBetweenMinAndMax, "Lastname", Constants.MinNameLength, Constants.MaxNameLength));
            this.lastName = lastName;

            ValidateIsNullOrEmpty(password, "Password");
            Validator.ValidateSymbols(password, Constants.PasswordPattern, string.Format(Constants.InvalidSymbols, "Password"));
            Validator.ValidateIntRange
                (password.Length,
                Constants.MinPasswordLength,
                Constants.MaxPasswordLength,
                string.Format(Constants.StringMustBeBetweenMinAndMax, "Password", Constants.MinPasswordLength, Constants.MaxPasswordLength));
            this.password = password;

            Role parsedRole;
            bool isParsedRole = Enum.TryParse(role, out parsedRole);
            if (!isParsedRole)
            {
                throw new ArgumentException("Invalid role");
            }

            this.role = parsedRole;

            this.Vehicles = new List<IVehicle>();

        }

        public string Username
        {
            get
            {
                return this.username;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        }

        public Role Role
        {
            get
            {
                return this.role;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get;
        }

        public void ValidateIsNullOrEmpty(string inputString, string name)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                throw new ArgumentNullException("{0} cannot be null or empty", name);
            }
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if (this.Role == Role.Admin)
            {
                throw new ArgumentException(Constants.AdminCannotAddVehicles);
            }
            if (this.Role != Role.VIP && (this.Vehicles.Count >= 5))
            {
                throw new ArgumentException(string.Format(Constants.NotAnVipUserVehiclesAdd, "5"));
            }

            this.Vehicles.Add(vehicle);
        }

        public string PrintVehicles()
        {
            int orderNumber = 1;
            return string.Format(@"--USER {0}--
{1}", this.Username,
this.Vehicles.Count == 0 ? "--NO VEHICLES--"
: string.Join("\n", this.Vehicles.Select(x => $"{orderNumber++}. {x.ToString()}")));
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (commentToRemove.Author == this.Username && vehicleToRemoveComment.Comments.Contains(commentToRemove))
            {
                vehicleToRemoveComment.Comments.Remove(commentToRemove);
            }
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            if (this.Vehicles.Contains(vehicle))
            {
                this.Vehicles.Remove(vehicle);
            }
        }

        public override string ToString()
        {
            return string.Format(Constants.UserToString + ", Role: {3}", this.Username, this.FirstName, this.LastName, this.Role);
        }
    }
}
