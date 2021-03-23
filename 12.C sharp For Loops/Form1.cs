using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12.C_sharp_For_Loops
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			//i is a variable, so its values will change from 0 to 1, 1 to 2, 2 to 3...all the way to 100
			//begin with i=0, i=progressBar1.Minimum
			//i<=progressBar1.Maximum ensures i goes all the way to 100
			//i++ is present to grow the value of i by 1 on each cycle of the loop
			for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
			{
				progressBar1.PerformStep();//this has the action of filling the bar from left to right
				richTextBox1.Text += $"{i}\n";//fills box with the values of i as loop operates
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "";//this clears the text from the rich text box
			progressBar1.Value = 0;//clears progress bar back to 0 so it's not green anymore
		}

		private void progressBar1_Click(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
