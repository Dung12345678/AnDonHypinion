
namespace BMS
{
    partial class frmImportMotor
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
			this.txtSerialNumber = new System.Windows.Forms.TextBox();
			this.txtLocation = new System.Windows.Forms.TextBox();
			this.txtWorker = new System.Windows.Forms.TextBox();
			this.txtRealQty = new System.Windows.Forms.TextBox();
			this.txtQtySale = new System.Windows.Forms.TextBox();
			this.txtSaleNumber = new System.Windows.Forms.TextBox();
			this.txtStep = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.tblLayout);
			this.panel2.Location = new System.Drawing.Point(1, 139);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1261, 559);
			this.panel2.TabIndex = 1;
			// 
			// tblLayout
			// 
			this.tblLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tblLayout.AutoScroll = true;
			this.tblLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tblLayout.ColumnCount = 1;
			this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tblLayout.Location = new System.Drawing.Point(0, 0);
			this.tblLayout.Margin = new System.Windows.Forms.Padding(1);
			this.tblLayout.Name = "tblLayout";
			this.tblLayout.RowCount = 1;
			this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tblLayout.Size = new System.Drawing.Size(1261, 558);
			this.tblLayout.TabIndex = 60;
			// 
			// txtSerialNumber
			// 
			this.txtSerialNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.txtSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSerialNumber.Location = new System.Drawing.Point(194, 93);
			this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(1);
			this.txtSerialNumber.Name = "txtSerialNumber";
			this.txtSerialNumber.Size = new System.Drawing.Size(193, 44);
			this.txtSerialNumber.TabIndex = 2;
			this.txtSerialNumber.TextChanged += new System.EventHandler(this.txt_TextChanged);
			this.txtSerialNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerialNumber_KeyDown);
			// 
			// txtLocation
			// 
			this.txtLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.txtLocation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLocation.Location = new System.Drawing.Point(194, 47);
			this.txtLocation.Margin = new System.Windows.Forms.Padding(1);
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.Size = new System.Drawing.Size(193, 44);
			this.txtLocation.TabIndex = 1;
			this.txtLocation.TextChanged += new System.EventHandler(this.txt_TextChanged);
			this.txtLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocation_KeyDown);
			// 
			// txtWorker
			// 
			this.txtWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.txtWorker.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWorker.Location = new System.Drawing.Point(194, 1);
			this.txtWorker.Margin = new System.Windows.Forms.Padding(1);
			this.txtWorker.Name = "txtWorker";
			this.txtWorker.Size = new System.Drawing.Size(193, 44);
			this.txtWorker.TabIndex = 0;
			this.txtWorker.TextChanged += new System.EventHandler(this.txt_TextChanged);
			this.txtWorker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorker_KeyDown);
			// 
			// txtRealQty
			// 
			this.txtRealQty.BackColor = System.Drawing.Color.White;
			this.txtRealQty.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtRealQty.Enabled = false;
			this.txtRealQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRealQty.Location = new System.Drawing.Point(1196, 47);
			this.txtRealQty.Margin = new System.Windows.Forms.Padding(1);
			this.txtRealQty.Name = "txtRealQty";
			this.txtRealQty.Size = new System.Drawing.Size(65, 44);
			this.txtRealQty.TabIndex = 15;
			this.txtRealQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtRealQty.TextChanged += new System.EventHandler(this.txt_TextChanged);
			// 
			// txtQtySale
			// 
			this.txtQtySale.BackColor = System.Drawing.Color.White;
			this.txtQtySale.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtQtySale.Enabled = false;
			this.txtQtySale.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQtySale.Location = new System.Drawing.Point(898, 47);
			this.txtQtySale.Margin = new System.Windows.Forms.Padding(1);
			this.txtQtySale.Name = "txtQtySale";
			this.txtQtySale.Size = new System.Drawing.Size(66, 44);
			this.txtQtySale.TabIndex = 17;
			this.txtQtySale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtQtySale.TextChanged += new System.EventHandler(this.txt_TextChanged);
			// 
			// txtSaleNumber
			// 
			this.txtSaleNumber.BackColor = System.Drawing.Color.White;
			this.txtSaleNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSaleNumber.Enabled = false;
			this.txtSaleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSaleNumber.Location = new System.Drawing.Point(525, 47);
			this.txtSaleNumber.Margin = new System.Windows.Forms.Padding(1);
			this.txtSaleNumber.Name = "txtSaleNumber";
			this.txtSaleNumber.Size = new System.Drawing.Size(175, 44);
			this.txtSaleNumber.TabIndex = 19;
			this.txtSaleNumber.TextChanged += new System.EventHandler(this.txt_TextChanged);
			// 
			// txtStep
			// 
			this.txtStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.txtStep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStep.Location = new System.Drawing.Point(525, 1);
			this.txtStep.Margin = new System.Windows.Forms.Padding(1);
			this.txtStep.Name = "txtStep";
			this.txtStep.Size = new System.Drawing.Size(175, 44);
			this.txtStep.TabIndex = 21;
			this.txtStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtStep.TextChanged += new System.EventHandler(this.txt_TextChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 8;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.29319F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.45166F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.77655F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.02536F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.5309F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.388273F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.22504F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.229794F));
			this.tableLayoutPanel1.Controls.Add(this.label5, 6, 1);
			this.tableLayoutPanel1.Controls.Add(this.label6, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtRealQty, 7, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtQtySale, 5, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtSaleNumber, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtStep, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtWorker, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtLocation, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtSerialNumber, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1262, 139);
			this.tableLayoutPanel1.TabIndex = 23;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.MediumBlue;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(966, 47);
			this.label5.Margin = new System.Windows.Forms.Padding(1);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(228, 44);
			this.label5.TabIndex = 65;
			this.label5.Text = "SỐ LƯỢNG ĐÃ NHẬP KHO\r\n";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.UseCompatibleTextRendering = true;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.MediumBlue;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(702, 47);
			this.label6.Margin = new System.Windows.Forms.Padding(1);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(194, 44);
			this.label6.TabIndex = 66;
			this.label6.Text = "SỐ LƯỢNG THEO SALE\r\n";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.UseCompatibleTextRendering = true;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.MediumBlue;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(389, 47);
			this.label7.Margin = new System.Windows.Forms.Padding(1);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(134, 44);
			this.label7.TabIndex = 67;
			this.label7.Text = "SALE NUMBER\r\n";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label7.UseCompatibleTextRendering = true;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.MediumBlue;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(1, 93);
			this.label2.Margin = new System.Windows.Forms.Padding(1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(191, 45);
			this.label2.TabIndex = 62;
			this.label2.Text = "NHẬP SERIAL NUMBER\r\n";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.UseCompatibleTextRendering = true;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.MediumBlue;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(1, 47);
			this.label3.Margin = new System.Windows.Forms.Padding(1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(191, 44);
			this.label3.TabIndex = 63;
			this.label3.Text = "NHẬP VỊ TRÍ GIÁ\r\n";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.UseCompatibleTextRendering = true;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MediumBlue;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(1, 1);
			this.label1.Margin = new System.Windows.Forms.Padding(1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 44);
			this.label1.TabIndex = 61;
			this.label1.Text = "NHÂN VIÊN";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.UseCompatibleTextRendering = true;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.MediumBlue;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(389, 1);
			this.label4.Margin = new System.Windows.Forms.Padding(1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 44);
			this.label4.TabIndex = 64;
			this.label4.Text = "CÔNG ĐOẠN\r\n";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.UseCompatibleTextRendering = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(1096, 704);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(154, 33);
			this.btnSave.TabIndex = 24;
			this.btnSave.Text = "CẤT DỮ LIỆU";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
			// 
			// frmImportMotor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1262, 749);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.panel2);
			this.Name = "frmImportMotor";
			this.Text = "NHẬP KHO MOTOR";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmHypMeasuringTools_Load);
			this.panel2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtWorker;
		private System.Windows.Forms.TextBox txtLocation;
		private System.Windows.Forms.TextBox txtSerialNumber;
		private System.Windows.Forms.TextBox txtRealQty;
		private System.Windows.Forms.TextBox txtQtySale;
		private System.Windows.Forms.TextBox txtSaleNumber;
		private System.Windows.Forms.TextBox txtStep;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tblLayout;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}