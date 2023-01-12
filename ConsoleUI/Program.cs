using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - DONE
             * The vehicle class shall have three string properties Year, Make, and Model - DONE
             * Set the defaults to something generic in the Vehicle class - DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - DONE
             * Provide the implementations for the abstract methods - DONE
             * Only in the Motorcycle class will you override the virtual drive method - DONE
            */

            // Create a list of Vehicle called vehicles

            var viper = new Car();
            viper.DriveAbstract();
            viper.DriveVirtual();

            Console.WriteLine();

            var harley = new Motorcycle();
            harley.year = 2023;
            harley.make = "Harley Davidson";
            harley.model = "Roadster";
            harley.DriveAbstract();
            harley.DriveVirtual();

            Vehicle wrangler = new Car();
            wrangler.year = 2023;
            wrangler.make = "Jeep";
            wrangler.model = "Wrangler";

            
            Console.WriteLine();

            Vehicle corvette = new Car();
            corvette.year = 2001;
            corvette.make = "Chevy";
            corvette.model = "Stringray";

            Console.WriteLine();

            List<Vehicle> vehicles= new List<Vehicle>();
            vehicles.Add(viper);
            vehicles.Add(wrangler);
            vehicles.Add(corvette);
            vehicles.Add(harley);


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes - DONE
             * 
             * Set the properties with object initializer syntax - DONE
             */

            /*
             * Add the 4 vehicles to the list - DONE
             * Using a foreach loop iterate over each of the properties - DONE
             */

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.year} {vehicle.make} {vehicle.model}");
            }

            // Call each of the drive methods for one car and one motorcycle - DONE

            #endregion            
            Console.ReadLine();
        }
    }
}
