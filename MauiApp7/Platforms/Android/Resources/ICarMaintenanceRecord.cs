namespace MauiApp7.Platforms.Android.Resources
{
    public interface ICarMaintenanceRecord
    {
        DateTime Date { get; init; }
        string Id { get; init; }
        int Mileage { get; init; }
        string Notes { get; init; }
        string ServiceType { get; init; }

        void Deconstruct(out string Id, out string ServiceType, out DateTime Date, out int Mileage, out string Notes);
        bool Equals(CarMaintenanceRecord.CarMaintenanceRecord other);
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}