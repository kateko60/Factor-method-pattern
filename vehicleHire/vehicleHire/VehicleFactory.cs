using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleHire
{
    abstract class VehicleFactory
    {
        public Vehicle purchaseCar(string carDescription)
        {
            Vehicle obj = MakeVehicle(carDescription);

            obj.addColor();
            obj.addWarranty();
            obj.addRate();
            obj.addPrice();
            obj.configure();
            

            return obj;
        }

        public abstract Vehicle MakeVehicle(string cardescription);
        public abstract double calculateCost(int days, string member);

    }
}
