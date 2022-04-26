using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManufacturer
{
    internal class MercedesHeadlight : Headlight
    {
        public override void ManufacturedHeadlight()
        {
            Console.WriteLine("Mercedes Headlight has been manufactured...");
        }
    }
}
