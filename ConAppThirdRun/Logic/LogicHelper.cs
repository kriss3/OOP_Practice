using System.Collections.Generic;
using System.Linq;

using ConAppThirdRun.Data;
using ConAppThirdRun.Model;

namespace ConAppThirdRun.Logic
{
	public class LogicHelper
	{
		DataHelper dh = new DataHelper();

		/// <summary>
		/// Frames 
		/// </summary>
		/// <param name="manufacturer"></param>
		/// <returns></returns>
		public List<Lens> GetLensesForFrameManuf(string manufacturer)
		{
			List<Lens> result = new List<Lens>();
			var allLenses = dh.GetListOfAllLenses();

			var temp =(from rec in allLenses
						where rec.Manuf.Name == manufacturer && rec.Manuf.isGeneric == false
						select rec).ToList();

			foreach (var item in temp)
			{
				result.Add(item);
			}
			return result;
		}

		/// <summary>
		/// Based on both lists: List<Lens> and List<Frames> searching for  
		/// Framses where Lenes and its thickness can fit that Fram
		/// </summary>
		/// <returns>List of available Frames with fitting Lenses</returns>
		public List<Frame> GetFramesForFittingLenses()
		{
			List<Frame> result = new List<Frame>();
			var allLenses = dh.GetListOfAllLenses();
			var allFrames = dh.GetListOfFrames();

			var temp = (from fram in allFrames
						join len in allLenses
							on fram.Manuf.Name equals len.Manuf.Name
						where len.Thickness <= fram.MaxLensThickness
						select fram).ToList();

			foreach (var item in temp)
			{
				result.Add(item);
			}
			return result;
		}

		/// <summary>
		/// Returns a List of available Frames for required Lens thicknes
		/// </summary>
		/// <param name="lensTh">Thickness of Lens</param>
		/// <returns>List of Frames for Lens no thicker than lensTh</returns>
		public List<Frame> GetFramesForLensThickness(double lensTh)
		{
			List<Frame> result = new List<Frame>();
			var allLenses = dh.GetListOfAllLenses();
			var allFrames = dh.GetListOfFrames();

			var temp = (from fram in allFrames
						where fram.MaxLensThickness <= lensTh
						select fram).ToList();
			

			foreach (var item in temp)
			{
				result.Add(item);
			}
			return result;
 
		}
	}
}
