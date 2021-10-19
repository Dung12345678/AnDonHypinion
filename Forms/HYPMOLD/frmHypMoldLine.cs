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
	public partial class frmHypMoldLine : _Forms
	{
		#region Variables
		int _KnifeDetailListID;
		DataTable _dt;
		DataTable _dtDisplay;
		DataTable _dtNoDisplay;
		int _stepIndex = 0;
		int _NoIndefinitely = 9999;
		string _path;
		Color _colorEmpty;
		//string Knife = "";
		CheckHistoryDetailModel _checkHistoryDetailModel;
		#endregion Variables
		public frmHypMoldLine()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Load Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmHypMoldLine_Load(object sender, EventArgs e)
		{
			loadCBPart();
			SetInterface(false);
			Setbutton(false);
			loadPath();
			_colorEmpty = Color.FromArgb(255, 192, 255);
			initBackColor();
			txtWorkerCode.Focus();
		}
		void loadCBPart()
		{
			DataTable dt = TextUtilsHP.Select("SELECT * FROM [HypoidPinion].[dbo].[Part]");
			cboBoPhan.DataSource = dt;
			cboBoPhan.DisplayMember = "PartName";
			cboBoPhan.ValueMember = "ID";
		}
		private void loadPath()
		{
			if (File.Exists(Application.StartupPath + @"\path.txt"))
			{
				_path = File.ReadAllText(Application.StartupPath + @"\path.txt");
			}
		}
		private void Setbutton(bool isEdit)
		{
			btnSave.Enabled = isEdit;
		}
		private void SetInterface(bool isEdit)
		{
			btnSave.Visible = isEdit;
		}
		/// <summary>
		/// Sự kiện KeyDown của textbox mã hàng
		/// </summary>
		private void txtMaHang_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			//Load Cbo Công đoạn
			//Load cbo theo mã jig hoặc mã dao
			//Tách chuỗi lấy mã khuôn
			//string[] Value = txtKnifeDetailCode.Text.Trim().Split(',');
			//if (Value.Count() >= 3)
			//{
			//	Knife = Value[0] + "," + Value[1] + "," + Value[2];
				DataTable dt = TextUtilsHP.Select($"SELECT DISTINCT ProductStepCode FROM [HypoidPinion].[dbo].[KnifeStep] kw JOIN dbo.KnifeDetailList kl ON kw.KnifeDetailListID = kl.ID WHERE kl.KnifeCode = N'{txtKnifeDetailCode.Text.Trim()}'");
				DataRow dr = dt.NewRow();
				dr["ProductStepCode"] = "";
				dt.Rows.InsertAt(dr, 0);
				cboCongDoan.DataSource = dt;
				cboCongDoan.DisplayMember = "ProductStepCode";
				//cboStep.ValueMember = "ID";
				cboCongDoan.Focus();
				if (_stepIndex > 0 && _stepIndex < dt.Rows.Count)
				{
					cboCongDoan.SelectedIndex = _stepIndex;
				}
			//}
		}
		private void loadAllTextBox()
		{
			try
			{
				//TODO: Xóa tất cả các textbox cũ
				deleteAllTextBox();
				//TODO: Load Bảng mục kiểm tra theo ID của tên mã hàng
				DataTable dt = TextUtilsHP.Select($"select ID from dbo.KnifeDetailList where KnifeCode = '{txtKnifeDetailCode.Text.Trim()}'");
				if (dt.Rows.Count <= 0)
				{
					MessageBox.Show("Không tìm thấy mã khuôn", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					Setbutton(false);
					return;
				}
				//TODO: Load file PDF rời mới hiển thị 
				try
				{
					string path = _path + $"\\{txtKnifeDetailCode.Text.Trim()}" + ".pdf";
					pdfViewer1.LoadDocument(path);
				}
				catch
				{
					MessageBox.Show("Không tìm thấy file PDF", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				_KnifeDetailListID = TextUtilsHP.ToInt(dt.Rows[0]["ID"]);
				//List<int> ids = new List<int>(loadDataHypMold().Rows.Count);
				//foreach (DataRow row in loadDataHypMold().Rows) ids.Add((int)row["ID"]);

				//List<int> isDisplay = new List<int>(loadDataHypMold().Rows.Count);
				//foreach (DataRow row in loadDataHypMold().Rows) isDisplay.Add((int)row["isDisplay"]);
				//Show textbox

				//TODO: Lấy bảng Hiển thị text box từ bảng tổng
				DataTable dtKnifeJigWorking = loadDataHypMold();
				if (dtKnifeJigWorking == null)
				{
					MessageBox.Show("Không tìm mục kiểm tra", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				DataRow[] dtr = dtKnifeJigWorking.Select("isDisplay = 1");
				_dtDisplay = loadDataHypMold().Clone();
				_dtDisplay.Clear();
				foreach (DataRow dr in dtr)
				{
					_dtDisplay.ImportRow(dr);
				}
				_maxTextBoxNumber = _dtDisplay.Rows.Count - 1;
				//TODO: Show textbox
				for (int i = 0; i < _dtDisplay.Rows.Count; i++)
				{
					int LocationX = TextUtilsHP.ToInt(_dtDisplay.Rows[i]["X"]);
					int LocationY = TextUtilsHP.ToInt(_dtDisplay.Rows[i]["Y"]);
					//string RealValue = TextUtilsHP.ToString(loadDataHypMold().Rows[i]["RealValue"]);
					showTextBox(LocationX, LocationY, "", i);
				}
				Setbutton(true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				Setbutton(false);
			}
		}
		private void deleteAllTextBox()
		{
			foreach (Control item in panel2.Controls.OfType<TextBox>().ToList())
			{
				panel2.Controls.Remove(item);
			}
		}
		private DataTable loadDataHypMold()
		{
			DataTable dt = TextUtilsHP.GetDataTableFromSP("spLoadJig", new string[] { "@KnifeCode", "@StepCode" }, new object[] { txtKnifeDetailCode.Text.Trim(), cboCongDoan.Text.Trim() });
			//string sql = $"Select * from dbo.KnifeJigWorking where KnifeDetailListID ={_KnifeDetailListID} order by SortOrder ";
			//DataTable dt = TextUtilsHP.Select(sql);
			//Cách lấy data từ 1 bảng khác theo điều kiện
			//TODO: Lấy bảng không hiển thị textbox từ bảng tổng
			if (dt.Rows.Count <= 0)
			{
				return null;
			}
			DataRow[] dtr = dt.Select("isDisplay = 0");
			_dtNoDisplay = dt.Clone();
			_dtNoDisplay.Clear();
			foreach (DataRow dr in dtr)
			{
				_dtNoDisplay.ImportRow(dr);
			}
			//grdData.AutoGenerateColumns = false; // Không show tất cả cột lên
			grdData.DataSource = _dtNoDisplay;
			return dt;
		}
		private void showTextBox(int X, int Y, string RealValue, int row)
		{
			//TODO: Tạo textbox
			TextBox txtRow = new TextBox();
			txtRow.Name = "txtxxx" + $"{row}";
			txtRow.Font = new Font("Calibri", 10);
			txtRow.Size = new Size(50, 10);
			txtRow.Location = new Point(X, Y);
			txtRow.Dock = DockStyle.None;
			txtRow.BackColor = Color.FromArgb(255, 192, 255);
			txtRow.ForeColor = Color.Black;
			txtRow.Enabled = true;
			txtRow.BringToFront();
			txtRow.Text = RealValue;
			panel2.Controls.Add(txtRow);
			pdfViewer1.SendToBack();
			txtRow.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
			txtRow.KeyDown += new KeyEventHandler(Textbox_KeyDown);
			txtRow.Click += new EventHandler(Textbox_Click);
		}
		void initBackColor()
		{
			if (string.IsNullOrWhiteSpace(txtOrder.Text))
			{
				txtOrder.BackColor = _colorEmpty;
			}
			else
			{
				txtOrder.BackColor = Color.White;
			}
			if (string.IsNullOrWhiteSpace(txtKnifeDetailCode.Text))
			{
				txtKnifeDetailCode.BackColor = _colorEmpty;
			}
			else
			{
				txtKnifeDetailCode.BackColor = Color.White;
			}
			if (string.IsNullOrWhiteSpace(txtWorkerCode.Text))
			{
				txtWorkerCode.BackColor = _colorEmpty;
			}
			else
			{
				txtWorkerCode.BackColor = Color.White;
			}
			if (string.IsNullOrWhiteSpace(cboCongDoan.Text))
			{
				cboCongDoan.BackColor = _colorEmpty;
			}
			else
			{
				cboCongDoan.BackColor = Color.White;
			}
			if (string.IsNullOrWhiteSpace(cboBoPhan.Text))
			{
				cboBoPhan.BackColor = _colorEmpty;
			}
			else
			{
				cboBoPhan.BackColor = Color.White;
			}
			if (string.IsNullOrWhiteSpace(txtGoodsCode.Text))
			{
				txtGoodsCode.BackColor = _colorEmpty;
			}
			else
			{
				txtGoodsCode.BackColor = Color.White;
			}
			if (string.IsNullOrWhiteSpace(txtMachine.Text))
			{
				txtMachine.BackColor = _colorEmpty;
			}
			else
			{
				txtMachine.BackColor = Color.White;
			}
		}
		private void Textbox_TextChanged(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			if (string.IsNullOrWhiteSpace(txt.Text.Trim()))
			{
				txt.BackColor = _colorEmpty;
			}
			else
			{
				txt.BackColor = Color.White;
			}
		}
		private void Textbox_Click(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			//int row = TextUtilsHP.ToInt(txt.Name.Replace("txtxxx", ""));
			txt.SelectAll();
			//grvData.CurrentCell = grvData[5, row];
		}
		int _maxTextBoxNumber;
		private void Textbox_KeyDown(object sender, KeyEventArgs e)
		{
			TextBox txt = (TextBox)sender;
			int row = TextUtilsHP.ToInt(txt.Name.Replace("txtxxx", ""));
			//Chuyển lên text box trước nó nếu không có sẽ chuyển lên grv
			if (e.KeyCode == Keys.Up)
			{

				int RowPrevious = row - 1;
				if (RowPrevious < 0)
				{
					//Focus vào gridview
					grdData.Focus();
					SetFocus(grvData.RowCount - 1, 2);
					//grvData.CurrentCell = grvData[5, grvData.RowCount - 1];

				}
				else
				{
					string nameControl = "txtxxx" + $"{row - 1}";
					Control tbox = this.Controls.Find(nameControl, true)[0];
					if (tbox != null)
					{
						(tbox as TextBox).Focus();
						(tbox as TextBox).SelectAll();
					}
				}


			}
			//Next textbox tiếp theo
			if (e.KeyCode != Keys.Enter) return;
			//TODO: Xử lý sự kiện keydown của textbox
			//TODO: So sánh giá trị 

			decimal MaxValue = TextUtilsHP.ToDecimal(_dtDisplay.Rows[row]["MaxValue"]);
			decimal MinValue = TextUtilsHP.ToDecimal(_dtDisplay.Rows[row]["MinValue"]);
			string StandartValue = TextUtilsHP.ToString(_dtDisplay.Rows[row]["PeriodValue"]);
			int CheckValueType = TextUtilsHP.ToInt(_dtDisplay.Rows[row]["CheckValueType"]);
			var value = txt.Text.Trim();
			if (CheckValueType == 2)
			{
				if (TextUtilsHP.ToString(value).ToUpper() != StandartValue.ToUpper())
				{
					txt.BackColor = Color.Red;
				}
				else
				{
					txt.BackColor = Color.Lime;
				}
			}
			else
			{
				if (TextUtilsHP.ToDecimal(value) != 0 && TextUtilsHP.ToDecimal(value) >= MinValue && TextUtilsHP.ToDecimal(value) <= MaxValue)
				{
					txt.BackColor = Color.Lime;
				}
				else
				{
					txt.BackColor = Color.Red;
				}
			}

			//TODO: Tìm textbox tiếp theo
			if (row <= _maxTextBoxNumber - 1)
			{
				string nameControl = "txtxxx" + $"{row + 1}";
				Control tbox = this.Controls.Find(nameControl, true)[0];
				if (tbox != null)
				{
					//foreach (Control item in panel2.Controls.OfType<TextBox>().ToList())
					//{
					//	if (item.Text == "")
					//	{
					//		item.BackColor = Color.White;
					//	}
					//}
					//(tbox as TextBox).ForeColor = Color.Navy;
					//(tbox as TextBox).BackColor = Color.Aqua;
					(tbox as TextBox).Focus();
					(tbox as TextBox).SelectAll();
				}
			}
			else
			{
				btnSave_Click(null, null);
			}
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc muốn cất dữ liệu?", "Cất?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No) return;
			saveAtTable();
			//loadAllTextBox();
		}
		private void saveAtTable()
		{
			try
			{
				CheckHistoryModel _checkHistory = new CheckHistoryModel();
				_checkHistory.KnifeDetailListID = _KnifeDetailListID;
				_checkHistory.OrderCode = txtOrder.Text.Trim();
				_checkHistory.CreateDate = DateTime.Now;
				_checkHistory.Type = 2;
				_checkHistory.KnifeDetailCode = txtKnifeDetailCode.Text.Trim();
				_checkHistory.KnifeDetailCodeReal = txtKnifeDetailCode.Text.Trim();
				_checkHistory.GoodsCode = txtGoodsCode.Text.Trim();
				_checkHistory.Machine = txtMachine.Text.Trim();
				_checkHistory.StepCode = cboCongDoan.Text.Trim();
				_checkHistory.PartID = TextUtilsHP.ToInt(cboBoPhan.SelectedValue);
				_checkHistory.PartCode = cboBoPhan.Text.Trim();
				_checkHistory.WorkerCode = txtWorkerCode.Text.Trim();
				_checkHistory.ID = TextUtilsHP.ToInt(CheckHistoryBO.Instance.Insert(_checkHistory));
				List<CheckHistoryDetailModel> lst = new List<CheckHistoryDetailModel>();
				// Save CheckHistoryDetail
				for (int i = 0; i < grvData.RowCount; i++)
				{
					_checkHistoryDetailModel = new CheckHistoryDetailModel();
					_checkHistoryDetailModel.CheckHistoryID = _checkHistory.ID;
					_checkHistoryDetailModel.WorkingName = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colWorkingName));
					_checkHistoryDetailModel.CheckValueType = TextUtilsHP.ToInt(grvData.GetRowCellValue(i, colCheckValueType));
					_checkHistoryDetailModel.Unit = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colUnit));
					_checkHistoryDetailModel.StandardValue = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colPeriodValue));
					_checkHistoryDetailModel.RealValue = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colRealvalue));
					_checkHistoryDetailModel.SortOrder = TextUtilsHP.ToInt(grvData.GetRowCellValue(i, colSortOrder));
					_checkHistoryDetailModel.Result = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colEvaluate));
					_checkHistoryDetailModel.CreateDate = DateTime.Now;
					lst.Add(_checkHistoryDetailModel);

				}
				//TODO: Save at Textbox
				foreach (Control item in panel2.Controls.OfType<TextBox>().ToList())
				{
					_checkHistoryDetailModel = new CheckHistoryDetailModel();
					int row = TextUtilsHP.ToInt(item.Name.Replace("txtxxx", ""));
					string Result;
					if (item.BackColor == Color.Red)
					{
						Result = "NG";
					}
					else if (item.BackColor == Color.Lime)
					{
						Result = "OK";
					}
					else
					{
						Result = null;
					}
					_checkHistoryDetailModel.CheckHistoryID = _checkHistory.ID;
					_checkHistoryDetailModel.WorkingName = TextUtilsHP.ToString(_dtDisplay.Rows[row]["WorkingName"]);
					_checkHistoryDetailModel.CheckValueType = TextUtilsHP.ToInt(_dtDisplay.Rows[row]["CheckValueType"]);
					_checkHistoryDetailModel.Unit = TextUtilsHP.ToString(_dtDisplay.Rows[row]["Unit"]);
					_checkHistoryDetailModel.StandardValue = TextUtilsHP.ToString(_dtDisplay.Rows[row]["PeriodValue"]);
					_checkHistoryDetailModel.RealValue = TextUtilsHP.ToString(item.Text.Trim());
					_checkHistoryDetailModel.SortOrder = TextUtilsHP.ToInt(_dtDisplay.Rows[row]["SortOrder"]);
					_checkHistoryDetailModel.Result = Result;
					_checkHistoryDetailModel.X = TextUtilsHP.ToInt(_dtDisplay.Rows[row]["X"]);
					_checkHistoryDetailModel.Y = TextUtilsHP.ToInt(_dtDisplay.Rows[row]["Y"]);
					_checkHistoryDetailModel.IsDisplay = 1;
					_checkHistoryDetailModel.CreateDate = DateTime.Now;
					lst.Add(_checkHistoryDetailModel);
				}
				Save(lst);
				_stepIndex = cboCongDoan.SelectedIndex;
				grdData.DataSource = null;
				txtOrder.Text = "";
				txtKnifeDetailCode.Text = "";
				cboCongDoan.Text = "";
				txtGoodsCode.Text = "";
				//Xóa các file text 
				deleteAllTextBox();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		async void Save(List<CheckHistoryDetailModel> checkHistoryDetailModel)
		{
			Task task = Task.Factory.StartNew(() =>
			{
				foreach (CheckHistoryDetailModel item in checkHistoryDetailModel)
				{
					CheckHistoryDetailBO.Instance.Insert(item);
				}
			});
			await task;

		}

		private void btnPath_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dlg = new FolderBrowserDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				string path = dlg.SelectedPath;
				string fileSavePath = Application.StartupPath + @"\path.txt";
				if (File.Exists(fileSavePath) == false)
				{
					File.Create(fileSavePath);
				}
				this.Invoke((MethodInvoker)delegate
				{
					File.WriteAllText(fileSavePath, path);
				});

				loadPath();
			}
		}
		private void grvKnifeJigWorking_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			grvData.Focus();
		}
		int _nextrow;

		private void txtWorkerCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				cboBoPhan.Focus();
			}
		}

		private void cboCongDoan_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboCongDoan.SelectedIndex == 0) return;
			if (cboCongDoan.SelectedIndex != 0)
			{
				txtMachine.BackColor = Color.White;
			}
			_NoIndefinitely = 9999;
			loadAllTextBox();
			grvKnifeJigWorking_CellClick(null, null);
			//if (grvData.Rows.Count > 0)
			//{
			//	grvData.CurrentCell = grvData[5, 0];
			//}
			SetInterface(true);
			if (grvData.RowCount <= 0) return;
			//focus vào dòng đầu tiên của cột thứ 2
			grvData.Focus();
			SetFocus(0, 2);


		}
		void SetFocus(int row, int column)
		{
			grvData.FocusedRowHandle = row;
			grvData.FocusedColumn = grvData.VisibleColumns[column];
		}

		private void txtBoPhan_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtOrder.Focus();
			}
		}

		private void txtOrder_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtGoodsCode.Focus();
			}
		}

		private void grvData_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			int selectedrowindex = 0;
			//	if (grvData.Rows.Count > 0)
			//	{
			//		selectedrowindex = grvData.SelectedCells[0].RowIndex;
			//	}
			//	else
			//	{
			//		string nameControl = "txtxxx0";
			//		Control tbox = this.Controls.Find(nameControl, true)[0];
			//		if (tbox != null)
			//		{
			//			//(tbox as TextBox).ForeColor = Color.Navy;
			//			//(tbox as TextBox).BackColor = Color.Aqua;
			//			(tbox as TextBox).Focus();
			//			(tbox as TextBox).SelectAll();
			//		}
			//	}

			//TODO: So sánh điều kiện của grid
			try
			{
				//setFocusCell();
				if (grvData.RowCount <= 0) return;
				decimal MaxValue = TextUtilsHP.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colMaxValue));
				decimal MinValue = TextUtilsHP.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colMinValue));
				//string StandartValue = TextUtilsHP.ToString(grvData.Rows[e.RowIndex].Cells["colPeriodValue"].Value);
				string StandartValue = TextUtilsHP.ToString(grvData.GetRowCellValue(e.RowHandle, colPeriodValue));
				int CheckValueType = TextUtilsHP.ToInt(grvData.GetRowCellValue(e.RowHandle, colCheckValueType));
				int ID = TextUtilsHP.ToInt(grvData.GetRowCellValue(e.RowHandle, colID));
				var value = grvData.GetRowCellValue(e.RowHandle, colRealvalue);
				string Evaluate = "";
				//CheckValueType=2 string , = 1 dạng số
				if (CheckValueType == 2)
				{
					if (TextUtilsHP.ToString(value).Trim().ToUpper() != StandartValue.Trim().ToUpper())
					{
						Evaluate = "NG";
					}
					else
					{
						Evaluate = "OK";
					}
				}
				else
				{
					if (TextUtilsHP.ToDecimal(value) != 0 && TextUtilsHP.ToDecimal(value) >= MinValue && TextUtilsHP.ToDecimal(value) <= MaxValue)
					{
						Evaluate = "OK";
					}
					else
					{
						Evaluate = "NG";
					}
				}
				if (e.Column == colRealvalue)
				{
					grvData.SetRowCellValue(e.RowHandle, colEvaluate, Evaluate);
				}
				SetFocus(e.RowHandle + 1, 2);
			}
			catch (Exception)
			{

			}
			//TODO: Điều kiện focus vào textbox

			if (_dtNoDisplay.Rows.Count == grvData.RowCount)
			{
				selectedrowindex = e.RowHandle;
				if (selectedrowindex < grvData.RowCount - 1)
				{
					_nextrow = selectedrowindex;
				}
				else
				{
					_nextrow = selectedrowindex + 1;
				}
				if (_nextrow >= grvData.RowCount)
				{
					string nameControl = "txtxxx0";
					Control[] controls = this.Controls.Find(nameControl, true);
					if (controls.Count() <= 0) return;
					Control tbox = this.Controls.Find(nameControl, true)[0];
					if (tbox != null)
					{
						//(tbox as TextBox).ForeColor = Color.Navy;
						//(tbox as TextBox).BackColor = Color.Aqua;
						(tbox as TextBox).Focus();
						(tbox as TextBox).SelectAll();
					}
				}
			}
		}
		private void grvData_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{
			if (e.RowHandle < 0) return;
			if (e.Column.VisibleIndex < 1) return;

			if (e.Column == colRealvalue)
			{
				string value = TextUtilsHP.ToString(grvData.GetRowCellValue(e.RowHandle, colRealvalue));
				int MaxValue = TextUtilsHP.ToInt(grvData.GetRowCellValue(e.RowHandle, colMaxValue));
				int MinValue = TextUtilsHP.ToInt(grvData.GetRowCellValue(e.RowHandle, colMinValue));
				string StandartValue = TextUtilsHP.ToString(grvData.GetRowCellValue(e.RowHandle, colPeriodValue));
				int CheckValueType = TextUtilsHP.ToInt(grvData.GetRowCellValue(e.RowHandle, colCheckValueType));
				if (string.IsNullOrWhiteSpace(value.Trim()))
				{
					e.Appearance.BackColor = Color.Violet;
					return;
				}
				if (CheckValueType == 2)
				{
					if (TextUtilsHP.ToString(value).Trim().ToUpper() != StandartValue.Trim().ToUpper())
					{
						e.Appearance.BackColor = Color.Red;
					}
					else
					{
						e.Appearance.BackColor = Color.Lime;
					}
				}
				else
				{
					if (TextUtilsHP.ToDecimal(value) != 0 && TextUtilsHP.ToDecimal(value) >= MinValue && TextUtilsHP.ToDecimal(value) <= MaxValue)
					{
						e.Appearance.BackColor = Color.Lime;
					}
					else
					{
						e.Appearance.BackColor = Color.Red;
					}
				}
			}
		}

		private void txtWorkerCode_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtWorkerCode.Text.Trim()))
			{
				txtWorkerCode.BackColor = _colorEmpty;
			}
			else
			{
				txtWorkerCode.BackColor = Color.White;
			}
		}

		private void cboBoPhan_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cboBoPhan.Text.Trim()))
			{
				cboBoPhan.BackColor = _colorEmpty;
			}
			else
			{
				cboBoPhan.BackColor = Color.White;
			}
		}

		private void txtMachine_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMachine.Text.Trim()))
			{
				txtMachine.BackColor = _colorEmpty;
			}
			else
			{
				txtMachine.BackColor = Color.White;
			}
		}

		private void txtOrder_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtOrder.Text.Trim()))
			{
				txtOrder.BackColor = _colorEmpty;
			}
			else
			{
				txtOrder.BackColor = Color.White;
			}
		}

		private void txtGoodsCode_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtGoodsCode.Text.Trim()))
			{
				txtGoodsCode.BackColor = _colorEmpty;
			}
			else
			{
				txtGoodsCode.BackColor = Color.White;
			}
		}

		private void txtKnifeDetailCode_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtKnifeDetailCode.Text.Trim()))
			{
				txtKnifeDetailCode.BackColor = _colorEmpty;
			}
			else
			{
				txtKnifeDetailCode.BackColor = Color.White;
			}
		}

		private void cboBoPhan_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtMachine.Focus();
		}

		private void txtMachine_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txtOrder.Focus();

		}

		private void txtGoodsCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txtKnifeDetailCode.Focus();
		}

		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSave_Click(null, null);
		}


	}
}
