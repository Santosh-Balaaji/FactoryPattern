using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Cooling : IAirConditioning
    {
        public void Operate()
        {
            Console.WriteLine("Started Cooling");
        }
    }
}
