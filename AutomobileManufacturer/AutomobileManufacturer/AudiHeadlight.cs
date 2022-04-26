using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManufacturer
{
    internal class AudiHeadlight : Headlight
    {
        public override void ManufacturedHeadlight()
        {
            Console.WriteLine("Audi Headlight has been manufactured...");
        }

    }
}
