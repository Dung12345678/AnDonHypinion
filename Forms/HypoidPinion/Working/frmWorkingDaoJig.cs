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
	public partial class frmWorkingDaoJig : _Forms
	{
		public frmWorkingDaoJig()
		{
			InitializeComponent();
		}

		private void frmWorking_Load(object sender, EventArgs e)
		{
			cboLoai.SelectedIndex = 0;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			frmWorkingDaoJigDetail frm = new frmWorkingDaoJigDetail();
			frm._Loai = cboLoai.SelectedIndex;
			int id = TextUtils.ToInt(treeData.FocusedNode.GetValue(colParentID));
			if (id > 0)
			{
				frm._GroupID = 0;
			}
			else
			{
				frm._GroupID = TextUtils.ToInt(treeData.FocusedNode.GetValue(colIDTree));
			}
			frm.IDTree = TextUtils.ToInt(treeData.FocusedNode.GetValue(colIDTree));

			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadTreeData();
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			try
			{
				int SortOrder = TextUtils.ToInt(grvDetail.GetFocusedRowCellValue(colSortOrder));
				string CD = TextUtils.ToString(grvDetail.GetFocusedRowCellValue(colProductStepCode));
				int id = TextUtils.ToInt(grvDetail.GetFocusedRowCellValue(colWorkingID));
				if (id == 0) return;
				KnifeJigWorkingModel model = (KnifeJigWorkingModel)KnifeJigWorkingBO.Instance.GetObjectByID(id);
				frmWorkingDaoJigDetail frm = new frmWorkingDaoJigDetail();
				frm._Loai = cboLoai.SelectedIndex;
				int idParent = TextUtils.ToInt(treeData.FocusedNode.GetValue(colParentID));
				if (idParent > 0)
				{
					frm._GroupID = 0;
				}
				else
				{
					frm._GroupID = TextUtils.ToInt(treeData.FocusedNode.GetValue(colIDTree));
				}
				frm._knifeJigWorkingModel = model;
				frm._CD = CD;
				if (frm.ShowDialog() == DialogResult.OK)
				{
					LoadTreeData();
				}
			}
			catch (Exception)
			{
			}
		}
		private void grdDetail_DoubleClick(object sender, EventArgs e)
		{
			if (grvDetail.RowCount > 0 && btnEdit.Enabled == true)
				btnEdit_Click(null, null);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				int ParentID = TextUtils.ToInt(treeData.FocusedNode.GetValue(colIDTree));
				int SortOrder = TextUtils.ToInt(grvDetail.GetFocusedRowCellValue(colSortOrder));
				string CD = TextUtils.ToString(grvDetail.GetFocusedRowCellValue(colProductStepCode));
				int id = TextUtils.ToInt(grvDetail.GetFocusedRowCellValue(colWorkingID));
				if (id == 0) return;

				if (MessageBox.Show("Bạn có chắc muốn xóa mục cần kiểm tra [" + grvDetail.GetFocusedRowCellValue(colWorkingName).ToString() + "] không?",
					  TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					return;
				KnifeJigWorkingBO.Instance.Delete(id);
				grvDetail.DeleteSelectedRows();


				//Xóa các thằng con thuộc thằng cha này đi
				TextUtilsHP.ExcuteSQL(string.Format("EXEC spUpdateKnifeJigWorking {0},{1}, 2,{2},N'{3}',{4},{5}", id, ParentID, SortOrder, CD, 0, 0));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadTreeData();
		}
		void LoadTreeData()
		{
			DataTable tbl = TextUtilsHP.GetDataTableFromSP("spLoadTreeData", new string[] { "@Type" }, new object[] { cboLoai.SelectedIndex });
			treeData.DataSource = tbl;
			treeData.KeyFieldName = "ID";
			treeData.PreviewFieldName = "KnifeCode";
			treeData.ExpandAll();

			//DevExpress.XtraTreeList.Nodes.TreeListNode currentNode = treeData.FindNodeByFieldValue("ID", _curentNode);
			//treeData.SetFocusedNode(currentNode);
		}

		private void btnCopyGroupProducts_Click(object sender, EventArgs e)
		{

		}
		private void treeData_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
		{
			int id = TextUtils.ToInt(treeData.FocusedNode.GetValue(colIDTree));
			if (id > 0)
			{
				LoadInfoSearch(id);
			}

		}
		void LoadInfoSearch(int id)
		{
			DataTable dt = TextUtilsHP.LoadDataFromSP("spLoadWorkingName", "LoadWorkingName", new string[] { "@KnifeDetailListID", "@Chk", "@Loai" }, new object[] { id, chkAll.Checked, cboLoai.SelectedIndex });
			grdDetail.DataSource = dt;
		}
		private void chkAll_CheckedChanged(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(treeData.FocusedNode.GetValue(colIDTree));
			if (id > 0)
			{
				LoadInfoSearch(id);
			}
		}
	}
}
