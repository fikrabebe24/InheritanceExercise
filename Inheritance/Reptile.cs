using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}

		public int NumberOfLegs { get; set; }

		public string AquaticTerrestrialOrBoth { get; set; }

		public bool LaysEggs { get; set; }

		public bool IsHerbivore { get; set; }

		
	}
}

