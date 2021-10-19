
using System;
using System.Collections;
using IE.Facade;
using IE.Model;
namespace IE.Business
{
	
	public class ShelfBO : BaseBO
	{
		private ShelfFacade facade = ShelfFacade.Instance;
		protected static ShelfBO instance = new ShelfBO();

		protected ShelfBO()
		{
			this.baseFacade = facade;
		}

		public static ShelfBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	