namespace Traveller.Models.Vehicles.Contracts
{
    public interface IBus : IVehicle
    {
        int PassangerCapacity { get; }

        decimal PricePerKilometer { get; }
    }
}