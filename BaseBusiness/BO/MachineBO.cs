
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class MachineBO : BaseBO
	{
		private MachineFacade facade = MachineFacade.Instance;
		protected static MachineBO instance = new MachineBO();

		protected MachineBO()
		{
			this.baseFacade = facade;
		}

		public static MachineBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	