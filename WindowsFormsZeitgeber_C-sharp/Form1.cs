using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsZeitgeber_C_sharp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		

		private void BT_Start_Click(object sender, EventArgs e)
		{
			LBL_Anzeige.Text = "";
			timer1.Enabled = true;
			LBL_Anzeige.Enabled = true;
		}

		private void BT_Stop_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			LBL_Anzeige.Enabled = false;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			LBL_Anzeige.Text += "X";
		}

		private void LBL_Anzeige_Click(object sender, EventArgs e)
		{

		}

		private void LBL_Anzeige_Tick(object sender, EventArgs e)
		{
			
		}
	}
}
