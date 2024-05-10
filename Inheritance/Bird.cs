using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{

			LaysEggs = true;
			Age = 1;
			LegCount = 2;
			LandSeaAir = "air";

		}

		public string BeakType { get; set; }
		public bool CanFly { get; set; }
		public bool doMigrate { get; set; }
		public string Color { get; set; }
	}
}

