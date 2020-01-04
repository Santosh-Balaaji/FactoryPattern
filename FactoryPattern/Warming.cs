using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Warming : IAirConditioning
    {
        public void Operate()
        {
            Console.WriteLine("Started Warming");
        }
    }
}
