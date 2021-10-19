
namespace BMS
{
    partial class frmMeasuringToolLine
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
			this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
			this.txtDateTime = new System.Windows.Forms.TextBox();
			this.cboStep = new System.Windows.Forms.ComboBox();
			this.txtJigCode = new System.Windows.Forms.TextBox();
			this.txtWorker = new System.Windows.Forms.TextBox();
			this.grdData = new DevExpress.XtraGrid.GridControl();
			this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colSortOrder = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductWorkingName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
			this.colStandardValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMinValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMaxValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReal1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCheckValueType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFrequency = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReal2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReal3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReal4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReal5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colValueType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pannelBot = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startRiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.endRiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSave = new System.Windows.Forms.Button();
			this.cbPart = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dtpFrequencyCheck = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
			this.pannelBot.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// repositoryItemMemoEdit2
			// 
			this.repositoryItemMemoEdit2.Appearance.Options.UseTextOptions = true;
			this.repositoryItemMemoEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.repositoryItemMemoEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.repositoryItemMemoEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
			// 
			// txtDateTime
			// 
			this.txtDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDateTime.Location = new System.Drawing.Point(1029, 1);
			this.txtDateTime.Margin = new System.Windows.Forms.Padding(1);
			this.txtDateTime.Name = "txtDateTime";
			this.txtDateTime.ReadOnly = true;
			this.txtDateTime.Size = new System.Drawing.Size(224, 40);
			this.txtDateTime.TabIndex = 85;
			this.txtDateTime.TextChanged += new System.EventHandler(this.txt_TextChanged);
			// 
			// cboStep
			// 
			this.cboStep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboStep.FormattingEnabled = true;
			this.cboStep.Location = new System.Drawing.Point(575, 42);
			this.cboStep.Margin = new System.Windows.Forms.Padding(1);
			this.cboStep.Name = "cboStep";
			this.cboStep.Size = new System.Drawing.Size(208, 41);
			this.cboStep.TabIndex = 5;
			this.cboStep.SelectedIndexChanged += new System.EventHandler(this.cboStep_SelectedIndexChanged);
			// 
			// txtJigCode
			// 
			this.txtJigCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtJigCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtJigCode.Location = new System.Drawing.Point(146, 42);
			this.txtJigCode.Margin = new System.Windows.Forms.Padding(1);
			this.txtJigCode.Name = "txtJigCode";
			this.txtJigCode.Size = new System.Drawing.Size(270, 40);
			this.txtJigCode.TabIndex = 4;
			this.txtJigCode.TextChanged += new System.EventHandler(this.txt_TextChanged);
			this.txtJigCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJigCode_KeyDown);
			// 
			// txtWorker
			// 
			this.txtWorker.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWorker.Location = new System.Drawing.Point(146, 1);
			this.txtWorker.Margin = new System.Windows.Forms.Padding(1);
			this.txtWorker.Name = "txtWorker";
			this.txtWorker.Size = new System.Drawing.Size(270, 40);
			this.txtWorker.TabIndex = 2;
			this.txtWorker.TextChanged += new System.EventHandler(this.txt_TextChanged);
			this.txtWorker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorker_KeyDown);
			// 
			// grdData
			// 
			this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdData.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grdData.Location = new System.Drawing.Point(-1, 127);
			this.grdData.MainView = this.grvData;
			this.grdData.Name = "grdData";
			this.grdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
			this.grdData.Size = new System.Drawing.Size(1254, 393);
			this.grdData.TabIndex = 6;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			// 
			// grvData
			// 
			this.grvData.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Lime;
			this.grvData.Appearance.FocusedCell.Options.UseBorderColor = true;
			this.grvData.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
			this.grvData.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
			this.grvData.Appearance.HeaderPanel.Options.UseBackColor = true;
			this.grvData.Appearance.HeaderPanel.Options.UseBorderColor = true;
			this.grvData.Appearance.HeaderPanel.Options.UseFont = true;
			this.grvData.Appearance.HeaderPanel.Options.UseForeColor = true;
			this.grvData.Appearance.HeaderPanel.Options.UseImage = true;
			this.grvData.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.grvData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.grvData.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.grvData.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.grvData.Appearance.ViewCaption.Options.UseTextOptions = true;
			this.grvData.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.grvData.ColumnPanelRowHeight = 50;
			this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSortOrder,
            this.colProductWorkingName,
            this.colStandardValue,
            this.colMinValue,
            this.colMaxValue,
            this.colReal1,
            this.colRate,
            this.colCheckValueType,
            this.colFrequency,
            this.colReal2,
            this.colReal3,
            this.colReal4,
            this.colReal5,
            this.colValueType});
			this.grvData.GridControl = this.grdData;
			this.grvData.HorzScrollStep = 5;
			this.grvData.Name = "grvData";
			this.grvData.OptionsBehavior.AutoExpandAllGroups = true;
			this.grvData.OptionsCustomization.AllowFilter = false;
			this.grvData.OptionsCustomization.AllowSort = false;
			this.grvData.OptionsFilter.AllowFilterEditor = false;
			this.grvData.OptionsFind.ShowCloseButton = false;
			this.grvData.OptionsLayout.Columns.AddNewColumns = false;
			this.grvData.OptionsLayout.Columns.RemoveOldColumns = false;
			this.grvData.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.grvData.OptionsSelection.EnableAppearanceFocusedRow = false;
			this.grvData.OptionsView.RowAutoHeight = true;
			this.grvData.OptionsView.ShowGroupPanel = false;
			this.grvData.PaintStyleName = "Flat";
			this.grvData.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grvData_RowCellStyle);
			this.grvData.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvData_CellValueChanged);
			// 
			// colSortOrder
			// 
			this.colSortOrder.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colSortOrder.AppearanceCell.Options.UseFont = true;
			this.colSortOrder.AppearanceCell.Options.UseTextOptions = true;
			this.colSortOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSortOrder.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSortOrder.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colSortOrder.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
			this.colSortOrder.AppearanceHeader.Options.UseFont = true;
			this.colSortOrder.AppearanceHeader.Options.UseTextOptions = true;
			this.colSortOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSortOrder.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSortOrder.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colSortOrder.Caption = "STT";
			this.colSortOrder.FieldName = "SortOrder";
			this.colSortOrder.Name = "colSortOrder";
			this.colSortOrder.OptionsColumn.AllowEdit = false;
			this.colSortOrder.OptionsColumn.AllowFocus = false;
			this.colSortOrder.OptionsColumn.AllowSize = false;
			this.colSortOrder.Visible = true;
			this.colSortOrder.VisibleIndex = 0;
			this.colSortOrder.Width = 51;
			// 
			// colProductWorkingName
			// 
			this.colProductWorkingName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colProductWorkingName.AppearanceCell.Options.UseFont = true;
			this.colProductWorkingName.AppearanceCell.Options.UseTextOptions = true;
			this.colProductWorkingName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductWorkingName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductWorkingName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductWorkingName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.colProductWorkingName.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.colProductWorkingName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
			this.colProductWorkingName.AppearanceHeader.Options.UseFont = true;
			this.colProductWorkingName.AppearanceHeader.Options.UseTextOptions = true;
			this.colProductWorkingName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductWorkingName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductWorkingName.Caption = "Mục kiểm tra";
			this.colProductWorkingName.ColumnEdit = this.repositoryItemMemoEdit1;
			this.colProductWorkingName.FieldName = "WorkingName";
			this.colProductWorkingName.Name = "colProductWorkingName";
			this.colProductWorkingName.OptionsColumn.AllowEdit = false;
			this.colProductWorkingName.OptionsColumn.AllowFocus = false;
			this.colProductWorkingName.OptionsColumn.AllowSize = false;
			this.colProductWorkingName.Visible = true;
			this.colProductWorkingName.VisibleIndex = 1;
			this.colProductWorkingName.Width = 276;
			// 
			// repositoryItemMemoEdit1
			// 
			this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
			// 
			// colStandardValue
			// 
			this.colStandardValue.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colStandardValue.AppearanceCell.Options.UseFont = true;
			this.colStandardValue.AppearanceCell.Options.UseTextOptions = true;
			this.colStandardValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStandardValue.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStandardValue.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colStandardValue.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colStandardValue.AppearanceHeader.Options.UseFont = true;
			this.colStandardValue.AppearanceHeader.Options.UseTextOptions = true;
			this.colStandardValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStandardValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStandardValue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colStandardValue.Caption = "Giá trị tiêu chuẩn";
			this.colStandardValue.ColumnEdit = this.repositoryItemMemoEdit2;
			this.colStandardValue.FieldName = "PeriodValue";
			this.colStandardValue.Name = "colStandardValue";
			this.colStandardValue.OptionsColumn.AllowEdit = false;
			this.colStandardValue.OptionsColumn.AllowFocus = false;
			this.colStandardValue.OptionsColumn.AllowSize = false;
			this.colStandardValue.Visible = true;
			this.colStandardValue.VisibleIndex = 2;
			this.colStandardValue.Width = 126;
			// 
			// colMinValue
			// 
			this.colMinValue.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.colMinValue.AppearanceCell.Options.UseFont = true;
			this.colMinValue.AppearanceCell.Options.UseTextOptions = true;
			this.colMinValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colMinValue.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colMinValue.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colMinValue.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colMinValue.AppearanceHeader.Options.UseFont = true;
			this.colMinValue.AppearanceHeader.Options.UseTextOptions = true;
			this.colMinValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colMinValue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colMinValue.Caption = "MinValue";
			this.colMinValue.FieldName = "MinValue";
			this.colMinValue.Name = "colMinValue";
			this.colMinValue.OptionsColumn.AllowEdit = false;
			this.colMinValue.Width = 104;
			// 
			// colMaxValue
			// 
			this.colMaxValue.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.colMaxValue.AppearanceCell.Options.UseFont = true;
			this.colMaxValue.AppearanceCell.Options.UseTextOptions = true;
			this.colMaxValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colMaxValue.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colMaxValue.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colMaxValue.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colMaxValue.AppearanceHeader.Options.UseFont = true;
			this.colMaxValue.AppearanceHeader.Options.UseTextOptions = true;
			this.colMaxValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colMaxValue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colMaxValue.Caption = "MaxValue";
			this.colMaxValue.FieldName = "MaxValue";
			this.colMaxValue.Name = "colMaxValue";
			this.colMaxValue.OptionsColumn.AllowEdit = false;
			// 
			// colReal1
			// 
			this.colReal1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colReal1.AppearanceCell.Options.UseFont = true;
			this.colReal1.AppearanceCell.Options.UseTextOptions = true;
			this.colReal1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colReal1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colReal1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colReal1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colReal1.AppearanceHeader.Options.UseFont = true;
			this.colReal1.AppearanceHeader.Options.UseTextOptions = true;
			this.colReal1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colReal1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colReal1.Caption = "Thực tế";
			this.colReal1.FieldName = "Real1";
			this.colReal1.Name = "colReal1";
			this.colReal1.Visible = true;
			this.colReal1.VisibleIndex = 4;
			this.colReal1.Width = 102;
			// 
			// colRate
			// 
			this.colRate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colRate.AppearanceCell.Options.UseFont = true;
			this.colRate.AppearanceCell.Options.UseTextOptions = true;
			this.colRate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colRate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colRate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colRate.AppearanceHeader.Options.UseFont = true;
			this.colRate.AppearanceHeader.Options.UseTextOptions = true;
			this.colRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colRate.Caption = "Đánh giá";
			this.colRate.FieldName = "Rate";
			this.colRate.Name = "colRate";
			this.colRate.OptionsColumn.AllowEdit = false;
			this.colRate.OptionsColumn.AllowFocus = false;
			this.colRate.OptionsColumn.AllowSize = false;
			this.colRate.Visible = true;
			this.colRate.VisibleIndex = 9;
			this.colRate.Width = 214;
			// 
			// colCheckValueType
			// 
			this.colCheckValueType.Caption = "CheckValueType";
			this.colCheckValueType.FieldName = "CheckValueType";
			this.colCheckValueType.Name = "colCheckValueType";
			// 
			// colFrequency
			// 
			this.colFrequency.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colFrequency.AppearanceCell.Options.UseFont = true;
			this.colFrequency.AppearanceCell.Options.UseTextOptions = true;
			this.colFrequency.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colFrequency.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colFrequency.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colFrequency.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colFrequency.AppearanceHeader.Options.UseFont = true;
			this.colFrequency.AppearanceHeader.Options.UseTextOptions = true;
			this.colFrequency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colFrequency.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colFrequency.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colFrequency.Caption = "Tần suất";
			this.colFrequency.FieldName = "Frequency";
			this.colFrequency.Name = "colFrequency";
			this.colFrequency.OptionsColumn.AllowSize = false;
			this.colFrequency.Visible = true;
			this.colFrequency.VisibleIndex = 3;
			this.colFrequency.Width = 50;
			// 
			// colReal2
			// 
			this.colReal2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colReal2.AppearanceCell.Options.UseFont = true;
			this.colReal2.AppearanceCell.Options.UseTextOptions = true;
			this.colReal2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colReal2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colReal2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colReal2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colReal2.AppearanceHeader.Options.UseFont = true;
			this.colReal2.AppearanceHeader.Options.UseTextOptions = true;
			this.colReal2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colReal2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colReal2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colReal2.Caption = "Thực tế";
			this.colReal2.FieldName = "Real2";
			this.colReal2.Name = "colReal2";
			this.colReal2.Visible = true;
			this.colReal2.VisibleIndex = 5;
			this.colReal2.Width = 116;
			// 
			// colReal3
			// 
			this.colReal3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colReal3.AppearanceCell.Options.UseFont = true;
			this.colReal3.AppearanceCell.Options.UseTextOptions = true;
			this.colReal3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colReal3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colReal3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colReal3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colReal3.AppearanceHeader.Options.UseFont = true;
			this.colReal3.AppearanceHeader.Options.UseTextOptions = true;
			this.colReal3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colReal3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colReal3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colReal3.Caption = "Thực tế";
			this.colReal3.FieldName = "Real3";
			this.colReal3.Name = "colReal3";
			this.colReal3.Visible = true;
			this.colReal3.VisibleIndex = 6;
			this.colReal3.Width = 116;
			// 
			// colReal4
			// 
			this.colReal4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colReal4.AppearanceCell.Options.UseFont = true;
			this.colReal4.AppearanceCell.Options.UseTextOptions = true;
			this.colReal4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colReal4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colReal4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colReal4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colReal4.AppearanceHeader.Options.UseFont = true;
			this.colReal4.AppearanceHeader.Options.UseTextOptions = true;
			this.colReal4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colReal4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colReal4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colReal4.Caption = "Thực tế";
			this.colReal4.FieldName = "Real4";
			this.colReal4.Name = "colReal4";
			this.colReal4.Visible = true;
			this.colReal4.VisibleIndex = 7;
			this.colReal4.Width = 116;
			// 
			// colReal5
			// 
			this.colReal5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colReal5.AppearanceCell.Options.UseFont = true;
			this.colReal5.AppearanceCell.Options.UseTextOptions = true;
			this.colReal5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colReal5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colReal5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colReal5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colReal5.AppearanceHeader.Options.UseFont = true;
			this.colReal5.AppearanceHeader.Options.UseTextOptions = true;
			this.colReal5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colReal5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colReal5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colReal5.Caption = "Thực tế";
			this.colReal5.FieldName = "Real5";
			this.colReal5.Name = "colReal5";
			this.colReal5.Visible = true;
			this.colReal5.VisibleIndex = 8;
			this.colReal5.Width = 116;
			// 
			// colValueType
			// 
			this.colValueType.Caption = "ValueType";
			this.colValueType.FieldName = "ValueType";
			this.colValueType.Name = "colValueType";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.RoyalBlue;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(1, 1);
			this.label1.Margin = new System.Windows.Forms.Padding(1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 39);
			this.label1.TabIndex = 90;
			this.label1.Text = "PHỤ TRÁCH";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.RoyalBlue;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(1, 42);
			this.label2.Margin = new System.Windows.Forms.Padding(1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 39);
			this.label2.TabIndex = 91;
			this.label2.Text = "MÃ DỤNG CỤ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.RoyalBlue;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(418, 1);
			this.label3.Margin = new System.Windows.Forms.Padding(1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 39);
			this.label3.TabIndex = 92;
			this.label3.Text = "BỘ PHẬN";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.RoyalBlue;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(418, 42);
			this.label5.Margin = new System.Windows.Forms.Padding(1);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(155, 39);
			this.label5.TabIndex = 94;
			this.label5.Text = "CÔNG ĐOẠN";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.RoyalBlue;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(785, 1);
			this.label6.Margin = new System.Windows.Forms.Padding(1);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(242, 39);
			this.label6.TabIndex = 95;
			this.label6.Text = "THỜI GIAN";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pannelBot
			// 
			this.pannelBot.Controls.Add(this.menuStrip1);
			this.pannelBot.Controls.Add(this.btnSave);
			this.pannelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pannelBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.pannelBot.Location = new System.Drawing.Point(0, 522);
			this.pannelBot.Margin = new System.Windows.Forms.Padding(2);
			this.pannelBot.Name = "pannelBot";
			this.pannelBot.Size = new System.Drawing.Size(1254, 77);
			this.pannelBot.TabIndex = 8;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(612, 26);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(31, 24);
			this.menuStrip1.TabIndex = 17;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// aToolStripMenuItem
			// 
			this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cấtToolStripMenuItem,
            this.startRiskToolStripMenuItem,
            this.endRiskToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.setWeightToolStripMenuItem});
			this.aToolStripMenuItem.Name = "aToolStripMenuItem";
			this.aToolStripMenuItem.Size = new System.Drawing.Size(25, 22);
			this.aToolStripMenuItem.Text = "a";
			// 
			// cấtToolStripMenuItem
			// 
			this.cấtToolStripMenuItem.Name = "cấtToolStripMenuItem";
			this.cấtToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
			this.cấtToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.cấtToolStripMenuItem.Text = "Cất";
			this.cấtToolStripMenuItem.Click += new System.EventHandler(this.cấtToolStripMenuItem_Click);
			// 
			// startRiskToolStripMenuItem
			// 
			this.startRiskToolStripMenuItem.Name = "startRiskToolStripMenuItem";
			this.startRiskToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
			this.startRiskToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.startRiskToolStripMenuItem.Text = "StartRisk";
			// 
			// endRiskToolStripMenuItem
			// 
			this.endRiskToolStripMenuItem.Name = "endRiskToolStripMenuItem";
			this.endRiskToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
			this.endRiskToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.endRiskToolStripMenuItem.Text = "EndRisk";
			// 
			// loginToolStripMenuItem
			// 
			this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			this.loginToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
			this.loginToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.loginToolStripMenuItem.Text = "Login";
			// 
			// setWeightToolStripMenuItem
			// 
			this.setWeightToolStripMenuItem.Name = "setWeightToolStripMenuItem";
			this.setWeightToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
			this.setWeightToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.setWeightToolStripMenuItem.Text = "SetWeight";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(1095, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(154, 33);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "CẤT DỮ LIỆU";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cbPart
			// 
			this.cbPart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPart.FormattingEnabled = true;
			this.cbPart.Location = new System.Drawing.Point(575, 1);
			this.cbPart.Margin = new System.Windows.Forms.Padding(1);
			this.cbPart.Name = "cbPart";
			this.cbPart.Size = new System.Drawing.Size(208, 41);
			this.cbPart.TabIndex = 99;
			this.cbPart.SelectedIndexChanged += new System.EventHandler(this.cbPart_SelectedIndexChanged);
			this.cbPart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPart_KeyDown);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.56039F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.74641F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.45774F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.78309F));
			this.tableLayoutPanel1.Controls.Add(this.dtpFrequencyCheck, 5, 1);
			this.tableLayoutPanel1.Controls.Add(this.label7, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtWorker, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.cbPart, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtDateTime, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtJigCode, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.cboStep, 3, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1254, 124);
			this.tableLayoutPanel1.TabIndex = 102;
			// 
			// dtpFrequencyCheck
			// 
			this.dtpFrequencyCheck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtpFrequencyCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFrequencyCheck.Location = new System.Drawing.Point(1029, 42);
			this.dtpFrequencyCheck.Margin = new System.Windows.Forms.Padding(1);
			this.dtpFrequencyCheck.Name = "dtpFrequencyCheck";
			this.dtpFrequencyCheck.Size = new System.Drawing.Size(224, 40);
			this.dtpFrequencyCheck.TabIndex = 103;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.RoyalBlue;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(785, 42);
			this.label7.Margin = new System.Windows.Forms.Padding(1);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(242, 39);
			this.label7.TabIndex = 104;
			this.label7.Text = "THỜI GIAN KIỂM TRA TIẾP THEO";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtDescription
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 5);
			this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescription.Location = new System.Drawing.Point(146, 83);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(1);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.Size = new System.Drawing.Size(1107, 40);
			this.txtDescription.TabIndex = 104;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.RoyalBlue;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(1, 83);
			this.label4.Margin = new System.Windows.Forms.Padding(1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 40);
			this.label4.TabIndex = 103;
			this.label4.Text = "MÔ TẢ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmMeasuringToolLine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1254, 599);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.pannelBot);
			this.Controls.Add(this.grdData);
			this.Name = "frmMeasuringToolLine";
			this.Text = "ĐIỀU KIỆN KIỂM TRA DỤNG CỤ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
			this.pannelBot.ResumeLayout(false);
			this.pannelBot.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.TextBox txtDateTime;
		private System.Windows.Forms.ComboBox cboStep;
		private System.Windows.Forms.TextBox txtJigCode;
		private System.Windows.Forms.TextBox txtWorker;
		private DevExpress.XtraGrid.GridControl grdData;
		private DevExpress.XtraGrid.Views.Grid.GridView grvData;
		private DevExpress.XtraGrid.Columns.GridColumn colProductWorkingName;
		private DevExpress.XtraGrid.Columns.GridColumn colStandardValue;
		private DevExpress.XtraGrid.Columns.GridColumn colMinValue;
		private DevExpress.XtraGrid.Columns.GridColumn colMaxValue;
		private DevExpress.XtraGrid.Columns.GridColumn colSortOrder;
		private DevExpress.XtraGrid.Columns.GridColumn colReal1;
		private DevExpress.XtraGrid.Columns.GridColumn colRate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel pannelBot;
		private DevExpress.XtraGrid.Columns.GridColumn colCheckValueType;
		private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
		private System.Windows.Forms.ComboBox cbPart;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private DevExpress.XtraGrid.Columns.GridColumn colFrequency;
		private DevExpress.XtraGrid.Columns.GridColumn colReal2;
		private DevExpress.XtraGrid.Columns.GridColumn colReal3;
		private DevExpress.XtraGrid.Columns.GridColumn colReal4;
		private DevExpress.XtraGrid.Columns.GridColumn colReal5;
		private DevExpress.XtraGrid.Columns.GridColumn colValueType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cấtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startRiskToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem endRiskToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setWeightToolStripMenuItem;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox dtpFrequencyCheck;
		private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
	}
}

