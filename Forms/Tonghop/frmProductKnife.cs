using BMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmProductKnife : _Forms
	{
		public frmProductKnife()
		{

			InitializeComponent();

		}

		ucModel UcModel;
		private void frmProductKnife_Load(object sender, EventArgs e)
		{
			loadStage();
			loadDataGrv();
		}
		DateTime dateStart;
		DateTime dateEnd;
		void convertdate()
		{
			dateStart = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 0, 0, 0);
			dateEnd = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 23, 59, 59);
		}
		void loadStage()
		{
			DataTable dt = TextUtilsHP.Select($"Select StageCode,ID From Stage ");
			cbStage.DisplayMember = "StageCode";
			cbStage.ValueMember = "ID";
			cbStage.DataSource = dt;
		}
		List<ucModel> lstUc = new List<ucModel>();
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		void loadDataGrv()
		{
			try
			{
				tableLayoutPanel2.RowStyles.RemoveAt(2);
				tableLayoutPanel2.Visible = false;
				convertdate();
				for (int i = 0; i < lstUc.Count; i++)
				{
					tableLayoutPanel2.Controls.Remove(lstUc[i]);
					//tableLayoutPanel2.RowStyles.RemoveAt(i + 2);
				}
				lstUc.Clear();
				DataTable dt = TextUtilsHP.Select($"Select m.* From Stage s inner join Machine m on s.ID=m.StageID where s.ID={cbStage.SelectedValue}");
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					string machinecode = TextUtilsHP.ToString(dt.Rows[i]["MachineCode"]);
					UcModel = new ucModel();
					UcModel.Dock = DockStyle.Fill;
					UcModel.dateStart = dateStart;
					UcModel.dateEnd = dateEnd;
					UcModel.MachineName = machinecode;
					UcModel.dtpDate = dtpDate;
					lstUc.Add(UcModel);
					tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25f));
					tableLayoutPanel2.Controls.Add(UcModel, 0, i + 2);
					tableLayoutPanel2.SetColumnSpan(UcModel, 10);
				}

				tableLayoutPanel2.Visible = true;
			}
			catch
			{
			}
			
		}
		void LoadDate()
		{
			//for (int i = 0; i < lstUc.Count; i++)
			//{
			//	lstUc[i].dateEnd = dateEnd;
			//	lstUc[i].dateEnd = dateEnd;
			//}
		}
		private async void loadUC(DataTable dt, int i)
		{
			Task task = Task.Factory.StartNew(() =>
			{
				if (this.InvokeRequired)
					tableLayoutPanel2.Invoke(new Action(() => { }));
				else tableLayoutPanel2.Controls.Add(UcModel, 0, i + 2);
				if (this.InvokeRequired)
					tableLayoutPanel2.Invoke(new Action(() => { }));
				else tableLayoutPanel2.SetColumnSpan(UcModel, 10);
			});
			await task;
		}
		private void cbStage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				loadDataGrv();
			}
		}


		private void dtpDate_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				loadDataGrv();
			}
		}

	}
}
