
namespace BMS
{
    partial class frmHypMold
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHypMold));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.btnNew = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.btnEditTxt = new System.Windows.Forms.ToolStripButton();
			this.btnPath = new System.Windows.Forms.ToolStripButton();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnCancel = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.cboCongDoan = new System.Windows.Forms.ComboBox();
			this.txtMaHang = new System.Windows.Forms.TextBox();
			this.txtCreateby = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.grvKnifeJigWorking = new System.Windows.Forms.DataGridView();
			this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colWorkingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPeriodValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRealvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEvaluate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMinValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbly = new System.Windows.Forms.Label();
			this.lblx = new System.Windows.Forms.Label();
			this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.mnuMenu.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grvKnifeJigWorking)).BeginInit();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.mnuMenu);
			this.panel1.Controls.Add(this.cboCongDoan);
			this.panel1.Controls.Add(this.txtMaHang);
			this.panel1.Controls.Add(this.txtCreateby);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1280, 83);
			this.panel1.TabIndex = 0;
			// 
			// mnuMenu
			// 
			this.mnuMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mnuMenu.AutoSize = false;
			this.mnuMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.mnuMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.mnuMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnDelete,
            this.btnEditTxt,
            this.btnPath,
            this.btnSave,
            this.btnCancel,
            this.toolStripButton1});
			this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.mnuMenu.Location = new System.Drawing.Point(655, 14);
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMenu.Size = new System.Drawing.Size(309, 25);
			this.mnuMenu.TabIndex = 73;
			this.mnuMenu.Text = "toolStrip2";
			// 
			// btnNew
			// 
			this.btnNew.AutoSize = false;
			this.btnNew.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
			this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(40, 20);
			this.btnNew.Tag = "";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.AutoSize = false;
			this.btnEdit.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(40, 20);
			this.btnEdit.Tag = "";
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.AutoSize = false;
			this.btnDelete.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(40, 20);
			this.btnDelete.Tag = "";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEditTxt
			// 
			this.btnEditTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnEditTxt.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTxt.Image")));
			this.btnEditTxt.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditTxt.Name = "btnEditTxt";
			this.btnEditTxt.Size = new System.Drawing.Size(23, 20);
			this.btnEditTxt.Text = "toolStripButton1";
			this.btnEditTxt.Click += new System.EventHandler(this.btnEditTxt_Click);
			// 
			// btnPath
			// 
			this.btnPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnPath.Image = ((System.Drawing.Image)(resources.GetObject("btnPath.Image")));
			this.btnPath.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPath.Name = "btnPath";
			this.btnPath.Size = new System.Drawing.Size(23, 20);
			this.btnPath.Text = "toolStripButton2";
			this.btnPath.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// btnSave
			// 
			this.btnSave.AutoSize = false;
			this.btnSave.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(40, 20);
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnCancel.AutoSize = false;
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(40, 20);
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 4);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// cboCongDoan
			// 
			this.cboCongDoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboCongDoan.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboCongDoan.FormattingEnabled = true;
			this.cboCongDoan.Location = new System.Drawing.Point(455, 13);
			this.cboCongDoan.Name = "cboCongDoan";
			this.cboCongDoan.Size = new System.Drawing.Size(181, 26);
			this.cboCongDoan.TabIndex = 4;
			this.cboCongDoan.Text = "THAY KHUÔN";
			this.cboCongDoan.SelectedIndexChanged += new System.EventHandler(this.cboCongDoan_SelectedIndexChanged);
			// 
			// txtMaHang
			// 
			this.txtMaHang.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaHang.Location = new System.Drawing.Point(127, 45);
			this.txtMaHang.Name = "txtMaHang";
			this.txtMaHang.Size = new System.Drawing.Size(205, 26);
			this.txtMaHang.TabIndex = 2;
			this.txtMaHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaHang_KeyDown);
			// 
			// txtCreateby
			// 
			this.txtCreateby.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCreateby.Location = new System.Drawing.Point(128, 12);
			this.txtCreateby.Name = "txtCreateby";
			this.txtCreateby.Size = new System.Drawing.Size(205, 26);
			this.txtCreateby.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.grvKnifeJigWorking);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(274, 872);
			this.panel3.TabIndex = 2;
			// 
			// grvKnifeJigWorking
			// 
			this.grvKnifeJigWorking.AllowUserToAddRows = false;
			this.grvKnifeJigWorking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grvKnifeJigWorking.BackgroundColor = System.Drawing.Color.White;
			this.grvKnifeJigWorking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle21.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grvKnifeJigWorking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
			this.grvKnifeJigWorking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grvKnifeJigWorking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colWorkingName,
            this.colCondition,
            this.colPeriodValue,
            this.colUnit,
            this.colRealvalue,
            this.colEvaluate,
            this.colDisplay,
            this.colY,
            this.colX,
            this.colMinValue,
            this.colID,
            this.colMaxValue});
			dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grvKnifeJigWorking.DefaultCellStyle = dataGridViewCellStyle22;
			this.grvKnifeJigWorking.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grvKnifeJigWorking.EnableHeadersVisualStyles = false;
			this.grvKnifeJigWorking.Location = new System.Drawing.Point(0, 0);
			this.grvKnifeJigWorking.Name = "grvKnifeJigWorking";
			this.grvKnifeJigWorking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.grvKnifeJigWorking.RowHeadersVisible = false;
			this.grvKnifeJigWorking.RowHeadersWidth = 10;
			this.grvKnifeJigWorking.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.grvKnifeJigWorking.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grvKnifeJigWorking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grvKnifeJigWorking.Size = new System.Drawing.Size(274, 872);
			this.grvKnifeJigWorking.TabIndex = 74;
			this.grvKnifeJigWorking.Click += new System.EventHandler(this.grvKnifeJigWorking_Click);
			// 
			// colSTT
			// 
			this.colSTT.DataPropertyName = "SortOrder";
			this.colSTT.FillWeight = 25.57112F;
			this.colSTT.HeaderText = "STT";
			this.colSTT.Name = "colSTT";
			this.colSTT.Visible = false;
			// 
			// colWorkingName
			// 
			this.colWorkingName.DataPropertyName = "WorkingName";
			this.colWorkingName.FillWeight = 107.1869F;
			this.colWorkingName.HeaderText = "Mục kiểm tra";
			this.colWorkingName.Name = "colWorkingName";
			// 
			// colCondition
			// 
			this.colCondition.DataPropertyName = "Condition";
			this.colCondition.HeaderText = "Tiêu chuẩn";
			this.colCondition.Name = "colCondition";
			this.colCondition.Visible = false;
			// 
			// colPeriodValue
			// 
			this.colPeriodValue.DataPropertyName = "PeriodValue";
			this.colPeriodValue.FillWeight = 64.31032F;
			this.colPeriodValue.HeaderText = "Tiêu chuẩn";
			this.colPeriodValue.Name = "colPeriodValue";
			// 
			// colUnit
			// 
			this.colUnit.DataPropertyName = "Unit";
			this.colUnit.FillWeight = 57.57317F;
			this.colUnit.HeaderText = "Đơn vị";
			this.colUnit.Name = "colUnit";
			// 
			// colRealvalue
			// 
			this.colRealvalue.DataPropertyName = "Realvalue";
			this.colRealvalue.FillWeight = 59.17865F;
			this.colRealvalue.HeaderText = "Thực tế";
			this.colRealvalue.Name = "colRealvalue";
			this.colRealvalue.Visible = false;
			// 
			// colEvaluate
			// 
			this.colEvaluate.DataPropertyName = "Evaluate";
			this.colEvaluate.FillWeight = 35.4599F;
			this.colEvaluate.HeaderText = "Đánh giá";
			this.colEvaluate.Name = "colEvaluate";
			this.colEvaluate.Visible = false;
			// 
			// colDisplay
			// 
			this.colDisplay.DataPropertyName = "isDisplay";
			this.colDisplay.HeaderText = "Display";
			this.colDisplay.Name = "colDisplay";
			this.colDisplay.Visible = false;
			// 
			// colY
			// 
			this.colY.DataPropertyName = "Y";
			this.colY.FillWeight = 45.68528F;
			this.colY.HeaderText = "Y";
			this.colY.Name = "colY";
			this.colY.Visible = false;
			// 
			// colX
			// 
			this.colX.DataPropertyName = "X";
			this.colX.HeaderText = "X";
			this.colX.Name = "colX";
			this.colX.Visible = false;
			// 
			// colMinValue
			// 
			this.colMinValue.DataPropertyName = "MinValue";
			this.colMinValue.HeaderText = "MinValue";
			this.colMinValue.Name = "colMinValue";
			this.colMinValue.Visible = false;
			// 
			// colID
			// 
			this.colID.DataPropertyName = "ID";
			this.colID.HeaderText = "ID";
			this.colID.Name = "colID";
			this.colID.Visible = false;
			// 
			// colMaxValue
			// 
			this.colMaxValue.DataPropertyName = "MaxValue";
			this.colMaxValue.FillWeight = 5.034656F;
			this.colMaxValue.HeaderText = "MaxValue";
			this.colMaxValue.Name = "colMaxValue";
			this.colMaxValue.Visible = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lbly);
			this.panel2.Controls.Add(this.lblx);
			this.panel2.Controls.Add(this.pdfViewer1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(283, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(994, 872);
			this.panel2.TabIndex = 1;
			// 
			// lbly
			// 
			this.lbly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbly.AutoSize = true;
			this.lbly.BackColor = System.Drawing.SystemColors.Control;
			this.lbly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbly.Location = new System.Drawing.Point(936, 3);
			this.lbly.Name = "lbly";
			this.lbly.Size = new System.Drawing.Size(15, 16);
			this.lbly.TabIndex = 1;
			this.lbly.Text = "y";
			// 
			// lblx
			// 
			this.lblx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblx.AutoSize = true;
			this.lblx.BackColor = System.Drawing.SystemColors.Control;
			this.lblx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblx.Location = new System.Drawing.Point(896, 3);
			this.lblx.Name = "lblx";
			this.lblx.Size = new System.Drawing.Size(14, 16);
			this.lblx.TabIndex = 0;
			this.lblx.Text = "x";
			// 
			// pdfViewer1
			// 
			this.pdfViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pdfViewer1.Location = new System.Drawing.Point(0, 0);
			this.pdfViewer1.LookAndFeel.SkinName = "VS2010";
			this.pdfViewer1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
			this.pdfViewer1.Name = "pdfViewer1";
			this.pdfViewer1.Size = new System.Drawing.Size(994, 872);
			this.pdfViewer1.TabIndex = 0;
			this.pdfViewer1.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1000F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 83);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.54006F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 878);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.SkyBlue;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(11, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 25);
			this.label1.TabIndex = 74;
			this.label1.Text = "Phụ trách";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.SkyBlue;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(11, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 25);
			this.label2.TabIndex = 75;
			this.label2.Text = "Mã khuôn";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.SkyBlue;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(339, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 25);
			this.label3.TabIndex = 76;
			this.label3.Text = "Công đoạn";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmHypMold
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1280, 961);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(1296, 1000);
			this.MinimumSize = new System.Drawing.Size(1278, 982);
			this.Name = "frmHypMold";
			this.Text = "HYPOID PINION";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grvKnifeJigWorking)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboCongDoan;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtCreateby;
        private System.Windows.Forms.ToolStrip mnuMenu;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnEditTxt;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnPath;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView grvKnifeJigWorking;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbly;
		private System.Windows.Forms.Label lblx;
		private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
		private System.Windows.Forms.DataGridViewTextBoxColumn colWorkingName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCondition;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRealvalue;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEvaluate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDisplay;
		private System.Windows.Forms.DataGridViewTextBoxColumn colY;
		private System.Windows.Forms.DataGridViewTextBoxColumn colX;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMinValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn colID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaxValue;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

