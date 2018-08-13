using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BlueBerry
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void Form4_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form2 frm = new Form2();
			frm.Show();
			this.Hide();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form5 frm5 = new Form5();
			frm5.Show();
			this.Hide();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				button1.Enabled = true;
			} else if (checkBox1.Checked == false)
			{
				button1.Enabled = false;
			}
			

			
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
