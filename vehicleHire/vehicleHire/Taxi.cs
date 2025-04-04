using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleHire
{
    internal class Taxi : Vehicle
    {
        public Taxi()
        {
            id = ++id;
            this.description = "taxi";
            this.numberOSeats = 16;
            this.ratePerDay = 1500;
        }

    }
}
