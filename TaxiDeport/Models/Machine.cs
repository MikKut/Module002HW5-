using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDeportProgram.Models
{
    internal abstract class Machine : Item
    {
        private decimal _price;
        public Machine(string name, string description, int id, decimal price)
            : base(name, description, id)
        {
            Price = price;
        }

        public decimal Price
        {
            get => _price;
            set => _price = (value > 0)
                ? value
                : throw new ArgumentOutOfRangeException($"{nameof(Price)} is lower than null");
        }
    }
}
