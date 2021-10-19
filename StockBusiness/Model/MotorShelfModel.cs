
using System;
namespace ST.Model
{
	public class MotorShelfModel : BaseModel
	{
		private int iD;
		private string shelf;
		private string serialNumber;
		private string saleNumBer;
		private int qtySale;
		private string articleID;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string Shelf
		{
			get { return shelf; }
			set { shelf = value; }
		}
	
		public string SerialNumber
		{
			get { return serialNumber; }
			set { serialNumber = value; }
		}
	
		public string SaleNumBer
		{
			get { return saleNumBer; }
			set { saleNumBer = value; }
		}
	
		public int QtySale
		{
			get { return qtySale; }
			set { qtySale = value; }
		}
	
		public string ArticleID
		{
			get { return articleID; }
			set { articleID = value; }
		}
	
	}
}
	