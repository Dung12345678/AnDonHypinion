
using System;
using System.Collections;
using IE.Facade;
using IE.Model;
namespace IE.Business
{
	
	public class ProductBO : BaseBO
	{
		private ProductFacade facade = ProductFacade.Instance;
		protected static ProductBO instance = new ProductBO();

		protected ProductBO()
		{
			this.baseFacade = facade;
		}

		public static ProductBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	