
using System;
using System.Collections;
using ST.Facade;
using ST.Model;
namespace ST.Business
{

	
	public class AutoAddShelfMotorBO : BaseBO
	{
		private AutoAddShelfMotorFacade facade = AutoAddShelfMotorFacade.Instance;
		protected static AutoAddShelfMotorBO instance = new AutoAddShelfMotorBO();

		protected AutoAddShelfMotorBO()
		{
			this.baseFacade = facade;
		}

		public static AutoAddShelfMotorBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	