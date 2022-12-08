using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDeportProgram.Models
{
    internal abstract class PassengerСar : Сar
    {
        private decimal _mileage;

        protected PassengerСar(string name, string description, decimal price, int id, decimal fuelConsumptionLiterPerHundredKm, decimal mileage)
            : base(name, description, price, id, fuelConsumptionLiterPerHundredKm)
        {
            Mileage = mileage;
        }

        public decimal Mileage
        {
            get => _mileage;
            set => _mileage = (value > 0)
                ? value
                : throw new ArgumentOutOfRangeException($"{nameof(Mileage)} is lower then null");
        }
    }
}