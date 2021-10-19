using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using HP.Business;
using HP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmDaoJigLine : _Forms
	{
		#region Variables
		Color _colorEmpty;
		DataTable _dtData = new DataTable();
		int _NoIndefinitely = -9999;
		int oldHeightGrid = 0;
		string Knife = "";
		string _PathMachine = Application.StartupPath + "/Machine.txt";
		#endregion Variables
		public frmDaoJigLine()
		{
			InitializeComponent();
			if (!File.Exists(_PathMachine))
			{
				File.WriteAllText(_PathMachine, "");
			}
		}
		/// <summary>
		/// Load Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			txtMachine.Text = File.ReadAllText(Application.StartupPath + "/Machine.txt");
			LoadCboPart();
			txtWorker.Focus();
			_colorEmpty = Color.FromArgb(255, 192, 255);
			txtDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
			oldHeightGrid = grdData.Height;
			LoadColor();
		}
		void LoadCboPart()
		{
			DataTable dt = TextUtilsHP.Select("SELECT * FROM [HypoidPinion].[dbo].[Part] ");
			cbPart.DataSource = dt;
			cbPart.DisplayMember = "PartCode";
			cbPart.ValueMember = "ID";
		}
		void LoadColor()
		{
			if (string.IsNullOrWhiteSpace(txtGoods.Text.Trim()))
			{
				txtGoods.BackColor = _colorEmpty;
			}
			if (string.IsNullOrWhiteSpace(txtDateTime.Text.Trim()))
			{
				txtDateTime.BackColor = _colorEmpty;
			}
			if (string.IsNullOrWhiteSpace(txtWorker.Text.Trim()))
			{
				txtWorker.BackColor = _colorEmpty;
			}
			if (string.IsNullOrWhiteSpace(cbPart.Text.Trim()))
			{
				cbPart.BackColor = _colorEmpty;
			}
			if (string.IsNullOrWhiteSpace(txtMachine.Text.Trim()))
			{
				txtMachine.BackColor = _colorEmpty;
			}
			if (string.IsNullOrWhiteSpace(txtDateTime.Text.Trim()))
			{
				txtDateTime.BackColor = _colorEmpty;
			}
			if (string.IsNullOrWhiteSpace(txtJigCode.Text.Trim()))
			{
				txtJigCode.BackColor = _colorEmpty;
			}
			if (string.IsNullOrWhiteSpace(txtOrder.Text.Trim()))
			{
				txtOrder.BackColor = _colorEmpty;
			}
		}

		private void txt_TextChanged(object sender, EventArgs e)
		{
			//File.WriteAllText(_PathMachine, "");
			//TextBox txt = (TextBox)sender;
			//if (string.IsNullOrWhiteSpace(txt.Text.Trim()))
			//{
			//	txt.BackColor = _colorEmpty;

			//}
			//else
			//{
			//	txt.BackColor = Color.White;
			//}
		}

		private void txtJigCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (txtJigCode.Text.Trim() == "") return;

			if (e.KeyCode == Keys.Enter)
			{
				//Tách chuỗi mã dao hoặc jig
				string[] Value = txtJigCode.Text.Trim().Split(',');
				if (Value.Count() >= 4)
				{
					Knife = Value[0] + "," + Value[1] + "," + Value[2];
					//Load cbo theo mã jig hoặc mã dao
					DataTable dt = TextUtilsHP.Select($"SELECT kw.ID as ID, ProductStepCode FROM [HypoidPinion].[dbo].[KnifeStep] kw JOIN dbo.KnifeDetailList kl ON kw.KnifeDetailListID = kl.ID WHERE kl.KnifeCode = N'{Knife}'");

					DataRow dr = dt.NewRow();
					dr["ID"] = 0;
					dr["ProductStepCode"] = "";
					dt.Rows.InsertAt(dr, 0);
					cboStep.DataSource = dt;
					cboStep.DisplayMember = "ProductStepCode";
					cboStep.ValueMember = "ID";
					//cboStep.ValueMember = "ID";
					cboStep.Focus();
				}
			}
		}
		void setFocusCell(int indexRow, int indexColum)
		{
			if (indexRow <= grvData.RowCount - 1)
			{
				grvData.FocusedRowHandle = indexRow;
				grvData.FocusedColumn = grvData.VisibleColumns[indexColum];

				grvData.ShowEditor();
			}
			else
			{
				btnSave.Focus();
			}
		}
		int getRowIndex(int columnIndex)
		{
			int rowIndex = -1;
			for (int i = 0; i < _dtData.Rows.Count; i++)
			{
				DataRow r = _dtData.Rows[i];
				string value = TextUtils.ToString(grvData.GetRowCellValue(i, colReal));
				int type = TextUtils.ToInt(r["ValueType"]);
				int checkValueType = TextUtils.ToInt(r["CheckValueType"]);
				string standardValue = TextUtils.ToString(r["PeriodValue"]);
				// Nếu có giá trị thì sẽ bỏ qua 
				if ((string.IsNullOrWhiteSpace(value) && type > 0) ||
					(checkValueType == 2 && string.IsNullOrWhiteSpace(value) &&
					!string.IsNullOrWhiteSpace(standardValue)))
				{
					rowIndex = i;
					break;
				}
			}
			if (rowIndex == -1)
			{
				rowIndex = grvData.RowCount + 1;
			}
			return rowIndex;
		}
		void LoadDao()
		{
			_dtData = TextUtilsHP.GetDataTableFromSP("spLoadDao", new string[] { "@KnifeCode", "@StepCode" }, new object[] { txtJigCode.Text.Trim(), cboStep.Text.Trim() });
			grdData.DataSource = _dtData;
			if (grvData.RowCount > 0)
			{
				grvData.RowHeight = -1;
				int totalHeightRow = this.getSumHeightRows();
				if ((oldHeightGrid - grvData.ColumnPanelRowHeight - 30) > totalHeightRow)
				{
					grvData.RowHeight = (oldHeightGrid - grvData.ColumnPanelRowHeight - 30) / grvData.RowCount;
				}
			}
		}
		void LoadJig()
		{
			_dtData = TextUtilsHP.GetDataTableFromSP("spLoadJig", new string[] { "@KnifeCode", "@StepCode" }, new object[] { Knife, cboStep.Text.Trim() });
			grdData.DataSource = _dtData;
			if (grvData.RowCount > 0)
			{
				grvData.RowHeight = -1;
				int totalHeightRow = this.getSumHeightRows();
				if ((oldHeightGrid - grvData.ColumnPanelRowHeight - 30) > totalHeightRow)
				{
					grvData.RowHeight = (oldHeightGrid - grvData.ColumnPanelRowHeight - 30) / grvData.RowCount;
				}
			}
		}
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

		private void txtWorker_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				cbPart.Focus();
			}
		}

		private void txtPart_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtGoods.Focus();
			}

		}

		private void txtMachine_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtWorker.Focus();
			}

		}

		private void cboStep_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cboStep.Text.Trim()))
			{
				cboStep.BackColor = _colorEmpty;
			}
			else
			{
				cboStep.BackColor = Color.White;
			}
			//0 Load Jig , 1 Load Dao

			//if (cboStep.SelectedIndex == 0)
			//{
			//Gán giá trị vào grid view 
			LoadJig();
			//}
			//else
			//{
			//	LoadDao();
			//}
			//Focus vào dòng đầu tiên
			int cIndex = grvData.Columns["Real"].VisibleIndex;
			setFocusCell(getRowIndex(cIndex), cIndex);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (grvData.RowCount == 0)
			{
				return;
			}
			DialogResult result = MessageBox.Show("Bạn có chắc muốn cất dữ liệu?", "Cất?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No) return;
			//Save bang history
			CheckHistoryModel checkHistoryModel = new CheckHistoryModel();
			checkHistoryModel.KnifeDetailListID = TextUtilsHP.ToInt(_dtData.Rows[0]["KnifeDetailListID"]);
			checkHistoryModel.OrderCode = txtOrder.Text.Trim();
			checkHistoryModel.GoodsCode = txtGoods.Text.Trim();
			checkHistoryModel.CreateDate = DateTime.Now;
			checkHistoryModel.Type = 1;
			checkHistoryModel.KnifeDetailCode = txtJigCode.Text.Trim();
			checkHistoryModel.KnifeDetailCodeReal = Knife;

			checkHistoryModel.Machine = txtMachine.Text.Trim();
			checkHistoryModel.PartCode = cbPart.Text.Trim();
			checkHistoryModel.PartID = TextUtilsHP.ToInt(cbPart.SelectedValue);
			checkHistoryModel.StepCode = cboStep.Text.Trim();
			checkHistoryModel.WorkerCode = txtWorker.Text.Trim();
			int IDCheckHistory = TextUtils.ToInt(CheckHistoryBO.Instance.Insert(checkHistoryModel));

			List<CheckHistoryDetailModel> lst = new List<CheckHistoryDetailModel>();
			for (int i = 0; i < grvData.RowCount; i++)
			{
				CheckHistoryDetailModel checkHistoryDetailModel = new CheckHistoryDetailModel();
				checkHistoryDetailModel.CheckHistoryID = IDCheckHistory;
				checkHistoryDetailModel.WorkingName = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colProductWorkingName));
				checkHistoryDetailModel.CheckValueType = TextUtilsHP.ToInt(grvData.GetRowCellValue(i, colCheckValueType));
				//checkHistoryDetailModel.Unit= TextUtilsHP.ToString(grvData.GetRowCellValue(i, coll));
				checkHistoryDetailModel.StandardValue = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colStandardValue));
				checkHistoryDetailModel.Min = TextUtilsHP.ToDecimal(grvData.GetRowCellValue(i, colMinValue));
				checkHistoryDetailModel.Max = TextUtilsHP.ToDecimal(grvData.GetRowCellValue(i, colMaxValue));
				checkHistoryDetailModel.RealValue = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colReal));
				checkHistoryDetailModel.SortOrder = TextUtilsHP.ToInt(grvData.GetRowCellValue(i, colSortOrder));
				checkHistoryDetailModel.Result = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colRate));
				checkHistoryDetailModel.CreateDate = DateTime.Now;
				lst.Add(checkHistoryDetailModel);
			}
			SaveCheckHistory(lst);
			txtJigCode.Text = "";
			txtGoods.Text = "";
			txtOrder.Text = "";
			cboStep.DataSource = null;
			grdData.DataSource = null;
			txtGoods.Focus();
		}
		async void SaveCheckHistory(List<CheckHistoryDetailModel> lst)
		{
			Task task = Task.Factory.StartNew(() =>
			{
				foreach (CheckHistoryDetailModel item in lst)
				{
					CheckHistoryDetailBO.Instance.Insert(item);
				}

			});
			await task;
		}
		private void grvData_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			int CheckValueType = TextUtils.ToInt(grvData.GetFocusedRowCellValue(colCheckValueType));
			string StandValue = TextUtils.ToString(grvData.GetFocusedRowCellValue(colStandardValue));
			string Real = TextUtils.ToString(grvData.GetFocusedRowCellValue(colReal));
			//Check số min max
			if (_NoIndefinitely != e.RowHandle)
			{
				_NoIndefinitely = e.RowHandle;

				if (CheckValueType == 1)
				{
					Decimal min = TextUtils.ToDecimal(grvData.GetFocusedRowCellValue(colMinValue));
					Decimal max = TextUtils.ToDecimal(grvData.GetFocusedRowCellValue(colMaxValue));
					if (TextUtils.ToDecimal(Real) >= min && TextUtils.ToDecimal(Real) <= max)
					{
						grvData.SetFocusedRowCellValue(colRate, "OK");
					}
					else
					{
						grvData.SetFocusedRowCellValue(colRate, "NG");
					}
				}
				else if (CheckValueType == 2)
				{
					if (Real.Trim().ToUpper() == StandValue.Trim().ToUpper())
					{
						grvData.SetFocusedRowCellValue(colRate, "OK");
					}
					else
					{
						grvData.SetFocusedRowCellValue(colRate, "NG");
					}
				}
			}
			int cIndex = grvData.Columns["Real"].VisibleIndex;
			setFocusCell(getRowIndex(cIndex), cIndex);
			_NoIndefinitely = 9999;

		}
		void LoadRate()
		{

		}

		private void grvData_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{
			if (e.RowHandle < 0) return;
			if (e.Column.VisibleIndex < 3) return;

			string value = TextUtils.ToString(grvData.GetRowCellValue(e.RowHandle, colReal));
			if (value.Trim() == "") return;
			int checkValueType = TextUtils.ToInt(grvData.GetRowCellValue(e.RowHandle, colCheckValueType));
			string standardValue = TextUtils.ToString(grvData.GetRowCellValue(e.RowHandle, colStandardValue));
			if (e.Column == colRate)
			{
				string OK = TextUtils.ToString(grvData.GetRowCellValue(e.RowHandle, colRate));
				if (OK.Trim() == "OK")
				{
					e.Appearance.BackColor = Color.FromArgb(102, 255, 255);
				}
				else
				{
					e.Appearance.BackColor = Color.Red;

				}
			}
			if (e.Column.VisibleIndex > 3) return;
			if (checkValueType == 2 && !string.IsNullOrWhiteSpace(value.Trim()) && !string.IsNullOrWhiteSpace(standardValue.Trim()))
			{
				string[] arr = value.Split(',');
				if (arr.Length > 0)
				{
					if (arr[0].ToLower() != standardValue.ToLower())
					{
						e.Appearance.BackColor = Color.Red;
					}
					else
					{
						e.Appearance.BackColor = Color.FromArgb(102, 255, 255);
					}
				}
				else
				{
					e.Appearance.BackColor = _colorEmpty;
				}
				return;
			}
			else
			{
				decimal number = TextUtils.ToDecimal(value);
				decimal min = TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colMinValue));
				decimal max = TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colMaxValue));
				if (number < min || number > max)
				{
					e.Appearance.BackColor = Color.Red;
					e.Appearance.ForeColor = Color.FromArgb(255, 255, 0);
				}
				else
				{
					e.Appearance.BackColor = Color.FromArgb(102, 255, 255);
				}
			}

		}

		private void txtMaHang_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtOrder.Focus();
			}
		}

		private void cbPart_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtGoods.Focus();
		}

		private void txtOrder_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtJigCode.Focus();
			}
		}

		private void txtOrder_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
