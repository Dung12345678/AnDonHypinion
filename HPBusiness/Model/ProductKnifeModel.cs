
using System;
namespace HP.Model
{
	public class ProductKnifeModel : BaseModel
	{
		private int iD;
		private string orderMachining;
		private string knifeCode;
		private string productCode;
		private DateTime? createDate;
		private string bR;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string OrderMachining
		{
			get { return orderMachining; }
			set { orderMachining = value; }
		}
	
		public string KnifeCode
		{
			get { return knifeCode; }
			set { knifeCode = value; }
		}
	
		public string ProductCode
		{
			get { return productCode; }
			set { productCode = value; }
		}
	
		public DateTime? CreateDate
		{
			get { return createDate; }
			set { createDate = value; }
		}
	
		public string BR
		{
			get { return bR; }
			set { bR = value; }
		}
	
	}
}
	