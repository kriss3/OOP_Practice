namespace ConAppThirdRun.Model
{
	public class Frame
	{
		//Props
		public Manufacturer Manuf { get; set; }
		public Colours Colour { get; set; }
		public double MaxLensThickness { get; set; }
		public double MinLensThickness { get; set; }

		//Constructors
		public Frame(Manufacturer man, Colours colour, double maxth, double minth)
		{
			Manuf = man;
			Colour = colour;
			MaxLensThickness = maxth;
			MinLensThickness = minth;
		}

		public Frame() { }
	}
}
