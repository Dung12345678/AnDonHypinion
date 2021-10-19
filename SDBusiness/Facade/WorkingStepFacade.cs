
using System.Collections;
using SD.Model;
namespace SD.Facade
{
	
	public class WorkingStepFacade : BaseFacade
	{
		protected static WorkingStepFacade instance = new WorkingStepFacade(new WorkingStepModel());
		protected WorkingStepFacade(WorkingStepModel model) : base(model)
		{
		}
		public static WorkingStepFacade Instance
		{
			get { return instance; }
		}
		protected WorkingStepFacade():base() 
		{ 
		} 
	
	}
}
	