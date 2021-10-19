
using System;
namespace HP.Model
{
	public class ToolsModel : BaseModel
	{
		private int iD;
		private string code;
		private string name;
		private double std;
		private double min;
		private double max;
		private int type;
		private string nameDisplay;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string Code
		{
			get { return code; }
			set { code = value; }
		}
	
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	
		public double Std
		{
			get { return std; }
			set { std = value; }
		}
	
		public double Min
		{
			get { return min; }
			set { min = value; }
		}
	
		public double Max
		{
			get { return max; }
			set { max = value; }
		}
	
		public int Type
		{
			get { return type; }
			set { type = value; }
		}
	
		public string NameDisplay
		{
			get { return nameDisplay; }
			set { nameDisplay = value; }
		}
	
	}
}
	