using System;

namespace ConAppThirdRun.Model
{
	public class Manufacturer: IPrint
	{
		//Props
		public string Name { get; set; }
		public bool isGeneric { get; set; }

		//Constructiors
		public Manufacturer(string name, bool isgeneric)
		{
			Name = name;
			isGeneric = isgeneric;
		}

		public Manufacturer() { }

		//Actions

		public string Print()
		{
			return String.Format("Then name of this Manufacturer is: {0}", Name);
		}
	}
}