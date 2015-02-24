namespace ConAppThirdRun.Model
{
	public abstract class Lens
	{
		//Props
		public Manufacturer Manuf { get; set; }
		public double Thickness { get; set; }
		public double Magnification { get; set; }
		public Colours Colour { get; set; }
		public Tint Tint  { get; set; }
		public double Area { get; set; }
		
		//Constructors
		public Lens(Manufacturer man, double th, double mag, Colours colour, Tint tint)
		{
			Manuf = man;
			Thickness = th;
			Magnification = mag;
			Colour = colour;
			Tint = tint;
		}

		public Lens() { }
		
		
		//Actions
		public abstract double GetArea();
	}
}
