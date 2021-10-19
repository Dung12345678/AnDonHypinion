using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using HP.Business;
using HP.Model;

namespace BMS
{
	public partial class frmKnifeSharpenNew : _Forms
	{
		#region Variables
		private KnifeSharpeningDetailsModel knifeSharpeningModel = new KnifeSharpeningDetailsModel();
		public int knifeID = 0;
		DataTable dtKnifeDetailList;
		string Knife = "";
		DataTable dtGrvData = new DataTable();
		int prevRow;
		int oldHeightGrid = 0;
		#endregion
		#region Methods
		public frmKnifeSharpenNew()
		{
			InitializeComponent();
		}
		private void frmKnifeSharpen_Load(object sender, EventArgs e)
		{
			//LoadListKnifeList();
			//LoadDataToForm();
			txtWoker.Focus();
			oldHeightGrid = grdData.Height;
		}

		void LoadListKnifeList()
		{
			//Tách chuỗi lấy mã dao
			string[] Value = txtKnifeList.Text.Trim().Split(',');
			if (Value.Count() >= 3)
			{
				Knife = Value[0] + "," + Value[1] + "," + Value[2];
				//string sql = $"SELECT top 1 * FROM dbo.KnifeDetailList WHERE Status = 1 and KnifeCode=N'{Knife}'";
				//dtKnifeDetailList = TextUtilsHP.Select(sql);
				DataSet ds = TextUtilsHP.LoadDataSetFromSP("spGetKnifeWorking", new string[] { "@KnifeCode" }, new object[] { Knife });
				dtKnifeDetailList = ds.Tables[0];
				dtGrvData = ds.Tables[1];
			}
			if (dtKnifeDetailList.Rows.Count <= 0)
			{
				MessageBox.Show("Không tìm thấy mã Dao", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtKnifeList.Focus();
				txtKnifeList.SelectAll();
				return;
			}

		}

		void LoadDataToForm()
		{
			if (dtKnifeDetailList.Rows.Count > 0)
				txtKnifeList.Text = TextUtilsHP.ToString(dtKnifeDetailList.Rows[0]["KnifeCode"]);
		}

		void ClearFormData()
		{
			txtSTD.Text = "";
			txtRemainQty.Text = "";
			txtTotalNumber.Text = "";
			txtKnifeList.Text = "";
			txtCurrentSTD.Text = "";
			txtCurrentATC.Text = "";
		}

		bool ValidateForm()
		{
			if (string.IsNullOrEmpty(txtKnifeList.Text))
			{
				MessageBox.Show("Vui lòng nhập mã Dao!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (dtKnifeDetailList.Rows.Count <= 0)
			{
				MessageBox.Show("Không tìm thấy mã Dao vui lòng nhập lại!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			//DataRowView selectData = (DataRowView)txtKnifeList.GetSelectedDataRow();
			int std = TextUtilsHP.ToInt(dtKnifeDetailList.Rows[0]["STD"]);
			int atc = TextUtilsHP.ToInt(dtKnifeDetailList.Rows[0]["ATC"]);
			int currentSTD = TextUtilsHP.ToInt(dtKnifeDetailList.Rows[0]["CurrentSTD"]);
			int currentATC = TextUtilsHP.ToInt(dtKnifeDetailList.Rows[0]["CurrentATC"]);
			if (currentATC == atc)
			{
				if (MessageBox.Show("Mã dao này không thể tiếp tục sử dụng! \n Bạn có muốn hủy mã dao này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					// Huy dao
					frmKnifeDisposed frm = new frmKnifeDisposed();
					frm.knifeID = TextUtilsHP.ToInt(dtKnifeDetailList.Rows[0]["ID"]);
					frm.Worker = txtWoker.Text.Trim();
					if (frm.ShowDialog() == DialogResult.OK)
					{
						knifeSharpeningModel = new KnifeSharpeningDetailsModel();
						ClearFormData();
					}
				}
				return false;
			}
			return true;
		}

		bool SaveData()
		{
			if (ValidateForm())
			{
				try
				{
					knifeSharpeningModel.KnifeCode = txtKnifeList.Text.Trim();
					knifeSharpeningModel.KnifeID = TextUtilsHP.ToInt(dtKnifeDetailList.Rows[0]["ID"]);
					knifeSharpeningModel.KnifeCodeReal = Knife;

					TextUtilsHP.ExcuteProcedure("spKnifeAddToSharpenQueue",
									new string[] { "@knifeCode", "@knifeID", "@knifeCodeReal" },
									new object[] { knifeSharpeningModel.KnifeCode, knifeSharpeningModel.KnifeID, knifeSharpeningModel.KnifeCodeReal });
					return true;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Có lỗi trong quá trình xử lý!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
					return false;
				}
			}
			return false;
		}

		#endregion

		#region Events

		private void txbSTD_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtCurrentSTD.Text))
			{
				txtCurrentSTD.BackColor = Color.White;
			}
			else
			{
				txtCurrentSTD.BackColor = Color.FromArgb(255, 153, 255);
			}
		}
		private void txtKnifeList_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtKnifeList.Text))
			{
				txtKnifeList.BackColor = Color.White;
			}
			else
			{
				txtKnifeList.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void txbATC_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtCurrentATC.Text))
			{
				txtCurrentATC.BackColor = Color.White;
			}
			else
			{
				txtCurrentATC.BackColor = Color.FromArgb(255, 153, 255);
			}
		}
		private void frmKnifeSharpen_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (SaveData())
			{
				knifeSharpeningModel = new KnifeSharpeningDetailsModel();
				ClearFormData();
				Knife = "";
				//LoadListKnifeList();
				txtKnifeList.Focus();
			}
		}

		private void catVaThemOiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}

		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}
		#endregion
		private void cKnifeList_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			LoadListKnifeList();

			if (string.IsNullOrEmpty(txtKnifeList.Text)) return;
			if (dtKnifeDetailList.Rows.Count <= 0) return;
			txtCurrentATC.Text = TextUtilsHP.ToString(dtKnifeDetailList.Rows[0]["CurrentATC"]);
			txtCurrentSTD.Text = TextUtilsHP.ToString(dtKnifeDetailList.Rows[0]["CurrentSTD"]);
			txtSTD.Text = TextUtilsHP.ToString(dtKnifeDetailList.Rows[0]["STD"]);
			txtRemainQty.Text = TextUtilsHP.ToString(dtKnifeDetailList.Rows[0]["RemainQty"]);
			txtTotalNumber.Text = TextUtilsHP.ToString(dtKnifeDetailList.Rows[0]["TotalNumber"]);
			//Show mục kiểm tra 
			grdData.DataSource = dtGrvData;
			//Focus vào Gridview
			grvData.Focus();
			SetFocusDao(0, 2);
			//Giãn mục kiểm tra theo form
			if (grvData.RowCount > 0)
			{
				grvData.RowHeight = -1;
				int totalHeightRow = this.getSumHeightRows();
				if ((oldHeightGrid - grvData.ColumnPanelRowHeight - 30) > totalHeightRow)
				{
					grvData.RowHeight = (oldHeightGrid - grvData.ColumnPanelRowHeight - 30) / grvData.RowCount;
				}
			}
			//Hiển thị biểu đồ
			LoadDataToChart();

		}
		void LoadDataToChart()
		{
			DataSet ds = TextUtilsHP.GetListDataFromSP("spGetChartProductHistoryData", new string[] { "@knifeCode" }, new object[] { Knife.Trim() });
			DataTable data = new DataTable();
			DataTable dtRealTime = new DataTable();
			if (ds.Tables.Count == 2)
			{
				data = ds.Tables[0];
				dtRealTime = ds.Tables[1];
			}
			DataTable table = new DataTable();
			DataRow row = null;
			table.Columns.Add("CDay", typeof(string));
			table.Columns.Add("Quantity", typeof(int));

			for (int i = 0; i < data.Rows.Count; i++)
			{
				row = table.NewRow();
				row["CDay"] = TextUtilsHP.ToString(data.Rows[i]["CDay"]);
				row["Quantity"] = TextUtilsHP.ToString(data.Rows[i]["Quantity"]);
				table.Rows.Add(row);
			}
			for (int i = 0; i < dtRealTime.Rows.Count; i++)
			{
				row = table.NewRow();
				row["CDay"] = TextUtilsHP.ToString(dtRealTime.Rows[0]["CDay"]);
				row["Quantity"] = TextUtilsHP.ToString(dtRealTime.Rows[0]["Quantity"]);
				table.Rows.Add(row);
			}

			chartControl1.Series[0].DataSource = table;
			chartControl1.Series[0].ArgumentScaleType = ScaleType.Auto;
			chartControl1.Series[0].ArgumentDataMember = "CDay";
			chartControl1.Series[0].ValueScaleType = ScaleType.Numerical;
			chartControl1.Series[0].ValueDataMembers.AddRange(new string[] { "Quantity" });

		}
		/// <summary>
		/// Focus vào grid view Dao
		/// </summary>
		/// <param name="row">dòng bao nhiêu</param>
		/// <param name="column">cột bao nhiêu</param>
		void SetFocusDao(int row, int column)
		{
			grvData.FocusedRowHandle = row;
			grvData.FocusedColumn = grvData.VisibleColumns[column];
		}
		//Giãn mục kiểm tra theo form
		int getSumHeightRows()
		{
			int total = 0;
			GridViewInfo vi = grvData.GetViewInfo() as GridViewInfo;
			for (int i = 0; i < grvData.RowCount; i++)
			{
				GridRowInfo ri = vi.RowsInfo.FindRow(i);
				if (ri != null)
					total += ri.Bounds.Height;
			}
			return total;
		}
		private void txtWoker_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtWoker.Text))
			{
				txtWoker.BackColor = Color.White;
			}
			else
			{
				txtWoker.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void txtWoker_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txtKnifeList.Focus();
		}

		private void txtSTD_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtSTD.Text))
			{
				txtSTD.BackColor = Color.White;
			}
			else
			{
				txtSTD.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void txtRemainQty_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtRemainQty.Text))
			{
				txtRemainQty.BackColor = Color.White;
			}
			else
			{
				txtRemainQty.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void txtTotalNumber_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtTotalNumber.Text))
			{
				txtTotalNumber.BackColor = Color.White;
			}
			else
			{
				txtTotalNumber.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void grvData_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{
			if (e.RowHandle < 0) return;
			if (e.Column.VisibleIndex == 3)
			{
				string Rate = TextUtilsHP.ToString(grvData.GetRowCellValue(e.RowHandle, colRate));
				if (Rate.Trim().ToUpper() == "OK")
				{
					e.Appearance.BackColor = Color.Lime;
				}
				else if (Rate.Trim().ToUpper() == "NG")
				{
					e.Appearance.BackColor = Color.Red;
				}
			}	
			if (e.Column.VisibleIndex != 2) return;
			string value = TextUtils.ToString(grvData.GetRowCellValue(e.RowHandle, e.Column));
			if (string.IsNullOrWhiteSpace(value))
			{
				e.Appearance.BackColor = Color.FromArgb(255, 192, 255);
			}
		}

		private void grvData_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			string value = TextUtilsHP.ToString(grvData.GetRowCellValue(e.RowHandle, e.Column));
			int CheckValueType = TextUtilsHP.ToInt(grvData.GetRowCellValue(e.RowHandle, colCheckValueType));
			if (CheckValueType == 1) //Check số 
			{
				decimal Min = TextUtilsHP.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colMinValue));
				decimal Max = TextUtilsHP.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colMaxValue));
				if (Min <= TextUtilsHP.ToDecimal(value) && TextUtilsHP.ToDecimal(value) <= Max)
				{
					//OK
					grvData.SetRowCellValue(e.RowHandle, colRate, "OK");
				}
				else
				{
					//NG
					grvData.SetRowCellValue(e.RowHandle, colRate, "NG");
				}	
			}
			else // =2 check chữ
			{
				string StandValue = TextUtilsHP.ToString(grvData.GetRowCellValue(e.RowHandle, colPeriodValue));

			}
		}

		private void grdData_Click(object sender, EventArgs e)
		{

		}
	}
}
