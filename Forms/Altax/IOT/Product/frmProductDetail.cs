using BMS.Business;
using BMS.Model;
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
    public partial class frmProductDetail : _Forms
    {
        public ProductModel Product = new ProductModel();
        public int ProductGroupID { get; set; }

        public frmProductDetail()
        {
            InitializeComponent();
        }
        void loadGroup()
        {
            DataTable dt = TextUtils.Select("SELECT * FROM dbo.ProductGroup WITH(NOLOCK)");
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
            txtPinNumber.Text = Product.PinNumber;
            txtPinNumberIN.Text = Product.PinNumberIN;
            txtCoilCode.Text = Product.CoilCode;
            txtMotorCode.Text = Product.MotorCode;
            txtLoaiMo.Text = Product.LoaiMo;
            txtLuongMo.Value = Product.LuongMo;
            txtMurata.Text = Product.MURATA;
            txtUnitMotor.Text = Product.UnitMotor;
            txtMauSon.Text = Product.MauSon;
            dtpDate.EditValue = Product.ProductDate;
            dtpMEDEDAY.EditValue = Product.MEDEDAY;
            txtHuongHopCau.Text = Product.HuongHopCau;

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
            txtQtyOcBanThat.Value = Product.QtyOcBanThat;
            txtJobNumber.Value = Product.JobNumber;
            txtShootNumber.Value = Product.ShootNumber;
            txtBuLongNumber.Value = Product.BuLongNumber;
            txtSetForce.Value = Product.SetForce;

            txtDifferenceMax.Value = Product.DifferenceMax;
            txtDifferenceMin.Value = Product.DifferenceMin;
            txtSizeSSSMax.Value = Product.SizeSSSMax;
            txtSizeSSSMin.Value = Product.SizeSSSMin;
            txtSpaceCenterMax.Value = Product.SpaceCenterMax;
            txtSpaceCenterMin.Value = Product.SpaceCenterMin;
            txtSpaceCycloidDiskMin.Value = Product.SpaceCycloidDiskMin;
            txtSpaceCycloidDiskMax.Value = Product.SpaceCycloidDiskMax;

            txtLucCheckGearMax.Value = Product.LucCheckGearMax;
            txtLucCheckGearMin.Value = Product.LucCheckGearMin;
            txtLucCheckGearMotorMax.Value = Product.LucCheckGearMotorMax;
            txtLucCheckGearMotorMin.Value = Product.LucCheckGearMotorMin;
            txtLucCheck3Max.Value = Product.LucCheck3Max;//Lực check cụm trục tốc độ thấp 511-512
            txtLucCheck3Min.Value = Product.LucCheck3Min;
            txtLucCheck4Max.Value = Product.LucCheck4Max;//Lực check phần xuất lực Naknishi
            txtLucCheck4Min.Value = Product.LucCheck4Min;
            txtLucCheck5Max.Value = Product.LucCheck5Max;//Lực check Ốc chặn mỡ Nakanishi, 6000
            txtLucCheck5Min.Value = Product.LucCheck5Min;

            txtDoDao1Max.Value = Product.DoDao1Max;//ĐẢO TRƯỚC ÉP VÒNG BI
            txtDoDao1Min.Value = Product.DoDao1Min;
            txtDoDao2Max.Value = Product.DoDao2Max;//ĐẢO SAU ÉP VÒNG BI
            txtDoDao2Min.Value = Product.DoDao2Min;
            txtDoDao3Max.Value = Product.DoDao3Max;
            txtDoDao3Min.Value = Product.DoDao3Min;
            txtDoDao4Max.Value = Product.DoDao4Max;
            txtDoDao4Min.Value = Product.DoDao4Min;

            txtLuongMo1Max.Value = Product.LuongMo1Max;//Mỡ cho trục tốc độ thấp
            txtLuongMo1Min.Value = Product.LuongMo1Min;//
            txtLuongMo2Max.Value = Product.LuongMo2Max;//Lượng mỡ cho hộp
            txtLuongMo2Min.Value = Product.LuongMo2Min;//
            txtLuongMo3Max.Value = Product.LuongMo3Max;//Mỡ cho vòng bi chịu tải & Carrier SSS
            txtLuongMo3Min.Value = Product.LuongMo3Min;//
            txtLuongMo4Max.Value = Product.LuongMo4Max;//Lượng mỡ cho vòng bi không tải
            txtLuongMo4Min.Value = Product.LuongMo4Min;//
            txtLuongMo5Max.Value = Product.LuongMo5Max;//Mỡ cho Carrier
            txtLuongMo5Min.Value = Product.LuongMo5Min;//
            txtLuongMo6Max.Value = Product.LuongMo6Max;//Mỡ cho hộp (Gram) ở công đoạn 3, số thứ tự 50 của 511,512
            txtLuongMo6Min.Value = Product.LuongMo6Min;//
            txtLuongMo7Max.Value = Product.LuongMo7Max;//
            txtLuongMo7Min.Value = Product.LuongMo7Min;//
        
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
                    dt = TextUtils.Select("select top 1 ProductCode from Product where ProductCode = '" + txtCode.Text.Trim() + "' and ID <> " + Product.ID);
                }
                else
                {
                    dt = TextUtils.Select("select top 1 ProductCode from Product where ProductCode = '" + txtCode.Text.Trim() + "'");
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

            Product.ProductGroupID = TextUtils.ToInt(cboGroup.EditValue);
            Product.ProductTypeCode = txtProductTypeCode.Text.Trim();
            Product.ProductCode = txtCode.Text.Trim();
            Product.ProductName = txtDes.Text.Trim();
            Product.RatioCode = txtRatio.Text.Trim();
            Product.PinNumber = txtPinNumber.Text.Trim();
            Product.PinNumberIN = txtPinNumberIN.Text.Trim();
            Product.CoilCode = txtCoilCode.Text.Trim();
            Product.MotorCode = txtMotorCode.Text.Trim();
            Product.LoaiMo = txtLoaiMo.Text.Trim();
            Product.LuongMo = txtLuongMo.Value;
            Product.MURATA = txtMurata.Text.Trim();
            Product.UnitMotor = txtUnitMotor.Text.Trim();
            Product.MauSon = txtMauSon.Text.Trim();
            Product.MEDEDAY = TextUtils.ToDate2(dtpMEDEDAY.EditValue);
            Product.ProductDate = TextUtils.ToDate2(dtpDate.EditValue);
            Product.HuongHopCau = txtHuongHopCau.Text.Trim();

            Product.DienAp = txtDienAp.Value;
            Product.TanSo = txtTanSo.Value;
            Product.DongDienMin = txtDongDienMin.Value;
            Product.DongDienMax = txtDongDienMax.Value;
            Product.NhapLucMax = txtNhapLucMax.Value;
            Product.NhapLucMin = txtNhapLucMin.Value;
            Product.VongQuayMax = txtVongQuayMax.Value;
            Product.VongQuayMin = txtVongQuayMin.Value;
            Product.TiengOnMax = txtTiengOnMax.Value;
            Product.TiengOnMin = txtTiengOnMin.Value;
            Product.DoRungFFTMax = txtDoRungMax.Value;
            Product.DoRungFFTMin = txtDoRungMin.Value;

            Product.GunNumber = TextUtils.ToInt(txtGunNumber.Value);
            Product.JobNumber = TextUtils.ToInt(txtJobNumber.Value);
            Product.QtyOcBanGa = TextUtils.ToInt(txtQtyOcBanGa.Value);
            Product.QtyOcBanThat = TextUtils.ToInt(txtQtyOcBanThat.Value);
            Product.BuLongNumber = TextUtils.ToInt(txtBuLongNumber.Value);
            Product.ShootNumber = TextUtils.ToInt(txtShootNumber.Value);
            Product.SetForce = TextUtils.ToInt(txtSetForce.Value);

            Product.DifferenceMax = txtDifferenceMax.Value;
            Product.DifferenceMin = txtDifferenceMin.Value;
            Product.SizeSSSMax = txtSizeSSSMax.Value;
            Product.SizeSSSMin = txtSizeSSSMin.Value;
            Product.SpaceCenterMax = txtSpaceCenterMax.Value;
            Product.SpaceCenterMin = txtSpaceCenterMin.Value;
            Product.SpaceCycloidDiskMin = txtSpaceCycloidDiskMin.Value;
            Product.SpaceCycloidDiskMax = txtSpaceCycloidDiskMax.Value;

            Product.LucCheckGearMax = txtLucCheckGearMax.Value;
            Product.LucCheckGearMin = txtLucCheckGearMin.Value;
            Product.LucCheckGearMotorMax = txtLucCheckGearMotorMax.Value;
            Product.LucCheckGearMotorMin = txtLucCheckGearMotorMin.Value;
            Product.LucCheck3Max = txtLucCheck3Max.Value;//Lực check cụm trục tốc độ thấp 511-512
            Product.LucCheck3Min = txtLucCheck3Min.Value;
            Product.LucCheck4Max = txtLucCheck4Max.Value;//Lực check phần xuất lực Naknishi
            Product.LucCheck4Min = txtLucCheck4Min.Value;
            Product.LucCheck5Max = txtLucCheck5Max.Value;//Lực check Ốc chặn mỡ Nakanishi, 6000
            Product.LucCheck5Min = txtLucCheck5Min.Value;

            Product.DoDao1Max = txtDoDao1Max.Value;//ĐẢO TRƯỚC ÉP VÒNG BI
            Product.DoDao1Min = txtDoDao1Min.Value;
            Product.DoDao2Max = txtDoDao2Max.Value;//ĐẢO SAU ÉP VÒNG BI
            Product.DoDao2Min = txtDoDao2Min.Value;
            Product.DoDao3Max = txtDoDao3Max.Value;
            Product.DoDao3Min = txtDoDao3Min.Value;
            Product.DoDao4Max = txtDoDao4Max.Value;
            Product.DoDao4Min = txtDoDao4Min.Value;

            Product.LuongMo1Max = txtLuongMo1Max.Value;//Mỡ cho trục tốc độ thấp
            Product.LuongMo1Min = txtLuongMo1Min.Value;//
            Product.LuongMo2Max = txtLuongMo2Max.Value;//Lượng mỡ cho hộp
            Product.LuongMo2Min = txtLuongMo2Min.Value;//
            Product.LuongMo3Max = txtLuongMo3Max.Value;//Mỡ cho vòng bi chịu tải & Carrier SSS
            Product.LuongMo3Min = txtLuongMo3Min.Value;//
            Product.LuongMo4Max = txtLuongMo4Max.Value;//Lượng mỡ cho vòng bi không tải
            Product.LuongMo4Min = txtLuongMo4Min.Value;//
            Product.LuongMo5Max = txtLuongMo5Max.Value;//Mỡ cho Carrier
            Product.LuongMo5Min = txtLuongMo5Min.Value;//
            Product.LuongMo6Max = txtLuongMo6Max.Value;//Mỡ cho hộp (Gram) ở công đoạn 3, số thứ tự 50 của 511,512
            Product.LuongMo6Min = txtLuongMo6Min.Value;//
            Product.LuongMo7Max = txtLuongMo7Max.Value;//
            Product.LuongMo7Min = txtLuongMo7Min.Value;//

            Product.Goal = txtGoal.Text.Trim();

            if (Product.ID > 0)
            {
                WorkingBO.Instance.Update(Product);
            }
            else
            {
                Product.ID = (int)WorkingBO.Instance.Insert(Product);
                //Sinh các công đoạn và mục kiểm tra của sản phẩm theo định dạng của nhóm sản phẩm
                TextUtils.ExcuteSQL(string.Format("EXEC dbo.CreateProductWorking_ByGroupID {0},{1}", Product.ProductGroupID, Product.ID));
            }

            /*
             * Cập nhật lại các mục check sản phẩm theo các rule quy định của các công đoạn
             */
            //TextUtils.ExcuteSQL(string.Format("EXEC spUpdateProductWorking_ByProductID {0},{1}", Product.ID, Product.MURATA == "3" ? 0 : 1));
            TextUtils.ExcuteSQL(string.Format("EXEC spUpdateProductWorking_ByProductID_New {0},{1}", Product.ID, Product.MURATA == "3" ? 0 : 1));
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(saveData())
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
