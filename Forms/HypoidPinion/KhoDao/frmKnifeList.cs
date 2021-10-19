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
	public partial class frmKnifeList : _Forms
	{
		#region Variables
		int prevRow;
		#endregion

		#region Methods
		public frmKnifeList()
		{
			InitializeComponent();
		}
		void LoadData()
		{
			//	string sql = "SELECT KnifeDetailList.*, Users.UserCode, Users.DepartmentCode FROM dbo.KnifeDetailList, dbo.Users WHERE dbo.KnifeDetailList.WorkerID = dbo.Users.ID AND KnifeDetailList.Status = 1 AND  KnifeDetailList.Type = 0";
			dtpFrom.Value = dtpFrom.Value.Date.AddHours(0).AddMinutes(00).AddSeconds(00);
			dtpTo.Value = dtpTo.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
			DataTable arr = TextUtilsHP.GetDataTableFromSP("spLoadKnife", new string[] { "@DateStart", "@DateEnd", "@Text", "@Chk" }, new object[] { dtpFrom.Value, dtpTo.Value, txtFindDate.Text.Trim(), 1 });
			treeData.DataSource = arr;
			treeData.KeyFieldName = "ID";
			treeData.PreviewFieldName = "KnifeCode";
			treeData.ExpandAll();
		}

		void LoadUnavailableData()
		{
			//string sql = "SELECT KnifeDetailList.*, Users.UserCode, Users.DepartmentCode FROM dbo.KnifeDetailList, dbo.Users WHERE dbo.KnifeDetailList.WorkerID = dbo.Users.ID AND KnifeDetailList.Status = 0 AND  KnifeDetailList.Type = 0";
			//DataTable arr = TextUtilsHP.Select(sql);
			dtpFrom.Value = dtpFrom.Value.Date.AddHours(0).AddMinutes(00).AddSeconds(00);
			dtpTo.Value = dtpTo.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
			DataTable arr = TextUtilsHP.GetDataTableFromSP("spLoadKnife", new string[] { "@DateStart", "@DateEnd", "@Text", "@Chk" }, new object[] { dtpFrom.Value, dtpTo.Value, txtFindDate.Text.Trim(), 0 });
			treeData.DataSource = arr;
			treeData.KeyFieldName = "ID";
			treeData.PreviewFieldName = "KnifeCode";
			treeData.ExpandAll();
		}
		#endregion

		#region Events
		private void btnCreateKnife_Click(object sender, EventArgs e)
		{
			if (cboLoai.SelectedIndex == 0)
			{
				frmAddEditKnife frm = new frmAddEditKnife(cGlobalVariables.Add);
				if (frm.ShowDialog() == DialogResult.OK)
				{
					cbShowUnavailable_CheckedChanged(null, null);
				}
			}
			else if (cboLoai.SelectedIndex == 1)
			{
				frmAddEditJig frm = new frmAddEditJig();
				if (frm.ShowDialog() == DialogResult.OK)
				{
					LoadAll();
				}
			}
			else if (cboLoai.SelectedIndex == 2)
			{
				frmShapeDetails frm = new frmShapeDetails();
				if (frm.ShowDialog() == DialogResult.OK)
				{
					LoadAll();
				}
			}
		}

		private void btnEditKnife_Click(object sender, EventArgs e)
		{
			if (cboLoai.SelectedIndex == 0) //Sửa Dao
			{
				int id = TextUtilsHP.ToInt(treeData.FocusedNode.GetValue(colID));
				if (id == 0) return;
				KnifeDetailListModel model = (KnifeDetailListModel)KnifeDetailListBO.Instance.FindByPK(id);

				frmAddEditKnife frm = new frmAddEditKnife(cGlobalVariables.Edit);
				frm.knifeDetailListModel = model;
				if (frm.ShowDialog() == DialogResult.OK)
				{
					cbShowUnavailable_CheckedChanged(null, null);
				}
			}
			else if (cboLoai.SelectedIndex == 1) //Sửa Jig
			{
				int id = TextUtilsHP.ToInt(treeData.FocusedNode.GetValue(colID));
				if (id == 0) return;
				KnifeDetailListModel model = (KnifeDetailListModel)KnifeDetailListBO.Instance.FindByPK(id);
				frmAddEditJig frm = new frmAddEditJig();
				frm._KnifeDetailListModel = model;
				if (frm.ShowDialog() == DialogResult.OK)
				{
					LoadAll();
				}
			}
			else if (cboLoai.SelectedIndex == 2)
			{
				int id = TextUtilsHP.ToInt(treeData.FocusedNode.GetValue(colID));
				if (id == 0) return;
				KnifeDetailListModel model = (KnifeDetailListModel)KnifeDetailListBO.Instance.FindByPK(id);
				frmShapeDetails frm = new frmShapeDetails();
				frm._KnifeDetailListModel = model;
				if (frm.ShowDialog() == DialogResult.OK)
				{
					LoadData();
				}
			}
		}

		private void btnDelKnife_Click(object sender, EventArgs e)
		{
			int strID = TextUtilsHP.ToInt(treeData.FocusedNode.GetValue(colID));
			string str = TextUtilsHP.ToString(treeData.FocusedNode.GetValue("KnifeCode"));

			try
			{
				if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa dụng cụ [{0}] không?", str), TextUtilsHP.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (cboLoai.SelectedIndex == 0)
					{
						if (KnifeSharpeningDetailsBO.Instance.CheckExist("KnifeID", strID))
						{
							MessageBox.Show("Dao đã được sử dụng! Vui lòng chọn hủy dao thay cho xóa", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
							return;
						}
						else
						{
							KnifeDetailListBO.Instance.Delete(strID);
							treeData.DeleteSelectedNodes();
						}
					}
					else
					{
						KnifeDetailListBO.Instance.Delete(strID);
						treeData.DeleteSelectedNodes();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hệ thống!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			cbShowUnavailable_CheckedChanged(null, null);
		}

		private void frmKnifeList_Load(object sender, EventArgs e)
		{
			cboLoai.SelectedIndex = 0;
			LoadData();
		}
		private void gvKnife_DoubleClick(object sender, EventArgs e)
		{
			btnEditKnife_Click(null, null);
		}

		private void cbShowUnavailable_CheckedChanged(object sender, EventArgs e)
		{
			if (cbShowUnavailable.Checked)
			{
				LoadUnavailableData();
			}
			else
			{
				LoadData();
			}
		}

		private void btnDisposeTool_Click(object sender, EventArgs e)
		{
			if (treeData.AllNodesCount <= 0) return;
			TextUtilsHP.ToInt(treeData.FocusedNode.GetValue(colParentID));
			int id = TextUtilsHP.ToInt(treeData.FocusedNode.GetValue(colID));
			if (id == 0) return;

			frmKnifeDisposed frm = new frmKnifeDisposed();
			frm.knifeID = id;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				cbShowUnavailable_CheckedChanged(null, null);
			}
		}
		private void btnSharpenKnife_Click(object sender, EventArgs e)
		{
			//if (treeData.AllNodesCount <= 0) return;
			//int id = TextUtilsHP.ToInt(treeData.FocusedNode.GetValue(colID));
			//if (id == 0) return;

			frmKnifeSharpen frm = new frmKnifeSharpen();
			//frm.knifeID = id;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				cbShowUnavailable_CheckedChanged(null, null);
			}
		}

		private void btnProcessTool_Click(object sender, EventArgs e)
		{
			//if (treeData.AllNodesCount <= 0) return;
			//int id = TextUtilsHP.ToInt(treeData.FocusedNode.GetValue(colID));
			string KnifeCode = TextUtilsHP.ToString(treeData.FocusedNode.GetValue(colKnifeCode));
			//if (id == 0) return;

			frmKnifeProcessedList frm = new frmKnifeProcessedList();
			//frm.knifeID = id;
			frm._KnifeCode = KnifeCode;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				cbShowUnavailable_CheckedChanged(null, null);
			}
		}
		private void btnProcessChart_Click(object sender, EventArgs e)
		{
			frmKnifeProcessedChart frm = new frmKnifeProcessedChart();
			frm.ShowDialog();
		}

		#endregion

		private void btnFindDate_Click(object sender, EventArgs e)
		{
			if (cboLoai.SelectedIndex == 0)
			{
				if (cbShowUnavailable.Checked)
				{
					LoadUnavailableData();
				}
				else
				{
					LoadData();
				}
			}
			else
			{
				LoadAll();
			}
		}

		private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboLoai.SelectedIndex == 0)
			{
				if (cbShowUnavailable.Checked)
				{
					LoadUnavailableData();
				}
				else
				{
					LoadData();
				}
				colATC.Visible = true;
				colSTD.Visible = true;
			}
			else
			{
				LoadAll();
				colATC.Visible = false;
				colSTD.Visible = false;
			}
		}
		void LoadAll()
		{
			dtpFrom.Value = dtpFrom.Value.Date.AddHours(0).AddMinutes(00).AddSeconds(00);
			dtpTo.Value = dtpTo.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
			DataTable arr = TextUtilsHP.GetDataTableFromSP(
											"spLoadAll",
											new string[] { "@DateStart", "@DateEnd", "@Text", "@Type" },
											new object[]{dtpFrom.Value.ToString("yyyy/MM/dd HH:mm:ss")
														, dtpTo.Value.ToString("yyyy/MM/dd HH:mm:ss")
														, txtFindDate.Text.Trim()
														, cboLoai.SelectedIndex });
			treeData.DataSource = arr;
			treeData.KeyFieldName = "ID";
			treeData.PreviewFieldName = "KnifeCode";
			treeData.ExpandAll();
		}
	}
}
