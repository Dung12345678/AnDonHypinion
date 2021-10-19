
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class MotorShelfFacade : BaseFacade
	{
		protected static MotorShelfFacade instance = new MotorShelfFacade(new MotorShelfModel());
		protected MotorShelfFacade(MotorShelfModel model) : base(model)
		{
		}
		public static MotorShelfFacade Instance
		{
			get { return instance; }
		}
		protected MotorShelfFacade():base() 
		{ 
		} 
	
	}
}
	