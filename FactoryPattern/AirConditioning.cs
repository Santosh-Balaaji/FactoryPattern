using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class AirConditioning
    {
        public IAirConditioning GetStatus(Action action)
        {
            switch (action)
            {
                case Action.Cooling : return new Cooling();
                case Action.Warming : return new Warming();
                default: throw new NotSupportedException();
            }
        }
    }
}
