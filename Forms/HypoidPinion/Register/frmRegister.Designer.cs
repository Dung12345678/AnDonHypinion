
namespace BMS
{
    partial class frmRegister
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cboMaHang = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grdData = new DevExpress.XtraGrid.GridControl();
			this.grvData = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
			this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colKnifeCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colKnifeName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colOk = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colKnifeDetailListID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colNameTool = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colSTD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colMin = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colMax = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colType = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colRegisterID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.label2 = new System.Windows.Forms.Label();
			this.cboKnifeDetailList = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboMaHang.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
			this.toolStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tên hàng hóa";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cboMaHang);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(892, 69);
			this.panel1.TabIndex = 74;
			// 
			// cboMaHang
			// 
			this.cboMaHang.EditValue = " ";
			this.cboMaHang.Location = new System.Drawing.Point(159, 13);
			this.cboMaHang.Name = "cboMaHang";
			this.cboMaHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboMaHang.Properties.Appearance.Options.UseFont = true;
			this.cboMaHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboMaHang.Properties.View = this.gridView1;
			this.cboMaHang.Size = new System.Drawing.Size(470, 40);
			this.cboMaHang.TabIndex = 77;
			this.cboMaHang.EditValueChanged += new System.EventHandler(this.cboMaHang_EditValueChanged);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCode,
            this.colName});
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			// 
			// colCode
			// 
			this.colCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colCode.AppearanceCell.Options.UseFont = true;
			this.colCode.AppearanceCell.Options.UseTextOptions = true;
			this.colCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colCode.AppearanceHeader.Options.UseFont = true;
			this.colCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colCode.Caption = "Mã hàng";
			this.colCode.FieldName = "Code";
			this.colCode.Name = "colCode";
			this.colCode.Visible = true;
			this.colCode.VisibleIndex = 0;
			// 
			// colName
			// 
			this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colName.AppearanceCell.Options.UseFont = true;
			this.colName.AppearanceCell.Options.UseTextOptions = true;
			this.colName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colName.AppearanceHeader.Options.UseFont = true;
			this.colName.AppearanceHeader.Options.UseTextOptions = true;
			this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colName.Caption = "Tên hàng";
			this.colName.FieldName = "Name";
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 1;
			// 
			// grdData
			// 
			this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdData.Location = new System.Drawing.Point(0, 129);
			this.grdData.MainView = this.grvData;
			this.grdData.Name = "grdData";
			this.grdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
			this.grdData.Size = new System.Drawing.Size(892, 527);
			this.grdData.TabIndex = 75;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			// 
			// grvData
			// 
			this.grvData.Appearance.HeaderPanel.BackColor = System.Drawing.Color.MediumBlue;
			this.grvData.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
			this.grvData.Appearance.HeaderPanel.Options.UseBackColor = true;
			this.grvData.Appearance.HeaderPanel.Options.UseForeColor = true;
			this.grvData.BandPanelRowHeight = 30;
			this.grvData.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
			this.grvData.ColumnPanelRowHeight = 25;
			this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colKnifeCode,
            this.colKnifeName,
            this.colOk,
            this.colKnifeDetailListID,
            this.colNameTool,
            this.colSTD,
            this.colMin,
            this.colMax,
            this.colType,
            this.colRegisterID});
			this.grvData.GridControl = this.grdData;
			this.grvData.Name = "grvData";
			this.grvData.OptionsView.ShowGroupPanel = false;
			this.grvData.OptionsView.ShowIndicator = false;
			this.grvData.RowHeight = 20;
			// 
			// gridBand1
			// 
			this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridBand1.AppearanceHeader.Options.UseFont = true;
			this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
			this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridBand1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridBand1.Caption = "DANH SÁCH DỤNG CỤ KIỂM TRA";
			this.gridBand1.Columns.Add(this.colKnifeCode);
			this.gridBand1.Columns.Add(this.colKnifeName);
			this.gridBand1.Columns.Add(this.colOk);
			this.gridBand1.Name = "gridBand1";
			this.gridBand1.VisibleIndex = 0;
			this.gridBand1.Width = 225;
			// 
			// colKnifeCode
			// 
			this.colKnifeCode.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
			this.colKnifeCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colKnifeCode.AppearanceCell.Options.UseBackColor = true;
			this.colKnifeCode.AppearanceCell.Options.UseFont = true;
			this.colKnifeCode.AppearanceCell.Options.UseTextOptions = true;
			this.colKnifeCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeCode.AppearanceHeader.BackColor = System.Drawing.Color.MediumBlue;
			this.colKnifeCode.AppearanceHeader.BackColor2 = System.Drawing.Color.Transparent;
			this.colKnifeCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colKnifeCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colKnifeCode.AppearanceHeader.Options.UseBackColor = true;
			this.colKnifeCode.AppearanceHeader.Options.UseFont = true;
			this.colKnifeCode.AppearanceHeader.Options.UseForeColor = true;
			this.colKnifeCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colKnifeCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colKnifeCode.Caption = "MÃ DỤNG CỤ";
			this.colKnifeCode.FieldName = "KnifeCode";
			this.colKnifeCode.Name = "colKnifeCode";
			this.colKnifeCode.Visible = true;
			// 
			// colKnifeName
			// 
			this.colKnifeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colKnifeName.AppearanceCell.Options.UseFont = true;
			this.colKnifeName.AppearanceCell.Options.UseTextOptions = true;
			this.colKnifeName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
			this.colKnifeName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colKnifeName.AppearanceHeader.Options.UseFont = true;
			this.colKnifeName.AppearanceHeader.Options.UseForeColor = true;
			this.colKnifeName.AppearanceHeader.Options.UseTextOptions = true;
			this.colKnifeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.colKnifeName.Caption = "TÊN DỤNG CỤ";
			this.colKnifeName.FieldName = "KnifeName";
			this.colKnifeName.Name = "colKnifeName";
			this.colKnifeName.Visible = true;
			// 
			// colOk
			// 
			this.colOk.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colOk.AppearanceCell.Options.UseFont = true;
			this.colOk.AppearanceCell.Options.UseTextOptions = true;
			this.colOk.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colOk.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colOk.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
			this.colOk.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colOk.AppearanceHeader.Options.UseFont = true;
			this.colOk.AppearanceHeader.Options.UseForeColor = true;
			this.colOk.AppearanceHeader.Options.UseTextOptions = true;
			this.colOk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colOk.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colOk.Caption = "KHẢ DỤNG";
			this.colOk.ColumnEdit = this.repositoryItemCheckEdit1;
			this.colOk.FieldName = "Ok";
			this.colOk.Name = "colOk";
			this.colOk.OptionsFilter.AllowFilter = false;
			this.colOk.Visible = true;
			// 
			// repositoryItemCheckEdit1
			// 
			this.repositoryItemCheckEdit1.AutoHeight = false;
			this.repositoryItemCheckEdit1.Caption = "Check";
			this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
			// 
			// colKnifeDetailListID
			// 
			this.colKnifeDetailListID.Caption = "KnifeDetailListID";
			this.colKnifeDetailListID.FieldName = "ID";
			this.colKnifeDetailListID.Name = "colKnifeDetailListID";
			this.colKnifeDetailListID.Visible = true;
			// 
			// colNameTool
			// 
			this.colNameTool.Caption = "Name";
			this.colNameTool.FieldName = "Name";
			this.colNameTool.Name = "colNameTool";
			// 
			// colSTD
			// 
			this.colSTD.Caption = "STD";
			this.colSTD.FieldName = "Std";
			this.colSTD.Name = "colSTD";
			// 
			// colMin
			// 
			this.colMin.Caption = "Min";
			this.colMin.FieldName = "Min";
			this.colMin.Name = "colMin";
			// 
			// colMax
			// 
			this.colMax.Caption = "Max";
			this.colMax.FieldName = "Max";
			this.colMax.Name = "colMax";
			this.colMax.Visible = true;
			// 
			// colType
			// 
			this.colType.Caption = "Type";
			this.colType.FieldName = "Type";
			this.colType.Name = "colType";
			// 
			// colRegisterID
			// 
			this.colRegisterID.Caption = "RegisterID";
			this.colRegisterID.FieldName = "ID1";
			this.colRegisterID.Name = "colRegisterID";
			// 
			// toolStrip2
			// 
			this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
			this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave});
			this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip2.Location = new System.Drawing.Point(0, 72);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip2.Size = new System.Drawing.Size(70, 54);
			this.toolStrip2.TabIndex = 74;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold);
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(69, 51);
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(542, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Chọn dụng cụ";
			// 
			// cboKnifeDetailList
			// 
			this.cboKnifeDetailList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboKnifeDetailList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboKnifeDetailList.FormattingEnabled = true;
			this.cboKnifeDetailList.Items.AddRange(new object[] {
            "Dao",
            "Jig",
            "Khuôn",
            "Thước"});
			this.cboKnifeDetailList.Location = new System.Drawing.Point(691, 85);
			this.cboKnifeDetailList.Name = "cboKnifeDetailList";
			this.cboKnifeDetailList.Size = new System.Drawing.Size(189, 26);
			this.cboKnifeDetailList.TabIndex = 76;
			this.cboKnifeDetailList.SelectedIndexChanged += new System.EventHandler(this.cboKnifeDetailList_SelectedIndexChanged);
			// 
			// frmRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(892, 658);
			this.Controls.Add(this.cboKnifeDetailList);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.toolStrip2);
			this.Controls.Add(this.grdData);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmRegister";
			this.Text = "Đăng kí mã hàng";
			this.Load += new System.EventHandler(this.frmProductdetail_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboMaHang.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView grvData;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKnifeCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKnifeName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKnifeDetailListID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNameTool;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSTD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMin;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMax;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colType;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRegisterID;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOk;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.SearchLookUpEdit cboMaHang;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colCode;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private System.Windows.Forms.ComboBox cboKnifeDetailList;
		private System.Windows.Forms.ToolStripButton btnSave;
	}
}