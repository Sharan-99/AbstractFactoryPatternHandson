using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileManufacturer
{
    internal class AudiFactory : Factory 
    {
        public override Headlight MakeHeadlight()
        {
            return new AudiHeadlight();
        }

        public override Tire MakeTire()
        {
            return new AudiTire();
        }
    }
}
