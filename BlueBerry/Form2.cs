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
	public partial class Form2 : Form
	{
		SqlConnection cn;
		string connectionString = @"Data Source=DESKTOP-NC0DTSG;Initial Catalog=blueberry1;Integrated Security=True";
		public Form2()
		{
			InitializeComponent();
		}

		private void Password_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

			if (!((char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)))
			{
				if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				{
					e.Handled = true;
					label9.Show();
					toolTip2.SetToolTip(label9, "Special Characters are not allowed. (- _ % # $ @ & * ^ ~)");

				}
			}
			else
			{
				label9.Hide();
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{
			label3.Hide();
			label2.Hide();
			label1.Hide();
			label4.Show();

			FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		}

		private void label4_Click(object sender, EventArgs e)
		{
			label3.Show();
			label2.Show();
			label1.Show();
			label4.Hide();

			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		}

		private void label2_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Minimized;
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}



		private void Form2_Load(object sender, EventArgs e)
		{

		}



		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			//i copied it here so when i check it change imeditly
			if (checkBox1.Checked)
			{
				Password.UseSystemPasswordChar = true;
			}
			else
			{
				Password.UseSystemPasswordChar = false;
			}
		}

		private void Password_TextChanged(object sender, EventArgs e)
		{
			Password.UseSystemPasswordChar = true;


			if (checkBox1.Checked)
			{
				Password.UseSystemPasswordChar = true;
			}
			else
			{
				Password.UseSystemPasswordChar = false;
			}
			if (string.IsNullOrWhiteSpace(Password.Text))
			{
				Password.BackColor = Color.LightPink;
				MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK);
				Password.Focus();
			}
			else
			{
				Password.BackColor = Color.Empty;
			}
		}



		private void toolTip1_Popup(object sender, PopupEventArgs e)
		{

		}

		private void Form2_KeyDown(object sender, KeyEventArgs e)
		{
			if (Control.IsKeyLocked(Keys.CapsLock))
			{
				toolTip1.SetToolTip(label8, "Caps Lock is ON !");
				label8.Show();

			} else
			{
				label8.Hide();
			}



		}

		private void email_TextChanged(object sender, EventArgs e)
		{
			if (!this.email.Text.Contains('@') || !this.email.Text.Contains('.'))
			{
				email.BackColor = Color.LightPink;
				toolTip3.SetToolTip(email, "Please enter a Valid E-Mail !");
			} else
			{
				email.BackColor = Color.Empty;
			}
			if (string.IsNullOrWhiteSpace(email.Text))
			{
				email.BackColor = Color.LightPink;
				MessageBox.Show("Please enter a valid E-Mail", "Error", MessageBoxButtons.OK);
				email.Focus();
			} else
			{
				email.BackColor = Color.Empty;
			}
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			SqlConnection cn = new SqlConnection("Data Source=DESKTOP-NC0DTSG;Initial Catalog=bluberrylogin2;Integrated Security=True");
			cn.Open();

			SqlCommand cmd = new SqlCommand("select * from users2 where email = '"+email.Text+"' and password ='"+Password.Text+"'", cn);
			SqlDataReader dr;
			dr = cmd.ExecuteReader();
			int count = 0;
			while (dr.Read())
			{
				count += 1;
			}
			if (count == 1)
			{
				MessageBox.Show(" Welcome Back, ");
				Form3 f3 = new Form3();
				f3.Show();
				this.Hide();
			} else if (count > 0)
			{
				MessageBox.Show(" The email and password already exist !");
			}
			else
			{
				MessageBox.Show(" email or Password are Wrong. if you forgot your email or password, please contact with Blueberry Team ");
			}

		
			
         }

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form4 fr4 = new Form4();
				fr4.Show();
			this.Hide();
		}
	}

}



