
namespace BMS
{
    partial class ucModel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.grdData1 = new DevExpress.XtraGrid.GridControl();
			this.grvData1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStand = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colstd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lbCurrentATC = new System.Windows.Forms.Label();
			this.lbSTD = new System.Windows.Forms.Label();
			this.lbNumberProduct = new System.Windows.Forms.Label();
			this.lbKnifeCode = new System.Windows.Forms.Label();
			this.lbGoodsCode = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.grdData = new DevExpress.XtraGrid.GridControl();
			this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colKnifeDetailCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRealValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStandardValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lbATC = new System.Windows.Forms.Label();
			this.lbCurrentSTD = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdData1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.grdData1, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbCurrentATC, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.lbSTD, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.lbNumberProduct, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lbKnifeCode, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbGoodsCode, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.grdData, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbATC, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.lbCurrentSTD, 3, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1225, 308);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// grdData1
			// 
			this.grdData1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdData1.Location = new System.Drawing.Point(878, 0);
			this.grdData1.MainView = this.grvData1;
			this.grdData1.Margin = new System.Windows.Forms.Padding(0);
			this.grdData1.Name = "grdData1";
			this.tableLayoutPanel1.SetRowSpan(this.grdData1, 3);
			this.grdData1.Size = new System.Drawing.Size(347, 308);
			this.grdData1.TabIndex = 10;
			this.grdData1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData1});
			// 
			// grvData1
			// 
			this.grvData1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colStand,
            this.colstd});
			this.grvData1.GridControl = this.grdData1;
			this.grvData1.Name = "grvData1";
			this.grvData1.OptionsView.ShowColumnHeaders = false;
			this.grvData1.OptionsView.ShowGroupPanel = false;
			this.grvData1.OptionsView.ShowIndicator = false;
			// 
			// colCode
			// 
			this.colCode.Caption = "Code";
			this.colCode.FieldName = "Code";
			this.colCode.Name = "colCode";
			this.colCode.Visible = true;
			this.colCode.VisibleIndex = 0;
			// 
			// colStand
			// 
			this.colStand.Caption = "stand";
			this.colStand.FieldName = "Stand";
			this.colStand.Name = "colStand";
			this.colStand.Visible = true;
			this.colStand.VisibleIndex = 1;
			// 
			// colstd
			// 
			this.colstd.Caption = "std";
			this.colstd.FieldName = "Std";
			this.colstd.Name = "colstd";
			this.colstd.Visible = true;
			this.colstd.VisibleIndex = 2;
			// 
			// lbCurrentATC
			// 
			this.lbCurrentATC.BackColor = System.Drawing.Color.White;
			this.lbCurrentATC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbCurrentATC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbCurrentATC.Location = new System.Drawing.Point(411, 178);
			this.lbCurrentATC.Margin = new System.Windows.Forms.Padding(0);
			this.lbCurrentATC.Name = "lbCurrentATC";
			this.lbCurrentATC.Size = new System.Drawing.Size(121, 130);
			this.lbCurrentATC.TabIndex = 8;
			this.lbCurrentATC.Text = "12";
			this.lbCurrentATC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbSTD
			// 
			this.lbSTD.BackColor = System.Drawing.Color.White;
			this.lbSTD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbSTD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbSTD.Location = new System.Drawing.Point(290, 48);
			this.lbSTD.Margin = new System.Windows.Forms.Padding(0);
			this.lbSTD.Name = "lbSTD";
			this.lbSTD.Size = new System.Drawing.Size(121, 130);
			this.lbSTD.TabIndex = 5;
			this.lbSTD.Text = "1000";
			this.lbSTD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbNumberProduct
			// 
			this.lbNumberProduct.BackColor = System.Drawing.Color.White;
			this.lbNumberProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbNumberProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbNumberProduct.Location = new System.Drawing.Point(140, 48);
			this.lbNumberProduct.Margin = new System.Windows.Forms.Padding(0);
			this.lbNumberProduct.Name = "lbNumberProduct";
			this.tableLayoutPanel1.SetRowSpan(this.lbNumberProduct, 2);
			this.lbNumberProduct.Size = new System.Drawing.Size(150, 260);
			this.lbNumberProduct.TabIndex = 4;
			this.lbNumberProduct.Text = "1000";
			this.lbNumberProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbKnifeCode
			// 
			this.lbKnifeCode.BackColor = System.Drawing.Color.Silver;
			this.lbKnifeCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tableLayoutPanel1.SetColumnSpan(this.lbKnifeCode, 2);
			this.lbKnifeCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbKnifeCode.Location = new System.Drawing.Point(290, 0);
			this.lbKnifeCode.Margin = new System.Windows.Forms.Padding(0);
			this.lbKnifeCode.Name = "lbKnifeCode";
			this.lbKnifeCode.Size = new System.Drawing.Size(242, 48);
			this.lbKnifeCode.TabIndex = 3;
			this.lbKnifeCode.Text = "HOB 1";
			this.lbKnifeCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbGoodsCode
			// 
			this.lbGoodsCode.BackColor = System.Drawing.Color.Aqua;
			this.lbGoodsCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbGoodsCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbGoodsCode.Location = new System.Drawing.Point(140, 0);
			this.lbGoodsCode.Margin = new System.Windows.Forms.Padding(0);
			this.lbGoodsCode.Name = "lbGoodsCode";
			this.lbGoodsCode.Size = new System.Drawing.Size(150, 48);
			this.lbGoodsCode.TabIndex = 1;
			this.lbGoodsCode.Text = "ACT199G-1";
			this.lbGoodsCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbName
			// 
			this.lbName.BackColor = System.Drawing.SystemColors.HotTrack;
			this.lbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbName.Location = new System.Drawing.Point(0, 0);
			this.lbName.Margin = new System.Windows.Forms.Padding(0);
			this.lbName.Name = "lbName";
			this.tableLayoutPanel1.SetRowSpan(this.lbName, 3);
			this.lbName.Size = new System.Drawing.Size(140, 308);
			this.lbName.TabIndex = 0;
			this.lbName.Text = "HOB 1";
			this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grdData
			// 
			this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdData.Location = new System.Drawing.Point(532, 0);
			this.grdData.MainView = this.grvData;
			this.grdData.Margin = new System.Windows.Forms.Padding(0);
			this.grdData.Name = "grdData";
			this.tableLayoutPanel1.SetRowSpan(this.grdData, 3);
			this.grdData.Size = new System.Drawing.Size(346, 308);
			this.grdData.TabIndex = 9;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			// 
			// grvData
			// 
			this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKnifeDetailCode,
            this.colRealValue,
            this.colStandardValue});
			this.grvData.GridControl = this.grdData;
			this.grvData.Name = "grvData";
			this.grvData.OptionsView.ShowColumnHeaders = false;
			this.grvData.OptionsView.ShowGroupPanel = false;
			this.grvData.OptionsView.ShowIndicator = false;
			// 
			// colKnifeDetailCode
			// 
			this.colKnifeDetailCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colKnifeDetailCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeDetailCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeDetailCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colKnifeDetailCode.Caption = "KnifeDetailCode";
			this.colKnifeDetailCode.FieldName = "KnifeDetailCode";
			this.colKnifeDetailCode.Name = "colKnifeDetailCode";
			this.colKnifeDetailCode.Visible = true;
			this.colKnifeDetailCode.VisibleIndex = 0;
			this.colKnifeDetailCode.Width = 527;
			// 
			// colRealValue
			// 
			this.colRealValue.AppearanceCell.Options.UseTextOptions = true;
			this.colRealValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRealValue.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colRealValue.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colRealValue.AppearanceHeader.Options.UseTextOptions = true;
			this.colRealValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRealValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colRealValue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colRealValue.Caption = "RealValue";
			this.colRealValue.FieldName = "RealValue";
			this.colRealValue.Name = "colRealValue";
			this.colRealValue.Visible = true;
			this.colRealValue.VisibleIndex = 2;
			this.colRealValue.Width = 543;
			// 
			// colStandardValue
			// 
			this.colStandardValue.AppearanceHeader.Options.UseTextOptions = true;
			this.colStandardValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStandardValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStandardValue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colStandardValue.Caption = "StandardValue";
			this.colStandardValue.FieldName = "StandardValue";
			this.colStandardValue.Name = "colStandardValue";
			this.colStandardValue.Visible = true;
			this.colStandardValue.VisibleIndex = 1;
			this.colStandardValue.Width = 545;
			// 
			// lbATC
			// 
			this.lbATC.BackColor = System.Drawing.Color.White;
			this.lbATC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbATC.Location = new System.Drawing.Point(290, 178);
			this.lbATC.Margin = new System.Windows.Forms.Padding(0);
			this.lbATC.Name = "lbATC";
			this.lbATC.Size = new System.Drawing.Size(121, 130);
			this.lbATC.TabIndex = 6;
			this.lbATC.Text = "20";
			this.lbATC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbCurrentSTD
			// 
			this.lbCurrentSTD.BackColor = System.Drawing.Color.White;
			this.lbCurrentSTD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbCurrentSTD.Location = new System.Drawing.Point(411, 48);
			this.lbCurrentSTD.Margin = new System.Windows.Forms.Padding(0);
			this.lbCurrentSTD.Name = "lbCurrentSTD";
			this.lbCurrentSTD.Size = new System.Drawing.Size(121, 130);
			this.lbCurrentSTD.TabIndex = 11;
			this.lbCurrentSTD.Text = "200";
			this.lbCurrentSTD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ucModel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ucModel";
			this.Size = new System.Drawing.Size(1225, 308);
			this.Load += new System.EventHandler(this.ucModel_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdData1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbCurrentATC;
        private System.Windows.Forms.Label lbATC;
        private System.Windows.Forms.Label lbSTD;
        private System.Windows.Forms.Label lbNumberProduct;
        private System.Windows.Forms.Label lbKnifeCode;
        private System.Windows.Forms.Label lbGoodsCode;
        private System.Windows.Forms.Label lbName;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView grvData;
        private DevExpress.XtraGrid.Columns.GridColumn colKnifeDetailCode;
        private DevExpress.XtraGrid.Columns.GridColumn colRealValue;
        private DevExpress.XtraGrid.Columns.GridColumn colStandardValue;
        private DevExpress.XtraGrid.GridControl grdData1;
        private DevExpress.XtraGrid.Views.Grid.GridView grvData1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colStand;
        private DevExpress.XtraGrid.Columns.GridColumn colstd;
		private System.Windows.Forms.Label lbCurrentSTD;
	}
}
