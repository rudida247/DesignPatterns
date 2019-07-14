using System;

namespace State
{
    public class IAmOff : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("Cant fix it's not broken");
            return this;
        }

        public ILightState TurnOff()
        {
            Console.WriteLine("Light is already off...");
            return this;

        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Turning on the light!");
            return new IAmOn();
        }
    }
}
