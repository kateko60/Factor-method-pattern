using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleHire
{
    class Bus : Vehicle
    {
        public Bus()
        {
            id = ++id;
            this.description = "bus";
            this.numberOSeats = 80;
            this.ratePerDay = 7000;
        }
      
    }
}
