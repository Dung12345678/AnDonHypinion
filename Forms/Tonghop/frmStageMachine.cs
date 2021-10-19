using BMS;
using BMS.Business;
using BMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Tonghop
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
            DataTable dt = TextUtils.Select("Select * From Stage");
            grdStage.DataSource = dt;
        }
        int IDStage;
        void loadMachine()
        {
             IDStage = TextUtils.ToInt(grvStage.GetFocusedRowCellValue(colID));
            DataTable dt = TextUtils.Select($"Select * From Machine where StageID = {IDStage}");
            grdMachine.DataSource = dt;
        }
        private void grvStage_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            loadMachine();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            MachineModel model = new MachineModel();
          
            for (int i = 0; i < grvMachine.RowCount; i++)
            {
                int ID = TextUtils.ToInt(grvMachine.GetRowCellValue(i, colIDMachine));
                if (ID > 0)
                    model = (MachineModel)MachineBO.Instance.FindByPK(ID);
                model.MachineCode = TextUtils.ToString(grvMachine.GetRowCellValue(i, colMachineCode));
                model.MachineName = TextUtils.ToString(grvMachine.GetRowCellValue(i, colMachineName));
                model.StageID = IDStage;
                if (ID > 0)
                    MachineBO.Instance.Update(model);
                else 
                    MachineBO.Instance.Insert(model);
            }
            
        }
    }
}
