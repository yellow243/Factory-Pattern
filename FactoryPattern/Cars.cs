using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Cars : IVehicle
    {
        public Cars() 
        {
        }

        public void Drive()
        {
            Console.WriteLine("Nice! We have a driving car!");
        }
    }
}
