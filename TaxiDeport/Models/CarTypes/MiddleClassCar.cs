using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDeportProgram.Models.CarTypes
{
    internal class MiddleClassCar : PassengerСar
    {
        private const decimal _tax = 2000;
        public MiddleClassCar(string name, string description, decimal price, int id, decimal fuelConsumptionLiterPerHundredKm, decimal mileage)
            : base(name, description, price, id, fuelConsumptionLiterPerHundredKm, mileage)
        {
        }

        public override decimal Tax => _tax;
    }
}
