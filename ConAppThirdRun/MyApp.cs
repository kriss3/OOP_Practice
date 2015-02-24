using System;
using System.Collections.Generic;
using ConAppThirdRun.Logic;
using ConAppThirdRun.Model;

namespace ConAppThirdRun
{
	class MyApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine("==== Tests ====");
			LogicHelper libHelper = new LogicHelper();
			
			//Frame with specific (non-Generic) manufacturer can match lenses
			//by the same manufacturer
			List<Lens> result = libHelper.GetLensesForFrameManuf("Bloggs");
			
			//Fremes with Lenes which have Thickness comaptibile with that Frame
			List<Frame> result1 = libHelper.GetFramesForFittingLenses();
			
			//With specified Lens Thicknes results of available Frames
			List<Frame> result2 = libHelper.GetFramesForLensThickness(2.5);

			Dictionary<int, IPrint> myTest = new Dictionary<int, IPrint>();

			myTest.Add(0, new SquareLens());
			
			myTest.Add(1, new RoundLens{Manuf = new Manufacturer {Name ="Bloggs", isGeneric= true}, Radiant=0.2, Thickness= 2.0, Magnification=3.0, Tint=Tint.Rose, Colour = Colours.None});
			myTest.Add(2, new RoundLens());
			
			
			IPrint value;
			//Testing what can be done with Type IPrint in context of
			// Lens type
			if(myTest.TryGetValue(1, out value))
			{
				value.Print();
			}

			Console.ReadLine();
		}
	}
}
