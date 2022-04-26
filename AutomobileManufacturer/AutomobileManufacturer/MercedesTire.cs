using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManufacturer
{
    internal class MercedesTire : Tire
    {
        public override void ManufacturedTire()
        {
            Console.WriteLine("Merecedes Tire has been manufactured...");
        }
    }
}
