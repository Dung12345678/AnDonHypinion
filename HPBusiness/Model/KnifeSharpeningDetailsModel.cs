
using System;
namespace HP.Model
{
	public class KnifeSharpeningDetailsModel : BaseModel
	{
		private int iD;
		private int knifeID;
		private string knifeCode;
		private int workerID;
		private DateTime? dateSharpen;
		private string knifeCodeReal;
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
	
		public int WorkerID
		{
			get { return workerID; }
			set { workerID = value; }
		}
	
		public DateTime? DateSharpen
		{
			get { return dateSharpen; }
			set { dateSharpen = value; }
		}
	
		public string KnifeCodeReal
		{
			get { return knifeCodeReal; }
			set { knifeCodeReal = value; }
		}
	
	}
}
	