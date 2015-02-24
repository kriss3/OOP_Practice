using System;

namespace ConAppThirdRun.Model
{
	public class OctagonalLens: Lens, IPrint
	{	
		//Props
		public double Side { get; set; }

		//Constructors
		public OctagonalLens(Manufacturer man, double side, double th, double mag, Tint tint, Colours colour)
			:base(man, th, mag, colour, tint)
		{
			Side = side;
		}

		public OctagonalLens() { }
		
		//Actions
		public override double GetArea()
		{
			return 2 * (1 + Math.Round(Math.Sqrt(2), 2)) * Math.Pow(Side,2);
		}

		public override string ToString()
		{
			return String.Format("This lens is Type: {0}", this.GetType().Name);
		}

		public string Print()
		{
			return String.Format("The area of this Lens type is: {0}", Area);
		}
	}
}
