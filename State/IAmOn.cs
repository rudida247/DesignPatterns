using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmOn : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("Cant fix it's not broken");
            return this;
        }

        public ILightState TurnOff()
        {
            Console.WriteLine("Turning off the light....");
            return new IAmOff();
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Oh no, The light is broken");
            return new IAmBroken();
        }
    }
}
