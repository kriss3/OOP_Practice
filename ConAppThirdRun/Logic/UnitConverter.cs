using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConAppThirdRun.Logic
{
	/// <summary>
	/// Class to provide the means of representing different metric systems i.e.
	/// converter between inches and mm and vice-versa
	/// this is hypthetical for different markets e.g. Canada/USA
	/// </summary>
	public class UnitConverter
	{
		private const double MILLIMETERS_PER_INCH = 25.4;
		private double _millimeters;

		/// <summary>
		/// Converts milimeters to inches
		/// </summary>
		/// <param name="mm">millimeter value</param>
		/// <returns>UnitConverter with value translated to inches</returns>
		public static UnitConverter ToInches(double mm)
		{
			 return new UnitConverter { _millimeters = mm };
		}

		/// <summary>
		/// Converts inches to millimeters
		/// </summary>
		/// <param name="inch">Value to be converted to milimeters</param>
		/// <returns>UnitConverter containing value in millimeters</returns>
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
