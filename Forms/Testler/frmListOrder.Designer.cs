namespace BMS
{
	partial class frmListOrder
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
			this.label1 = new System.Windows.Forms.Label();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.grdData = new DevExpress.XtraGrid.GridControl();
			this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOrderCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHYP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWorker = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colConfirmer = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBatch = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDateLR = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Blue;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1370, 49);
			this.label1.TabIndex = 0;
			this.label1.Text = "DANH SÁCH ORDERS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
			this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEndDate.Location = new System.Drawing.Point(316, 68);
			this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(124, 26);
			this.dtpEndDate.TabIndex = 30;
			this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(232, 72);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 20);
			this.label2.TabIndex = 31;
			this.label2.Text = "Đến ngày";
			// 
			// dtpFromDate
			// 
			this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
			this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFromDate.Location = new System.Drawing.Point(98, 68);
			this.dtpFromDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dtpFromDate.Name = "dtpFromDate";
			this.dtpFromDate.Size = new System.Drawing.Size(124, 26);
			this.dtpFromDate.TabIndex = 29;
			this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 72);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 20);
			this.label3.TabIndex = 32;
			this.label3.Text = "Từ ngày";
			// 
			// grdData
			// 
			this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grdData.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grdData.Location = new System.Drawing.Point(6, 109);
			this.grdData.MainView = this.grvData;
			this.grdData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grdData.Name = "grdData";
			this.grdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
			this.grdData.Size = new System.Drawing.Size(1370, 577);
			this.grdData.TabIndex = 33;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			this.grdData.Click += new System.EventHandler(this.grdData_Click);
			// 
			// grvData
			// 
			this.grvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.FocusedRow.Options.UseBackColor = true;
			this.grvData.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.grvData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.grvData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.HideSelectionRow.Options.UseBackColor = true;
			this.grvData.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.SelectedRow.Options.UseBackColor = true;
			this.grvData.ColumnPanelRowHeight = 40;
			this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderCode,
            this.colHYP,
            this.colWorker,
            this.colConfirmer,
            this.colBatch,
            this.colDateLR,
            this.colID});
			this.grvData.CustomizationFormBounds = new System.Drawing.Rectangle(1156, 205, 210, 312);
			this.grvData.GridControl = this.grdData;
			this.grvData.HorzScrollStep = 5;
			this.grvData.Name = "grvData";
			this.grvData.OptionsBehavior.AutoExpandAllGroups = true;
			this.grvData.OptionsCustomization.AllowRowSizing = true;
			this.grvData.OptionsFind.AlwaysVisible = true;
			this.grvData.OptionsFind.ShowCloseButton = false;
			this.grvData.OptionsSelection.MultiSelect = true;
			this.grvData.OptionsView.ColumnAutoWidth = false;
			this.grvData.OptionsView.RowAutoHeight = true;
			this.grvData.OptionsView.ShowAutoFilterRow = true;
			this.grvData.OptionsView.ShowFooter = true;
			this.grvData.OptionsView.ShowGroupPanel = false;
			this.grvData.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvData_RowClick);
			this.grvData.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grvData_RowCellClick);
			// 
			// colOrderCode
			// 
			this.colOrderCode.AppearanceCell.Options.UseTextOptions = true;
			this.colOrderCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colOrderCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colOrderCode.AppearanceHeader.Options.UseFont = true;
			this.colOrderCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colOrderCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colOrderCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colOrderCode.Caption = "Mã Order";
			this.colOrderCode.FieldName = "OrderCode";
			this.colOrderCode.Name = "colOrderCode";
			this.colOrderCode.OptionsColumn.AllowEdit = false;
			this.colOrderCode.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
			this.colOrderCode.Visible = true;
			this.colOrderCode.VisibleIndex = 0;
			this.colOrderCode.Width = 195;
			// 
			// colHYP
			// 
			this.colHYP.AppearanceCell.Options.UseTextOptions = true;
			this.colHYP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colHYP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colHYP.AppearanceHeader.Options.UseFont = true;
			this.colHYP.AppearanceHeader.Options.UseTextOptions = true;
			this.colHYP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colHYP.Caption = "Mã hàng";
			this.colHYP.FieldName = "HypCode";
			this.colHYP.Name = "colHYP";
			this.colHYP.OptionsColumn.AllowEdit = false;
			this.colHYP.Visible = true;
			this.colHYP.VisibleIndex = 1;
			this.colHYP.Width = 159;
			// 
			// colWorker
			// 
			this.colWorker.AppearanceCell.Options.UseTextOptions = true;
			this.colWorker.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colWorker.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colWorker.AppearanceHeader.Options.UseFont = true;
			this.colWorker.AppearanceHeader.Options.UseTextOptions = true;
			this.colWorker.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWorker.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colWorker.Caption = "Tên gia công";
			this.colWorker.FieldName = "WorkerCode";
			this.colWorker.Name = "colWorker";
			this.colWorker.OptionsColumn.AllowEdit = false;
			this.colWorker.Visible = true;
			this.colWorker.VisibleIndex = 2;
			this.colWorker.Width = 243;
			// 
			// colConfirmer
			// 
			this.colConfirmer.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colConfirmer.AppearanceHeader.Options.UseFont = true;
			this.colConfirmer.Caption = "Người xác nhận";
			this.colConfirmer.FieldName = "Confirmer";
			this.colConfirmer.Name = "colConfirmer";
			this.colConfirmer.Visible = true;
			this.colConfirmer.VisibleIndex = 3;
			this.colConfirmer.Width = 211;
			// 
			// colBatch
			// 
			this.colBatch.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colBatch.AppearanceHeader.Options.UseFont = true;
			this.colBatch.Caption = "Số lô";
			this.colBatch.FieldName = "Batch";
			this.colBatch.Name = "colBatch";
			this.colBatch.Visible = true;
			this.colBatch.VisibleIndex = 4;
			this.colBatch.Width = 192;
			// 
			// colDateLR
			// 
			this.colDateLR.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colDateLR.AppearanceHeader.Options.UseFont = true;
			this.colDateLR.AppearanceHeader.Options.UseTextOptions = true;
			this.colDateLR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDateLR.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDateLR.Caption = "Ngày lắp ráp";
			this.colDateLR.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
			this.colDateLR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colDateLR.FieldName = "DateLR";
			this.colDateLR.Name = "colDateLR";
			this.colDateLR.OptionsColumn.AllowEdit = false;
			this.colDateLR.Visible = true;
			this.colDateLR.VisibleIndex = 5;
			this.colDateLR.Width = 194;
			// 
			// colID
			// 
			this.colID.AppearanceCell.Options.UseTextOptions = true;
			this.colID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colID.AppearanceHeader.Options.UseTextOptions = true;
			this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// repositoryItemMemoEdit1
			// 
			this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
			this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
			// 
			// frmListOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 702);
			this.Controls.Add(this.grdData);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpFromDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "frmListOrder";
			this.Text = "LIST ORDER";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpFromDate;
		private System.Windows.Forms.Label label3;
		private DevExpress.XtraGrid.GridControl grdData;
		private DevExpress.XtraGrid.Views.Grid.GridView grvData;
		private DevExpress.XtraGrid.Columns.GridColumn colOrderCode;
		private DevExpress.XtraGrid.Columns.GridColumn colHYP;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colWorker;
		private DevExpress.XtraGrid.Columns.GridColumn colDateLR;
		private DevExpress.XtraGrid.Columns.GridColumn colConfirmer;
		private DevExpress.XtraGrid.Columns.GridColumn colBatch;
		private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
	}
}