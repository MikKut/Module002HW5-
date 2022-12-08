using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TaxiDeportProgram.Extensions;
using TaxiDeportProgram.Models.Comparers;

namespace TaxiDeportProgram.Models
{
    internal class TaxiDeport
    {
        private const int QuantityOfMacinesInDeport = 40;
        private PassengerСar[] _passengerСars;
        public TaxiDeport(PassengerСar[] cars)
        {
            if (cars == null)
            {
                throw new ArgumentNullException($"The {nameof(cars)} array is null");
            }

            if (cars.Length > 40)
            {
                throw new ArgumentOutOfRangeException("Too much cars");
            }

            _passengerСars = cars;
        }

        public PassengerСar[] PassengerСars { get => _passengerСars; }
        public bool AddCar(PassengerСar car)
        {
            if (car == null)
            {
                throw new ArgumentNullException($"The {nameof(car)} is null");
            }

            if (_passengerСars.Length > QuantityOfMacinesInDeport)
            {
                throw new ArgumentOutOfRangeException("Too much cars!");
            }

            if (_passengerСars.Contains(car, new PassengerСarEqualityComarer()))
            {
                return false;
            }

            _passengerСars.Append(car);
            return true;
        }

        public void SortByFuelConsumption()
        {
            _passengerСars = _passengerСars.GetSortedByFuelConsumption();
        }

        public PassengerСar? GetCarById(int id)
        {
            return _passengerСars.FindCarByID(id);
        }
    }
}
