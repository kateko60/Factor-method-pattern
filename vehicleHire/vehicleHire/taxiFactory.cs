using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleHire
{
   
    class taxiFactory : VehicleFactory
    {
        public override Vehicle MakeVehicle(string carDescription)
        {
            Vehicle car = null;

            if (carDescription == "taxi")
                car = new Taxi();

            return car;
        }
        public override double calculateCost(int days, string member)
        {
            double cost;
            Vehicle car = MakeVehicle("taxi");
            cost = car.ratePerDay * days;
            if (member == "yes")
                cost -= (cost * 0.15);
            else
                return cost;
            return cost;
        }
    }
}
