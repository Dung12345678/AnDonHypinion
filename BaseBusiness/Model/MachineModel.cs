
using System;
namespace BMS.Model
{
	public partial class MachineModel : BaseModel
	{
		public int ID {get; set;}
		
		public string MachineCode {get; set;}
		
		public int StageID {get; set;}
		
		public string StageCode {get; set;}
		
		public string MachineName {get; set;}
		
		public string Description {get; set;}
		
	}
}
	