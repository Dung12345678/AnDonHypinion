using BMS;
using HP.Business;
using HP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmStageMachine : _Forms
	{
		public frmStageMachine()
		{
			InitializeComponent();
		}

		private void frmStageMachine_Load(object sender, EventArgs e)
		{
			loadMaster();
		}
		void loadMaster()
		{
			DataTable dt = TextUtilsHP.Select("Select * From Stage");
			grdStage.DataSource = dt;
		}
		int IDStage;
		void loadMachine()
		{
			IDStage = TextUtilsHP.ToInt(grvStage.GetFocusedRowCellValue(colID));
			DataTable dt = TextUtilsHP.Select($"Select * From Machine where StageID = {IDStage}");
			grdMachine.DataSource = dt;
		}
		private void grvStage_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			loadMachine();
		}
		private void frmStageMachine_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void btnSaveCD_Click(object sender, EventArgs e)
		{
			grvStage.FocusedRowHandle = 0;
			StageModel model = new StageModel();
			for (int i = 0; i < grvStage.RowCount; i++)
			{
				int ID = TextUtilsHP.ToInt(grvStage.GetRowCellValue(i, colID));
				if (ID > 0)
					model = (StageModel)StageBO.Instance.FindByPK(ID);
				model.StageCode = TextUtilsHP.ToString(grvStage.GetRowCellValue(i, colStageCode));
				model.StageName = TextUtilsHP.ToString(grvStage.GetRowCellValue(i, colStageName));
				if (ID > 0)
				{
					StageBO.Instance.Update(model);
				}
				else
				{
					StageBO.Instance.Insert(model);
				}
			}
			loadMaster();
		}

		private void btnDeleteCD_Click(object sender, EventArgs e)
		{
			int ID = TextUtilsHP.ToInt(grvStage.GetFocusedRowCellValue(colID));
			StageBO.Instance.Delete(ID);
			MessageBox.Show("Xóa thành công");
			loadMaster();
		}

		private void btnSaveMachine_Click(object sender, EventArgs e)
		{
			grvMachine.FocusedRowHandle = 0;
			MachineModel model = new MachineModel();

			for (int i = 0; i < grvMachine.RowCount; i++)
			{
				int ID = TextUtilsHP.ToInt(grvMachine.GetRowCellValue(i, colIDMachine));
				if (ID > 0)
					model = (MachineModel)MachineBO.Instance.FindByPK(ID);
				model.MachineCode = TextUtilsHP.ToString(grvMachine.GetRowCellValue(i, colMachineCode));
				model.MachineName = TextUtilsHP.ToString(grvMachine.GetRowCellValue(i, colMachineName));
				model.StageID = IDStage;
				if (ID > 0)
				{
					MachineBO.Instance.Update(model);
				}
				else
				{
					MachineBO.Instance.Insert(model);
				}
			}
			loadMachine();
		}

		private void btnDelMachine_Click(object sender, EventArgs e)
		{
			int ID = TextUtilsHP.ToInt(grvMachine.GetFocusedRowCellValue(colIDMachine));
			MachineBO.Instance.Delete(ID);
			MessageBox.Show("Xóa thành công");
			loadMachine();
		}
	}
}
