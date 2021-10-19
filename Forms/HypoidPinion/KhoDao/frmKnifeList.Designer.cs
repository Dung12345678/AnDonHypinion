
namespace BMS
{
	partial class frmKnifeList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKnifeList));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnCreateKnife = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEditKnife = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelKnife = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnProcessTool = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDisposeTool = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSharpenKnife = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnProcessChart = new System.Windows.Forms.ToolStripButton();
			this.cbShowUnavailable = new System.Windows.Forms.CheckBox();
			this.btnFindDate = new System.Windows.Forms.Button();
			this.txtFindDate = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboLoai = new System.Windows.Forms.ComboBox();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.treeData = new DevExpress.XtraTreeList.TreeList();
			this.colID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colKnifeCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colKnifeName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colImportedDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colWorkerID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colSTD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colATC = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colParentID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colFullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeData)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateKnife,
            this.toolStripSeparator1,
            this.btnEditKnife,
            this.toolStripSeparator7,
            this.btnDelKnife,
            this.toolStripSeparator2,
            this.btnProcessTool,
            this.toolStripSeparator5,
            this.btnDisposeTool,
            this.toolStripSeparator3,
            this.btnSharpenKnife,
            this.toolStripSeparator6,
            this.btnRefresh,
            this.toolStripSeparator4,
            this.btnProcessChart});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1146, 42);
			this.toolStrip1.TabIndex = 32;
			this.toolStrip1.Text = "toolStrip2";
			// 
			// btnCreateKnife
			// 
			this.btnCreateKnife.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btnCreateKnife.ForeColor = System.Drawing.Color.Black;
			this.btnCreateKnife.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateKnife.Image")));
			this.btnCreateKnife.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCreateKnife.Name = "btnCreateKnife";
			this.btnCreateKnife.Size = new System.Drawing.Size(79, 37);
			this.btnCreateKnife.Tag = "frmKnifeListAdd";
			this.btnCreateKnife.Text = "Tạo dụng cụ";
			this.btnCreateKnife.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCreateKnife.Click += new System.EventHandler(this.btnCreateKnife_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
			// 
			// btnEditKnife
			// 
			this.btnEditKnife.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btnEditKnife.ForeColor = System.Drawing.Color.Black;
			this.btnEditKnife.Image = ((System.Drawing.Image)(resources.GetObject("btnEditKnife.Image")));
			this.btnEditKnife.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditKnife.Name = "btnEditKnife";
			this.btnEditKnife.Size = new System.Drawing.Size(80, 37);
			this.btnEditKnife.Tag = "frmKnifeListEdit";
			this.btnEditKnife.Text = "Sửa dụng cụ";
			this.btnEditKnife.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEditKnife.Click += new System.EventHandler(this.btnEditKnife_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
			// 
			// btnDelKnife
			// 
			this.btnDelKnife.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btnDelKnife.ForeColor = System.Drawing.Color.Black;
			this.btnDelKnife.Image = ((System.Drawing.Image)(resources.GetObject("btnDelKnife.Image")));
			this.btnDelKnife.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelKnife.Name = "btnDelKnife";
			this.btnDelKnife.Size = new System.Drawing.Size(79, 37);
			this.btnDelKnife.Tag = "frmKnifeListDelete";
			this.btnDelKnife.Text = "Xóa dụng cụ";
			this.btnDelKnife.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDelKnife.Click += new System.EventHandler(this.btnDelKnife_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
			// 
			// btnProcessTool
			// 
			this.btnProcessTool.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btnProcessTool.ForeColor = System.Drawing.Color.Black;
			this.btnProcessTool.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessTool.Image")));
			this.btnProcessTool.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnProcessTool.Name = "btnProcessTool";
			this.btnProcessTool.Size = new System.Drawing.Size(59, 37);
			this.btnProcessTool.Tag = "frmKnifeListProcessTool";
			this.btnProcessTool.Text = "Gia công";
			this.btnProcessTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnProcessTool.Visible = false;
			this.btnProcessTool.Click += new System.EventHandler(this.btnProcessTool_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
			this.toolStripSeparator5.Visible = false;
			// 
			// btnDisposeTool
			// 
			this.btnDisposeTool.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btnDisposeTool.ForeColor = System.Drawing.Color.Black;
			this.btnDisposeTool.Image = ((System.Drawing.Image)(resources.GetObject("btnDisposeTool.Image")));
			this.btnDisposeTool.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDisposeTool.Name = "btnDisposeTool";
			this.btnDisposeTool.Size = new System.Drawing.Size(80, 37);
			this.btnDisposeTool.Tag = "frmKnifeListDisposeTool";
			this.btnDisposeTool.Text = "Hủy dụng cụ";
			this.btnDisposeTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDisposeTool.Click += new System.EventHandler(this.btnDisposeTool_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.AutoSize = false;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
			// 
			// btnSharpenKnife
			// 
			this.btnSharpenKnife.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btnSharpenKnife.ForeColor = System.Drawing.Color.Black;
			this.btnSharpenKnife.Image = ((System.Drawing.Image)(resources.GetObject("btnSharpenKnife.Image")));
			this.btnSharpenKnife.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSharpenKnife.Name = "btnSharpenKnife";
			this.btnSharpenKnife.Size = new System.Drawing.Size(55, 37);
			this.btnSharpenKnife.Tag = "frmKnifeListShapenKnife";
			this.btnSharpenKnife.Text = "Mài dao";
			this.btnSharpenKnife.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSharpenKnife.Click += new System.EventHandler(this.btnSharpenKnife_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.AutoSize = false;
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 40);
			// 
			// btnRefresh
			// 
			this.btnRefresh.AutoSize = false;
			this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(91, 44);
			this.btnRefresh.Tag = "";
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.AutoSize = false;
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
			// 
			// btnProcessChart
			// 
			this.btnProcessChart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btnProcessChart.ForeColor = System.Drawing.Color.Black;
			this.btnProcessChart.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessChart.Image")));
			this.btnProcessChart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnProcessChart.Name = "btnProcessChart";
			this.btnProcessChart.Size = new System.Drawing.Size(52, 37);
			this.btnProcessChart.Tag = "";
			this.btnProcessChart.Text = "Biểu đồ";
			this.btnProcessChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnProcessChart.Visible = false;
			this.btnProcessChart.Click += new System.EventHandler(this.btnProcessChart_Click);
			// 
			// cbShowUnavailable
			// 
			this.cbShowUnavailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbShowUnavailable.Location = new System.Drawing.Point(1008, 7);
			this.cbShowUnavailable.Name = "cbShowUnavailable";
			this.cbShowUnavailable.Size = new System.Drawing.Size(138, 30);
			this.cbShowUnavailable.TabIndex = 0;
			this.cbShowUnavailable.Text = "Hiển thị những sản phẩm không khả dụng";
			this.cbShowUnavailable.UseVisualStyleBackColor = true;
			this.cbShowUnavailable.CheckedChanged += new System.EventHandler(this.cbShowUnavailable_CheckedChanged);
			// 
			// btnFindDate
			// 
			this.btnFindDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFindDate.Location = new System.Drawing.Point(869, 45);
			this.btnFindDate.Name = "btnFindDate";
			this.btnFindDate.Size = new System.Drawing.Size(75, 23);
			this.btnFindDate.TabIndex = 60;
			this.btnFindDate.Text = "Tìm kiếm";
			this.btnFindDate.UseVisualStyleBackColor = true;
			this.btnFindDate.Click += new System.EventHandler(this.btnFindDate_Click);
			// 
			// txtFindDate
			// 
			this.txtFindDate.Location = new System.Drawing.Point(634, 46);
			this.txtFindDate.Name = "txtFindDate";
			this.txtFindDate.Size = new System.Drawing.Size(218, 20);
			this.txtFindDate.TabIndex = 55;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(575, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 54;
			this.label2.Text = "Từ khóa";
			// 
			// cboLoai
			// 
			this.cboLoai.FormattingEnabled = true;
			this.cboLoai.Items.AddRange(new object[] {
            "Dao",
            "Jig",
            "Khuôn"});
			this.cboLoai.Location = new System.Drawing.Point(41, 46);
			this.cboLoai.Name = "cboLoai";
			this.cboLoai.Size = new System.Drawing.Size(133, 21);
			this.cboLoai.TabIndex = 61;
			this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.labelControl1.Location = new System.Drawing.Point(12, 49);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(23, 13);
			this.labelControl1.TabIndex = 62;
			this.labelControl1.Text = "Loại";
			// 
			// dtpFrom
			// 
			this.dtpFrom.CustomFormat = "dd/MM/yyyy";
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFrom.Location = new System.Drawing.Point(250, 48);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(104, 20);
			this.dtpFrom.TabIndex = 66;
			// 
			// dtpTo
			// 
			this.dtpTo.CustomFormat = "dd/MM/yyyy";
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTo.Location = new System.Drawing.Point(443, 47);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(104, 20);
			this.dtpTo.TabIndex = 65;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(374, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 64;
			this.label1.Text = "Đến ngày: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(194, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 63;
			this.label3.Text = "Từ ngày: ";
			// 
			// treeData
			// 
			this.treeData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.treeData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.treeData.Appearance.FocusedRow.Options.UseBackColor = true;
			this.treeData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.treeData.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.treeData.Appearance.HideSelectionRow.Options.UseBackColor = true;
			this.treeData.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colID,
            this.colKnifeCode,
            this.colKnifeName,
            this.colDescription,
            this.colImportedDate,
            this.colWorkerID,
            this.colSTD,
            this.colATC,
            this.colParentID,
            this.colFullName});
			this.treeData.Location = new System.Drawing.Point(0, 74);
			this.treeData.Name = "treeData";
			this.treeData.OptionsBehavior.AllowExpandOnDblClick = false;
			this.treeData.OptionsBehavior.DragNodes = true;
			this.treeData.OptionsBehavior.Editable = false;
			this.treeData.OptionsView.ShowIndicator = false;
			this.treeData.Size = new System.Drawing.Size(1146, 550);
			this.treeData.TabIndex = 67;
			// 
			// colID
			// 
			this.colID.AppearanceCell.Options.UseTextOptions = true;
			this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colID.AppearanceHeader.Options.UseFont = true;
			this.colID.AppearanceHeader.Options.UseTextOptions = true;
			this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			// 
			// colKnifeCode
			// 
			this.colKnifeCode.AppearanceCell.Options.UseTextOptions = true;
			this.colKnifeCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colKnifeCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colKnifeCode.AppearanceHeader.Options.UseFont = true;
			this.colKnifeCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colKnifeCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colKnifeCode.Caption = "Mã";
			this.colKnifeCode.FieldName = "KnifeCode";
			this.colKnifeCode.Name = "colKnifeCode";
			this.colKnifeCode.Visible = true;
			this.colKnifeCode.VisibleIndex = 0;
			// 
			// colKnifeName
			// 
			this.colKnifeName.AppearanceCell.Options.UseTextOptions = true;
			this.colKnifeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colKnifeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colKnifeName.AppearanceHeader.Options.UseFont = true;
			this.colKnifeName.AppearanceHeader.Options.UseTextOptions = true;
			this.colKnifeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colKnifeName.Caption = "Tên";
			this.colKnifeName.FieldName = "KnifeName";
			this.colKnifeName.Name = "colKnifeName";
			this.colKnifeName.Visible = true;
			this.colKnifeName.VisibleIndex = 1;
			// 
			// colDescription
			// 
			this.colDescription.AppearanceCell.Options.UseTextOptions = true;
			this.colDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDescription.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colDescription.AppearanceHeader.Options.UseFont = true;
			this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
			this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDescription.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDescription.Caption = "Mô tả";
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 2;
			// 
			// colImportedDate
			// 
			this.colImportedDate.AppearanceCell.Options.UseTextOptions = true;
			this.colImportedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colImportedDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colImportedDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colImportedDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colImportedDate.AppearanceHeader.Options.UseFont = true;
			this.colImportedDate.AppearanceHeader.Options.UseTextOptions = true;
			this.colImportedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colImportedDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colImportedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colImportedDate.Caption = "Ngày nhập";
			this.colImportedDate.FieldName = "ImportedDate";
			this.colImportedDate.Name = "colImportedDate";
			this.colImportedDate.Visible = true;
			this.colImportedDate.VisibleIndex = 6;
			// 
			// colWorkerID
			// 
			this.colWorkerID.AppearanceCell.Options.UseTextOptions = true;
			this.colWorkerID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWorkerID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colWorkerID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colWorkerID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colWorkerID.AppearanceHeader.Options.UseFont = true;
			this.colWorkerID.AppearanceHeader.Options.UseTextOptions = true;
			this.colWorkerID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWorkerID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colWorkerID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colWorkerID.Caption = "WorkerID";
			this.colWorkerID.FieldName = "WorkerID";
			this.colWorkerID.Name = "colWorkerID";
			// 
			// colSTD
			// 
			this.colSTD.AppearanceCell.Options.UseTextOptions = true;
			this.colSTD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTD.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colSTD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colSTD.AppearanceHeader.Options.UseFont = true;
			this.colSTD.AppearanceHeader.Options.UseTextOptions = true;
			this.colSTD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colSTD.Caption = "STD";
			this.colSTD.FieldName = "STD";
			this.colSTD.Name = "colSTD";
			this.colSTD.Visible = true;
			this.colSTD.VisibleIndex = 3;
			// 
			// colATC
			// 
			this.colATC.AppearanceCell.Options.UseTextOptions = true;
			this.colATC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colATC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colATC.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colATC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colATC.AppearanceHeader.Options.UseFont = true;
			this.colATC.AppearanceHeader.Options.UseTextOptions = true;
			this.colATC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colATC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colATC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colATC.Caption = "ATC";
			this.colATC.FieldName = "ATC";
			this.colATC.Name = "colATC";
			this.colATC.Visible = true;
			this.colATC.VisibleIndex = 4;
			// 
			// colParentID
			// 
			this.colParentID.AppearanceCell.Options.UseTextOptions = true;
			this.colParentID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colParentID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colParentID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colParentID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colParentID.AppearanceHeader.Options.UseFont = true;
			this.colParentID.AppearanceHeader.Options.UseTextOptions = true;
			this.colParentID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colParentID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colParentID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colParentID.Caption = "ParentID";
			this.colParentID.FieldName = "ParentID";
			this.colParentID.Name = "colParentID";
			// 
			// colFullName
			// 
			this.colFullName.AppearanceCell.Options.UseTextOptions = true;
			this.colFullName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colFullName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colFullName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colFullName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colFullName.AppearanceHeader.Options.UseFont = true;
			this.colFullName.AppearanceHeader.Options.UseTextOptions = true;
			this.colFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colFullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colFullName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colFullName.Caption = "Người nhập";
			this.colFullName.FieldName = "FullName";
			this.colFullName.Name = "colFullName";
			this.colFullName.Visible = true;
			this.colFullName.VisibleIndex = 5;
			// 
			// treeListColumn1
			// 
			this.treeListColumn1.Caption = "ID";
			this.treeListColumn1.FieldName = "ID";
			this.treeListColumn1.Name = "treeListColumn1";
			this.treeListColumn1.Visible = true;
			this.treeListColumn1.VisibleIndex = 0;
			// 
			// frmKnifeList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1146, 620);
			this.Controls.Add(this.treeData);
			this.Controls.Add(this.dtpFrom);
			this.Controls.Add(this.dtpTo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.cboLoai);
			this.Controls.Add(this.btnFindDate);
			this.Controls.Add(this.txtFindDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbShowUnavailable);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmKnifeList";
			this.Tag = "";
			this.Text = "DANH SÁCH KHO DAO";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmKnifeList_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnCreateKnife;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnEditKnife;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton btnDelKnife;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnProcessTool;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton btnDisposeTool;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.CheckBox cbShowUnavailable;
		private System.Windows.Forms.ToolStripButton btnSharpenKnife;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton btnProcessChart;
		private System.Windows.Forms.Button btnFindDate;
		private System.Windows.Forms.TextBox txtFindDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboLoai;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private DevExpress.XtraTreeList.TreeList treeData;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colID;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colKnifeCode;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colKnifeName;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colImportedDate;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colWorkerID;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colSTD;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colATC;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colParentID;
		private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colFullName;
	}
}