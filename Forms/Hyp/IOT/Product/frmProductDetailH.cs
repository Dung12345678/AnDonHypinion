using IE.Business;
using IE.Model;
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
	public partial class frmProductDetailH : _Forms
	{
		public ProductModel Product = new ProductModel();
		public int ProductGroupID { get; set; }

		public frmProductDetailH()
		{
			InitializeComponent();
		}
		void loadGroup()
		{
			DataTable dt = LibIE.Select("SELECT * FROM dbo.ProductGroup WITH(NOLOCK)");
			cboGroup.Properties.DataSource = dt;
			cboGroup.Properties.DisplayMember = "ProductGroupName";
			cboGroup.Properties.ValueMember = "ID";
		}


		/// <summary>
		/// Load dữ liệu vào form
		/// </summary>
		void loadData()
		{
			cboGroup.EditValue = Product.ProductGroupID;
			txtProductTypeCode.Text = Product.ProductTypeCode;
			txtCode.Text = Product.ProductCode;
			txtDes.Text = Product.ProductName;
			txtRatio.Text = Product.RatioCode;
			txtCoilCode.Text = Product.CoilCode;
			txtMotorCode.Text = Product.MotorCode;
			dtpDate.EditValue = Product.ProductDate;
			txtDienAp.Value = Product.DienAp;
			txtTanSo.Value = Product.TanSo;
			txtDongDienMax.Value = Product.DongDienMax;
			txtDongDienMin.Value = Product.DongDienMin;
			txtNhapLucMax.Value = Product.NhapLucMax;
			txtNhapLucMin.Value = Product.NhapLucMin;
			txtVongQuayMax.Value = Product.VongQuayMax;
			txtVongQuayMin.Value = Product.VongQuayMin;
			txtTiengOnMax.Value = Product.TiengOnMax;
			txtTiengOnMin.Value = Product.TiengOnMin;
			txtDoRungMax.Value = Product.DoRungFFTMax;
			txtDoRungMin.Value = Product.DoRungFFTMin;
			txtGunNumber.Value = Product.GunNumber;
			txtQtyOcBanGa.Value = Product.QtyOcBanGa;
			txtJobNumber.Value = Product.JobNumber;
			txtShootNumber.Value = Product.ShootNumber;
			txtBuLongNumber.Value = Product.BuLongNumber;
			txtSetForce.Value = Product.SetForce;
			txtXuatLucSealCap.Text = Product.XuatLucSealCap;
			txtLoaiMoNapDau.Text = Product.LoaiMoNapDau;
			txtLoaiMoBomHopSo.Text = Product.LoaiMoBomHopSo;
			txtLucCheckMin.Value = Product.LucCheckGearMin;
			txtLucCheckMax.Value = Product.LucCheckGearMax;

			txtEngineWeightMax.Value = TextUtils.ToDecimal(Product.EngineWeightMax);
			txtEngineWeightMin.Value= TextUtils.ToDecimal(Product.EngineWeightMin);
			txtEngineWeight.Text = TextUtils.ToString(Product.EngineWeight);
			//nvthao thêm ngày 03.01.2020
			//Thêm trường Đích lưu cho sản phẩm
			txtGoal.Text = Product.Goal;
		}

		private void frmWorkingDetail_Load(object sender, EventArgs e)
		{
			loadGroup();
			loadData();

			if (ProductGroupID > 0)
			{
				cboGroup.EditValue = ProductGroupID;
			}
		}

		/// <summary>
		/// Validate trước khi cất dữ liệu
		/// </summary>
		/// <returns></returns>
		private bool ValidateForm()
		{
			if (cboGroup.EditValue == null)
			{
				MessageBox.Show("Xin hãy chọn một nhóm sản phẩm.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (string.IsNullOrEmpty(txtProductTypeCode.Text.Trim()))
			{
				MessageBox.Show("Xin hãy nhập loại sản phẩm.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			if (txtCode.Text.Trim() == "")
			{
				MessageBox.Show("Xin hãy điền mã sản phẩm.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			else
			{
				DataTable dt;
				if (Product.ID > 0)
				{
					dt = LibIE.Select("select top 1 ProductCode from Product where ProductCode = '" + txtCode.Text.Trim() + "' and ID <> " + Product.ID);
				}
				else
				{
					dt = LibIE.Select("select top 1 ProductCode from Product where ProductCode = '" + txtCode.Text.Trim() + "'");
				}
				if (dt != null)
				{
					if (dt.Rows.Count > 0)
					{
						MessageBox.Show("Mã này đã tồn tại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return false;
					}
				}
			}
			if (txtDes.Text.Trim() == "")
			{
				MessageBox.Show("Xin hãy điền tên sản phẩm.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
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

			Product.ProductGroupID = TextUtils.ToInt(cboGroup.EditValue);//"NHÓM SẢN PHẨM"
			Product.ProductTypeCode = txtProductTypeCode.Text.Trim();//"LOẠI SẢN PHẨM#"
			Product.ProductCode = txtCode.Text.Trim(); //PRODUCT ID
			Product.ProductName = txtDes.Text.Trim();//MÔ TẢ SẢN PHẨM
			Product.RatioCode = txtRatio.Text.Trim();     //Giảm tốc   
			Product.ProductDate = TextUtils.ToDate2(dtpDate.EditValue);//NGÀY LẬP
			Product.XuatLucSealCap = txtXuatLucSealCap.Text.Trim();//"HƯỚNG TRỤC XUẤT LỰC SEAL CAP"
			Product.LoaiMoNapDau = txtLoaiMoNapDau.Text.Trim();//LOẠI MỠ NẮP DẦU
			Product.LoaiMoBomHopSo = txtLoaiMoBomHopSo.Text.Trim();//LOẠI MỠ BƠM HỘP SỐ
																   //"LỰC CHECK 1  NẮP - HỘP (N.m)"
			Product.LucCheckGearMin = txtLucCheckMin.Value;
			Product.LucCheckGearMax = txtLucCheckMax.Value;
			Product.GunNumber = TextUtils.ToInt(txtGunNumber.Value); //SÚNG
			Product.JobNumber = TextUtils.ToInt(txtJobNumber.Value);//JOB
			Product.QtyOcBanGa = TextUtils.ToInt(txtQtyOcBanGa.Value);   //BẮN GÁ
			Product.BuLongNumber = TextUtils.ToInt(txtBuLongNumber.Value);// SỐ LUỢNG BULONG
			Product.ShootNumber = TextUtils.ToInt(txtShootNumber.Value);//SỐ LẦN BẮN
			Product.SetForce = TextUtils.ToInt(txtSetForce.Value);// đặt lực
			Product.MotorCode = txtMotorCode.Text.Trim();    //MÃ MOTOR
			Product.CoilCode = txtCoilCode.Text.Trim();// Mã Coil
			Product.DienAp = txtDienAp.Value;//Điện áp (V)
			Product.TanSo = txtTanSo.Value;//Tần số (Hz)
										   //Dòng điện Io
			Product.DongDienMin = txtDongDienMin.Value;
			Product.DongDienMax = txtDongDienMax.Value;
			//Nhập lực Wo
			Product.NhapLucMax = txtNhapLucMax.Value;
			Product.NhapLucMin = txtNhapLucMin.Value;
			//Vòng quay
			Product.VongQuayMax = txtVongQuayMax.Value;
			Product.VongQuayMin = txtVongQuayMin.Value;
			// Tiếng ồn dB
			Product.TiengOnMax = txtTiengOnMax.Value;
			Product.TiengOnMin = txtTiengOnMin.Value;
			//Độ rung FFT
			Product.DoRungFFTMax = txtDoRungMax.Value;
			Product.DoRungFFTMin = txtDoRungMin.Value;

			// Trọng lượng sản phẩm khi có mỡ và đã lắp hoàn chỉnh
			Product.EngineWeightMax = TextUtils.ToDouble(txtEngineWeightMax.Value);
			Product.EngineWeightMin = TextUtils.ToDouble(txtEngineWeightMin.Value);
			Product.EngineWeight = TextUtils.ToDouble(txtEngineWeight.Text.Trim());

			Product.Goal = txtGoal.Text.Trim();// đích  
			if (Product.ID > 0)
			{
				WorkingBO.Instance.Update(Product);
			}
			else
			{
				Product.ID = (int)WorkingBO.Instance.Insert(Product);
				//Sinh các công đoạn và mục kiểm tra của sản phẩm theo định dạng của nhóm sản phẩm
				LibIE.ExcuteSQL(string.Format("EXEC dbo.CreateProductWorking_ByGroupID {0},{1}", Product.ProductGroupID, Product.ID));
			}
			/*
             * Cập nhật lại các mục check sản phẩm theo các rule quy định của các công đoạn
             */
			LibIE.ExcuteSQL(string.Format("EXEC spUpdateProductWorking_ByProductID_New {0},{1}", Product.ID, Product.MURATA == "3" ? 0 : 1));
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
				Product = new ProductModel();
				loadData();
			}
		}

		private void frmWorkingDetail_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void control_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
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
