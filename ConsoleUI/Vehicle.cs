using System;
using System.Collections.Generic;

namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public int Year { get; set; } = 1;
		public string Make { get; set; } = "Default Make";
		public string Model { get; set; } = "Default Model";
		//* Set the defaults to something generic in the Vehicle class
		//* Vehicle shall have an abstract method called DriveAbstract with no implementation
		public abstract void DriveAbstract();
		
        //* Vehicle shall have a virtual method called DriveVirtual with a base implementation.
        //*/
		public virtual void DriveVirtual()
		{
			Console.WriteLine($"This is in virtual Drive");

		}


	}
}

