using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}
        public bool SideCart { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine($"Default Stubbed: This motercycle is in Abstract Drive -motercycle default-"); ;
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"Virtual override: This motorcycle is in virtual drive ");

        }
    }
}

