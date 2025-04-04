using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleHire
{
    class Vehicle
    {
        public static int id { get; set; }
        public string description { get; set; }
        public int numberOSeats { get; set; }
        public double ratePerDay { get; set; }

        public virtual void addColor()
        {
            Console.WriteLine("Adding color");
        }
        public virtual void addWarranty()
        {
            Console.WriteLine("Adding warranty");
        }
        public virtual void addRate()
        {
            Console.WriteLine("Adding rate");
        }
        public virtual void addPrice()
        {
            Console.WriteLine("Calculating cost");
        }
        public virtual void configure()
        {
            Console.WriteLine("Configuring.........car successfully configured");
        }

    }
}
