using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ConAppThirdRun.Model;

namespace ConAppThirdRun.Data
{
	public class DataHelper
	{
		/// <summary>
		/// Building a List of available Lenses
		/// </summary>
		/// <returns>List of Lenses</returns>
		public List<Lens> GetListOfAllLenses()
		{
			//Checking Object Initiazlization and Manual object creation via custom contructor
			 List<Lens> myLenses = new List<Lens>()
			{
				new SquareLens { Manuf = new Manufacturer{Name = "Bloggs", isGeneric = false}, Width = 1.0, Height = 1.0, Thickness = 0.4, Magnification = 1.0, Tint = Tint.Pink, Colour = Colours.None},
				new SquareLens { Manuf = new Manufacturer{Name = "Bloggs", isGeneric = false}, Width = 1.0, Height = 0.9, Thickness = 0.4, Magnification = 1.0, Tint = Tint.Purple, Colour = Colours.None},
				new SquareLens { Manuf = new Manufacturer{Name = "Bloggs", isGeneric = false}, Width = 1.0, Height = 0.7, Thickness = 0.4, Magnification = 1.0, Tint = Tint.Rose, Colour = Colours.None},
				new SquareLens { Manuf = new Manufacturer{Name = "Bloggs", isGeneric = false}, Width = 1.0, Height = 0.66, Thickness = 0.4, Magnification = 1.0, Tint = Tint.Pink, Colour = Colours.None},
				new SquareLens { Manuf = new Manufacturer{Name = "Bloggs", isGeneric = false}, Width = 1.0, Height = 0.78, Thickness = 0.4, Magnification = 1.0, Tint = Tint.Rose, Colour = Colours.None},
				new SquareLens { Manuf = new Manufacturer{Name = "Bloggs", isGeneric = false}, Width = 0.75, Height = 12.0, Thickness = 0.4, Magnification = 1.0, Tint = Tint.Pink, Colour = Colours.None},
				new RoundLens{Manuf = new Manufacturer{Name = "Tony", isGeneric=false}, Radiant = 0.7, Thickness = 0.33, Magnification = 1.0, Tint = Tint.Purple, Colour = Colours.None },
				new RoundLens{Manuf = new Manufacturer{Name = "Tony", isGeneric=false}, Radiant = 0.7, Thickness = 0.25, Magnification = 1.5, Tint = Tint.Purple, Colour = Colours.None },
				new RoundLens{Manuf = new Manufacturer{Name = "Tony", isGeneric=false}, Radiant = 0.7, Thickness = 0.27, Magnification = 2.0, Tint = Tint.Purple, Colour = Colours.None },
				new RoundLens{Manuf = new Manufacturer{Name = "Tony", isGeneric=false}, Radiant = 0.7, Thickness = 0.56, Magnification = 2.5, Tint = Tint.Purple, Colour = Colours.None },
				new RoundLens{Manuf = new Manufacturer{Name = "Tony", isGeneric=false}, Radiant = 0.7, Thickness = 0.46, Magnification = 3.0, Tint = Tint.Purple, Colour = Colours.None },
				new OctagonalLens{Manuf =  new Manufacturer{Name = "Generic", isGeneric = true}, Side = 2.0, Thickness = 0.22, Magnification = 1.25, Tint = Tint.None, Colour = Colours.Red},
				new OctagonalLens{Manuf =  new Manufacturer{Name = "Generic", isGeneric = true}, Side = 2.0, Thickness = 0.22, Magnification = 1.25, Tint = Tint.None, Colour = Colours.Blue},
				new OctagonalLens{Manuf =  new Manufacturer{Name = "Generic", isGeneric = true}, Side = 2.0, Thickness = 0.22, Magnification = 1.25, Tint = Tint.None, Colour = Colours.Yellow},
				new OctagonalLens{Manuf =  new Manufacturer{Name = "Generic", isGeneric = true}, Side = 2.0, Thickness = 0.22, Magnification = 1.25, Tint = Tint.None, Colour = Colours.Black},
				new OctagonalLens{Manuf =  new Manufacturer{Name = "Generic", isGeneric = true}, Side = 2.0, Thickness = 0.22, Magnification = 1.25, Tint = Tint.None, Colour = Colours.Red},

				//test obj creation using custom constructor
				new SquareLens(new Manufacturer("Bloggs", false), 0.79, 13.9, 2.0, 3.0, Tint.Pink, Colours.None)

			};

			 foreach (Lens item in myLenses)
			 {
				 item.Area = item.GetArea();
			 }
			return myLenses;
		}

		/// <summary>
		/// Building List of available Glass frames
		/// </summary>
		/// <returns>List of Frame objects</returns>
		public List<Frame> GetListOfFrames()
		{
			List<Frame> myFrames = new List<Frame>() 
			{
				new Frame{Manuf = new Manufacturer{Name = "Bloggs", isGeneric = false}, Colour = Colours.Red, MaxLensThickness  = 2.5, MinLensThickness = 0.25},
				new Frame{Manuf = new Manufacturer{Name = "Global", isGeneric = false}, Colour = Colours.Blue, MaxLensThickness  = 2.5, MinLensThickness = 0.25},
				new Frame{Manuf = new Manufacturer{Name = "Generic", isGeneric = true}, Colour = Colours.Yellow, MaxLensThickness  = 2.5, MinLensThickness = 0.25},
				new Frame{Manuf = new Manufacturer{Name = "Blogs", isGeneric = false}, Colour = Colours.Black, MaxLensThickness  = 2.5, MinLensThickness = 0.25},
				new Frame{Manuf = new Manufacturer{Name = "Global", isGeneric = false}, Colour = Colours.Red, MaxLensThickness  = 2.5, MinLensThickness = 0.25},
				new Frame{Manuf = new Manufacturer{Name = "Generic", isGeneric = true}, Colour = Colours.Blue, MaxLensThickness  = 2.5, MinLensThickness = 0.25},
				new Frame{Manuf = new Manufacturer{Name = "Bloggs", isGeneric = false}, Colour = Colours.Yellow, MaxLensThickness  = 2.5, MinLensThickness = 0.25},
				new Frame{Manuf = new Manufacturer{Name = "Global", isGeneric = false}, Colour = Colours.Black, MaxLensThickness  = 2.5, MinLensThickness = 0.25},
				new Frame{Manuf = new Manufacturer{Name = "Generic", isGeneric = true}, Colour = Colours.Red, MaxLensThickness  = 2.5, MinLensThickness = 0.25}
			};
			return myFrames;
		}
	}
}
