namespace Traveller.Models.Vehicles.Contracts
{
    public interface IAirplane : IVehicle
    {
        int PassangerCapacity { get; }

        decimal PricePerKilometer { get; }

        bool HasFreeFood { get; }
    }
}