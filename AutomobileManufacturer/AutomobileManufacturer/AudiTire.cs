using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManufacturer
{
    internal class AudiTire : Tire
    {
        public override void ManufacturedTire()
        {
            Console.WriteLine("Audi Tire has been manufactured...");
        }
    }
}
