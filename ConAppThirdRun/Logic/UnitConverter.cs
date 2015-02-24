using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppThirdRun.Logic
{
	public class UnitConverter
	{
		private const double MILLIMETERS_PER_INCH = 25.4;
		private double _millimeters;

		public static UnitConverter ToInches(double mm)
		{
			 return new UnitConverter { _millimeters = mm };
		}

		public static UnitConverter ToMillimeters(double inch)
		{
			 return new UnitConverter { _millimeters = inch * MILLIMETERS_PER_INCH };
		}

		public double Inch 
		{ 
			get 
			{ 
				return _millimeters / MILLIMETERS_PER_INCH; 
			} 
		} 
		
		public double Millimeters 
		{ 
			get 
			{ 
				return _millimeters; 
			} 
		}
	}
}
