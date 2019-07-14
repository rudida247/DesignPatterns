using System;

namespace State
{
    public class IAmBroken : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("Congratulations! You fix the light");
            return new IAmOff();
        }

        public ILightState TurnOff()
        {
            Console.WriteLine("Cant turn off the light is broken");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Cant turn on the light is broken");
            return this;
        }
    }
}