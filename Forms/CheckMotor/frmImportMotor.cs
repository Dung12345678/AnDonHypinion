using DevExpress.XtraGrid;
using Forms.CheckMotor;
using ST.Business;
using ST.Model;
using System;
using System.Collections;
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
	public partial class frmImportMotor : _Forms
	{
		ShelfModel _shelfModel = new ShelfModel();
		HistoryShelfMotorModel _historyShelfMotorModel = new HistoryShelfMotorModel();
		AutoAddShelfMotorModel _autoAddShelfMotorModel = new AutoAddShelfMotorModel();
		MotorShelfModel _motorShelf = new MotorShelfModel();
		Color _colorEmpty;
		int Qty = 0;
		List<UCShelf> _lstUCShelf = new List<UCShelf>();
		List<string> _lstShelfName = new List<string>();
		List<UCSequence> _lstUCSequence = new List<UCSequence>();
		List<HistoryShelfMotorModel> _lsthistoryShelfMotorModels = new List<HistoryShelfMotorModel>();
		List<AutoAddShelfMotorModel> _lstAddShelfMotorModels = new List<AutoAddShelfMotorModel>();
		//List<MotorShelfModel> _lstMotorShelf = new List<MotorShelfModel>();
		List<string> _LstSerialNumber = new List<string>();
		string ArticleID = "";
		Thread _threadShelfNumber;

		int[] rowCount;
		public frmImportMotor()
		{
			InitializeComponent();

		}

		private void frmHypMeasuringTools_Load(object sender, EventArgs e)
		{
			tableLayoutPanel1.SetColumnSpan(txtStep, 5);
			_colorEmpty = Color.FromArgb(255, 192, 255);
			txtStep.Text = "NHẬP HÀNG MOTOR";
			//Load dãy và giá
			LoadSequence();
			//Load số lượng thực tế đang ở Giá đỡ
			_threadShelfNumber = new Thread(new ThreadStart(LoadShelfNumber));
			_threadShelfNumber.IsBackground = true;
			_threadShelfNumber.Start();
			txtWorker.Focus();
		}
		void LoadShelfNumber()
		{
			while (true)
			{
				try
				{
					Thread.Sleep(500);
					DataSet ds = TextUtilsStock.GetListDataFromSP("spLoadShelf", new string[] { }, new object[] { });
					DataTable dt = ds.Tables[0];// Số cột Giá đỡ 
					DataTable dt1 = ds.Tables[1];// Số dòng Dãy 
					DataTable dt2 = ds.Tables[2];// bảng Shelf
					for (int i = 0; i < _lstUCShelf.Count; i++)
					{
						this.Invoke((MethodInvoker)delegate
						{
							int ShelfNumber = TextUtils.ToInt(dt2.Rows[i]["ShelfNumber"]);
							_lstUCShelf[i].LoadColor(ShelfNumber, txtLocation.Text.Trim());
						});
					}
				}
				catch (Exception)
				{


				}

			}
		}

		void LoadSequence()
		{
			Lib.BeginControlUpdate(tblLayout);
			tblLayout.SuspendLayout();
			_lstUCSequence.Clear();
			_lstUCShelf.Clear();
			DataSet ds = TextUtilsStock.GetListDataFromSP("spLoadShelf", new string[] { }, new object[] { });
			DataTable dt = ds.Tables[0];// Số cột Giá đỡ 
			DataTable dt1 = ds.Tables[1];// Số dòng Dãy 
			DataTable dt2 = ds.Tables[2];// bảng Shelf
			if (dt.Rows.Count <= 0) return;
			if (dt1.Rows.Count <= 0) return;
			int Width = this.tblLayout.Width;
			int Height = this.tblLayout.Height;
			float F = (float)(Height * 1.0 / dt.Rows.Count);
			this.tblLayout.RowCount = dt.Rows.Count;
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				if (F >= 48)
					this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, F));
				else
				{
					this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
				}
			}
			this.tblLayout.ColumnCount = TextUtilsStock.ToInt(dt1.Rows[0]["column1"]) + 2;
			float FC = (float)(Width * 1.0 / tblLayout.ColumnCount + 1);
			for (int i = 0; i <= tblLayout.ColumnCount + 2; i++)
			{
				this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, FC));
			}

			int row = 0;
			int column = 0;
			int rowSequence = 0;
			int columnSequence = 0;
			int columnI = 0;
			for (int i = 0; i < dt2.Rows.Count; i++)
			{
				int SequenceIDOld = 0;
				int SequenceIDNew = 0;
				if (i > 0)
				{
					SequenceIDOld = TextUtilsStock.ToInt(dt2.Rows[i - 1]["SequenceID"]);
				}
				SequenceIDNew = TextUtilsStock.ToInt(dt2.Rows[i]["SequenceID"]);
				//So sánh theo Dãy nếu khác dãy thì xuống dòng tablepanel
				if (SequenceIDNew != SequenceIDOld)
				{
					// Add UCControl Dãy vào panel
					string SequenceName = TextUtilsStock.ToString(dt.Rows[rowSequence]["SequenceName"]);
					UCSequence uc = new UCSequence();
					uc.Dock = DockStyle.Fill;
					uc.SequenceName = SequenceName;
					tblLayout.Controls.Add(uc, columnSequence + 1, rowSequence + 1);
					_lstUCSequence.Add(uc);
					rowSequence++;
					columnI = i;
				}
				// Add UCControl Giá vào panel
				row = rowSequence;
				column = i + 2 - columnI;
				UCShelf uc1 = new UCShelf();
				uc1.NameShelf = TextUtilsStock.ToString(dt2.Rows[i]["ShelfName"]);
				uc1.Qty = TextUtilsStock.ToInt(dt2.Rows[i]["ShelfNumber"]);
				uc1.Dock = DockStyle.Fill;
				tblLayout.Controls.Add(uc1, column, row);
				_lstUCShelf.Add(uc1);
				_lstShelfName.Add(TextUtilsStock.ToString(dt2.Rows[i]["ShelfName"]));
			}
			Lib.EndControlUpdate(tblLayout);
			tblLayout.ResumeLayout();

		}
		private void txt_TextChanged(object sender, EventArgs e)
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

		private void txtSerialNumber_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode != Keys.Enter) return;
			if (txtSerialNumber.Text.Trim().ToUpper().Contains("OK"))
			{
				btnSave_Click_1(null, null);
				return;
			}
			DataTable dt = TextUtilsStock.Select($"SELECT * FROM [SystemData].[dbo].[CheckMotor] WHERE CardNo =N'{ txtSerialNumber.Text.Trim()}'");
			if (dt.Rows.Count <= 0)
			{
				MessageBox.Show("Không tìm thấy Serial Number trong kho Motor", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSerialNumber.Text = "";
				txtSerialNumber.Focus();
				return;
			}
			ArticleID = TextUtilsStock.ToString(dt.Rows[0]["ArticleID"]);
			txtSaleNumber.Text = TextUtilsStock.ToString(dt.Rows[0]["SalesOrder"]);
			txtQtySale.Text = TextUtilsStock.ToString(dt.Rows[0]["OrderedQty"]);
			int UC = 0;
			for (int i = 0; i < _lstShelfName.Count; i++)
			{
				if (_lstShelfName[i] == txtLocation.Text.Trim())
				{
					UC = i;
					break;
				}
			}
			//Load Shelf
			ArrayList array = ShelfBO.Instance.FindByAttribute("ShelfCode", txtLocation.Text.Trim());
			if (array.Count <= 0)
			{
				MessageBox.Show("Vị trí không đúng xin nhập lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			_shelfModel = (ShelfModel)array[0];
			//Load lên số lượng từng Shelf
			int check = TextUtilsStock.ToInt(TextUtilsStock.ExcuteScalar($"SELECT 1 FROM [ShiStock].[dbo].[HistoryShelfMotor] WHERE SerialNumber='{txtSerialNumber.Text.Trim()}'"));
			if (check == 1 || _LstSerialNumber.Contains($"{txtSerialNumber.Text.Trim()}"))
			{
				MessageBox.Show("Serial Number đã nhập", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSerialNumber.Text = "";
				txtSerialNumber.Focus();
				return;
			}
			//Check Sale Number theo giá  nếu khác giá thì thông báo return;
			//string Shelf = TextUtilsStock.ToString(TextUtilsStock.ExcuteScalar($"SELECT Shelf FROM [ShiStock].[dbo].MotorShelf WHERE SerialNumber='{txtSerialNumber.Text.Trim()}' AND SaleNumBer ='{txtSaleNumber.Text.Trim()}' AND Shelf ='{txtLocation.Text.Trim()}'"));
			if (_lsthistoryShelfMotorModels.Where(m => m.SaleNumBer != $"{txtSaleNumber.Text.Trim()}").Count() > 0)
			{
				MessageBox.Show("Giá đã có SALE NUMBER", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSerialNumber.Text = "";
				txtSerialNumber.Focus();
				return;
			}

			int RowCountHistory = TextUtilsStock.ToInt(TextUtilsStock.ExcuteScalar($"SELECT count(*) AS Count FROM[ShiStock].[dbo].[HistoryShelfMotor] WHERE SerialNumber = N'{txtSerialNumber.Text.Trim()}'"));
			Qty = _shelfModel.ShelfNumber;
			//Cộng với số lượng bắn vào 
			Qty = Qty + 1;
			_shelfModel.ShelfNumber = Qty;
			ShelfBO.Instance.Update(_shelfModel);
			_historyShelfMotorModel = new HistoryShelfMotorModel();
			_historyShelfMotorModel.Worker = txtWorker.Text.Trim();
			_historyShelfMotorModel.Shelf = txtLocation.Text.Trim();
			_historyShelfMotorModel.SerialNumber = txtSerialNumber.Text.Trim();
			_historyShelfMotorModel.SaleNumBer = txtSaleNumber.Text.Trim();
			_historyShelfMotorModel.QtySale = TextUtilsStock.ToInt(txtQtySale.Text.Trim());
			_historyShelfMotorModel.QtyShelf = Qty;
			_historyShelfMotorModel.ArticleID = ArticleID;
			_historyShelfMotorModel.CreateDate = DateTime.Now;
			_lsthistoryShelfMotorModels.Add(_historyShelfMotorModel);
			//Add vào bảng AutoAddShelfMotor
			_autoAddShelfMotorModel = new AutoAddShelfMotorModel();
			_autoAddShelfMotorModel.Worker = _historyShelfMotorModel.Worker;
			_autoAddShelfMotorModel.Shelf = _historyShelfMotorModel.Shelf;
			_autoAddShelfMotorModel.SerialNumber = _historyShelfMotorModel.SerialNumber;
			_autoAddShelfMotorModel.SaleNumBer = _historyShelfMotorModel.SaleNumBer;
			_autoAddShelfMotorModel.QtySale = _historyShelfMotorModel.QtySale;
			_autoAddShelfMotorModel.QtyShelf = _historyShelfMotorModel.QtyShelf;
			_autoAddShelfMotorModel.ArticleID = _historyShelfMotorModel.ArticleID;
			_autoAddShelfMotorModel.CreateDate = DateTime.Now;
			_lstAddShelfMotorModels.Add(_autoAddShelfMotorModel);
			_LstSerialNumber.Add(_historyShelfMotorModel.SerialNumber);
			//Hiển thị số lượng thực tế khi cất vào kho TODO: check trong History
			txtRealQty.Text = TextUtilsStock.ToString(RowCountHistory + _lsthistoryShelfMotorModels.Count);
			//_motorShelf = new MotorShelfModel();
			//_motorShelf.Shelf = txtLocation.Text.Trim();
			//_motorShelf.SerialNumber = txtSerialNumber.Text.Trim();
			//_motorShelf.SaleNumBer = txtSaleNumber.Text.Trim();
			//_motorShelf.QtySale = _historyShelfMotorModel.QtySale;
			//_motorShelf.ArticleID = ArticleID;
			//_lstMotorShelf.Add(_motorShelf);
			//Hiển thị số lượng thực tế trên giá 
			_lstUCShelf[UC].LoadColor(Qty, txtLocation.Text.Trim());


			txtSerialNumber.Text = "";
			txtSerialNumber.Focus();
			txtSerialNumber.SelectAll();
			if (TextUtilsStock.ToInt(txtRealQty.Text.Trim()) == TextUtilsStock.ToInt(txtQtySale.Text.Trim()))
			{
				btnSave_Click_1(null, null);
			}
		}

		private void btnSave_Click_1(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc muốn cất dữ liệu?", "Cất?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No) return;
			foreach (HistoryShelfMotorModel item in _lsthistoryShelfMotorModels)
			{
				HistoryShelfMotorBO.Instance.Insert(item);
			}
			foreach (AutoAddShelfMotorModel item in _lstAddShelfMotorModels)
			{
				AutoAddShelfMotorBO.Instance.Insert(item);
			}
			_lstAddShelfMotorModels.Clear();
			_lsthistoryShelfMotorModels.Clear();
			_LstSerialNumber.Clear();
			txtLocation.Text = "";
			txtSerialNumber.Text = "";
			txtSaleNumber.Text = "";
			txtRealQty.Text = "";
			txtQtySale.Text = "";
			txtLocation.Focus();
		}

		private void txtWorker_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txtLocation.Focus();
		}

		private void txtLocation_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txtSerialNumber.Focus();
		}
	}
}
