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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmMeasuringToolLine : _Forms
	{
		#region Variables
		Color _colorEmpty;
		DataTable _dtData = new DataTable();
		int _NoIndefinitely = -9999;
		int oldHeightGrid = 0;
		int IndexCbo = 0;
		string Knife = "";
		string _PathMachine = Application.StartupPath + "/Machine.txt";
		Thread _threadDateTime;
		Thread _threadFrequencyCheck;

		DataTable dt = new DataTable();

		#endregion Variables
		public frmMeasuringToolLine()
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
			LoadCboPart();
			_colorEmpty = Color.FromArgb(255, 192, 255);
			int OldWightGrid = grdData.Width;
			oldHeightGrid = grdData.Height;
			LoadColor();
			_threadDateTime = new Thread(new ThreadStart(DateTimeMachine));
			_threadDateTime.IsBackground = true;
			_threadDateTime.Start();
			_threadFrequencyCheck = new Thread(new ThreadStart(FrequencyCheck));
			_threadFrequencyCheck.IsBackground = true;
			_threadFrequencyCheck.Start();
			txtWorker.Focus();

		}
		void LoadCboPart()
		{
			DataTable dt = TextUtilsHP.Select("SELECT * FROM [HypoidPinion].[dbo].[Part] ");
			cbPart.DataSource = dt;
			cbPart.DisplayMember = "PartCode";
			cbPart.ValueMember = "ID";
		}
		void FrequencyCheck()
		{
			while (true)
			{
				Thread.Sleep(1000);
				try
				{
					if (txtJigCode.Text.Trim() == "") continue;
					if (dt.Rows.Count <= 0) continue;
					//Lấy ra ngày nhập gần nhất 
					string date = TextUtilsHP.ToString(TextUtilsHP.ExcuteScalar($"SELECT top 1 CreateDate FROM[HypoidPinion].[dbo].[CheckHistory] WHERE OrderCode = '' AND KnifeDetailCodeReal = '{Knife}' Order By ID Desc"));
					if (date.Trim() == "")
					{
						date = TextUtils.ToString(dt.Rows[1]["DateOld"]);
					}
					//Lấy ra số yêu cầu kiểm tra 0 tuần,1 ngày,2 tháng,3 năm
					int type = TextUtils.ToInt(dt.Rows[1]["TypeFrequencyCheck"]);
					double ValueFrequency = TextUtils.ToDouble(dt.Rows[1]["ValueFrequency"]);
					DateTime dateOld = TextUtilsHP.ToDate(date);
					//Cộng ngày nhập gần nhất với 
					this.Invoke((MethodInvoker)delegate
					{
						switch (type)
						{
							case 0:
								dtpFrequencyCheck.Text = TextUtilsHP.ToString(dateOld.AddDays(ValueFrequency).ToString("dd-MM-yyyy"));
								break;
							case 1:
								dtpFrequencyCheck.Text = TextUtilsHP.ToString(dateOld.AddDays(ValueFrequency).ToString("dd-MM-yyyy"));
								break;
							case 2:
								dtpFrequencyCheck.Text = TextUtilsHP.ToString(dateOld.AddMonths(TextUtilsHP.ToInt(ValueFrequency)).ToString("dd-MM-yyyy"));
								break;
							case 3:
								dtpFrequencyCheck.Text = TextUtilsHP.ToString(dateOld.AddYears(TextUtilsHP.ToInt(ValueFrequency)).ToString("dd-MM-yyyy"));
								break;
							default:
								break;
						}
					});
				}
				catch
				{
				}
			}
		}
		void DateTimeMachine()
		{
			while (true)
			{
				Thread.Sleep(1000);
				{
					try
					{
						this.Invoke((MethodInvoker)delegate
						{
							txtDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
						});
					}
					catch
					{

					}
				}
			}
		}
		void LoadColor()
		{
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
			if (string.IsNullOrWhiteSpace(txtDateTime.Text.Trim()))
			{
				txtDateTime.BackColor = _colorEmpty;
			}
			if (string.IsNullOrWhiteSpace(txtJigCode.Text.Trim()))
			{
				txtJigCode.BackColor = _colorEmpty;
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
				if (Value.Count() >= 3)
				{
					Knife = Value[0] + "," + Value[1] + "," + Value[2];
					//Load cbo theo mã jig hoặc mã dao
					dt = TextUtilsHP.Select($"SELECT kw.ID as ID, ProductStepCode,kl.Description,kl.ValueFrequency,kl.TypeFrequencyCheck,kl.DateOld FROM [HypoidPinion].[dbo].[KnifeStep] kw JOIN dbo.KnifeDetailList kl ON kw.KnifeDetailListID = kl.ID WHERE kl.KnifeCode = N'{Knife}'");

					if (dt.Rows.Count <= 0)
					{
						txtJigCode.Text = "";
						MessageBox.Show("Không tìm thấy mã xin hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					txtDescription.Text = TextUtils.ToString(dt.Rows[0]["Description"]);
					DataRow dr = dt.NewRow();
					dr["ID"] = 0;
					dr["ProductStepCode"] = "";
					dt.Rows.InsertAt(dr, 0);
					cboStep.DataSource = dt;
					cboStep.DisplayMember = "ProductStepCode";
					cboStep.ValueMember = "ID";
					//cboStep.ValueMember = "ID";
					cboStep.Focus();
					cboStep.SelectedIndex = IndexCbo;
				}
			}
		}
		/// <summary>
		/// focus xuống dòng
		/// </summary>
		/// <param name="indexRow">dòng cần focus</param>
		/// <param name="indexColum">cột cần focus</param>
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
				string value = TextUtils.ToString(grvData.GetRowCellValue(i, colReal1));
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
			int cIndex = grvData.Columns["Real1"].VisibleIndex;
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
			IndexCbo = cboStep.SelectedIndex;
			//Save bang history
			CheckHistoryModel checkHistoryModel = new CheckHistoryModel();
			checkHistoryModel.KnifeDetailListID = TextUtilsHP.ToInt(_dtData.Rows[0]["KnifeDetailListID"]);
			checkHistoryModel.CreateDate = DateTime.Now;
			checkHistoryModel.Type = 1;
			checkHistoryModel.KnifeDetailCode = txtJigCode.Text.Trim();
			checkHistoryModel.KnifeDetailCodeReal = Knife;
			checkHistoryModel.PartID = TextUtilsHP.ToInt(cbPart.SelectedValue);
			checkHistoryModel.PartCode = cbPart.Text.Trim();
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
				checkHistoryDetailModel.RealValue = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colReal1));
				checkHistoryDetailModel.RealValue1 = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colReal2));
				checkHistoryDetailModel.RealValue2 = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colReal3));
				checkHistoryDetailModel.RealValue3 = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colReal4));
				checkHistoryDetailModel.RealValue4 = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colReal5));
				checkHistoryDetailModel.SortOrder = TextUtilsHP.ToInt(grvData.GetRowCellValue(i, colSortOrder));
				checkHistoryDetailModel.Result = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colRate));
				checkHistoryDetailModel.CreateDate = DateTime.Now;
				lst.Add(checkHistoryDetailModel);
			}
			SaveCheckHistory(lst);
			txtJigCode.Text = "";
			txtDescription.Text = "";
			dtpFrequencyCheck.Text = "";
			cboStep.DataSource = null;
			grdData.DataSource = null;
			txtJigCode.Focus();

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
			string Real = TextUtils.ToString(grvData.GetFocusedRowCellValue(e.Column));
			string Rate = TextUtils.ToString(grvData.GetRowCellValue(e.RowHandle, colRate));
			string TanSuat = TextUtils.ToString(grvData.GetRowCellValue(e.RowHandle, colFrequency));
			//Tách tần suất lấy số đầu tiên
			string[] array = TanSuat.Split('/');
			int Sodautien = 0;
			if (array.Count() > 1)
			{
				Sodautien = TextUtils.ToInt(array[0]);
			}
			int check = 0; //Check =1 OK,check =2 NG
			for (int i = 1; i <= Sodautien; i++)
			{
				string Reali = TextUtils.ToString(grvData.GetFocusedRowCellValue("Real" + i));
				if (Reali.Trim() == "") continue;
				if (CheckValueType == 1)
				{
					Decimal min = TextUtils.ToDecimal(grvData.GetFocusedRowCellValue(colMinValue));
					Decimal max = TextUtils.ToDecimal(grvData.GetFocusedRowCellValue(colMaxValue));
					if (TextUtils.ToDecimal(Reali) >= min && TextUtils.ToDecimal(Reali) <= max)
					{
						check = 1;
					}
					else
					{
						check = 2;
						break;
					}
				}
				else if (CheckValueType == 2)
				{
					if (Reali.Trim().ToUpper() == StandValue.Trim().ToUpper())
					{
						check = 1;
					}
					else
					{
						check = 2;
						break;
					}
				}
			}
			//Check số min max
			if (_NoIndefinitely != e.RowHandle)
			{
				_NoIndefinitely = e.RowHandle;
				if (check == 2)
				{
					grvData.SetFocusedRowCellValue(colRate, "NG");
				}
				else if (check == 1)
				{
					grvData.SetFocusedRowCellValue(colRate, "OK");
				}
			}
			//Check số min max
			//if (_NoIndefinitely != e.RowHandle)
			//{
			//	_NoIndefinitely = e.RowHandle;

			//	if (CheckValueType == 1)
			//	{
			//		Decimal min = TextUtils.ToDecimal(grvData.GetFocusedRowCellValue(colMinValue));
			//		Decimal max = TextUtils.ToDecimal(grvData.GetFocusedRowCellValue(colMaxValue));
			//		if (TextUtils.ToDecimal(Real) >= min && TextUtils.ToDecimal(Real) <= max)
			//		{
			//			grvData.SetFocusedRowCellValue(colRate, "OK");
			//		}
			//		else
			//		{
			//			grvData.SetFocusedRowCellValue(colRate, "NG");
			//		}
			//	}
			//	else if (CheckValueType == 2)
			//	{
			//		if (Real.Trim().ToUpper() == StandValue.Trim().ToUpper())
			//		{
			//			grvData.SetFocusedRowCellValue(colRate, "OK");
			//		}
			//		else
			//		{
			//			grvData.SetFocusedRowCellValue(colRate, "NG");
			//		}
			//	}
			//}
			int cIndex = grvData.Columns["Real1"].VisibleIndex;
			int column = 0;
			for (int i = 1; i <= 5; i++)
			{
				string RealValue = TextUtils.ToString(grvData.GetRowCellValue(e.RowHandle, "Real" + i));
				if (RealValue == "")
				{
					column = i;
					break;
				}
			}
			if (Sodautien < column || column == 0)
			{
				//xuống dòng
				setFocusCell(e.RowHandle + 1, 4);
			}
			else
			{
				//next sang phải focus vào cột bên cạnh
				setFocusCell(e.RowHandle, e.Column.VisibleIndex + 1);
			}

			//Focus xuống dòng dưới nếu hết thì focus vào cất dữ liệu
			//setFocusCell(getRowIndex(cIndex), cIndex);
			_NoIndefinitely = 9999;

		}
		private void grvData_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{
			if (e.RowHandle < 0) return;
			if (e.Column.VisibleIndex < 4) return;

			string value = TextUtils.ToString(grvData.GetRowCellValue(e.RowHandle, e.Column));
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
				else if (OK.Trim() == "NG")
				{
					e.Appearance.BackColor = Color.Red;
				}
			}
			if (e.Column.VisibleIndex == 9) return;
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

		private void cbPart_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtJigCode.Focus();
		}

		private void cbPart_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txtJigCode.Focus();
		}
		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSave_Click(null, null);
		}
	}
}
