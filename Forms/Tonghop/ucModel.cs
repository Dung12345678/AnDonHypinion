using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class ucModel : UserControl
	{
		public delegate void SendData(string name, object sender, EventArgs e);
		public bool IsZoom = false;
		public event SendData Datatb;
		public DataTable dtJig;
		public DataTable dtTool;
		public int size;
		public string MachineName;
		public string goodCode;
		public string Knife;
		public string STD;
		public string ATC;
		public string CurrentSTD;
		public string CurrentATC;
		public string Numberproduct;
		public DateTime dateStart;
		public DateTime dateEnd;
		public DateTimePicker dtpDate;

		Thread _threadLoadData;
		public ucModel()
		{
			InitializeComponent();
		}

		private void dtpDate_valueChanged(object sender, EventArgs e)
		{
			dateStart = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 0, 0, 0);
			dateEnd = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 23, 59, 59);
			loadData();
		}
		private void ucModel_Load(object sender, EventArgs e)
		{
			//Thread Load Data
			//_threadLoadData = new Thread(new ThreadStart(loadData));
			//_threadLoadData.IsBackground = true;
			//_threadLoadData.Start();
			loadData();
			dtpDate.ValueChanged += new EventHandler(dtpDate_valueChanged);
		}
		void loadData()
		{
			//    while(true)
			//		{
			try
			{
				lbName.Text = MachineName;
				DataSet ds = TextUtilsHP.LoadDataSetFromSP("spGetDisplayAndon", new string[] { "@Machine", "@dateStart", "@dateEnd" }, new object[] { MachineName, dateStart, dateEnd });
				if (ds.Tables[0].Rows.Count > 0)
				{
					lbGoodsCode.Text = TextUtilsHP.ToString(ds.Tables[0].Rows[0]["GoodsCode"]);
					lbSTD.Text = TextUtilsHP.ToString(ds.Tables[0].Rows[0]["STD"]);
					lbATC.Text = TextUtilsHP.ToString(ds.Tables[0].Rows[0]["ATC"]);
					lbCurrentATC.Text = TextUtilsHP.ToString(ds.Tables[0].Rows[0]["CurrentATC"]);
					lbCurrentSTD.Text = TextUtilsHP.ToString(ds.Tables[0].Rows[0]["CurrentSTD"]);
					lbKnifeCode.Text = TextUtilsHP.ToString(ds.Tables[0].Rows[0]["KnifeCode"]);

				}
				else
				{
					lbGoodsCode.Text = "";
					lbSTD.Text = "";
					lbATC.Text = "";
					lbCurrentATC.Text = "";
					lbCurrentSTD.Text = "";
					lbKnifeCode.Text = "";
				}	
				grdData.DataSource = ds.Tables[1]; // jig
				grdData1.DataSource = ds.Tables[2];//Tool
												   //Đếm
				lbNumberProduct.Text = TextUtilsHP.ToString(ds.Tables[3].Rows[0]["NumberProduct"]);
				// Thread.Sleep(200);
			}
			catch (Exception ex)
			{
			}
			//	}                
		}

		private void grvData_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
		{
			if(e.Column==colRealValue)
			{
				e.Appearance.BackColor = Color.FromArgb(0,255,255);
			}	
		}

		private void grvData1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{
			if (e.Column == colValue)
			{
				e.Appearance.BackColor = Color.FromArgb(0, 255, 255);
			}
		}
	}
}
