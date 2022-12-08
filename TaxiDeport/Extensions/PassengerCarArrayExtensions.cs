using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDeportProgram.Models;

namespace TaxiDeportProgram.Extensions
{
    internal static class PassengerCarArrayExtensions
    {
        public static PassengerСar[] GetSortedByFuelConsumption(this PassengerСar[] passengerСars)
        {
            return passengerСars.Where(x => x != null).OrderBy(x => x.FuelConsumptionLiterPerHundredKm).ToArray();
        }

        public static PassengerСar? FindCarByID(this PassengerСar[] passengerСars, int id)
        {
            return passengerСars.FirstOrDefault(x => x.ID == id);
        }
    }
}
