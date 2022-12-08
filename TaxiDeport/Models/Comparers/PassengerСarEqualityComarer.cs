using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDeportProgram.Models.Comparers
{
    internal class PassengerСarEqualityComarer : IEqualityComparer<PassengerСar>
    {
        public bool Equals(PassengerСar? x, PassengerСar? y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException($"Can't compare {nameof(Item)}");
            }

            return (x.ID == y.ID
                && x.Tax == y.Tax
                && x.Name == y.Name
                && x.FuelConsumptionLiterPerHundredKm == y.FuelConsumptionLiterPerHundredKm
                && x.Price == y.Price);
        }

        public int GetHashCode([DisallowNull] PassengerСar obj)
        {
            return obj.GetHashCode();
        }
    }
}
