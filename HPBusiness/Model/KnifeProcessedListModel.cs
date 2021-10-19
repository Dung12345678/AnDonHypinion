
using System;
namespace HP.Model
{
	public class KnifeProcessedListModel : BaseModel
	{
		private int iD;
		private int knifeID;
		private string knifeCode;
		private string worker;
		private DateTime? dateProcess;
		private string goodsCode;
		private string machineCode;
		private int quantity;
		private string orderCode;
		private int partID;
		private string knifeCodeReal;
		private string partCode;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public int KnifeID
		{
			get { return knifeID; }
			set { knifeID = value; }
		}
	
		public string KnifeCode
		{
			get { return knifeCode; }
			set { knifeCode = value; }
		}
	
		public string Worker
		{
			get { return worker; }
			set { worker = value; }
		}
	
		public DateTime? DateProcess
		{
			get { return dateProcess; }
			set { dateProcess = value; }
		}
	
		public string GoodsCode
		{
			get { return goodsCode; }
			set { goodsCode = value; }
		}
	
		public string MachineCode
		{
			get { return machineCode; }
			set { machineCode = value; }
		}
	
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}
	
		public string OrderCode
		{
			get { return orderCode; }
			set { orderCode = value; }
		}
	
		public int PartID
		{
			get { return partID; }
			set { partID = value; }
		}
	
		public string KnifeCodeReal
		{
			get { return knifeCodeReal; }
			set { knifeCodeReal = value; }
		}
	
		public string PartCode
		{
			get { return partCode; }
			set { partCode = value; }
		}
	
	}
}
	