using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AirConditioning status = new AirConditioning();
            var result =status.GetStatus(Action.Cooling);
            result.Operate();
        }
    }
}
