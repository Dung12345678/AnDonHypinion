namespace BMS
{
    partial class frmHistoryPartOutDetail
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
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colValueTypeText = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRealValue1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grdData = new DevExpress.XtraGrid.GridControl();
			this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStockID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShelf = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colArticleID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAccessory = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCreatDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRealQty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStockCDID = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			this.SuspendLayout();
			// 
			// gridColumn1
			// 
			this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.gridColumn1.AppearanceHeader.Options.UseFont = true;
			this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.gridColumn1.Caption = "Giá trị tiêu chuẩn";
			this.gridColumn1.FieldName = "StandardValue";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.OptionsColumn.AllowEdit = false;
			this.gridColumn1.OptionsColumn.AllowFocus = false;
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 1;
			this.gridColumn1.Width = 100;
			// 
			// colValueTypeText
			// 
			this.colValueTypeText.AppearanceCell.Options.UseTextOptions = true;
			this.colValueTypeText.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colValueTypeText.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colValueTypeText.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colValueTypeText.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colValueTypeText.AppearanceHeader.Options.UseFont = true;
			this.colValueTypeText.Caption = "Ghi chép";
			this.colValueTypeText.FieldName = "ValueTypeText";
			this.colValueTypeText.Name = "colValueTypeText";
			this.colValueTypeText.OptionsColumn.AllowEdit = false;
			this.colValueTypeText.OptionsColumn.AllowFocus = false;
			this.colValueTypeText.Visible = true;
			this.colValueTypeText.VisibleIndex = 2;
			this.colValueTypeText.Width = 70;
			// 
			// colRealValue1
			// 
			this.colRealValue1.AppearanceCell.Options.UseTextOptions = true;
			this.colRealValue1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRealValue1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colRealValue1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colRealValue1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.colRealValue1.AppearanceHeader.Options.UseFont = true;
			this.colRealValue1.AppearanceHeader.Options.UseTextOptions = true;
			this.colRealValue1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRealValue1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colRealValue1.Caption = "#";
			this.colRealValue1.FieldName = "RealValue1";
			this.colRealValue1.Name = "colRealValue1";
			this.colRealValue1.Visible = true;
			this.colRealValue1.VisibleIndex = 3;
			this.colRealValue1.Width = 85;
			// 
			// grdData
			// 
			this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grdData.Location = new System.Drawing.Point(3, 0);
			this.grdData.MainView = this.grvData;
			this.grdData.Name = "grdData";
			this.grdData.Size = new System.Drawing.Size(1018, 533);
			this.grdData.TabIndex = 30;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			// 
			// grvData
			// 
			this.grvData.ColumnPanelRowHeight = 40;
			this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colStockID,
            this.colShelf,
            this.colLo,
            this.colArticleID,
            this.colAccessory,
            this.colDescription,
            this.colCreatDate,
            this.colQty,
            this.colRealQty,
            this.colStockCDID});
			this.grvData.GridControl = this.grdData;
			this.grvData.Name = "grvData";
			this.grvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.grvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.grvData.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.grvData.OptionsBehavior.AllowIncrementalSearch = true;
			this.grvData.OptionsBehavior.Editable = false;
			this.grvData.OptionsView.ColumnAutoWidth = false;
			this.grvData.OptionsView.ShowGroupPanel = false;
			this.grvData.PaintStyleName = "Flat";
			this.grvData.RowHeight = 25;
			// 
			// colID
			// 
			this.colID.AppearanceCell.Options.UseTextOptions = true;
			this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colStockID
			// 
			this.colStockID.AppearanceCell.Options.UseTextOptions = true;
			this.colStockID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStockID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStockID.Caption = "StockID";
			this.colStockID.FieldName = "StockID";
			this.colStockID.Name = "colStockID";
			// 
			// colShelf
			// 
			this.colShelf.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colShelf.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colShelf.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colShelf.AppearanceCell.Options.UseBackColor = true;
			this.colShelf.AppearanceCell.Options.UseFont = true;
			this.colShelf.AppearanceCell.Options.UseTextOptions = true;
			this.colShelf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colShelf.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colShelf.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colShelf.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colShelf.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colShelf.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colShelf.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colShelf.AppearanceHeader.Options.UseBackColor = true;
			this.colShelf.AppearanceHeader.Options.UseBorderColor = true;
			this.colShelf.AppearanceHeader.Options.UseFont = true;
			this.colShelf.AppearanceHeader.Options.UseForeColor = true;
			this.colShelf.AppearanceHeader.Options.UseTextOptions = true;
			this.colShelf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colShelf.Caption = "Vị trí";
			this.colShelf.FieldName = "Shelf";
			this.colShelf.Name = "colShelf";
			this.colShelf.OptionsColumn.AllowEdit = false;
			this.colShelf.Visible = true;
			this.colShelf.VisibleIndex = 2;
			this.colShelf.Width = 89;
			// 
			// colLo
			// 
			this.colLo.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colLo.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colLo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colLo.AppearanceCell.Options.UseBackColor = true;
			this.colLo.AppearanceCell.Options.UseFont = true;
			this.colLo.AppearanceCell.Options.UseTextOptions = true;
			this.colLo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colLo.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colLo.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colLo.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colLo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colLo.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colLo.AppearanceHeader.Options.UseBackColor = true;
			this.colLo.AppearanceHeader.Options.UseBorderColor = true;
			this.colLo.AppearanceHeader.Options.UseFont = true;
			this.colLo.AppearanceHeader.Options.UseForeColor = true;
			this.colLo.AppearanceHeader.Options.UseTextOptions = true;
			this.colLo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLo.Caption = "Lo";
			this.colLo.FieldName = "Lo";
			this.colLo.Name = "colLo";
			this.colLo.OptionsColumn.AllowEdit = false;
			this.colLo.Visible = true;
			this.colLo.VisibleIndex = 4;
			this.colLo.Width = 199;
			// 
			// colArticleID
			// 
			this.colArticleID.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colArticleID.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colArticleID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colArticleID.AppearanceCell.Options.UseBackColor = true;
			this.colArticleID.AppearanceCell.Options.UseFont = true;
			this.colArticleID.AppearanceCell.Options.UseTextOptions = true;
			this.colArticleID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colArticleID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colArticleID.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colArticleID.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colArticleID.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colArticleID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colArticleID.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colArticleID.AppearanceHeader.Options.UseBackColor = true;
			this.colArticleID.AppearanceHeader.Options.UseBorderColor = true;
			this.colArticleID.AppearanceHeader.Options.UseFont = true;
			this.colArticleID.AppearanceHeader.Options.UseForeColor = true;
			this.colArticleID.AppearanceHeader.Options.UseTextOptions = true;
			this.colArticleID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colArticleID.Caption = "ArticleID";
			this.colArticleID.FieldName = "ArticleID";
			this.colArticleID.Name = "colArticleID";
			this.colArticleID.OptionsColumn.AllowEdit = false;
			this.colArticleID.Visible = true;
			this.colArticleID.VisibleIndex = 0;
			this.colArticleID.Width = 108;
			// 
			// colAccessory
			// 
			this.colAccessory.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colAccessory.AppearanceCell.Options.UseFont = true;
			this.colAccessory.AppearanceCell.Options.UseTextOptions = true;
			this.colAccessory.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colAccessory.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colAccessory.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colAccessory.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colAccessory.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colAccessory.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colAccessory.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colAccessory.AppearanceHeader.Options.UseBackColor = true;
			this.colAccessory.AppearanceHeader.Options.UseBorderColor = true;
			this.colAccessory.AppearanceHeader.Options.UseFont = true;
			this.colAccessory.AppearanceHeader.Options.UseForeColor = true;
			this.colAccessory.AppearanceHeader.Options.UseTextOptions = true;
			this.colAccessory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colAccessory.Caption = "Accessory";
			this.colAccessory.FieldName = "Accessory";
			this.colAccessory.Name = "colAccessory";
			this.colAccessory.OptionsColumn.AllowEdit = false;
			this.colAccessory.Visible = true;
			this.colAccessory.VisibleIndex = 5;
			this.colAccessory.Width = 213;
			// 
			// colDescription
			// 
			this.colDescription.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colDescription.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colDescription.AppearanceCell.Options.UseBackColor = true;
			this.colDescription.AppearanceCell.Options.UseFont = true;
			this.colDescription.AppearanceCell.Options.UseTextOptions = true;
			this.colDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDescription.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colDescription.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colDescription.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colDescription.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colDescription.AppearanceHeader.Options.UseBackColor = true;
			this.colDescription.AppearanceHeader.Options.UseBorderColor = true;
			this.colDescription.AppearanceHeader.Options.UseFont = true;
			this.colDescription.AppearanceHeader.Options.UseForeColor = true;
			this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
			this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDescription.Caption = "Mô tả";
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.OptionsColumn.AllowEdit = false;
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 1;
			this.colDescription.Width = 234;
			// 
			// colCreatDate
			// 
			this.colCreatDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colCreatDate.AppearanceCell.Options.UseFont = true;
			this.colCreatDate.AppearanceCell.Options.UseTextOptions = true;
			this.colCreatDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCreatDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colCreatDate.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colCreatDate.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colCreatDate.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colCreatDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colCreatDate.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colCreatDate.AppearanceHeader.Options.UseBackColor = true;
			this.colCreatDate.AppearanceHeader.Options.UseBorderColor = true;
			this.colCreatDate.AppearanceHeader.Options.UseFont = true;
			this.colCreatDate.AppearanceHeader.Options.UseForeColor = true;
			this.colCreatDate.AppearanceHeader.Options.UseTextOptions = true;
			this.colCreatDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCreatDate.Caption = "Thời gian";
			this.colCreatDate.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm";
			this.colCreatDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colCreatDate.FieldName = "CreatDate";
			this.colCreatDate.GroupFormat.FormatString = "d";
			this.colCreatDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colCreatDate.Name = "colCreatDate";
			this.colCreatDate.OptionsColumn.AllowEdit = false;
			this.colCreatDate.Visible = true;
			this.colCreatDate.VisibleIndex = 7;
			this.colCreatDate.Width = 117;
			// 
			// colQty
			// 
			this.colQty.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colQty.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colQty.AppearanceCell.Options.UseBackColor = true;
			this.colQty.AppearanceCell.Options.UseFont = true;
			this.colQty.AppearanceCell.Options.UseTextOptions = true;
			this.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQty.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colQty.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colQty.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colQty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colQty.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colQty.AppearanceHeader.Options.UseBackColor = true;
			this.colQty.AppearanceHeader.Options.UseBorderColor = true;
			this.colQty.AppearanceHeader.Options.UseFont = true;
			this.colQty.AppearanceHeader.Options.UseForeColor = true;
			this.colQty.AppearanceHeader.Options.UseTextOptions = true;
			this.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQty.Caption = "Q\'TY";
			this.colQty.FieldName = "Qty";
			this.colQty.Name = "colQty";
			this.colQty.OptionsColumn.AllowEdit = false;
			this.colQty.Visible = true;
			this.colQty.VisibleIndex = 3;
			this.colQty.Width = 103;
			// 
			// colRealQty
			// 
			this.colRealQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colRealQty.AppearanceCell.Options.UseFont = true;
			this.colRealQty.AppearanceCell.Options.UseTextOptions = true;
			this.colRealQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRealQty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colRealQty.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colRealQty.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colRealQty.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colRealQty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colRealQty.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colRealQty.AppearanceHeader.Options.UseBackColor = true;
			this.colRealQty.AppearanceHeader.Options.UseBorderColor = true;
			this.colRealQty.AppearanceHeader.Options.UseFont = true;
			this.colRealQty.AppearanceHeader.Options.UseForeColor = true;
			this.colRealQty.AppearanceHeader.Options.UseTextOptions = true;
			this.colRealQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRealQty.Caption = "Real Q\'TY";
			this.colRealQty.FieldName = "RealQty";
			this.colRealQty.Name = "colRealQty";
			this.colRealQty.Visible = true;
			this.colRealQty.VisibleIndex = 6;
			this.colRealQty.Width = 98;
			// 
			// colStockCDID
			// 
			this.colStockCDID.Caption = "StockCDID";
			this.colStockCDID.FieldName = "StockCDID";
			this.colStockCDID.Name = "colStockCDID";
			// 
			// frmHistoryPartOutDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 536);
			this.Controls.Add(this.grdData);
			this.Name = "frmHistoryPartOutDetail";
			this.Text = "CHI TIẾT KIỂM TRA";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmHistoryCheckDetail_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colValueTypeText;
        private DevExpress.XtraGrid.Columns.GridColumn colRealValue1;
		private DevExpress.XtraGrid.GridControl grdData;
		private DevExpress.XtraGrid.Views.Grid.GridView grvData;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colStockID;
		private DevExpress.XtraGrid.Columns.GridColumn colShelf;
		private DevExpress.XtraGrid.Columns.GridColumn colLo;
		private DevExpress.XtraGrid.Columns.GridColumn colArticleID;
		private DevExpress.XtraGrid.Columns.GridColumn colAccessory;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colCreatDate;
		private DevExpress.XtraGrid.Columns.GridColumn colQty;
		private DevExpress.XtraGrid.Columns.GridColumn colRealQty;
		private DevExpress.XtraGrid.Columns.GridColumn colStockCDID;
	}
}