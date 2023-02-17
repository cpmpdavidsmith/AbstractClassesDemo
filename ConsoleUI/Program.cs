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
             -* Create an abstract class called Vehicle
             -* The vehicle class shall have three string properties Year, Make, and Model
             -* Set the defaults to something generic in the Vehicle class
             -* Vehicle shall have an abstract method called DriveAbstract with no implementation
             -* -Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
            - * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
            -* Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
            -* Provide the implementations for the abstract methods
            -* Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            Car Dodge = new Car() { HasTrunk = true, Make = "Dodge", Model = "Challenger", Year = 2018 };
            Motorcycle Ducati = new Motorcycle() { SideCart = false, Make = "Ducati", Model = "Monster", Year = 2020 };

            Vehicle Tesla = new Car() { HasTrunk = true, Make = "Tesla", Model = "Type X", Year = 2022 };
            Vehicle BMW = new Car() { HasTrunk = true, Make = "BMW", Model = "X4", Year = 2023 };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(Dodge);
            vehicles.Add(Ducati);
            vehicles.Add(Tesla);
            vehicles.Add(BMW);

            // Call each of the drive methods for one car and one motorcycle

            foreach (var wip in vehicles )
            {
                Console.WriteLine($"Make: {wip.Make} Model: {wip.Model} year: {wip.Year}");
                Console.WriteLine($"");
                wip.DriveVirtual();
                Console.WriteLine($"");
                Console.WriteLine($"");
            }
            #endregion            
            Console.ReadLine();
        }
    }
}
