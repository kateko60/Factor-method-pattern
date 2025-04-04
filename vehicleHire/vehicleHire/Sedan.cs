using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleHire
{
    class Sedan : Vehicle
    { 
        public Sedan()
        {
            id = ++id;
            this.description = "sedan";
            this.numberOSeats = 5;
            this.ratePerDay = 900;
        }
    }
}
