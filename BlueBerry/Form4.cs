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
            frm5.RefToForm4 = this;
            frm5.refToCheckBox = this.checkBox1;
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
			SqlConnection cn = new SqlConnection("Data Source=DESKTOP-NC0DTSG;Initial Catalog=bluberrylogin2;Integrated Security=True");
			cn.Open();

			string newcom = "insert into users2 (name,email,password,phone) VALUES ('" + namesu.Text + "','" + emailsu.Text + "','" + passwordsu.Text + "','" + phonesu.Text + "')";

			SqlCommand cmd = new SqlCommand(newcom, cn);

			cmd.ExecuteNonQuery();

			MessageBox.Show("Welcome to Blueberry");
			this.Hide();

			Form2 form2 = new Form2();
			form2.Show();
			



		}

		private void passwordsu_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Minimized;
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{
			label4.Show();
			label5.Show();
			label1.Show();
			label2.Hide();

			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		}

		private void label1_Click(object sender, EventArgs e)
		{
			label5.Hide();
			label4.Hide();
			label1.Hide();
			label2.Show();

			FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		}
	}   
	
}
