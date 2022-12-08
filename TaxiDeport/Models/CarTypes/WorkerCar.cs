using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDeportProgram.Models.CarTypes
{
    internal class WorkerCar : PassengerСar
    {
        private const decimal _tax = 1000;
        public WorkerCar(string name, string description, decimal price, int id, decimal fuelConsumptionLiterPerHundredKm, decimal mileage)
            : base(name, description, price, id, fuelConsumptionLiterPerHundredKm, mileage)
        {
        }

        public override decimal Tax => _tax;
    }
}
