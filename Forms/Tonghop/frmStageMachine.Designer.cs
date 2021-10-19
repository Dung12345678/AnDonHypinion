
namespace Forms.Tonghop
{
    partial class frmStageMachine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grdStage = new DevExpress.XtraGrid.GridControl();
            this.grvStage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStageCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStageName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdMachine = new DevExpress.XtraGrid.GridControl();
            this.grvMachine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDMachine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMachineCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMachineName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvStage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMachine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave1
            // 
            this.btnSave1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave1.Location = new System.Drawing.Point(12, 12);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(110, 39);
            this.btnSave1.TabIndex = 1;
            this.btnSave1.Text = "SAVE";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.55155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.44846F));
            this.tableLayoutPanel1.Controls.Add(this.grdStage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grdMachine, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1115, 584);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // grdStage
            // 
            this.grdStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStage.Location = new System.Drawing.Point(3, 3);
            this.grdStage.MainView = this.grvStage;
            this.grdStage.Name = "grdStage";
            this.grdStage.Size = new System.Drawing.Size(245, 578);
            this.grdStage.TabIndex = 0;
            this.grdStage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvStage});
            // 
            // grvStage
            // 
            this.grvStage.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colStageCode,
            this.colStageName});
            this.grvStage.GridControl = this.grdStage;
            this.grvStage.Name = "grvStage";
            this.grvStage.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.grvStage.OptionsView.ShowGroupPanel = false;
            this.grvStage.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvStage_FocusedRowChanged);
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.AppearanceHeader.Options.UseForeColor = true;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colStageCode
            // 
            this.colStageCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStageCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colStageCode.AppearanceHeader.Options.UseFont = true;
            this.colStageCode.AppearanceHeader.Options.UseForeColor = true;
            this.colStageCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colStageCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStageCode.Caption = "Mã công đoạn";
            this.colStageCode.FieldName = "StageCode";
            this.colStageCode.Name = "colStageCode";
            this.colStageCode.Visible = true;
            this.colStageCode.VisibleIndex = 0;
            // 
            // colStageName
            // 
            this.colStageName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStageName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colStageName.AppearanceHeader.Options.UseFont = true;
            this.colStageName.AppearanceHeader.Options.UseForeColor = true;
            this.colStageName.AppearanceHeader.Options.UseTextOptions = true;
            this.colStageName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStageName.Caption = "Tên công đoạn";
            this.colStageName.FieldName = "StageName";
            this.colStageName.Name = "colStageName";
            this.colStageName.Visible = true;
            this.colStageName.VisibleIndex = 1;
            // 
            // grdMachine
            // 
            this.grdMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMachine.Location = new System.Drawing.Point(254, 3);
            this.grdMachine.MainView = this.grvMachine;
            this.grdMachine.Name = "grdMachine";
            this.grdMachine.Size = new System.Drawing.Size(858, 578);
            this.grdMachine.TabIndex = 1;
            this.grdMachine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMachine});
            // 
            // grvMachine
            // 
            this.grvMachine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDMachine,
            this.colMachineCode,
            this.colMachineName});
            this.grvMachine.GridControl = this.grdMachine;
            this.grvMachine.Name = "grvMachine";
            this.grvMachine.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.grvMachine.OptionsView.ShowGroupPanel = false;
            // 
            // colIDMachine
            // 
            this.colIDMachine.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIDMachine.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colIDMachine.AppearanceHeader.Options.UseFont = true;
            this.colIDMachine.AppearanceHeader.Options.UseForeColor = true;
            this.colIDMachine.AppearanceHeader.Options.UseTextOptions = true;
            this.colIDMachine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIDMachine.Caption = "ID";
            this.colIDMachine.FieldName = "ID";
            this.colIDMachine.Name = "colIDMachine";
            // 
            // colMachineCode
            // 
            this.colMachineCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMachineCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colMachineCode.AppearanceHeader.Options.UseFont = true;
            this.colMachineCode.AppearanceHeader.Options.UseForeColor = true;
            this.colMachineCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colMachineCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMachineCode.Caption = "Mã máy";
            this.colMachineCode.FieldName = "MachineCode";
            this.colMachineCode.Name = "colMachineCode";
            this.colMachineCode.Visible = true;
            this.colMachineCode.VisibleIndex = 0;
            // 
            // colMachineName
            // 
            this.colMachineName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMachineName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colMachineName.AppearanceHeader.Options.UseFont = true;
            this.colMachineName.AppearanceHeader.Options.UseForeColor = true;
            this.colMachineName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMachineName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMachineName.Caption = "Tên máy";
            this.colMachineName.FieldName = "MachineName";
            this.colMachineName.Name = "colMachineName";
            this.colMachineName.Visible = true;
            this.colMachineName.VisibleIndex = 1;
            // 
            // frmStageMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSave1);
            this.Name = "frmStageMachine";
            this.Text = "CÔNG ĐOẠN VÀ MÁY";
            this.Load += new System.EventHandler(this.frmStageMachine_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvStage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMachine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl grdStage;
        private DevExpress.XtraGrid.Views.Grid.GridView grvStage;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colStageCode;
        private DevExpress.XtraGrid.Columns.GridColumn colStageName;
        private DevExpress.XtraGrid.GridControl grdMachine;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMachine;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMachine;
        private DevExpress.XtraGrid.Columns.GridColumn colMachineCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMachineName;
    }
}