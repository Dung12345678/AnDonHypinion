
using System;
using System.Collections;
using BMS.Facade;
using BMS.Model;
namespace BMS.Business
{

	
	public class StageBO : BaseBO
	{
		private StageFacade facade = StageFacade.Instance;
		protected static StageBO instance = new StageBO();

		protected StageBO()
		{
			this.baseFacade = facade;
		}

		public static StageBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	