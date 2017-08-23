using Traveller.Models.Vehicles.Enum;

namespace Traveller.Models.Vehicles.Contracts
{
    public interface IVehicle
    {
        decimal PricePerKilometer { get; }
        VehicleType Type { get; set; }
    }
}