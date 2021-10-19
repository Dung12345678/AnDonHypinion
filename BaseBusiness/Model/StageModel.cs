
using System;
namespace BMS.Model
{
	public partial class StageModel : BaseModel
	{
		public int ID {get; set;}
		
		public string StageCode {get; set;}
		
		public int ManagerID {get; set;}
		
		public string ManagerCode {get; set;}
		
		public int DepartmentID {get; set;}
		
		public string DepartmentCode {get; set;}
		
		public string StageName {get; set;}
		
		public string Description {get; set;}
		
	}
}
	