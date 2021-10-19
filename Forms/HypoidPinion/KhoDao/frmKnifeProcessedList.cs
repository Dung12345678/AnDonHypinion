using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HP.Business;
using HP.Model;

namespace BMS
{
	public partial class frmKnifeProcessedList : _Forms
	{
		#region Variables
		private KnifeProcessedListModel knifeProcessedList = new KnifeProcessedListModel();
		public int knifeID = 0;
		string fileSavePath = Application.StartupPath + @"\Machine.txt";
		int prevRow;
		DataTable dtKnifeList;
		public string _KnifeCode = "";
		string Knife = "";

		#endregion

		#region Methods
		public frmKnifeProcessedList()
		{
			InitializeComponent();
			if (File.Exists(fileSavePath) == false)
			{
				File.Create(fileSavePath);
			}
		}
		private void frmKnifeSharpenList_Load(object sender, EventArgs e)
		{
			LoadAllComboboxData();
			LoadData();
			if (knifeID != 0)
			{
				txtKnifeList.Text = _KnifeCode;
				LoadDataToForm();
				cKnifeList_Leave(null, null);
			}
			txtWorker.Focus();
			txtMachine.Text = File.ReadAllText(Application.StartupPath + @"\Machine.txt");
		}

		void LoadListUsers()
		{
			DataTable dt = TextUtilsHP.Select(cGlobalFunction.GetWithSelectionQuery(new string[] { "ID", "PartCode", "PartName", "CreateDate" }, "Part", "CreateDate"));
			cboPart.Properties.DataSource = dt;
			cboPart.Properties.DisplayMember = "PartCode";
			cboPart.Properties.ValueMember = "ID";
		}
		void LoadListKnifeList()
		{
			//tách chuỗi trong mã dao nhập trên Line
			string[] Value = txtKnifeList.Text.Trim().Split(',');
			if (Value.Count() >= 3)
			{
				Knife = Value[0] + "," + Value[1] + "," + Value[2];
				string sql = $"SELECT ID, KnifeCode, STD, ATC FROM dbo.KnifeDetailList WHERE Status = 1 and KnifeCode=N'{Knife}'";
				dtKnifeList = TextUtilsHP.Select(sql);
			}
			if (dtKnifeList.Rows.Count <= 0)
			{
				MessageBox.Show("Không tìm thấy mã dao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtKnifeList.Text = "";
				txtKnifeList.Focus();
				return;
			}
		}

		void LoadAllComboboxData()
		{
			LoadListUsers();
			LoadListKnifeList();

			//DataTable dt = TextUtilsHP.Select(cGlobalFunction.GetWithSelectionQuery(new string[] { "ID", "MachineCode", "MachineName", "StageCode" }, "Machine", "MachineCode"));
			//txtMachine.Properties.DataSource = dt;
			//txtMachine.Properties.DisplayMember = "MachineCode";
			//txtMachine.Properties.ValueMember = "ID";
		}

		void LoadData()
		{
			string sql = "SELECT kdl.*, Status = (CASE k.Status WHEN 1 THEN N'Còn sử dụng' WHEN 0 THEN N'Đã hủy' END),p.PartName FROM dbo.KnifeProcessedList AS kdl join dbo.KnifeDetailList AS k on kdl.KnifeID = k.ID LEFT JOIN dbo.Part p ON kdl.PartID=p.ID Order by ID desc";
			DataTable arr = TextUtilsHP.Select(sql);
			dtgvKnifeProcessedList.DataSource = arr;
		}

		void LoadDataToForm()
		{
			if (dtKnifeList.Rows.Count > 0)
				txtKnifeList.Text = TextUtilsHP.ToString(dtKnifeList.Rows[0]["KnifeCode"]);
		}

		void ClearFormData()
		{
			txbGoodsCode.Text = "";
			txtKnifeList.Text = "";
			txtOrderCode.Text = "";
		}

		bool ValidateForm()
		{
			/*if (cKnifeList.EditValue == null)
			{
				MessageBox.Show("Vui lòng nhập mã dao!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}*/

			if (cboPart.EditValue == null)
			{
				MessageBox.Show("Vui lòng chọn bộ phận!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (string.IsNullOrEmpty(txtKnifeList.Text))
			{
				MessageBox.Show("Vui lòng điền mã dao!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (dtKnifeList.Rows.Count <= 0)
			{
				MessageBox.Show("Không tìm thấy mã Dao!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			KnifeDetailListModel currentModel = (KnifeDetailListModel)KnifeDetailListBO.Instance.FindByPK(TextUtilsHP.ToInt64(dtKnifeList.Rows[0]["ID"]));
			if (currentModel.CurrentATC == currentModel.ATC)
			{
				if (MessageBox.Show("Mã dao này không thể tiếp tục sử dụng! \n Bạn có muốn hủy mã dao này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					frmKnifeDisposed frm = new frmKnifeDisposed();
					frm.knifeID = currentModel.ID;
					if (frm.ShowDialog() == DialogResult.OK)
					{
						knifeProcessedList = new KnifeProcessedListModel();
						ClearFormData();
						LoadData();
					}
				}
				return false;
			}
			if (currentModel.CurrentSTD == currentModel.STD)
			{
				if (MessageBox.Show("Mã dao này cần được mài trước khi sử dụng! \n Bạn có muốn mài mã dao này ngay bây giờ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					// Mai dao
					frmKnifeSharpen frm = new frmKnifeSharpen();
					frm.knifeID = TextUtilsHP.ToInt(dtKnifeList.Rows[0]["ID"]);
					if (frm.ShowDialog() == DialogResult.OK)
					{
						knifeProcessedList = new KnifeProcessedListModel();
						ClearFormData();
						LoadData();
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
					knifeProcessedList.KnifeCode = txtKnifeList.Text.Trim();
					knifeProcessedList.KnifeID = TextUtilsHP.ToInt(dtKnifeList.Rows[0]["ID"]);
					knifeProcessedList.Worker = TextUtilsHP.ToString(txtWorker.Text);
					knifeProcessedList.GoodsCode = txbGoodsCode.Text.Trim();
					knifeProcessedList.MachineCode = txtMachine.Text.Trim();
					knifeProcessedList.OrderCode = txtOrderCode.Text.Trim();
					knifeProcessedList.PartID = TextUtils.ToInt(cboPart.EditValue);
					knifeProcessedList.PartCode = cboPart.Text.Trim();
					knifeProcessedList.KnifeCodeReal = Knife;
					// đếm số lần gia công giao trên PGN
					int Count = TextUtilsHP.ToInt(TextUtilsHP.ExcuteScalar($"SELECT COUNT(*) FROM [HypoidPinion].[dbo].[ProductKnife] WHERE OrderMachining=N'{knifeProcessedList.OrderCode}'  AND ArticleID=N'{knifeProcessedList.GoodsCode}' "));
					knifeProcessedList.Quantity = Count;
					if (TextUtilsHP.ToInt(dtKnifeList.Rows[0]["STD"]) < Count)
					{
						if (MessageBox.Show($"Số lượng gia công thực tế: {Count} vượt quá số lượng gia công quy định: {TextUtilsHP.ToInt(dtKnifeList.Rows[0]["STD"])} bạn có muốn mài dao không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
						{
							// Mai dao
							frmKnifeSharpen frm = new frmKnifeSharpen();
							frm.knifeID = TextUtilsHP.ToInt(dtKnifeList.Rows[0]["ID"]);
							if (frm.ShowDialog() == DialogResult.OK)
							{
								knifeProcessedList = new KnifeProcessedListModel();
								ClearFormData();
								LoadData();
							}
						}
						else
						{
							return false;
						}
					}

					//Insert vào bảng KnifeProcessedList và cập nhật số lượng theo DaoID
					TextUtilsHP.ExcuteProcedure("spKnifeAddProcess",
									new string[] { "@knifeID", "@knifeCode", "@worker", "@productCode", "@machineCode", "@quantity", "@orderCode", "@partID", "@KnifeCodeReal" },
									new object[] { knifeProcessedList.KnifeID, knifeProcessedList.KnifeCode, knifeProcessedList.Worker, knifeProcessedList.GoodsCode, knifeProcessedList.MachineCode, knifeProcessedList.Quantity, knifeProcessedList.OrderCode, knifeProcessedList.PartID, Knife });
					//Nếu Count > 0 update số lượng vào gia công dao
					//if (Count > 0)
					//{
					//	KnifeDetailListModel knifeDetailListModel = new KnifeDetailListModel();
					//	knifeDetailListModel = (KnifeDetailListModel)KnifeDetailListBO.Instance.FindByAttribute("KnifeCode", txtKnifeList.Text.Trim())[0];
					//	knifeDetailListModel.CurrentSTD += Count;
					//	knifeDetailListModel.TotalNumber += Count;
					//	KnifeDetailListBO.Instance.Update(knifeDetailListModel);

					//	//Insert số lượng trên PGN vào bảng gia công	
					//	knifeProcessedList.Worker = "PGN";
					//	knifeProcessedList.Quantity = Count;
					//	knifeProcessedList.DateProcess = DateTime.Now;
					//	KnifeProcessedListBO.Instance.Insert(knifeProcessedList);
					//}
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


		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}

		private void catVaThemOiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}

		/*	private void timer1_Tick(object sender, EventArgs e)
			{
				txbTime.Text = string.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
			}
	*/
		private void cWorker_EditValueChanged(object sender, EventArgs e)
		{
			//if (!string.IsNullOrEmpty(cboDepartmentCode.Text))
			//{
			//	DataRowView selectData = (DataRowView)cboDepartmentCode.GetSelectedDataRow();
			//	string departmentCode = (string)selectData.Row.ItemArray[6];
			//	txtOrderCode.Text = departmentCode;

			//}
			txtOrderCode.Focus();
		}

		private void frmKnifeSharpenList_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (SaveData())
			{
				knifeProcessedList = new KnifeProcessedListModel();
				ClearFormData();
				LoadData();
			}
		}

		private void cKnifeList_Leave(object sender, EventArgs e)
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

		private void cMachine_Leave(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtMachine.Text))
			{
				txtMachine.BackColor = Color.White;
			}
			else
			{
				txtMachine.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void cWorker_Leave(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cboPart.Text))
			{
				cboPart.BackColor = Color.White;
			}
			else
			{
				cboPart.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void txbDepartmentCode_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtOrderCode.Text))
			{
				txtOrderCode.BackColor = Color.White;
			}
			else
			{
				txtOrderCode.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void gvKnifeProcessedList_DoubleClick(object sender, EventArgs e)
		{
			knifeID = TextUtilsHP.ToInt(gvKnifeProcessedList.GetFocusedRowCellValue(colKnifeID));
			if (knifeID == 0) return;
			LoadDataToForm();
		}
		#endregion

		private void txbQuantity_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txtOrderCode.Focus();
		}

		private void txtKnifeList_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			LoadListKnifeList();
			if (dtKnifeList.Rows.Count <= 0)
			{
				MessageBox.Show("Không tìm thấy mã Dao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			btnSave.Focus();
		}

		private void txtWorker_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			cboPart.Focus();
		}

		private void txtOrder_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txbGoodsCode.Focus();
		}

		private void txtWorker_TextChanged(object sender, EventArgs e)
		{
			if (!string.Equals(txtWorker.Text, ""))
			{
				txtWorker.BackColor = Color.White;
			}
			else
			{
				txtWorker.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void txbGoodsCode_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txbGoodsCode.Text))
			{
				txbGoodsCode.BackColor = Color.White;
			}
			else
			{
				txbGoodsCode.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void txbGoodsCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txtKnifeList.Focus();
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

		private void txtMachine_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtMachine.Text))
			{
				txtMachine.BackColor = Color.White;
			}
			else
			{
				txtMachine.BackColor = Color.FromArgb(255, 153, 255);
			}
		}

		private void txtMachine_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			File.WriteAllText(fileSavePath, txtMachine.Text.Trim());
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (SaveData())
			{
				knifeProcessedList = new KnifeProcessedListModel();
				ClearFormData();
				LoadData();
				txtOrderCode.Focus();
			}
		}
	}
}
