
namespace BMS
{
	partial class frmAddEditJig
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditJig));
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.btnSaveClose = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSaveNew = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.catVaThemOiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.cbJigCha = new System.Windows.Forms.ComboBox();
			this.cWorker = new DevExpress.XtraEditors.LookUpEdit();
			this.txtPart = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtQty = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtJigCode = new System.Windows.Forms.TextBox();
			this.txtJigName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.mnuMenu.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cWorker.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
			this.SuspendLayout();
			// 
			// mnuMenu
			// 
			this.mnuMenu.AutoSize = false;
			this.mnuMenu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.mnuMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveClose,
            this.toolStripSeparator2,
            this.btnSaveNew});
			this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.mnuMenu.Location = new System.Drawing.Point(0, 0);
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMenu.Size = new System.Drawing.Size(746, 41);
			this.mnuMenu.TabIndex = 226;
			this.mnuMenu.Text = "toolStrip2";
			// 
			// btnSaveClose
			// 
			this.btnSaveClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnSaveClose.ForeColor = System.Drawing.Color.Black;
			this.btnSaveClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClose.Image")));
			this.btnSaveClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSaveClose.Name = "btnSaveClose";
			this.btnSaveClose.Size = new System.Drawing.Size(94, 41);
			this.btnSaveClose.Tag = "frmProduct_AddProductH";
			this.btnSaveClose.Text = "Cất && Đóng";
			this.btnSaveClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
			// 
			// btnSaveNew
			// 
			this.btnSaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnSaveNew.ForeColor = System.Drawing.Color.Black;
			this.btnSaveNew.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveNew.Image")));
			this.btnSaveNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSaveNew.Name = "btnSaveNew";
			this.btnSaveNew.Size = new System.Drawing.Size(126, 41);
			this.btnSaveNew.Tag = "frmProduct_AddProductH";
			this.btnSaveNew.Text = "Cất && Thêm mới";
			this.btnSaveNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cấtToolStripMenuItem,
            this.catVaThemOiToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(366, 9);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(139, 24);
			this.menuStrip1.TabIndex = 229;
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
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.2533F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.7467F));
			this.tableLayoutPanel3.Controls.Add(this.cbJigCha, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.cWorker, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.txtPart, 1, 4);
			this.tableLayoutPanel3.Controls.Add(this.txtDescription, 1, 5);
			this.tableLayoutPanel3.Controls.Add(this.txtQty, 1, 6);
			this.tableLayoutPanel3.Controls.Add(this.label7, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.label6, 0, 6);
			this.tableLayoutPanel3.Controls.Add(this.label4, 0, 5);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.txtJigCode, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.txtJigName, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.label3, 0, 4);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 43);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 7;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(742, 335);
			this.tableLayoutPanel3.TabIndex = 230;
			// 
			// cbJigCha
			// 
			this.cbJigCha.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbJigCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbJigCha.FormattingEnabled = true;
			this.cbJigCha.Location = new System.Drawing.Point(249, 97);
			this.cbJigCha.Margin = new System.Windows.Forms.Padding(0);
			this.cbJigCha.Name = "cbJigCha";
			this.cbJigCha.Size = new System.Drawing.Size(490, 45);
			this.cbJigCha.TabIndex = 239;
			this.cbJigCha.SelectedIndexChanged += new System.EventHandler(this.cbJigCha_SelectedIndexChanged);
			// 
			// cWorker
			// 
			this.cWorker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cWorker.Location = new System.Drawing.Point(249, 144);
			this.cWorker.Margin = new System.Windows.Forms.Padding(0);
			this.cWorker.Name = "cWorker";
			this.cWorker.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
			this.cWorker.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.cWorker.Properties.Appearance.Options.UseFont = true;
			this.cWorker.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cWorker.Properties.AppearanceDropDown.Options.UseFont = true;
			this.cWorker.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cWorker.Properties.AppearanceDropDownHeader.Options.UseFont = true;
			this.cWorker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cWorker.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserCode", "User Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentCode", "Department Code")});
			this.cWorker.Properties.NullText = "";
			this.cWorker.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.cWorker.Properties.UseCtrlScroll = true;
			this.cWorker.Size = new System.Drawing.Size(490, 44);
			this.cWorker.TabIndex = 231;
			this.cWorker.EditValueChanged += new System.EventHandler(this.cWorker_EditValueChanged);
			// 
			// txtPart
			// 
			this.txtPart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPart.BackColor = System.Drawing.Color.White;
			this.txtPart.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.txtPart.Location = new System.Drawing.Point(249, 191);
			this.txtPart.Margin = new System.Windows.Forms.Padding(0);
			this.txtPart.Name = "txtPart";
			this.txtPart.ReadOnly = true;
			this.txtPart.Size = new System.Drawing.Size(490, 44);
			this.txtPart.TabIndex = 231;
			this.txtPart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPart_KeyDown);
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.BackColor = System.Drawing.Color.White;
			this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.txtDescription.Location = new System.Drawing.Point(249, 238);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(0);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(490, 44);
			this.txtDescription.TabIndex = 230;
			this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
			// 
			// txtQty
			// 
			this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQty.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.txtQty.Location = new System.Drawing.Point(249, 285);
			this.txtQty.Margin = new System.Windows.Forms.Padding(0);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(490, 44);
			this.txtQty.TabIndex = 236;
			this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.label7.ForeColor = System.Drawing.Color.Navy;
			this.label7.Location = new System.Drawing.Point(3, 97);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(243, 44);
			this.label7.TabIndex = 237;
			this.label7.Text = "Jig Cha";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.label6.ForeColor = System.Drawing.Color.Navy;
			this.label6.Location = new System.Drawing.Point(3, 285);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(243, 47);
			this.label6.TabIndex = 233;
			this.label6.Text = "Q\'ty";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.label4.ForeColor = System.Drawing.Color.Navy;
			this.label4.Location = new System.Drawing.Point(3, 238);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(243, 44);
			this.label4.TabIndex = 231;
			this.label4.Text = "Mô tả";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(3, 3);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(243, 44);
			this.label2.TabIndex = 218;
			this.label2.Text = "Mã Jig";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtJigCode
			// 
			this.txtJigCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtJigCode.BackColor = System.Drawing.Color.White;
			this.txtJigCode.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtJigCode.Location = new System.Drawing.Point(249, 3);
			this.txtJigCode.Margin = new System.Windows.Forms.Padding(0);
			this.txtJigCode.Name = "txtJigCode";
			this.txtJigCode.Size = new System.Drawing.Size(490, 44);
			this.txtJigCode.TabIndex = 217;
			this.txtJigCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtJigCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJigCode_KeyDown);
			// 
			// txtJigName
			// 
			this.txtJigName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtJigName.BackColor = System.Drawing.Color.White;
			this.txtJigName.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.txtJigName.Location = new System.Drawing.Point(249, 50);
			this.txtJigName.Margin = new System.Windows.Forms.Padding(0);
			this.txtJigName.Name = "txtJigName";
			this.txtJigName.Size = new System.Drawing.Size(490, 44);
			this.txtJigName.TabIndex = 228;
			this.txtJigName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtJigName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJigName_KeyDown);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.label5.ForeColor = System.Drawing.Color.Navy;
			this.label5.Location = new System.Drawing.Point(3, 50);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(243, 44);
			this.label5.TabIndex = 221;
			this.label5.Text = "Tên Jig";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(3, 144);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 44);
			this.label1.TabIndex = 225;
			this.label1.Text = "Người nhập";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.label3.ForeColor = System.Drawing.Color.Navy;
			this.label3.Location = new System.Drawing.Point(3, 191);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(243, 44);
			this.label3.TabIndex = 229;
			this.label3.Text = "Bộ phận";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmAddEditJig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 379);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Controls.Add(this.mnuMenu);
			this.Name = "frmAddEditJig";
			this.Text = "Jig Detail";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditKnife_FormClosing);
			this.Load += new System.EventHandler(this.frmAddEditJig_Load);
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cWorker.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip mnuMenu;
		private System.Windows.Forms.ToolStripButton btnSaveClose;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnSaveNew;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cấtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem catVaThemOiToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtJigCode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtJigName;
		private System.Windows.Forms.TextBox txtPart;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown txtQty;
		private DevExpress.XtraEditors.LookUpEdit cWorker;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbJigCha;
	}
}