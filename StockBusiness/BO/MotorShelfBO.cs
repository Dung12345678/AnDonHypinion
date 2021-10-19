
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class MotorShelfBO : BaseBO
	{
		private MotorShelfFacade facade = MotorShelfFacade.Instance;
		protected static MotorShelfBO instance = new MotorShelfBO();

		protected MotorShelfBO()
		{
			this.baseFacade = facade;
		}

		public static MotorShelfBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	