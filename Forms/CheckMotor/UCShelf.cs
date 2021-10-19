using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class UCShelf : UserControl
	{
		public string NameShelf;
		public int Qty;
		public UCShelf()
		{
			InitializeComponent();
		}

		private void UCShelf_Load(object sender, EventArgs e)
		{
			lblGia.Text = "GIÁ: " + NameShelf.Trim();
			lblSLTT.Text = "THỰC TẾ: " + TextUtilsStock.ToString(Qty);
			if (Qty == 0)
			{
				this.BackColor = System.Drawing.Color.Lime;
			}
			else
			{
				this.BackColor = System.Drawing.Color.Gray;
			}

		}
		public void LoadColor(int Qty, string Real)
		{
			if (Qty == 0)
			{
				this.BackColor = System.Drawing.Color.Lime;
			}
			else if (Real.Trim().ToUpper() == NameShelf.Trim().ToUpper() && Real.Trim().ToUpper() != "")
			{
				this.BackColor = System.Drawing.Color.Yellow;
			}
			else
			{
				this.BackColor = System.Drawing.Color.Gray;
			}
			lblSLTT.Text = "THỰC TẾ: " + TextUtilsStock.ToString(Qty);
		}
	}
}
