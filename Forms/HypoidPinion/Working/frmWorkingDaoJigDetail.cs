using HP.Business;
using HP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmWorkingDaoJigDetail : _Forms
	{
		// Loại = 0 Dao ; = 1 Jig ; = 2 Khuôn (để hiển thị nhóm ParentID == 0)
		public int _Loai;
		public int _GroupID;
		public string _CD = "";
		public int IDTree;
		public KnifeJigWorkingModel _knifeJigWorkingModel = new KnifeJigWorkingModel();
		public KnifeJigWorkingModel _knifeJigWorkingModelOld = new KnifeJigWorkingModel();

		public frmWorkingDaoJigDetail()
		{
			InitializeComponent();
		}
		void loadGroup()
		{
			// Load dụng cụ có parentID = 0 trong bảng KnifeDetailList
			DataTable dt = TextUtilsHP.GetDataTableFromSP("spLoadGroup", new string[] { "@Type" }, new object[] { _Loai });
			cboGroup.Properties.DataSource = dt;
			cboGroup.Properties.DisplayMember = "KnifeCode";
			cboGroup.Properties.ValueMember = "ID";
		}
		/// <summary>
		/// Load dữ liệu vào form
		/// </summary>
		void loadData()
		{
			if (_knifeJigWorkingModel.ID == 0)
			{
				txtSortOrder.Value = 1;
			}

			txtMax.Value = _knifeJigWorkingModel.MaxValue;
			txtMin.Value = _knifeJigWorkingModel.MinValue;
			txtName.Text = _knifeJigWorkingModel.WorkingName;
			txtPeriodValue.Text = _knifeJigWorkingModel.PeriodValue;
			txtSortOrder.Value = _knifeJigWorkingModel.SortOrder;
			txtUnit.Text = _knifeJigWorkingModel.Unit;
			cboValueType.SelectedIndex = _knifeJigWorkingModel.ValueType;

			txtCD.Text = _knifeJigWorkingModel.ProductStepCode;
			if (txtCD.Text == "") txtCD.Text = _CD.Trim();
			cboGroup.EditValue = _knifeJigWorkingModel.KnifeDetailListID;
			cboCheckValueType.SelectedIndex = _knifeJigWorkingModel.CheckValueType;

		}

		private void frmWorkingDetail_Load(object sender, EventArgs e)
		{

			LoadKnifeJigWorkingModelOld();
			loadGroup();
			loadData();
			if (_knifeJigWorkingModel.ID == 0)
			{
				cboGroup.EditValue = IDTree;
				txtCD.Focus();
				return;
			}
			txtName.Focus();
		}
		void LoadKnifeJigWorkingModelOld()
		{
			_knifeJigWorkingModelOld.ID = _knifeJigWorkingModel.ID;
			_knifeJigWorkingModelOld.KnifeDetailListID = _knifeJigWorkingModel.KnifeDetailListID;
			_knifeJigWorkingModelOld.WorkingName = _knifeJigWorkingModel.WorkingName;
			_knifeJigWorkingModelOld.ValueType = _knifeJigWorkingModel.ValueType;
			_knifeJigWorkingModelOld.ValueTypeName = _knifeJigWorkingModel.ValueTypeName;
			_knifeJigWorkingModelOld.PeriodValue = _knifeJigWorkingModel.PeriodValue;
			_knifeJigWorkingModelOld.MinValue = _knifeJigWorkingModel.MinValue;
			_knifeJigWorkingModelOld.MaxValue = _knifeJigWorkingModel.MaxValue;
			_knifeJigWorkingModelOld.SortOrder = _knifeJigWorkingModel.SortOrder;
			_knifeJigWorkingModelOld.CreatedBy = _knifeJigWorkingModel.CreatedBy;
			_knifeJigWorkingModelOld.CreatedDate = _knifeJigWorkingModel.CreatedDate;
			_knifeJigWorkingModelOld.UpdatedBy = _knifeJigWorkingModel.UpdatedBy;
			_knifeJigWorkingModelOld.UpdatedDate = _knifeJigWorkingModel.UpdatedDate;
			_knifeJigWorkingModelOld.CheckValueType = _knifeJigWorkingModel.CheckValueType;
			_knifeJigWorkingModelOld.ProductStepCode = _knifeJigWorkingModel.ProductStepCode;
			_knifeJigWorkingModelOld.Unit = _knifeJigWorkingModel.Unit;
		}

		/// <summary>
		/// Validate trước khi cất dữ liệu
		/// </summary>
		/// <returns></returns>
		private bool ValidateForm()
		{
			if (cboGroup.EditValue == null)
			{
				MessageBox.Show("Xin hãy chọn dụng cụ.", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (txtCD.Text.Trim() == "")
			{
				MessageBox.Show("Xin hãy điền công đoạn.", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			if (cboValueType.SelectedIndex < 0)
			{
				MessageBox.Show("Xin hãy chọn kiểu kiểm tra.", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			if (txtName.Text.Trim() == "")
			{
				MessageBox.Show("Xin hãy điền Mô tả công đoạn.", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			string sql1 = "";
			if (_knifeJigWorkingModel.ID > 0)
			{
				sql1 = $"SELECT ID from KnifeJigWorking WHERE SortOrder = '{txtSortOrder.Value}' and ID <>'{_knifeJigWorkingModel.ID}' and ProductStepCode={txtCD.Text.Trim()} ";

			}
			else
			{
				sql1 = $"SELECT ID from KnifeJigWorking WHERE SortOrder = '{txtSortOrder.Value}' and ProductStepCode={txtCD.Text.Trim()}";
			}
			int id = TextUtilsHP.ToInt(LibIE.ExcuteScalar(sql1));
			if (id > 0)
			{
				MessageBox.Show("Trùng STT", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				// return false;
			}
			return true;
		}

		/// <summary>
		/// Cất dữ liệu
		/// </summary>
		/// <returns></returns>
		bool saveData()
		{
			if (!ValidateForm())
				return false;

			_knifeJigWorkingModel.KnifeDetailListID = TextUtilsHP.ToInt(cboGroup.EditValue);
			_knifeJigWorkingModel.ProductStepCode = txtCD.Text.Trim().ToUpper();
			_knifeJigWorkingModel.WorkingName = txtName.Text.Trim();
			_knifeJigWorkingModel.SortOrder = TextUtilsHP.ToInt(txtSortOrder.Value);
			_knifeJigWorkingModel.CheckValueType = cboCheckValueType.SelectedIndex;
			_knifeJigWorkingModel.Unit = txtUnit.Text.Trim();
			_knifeJigWorkingModel.ValueType = cboValueType.SelectedIndex;
			_knifeJigWorkingModel.ValueTypeName = cboValueType.SelectedIndex == 0 ? "Check mark" : "Giá trị\n数値";
			_knifeJigWorkingModel.MaxValue = TextUtilsHP.ToDecimal(txtMax.Value);
			_knifeJigWorkingModel.MinValue = TextUtilsHP.ToDecimal(txtMin.Value);
			if (_knifeJigWorkingModel.ValueType == 0)//checkmark
			{
				_knifeJigWorkingModel.PeriodValue = txtPeriodValue.Text.Trim();
			}
			else
			{
				if (_knifeJigWorkingModel.CheckValueType == 1)//giá trị dạng số
				{
					if (_knifeJigWorkingModel.MinValue == _knifeJigWorkingModel.MaxValue)
					{
						_knifeJigWorkingModel.PeriodValue = _knifeJigWorkingModel.MaxValue.ToString("n3");
					}
					else
					{
						_knifeJigWorkingModel.PeriodValue = _knifeJigWorkingModel.MinValue.ToString("n3") + "~" + _knifeJigWorkingModel.MaxValue.ToString("n3");
					}
				}
				else // Giá trị dạng ký tự
				{
					_knifeJigWorkingModel.PeriodValue = txtPeriodValue.Text.Trim();
				}
			}

			if (_knifeJigWorkingModel.ID > 0)
			{
				KnifeJigWorkingBO.Instance.Update(_knifeJigWorkingModel);
				//Update những trường con theo trường cha
				//TextUtilsHP.ExcuteSQL(string.Format("EXEC spUpdateKnifeJigWorking {0},{1},1,{2},N'{3}',{4},N'{5}'", _knifeJigWorkingModel.ID, _GroupID, _knifeJigWorkingModel.SortOrder, _knifeJigWorkingModel.ProductStepCode, _knifeJigWorkingModelOld.SortOrder, _knifeJigWorkingModelOld.ProductStepCode));
			}
			else
			{
				_knifeJigWorkingModel.ID = (int)KnifeJigWorkingBO.Instance.Insert(_knifeJigWorkingModel);
				//Insert những trường con theo trường cha
				//TextUtilsHP.ExcuteSQL(string.Format("EXEC CreateInsertKnifeJigWorking {0}", _knifeJigWorkingModel.ID));
			}
			return true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (saveData())
				this.DialogResult = DialogResult.OK;
		}

		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (saveData())
			{
				_knifeJigWorkingModel = new KnifeJigWorkingModel();
				loadData();
				txtName.Focus();
			}
		}
		private void frmWorkingDetail_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void txtMin_ValueChanged(object sender, EventArgs e)
		{
			txtPeriodValue.Text = txtMin.Value + "~" + txtMax.Value;
		}

		private void txtMax_ValueChanged(object sender, EventArgs e)
		{
			txtPeriodValue.Text = txtMin.Value + "~" + txtMax.Value;
		}
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSave_Click(null, null);
		}

		private void saveNewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
