using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Saguiy : Vehicle
    {
        protected string rentalLocation;

        public Saguiy(string model, float cylinder, string color, int numberOfWheels, string rentalLocation) : base(model, cylinder, color, numberOfWheels)
        {
            this.rentalLocation = rentalLocation;
        }

        public override string ToString()
        {
            return "Saguiy " + base.ToString() + $" {rentalLocation}";
        }
    }
}