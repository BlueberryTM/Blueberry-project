using iTextSharp.text.pdf.parser;
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
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void axAcroPDF1_Enter(object sender, EventArgs e)
		{

		}

		private void Form5_Load(object sender, EventArgs e)
		{
			richTextBox1.LoadFile(@"D:\Programing\BlueBerry\Welcome to Blueberry.rtf");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void axAcroPDF1_Enter_1(object sender, EventArgs e)
		{
			
		}
	}
}
