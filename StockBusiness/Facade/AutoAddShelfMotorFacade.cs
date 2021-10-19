
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class AutoAddShelfMotorFacade : BaseFacade
	{
		protected static AutoAddShelfMotorFacade instance = new AutoAddShelfMotorFacade(new AutoAddShelfMotorModel());
		protected AutoAddShelfMotorFacade(AutoAddShelfMotorModel model) : base(model)
		{
		}
		public static AutoAddShelfMotorFacade Instance
		{
			get { return instance; }
		}
		protected AutoAddShelfMotorFacade():base() 
		{ 
		} 
	
	}
}
	