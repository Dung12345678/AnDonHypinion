
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class HistoryShelfMotorFacade : BaseFacade
	{
		protected static HistoryShelfMotorFacade instance = new HistoryShelfMotorFacade(new HistoryShelfMotorModel());
		protected HistoryShelfMotorFacade(HistoryShelfMotorModel model) : base(model)
		{
		}
		public static HistoryShelfMotorFacade Instance
		{
			get { return instance; }
		}
		protected HistoryShelfMotorFacade():base() 
		{ 
		} 
	
	}
}
	