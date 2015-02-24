using System;

namespace ConAppThirdRun.Model
{
	public class SquareLens: Lens, IPrint
	{
		//vars
		private double _height;

		//Props
		public double Width { get; set; }
		/// <summary>
		/// When setting Height of the Lens, checking is value assign or setting to the value width
		/// </summary>
		public double Height
		{
			get 
			{
				return this._height; 
			}
			set
			{
				if (value > Width)
				{
					this._height = Width;
				}
				else
				{
					this._height = value;
				}
			}
		}
		
		/// <summary>
		/// SquareLens concreate class based on Lens class
		/// </summary>
		/// <param name="man">manufacturer</param>
		/// <param name="ht">height</param>
		/// <param name="wd">width</param>
		/// <param name="th">thickness</param>
		/// <param name="mag">magnification</param>
		/// <param name="tint">tint</param>
		/// <param name="colour">colour</param>
		public SquareLens(Manufacturer man, double wd, double ht, double th, double mag, Tint tint, Colours colour)
			:base(man, th, mag, colour, tint)
		{
			Width = wd;
			Height = ht;
		}

		public SquareLens() { }

		//Actions
		public override double GetArea()
		{
			return Math.Round(Width * Height, 2);
		}

		public override string ToString()
		{
			return String.Format("This lens is type: {0}", this.GetType().Name);
		}

		//for test purpose only
		public string Print()
		{
			return String.Format("The area of this Lense type is: {0}", Area);
		}
	}
}
