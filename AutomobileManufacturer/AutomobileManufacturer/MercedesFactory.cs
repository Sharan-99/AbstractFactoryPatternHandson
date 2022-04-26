using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManufacturer
{
    internal class MercedesFactory : Factory
    {
        public override Headlight MakeHeadlight()
        {
            return new MercedesHeadlight();
        }

        public override Tire MakeTire()
        {
            return new MercedesTire();
        }
    }
}
