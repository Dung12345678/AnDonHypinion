using ST.Business;
using ST.Model;
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
	public partial class frmAssemblyOrder : _Forms
	{
		public frmAssemblyOrder()
		{
			InitializeComponent();
		}
		private void frmAssemblyOrder_Load(object sender, EventArgs e)
		{
			LoadOrderPart();
		}
		int prevRow;

		#region Method

		void LoadOrderPart()
		{
			dtpFrom.Value = dtpFrom.Value.Date.AddHours(0).AddMinutes(00).AddSeconds(00);
			dtpTo.Value = dtpTo.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
			DataTable dataTable = TextUtilsStock.LoadDataFromSP(
					   "[spLoadOrderPart]"
					   , "A"
					   , new string[] { "@DateStart", "@DateEnd ", "@Text" }
					   , new object[] { dtpFrom.Value.ToString("yyyy/MM/dd HH:mm:ss")
										, dtpTo.Value.ToString("yyyy/MM/dd HH:mm:ss")
										, txbSearch.Text.Trim()
				   });
			grdData.DataSource = dataTable;
		}
		/// <summary>
		/// All form events
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnImportExcel_Click(object sender, EventArgs e)
		{
			frmImPortOrderPart frm = new frmImPortOrderPart();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadOrderPart();
			}
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			try
			{
				if (grvData.RowCount > 0)
				{
					FolderBrowserDialog od = new FolderBrowserDialog();
					if (od.ShowDialog() == DialogResult.OK)
					{
						TextUtilsStock.ExportExcel(grvData, od.SelectedPath, string.Format("DanhSachOrderPart_{0}", DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private void btnCreatePlan_Click(object sender, EventArgs e)
		{
			frmAssemblyOrderDetail frm = new frmAssemblyOrderDetail(1);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadOrderPart();
				// Tu dong focus ve dong vua tao
				//gvSonPlan.FocusedRowHandle = gvSonPlan.RowCount - 1;
			}
		}

		private void btnEditPlan_Click(object sender, EventArgs e)
		{
			if (grvData.GetSelectedRows().Length != 0)
				prevRow = grvData.GetSelectedRows()[0];
			DataRow row = grvData.GetFocusedDataRow();
			if (row != null)
			{
				int strID = TextUtilsStock.ToInt(grvData.GetFocusedRowCellValue("ID"));
				OrderPartModel model = (OrderPartModel)OrderPartBO.Instance.FindByPK(strID);
				frmAssemblyOrderDetail frm = new frmAssemblyOrderDetail(2);
				frm.OrderPartModel = model;
				if (frm.ShowDialog() == DialogResult.OK)
				{
					LoadOrderPart();
					//  Tu dong focus lai ve dong vua chon
					if (grvData.GetSelectedRows().Length != 0)
						grvData.FocusedRowHandle = prevRow;
				}
			}
		}

		private void btnDelPlan_Click(object sender, EventArgs e)
		{
			if (!grvData.IsDataRow(grvData.FocusedRowHandle))
				return;
			int strID = TextUtilsStock.ToInt(grvData.GetFocusedRowCellValue("ID"));
			string str = TextUtilsStock.ToString(grvData.GetFocusedRowCellValue("PartCode"));

			try
			{
				if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa kế hoạch [{0}] không?", str), TextUtilsStock.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					OrderPartBO.Instance.Delete(strID);
					LoadOrderPart();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hệ thống!", TextUtilsStock.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
		}

		private void gvSonPlan_DoubleClick(object sender, EventArgs e)
		{
			if (grvData.RowCount > 0 && btnEditPlan.Enabled == true)
			{
				btnEditPlan_Click(null, null);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			LoadOrderPart();
		}
		#endregion

		private void dtpFrom_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnSearch_Click(null, null);
			}
		}

		private void dtpTo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnSearch_Click(null, null);
			}
		}
	}
}
