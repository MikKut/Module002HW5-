namespace TaxiDeportProgram.Models
{
    internal abstract class Сar : Machine
    {
        private decimal _fuelConsumptionLiterPerHundredKm;
        public Сar(string name, string description, decimal price, int id, decimal fuelConsumptionLiterPerHundredKm)
            : base(name, description, id, price)
        {
            FuelConsumptionLiterPerHundredKm = fuelConsumptionLiterPerHundredKm;
        }

        public decimal FuelConsumptionLiterPerHundredKm
        {
            get => _fuelConsumptionLiterPerHundredKm;
            private set => _fuelConsumptionLiterPerHundredKm = (value <= 0)
                ? throw new ArgumentOutOfRangeException($"{nameof(FuelConsumptionLiterPerHundredKm)} is wrong")
                : value;
        }

        public abstract decimal Tax { get; }
    }
}
