using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace vehicleHire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LootGuys!");
            Console.WriteLine("Rent cars with ease");
            Console.WriteLine();
            VehicleFactory fact;

            Console.Write("Choose the vehicle type (sedan/taxi/bus): ");
            string vehicleType = Console.ReadLine().ToLower();
            if (vehicleType == "bus")
                fact = new busFactory();
            else
                if (vehicleType == "sedan")
                fact = new sedanFactory();
            else
                if (vehicleType == "taxi")
                fact = new taxiFactory();
            else
                return;

            Console.Write("Enter a number of days: ");
            int days = int.Parse(Console.ReadLine());

            Console.Write("Are you a member of the club: ");
            string member = Console.ReadLine().ToLower();

            Vehicle car = fact.purchaseCar(vehicleType);
            Console.WriteLine("Car created:  " + car.GetType().Name);
            Console.WriteLine($"Total Cost: {fact.calculateCost(days, member):C2}");


            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Choose a vehicle type (sedan/taxi/bus): ");
            vehicleType = Console.ReadLine().ToLower();
            if (vehicleType == "bus")
                fact = new busFactory();
            else
                if (vehicleType == "sedan")
                fact = new sedanFactory();
            else
                if (vehicleType == "taxi")
                fact = new taxiFactory();
            else
                return;
            Console.Write("Enter the number of days: ");
            days = int.Parse(Console.ReadLine());

            Console.Write("Are you a member of the club: ");
            member = Console.ReadLine().ToLower();

            car = fact.purchaseCar(vehicleType);
            Console.WriteLine("Car created:  " + car.GetType().Name);
            Console.WriteLine($"Total Cost: {fact.calculateCost(days, member):C2}");



            Console.ReadLine();
        }
    }
}
