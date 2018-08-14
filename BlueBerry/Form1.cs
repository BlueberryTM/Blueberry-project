using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueBerry
{
	public partial class BlueBerry : Form
	{
		public BlueBerry()
		{
			InitializeComponent();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{

			progressBar1.Increment(1);

			if(progressBar1.Value == 100)
			{
				timer1.Stop();

				Form2 frm = new Form2();
				frm.Show();
				this.Hide();
			}
		}
		private void progressBar1_Click(object sender, EventArgs e)
		{

		}

		private void BlueBerry_Load(object sender, EventArgs e)
		{

		}
	}
}
