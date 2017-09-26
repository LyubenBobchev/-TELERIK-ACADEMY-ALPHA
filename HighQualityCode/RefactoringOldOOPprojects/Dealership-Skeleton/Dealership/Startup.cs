using Dealership.Engine;
using Dealership.Models;
using Dealership.Models.Users;
using System;

namespace Dealership
{
    

    public class Startup
    {
        public static void Main()
        {
            DealershipEngine.Instance.Start();

            //User user = new User("Alab", "asdasd", "asdasd", "asdasdasd", "VIP");
            //Truck car = new Truck("BMW", "QKO", 41243, 49);
            //user.AddVehicle(car);

            //System.Console.WriteLine(user.PrintVehicles());



        }
    }
}
