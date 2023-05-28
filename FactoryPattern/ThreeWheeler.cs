using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ThreeWheeler : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Hur dur I only have three wheels lol");
            Console.WriteLine("You have a working... slingshot car");
        }
    }
}
