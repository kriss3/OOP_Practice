using System;

namespace ConAppThirdRun.Model
{
	public class RoundLens: Lens, IPrint
	{
		//Auto generated properties
		public double Radiant { get; set; }

		//Constructors => although in DataHelper I am using object initializers
		public RoundLens(Manufacturer man, double rd, double th, double mag, Tint tint, Colours colour)
			:base(man, th, mag, colour, tint)
		{ 
			Radiant = rd;
		}

		public RoundLens() { }

		//Actions
		public override double GetArea()
		{
			return Math.Round(Radiant * Math.PI, 2);
		}

		public override string ToString()
		{
			return String.Format("This Lens is type {0}", this.GetType().Name);
		}

		public string Print()
		{
			return String.Format("The area of this lens type is: {0}", Area);
		}
	}
}
