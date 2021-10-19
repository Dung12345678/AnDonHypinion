using DevExpress.XtraCharts;
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
	public partial class frmHypMoldDaoJigLine : _Forms
	{
		#region Variables
		//ID khuôn
		int _KnifeDetailListID;
		DataTable _dt;
		DataTable _dtDisplay;
		DataTable _dtNoDisplay;
		int _stepIndex = 0;
		int _NoIndefinitely = 9999;
		int _checkHistoryID = 0;
		int StepIDJig = 0;
		string _path;
		Color _colorEmpty;
		int isHistory = 0;
		int oldHeightGrid = 0;
		DataTable dtJigHistory = new DataTable();
		//string Knife = "";
		CheckHistoryDetailModel _checkHistoryDetailModel;
		DataTable dtDao = new DataTable();
		#endregion Variables
		public frmHypMoldDaoJigLine()
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
			oldHeightGrid = grdData.Height;
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
		/// Sự kiện KeyDown của textbox mã khuôn
		/// </summary>
		private void txtMaHang_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;

			//Tách chuỗi lấy mã khuôn
			//string[] Value = txtKnifeDetailCode.Text.Trim().Split(',');
			//if (Value.Count() >= 3)
			//{
			//	Knife = Value[0] + "," + Value[1] + "," + Value[2];
			DataTable dt = TextUtilsHP.Select($"SELECT DISTINCT kw.ProductStepCode ,kw.ID FROM [HypoidPinion].[dbo].[KnifeStep] kw JOIN dbo.KnifeDetailList kl ON kw.KnifeDetailListID = kl.ID WHERE kl.KnifeCode = N'{txtKnifeDetailCode.Text.Trim()}'");
			DataRow dr = dt.NewRow();
			dr["ProductStepCode"] = "";
			dr["ID"] = 0;
			dt.Rows.InsertAt(dr, 0);
			cboCongDoan.DataSource = dt;
			cboCongDoan.DisplayMember = "ProductStepCode";
			cboCongDoan.ValueMember = "ID";
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
					Color color = Color.White;
					showTextBox(LocationX, LocationY, "", i, color);
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
			//Hiển thị text box của Dao
			LoadDao();
			return dt;
		}
		void LoadDao()
		{
			DataRow[] dr = _dtNoDisplay.Select("WorkingName like '#1#%'");
			if (dr.Length <= 0)
			{
				return;
			}
			DataTable dataTableDao = dr.CopyToDataTable();
			for (int i = 0; i < dataTableDao.Rows.Count; i++)
			{
				string WorkingName = TextUtilsHP.ToString(dataTableDao.Rows[i]["WorkingName"]);
				if (WorkingName.Trim().Contains("#1#"))
				{
					string KnifeCode = TextUtilsHP.ToString(dataTableDao.Rows[i]["PeriodValue"]);
					txtCode.Text = KnifeCode.Trim();
					break;
				}
			}
			//Hiển thị biểu đồ Dao
			LoadDataToChart();
			//Load Dao
			LoadKnife();
		}
		void LoadKnife()
		{
			try
			{
				dtDao = TextUtilsHP.Select($"SELECT Top 1 * FROM  [HypoidPinion].[dbo].[KnifeDetailList] WHERE KnifeCode = N'{txtCode.Text.Trim()}' AND Type = 0");
				if (dtDao.Rows.Count <= 0)
				{
					MessageBox.Show("Không tìm thấy mã Dao");
					return;
				}
				else
				{
					txtCode.Text = TextUtilsHP.ToString(dtDao.Rows[0]["KnifeCode"]);
					txtCurrentATC.Text = TextUtilsHP.ToString(dtDao.Rows[0]["CurrentATC"]);
					txtCurrentSTD.Text = TextUtilsHP.ToString(dtDao.Rows[0]["CurrentSTD"]);
					txtSTD.Text = TextUtilsHP.ToString(dtDao.Rows[0]["STD"]);
					txtRemainQty.Text = TextUtilsHP.ToString(dtDao.Rows[0]["RemainQty"]);
				}
			}
			catch (Exception)
			{
			}
		}
		void LoadDataToChart()
		{
			DataSet ds = TextUtilsHP.GetListDataFromSP("spGetChartProductHistoryData", new string[] { "@knifeCode" }, new object[] { txtCode.Text });
			DataTable data = new DataTable();
			DataTable dtRealTime = new DataTable();
			if (ds.Tables.Count==2)
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
		private void showTextBox(int X, int Y, string RealValue, int row, Color color)
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
			if (RealValue.Trim() != "")
			{
				txtRow.BackColor = color;
			}
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
				//if (RowPrevious < 0)
				//{
				//	//Focus vào gridview
				//	grdData.Focus();
				//	SetFocus(grvData.RowCount - 1, 3);
				//	//grvData.CurrentCell = grvData[5, grvData.RowCount - 1];
				//}
				//else
				//{
				if (RowPrevious >= 0)
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
			if (e.KeyCode == Keys.Down)
			{
				if (row <= _maxTextBoxNumber - 1)
				{
					string nameControl = "txtxxx" + $"{row + 1}";
					Control tbox = this.Controls.Find(nameControl, true)[0];
					if (tbox != null)
					{
						(tbox as TextBox).Focus();
						(tbox as TextBox).SelectAll();
					}
				}
				else
				{
					btnSave1.Focus();
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
					(tbox as TextBox).Focus();
					(tbox as TextBox).SelectAll();
				}
			}
			else
			{
				btnSave1.Focus();
				//btnSave_Click(null, null);
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
		async void UpdateDetailsKhuon(List<CheckHistoryDetailModel> checkHistoryDetailModel)
		{
			Task task = Task.Factory.StartNew(() =>
			{
				foreach (CheckHistoryDetailModel item in checkHistoryDetailModel)
				{
					CheckHistoryDetailBO.Instance.Update(item);
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
			isHistory = 0;
			//Check mã cũ trong lịch sử có tồn tại không 
			DataSet ds = TextUtilsHP.GetListDataFromSP("spGetHistoryMold", new string[] { "@KnifeCode", "@Order", "@GoodsCode", "@StepCode" }, new object[] { txtKnifeDetailCode.Text.Trim(), txtOrder.Text.Trim(), txtGoodsCode.Text.Trim(), cboCongDoan.Text.Trim() });
			///Hiển thị dữ trên grv
			DataTable dt = ds.Tables[0];
			if (dt != null && dt.Rows.Count > 0)
			{
				_checkHistoryID = TextUtilsHP.ToInt(dt.Rows[0]["CheckHistoryID"]);
				grdData.DataSource = dt;
				_dtNoDisplay = dt.Copy();
				//Hiển thị trên hình vẽ
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
				deleteAllTextBox();
				//Hiển thị text box
				if(ds.Tables.Count==2)
				{
					_dtDisplay = ds.Tables[1];
				}
				//TODO: Show textbox
				_maxTextBoxNumber = _dtDisplay.Rows.Count - 1;
				for (int i = 0; i < _dtDisplay.Rows.Count; i++)
				{
					Color Color = Color.White;
					string RealDisplay = TextUtilsHP.ToString(_dtDisplay.Rows[i]["Real1"]);
					int LocationX = TextUtilsHP.ToInt(_dtDisplay.Rows[i]["X"]);
					int LocationY = TextUtilsHP.ToInt(_dtDisplay.Rows[i]["Y"]);
					decimal MaxValue = TextUtilsHP.ToDecimal(_dtDisplay.Rows[i]["MaxValue"]);
					decimal MinValue = TextUtilsHP.ToDecimal(_dtDisplay.Rows[i]["MinValue"]);
					string StandartValue = TextUtilsHP.ToString(_dtDisplay.Rows[i]["PeriodValue"]);
					int CheckValueType = TextUtilsHP.ToInt(_dtDisplay.Rows[i]["CheckValueType"]);
					if (CheckValueType == 2)
					{
						if (TextUtilsHP.ToString(RealDisplay).ToUpper() != StandartValue.ToUpper())
						{
							Color = Color.Red;
						}
						else
						{
							Color = Color.Lime;
						}
					}
					else
					{
						if (TextUtilsHP.ToDecimal(RealDisplay) != 0 && TextUtilsHP.ToDecimal(RealDisplay) >= MinValue && TextUtilsHP.ToDecimal(RealDisplay) <= MaxValue)
						{
							Color = Color.Lime;
						}
						else
						{
							Color = Color.Red;
						}
					}
					//string RealValue = TextUtilsHP.ToString(loadDataHypMold().Rows[i]["RealValue"]);
					showTextBox(LocationX, LocationY, RealDisplay, i, Color);
				}
				Setbutton(true);
				LoadDao();
				LoadJig();
				isHistory = 1;
				btnSave1.Focus();

			}
			else
			{
				loadAllTextBox();
				grvKnifeJigWorking_CellClick(null, null);
				//if (grvData.Rows.Count > 0)
				//{
				//	grvData.CurrentCell = grvData[5, 0];
				//}
				SetInterface(true);
				//focus vào dòng đầu tiên của cột thứ 3
				SetFocus(0, 3);
				if (grvData.RowCount <= 0) return;
			}
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
				string value = TextUtilsHP.ToString(grvData.GetRowCellValue(e.RowHandle, colRealvalue));
				string Evaluate = "";
				//CheckValueType=2 string , = 1 dạng số
				string[] valueSplit = value.Split(',');
				if (valueSplit.Length >= 3)
				{
					value = valueSplit[0] + "," + valueSplit[1] + "," + valueSplit[2];
				}
				if (CheckValueType == 2)
				{
					string ValueReal = TextUtilsHP.ToString(value).Trim().ToUpper();
					string StandartValueReal = StandartValue.Trim().ToUpper();
					if (ValueReal != StandartValueReal)
					{

					}
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
				SetFocus(e.RowHandle + 1, 3);
			}
			catch (Exception)
			{

			}
			//Hiển thị Gridview Jig
			LoadJig();
			//if (e.RowHandle == grvData.RowCount - 1)
			//{
			//	grvDataJig.Focus();
			//	SetFocusJig(0, 2);
			//}
			if (e.RowHandle == grvData.RowCount - 1)
			{
				btnSave1.Focus();
			}
			//TODO: Điều kiện focus vào textbox

			//if (_dtNoDisplay.Rows.Count == grvData.RowCount)
			//{
			//	selectedrowindex = e.RowHandle;
			//	if (selectedrowindex < grvData.RowCount - 1)
			//	{
			//		_nextrow = selectedrowindex;
			//	}
			//	else
			//	{
			//		_nextrow = selectedrowindex + 1;
			//	}
			//	if (_nextrow >= grvData.RowCount)
			//	{
			//		string nameControl = "txtxxx0";
			//		Control[] controls = this.Controls.Find(nameControl, true);
			//		if (controls.Count() <= 0) return;
			//		Control tbox = this.Controls.Find(nameControl, true)[0];
			//		if (tbox != null)
			//		{
			//			//(tbox as TextBox).ForeColor = Color.Navy;
			//			//(tbox as TextBox).BackColor = Color.Aqua;
			//			(tbox as TextBox).Focus();
			//			(tbox as TextBox).SelectAll();
			//		}
			//	}
			//}

		}
		void LoadJig()
		{
			try
			{
				//Tìm mã Jig
				DataTable AllJig = new DataTable();
				int check = 1;
				DataRow[] dr = _dtNoDisplay.Select("WorkingName like '#2#%'");
				if (dr.Length <= 0)
				{
					return;
				}
				DataTable dataTableJig = dr.CopyToDataTable();
				for (int i = 0; i < dataTableJig.Rows.Count; i++)
				{
					string Real = TextUtilsHP.ToString(dataTableJig.Rows[i]["Real1"]);
					string KnifeCode = "";
					if (Real.Trim() == "") continue;
					string[] RealSplit = Real.Split(',');
					if (RealSplit.Length >= 3)
					{
						KnifeCode = RealSplit[0] + "," + RealSplit[1] + "," + RealSplit[2];
					}
					else
					{
						continue;
					}	
					// có Code => mục kiểm tra data jig theo CD10 
					DataTable dt = TextUtilsHP.GetDataTableFromSP("spGetHistoryCDJig", new string[] { "@KnifeCode", "@KnifeCodeReal", "@OrderCode", "@GoodsCode" }, new object[] { KnifeCode.Trim(), Real, txtOrder.Text.Trim(), txtGoodsCode.Text.Trim() });

					if (check == 1)
					{
						check = 2;
						AllJig = dt.Clone();
					}
					AllJig.Merge(dt);
				}
				grdDataJig.DataSource = AllJig;
				dtJigHistory = AllJig;
			}
			catch
			{

			}
		}
		void SetFocusJig(int row, int column)
		{
			grvDataJig.FocusedRowHandle = row;
			grvDataJig.FocusedColumn = grvDataJig.VisibleColumns[column];
		}
		private void grvData_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{
			if (e.RowHandle < 0) return;
			if (e.Column.VisibleIndex < 4) return;
			if (e.Column == colEvaluate)
			{
				string value = TextUtilsHP.ToString(grvData.GetRowCellValue(e.RowHandle, colEvaluate));
				if (value.ToUpper().Trim() == "OK")
				{
					e.Appearance.BackColor = Color.Lime;
				}
				else if (value.ToUpper().Trim() == "NG")
				{
					e.Appearance.BackColor = Color.Red;
				}
			}
			//if (e.Column == colRealvalue)
			//{
			//	string value = TextUtilsHP.ToString(grvData.GetRowCellValue(e.RowHandle, colRealvalue));
			//	int MaxValue = TextUtilsHP.ToInt(grvData.GetRowCellValue(e.RowHandle, colMaxValue));
			//	int MinValue = TextUtilsHP.ToInt(grvData.GetRowCellValue(e.RowHandle, colMinValue));
			//	string StandartValue = TextUtilsHP.ToString(grvData.GetRowCellValue(e.RowHandle, colPeriodValue));
			//	int CheckValueType = TextUtilsHP.ToInt(grvData.GetRowCellValue(e.RowHandle, colCheckValueType));
			//	if (string.IsNullOrWhiteSpace(value.Trim()))
			//	{
			//		e.Appearance.BackColor = Color.Violet;
			//		return;
			//	}
			//	if (CheckValueType == 2)
			//	{
			//		if (TextUtilsHP.ToString(value).Trim().ToUpper() != StandartValue.Trim().ToUpper())
			//		{
			//			e.Appearance.BackColor = Color.Red;
			//		}
			//		else
			//		{
			//			e.Appearance.BackColor = Color.Lime;
			//		}
			//	}
			//	else
			//	{
			//		if (TextUtilsHP.ToDecimal(value) != 0 && TextUtilsHP.ToDecimal(value) >= MinValue && TextUtilsHP.ToDecimal(value) <= MaxValue)
			//		{
			//			e.Appearance.BackColor = Color.Lime;
			//		}
			//		else
			//		{
			//			e.Appearance.BackColor = Color.Red;
			//		}
			//	}
			//}
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

		private void btnSave1_Click(object sender, EventArgs e)
		{

			DataSet ds = TextUtilsHP.GetListDataFromSP("spGetHistoryMold", new string[] { "@KnifeCode", "@Order", "@GoodsCode", "@StepCode" }, new object[] { txtKnifeDetailCode.Text.Trim(), txtOrder.Text.Trim(), txtGoodsCode.Text.Trim(), cboCongDoan.Text.Trim() });
			if (btnSave1.Text.Trim() == "NEXT")
			{
				//Thông báo 
				//if()
				//DialogResult result = MessageBox.Show("Bạn có chắc muốn cất dữ liệu?", "Cất?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				//if (result == DialogResult.No) return;
				btnBack.Visible = true;
				btnSave1.Text = "SAVE";
				//Check database có tồn tại k  
				// Lưu data vào sql
				DataTable dtGrv = ds.Tables[0];
				if (ds.Tables[0].Rows.Count == 0)
				{
					//Hiển thị số lượng Dao trong bảng PNG
					try
					{
						DataTable dt = TextUtilsHP.GetDataTableFromSP("spGetCountDaoCachining", new string[] { "@KnifeCode", "@Order" }, new object[] { txtCode.Text.Trim(), txtOrder.Text.Trim() });
						if (dt.Rows.Count > 0)
						{
							try
							{
								KnifeProcessedListModel knifeProcessedList = new KnifeProcessedListModel();
								knifeProcessedList.KnifeCode = txtCode.Text.Trim();
								knifeProcessedList.KnifeID = TextUtilsHP.ToInt(dtDao.Rows[0]["ID"]);
								knifeProcessedList.Worker = txtWorkerCode.Text;
								knifeProcessedList.GoodsCode = txtGoodsCode.Text.Trim();
								knifeProcessedList.MachineCode = txtMachine.Text.Trim();
								knifeProcessedList.OrderCode = txtOrder.Text.Trim();
								knifeProcessedList.PartID = TextUtils.ToInt(cboBoPhan.SelectedValue);
								knifeProcessedList.PartCode = cboBoPhan.Text.Trim();
								knifeProcessedList.KnifeCodeReal = txtCode.Text.Trim();
								// đếm số lần gia công giao trên PGN
								int Count = TextUtilsHP.ToInt(dt.Rows[0]["Countt"]);
								knifeProcessedList.Quantity = Count;
								if (TextUtilsHP.ToInt(txtSTD.Text.Trim()) < Count + TextUtilsHP.ToInt(txtCurrentSTD.Text.Trim()))
								{
									if (MessageBox.Show($"Số lượng gia công thực tế: { Count + TextUtilsHP.ToInt(txtCurrentSTD.Text.Trim())} vượt quá số lượng gia công quy định: {TextUtilsHP.ToInt(txtSTD.Text.Trim())} bạn có muốn mài dao không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
									{
										// Mai dao
										frmKnifeSharpen frm = new frmKnifeSharpen();
										frm.knifeID = TextUtilsHP.ToInt(dtDao.Rows[0]["ID"]);
										if (frm.ShowDialog() == DialogResult.OK)
										{
											knifeProcessedList = new KnifeProcessedListModel();
											LoadKnife();
											return;
										}
									}
								}
								//Insert vào bảng KnifeProcessedList và cập nhật số lượng theo DaoID
								TextUtilsHP.ExcuteProcedure("spKnifeAddProcess",
												new string[] { "@knifeID", "@knifeCode", "@worker", "@productCode", "@machineCode", "@quantity", "@orderCode", "@partID", "@KnifeCodeReal" },
												new object[] { knifeProcessedList.KnifeID, knifeProcessedList.KnifeCode, knifeProcessedList.Worker, knifeProcessedList.GoodsCode, knifeProcessedList.MachineCode, knifeProcessedList.Quantity, knifeProcessedList.OrderCode, knifeProcessedList.PartID, knifeProcessedList.KnifeCode });
							}
							catch (Exception ex)
							{
								MessageBox.Show("Có lỗi trong quá trình xử lý!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
							}
						}
						else
						{
							MessageBox.Show("Không tìm thấy số lượng Dao gia công", "Thông báo");
							return;
						}
					}
					catch
					{
					}
					//try
					//{

					//	//Lưu thông tin Jig
					//	int IDOld = 0;
					//	int CheckHistoryID = 0;
					//	for (int i = 0; i < grvDataJig.RowCount; i++)
					//	{
					//		//Lưu Master
					//		int ID = TextUtilsHP.ToInt(grvDataJig.GetRowCellValue(i, colKnifeDetailListID));
					//		if (ID != IDOld)
					//		{
					//			IDOld = ID;
					//			CheckHistoryModel checkHistoryModel = new CheckHistoryModel();
					//			checkHistoryModel.KnifeDetailListID = TextUtilsHP.ToInt(grvDataJig.GetRowCellValue(i, colKnifeDetailListID));
					//			checkHistoryModel.OrderCode = txtOrder.Text.Trim();
					//			checkHistoryModel.Type = 1;
					//			checkHistoryModel.KnifeDetailCode = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(i, colKnifeCodeReal));
					//			checkHistoryModel.Machine = txtMachine.Text.Trim();
					//			checkHistoryModel.StepCode = cboCongDoan.Text.Trim();
					//			checkHistoryModel.WorkerCode = txtWorkerCode.Text.Trim();
					//			checkHistoryModel.GoodsCode = txtGoodsCode.Text.Trim();
					//			checkHistoryModel.CreateDate = DateTime.Now;
					//			string[] RealJigSplit = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(i, colKnifeCodeReal)).Split(',');
					//			string RealJig = "";
					//			if (RealJigSplit.Length >= 3)
					//			{
					//				RealJig = RealJigSplit[0] + "," + RealJigSplit[1] + "," + RealJigSplit[2];
					//			}
					//			checkHistoryModel.KnifeDetailCodeReal = RealJig;
					//			checkHistoryModel.PartCode = cboBoPhan.Text.Trim();
					//			checkHistoryModel.StepCodeID = StepIDJig;
					//			CheckHistoryID = (int)CheckHistoryBO.Instance.Insert(checkHistoryModel);
					//		}
					//		//Lưu Details
					//		CheckHistoryDetailModel checkHistoryDetailModel = new CheckHistoryDetailModel();
					//		checkHistoryDetailModel.CheckHistoryID = CheckHistoryID;
					//		checkHistoryDetailModel.WorkingName = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(i, colWorkingNameJig));
					//		checkHistoryDetailModel.CheckValueType = TextUtilsHP.ToInt(grvDataJig.GetRowCellValue(i, colCheckValueTypeJig));
					//		checkHistoryDetailModel.Unit = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(i, colUnitJig));
					//		checkHistoryDetailModel.StandardValue = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(i, colPeriodValueJig));
					//		checkHistoryDetailModel.RealValue = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(i, colReal));
					//		checkHistoryDetailModel.SortOrder = TextUtilsHP.ToInt(grvDataJig.GetRowCellValue(i, colSortOrderJig));
					//		checkHistoryDetailModel.Result = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(i, colRateJig));
					//		checkHistoryDetailModel.Min = TextUtilsHP.ToDecimal(grvDataJig.GetRowCellValue(i, colMinJig));
					//		checkHistoryDetailModel.Max = TextUtilsHP.ToDecimal(grvDataJig.GetRowCellValue(i, colMaxJig));
					//		CheckHistoryDetailBO.Instance.Insert(checkHistoryDetailModel);
					//	}
					//}
					//catch
					//{
					//}
					//Lưu thông tin khuôn
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
						_checkHistory.StepCodeID = TextUtilsHP.ToInt(cboCongDoan.SelectedValue);
						_checkHistory.PartID = TextUtilsHP.ToInt(cboBoPhan.SelectedValue);
						_checkHistory.PartCode = cboBoPhan.Text.Trim();
						_checkHistory.WorkerCode = txtWorkerCode.Text.Trim();
						_checkHistory.ID = TextUtilsHP.ToInt(CheckHistoryBO.Instance.Insert(_checkHistory));
						List<CheckHistoryDetailModel> lstKhuon = new List<CheckHistoryDetailModel>();
						_checkHistoryID = _checkHistory.ID;
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
							_checkHistoryDetailModel.Min = TextUtilsHP.ToDecimal(grvData.GetRowCellValue(i, colMinValue));
							_checkHistoryDetailModel.Max = TextUtilsHP.ToDecimal(grvData.GetRowCellValue(i, colMaxValue));
							_checkHistoryDetailModel.CreateDate = DateTime.Now;
							lstKhuon.Add(_checkHistoryDetailModel);
						}
						Save(lstKhuon);
					}
					catch
					{
					}
				}
				else
				{
					//try
					//{
					//	//cập nhật thông tin Jig
					//	for (int i = 0; i < grvDataJig.RowCount; i++)
					//	{
					//		//Lưu Details
					//		CheckHistoryDetailModel checkHistoryDetailModel = new CheckHistoryDetailModel();
					//		checkHistoryDetailModel.ID = TextUtilsHP.ToInt(dtJigHistory.Rows[i]["ID"]);
					//		checkHistoryDetailModel.CheckHistoryID = TextUtilsHP.ToInt(dtJigHistory.Rows[i]["CheckHistoryID"]);
					//		checkHistoryDetailModel.WorkingName = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(i, colWorkingNameJig));
					//		checkHistoryDetailModel.CheckValueType = TextUtilsHP.ToInt(grvDataJig.GetRowCellValue(i, colCheckValueTypeJig));
					//		checkHistoryDetailModel.Unit = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(i, colUnitJig));
					//		checkHistoryDetailModel.StandardValue = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(i, colPeriodValueJig));
					//		checkHistoryDetailModel.RealValue = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(i, colReal));
					//		checkHistoryDetailModel.SortOrder = TextUtilsHP.ToInt(grvDataJig.GetRowCellValue(i, colSortOrderJig));
					//		checkHistoryDetailModel.Result = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(i, colRateJig));
					//		checkHistoryDetailModel.Min = TextUtilsHP.ToDecimal(grvDataJig.GetRowCellValue(i, colMinJig));
					//		checkHistoryDetailModel.Max = TextUtilsHP.ToDecimal(grvDataJig.GetRowCellValue(i, colMaxJig));
					//		CheckHistoryDetailBO.Instance.Update(checkHistoryDetailModel);
					//	}
					//}
					//catch
					//{
					//}

					//Update
					List<CheckHistoryDetailModel> lstKhuon = new List<CheckHistoryDetailModel>();
					for (int i = 0; i < grvData.RowCount; i++)
					{
						_checkHistoryDetailModel = new CheckHistoryDetailModel();
						_checkHistoryDetailModel.ID = TextUtilsHP.ToInt(dtGrv.Rows[i]["ID"]);
						_checkHistoryDetailModel.CheckHistoryID = TextUtilsHP.ToInt(dtGrv.Rows[i]["CheckHistoryID"]);
						_checkHistoryDetailModel.WorkingName = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colWorkingName));
						_checkHistoryDetailModel.CheckValueType = TextUtilsHP.ToInt(grvData.GetRowCellValue(i, colCheckValueType));
						_checkHistoryDetailModel.Unit = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colUnit));
						_checkHistoryDetailModel.StandardValue = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colPeriodValue));
						_checkHistoryDetailModel.RealValue = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colRealvalue));
						_checkHistoryDetailModel.SortOrder = TextUtilsHP.ToInt(grvData.GetRowCellValue(i, colSortOrder));
						_checkHistoryDetailModel.Result = TextUtilsHP.ToString(grvData.GetRowCellValue(i, colEvaluate));
						_checkHistoryDetailModel.Min = TextUtilsHP.ToDecimal(grvData.GetRowCellValue(i, colMinValue));
						_checkHistoryDetailModel.Max = TextUtilsHP.ToDecimal(grvData.GetRowCellValue(i, colMaxValue));
						_checkHistoryDetailModel.CreateDate = DateTime.Now;
						lstKhuon.Add(_checkHistoryDetailModel);
					}
					UpdateDetailsKhuon(lstKhuon);
				}
				tableLayoutPanel1.Visible = false;
				//Focus vào textbox
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
			else
			{
				btnBack.Visible = false;
				DataTable dtIMG = new DataTable();
				if (ds.Tables.Count == 2)
				{
					dtIMG = ds.Tables[1];
				}
				//Lưu dữ liệu của ảnh vẽ
				//TODO: Save at Textbox
				List<CheckHistoryDetailModel> lstKhuon = new List<CheckHistoryDetailModel>();
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
					_checkHistoryDetailModel.CheckHistoryID = _checkHistoryID;
					_checkHistoryDetailModel.WorkingName = TextUtilsHP.ToString(_dtDisplay.Rows[row]["WorkingName"]);
					_checkHistoryDetailModel.CheckValueType = TextUtilsHP.ToInt(_dtDisplay.Rows[row]["CheckValueType"]);
					_checkHistoryDetailModel.Unit = TextUtilsHP.ToString(_dtDisplay.Rows[row]["Unit"]);
					_checkHistoryDetailModel.StandardValue = TextUtilsHP.ToString(_dtDisplay.Rows[row]["PeriodValue"]);
					_checkHistoryDetailModel.RealValue = TextUtilsHP.ToString(item.Text.Trim());
					_checkHistoryDetailModel.SortOrder = TextUtilsHP.ToInt(_dtDisplay.Rows[row]["SortOrder"]);
					_checkHistoryDetailModel.Result = Result;
					_checkHistoryDetailModel.Min = TextUtilsHP.ToDecimal(_dtDisplay.Rows[row]["MinValue"]);
					_checkHistoryDetailModel.Max = TextUtilsHP.ToDecimal(_dtDisplay.Rows[row]["MaxValue"]);
					_checkHistoryDetailModel.X = TextUtilsHP.ToInt(_dtDisplay.Rows[row]["X"]);
					_checkHistoryDetailModel.Y = TextUtilsHP.ToInt(_dtDisplay.Rows[row]["Y"]);
					_checkHistoryDetailModel.IsDisplay = 1;
					_checkHistoryDetailModel.CreateDate = DateTime.Now;
					if (dtIMG.Rows.Count > 0)
					{
						_checkHistoryDetailModel.ID = TextUtilsHP.ToInt(dtIMG.Rows[row]["ID"]);
					}
					lstKhuon.Add(_checkHistoryDetailModel);
				}
				if (dtIMG.Rows.Count > 0)
				{
					UpdateDetailsKhuon(lstKhuon);
				}
				else
				{
					Save(lstKhuon);
				}
				tableLayoutPanel1.Visible = true;
				Reset();
				btnSave1.Text = "NEXT";
			}
		}
		void Reset()
		{
			txtOrder.Focus();
			txtOrder.Text = "";
			txtGoodsCode.Text = "";
			txtKnifeDetailCode.Text = "";
			cboCongDoan.Text = "";
			grdData.DataSource = null;
			grdDataJig.DataSource = null;
			txtCode.Text = "";
			txtCurrentATC.Text = "";
			txtCurrentSTD.Text = "";
			txtSTD.Text = "";
			txtRemainQty.Text = "";
		}
		private void txtCode_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void txtCode_TextChanged(object sender, EventArgs e)
		{
			//int Count = TextUtilsHP.ToInt(TextUtilsHP.ExcuteScalar($"SELECT COUNT(*) FROM [HypoidPinion].[dbo].[ProductKnife] WHERE OrderMachining=N'{txtOrder.Text.Trim()}'  AND ArticleID=N'{knifeProcessedList.GoodsCode}' "));
			//knifeProcessedList.Quantity = Count;
			//if (TextUtilsHP.ToInt(dtKnifeList.Rows[0]["STD"]) < Count)
			//{
			//	if (MessageBox.Show($"Số lượng gia công thực tế: {Count} vượt quá số lượng gia công quy định: {TextUtilsHP.ToInt(dtKnifeList.Rows[0]["STD"])} bạn có muốn mài dao không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
			//	{
			//		// Mai dao
			//		frmKnifeSharpen frm = new frmKnifeSharpen();
			//		frm.knifeID = TextUtilsHP.ToInt(dtKnifeList.Rows[0]["ID"]);
			//		if (frm.ShowDialog() == DialogResult.OK)
			//		{
			//			knifeProcessedList = new KnifeProcessedListModel();
			//			ClearFormData();
			//			LoadData();
			//		}
			//	}
			//	else
			//	{
			//		return false;
			//	}
			//}
		}

		private void grvDataJig_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			//TODO: So sánh điều kiện của grid
			try
			{
				//setFocusCell();
				if (grvDataJig.RowCount <= 0) return;
				decimal MaxValue = TextUtilsHP.ToDecimal(grvDataJig.GetRowCellValue(e.RowHandle, colMaxJig));
				decimal MinValue = TextUtilsHP.ToDecimal(grvDataJig.GetRowCellValue(e.RowHandle, colMinJig));
				string StandartValue = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(e.RowHandle, colPeriodValueJig));
				int CheckValueType = TextUtilsHP.ToInt(grvDataJig.GetRowCellValue(e.RowHandle, colCheckValueTypeJig));
				string value = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(e.RowHandle, colReal));
				string Evaluate = "";
				//CheckValueType=2 string , = 1 dạng số
				string[] valueSplit = value.Split(',');
				if (valueSplit.Length >= 3)
				{
					value = valueSplit[0] + "," + valueSplit[1] + "," + valueSplit[2];
				}
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
				if (e.Column == colReal)
				{
					grvDataJig.SetRowCellValue(e.RowHandle, colRateJig, Evaluate);
				}


				SetFocusJig(e.RowHandle + 1, 2);
				if (e.RowHandle == grvDataJig.RowCount - 1)
				{
					btnSave1.Focus();
				}
			}
			catch (Exception)
			{

			}
		}

		private void grvDataJig_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{
			if (e.RowHandle < 0) return;
			if (e.Column.VisibleIndex < 3) return;
			if (e.Column == colRateJig)
			{
				string value = TextUtilsHP.ToString(grvDataJig.GetRowCellValue(e.RowHandle, colRateJig));
				if (value.ToUpper().Trim() == "OK")
				{
					e.Appearance.BackColor = Color.Lime;
				}
				else if (value.ToUpper().Trim() == "NG")
				{
					e.Appearance.BackColor = Color.Red;
				}
			}
		}

		private void cboBoPhan_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtMachine.Focus();
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			tableLayoutPanel1.Visible = true;
			btnSave1.Text = "NEXT";
			btnBack.Visible = false;
		}

		private void btnSave1_KeyUp(object sender, KeyEventArgs e)
		{
			//Mũi tên lên focus vào gridviewjig
			if (e.KeyCode == Keys.Up && btnSave1.Text.Trim().ToUpper() == "NEXT")
			{
				//if (grvDataJig.RowCount > 0)
				//{
				//	grvDataJig.Focus();
				//	SetFocusJig(grvDataJig.RowCount - 1, 2);
				//}
				//else
				//{
					grvData.Focus();
					SetFocus(grvData.RowCount - 1, 3);
				//}
			}
			if (e.KeyCode == Keys.Up && btnSave1.Text.Trim().ToUpper() == "SAVE")
			{
				string nameControl = "txtxxx" + $"{_maxTextBoxNumber}";
				Control tbox = this.Controls.Find(nameControl, true)[0];
				if (tbox != null)
				{
					(tbox as TextBox).Focus();
					(tbox as TextBox).SelectAll();
				}

			}
		}

		private void grvData_KeyDown(object sender, KeyEventArgs e)
		{
			if (grvData.FocusedRowHandle == grvData.RowCount - 1 && e.KeyCode == Keys.Down)//dòng cuối cùng
			{
				if (grvDataJig.RowCount > 0)
				{
					grvDataJig.Focus();
					SetFocusJig(0, 2);
				}
				else
				{
					btnSave1.Focus();
				}
			}
		}

		private void grvDataJig_KeyDown(object sender, KeyEventArgs e)
		{
			if (grvDataJig.FocusedRowHandle == grvDataJig.RowCount - 1 && e.KeyCode == Keys.Down)//dòng cuối cùng
			{
				btnSave1.Focus();
			}
			if (grvDataJig.FocusedRowHandle == 0 && e.KeyCode == Keys.Up)
			{
				grvData.Focus();
				SetFocus(grvData.RowCount - 1, 3);
			}
		}

		private void cboCongDoan_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cboCongDoan.Text.Trim()))
			{
				cboCongDoan.BackColor = _colorEmpty;
			}
			else
			{
				cboCongDoan.BackColor = Color.White;
			}
		}
	}
}
