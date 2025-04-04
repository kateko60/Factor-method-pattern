using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleHire
{
     class sedanFactory : VehicleFactory
    {
        public override Vehicle MakeVehicle(string carDescription)
        {
            Vehicle car = null;

            if (carDescription == "sedan")
                car = new Sedan();
  
            return car;
        }
        public override double calculateCost(int days, string member)
        {
            double cost;
            Vehicle car = MakeVehicle("sedan");
            cost = car.ratePerDay * days;
            if (member == "yes")
                cost -= (cost * 0.15);
            else
                return cost;
            return cost;
        }

    }
}
