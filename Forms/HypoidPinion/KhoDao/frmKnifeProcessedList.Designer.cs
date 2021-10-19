
namespace BMS
{
	partial class frmKnifeProcessedList
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
			this.dtgvKnifeProcessedList = new DevExpress.XtraGrid.GridControl();
			this.gvKnifeProcessedList = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKnifeCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWorkerID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKnifeID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtWorker = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cboPart = new DevExpress.XtraEditors.LookUpEdit();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMachine = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtOrderCode = new System.Windows.Forms.TextBox();
			this.txbGoodsCode = new System.Windows.Forms.TextBox();
			this.txtKnifeList = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.catVaThemOiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtgvKnifeProcessedList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvKnifeProcessedList)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboPart.Properties)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtgvKnifeProcessedList
			// 
			this.dtgvKnifeProcessedList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvKnifeProcessedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvKnifeProcessedList.Location = new System.Drawing.Point(0, 92);
			this.dtgvKnifeProcessedList.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
			this.dtgvKnifeProcessedList.MainView = this.gvKnifeProcessedList;
			this.dtgvKnifeProcessedList.Name = "dtgvKnifeProcessedList";
			this.dtgvKnifeProcessedList.Size = new System.Drawing.Size(984, 537);
			this.dtgvKnifeProcessedList.TabIndex = 0;
			this.dtgvKnifeProcessedList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKnifeProcessedList});
			// 
			// gvKnifeProcessedList
			// 
			this.gvKnifeProcessedList.ColumnPanelRowHeight = 40;
			this.gvKnifeProcessedList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKnifeCode,
            this.colSTT,
            this.colWorkerID,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn3,
            this.colStatus,
            this.colKnifeID});
			this.gvKnifeProcessedList.GridControl = this.dtgvKnifeProcessedList;
			this.gvKnifeProcessedList.Name = "gvKnifeProcessedList";
			this.gvKnifeProcessedList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvKnifeProcessedList.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvKnifeProcessedList.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvKnifeProcessedList.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvKnifeProcessedList.OptionsBehavior.Editable = false;
			this.gvKnifeProcessedList.OptionsCustomization.AllowColumnMoving = false;
			this.gvKnifeProcessedList.OptionsCustomization.AllowQuickHideColumns = false;
			this.gvKnifeProcessedList.OptionsFind.ShowCloseButton = false;
			this.gvKnifeProcessedList.OptionsView.ShowGroupPanel = false;
			this.gvKnifeProcessedList.RowHeight = 25;
			this.gvKnifeProcessedList.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
			this.gvKnifeProcessedList.DoubleClick += new System.EventHandler(this.gvKnifeProcessedList_DoubleClick);
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colKnifeCode
			// 
			this.colKnifeCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colKnifeCode.AppearanceCell.Options.UseFont = true;
			this.colKnifeCode.AppearanceCell.Options.UseTextOptions = true;
			this.colKnifeCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colKnifeCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colKnifeCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colKnifeCode.AppearanceHeader.Options.UseFont = true;
			this.colKnifeCode.AppearanceHeader.Options.UseForeColor = true;
			this.colKnifeCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colKnifeCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKnifeCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colKnifeCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colKnifeCode.Caption = "MÃ DAO";
			this.colKnifeCode.FieldName = "KnifeCode";
			this.colKnifeCode.Name = "colKnifeCode";
			this.colKnifeCode.OptionsColumn.AllowEdit = false;
			this.colKnifeCode.Visible = true;
			this.colKnifeCode.VisibleIndex = 0;
			this.colKnifeCode.Width = 110;
			// 
			// colSTT
			// 
			this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colSTT.AppearanceCell.Options.UseFont = true;
			this.colSTT.AppearanceCell.Options.UseTextOptions = true;
			this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colSTT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colSTT.AppearanceHeader.Options.UseFont = true;
			this.colSTT.AppearanceHeader.Options.UseForeColor = true;
			this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
			this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTT.Caption = "STT";
			this.colSTT.FieldName = "STT";
			this.colSTT.Name = "colSTT";
			this.colSTT.Width = 173;
			// 
			// colWorkerID
			// 
			this.colWorkerID.Caption = "gridColumn1";
			this.colWorkerID.FieldName = "WorkerID";
			this.colWorkerID.Name = "colWorkerID";
			// 
			// gridColumn5
			// 
			this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.gridColumn5.AppearanceCell.Options.UseFont = true;
			this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.gridColumn5.AppearanceHeader.Options.UseFont = true;
			this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn5.Caption = "NGƯỜI GIA CÔNG";
			this.gridColumn5.FieldName = "Worker";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 2;
			this.gridColumn5.Width = 121;
			// 
			// gridColumn6
			// 
			this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.gridColumn6.AppearanceCell.Options.UseFont = true;
			this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.gridColumn6.AppearanceHeader.Options.UseFont = true;
			this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn6.Caption = "BỘ PHẬN";
			this.gridColumn6.FieldName = "PartName";
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.Visible = true;
			this.gridColumn6.VisibleIndex = 3;
			this.gridColumn6.Width = 125;
			// 
			// gridColumn2
			// 
			this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.gridColumn2.AppearanceCell.Options.UseFont = true;
			this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.gridColumn2.AppearanceHeader.Options.UseFont = true;
			this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn2.Caption = "NGÀY GIA CÔNG";
			this.gridColumn2.FieldName = "DateProcess";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 7;
			this.gridColumn2.Width = 145;
			// 
			// gridColumn1
			// 
			this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.gridColumn1.AppearanceCell.Options.UseFont = true;
			this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.gridColumn1.AppearanceHeader.Options.UseFont = true;
			this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.gridColumn1.Caption = "SỐ LƯỢNG";
			this.gridColumn1.FieldName = "Quantity";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 6;
			this.gridColumn1.Width = 78;
			// 
			// gridColumn4
			// 
			this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.gridColumn4.AppearanceCell.Options.UseFont = true;
			this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.gridColumn4.AppearanceHeader.Options.UseFont = true;
			this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.gridColumn4.Caption = "MÃ MÁY";
			this.gridColumn4.FieldName = "MachineCode";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 4;
			this.gridColumn4.Width = 113;
			// 
			// gridColumn3
			// 
			this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.gridColumn3.AppearanceCell.Options.UseFont = true;
			this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.gridColumn3.AppearanceHeader.Options.UseFont = true;
			this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
			this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.gridColumn3.Caption = "MÃ HÀNG";
			this.gridColumn3.FieldName = "GoodsCode";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 5;
			this.gridColumn3.Width = 105;
			// 
			// colStatus
			// 
			this.colStatus.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colStatus.AppearanceCell.Options.UseFont = true;
			this.colStatus.AppearanceCell.Options.UseTextOptions = true;
			this.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStatus.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colStatus.AppearanceHeader.Options.UseFont = true;
			this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
			this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStatus.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colStatus.Caption = "TÌNH TRẠNG";
			this.colStatus.FieldName = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 1;
			this.colStatus.Width = 69;
			// 
			// colKnifeID
			// 
			this.colKnifeID.Caption = "gridColumn7";
			this.colKnifeID.FieldName = "KnifeID";
			this.colKnifeID.Name = "colKnifeID";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Controls.Add(this.txtWorker, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.cboPart, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtMachine, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label4, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtOrderCode, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.txbGoodsCode, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtKnifeList, 5, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 91);
			this.tableLayoutPanel1.TabIndex = 43;
			// 
			// txtWorker
			// 
			this.txtWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.txtWorker.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWorker.Location = new System.Drawing.Point(165, 2);
			this.txtWorker.Margin = new System.Windows.Forms.Padding(0);
			this.txtWorker.Name = "txtWorker";
			this.txtWorker.Size = new System.Drawing.Size(161, 43);
			this.txtWorker.TabIndex = 0;
			this.txtWorker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtWorker.TextChanged += new System.EventHandler(this.txtWorker_TextChanged);
			this.txtWorker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorker_KeyDown);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Blue;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(2, 2);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 42);
			this.label1.TabIndex = 7;
			this.label1.Text = "NGƯỜI GIA CÔNG";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Blue;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(328, 2);
			this.label8.Margin = new System.Windows.Forms.Padding(0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(161, 42);
			this.label8.TabIndex = 10;
			this.label8.Text = "BỘ PHẬN";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Blue;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(2, 46);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 43);
			this.label2.TabIndex = 8;
			this.label2.Text = "MÃ ORDER";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cboPart
			// 
			this.cboPart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboPart.Location = new System.Drawing.Point(491, 2);
			this.cboPart.Margin = new System.Windows.Forms.Padding(0);
			this.cboPart.Name = "cboPart";
			this.cboPart.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
			this.cboPart.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.cboPart.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboPart.Properties.Appearance.Options.UseBackColor = true;
			this.cboPart.Properties.Appearance.Options.UseFont = true;
			this.cboPart.Properties.Appearance.Options.UseTextOptions = true;
			this.cboPart.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.cboPart.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboPart.Properties.AppearanceDropDown.Options.UseFont = true;
			this.cboPart.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboPart.Properties.AppearanceDropDownHeader.Options.UseFont = true;
			this.cboPart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cboPart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cboPart.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name42", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartCode", "Mã bộ phận"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartName", "Tên bộ phận")});
			this.cboPart.Properties.NullText = "";
			this.cboPart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.cboPart.Properties.UseCtrlScroll = true;
			this.cboPart.Size = new System.Drawing.Size(161, 44);
			this.cboPart.TabIndex = 1;
			this.cboPart.EditValueChanged += new System.EventHandler(this.cWorker_EditValueChanged);
			this.cboPart.Leave += new System.EventHandler(this.cWorker_Leave);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Blue;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(654, 2);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(161, 42);
			this.label6.TabIndex = 12;
			this.label6.Text = "MÁY GIA CÔNG";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtMachine
			// 
			this.txtMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.txtMachine.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMachine.Location = new System.Drawing.Point(817, 2);
			this.txtMachine.Margin = new System.Windows.Forms.Padding(0);
			this.txtMachine.Name = "txtMachine";
			this.txtMachine.Size = new System.Drawing.Size(165, 43);
			this.txtMachine.TabIndex = 2;
			this.txtMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtMachine.TextChanged += new System.EventHandler(this.txtMachine_TextChanged);
			this.txtMachine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMachine_KeyDown);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Blue;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(328, 46);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(161, 43);
			this.label5.TabIndex = 11;
			this.label5.Text = "MÃ HÀNG";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Blue;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(654, 46);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(161, 43);
			this.label4.TabIndex = 13;
			this.label4.Text = "MÃ DAO";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtOrderCode
			// 
			this.txtOrderCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.txtOrderCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOrderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOrderCode.Location = new System.Drawing.Point(165, 46);
			this.txtOrderCode.Margin = new System.Windows.Forms.Padding(0);
			this.txtOrderCode.Name = "txtOrderCode";
			this.txtOrderCode.Size = new System.Drawing.Size(161, 43);
			this.txtOrderCode.TabIndex = 3;
			this.txtOrderCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOrderCode.TextChanged += new System.EventHandler(this.txbDepartmentCode_TextChanged);
			this.txtOrderCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrder_KeyDown);
			// 
			// txbGoodsCode
			// 
			this.txbGoodsCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.txbGoodsCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txbGoodsCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbGoodsCode.Location = new System.Drawing.Point(491, 46);
			this.txbGoodsCode.Margin = new System.Windows.Forms.Padding(0);
			this.txbGoodsCode.Name = "txbGoodsCode";
			this.txbGoodsCode.Size = new System.Drawing.Size(161, 43);
			this.txbGoodsCode.TabIndex = 4;
			this.txbGoodsCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txbGoodsCode.TextChanged += new System.EventHandler(this.txbGoodsCode_TextChanged);
			this.txbGoodsCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbGoodsCode_KeyDown);
			// 
			// txtKnifeList
			// 
			this.txtKnifeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.txtKnifeList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtKnifeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKnifeList.Location = new System.Drawing.Point(817, 46);
			this.txtKnifeList.Margin = new System.Windows.Forms.Padding(0);
			this.txtKnifeList.Name = "txtKnifeList";
			this.txtKnifeList.Size = new System.Drawing.Size(165, 43);
			this.txtKnifeList.TabIndex = 5;
			this.txtKnifeList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtKnifeList.TextChanged += new System.EventHandler(this.txtKnifeList_TextChanged);
			this.txtKnifeList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKnifeList_KeyDown);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cấtToolStripMenuItem,
            this.catVaThemOiToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(507, 289);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(139, 24);
			this.menuStrip1.TabIndex = 230;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// cấtToolStripMenuItem
			// 
			this.cấtToolStripMenuItem.Name = "cấtToolStripMenuItem";
			this.cấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cấtToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.cấtToolStripMenuItem.Text = "Cất";
			this.cấtToolStripMenuItem.Click += new System.EventHandler(this.cấtToolStripMenuItem_Click);
			// 
			// catVaThemOiToolStripMenuItem
			// 
			this.catVaThemOiToolStripMenuItem.Name = "catVaThemOiToolStripMenuItem";
			this.catVaThemOiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.catVaThemOiToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.catVaThemOiToolStripMenuItem.Text = "Cat va them oi";
			this.catVaThemOiToolStripMenuItem.Click += new System.EventHandler(this.catVaThemOiToolStripMenuItem_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 700;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnSave.Location = new System.Drawing.Point(848, 635);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(134, 37);
			this.btnSave.TabIndex = 231;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmKnifeProcessedList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 675);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.dtgvKnifeProcessedList);
			this.Name = "frmKnifeProcessedList";
			this.Text = "QUẢN LÝ GIA CÔNG DAO";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKnifeSharpenList_FormClosing);
			this.Load += new System.EventHandler(this.frmKnifeSharpenList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgvKnifeProcessedList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvKnifeProcessedList)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboPart.Properties)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraGrid.GridControl dtgvKnifeProcessedList;
		private DevExpress.XtraGrid.Views.Grid.GridView gvKnifeProcessedList;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colKnifeCode;
		private DevExpress.XtraGrid.Columns.GridColumn colSTT;
		private DevExpress.XtraGrid.Columns.GridColumn colWorkerID;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txbGoodsCode;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private DevExpress.XtraEditors.LookUpEdit cboPart;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cấtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem catVaThemOiToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox txtOrderCode;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn colKnifeID;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private System.Windows.Forms.TextBox txtKnifeList;
		private System.Windows.Forms.TextBox txtWorker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMachine;
		private System.Windows.Forms.Button btnSave;
	}
}