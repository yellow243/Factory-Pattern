using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle() 
        {
          
        }
        public void Drive()
        {
            Console.WriteLine("Nice! Our Motorcycle is revved up and ready to go baby!");
            Console.WriteLine("VROOOOOOOOOOOOOOOOOOM");
        }
    }
}
