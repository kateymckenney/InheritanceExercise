using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{

            LaysEggs = true;
            Age =87;
            LegCount = 4;
            LandSeaAir = "land";
        }

		public bool CanSwim { get; set; }
		public bool IsScaly { get; set; }
		public string Habitat { get; set; }
		public bool IsAGoodPet { get; set; }


	 

	}
}

