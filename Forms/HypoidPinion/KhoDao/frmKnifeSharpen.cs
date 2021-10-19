using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HP.Business;
using HP.Model;

namespace BMS
{
    public partial class frmKnifeSharpen : _Forms
    {
        #region Variables
        private KnifeSharpeningDetailsModel knifeSharpeningModel = new KnifeSharpeningDetailsModel();
        public int knifeID = 0;
        DataTable dtKnifeDetailList;
        string Knife = "";
        int prevRow;
        #endregion
        #region Methods
        public frmKnifeSharpen()
        {
            InitializeComponent();
        }
        private void frmKnifeSharpen_Load(object sender, EventArgs e)
        {
            //LoadListKnifeList();
            LoadData();
            //LoadDataToForm();
            txtWoker.Focus();
        }

        void LoadListKnifeList()
        {
            //Tách chuỗi lấy mã dao
            string[] Value = txtKnifeList.Text.Trim().Split(',');
            if (Value.Count() >= 3)
            {
                Knife = Value[0] + "," + Value[1] + "," + Value[2];
                string sql = $"SELECT top 1 * FROM dbo.KnifeDetailList WHERE Status = 1 and KnifeCode=N'{Knife}'";
                dtKnifeDetailList = TextUtilsHP.Select(sql);
            }
            if (dtKnifeDetailList == null || dtKnifeDetailList.Rows.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy mã Dao", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKnifeList.Focus();
                txtKnifeList.SelectAll();
                return;
            }

        }

        void LoadData()
        {
            string sql = "SELECT kdl.*, u.UserCode, u.DepartmentCode, Type = (CASE k.Status WHEN 1 THEN N'Còn sử dụng' WHEN 0 THEN N'Đã hủy' END) FROM dbo.KnifeSharpeningDetails AS kdl, dbo.Users AS u, dbo.KnifeDetailList AS k WHERE kdl.WorkerID = u.ID AND kdl.KnifeID = k.ID";
            //string sql = "SELECT kdl.*, u.UserCode, u.DepartmentCode FROM dbo.KnifeSharpeningDetails AS kdl, dbo.Users AS u WHERE kdl.WorkerID = u.ID";
            DataTable arr = TextUtilsHP.Select(sql);
            dtgvKnifeSharpen.DataSource = arr;
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

        private void gvKnifeSharpen_DoubleClick(object sender, EventArgs e)
        {
            knifeID = TextUtilsHP.ToInt(gvKnifeSharpen.GetFocusedRowCellValue(colKnifeID));
            if (knifeID == 0) return;
            LoadDataToForm();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                knifeSharpeningModel = new KnifeSharpeningDetailsModel();
                ClearFormData();
                Knife = "";
                //LoadListKnifeList();
                LoadData();
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

            if (!string.IsNullOrEmpty(txtKnifeList.Text))
            {
                if (dtKnifeDetailList.Rows.Count <= 0) return;
                txtCurrentATC.Text = TextUtilsHP.ToString(dtKnifeDetailList.Rows[0]["CurrentATC"]);
                txtCurrentSTD.Text = TextUtilsHP.ToString(dtKnifeDetailList.Rows[0]["CurrentSTD"]);
                txtSTD.Text = TextUtilsHP.ToString(dtKnifeDetailList.Rows[0]["STD"]);
                txtRemainQty.Text = TextUtilsHP.ToString(dtKnifeDetailList.Rows[0]["RemainQty"]);
                txtTotalNumber.Text = TextUtilsHP.ToString(dtKnifeDetailList.Rows[0]["TotalNumber"]);
            }
            btnSave.Focus();
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
    }
}
