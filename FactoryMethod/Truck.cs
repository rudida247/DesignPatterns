using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Truck : Vehicle
    {
        protected string truckUsage;

        public Truck(string model, float cylinder, string color, int numberOfWheels, string truckUsage) : base(model, cylinder, color, numberOfWheels)
        {
            this.truckUsage = truckUsage;
        }

        public override string ToString()
        {
            return "Truck " + base.ToString() + $" {truckUsage}";
        }
    }
}
