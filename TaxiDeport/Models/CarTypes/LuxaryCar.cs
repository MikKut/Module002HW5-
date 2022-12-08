using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDeportProgram.Models.CarTypes
{
    internal class LuxaryCar : PassengerСar
    {
        private const decimal _tax = 3000;

        public LuxaryCar(string name, string description, decimal price, int id, decimal fuelConsumptionLiterPerHundredKm, decimal mileage)
            : base(name, description, price, id, fuelConsumptionLiterPerHundredKm, mileage)
        {
        }

        public override decimal Tax => _tax;
    }
}
